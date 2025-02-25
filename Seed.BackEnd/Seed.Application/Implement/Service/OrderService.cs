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
            return Result.SuccessWithObject(orders);
        }
    }
}
