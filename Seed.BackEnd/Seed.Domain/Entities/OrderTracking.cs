using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Domain.Entities
{
    public class OrderTracking : BaseEntity
    {
        public Guid OrderId { get; set; } // Foreign key to Order
        public string Status { get; set; } // In Transit, Out for Delivery, Delivered
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Relationships
        public virtual Order Order { get; set; }
    }
}
