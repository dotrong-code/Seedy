using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Infrastructure.DTOs.ProductCategory.Create
{
    public class AddProductCategoryRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
