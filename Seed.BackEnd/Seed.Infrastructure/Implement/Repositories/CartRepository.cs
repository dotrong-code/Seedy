using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Seed.Domain.Entities;
using Seed.Infrastructure.DB;
using Seed.Infrastructure.Implement.Repositories.Generic;
using Seed.Infrastructure.Interfaces.IRepositories;

namespace Seed.Infrastructure.Implement.Repositories
{
    public class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        private readonly SeedContext _context;

        public CartRepository(SeedContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> CreateCartAsync(Cart cart)
        {
            await _context.Carts.AddAsync(cart);
            return await _context.SaveChangesAsync(); // Trả về số dòng bị ảnh hưởng
        }
        public async Task<Cart> GetCartByUserIdAsync(Guid userId)
        {
            return await _context.Carts.Include(c => c.CartItems).FirstOrDefaultAsync(c => c.UserID == userId);
        }

        public async Task<IEnumerable<CartItem>> GetCartItemsByUserIdAsync(Guid userId)
        {
            return await _context.CartItems.Where(c => c.Cart.UserID == userId).ToListAsync();
        }

        public async Task<bool> AddCartItemAsync(CartItem cartItem)
        {
            _context.CartItems.Add(cartItem);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateCartItemQuantityAsync(Guid cartItemId, int quantity)
        {
            var cartItem = await _context.CartItems.FindAsync(cartItemId);
            if (cartItem == null) return false;
            cartItem.Quantity = quantity;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveCartItemAsync(Guid cartItemId)
        {
            var cartItem = await _context.CartItems.FindAsync(cartItemId);
            if (cartItem == null) return false;
            _context.CartItems.Remove(cartItem);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> ClearCartAsync(Guid userId)
        {
            var cartItems = await _context.CartItems.Where(c => c.Cart.UserID == userId).ToListAsync();
            _context.CartItems.RemoveRange(cartItems);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<CartItem> GetCartItemByIdAsync(Guid cartItemId)
        {
            return await _context.CartItems.FirstOrDefaultAsync(c => c.Id == cartItemId);
        }
        public async Task<Cart> GetCartWithItemsAsync(Guid userId)
        {
            return await _context.Carts
                .Include(c => c.CartItems)
                    .ThenInclude(ci => ci.Product) // Load luôn thông tin Product
                .FirstOrDefaultAsync(c => c.UserID == userId);
        }
    }
}
