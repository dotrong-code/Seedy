using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;
using Seed.Application.Common.Result;
using Seed.Application.DTOs.User.Login;
using Seed.Application.Interface.IService;

namespace Seed.Host.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("sign-in")]
        public async Task<IResult> SignInForUser(LoginRequest loginRequest)
        {
            Result result = await _authService.SignIn(loginRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Login successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}
