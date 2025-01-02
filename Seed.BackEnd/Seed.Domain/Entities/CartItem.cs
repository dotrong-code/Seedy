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
        

        public Guid? ProductId { get; set; } // Optional foreign key to Product
        
        public int Quantity { get; set; } = 1;
        public bool IsDeleted { get; set; }

        public Product Product { get; set; }

        public Cart Cart { get; set; }
    }
}
