using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.Common.Result;
using Seed.Infrastructure.DTOs.Order;
using Seed.Infrastructure.DTOs.Product.Create;

namespace Seed.Application.Interface.IService
{
    public interface IOrderService
    {
        Task<Result> CreateOrderAsync(CreateOrderRequest request);
        Task<Result> GetOrderByIdAsync(Guid orderId);
        Task<Result> GetOrdersByUserIdAsync(Guid userId);

        Task<Result> GetOrdersWithDetailsByUserIdAsync(Guid userId);
        Task<Result> GetOrderDetailsAsync(Guid orderId);
    }
}
