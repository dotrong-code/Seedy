using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Application.DTOs.ProductCategory.Create
{
    public class CreateProductCategoryDTO_Request
    {
        public string Name { get; set; } // Category name, e.g., "Accessories", "Fish Food"
        public string Description { get; set; } // Optional description
    }
}
