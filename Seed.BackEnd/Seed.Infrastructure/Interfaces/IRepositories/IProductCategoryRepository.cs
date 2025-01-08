using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Domain.Entities;
using Seed.Infrastructure.Interfaces.IRepositories.IGeneric;

namespace Seed.Infrastructure.Interfaces.IRepositories
{
    public interface IProductCategoryRepository : IGenericRepository<ProductCategory>
    {
        Task<bool> ProductCategoryNameExistsAsync(string productCategoryName);
        Task<int> CreateProductCategoryAsync(ProductCategory productCategory);
        Task<ProductCategory> GetProductCategoryByIdAsync(Guid productCategoryId);
        Task<List<ProductCategory>> GetAllProductCategoriesAsync();
        Task<int> UpdateProductCategoryAsync(ProductCategory productCategory);
        Task<bool> RemoveProductCategoryAsync(ProductCategory productCategory);
        Task<bool> RemoveProductCategoryByIdAsync(Guid productCategoryId);
    }
}
