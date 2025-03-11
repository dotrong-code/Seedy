using Seed.Domain.Entities;
using Seed.Infrastructure.Interfaces.IRepositories.IGeneric;

namespace Seed.Infrastructure.Interfaces.IRepositories
{
    public interface IPaymentRepository : IGenericRepository<Payment>
    {
        Task<int> CreatePaymentAsync(Payment payment);
        Task<List<Payment>> GetAllPaymentsAsync();
        Task<List<Payment>> GetPaymentsByMonth(int month, int year);
    }
}
