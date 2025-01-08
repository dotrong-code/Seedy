using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.Common.Result;

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
