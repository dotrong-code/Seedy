using Microsoft.AspNetCore.Mvc;
using Seed.Application.Common.Result;
using Seed.Application.Interface.IService;
using Seed.Infrastructure.DTOs.Carts;
using Seed.Domain.Entities;
using Seed.Infrastructure.Interfaces.IRepositories;
using Seed.Infrastructure.Implement.Repositories.Generic;
using System.Threading.Tasks;

namespace Seed.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("{userId}")]
        public async Task<IResult> GetCartByUserId(Guid userId)
        {
            var result = await _cartService.GetCartByUserIdAsync(userId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("items/{userId}")]
        public async Task<IResult> GetCartItems(Guid userId)
        {
            var result = await _cartService.GetCartItemsAsync(userId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart items retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpPost("add")]
        public async Task<IResult> AddToCart(AddCartItemRequest request)
        {
            var result = await _cartService.AddToCartAsync(request);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Item added to cart successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpPut("update")]
        public async Task<IResult> UpdateCartItem(UpdateCartItemRequest request)
        {
            var result = await _cartService.UpdateCartItemAsync(request);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart item updated successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpDelete("remove/{cartItemId}")]
        public async Task<IResult> RemoveCartItem(Guid cartItemId)
        {
            var result = await _cartService.RemoveCartItemAsync(cartItemId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart item removed successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpDelete("clear/{userId}")]
        public async Task<IResult> ClearCart(Guid userId)
        {
            var result = await _cartService.ClearCartAsync(userId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart cleared successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}