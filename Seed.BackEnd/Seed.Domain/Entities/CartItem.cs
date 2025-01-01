using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Seed.Domain.Entities
{
    public class CartItem : BaseEntity
    {
        public Guid CartId { get; set; } // Foreign key to Cart
        public Guid ProductId { get; set; } // Foreign key to Product
        public int Quantity { get; set; }

        // Relationships
        public virtual Cart Cart { get; set; }
        public virtual Product Product { get; set; }
    }
}
