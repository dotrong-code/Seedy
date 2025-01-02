using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public Guid? UserID { get; set; }  // Nullable for guest orders
        public string Email { get; set; }  // Guest email   
        public Guid OrderId { get; set; } // Foreign key to Order
        public decimal Amount { get; set; } // Total amount paid
        public string PaymentMethod { get; set; } // E.g., Credit Card, PayPal, COD
        public string PaymentStatus { get; set; } // Pending, Completed, Failed
        public DateTime PaymentDate { get; set; } // Date of payment

        // Relationships
        public User User { get; set; }
        public Order Order { get; set; }
    }
}
