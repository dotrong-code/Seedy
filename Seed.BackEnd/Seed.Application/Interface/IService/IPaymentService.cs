using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.Common.Result;
using Seed.Infrastructure.DTOs.Order;

namespace Seed.Application.Interface.IService
{
    public interface IPaymentService
    {
        Task<Result> GetAllPaymentsAsync();
        Task<Result> CheckPaymentAsync(string accountNumber, decimal amount, string description, Guid userId);
        Task<Result> CreateOrderAndCheckPaymentAsync(OrderRequest orderRequest, Guid userId);
        Task<Result> CreateOrderCODAsync(OrderRequest orderRequest, Guid userId);
    }
}
