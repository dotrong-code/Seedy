using Microsoft.EntityFrameworkCore;
using Seed.Domain.Entities;
using Seed.Infrastructure.DB;
using Seed.Infrastructure.Implement.Repositories.Generic;
using Seed.Infrastructure.Interfaces.IRepositories;

namespace Seed.Infrastructure.Implement.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(SeedContext context) : base(context) { }

        public async Task<int> CreateOrderAsync(Order order)
        {
            _context.Orders.Add(order);
            return await _context.SaveChangesAsync();
        }

        public async Task<Order> GetOrderByIdAsync(Guid orderId)
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product) // ✅ Load luôn thông tin sản phẩm
                .FirstOrDefaultAsync(o => o.Id == orderId);
        }


        public async Task<List<Order>> GetOrdersByUserIdAsync(Guid userId)
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                .Where(o => o.UserID == userId)
                .ToListAsync();
        }

        public async Task<int> UpdateOrderAsync(Order order)
        {
            _context.Orders.Update(order);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> RemoveOrderAsync(Order order)
        {
            _context.Orders.Remove(order);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<List<Order>> GetOrdersWithDetailsByUserIdAsync(Guid userId)
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .Where(o => o.UserID == userId)
                .ToListAsync();
        }
        public async Task<List<Order>> GetOrders()
        {
            return await _context.Orders.ToListAsync();
        }
    }
}
