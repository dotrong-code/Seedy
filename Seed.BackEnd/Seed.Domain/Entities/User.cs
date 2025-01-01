using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public int Role { get; set; }//1 admin, 2 manager,3 veterinarian, 4 staff, 5 customer

        // Relationships
        public virtual ICollection<Order>? Orders { get; set; } // Nullable relationship
        public virtual ICollection<Cart>? Carts { get; set; } // Nullable relationship
    }
}
