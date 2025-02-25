using Seed.Application.Common.Result;
using Seed.Domain.Entities;
using Seed.Infrastructure.DTOs.Carts;
using System;
using System.Threading.Tasks;

namespace Seed.Application.Interface.IService
{
    public interface ICartService
    {
        Task<Result> GetCartByUserIdAsync(Guid userId);
        Task<Result> GetCartItemsAsync(Guid userId);
        Task<Result> AddToCartAsync(Guid userId, Guid productId, int quantity); // 🆕 Không cần CartId nữa
        Task<Result> UpdateCartItemAsync(Guid userId, Guid cartItemId, int quantity); // 🆕 Không cần CartId nữa
        Task<Result> RemoveCartItemAsync(Guid cartItemId);
        Task<Result> ClearCartAsync(Guid userId);


        Task<Result> GetCartDetailsAsync(Guid userId);
        Task<Result> CreateCartByUserIdAsync(Guid userId, string email);
    }

}
