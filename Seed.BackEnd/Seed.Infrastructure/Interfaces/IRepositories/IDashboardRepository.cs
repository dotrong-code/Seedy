using Seed.Infrastructure.DTOs.Admin;

namespace Seed.Infrastructure.Interfaces.IRepositories
{
    public interface IDashboardRepository
    {
        Task<DashboardRevenueDto> GetDashboardRevenue();

    }
}
