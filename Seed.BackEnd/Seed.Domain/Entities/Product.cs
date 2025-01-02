using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Domain.Entities
{
    public class Product : BaseEntity
    {
        public Guid? ProductCategoryId { get; set; } // Foreign key to ProductCategory
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }

        // Relationships
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<CartItem> CartItems { get; set; } // Add this navigation property
        public ProductCategory ProductCategory { get; set; } // Navigation property for relationship
    }
}
