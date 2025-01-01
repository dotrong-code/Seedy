using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Seed.Domain.Entities
{
    public class Cart : BaseEntity
    {
        public Guid CustomerId { get; set; } // Foreign key to User
        public User Customer { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
