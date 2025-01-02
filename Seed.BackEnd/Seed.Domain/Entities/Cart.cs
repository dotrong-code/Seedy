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
        public Guid? UserID { get; set; } // Foreign key to User
        public string Email { get; set; }  // Optional for guest users
        public ICollection<CartItem> CartItems { get; set; }
        public User User { get; set; }
    }
}
