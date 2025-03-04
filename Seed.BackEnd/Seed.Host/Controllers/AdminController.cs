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
        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
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

    }
}
