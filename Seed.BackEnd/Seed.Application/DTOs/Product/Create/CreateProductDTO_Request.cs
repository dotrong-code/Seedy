using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Application.DTOs.Product.Create
{
    public class CreateProductDTO_Request
    {
        public Guid ProductCategoryId { get; set; } // Foreign key to ProductCategory
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
    }
}
