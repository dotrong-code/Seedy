using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Domain.Entities
{
    public class User : BaseEntity
    {
        public string? FullName { get; set; } // Nullable string
        public string? Email { get; set; } // Nullable string
        public string? PhoneNumber { get; set; } // Nullable string
        public string? Address { get; set; } // Nullable string
        public string? Username { get; set; } // Nullable string
        public string? PasswordHash { get; set; } // Nullable string
        public string? ProfilePictureUrl { get; set; } // Nullable string
        public DateTime? DateOfBirth { get; set; } // Nullable DateTime

        // Relationships
        public virtual ICollection<Order>? Orders { get; set; } // Nullable relationship
        public virtual ICollection<Cart>? Carts { get; set; } // Nullable relationship
    }
}
