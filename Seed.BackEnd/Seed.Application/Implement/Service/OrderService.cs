using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Seed.Application.Common.Result;
using Seed.Application.DTOs.Common;
using Seed.Application.Interface.IService;
using Seed.Domain.Entities;
using Seed.Infrastructure.DTOs.Common.Message;
using Seed.Infrastructure.DTOs.Order;
using Seed.Infrastructure.Interfaces;

namespace Seed.Application.Implement.Service
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public OrderService(
            IUnitOfWork unitOfWork
            
        )
        {
            _unitOfWork = unitOfWork;
            
        }

        public async Task<Result> CreateOrderAsync(CreateOrderRequest createOrderRequest)
        {
            // Step 1: Create the Order object
            var order = new Order
            {
                UserID = createOrderRequest.UserID,
                ReceiverFullName = createOrderRequest.ReceiverFullName,
                ReceiverAddress = createOrderRequest.ReceiverAddress,
                ReceiverPhone = createOrderRequest.ReceiverPhone,
                ReceiverEmail = createOrderRequest.ReceiverEmail,
                ReceiverWard = createOrderRequest.ReceiverWard,
                ReceiverDistrict = createOrderRequest.ReceiverDistrict,
                ReceiverProvince = createOrderRequest.ReceiverProvince,
                TotalPrice = createOrderRequest.TotalPrice,
                ShippingFee = createOrderRequest.ShippingFee,
                OrderService = createOrderRequest.OrderService,
                OrderNote = createOrderRequest.OrderNote,
                MoneyCollection = createOrderRequest.MoneyCollection,
                OrderItems = new List<OrderItem>()
            };

            // Step 2: Save Order to the database first
            await _unitOfWork.OrderRepository.CreateAsync(order);
            await _unitOfWork.SaveChangesAsync(); // Ensure Order.Id is generated

            var orderItems = new List<OrderItem>();

            foreach (var oi in createOrderRequest.OrderItems)
            {
                // Step 3: Validate that the Product exists
                var product = await _unitOfWork.ProductRepository.GetByIdAsync(oi.ProductId);
                if (product == null)
                {
                    return Result.Failure(Error.Failure("ORDER_CREATION_FAILED", $"Product with ID {oi.ProductId} does not exist."));
                }

                // Step 4: Create OrderItems now that Order.Id exists
                orderItems.Add(new OrderItem
                {
                    OrderId = order.Id, // Now this is a valid OrderId
                    ProductId = oi.ProductId,
                    Quantity = oi.Quantity,
                    Price = oi.Price
                });
            }

            // Step 5: Save all OrderItems
            foreach (var item in orderItems)
            {
                await _unitOfWork.OrderItemRepository.CreateAsync(item);
            }

            await _unitOfWork.SaveChangesAsync(); // Save OrderItems

            return Result.SuccessWithObject(order.Id);
        }


        public async Task<Result> GetOrderByIdAsync(Guid orderId)
        {
            var order = await _unitOfWork.OrderRepository.GetOrderByIdAsync(orderId);
            if (order == null)
            {
                return Result.Failure(OrderErrorMessage.OrderNotFound());
            }

            return Result.SuccessWithObject(order);
        }

        
        public async Task<Result> GetOrdersByUserIdAsync(Guid userId)
        {
            var orders = await _unitOfWork.OrderRepository.GetOrdersByUserIdAsync(userId);
            if (orders == null || !orders.Any())
            {
                return Result.Failure(Error.Failure("NO_ORDERS_FOUND", "No orders found for this user."));
            }

            var orderResponses = orders.Select(o => new UserOrderResponse
            {
                OrderId = o.Id,
                TotalPrice = o.TotalPrice,
                CreatedDate = o.CreatedDate, // Giả sử BaseEntity có thuộc tính này
                OrderNote = o.OrderNote,
                ShippingFee = o.ShippingFee,
                OrderService = o.OrderService
            }).ToList();

            return Result.SuccessWithObject(orderResponses);
        }

        public async Task<Result> GetOrderDetailsAsync(Guid orderId)
        {
            var order = await _unitOfWork.OrderRepository.GetOrderByIdAsync(orderId);
            if (order == null)
            {
                return Result.Failure(OrderErrorMessage.OrderNotFound());
            }

            var orderDetails = new OrderDetailResponse
            {
                OrderId = order.Id,
                TotalPrice = order.TotalPrice,
                CreatedAt = order.CreatedDate,
                OrderNote = order.OrderNote,
                ShippingFee = order.ShippingFee,
                OrderService = order.OrderService,
                Items = order.OrderItems.Select(oi => new OrderItemDetailResponse
                {
                    ProductId = oi.ProductId ?? Guid.Empty,
                    ProductName = oi.Product?.Name ?? "Unknown Product",
                    ImageUrl = oi.Product?.ImageUrl ?? "/default-product.jpg",
                    Price = oi.Price,
                    Quantity = oi.Quantity
                }).ToList()
            };

            return Result.SuccessWithObject(orderDetails);
        }
        public async Task<Result> GetOrdersWithDetailsByUserIdAsync(Guid userId)
        {
            // Lấy danh sách đơn hàng từ repository, bao gồm OrderItems và Product
            var orders = await _unitOfWork.OrderRepository.GetOrdersWithDetailsByUserIdAsync(userId);

            // Chuyển đổi sang DTO để định dạng dữ liệu cho FE
            var orderDtos = orders.Select(o => new OrderDto
            {
                Id = o.Id,
                CreatedDate = o.CreatedDate,
                OrderItems = o.OrderItems.Select(oi => new OrderItemDto
                {
                    ProductId = oi.ProductId ?? Guid.Empty,
                    ProductName = oi.Product.Name,
                    ProductImageUrl = oi.Product.ImageUrl,
                    Quantity = oi.Quantity,
                    Price = oi.Price
                }).ToList()
            }).ToList();

            return Result.SuccessWithObject(orderDtos);
        }
    }
}
