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
        public Guid? UserId { get; set; } // Nullable to allow any user


        // Relationships
        public virtual User User { get; set; } // Navigation property
        public virtual ICollection<CartItem> CartItems { get; set; }
    }
}
