using Microsoft.AspNetCore.Mvc;
using Seed.Application.Common.Result;
using Seed.Application.Interface.IService;

namespace Seed.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetController : ControllerBase
    {
        private readonly ISetService _setService;
        public SetController(ISetService setService)
        {
            _setService = setService;
        }
        #region
        [HttpGet("list")]
        public async Task<IResult> GetListSet()
        {
            var result = await _setService.GetListSet();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Set get successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpGet("{id}")]
        public async Task<IResult> GetDetail(Guid id)
        {
            var result = await _setService.GetSetDetail(id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Set get successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        #endregion
    }
}
