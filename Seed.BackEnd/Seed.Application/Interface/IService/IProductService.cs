using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.Common.Result;
using Seed.Infrastructure.DTOs.Product.Create;
using Seed.Infrastructure.DTOs.Product.Read;
using Seed.Infrastructure.DTOs.Product.Update;

namespace Seed.Application.Interface.IService
{
    public interface IProductService
    {
        Task<Result> AddProductAsync(AddProductRequest addProductRequest);
        Task<Result> UpdateProductAsync(UpdateProductRequest updateProductRequest);
        Task<Result> DeleteProductAsync(Guid productId);
        Task<Result> GetProductByIdAsync(Guid id);
        Task<Result> GetProductsAsync(SearchProductRequest request);
    }
}
