using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Seed.Domain.Entities;
using Seed.Infrastructure.DB;
using Seed.Infrastructure.Implement.Repositories.Generic;
using Seed.Infrastructure.Interfaces.IRepositories;

namespace Seed.Infrastructure.Implement.Repositories
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(SeedContext context) : base(context) { }

        public async Task<int> CreatePaymentAsync(Payment payment)
        {
            _context.Payments.Add(payment);
            return await _context.SaveChangesAsync();
        }
        public async Task<List<Payment>> GetAllPaymentsAsync()
        {
            return await _context.Payments
                .OrderByDescending(p => p.TransactionDate) // Sort by latest transaction
                .ToListAsync();
        }
    }
}
