using Microsoft.EntityFrameworkCore;
using Seed.Infrastructure.DB;
using Seed.Infrastructure.DTOs.Admin;
using Seed.Infrastructure.Interfaces.IRepositories;

namespace Seed.Infrastructure.Implement.Repositories
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly SeedContext _context;
        public DashboardRepository(SeedContext context) => _context = context;

        public async Task<DashboardRevenueDto> GetDashboardRevenue()
        {
            var revenueOverTime = await _context.Payments
                .Where(p => p.Status == "Completed")
                .GroupBy(p => p.TransactionDate.Date)
                .Select(p => new RevenueOverTimeDto
                {
                    Date = p.Key,
                    Revenue = p.Sum(p => p.Amount)
                })
                .ToListAsync();
            var salesByCategory = await _context.Orders

                .Join(_context.OrderItems, o => o.Id, oi => oi.OrderId, (o, oi) => new { o, oi })  // Join Orders with OrderItems
                .Join(_context.Products, oi => oi.oi.ProductId, p => p.Id, (oi, p) => new { p.ProductCategoryId, oi.oi.Price })  // Join OrderItems with Products
                .Join(_context.ProductCategories, p => p.ProductCategoryId, c => c.Id, (p, c) => new { c.Name, p.Price })  // Get Category Name
                .GroupBy(x => x.Name)  // Group by Category Name
                .Select(g => new SalesCategoryDto
                {
                    Category = g.Key,
                    Revenue = g.Sum(x => x.Price)
                })
                .ToListAsync();
            var topSellingCards = await _context.Orders

                .Join(_context.OrderItems, o => o.Id, oi => oi.OrderId, (o, oi) => new { oi.ProductId, oi.Quantity, oi.Price })  // Join Orders with OrderItems
                .Join(_context.Products, oi => oi.ProductId, p => p.Id, (oi, p) => new { p.Name, Revenue = oi.Quantity * oi.Price })  // Get Product Name & Revenue
                .GroupBy(x => x.Name)
                .Select(g => new TopSellingCardDto
                {
                    CardName = g.Key,
                    Revenue = g.Sum(x => x.Revenue)  // Calculate total revenue for each card
                })
                .OrderByDescending(x => x.Revenue)
                .Take(5)
                .ToListAsync();
            var list = new DashboardRevenueDto
            {
                RevenueOverTime = revenueOverTime,
                SalesByCategory = salesByCategory,
                TopSellingCards = topSellingCards
            };
            return list;

        }
    }
}
