using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Seed.Domain.Entities;
using Seed.Application.Interface.IService;
using Seed.Infrastructure.DTOs.Order;
using Seed.Application.Common.Result;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost("create")]
    public async Task<IResult> CreateOrder([FromBody] CreateOrderRequest createOrderRequest)
    {
        var result = await _orderService.CreateOrderAsync(createOrderRequest);
        return result.IsSuccess
            ? ResultExtensions.ToSuccessDetails(result, "Order created successfully")
            : ResultExtensions.ToProblemDetails(result);
    }

    [HttpGet("{id}")]
    public async Task<IResult> GetOrderById(Guid id)
    {
        var result = await _orderService.GetOrderByIdAsync(id);
        return result.IsSuccess
            ? ResultExtensions.ToSuccessDetails(result, "Order retrieved successfully")
            : ResultExtensions.ToProblemDetails(result);
    }

    [HttpGet("user/{userId}")]
    public async Task<IResult> GetOrdersByUserId(Guid userId)
    {
        var result = await _orderService.GetOrdersByUserIdAsync(userId);
        return result.IsSuccess
            ? ResultExtensions.ToSuccessDetails(result, "Orders retrieved successfully")
            : ResultExtensions.ToProblemDetails(result);
    }
}