using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Seed.Application.Common.Result;
using Seed.Application.Common;
using Seed.Application.Interface.IService;
using Seed.Infrastructure.DTOs.Carts;
using System;
using System.Threading.Tasks;

namespace Seed.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] // Bắt buộc người dùng phải đăng nhập
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpGet("details")]
        public async Task<IResult> GetCartDetails()
        {
            var currentUser = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            var result = await _cartService.GetCartDetailsAsync(currentUser.UserId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart details retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // Lấy giỏ hàng của user từ token
        [HttpGet("user-cart")]
        public async Task<IResult> GetCartByUserId()
        {
            var currentUser = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            var result = await _cartService.GetCartByUserIdAsync(currentUser.UserId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // Lấy danh sách item trong giỏ hàng của user từ token
        [HttpGet("items")]
        public async Task<IResult> GetCartItems()
        {
            var currentUser = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            var result = await _cartService.GetCartItemsAsync(currentUser.UserId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart items retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // Thêm sản phẩm vào giỏ hàng (Tự động lấy CartId)
        [HttpPost("add")]
        public async Task<IResult> AddToCart(AddCartItemRequest request)
        {
            var currentUser = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            var result = await _cartService.AddToCartAsync(currentUser.UserId, request.ProductId, request.Quantity);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Item added to cart successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // Cập nhật số lượng sản phẩm trong giỏ hàng
        [HttpPut("update")]
        public async Task<IResult> UpdateCartItem(UpdateCartItemRequest request)
        {
            var currentUser = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            var result = await _cartService.UpdateCartItemAsync(currentUser.UserId, request.CartItemId, request.Quantity);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart item updated successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // Xóa một sản phẩm khỏi giỏ hàng
        [HttpDelete("remove/{cartItemId}")]
        public async Task<IResult> RemoveCartItem(Guid cartItemId)
        {
            var result = await _cartService.RemoveCartItemAsync(cartItemId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart item removed successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // Xóa toàn bộ giỏ hàng của user
        [HttpDelete("clear")]
        public async Task<IResult> ClearCart()
        {
            var currentUser = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            var result = await _cartService.ClearCartAsync(currentUser.UserId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart cleared successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}
