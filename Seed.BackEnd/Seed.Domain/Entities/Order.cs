using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Guid CustomerId { get; set; } // Foreign key to User
        public User Customer { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } // Pending, Confirmed, Shipped, Delivered

        // Relationships
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<OrderTracking> OrderTrackings { get; set; }
    }
}
