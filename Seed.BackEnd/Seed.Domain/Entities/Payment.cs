using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seed.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public Guid UserId { get; set; } // Foreign key to User
        public Guid OrderId { get; set; } // Foreign key to Order
        public decimal Amount { get; set; } // Total amount paid
        public string PaymentMethod { get; set; } // E.g., Credit Card, PayPal, COD
        public string PaymentStatus { get; set; } // Pending, Completed, Failed
        public DateTime PaymentDate { get; set; } // Date of payment

        // Relationships
        public virtual User User { get; set; }
        public virtual Order Order { get; set; }
    }
}
