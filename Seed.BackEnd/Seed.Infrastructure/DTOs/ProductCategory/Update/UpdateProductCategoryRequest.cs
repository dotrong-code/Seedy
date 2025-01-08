using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Infrastructure.DTOs.ProductCategory.Update
{
    public class UpdateProductCategoryRequest
    {
        public Guid ProductCategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
