using Seed.Application.Common.Result;
using Seed.Application.DTOs.Common;
using Seed.Application.Interface.IService;
using Seed.Domain.Entities;
using Seed.Infrastructure.DTOs.Carts;
using Seed.Infrastructure.Interfaces;
using Seed.Infrastructure.Interfaces.IRepositories;
using System;
using System.Threading.Tasks;

namespace Seed.Application.Implement.Service
{
    public class CartService : ICartService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CartService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> GetCartByUserIdAsync(Guid userId)
        {
            var cart = await _unitOfWork.CartRepository.GetCartByUserIdAsync(userId);
            return cart != null ? Result.SuccessWithObject(cart) : Result.Failure(Error.NotFound("CART_NOT_FOUND", "Cart not found"));
        }

        public async Task<Result> GetCartItemsAsync(Guid userId)
        {
            var cartItems = await _unitOfWork.CartRepository.GetCartItemsByUserIdAsync(userId);
            return cartItems != null ? Result.SuccessWithObject(cartItems) : Result.Failure(Error.NotFound("NO_ITEMS", "No items in cart"));
        }

        public async Task<Result> AddToCartAsync(AddCartItemRequest request)
        {
            var cartItem = new CartItem { CartId = request.CartId, ProductId = request.ProductId, Quantity = request.Quantity };
            var added = await _unitOfWork.CartRepository.AddCartItemAsync(cartItem);
            return added ? Result.Success() : Result.Failure(Error.Failure("ADD_FAILED", "Failed to add item to cart"));
        }

        public async Task<Result> UpdateCartItemAsync(UpdateCartItemRequest request)
        {
            var updated = await _unitOfWork.CartRepository.UpdateCartItemQuantityAsync(request.CartItemId, request.Quantity);
            return updated ? Result.Success() : Result.Failure(Error.Failure("UPDATE_FAILED", "Failed to update cart item"));
        }

        public async Task<Result> RemoveCartItemAsync(Guid cartItemId)
        {
            var removed = await _unitOfWork.CartRepository.RemoveCartItemAsync(cartItemId);
            return removed ? Result.Success() : Result.Failure(Error.Failure("REMOVE_FAILED", "Failed to remove cart item"));
        }

        public async Task<Result> ClearCartAsync(Guid userId)
        {
            var cleared = await _unitOfWork.CartRepository.ClearCartAsync(userId);
            return cleared ? Result.Success() : Result.Failure(Error.Failure("CLEAR_FAILED", "Failed to clear cart"));
        }
    }
}
