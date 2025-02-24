using Microsoft.AspNetCore.Mvc;
using Seed.Application.Common.Result;
using Seed.Application.Interface.IService;
using Seed.Infrastructure.DTOs.Product.Create;
using Seed.Infrastructure.DTOs.Product.Read;
using Seed.Infrastructure.DTOs.Product.Update;
using Seed.Infrastructure.DTOs.ProductCategory.Create;
using Seed.Infrastructure.DTOs.ProductCategory.Delete;
using Seed.Infrastructure.DTOs.ProductCategory.Read;
using Seed.Infrastructure.DTOs.ProductCategory.Update;

namespace Seed.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;

        public ProductController(IProductService productService, IProductCategoryService productCategoryService)
        {
            _productService = productService;
            _productCategoryService = productCategoryService;
        }
        // Get product by ID
        [HttpGet("{id}")]
        public async Task<IResult> GetProductById(Guid id)
        {
            var result = await _productService.GetProductByIdAsync(id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Products retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("all")]
        public async Task<IResult> GetAllProducts()
        {
            var result = await _productService.GetAllProduct();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Products retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);

        }

        // Get products with search criteria
        [HttpPost("search")]
        public async Task<IResult> GetProducts([FromBody] SearchProductRequest request)
        {
            var result = await _productService.GetProductsAsync(request);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Products retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        // Add a new product
        [HttpPost("add")]
        public async Task<IResult> AddProduct([FromForm] AddProductRequest addProductRequest)
        {
            var result = await _productService.AddProductAsync(addProductRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Product added successfully")
                : ResultExtensions.ToProblemDetails(result);
        }


        // Update a product
        [HttpPut("update")]
        public async Task<IResult> UpdateProduct([FromBody] UpdateProductRequest updateProductRequest)
        {
            var result = await _productService.UpdateProductAsync(updateProductRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Product updated successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // Delete a product
        [HttpDelete("delete/{id}")]
        public async Task<IResult> DeleteProduct(Guid id)
        {
            var result = await _productService.DeleteProductAsync(id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Product deleted successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        #region ProductCategory Endpoints

        // Add a new product category
        [HttpPost("category/add")]
        public async Task<IResult> AddProductCategory([FromBody] AddProductCategoryRequest addProductCategoryRequest)
        {
            var result = await _productCategoryService.AddProductCategoryAsync(addProductCategoryRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Product category added successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // Get a product category by ID
        [HttpGet("category/{id}")]
        public async Task<IResult> GetProductCategoryById(Guid id)
        {
            var request = new GetProductCategoryRequest { ProductCategoryId = id };
            var result = await _productCategoryService.GetProductCategoryByIdAsync(request);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Product category retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // Update a product category
        [HttpPut("category/update")]
        public async Task<IResult> UpdateProductCategory([FromBody] UpdateProductCategoryRequest updateProductCategoryRequest)
        {
            var result = await _productCategoryService.UpdateProductCategoryAsync(updateProductCategoryRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Product category updated successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // Delete a product category
        [HttpDelete("category/delete/{id}")]
        public async Task<IResult> DeleteProductCategory(Guid id)
        {
            var request = new DeleteProductCategoryRequest { ProductCategoryId = id };
            var result = await _productCategoryService.DeleteProductCategoryAsync(request);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Product category deleted successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        #endregion


    }
}
