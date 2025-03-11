using Microsoft.AspNetCore.Mvc;
using Seed.Application.Common.Result;
using Seed.Application.Interface.IService;

namespace Seed.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;
        private readonly IPaymentService _paymentService;
        public AdminController(IAdminService adminService, IPaymentService paymentService)
        {
            _adminService = adminService;
            _paymentService = paymentService;
        }

        [HttpGet("users")]
        public async Task<IResult> GetUsers()
        {
            var result = await _adminService.GetUsers();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Get successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpGet("products")]
        public async Task<IResult> GetProducts()
        {
            var result = await _adminService.GetProducts();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Get successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpGet("orders")]
        public async Task<IResult> GetOrders()
        {
            var result = await _adminService.GetOrders();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Get successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpGet("payments")]
        public async Task<IResult> GetAllPayments()
        {
            var result = await _paymentService.GetAllPaymentsAsync();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Payments retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

    }
}
