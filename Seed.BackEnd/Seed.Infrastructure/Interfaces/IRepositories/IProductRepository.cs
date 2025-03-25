using Seed.Domain.Entities;
using Seed.Infrastructure.DTOs.Product.Read;
using Seed.Infrastructure.Interfaces.IRepositories.IGeneric;
using System.Linq.Expressions;

namespace Seed.Infrastructure.Interfaces.IRepositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<bool> ProductNameExistsAsync(string productName);
        Task<int> CreateProductAsync(Product product);
        Task<Product> GetProductByIdAsync(Guid productId);
        Task<Product> GetProductByIdAsync(Guid productId, params Expression<Func<Product, object>>[] includes);
        Task<List<Product>> GetAllProductsAsync();
        Task<int> UpdateProductAsync(Product product);
        Task<bool> RemoveProductAsync(Product product);
        Task<bool> RemoveProductByIdAsync(Guid productId);
        Task<SearchProductResponse> GetProductsAsync(SearchProductRequest productName);
        Task<List<Product>> GetSortedProductsAsync(GetSortedProductsRequest request);
    }
}
