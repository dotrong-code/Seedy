using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.DTOs.Common;

namespace Seed.Infrastructure.DTOs.Product.Read
{
    public class SearchProductResponse
    {
        public List<ProductDTO> Products { get; set; } = new List<ProductDTO>(); // List of found products
        public int TotalCount { get; set; } // Total number of products that match the search criteria
        public Error Error { get; set; } = Error.None;
        public class ProductDTO
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int StockQuantity { get; set; }
            public string ImageUrl { get; set; }
        }
    }
}
