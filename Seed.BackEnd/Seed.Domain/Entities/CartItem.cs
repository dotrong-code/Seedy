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
        public Cart Cart { get; set; }

        public Guid? ProductId { get; set; } // Optional foreign key to Product
        public Product Product { get; set; }

        public bool IsDeleted { get; set; }
        public Guid? OrderHistoryId { get; set; } // This can refer to a historical order record
    }
}
