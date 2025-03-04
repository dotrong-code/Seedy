using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Seed.Domain.Entities;
using Seed.Application.Interface.IService;
using Seed.Infrastructure.DTOs.Order;
using Seed.Application.Common.Result;
using Seed.Application.Common;

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

    [HttpGet("user-orders")]
    public async Task<IResult> GetOrdersByUserId(Guid userId)
    {
        var currentUser = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
        var result = await _orderService.GetOrdersByUserIdAsync(currentUser.UserId);
        return result.IsSuccess
            ? ResultExtensions.ToSuccessDetails(result, "Orders retrieved successfully")
            : ResultExtensions.ToProblemDetails(result);
    }

    [HttpGet("details/{orderId}")]
    public async Task<IResult> GetOrderDetails(Guid orderId)
    {
        var result = await _orderService.GetOrderDetailsAsync(orderId);
        return result.IsSuccess
            ? ResultExtensions.ToSuccessDetails(result, "Order details retrieved successfully")
            : ResultExtensions.ToProblemDetails(result);
    }
    [HttpGet("user/details")]
    public async Task<IResult> GetOrdersWithDetailsByUserId()
    {
        var currentUser = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
        var result = await _orderService.GetOrdersWithDetailsByUserIdAsync(currentUser.UserId);
        return result.IsSuccess
            ? ResultExtensions.ToSuccessDetails(result, "Orders retrieved successfully")
            : ResultExtensions.ToProblemDetails(result);
    }

}