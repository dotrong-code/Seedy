using Microsoft.AspNetCore.Mvc;
using Seed.Application.Common.Result;
using Seed.Application.Interface.IService;
using Seed.Infrastructure.DTOs.ViettelPost;

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
        public async Task<IResult> GetProvinces([FromHeader] string token)
        {
            var result = await _viettelPostService.GetProvincesAsync(token);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Getting successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("districts/{provinceId}")]
        public async Task<IResult> GetDistricts(int provinceId, [FromHeader] string token)
        {
            var result = await _viettelPostService.GetDistrictsAsync(provinceId, token);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Getting successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("wards/{districtId}")]
        public async Task<IResult> GetWards(int districtId, [FromHeader] string token)
        {
            var result = await _viettelPostService.GetWardsAsync(districtId, token);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Getting successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpPost("shipping-price")]
        public async Task<IResult> GetShippingPrice([FromBody] ViettelShippingPriceRequest request, [FromHeader] string token)
        {
            var result = await _viettelPostService.GetShippingPriceAsync(request, token);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Getting successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}
