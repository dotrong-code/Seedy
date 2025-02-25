using Seed.Application.Common.Result;
using Seed.Application.DTOs.Common;
using Seed.Application.Interface.IService;
using Seed.Domain.Entities;
using Seed.Infrastructure.DTOs.Carts;
using Seed.Infrastructure.Interfaces;

namespace Seed.Application.Implement.Service
{
    public class CartService : ICartService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFirebaseService _firebaseService;

        public CartService(IUnitOfWork unitOfWork, IFirebaseService firebaseService)
        {
            _unitOfWork = unitOfWork;
            _firebaseService = firebaseService;
        }
        public async Task<Result> GetCartDetailsAsync(Guid userId)
        {
            var cart = await _unitOfWork.CartRepository.GetCartWithItemsAsync(userId);
            if (cart == null)
            {
                return Result.Failure(Error.NotFound("CART_NOT_FOUND", "User does not have a cart."));
            }

            var cartItemsDictionary = new Dictionary<Guid, ProductCartItemDto>();

            foreach (var item in cart.CartItems.Where(item => !item.IsDeleted && item.Product != null))
            {
                string imageUrl = null;
                //item.Product.Images;

                // Ensure Product Image URL is not empty before requesting from Firebase

                var imageRequest = new GetImageRequest(imageUrl ?? string.Empty);
                var imageResult = await _unitOfWork.FirebaseRepository.GetImageAsync(imageRequest);



                cartItemsDictionary[item.Id] = new ProductCartItemDto
                {
                    ProductId = item.Product.Id,
                    ProductName = item.Product.Name,
                    ProductPrice = item.Product.Price,
                    ProductImageUrl = imageResult.ImageUrl ?? string.Empty, // Use the retrieved Firebase URL
                    ProductStockQuantity = item.Product.StockQuantity,
                    Quantity = item.Quantity
                };
            }

            var cartDetailsDto = new CartDetailsDto
            {
                CartID = cart.Id,
                UserID = cart.UserID,
                CartItems = cartItemsDictionary
            };

            return Result.SuccessWithObject(cartDetailsDto);
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

        public async Task<Result> AddToCartAsync(Guid userId, Guid productId, int quantity)
        {
            // Lấy Cart của user
            var cart = await _unitOfWork.CartRepository.GetCartByUserIdAsync(userId);
            if (cart == null)
            {
                return Result.Failure(Error.NotFound("CART_NOT_FOUND", "User does not have a cart."));
            }

            var cartItem = new CartItem
            {
                CartId = cart.Id, // 🆕 Tự lấy CartId
                ProductId = productId,
                Quantity = quantity
            };

            var added = await _unitOfWork.CartRepository.AddCartItemAsync(cartItem);
            return added ? Result.SuccessWithObject(new { Mess = "Add successfully" }) : Result.Failure(Error.Failure("ADD_FAILED", "Failed to add item to cart"));
        }

        public async Task<Result> UpdateCartItemAsync(Guid userId, Guid cartItemId, int quantity)
        {
            // Lấy Cart của user
            var cart = await _unitOfWork.CartRepository.GetCartByUserIdAsync(userId);
            if (cart == null)
            {
                return Result.Failure(Error.NotFound("CART_NOT_FOUND", "User does not have a cart."));
            }

            var cartItem = await _unitOfWork.CartRepository.GetCartItemByIdAsync(cartItemId);
            if (cartItem == null || cartItem.CartId != cart.Id)
            {
                return Result.Failure(Error.NotFound("CART_ITEM_NOT_FOUND", "Item not found in user's cart."));
            }

            cartItem.Quantity = quantity;
            var updated = await _unitOfWork.CartRepository.UpdateCartItemQuantityAsync(cartItemId, quantity);
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
        // CartService.cs
        public async Task<Result> CreateCartByUserIdAsync(Guid userId, string email)
        {
            var existingCart = await _unitOfWork.CartRepository.GetCartByUserIdAsync(userId);
            if (existingCart != null)
            {
                return Result.Failure(Error.Conflict("CART_ALREADY_EXISTS", "User already has a cart."));
            }

            var newCart = new Cart
            {
                Id = Guid.NewGuid(),
                UserID = userId,
                Email = email,
                CartItems = new List<CartItem>()
            };

            var created = await _unitOfWork.CartRepository.CreateCartAsync(newCart);
            return created > 0 ? Result.SuccessWithObject(newCart) : Result.Failure(Error.Failure("CREATE_FAILED", "Failed to create cart"));
        }
    }
}
