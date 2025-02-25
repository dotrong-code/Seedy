using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Seed.Domain.Entities
{
    public class Payment : BaseEntity
    {
        public Guid UserId { get; set; } // Foreign key to User
        public string Email { get; set; }  // Guest email   
        public string TransactionId { get; set; } // Transaction ID from SePay
        public string BankBrandName { get; set; } // Bank brand name (e.g., Vietcombank)
        public string AccountNumber { get; set; } // Customer's account number
        public decimal Amount { get; set; } // Payment amount
        public string TransactionContent { get; set; } // Transaction description
        public DateTime TransactionDate { get; set; } // Transaction date
        public string ReferenceNumber { get; set; } // Reference number from SePay

        // Relationships
        public User User { get; set; }
    }
}

