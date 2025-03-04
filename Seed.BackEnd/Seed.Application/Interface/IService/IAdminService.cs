using Seed.Application.Common.Result;

namespace Seed.Application.Interface.IService
{
    public interface IAdminService
    {
        Task<Result> GetOrders();
        Task<Result> GetProducts();
        Task<Result> GetUsers();
    }
}
