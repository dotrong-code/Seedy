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
            //var result = await _paymentService.GetAllPaymentsAsync();
            var result = await _adminService.GetPayments();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Payments retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpGet("revenues")]
        public async Task<IResult> GetAllRevenue()
        {
            var result = await _adminService.GetDashboardRevenue();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Revenue retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

    }
}
