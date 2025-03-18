using FluentValidation;
using Seed.Application.Common.Result;
using Seed.Application.DTOs.Common;
using Seed.Application.DTOs.Firebase.AddImage;
using Seed.Application.Interface.IService;
using Seed.Domain.Entities;
using Seed.Infrastructure.DTOs.Product.Create;
using Seed.Infrastructure.DTOs.Product.Read;
using Seed.Infrastructure.DTOs.Product.Update;
using Seed.Infrastructure.Interfaces;

namespace Seed.Application.Implement.Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<AddProductRequest> _addProductRequestValidator;
        private readonly IValidator<UpdateProductRequest> _updateProductRequestValidator;

        public ProductService(
            IUnitOfWork unitOfWork,
            IValidator<AddProductRequest> addProductRequestValidator,
            IValidator<UpdateProductRequest> updateProductRequestValidator
        )
        {
            _unitOfWork = unitOfWork;
            _addProductRequestValidator = addProductRequestValidator;
            _updateProductRequestValidator = updateProductRequestValidator;

        }
        public async Task<Result> AddProductAsync(AddProductRequest addProductRequest)
        {
            try
            {
                var validate = await _addProductRequestValidator.ValidateAsync(addProductRequest);
                if (!validate.IsValid)
                {
                    var errors = validate.Errors.Select(e => (Error)e.CustomState).ToList();
                    return Result.Failures(errors);
                }

                var productExists = await _unitOfWork.ProductRepository.ProductNameExistsAsync(addProductRequest.Name);
                if (productExists)
                {
                    return Result.Failure(ProductErrorMessage.ProductNameIsExist());
                }

                string mainImageUrl = null;
                if (addProductRequest.ImageFile != null)
                {
                    var imageRequest = new AddImageRequest(addProductRequest.ImageFile, "Products");
                    var uploadImageResult = await _unitOfWork.FirebaseRepository.UploadImageAsync(imageRequest);
                    if (!uploadImageResult.Success)
                    {
                        return Result.Failure(uploadImageResult.Error);
                    }
                    mainImageUrl = uploadImageResult.FilePath;
                }

                var product = new Product
                {
                    Note = addProductRequest.Note,
                    Name = addProductRequest.Name,
                    Price = addProductRequest.Price,
                    Description = addProductRequest.Description,
                    ProductCategoryId = addProductRequest.ProductCategoryId,
                    OccasionId = addProductRequest.OccasionId,
                    StockQuantity = addProductRequest.StockQuantity,
                    ImageUrl = mainImageUrl,
                    ProductImages = new List<ProductImage>()
                };

                if (addProductRequest.AdditionalImageFiles != null && addProductRequest.AdditionalImageFiles.Any())
                {
                    foreach (var additionalImage in addProductRequest.AdditionalImageFiles)
                    {
                        var additionalImageRequest = new AddImageRequest(additionalImage, "Products");
                        var uploadResult = await _unitOfWork.FirebaseRepository.UploadImageAsync(additionalImageRequest);
                        if (!uploadResult.Success)
                        {
                            return Result.Failure(uploadResult.Error);
                        }
                        product.ProductImages.Add(new ProductImage { ImageUrl = uploadResult.FilePath });
                    }
                }

                var createResult = await _unitOfWork.ProductRepository.CreateProductAsync(product);
                if (createResult == 0)
                {
                    return Result.Failure(ProductErrorMessage.ProductNameIsExist());
                }

                return Result.SuccessWithObject(createResult);
            }
            catch (Exception ex)
            {
                // Log lỗi và trả về chi tiết
                Console.WriteLine($"Error in AddProductAsync: {ex.Message}");
                return Result.Failure(ProductErrorMessage.ProductNotCreated());
            }
        }
        // Read (Retrieve a product by ID)
        public async Task<Result> GetProductByIdAsync(Guid productId)
        {
            var product = await _unitOfWork.ProductRepository.GetProductByIdAsync(productId, p => p.ProductImages, p => p.Occasion);
            if (product == null)
            {
                return Result.Failure(ProductErrorMessage.ProductNotExist());
            }
            // Retrieve the product image from Firebase (assuming FirebaseRepository has a method to get the image)
            GetImageRequest getImageRequest = new GetImageRequest(product.ImageUrl);
            var imageResult = await _unitOfWork.FirebaseRepository.GetImageAsync(getImageRequest); // Assuming product.ImageUrl stores the image reference
            if (imageResult == null)
            {
                return Result.Failure(imageResult.Error); // Handle image retrieval failure
            }
            var productImageUrls = new List<string>();
            if (product.ProductImages != null && product.ProductImages.Any())
            {
                foreach (var productImage in product.ProductImages)
                {
                    var additionalImageRequest = new GetImageRequest(productImage.ImageUrl);
                    var additionalImageResult = await _unitOfWork.FirebaseRepository.GetImageAsync(additionalImageRequest);
                    if (additionalImageResult != null && !string.IsNullOrEmpty(additionalImageResult.ImageUrl))
                    {
                        productImageUrls.Add(additionalImageResult.ImageUrl);
                    }
                    // Nếu không lấy được URL cho ảnh phụ, có thể bỏ qua hoặc log lỗi tùy yêu cầu
                }
            }
            var productResponse = new GetProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                OccasionName = product.Occasion.OccasionName,
                OccasionId = product.Occasion.Id,
                Price = product.Price,
                Description = product.Description,
                ProductCategoryId = product.ProductCategoryId,
                StockQuantity = product.StockQuantity,
                ImageStream = imageResult.ImageUrl,   // Store image data in MemoryStream
                //ProductCategoryName = product.ProductCategory?.Name // Optional: Category name, if available
                ProductImageUrls = productImageUrls // Danh sách URL của ảnh phụ
            };
            return Result.SuccessWithObject(productResponse);
        }
        public async Task<Result> GetProductsAsync(SearchProductRequest request)
        {
            var response = await _unitOfWork.ProductRepository.GetProductsAsync(request);
            if (response.Error != Error.None) // Assuming Error.None means no error
            {
                return Result.Failure(response.Error);
            }
            return Result.SuccessWithObject(response);
        }

        // Update
        public async Task<Result> UpdateProductAsync(UpdateProductRequest updateProductRequest)
        {
            var validate = await _updateProductRequestValidator.ValidateAsync(updateProductRequest);
            if (!validate.IsValid)
            {
                var errors = validate.Errors.Select(e => (Error)e.CustomState).ToList();
                return Result.Failures(errors);
            }

            var product = await _unitOfWork.ProductRepository.GetProductByIdAsync(updateProductRequest.Id);
            if (product == null)
            {
                return Result.Failure(ProductErrorMessage.ProductNotExist());
            }

            // Update fields
            if (updateProductRequest.Name != null)
                product.Name = updateProductRequest.Name;

            if (updateProductRequest.Description != null)
                product.Description = updateProductRequest.Description;

            if (updateProductRequest.Price.HasValue)
                product.Price = updateProductRequest.Price.Value;

            if (updateProductRequest.StockQuantity.HasValue)
                product.StockQuantity = updateProductRequest.StockQuantity.Value;

            if (updateProductRequest.ImageUrl != null)
                product.ImageUrl = updateProductRequest.ImageUrl;


            var updateResult = await _unitOfWork.ProductRepository.UpdateProductAsync(product);
            return updateResult == 0
                ? Result.Failure(ProductErrorMessage.ProductUpdateFailed())
                : Result.Success();
        }

        // Delete
        public async Task<Result> DeleteProductAsync(Guid productId)
        {
            var product = await _unitOfWork.ProductRepository.GetProductByIdAsync(productId);
            if (product == null)
            {
                return Result.Failure(ProductErrorMessage.ProductNotFound());
            }

            var deleteResult = await _unitOfWork.ProductRepository.RemoveProductAsync(product);
            return deleteResult ? Result.Success() : Result.Failure(ProductErrorMessage.ProductDeletionFailed());
        }

        public async Task<Result> GetAllProduct()
        {
            var products = await _unitOfWork.ProductRepository.GetAllProductsAsync();
            if (products == null)
            {
                return Result.Failure(ProductErrorMessage.ProductNotFound());
            }
            var productList = new List<object>();
            foreach (var product in products)
            {
                // Lấy URL của ảnh chính từ Firebase
                string imageUrl = null;
                if (!string.IsNullOrEmpty(product.ImageUrl))
                {
                    var getImageRequest = new GetImageRequest(product.ImageUrl);
                    var imageResult = await _unitOfWork.FirebaseRepository.GetImageAsync(getImageRequest);
                    if (imageResult != null && !string.IsNullOrEmpty(imageResult.ImageUrl))
                    {
                        imageUrl = imageResult.ImageUrl;
                    }
                }

                productList.Add(new
                {
                    product.Id,
                    product.Name,
                    product.Price,
                    category = product.ProductCategory.Name,
                    ImageUrl = imageUrl // URL từ Firebase
                });
            }

            return Result.SuccessWithObject(productList);

        }
        public async Task<Result> GetSortedProductsAsync(GetSortedProductsRequest request)
        {
            try
            {
                var products = await _unitOfWork.ProductRepository.GetSortedProductsAsync(request);
                if (products == null || !products.Any())
                {
                    return Result.Failure(ProductErrorMessage.ProductNotFound());
                }

                var productList = new List<object>();
                foreach (var product in products)
                {
                    // Lấy URL ảnh chính từ Firebase
                    string imageUrl = null;
                    if (!string.IsNullOrEmpty(product.ImageUrl))
                    {
                        var getImageRequest = new GetImageRequest(product.ImageUrl);
                        var imageResult = await _unitOfWork.FirebaseRepository.GetImageAsync(getImageRequest);
                        if (imageResult != null && !string.IsNullOrEmpty(imageResult.ImageUrl))
                        {
                            imageUrl = imageResult.ImageUrl;
                        }
                    }

                    productList.Add(new
                    {
                        product.Id,
                        product.Name,
                        product.Price,
                        ImageUrl = imageUrl // URL từ Firebase
                    });
                }

                return Result.SuccessWithObject(productList);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetSortedProductsAsync: {ex.Message}");
                return Result.Failure(ProductErrorMessage.ProductNotFound());
            }
        }
        public async Task<Result> GetProductDetail(Guid productId)
        {
            var product = await _unitOfWork.ProductRepository.GetByIdAsync(productId, p => p.ProductImages);
            if (product == null)
            {
                return Result.Failure(ProductErrorMessage.ProductNotExist());
            }

            var productResponse = new GetProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                ProductCategoryId = product.ProductCategoryId,
                StockQuantity = product.StockQuantity,
                ImageStream = product.ImageUrl, // Ảnh chính
                ProductImageUrls = product.ProductImages?.Select(pi => pi.ImageUrl).ToList() ?? new List<string>() // Danh sách ảnh phụ
            };

            return Result.SuccessWithObject(productResponse);

        }
    }
}
