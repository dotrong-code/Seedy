using Seed.Application.Common.Result;
using Seed.Application.Interface.IService;
using Seed.Infrastructure.Common;
using Seed.Infrastructure.DTOs.Common.Message;

namespace Seed.Application.Implement.Service
{
    public class AdminService : IAdminService
    {
        private readonly UnitOfWork _unitOfWork;
        public AdminService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public async Task<Result> GetOrders()
        {
            var orders = await _unitOfWork.OrderRepository.GetOrders();
            if (orders == null)
            {
                return Result.Failure(OrderErrorMessage.OrderNotFound());
            }
            var list = orders.Select(o => new
            {
                o.Id,
                o.OrderService,
                o.TotalPrice,
                o.ReceiverFullName,
                o.ReceiverAddress,

            }).ToList();
            return Result.SuccessWithObject(list);

        }

        public async Task<Result> GetProducts()
        {
            var products = await _unitOfWork.ProductRepository.GetAllAsync();
            if (products == null)
            {
                return Result.Failure(ProductErrorMessage.ProductNotFound());
            }
            var list = products.Select(p => new
            {
                p.Id,
                p.Name,
                p.StockQuantity,
                p.Price,
                p.ImageUrl
            }).ToList();
            return Result.SuccessWithObject(list);
        }

        public async Task<Result> GetUsers()
        {
            var users = await _unitOfWork.UserRepository.GetUsers();
            if (users == null)
            {
                return Result.Failure(UserErrorMessage.UserNotExist());
            }
            var list = users.Select(p => new
            {
                p.Id,
                p.FullName,
                p.PhoneNumber,
                p.ProfilePictureUrl,
                p.Points
            }).ToList();
            return Result.SuccessWithObject(list);
        }
    }
}
