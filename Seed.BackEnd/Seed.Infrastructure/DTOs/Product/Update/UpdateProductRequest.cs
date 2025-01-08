using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Infrastructure.DTOs.Product.Create;

namespace Seed.Infrastructure.DTOs.Product.Update
{
    public class UpdateProductRequest
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public int? StockQuantity { get; set; }
        public string? ImageUrl { get; set; }
    }
}
