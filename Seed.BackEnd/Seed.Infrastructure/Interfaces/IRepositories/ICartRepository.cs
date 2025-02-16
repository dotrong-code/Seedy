using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Domain.Entities;
using Seed.Infrastructure.Interfaces.IRepositories.IGeneric;

namespace Seed.Infrastructure.Interfaces.IRepositories
{
    public interface ICartRepository : IGenericRepository<Cart>
    {
        Task<Cart> GetCartByUserIdAsync(Guid userId);
        Task<IEnumerable<CartItem>> GetCartItemsByUserIdAsync(Guid userId);
        Task<bool> AddCartItemAsync(CartItem cartItem);
        Task<bool> UpdateCartItemQuantityAsync(Guid cartItemId, int quantity);
        Task<bool> RemoveCartItemAsync(Guid cartItemId);
        Task<bool> ClearCartAsync(Guid userId);
    }
}
