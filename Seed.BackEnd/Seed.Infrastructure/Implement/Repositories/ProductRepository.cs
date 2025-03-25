using Microsoft.EntityFrameworkCore;
using Seed.Application.DTOs.Common;
using Seed.Domain.Entities;
using Seed.Infrastructure.DB;
using Seed.Infrastructure.DTOs.Product.Read;
using Seed.Infrastructure.Implement.Repositories.Generic;
using Seed.Infrastructure.Interfaces.IRepositories;
using System.Linq.Expressions;

namespace Seed.Infrastructure.Implement.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(SeedContext context) : base(context) { }

        #region bool
        public async Task<bool> ProductNameExistsAsync(string productName)
        {
            // Check if any product exists with the specified product name
            return await _context.Products.AnyAsync(x => x.Name == productName);
        }
        #endregion

        #region Product CRUD Methods

        // Create new product
        public async Task<int> CreateProductAsync(Product product)
        {
            try
            {
                _context.Products.Add(product);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log lỗi chi tiết
                Console.WriteLine($"Error in CreateProductAsync: {ex.Message}");
                throw; // Ném lại để ProductService xử lý
            }
        }

        // Get product by ID
        public async Task<Product> GetProductByIdAsync(Guid productId)
        {
            return await _context.Products.FindAsync(productId);
        }


        public async Task<Product> GetProductByIdAsync(Guid productId, params Expression<Func<Product, object>>[] includes)
        {
            var query = _context.Products.AsQueryable();

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.FirstOrDefaultAsync(p => p.Id == productId);
        }


        // Get all products
        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _context.Products.Include(p => p.ProductCategory).ToListAsync();
        }





        public async Task<List<Product>> GetSortedProductsAsync(GetSortedProductsRequest request)
        {
            var query = _context.Products
                .Include(p => p.ProductImages)
                .AsQueryable();

            // Bước 1: Lấy sản phẩm với OccasionId (nếu có)
            List<Product> result = new List<Product>();
            Guid? targetCategoryId = null;

            if (request.OccasionId.HasValue)
            {
                var occasionProducts = await query
                    .Where(p => p.OccasionId == request.OccasionId.Value)
                    .Take(request.MaxProducts) // Giới hạn tối đa
                    .ToListAsync();

                result.AddRange(occasionProducts);

                // Lấy productCategoryId từ sản phẩm đầu tiên (nếu có)
                if (occasionProducts.Any())
                {
                    targetCategoryId = occasionProducts.First().ProductCategoryId;
                }
            }

            // Bước 2: Nếu không đủ MaxProducts, lấy thêm sản phẩm từ cùng productCategoryId
            if (result.Count < request.MaxProducts && targetCategoryId.HasValue)
            {
                int remaining = request.MaxProducts - result.Count;

                var additionalProducts = await query
                    .Where(p => p.ProductCategoryId == targetCategoryId.Value
                             && p.OccasionId != request.OccasionId) // Loại trừ sản phẩm đã lấy
                    .Take(remaining) // Chỉ lấy số lượng cần thiết
                    .ToListAsync();

                result.AddRange(additionalProducts);
            }

            // Bước 3: Trả về danh sách đã được giới hạn
            return result.Take(request.MaxProducts).ToList();
        }

        // Update product
        public async Task<int> UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            return await _context.SaveChangesAsync();
        }

        // Remove product by entity
        public async Task<bool> RemoveProductAsync(Product product)
        {
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync() > 0;
        }

        // Remove product by ID
        public async Task<bool> RemoveProductByIdAsync(Guid productId)
        {
            var product = await GetProductByIdAsync(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }

        #endregion

        #region Product-specific methods
        // Add more specific methods for Product entity here if needed
        public async Task<SearchProductResponse> GetProductsAsync(SearchProductRequest request)
        {
            var response = new SearchProductResponse
            {
                Error = Error.None // Initialize Error to None
            };

            try
            {
                var productsQuery = _context.Products.AsQueryable();

                // Filter Query
                if (!string.IsNullOrWhiteSpace(request.FilterOn) && !string.IsNullOrWhiteSpace(request.FilterQuery))
                {
                    switch (request.FilterOn.Trim().ToLower())
                    {
                        case "name":
                            // Use EF.Functions.Like for case-insensitive comparison
                            productsQuery = productsQuery.Where(x => EF.Functions.Like(x.Name.ToLower(), $"%{request.FilterQuery.ToLower()}%"));
                            break;
                        case "description":
                            // Use EF.Functions.Like for case-insensitive comparison
                            productsQuery = productsQuery.Where(x => EF.Functions.Like(x.Description.ToLower(), $"%{request.FilterQuery.ToLower()}%"));
                            break;
                        case "category":
                            productsQuery = productsQuery.Where(x => x.ProductCategoryId.ToString() == request.FilterQuery); // Adjust as needed
                            break;
                    }
                }

                // Price range
                if (request.FromPrice.HasValue)
                {
                    productsQuery = productsQuery.Where(x => x.Price >= request.FromPrice.Value);
                }
                if (request.ToPrice.HasValue)
                {
                    productsQuery = productsQuery.Where(x => x.Price <= request.ToPrice.Value);
                }

                // Sorting
                var validSortProperties = new Dictionary<string, Expression<Func<Product, object>>>
        {
            { "name", p => p.Name },
            { "price", p => p.Price },
            { "stockquantity", p => p.StockQuantity },
            { "imageurl", p => p.ImageUrl }
        };

                // Sorting
                if (!string.IsNullOrEmpty(request.SortBy))
                {
                    productsQuery = request.IsAscending == true
                        ? productsQuery.OrderBy(x => EF.Property<object>(x, request.SortBy))
                        : productsQuery.OrderByDescending(x => EF.Property<object>(x, request.SortBy));
                }


                // Pagination validation
                if (request.PageNumber < 1) request.PageNumber = 1;
                if (request.PageSize < 1) request.PageSize = 10;

                // Pagination
                response.TotalCount = await productsQuery.CountAsync();
                var products = await productsQuery.Skip((request.PageNumber - 1) * request.PageSize).Take(request.PageSize).ToListAsync();

                // Mapping products to ProductDTO
                response.Products = products.Select(product => new SearchProductResponse.ProductDTO
                {
                    Name = product.Name,
                    Price = product.Price,
                    StockQuantity = product.StockQuantity,
                    ImageUrl = product.ImageUrl
                }).ToList();

                // Set the error to None indicating success
                response.Error = Error.None;
            }
            catch (Exception e)
            {
                // Log and set meaningful error codes
                response.Error = Error.Failure("ProductFetchError", "An error occurred while fetching the products.");
            }

            return response;
        }


        #endregion

    }
}
