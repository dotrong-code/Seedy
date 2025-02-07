using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.Common.Result;
using Seed.Infrastructure.DTOs.ProductCategory.Create;
using Seed.Infrastructure.DTOs.ProductCategory.Delete;
using Seed.Infrastructure.DTOs.ProductCategory.Read;
using Seed.Infrastructure.DTOs.ProductCategory.Update;

namespace Seed.Application.Interface.IService
{
    public interface IProductCategoryService
    {
        Task<Result> AddProductCategoryAsync(AddProductCategoryRequest addProductCategoryRequest);
        Task<Result> GetProductCategoryByIdAsync(GetProductCategoryRequest getProductCategoryRequest);
        Task<Result> UpdateProductCategoryAsync(UpdateProductCategoryRequest updateProductCategoryRequest);
        Task<Result> DeleteProductCategoryAsync(DeleteProductCategoryRequest request);
    }
}
