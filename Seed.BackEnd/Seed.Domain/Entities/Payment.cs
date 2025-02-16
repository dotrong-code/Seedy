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
        public Guid? UserID { get; set; }  // Nullable for guest orders
        public string Email { get; set; }  // Guest email   
        public Guid OrderId { get; set; } // Foreign key to Order
        public decimal AmountIn { get; set; } // Số tiền nhận
        public decimal AmountOut { get; set; } // Số tiền trừ đi (nếu có)
        public decimal Accumulated { get; set; } // Tổng số dư tích lũy
        public string AccountNumber { get; set; } // Số tài khoản chính
        public string SubAccount { get; set; } // Tài khoản phụ
        public string ReferenceNumber { get; set; } // Mã tham chiếu giao dịch
        public string TransactionContent { get; set; } // Nội dung giao dịch
        public string BankBrandName { get; set; } // Ngân hàng giao dịch
        public string BankAccountId { get; set; } // ID tài khoản ngân hàng
        public string PaymentMethod { get; set; } // E.g., Credit Card, PayPal, COD
        public string PaymentStatus { get; set; } // Pending, Completed, Failed
        public DateTime TransactionDate { get; set; } // Ngày giao dịch

        // Relationships
        public User User { get; set; }
        public Order Order { get; set; }
    }
}

