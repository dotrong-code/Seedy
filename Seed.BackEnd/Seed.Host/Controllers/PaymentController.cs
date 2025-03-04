using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Seed.Application.Common;
using Seed.Application.Common.Result;
using Seed.Application.DTOs.Common;
using Seed.Application.Interface.IService;
using Seed.Infrastructure.DTOs.Order;
using System.Security.Claims;

namespace Seed.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet("all")]
        public async Task<IResult> GetAllPayments()
        {
            var result = await _paymentService.GetAllPaymentsAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Payments retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("check")]
        public async Task<IResult> CheckPayment([FromQuery] string accountNumber, [FromQuery] decimal amount, [FromQuery] string description)
        {
            var userId = await GetUserIdFromTokenAsync();
            if (!userId.HasValue)
            {
                return ResultExtensions.ToProblemDetails(Result.Failure(Error.Unauthorized("INVALID_TOKEN", "Invalid or missing UserId in token.")));
            }

            var result = await _paymentService.CheckPaymentAsync(accountNumber, amount, description, userId.Value);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Payment checked successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpPost("create-and-check")]
        public async Task<IResult> CreateOrderAndCheckPayment([FromBody] OrderRequest orderRequest)
        {
            var userId = await GetUserIdFromTokenAsync();
            if (!userId.HasValue)
            {
                return ResultExtensions.ToProblemDetails(Result.Failure(Error.Unauthorized("INVALID_TOKEN", "Invalid or missing UserId in token.")));
            }

            var result = await _paymentService.CreateOrderAndCheckPaymentAsync(orderRequest, userId.Value);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Payment and order created successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpPost("create-cod")]
        public async Task<IResult> CreateOrderCOD([FromBody] OrderRequest orderRequest)
        {
            var userId = await GetUserIdFromTokenAsync();
            if (!userId.HasValue)
            {
                return ResultExtensions.ToProblemDetails(Result.Failure(Error.Unauthorized("INVALID_TOKEN", "Invalid or missing UserId in token.")));
            }

            var result = await _paymentService.CreateOrderCODAsync(orderRequest, userId.Value);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "COD order created successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        private async Task<Guid?> GetUserIdFromTokenAsync()
        {
            var currentUser = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            return currentUser?.UserId;
        }
    }
}