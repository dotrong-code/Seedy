using Seed.Domain.Entities;
using Seed.Infrastructure.Interfaces.IRepositories.IGeneric;

namespace Seed.Infrastructure.Interfaces.IRepositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<int> CreateOrderAsync(Order order);
        Task<Order> GetOrderByIdAsync(Guid orderId);
        Task<List<Order>> GetOrdersByUserIdAsync(Guid userId);
        Task<int> UpdateOrderAsync(Order order);
        Task<bool> RemoveOrderAsync(Order order);
        Task<List<Order>> GetOrdersWithDetailsByUserIdAsync(Guid userId);
        Task<List<Order>> GetOrders();
    }
}
