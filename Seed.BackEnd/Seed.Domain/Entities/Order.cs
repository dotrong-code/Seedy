using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Domain.Entities
{
    public class Order : BaseEntity
    {
        public Guid? UserID { get; set; }  // Nullable for guest orders
        public string Email { get; set; }  // Guest email   
        public decimal TotalPrice { get; set; }
        public decimal ShippingFee { get; set; }
        public string PaymentStatus { get; set; } = "Pending";
        public string ShippingStatus { get; set; } = "Pending";// Pending, Confirmed, Shipped, Delivered
        public string RefundStatus { get; set; } = "None"; 

        // Relationships
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<OrderTracking> OrderTrackings { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public User User { get; set; }
    }
}
