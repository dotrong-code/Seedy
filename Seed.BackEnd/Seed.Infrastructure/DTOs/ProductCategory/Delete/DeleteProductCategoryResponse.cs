using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Infrastructure.DTOs.ProductCategory.Delete
{
    public class DeleteProductCategoryResponse
    {
        public Guid ProductCategoryId { get; set; }
        public string Name { get; set; }
    }
}
