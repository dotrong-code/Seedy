using Seed.Application.Common.Result;
using Seed.Infrastructure.DTOs.Carts;
using System;
using System.Threading.Tasks;

namespace Seed.Application.Interface.IService
{
    public interface ICartService
    {
        Task<Result> GetCartByUserIdAsync(Guid userId);
        Task<Result> GetCartItemsAsync(Guid userId);
        Task<Result> AddToCartAsync(AddCartItemRequest request);
        Task<Result> UpdateCartItemAsync(UpdateCartItemRequest request);
        Task<Result> RemoveCartItemAsync(Guid cartItemId);
        Task<Result> ClearCartAsync(Guid userId);
    }
}
