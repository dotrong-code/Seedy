using Microsoft.AspNetCore.Mvc;
using Seed.Application.Common.Result;
using Seed.Application.Interface.IService;
using Seed.Infrastructure.DTOs.ViettelPost;
using System.Threading.Tasks;

namespace Seed.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViettelPostController : ControllerBase
    {
        private readonly IViettelPostService _viettelPostService;

        public ViettelPostController(IViettelPostService viettelPostService)
        {
            _viettelPostService = viettelPostService;
        }

        [HttpPost("login")]
        public async Task<IResult> Login([FromBody] ViettelLoginRequest request)
        {
            var result = await _viettelPostService.LoginAsync(request);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Login successful")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpPost("owner-connect")]
        public async Task<IResult> ConnectOwner([FromBody] ViettelLoginRequest request, [FromHeader] string token)
        {
            var result = await _viettelPostService.ConnectOwnerAsync(request, token);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Owner connected successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpGet("provinces")]
        public async Task<IActionResult> GetProvinces([FromHeader] string token)
        {
            var result = await _viettelPostService.GetProvincesAsync(token);
            return result.IsSuccess ? Ok(result.Object) : BadRequest(result.Error);
        }

        [HttpGet("districts/{provinceId}")]
        public async Task<IActionResult> GetDistricts(int provinceId, [FromHeader] string token)
        {
            var result = await _viettelPostService.GetDistrictsAsync(provinceId, token);
            return result.IsSuccess ? Ok(result.Object) : BadRequest(result.Error);
        }

        [HttpGet("wards/{districtId}")]
        public async Task<IActionResult> GetWards(int districtId, [FromHeader] string token)
        {
            var result = await _viettelPostService.GetWardsAsync(districtId, token);
            return result.IsSuccess ? Ok(result.Object) : BadRequest(result.Error);
        }
        [HttpPost("shipping-price")]
        public async Task<IActionResult> GetShippingPrice([FromBody] ViettelShippingPriceRequest request, [FromHeader] string token)
        {
            var result = await _viettelPostService.GetShippingPriceAsync(request, token);
            return result.IsSuccess ? Ok(result.Object) : BadRequest(result.Error);
        }
    }
}
