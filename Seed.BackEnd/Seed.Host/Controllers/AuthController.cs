using Google.Apis.Auth;

using Microsoft.AspNetCore.Mvc;
using Seed.Application.Common;
using Seed.Application.Common.Result;
using Seed.Application.DTOs.User.Login;
using Seed.Application.DTOs.User.Register;
using Seed.Application.Interface.IService;

namespace Seed.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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

        [HttpPost("sign-up")]
        public async Task<IResult> RegisterForUser([FromBody] RegisterRequest registerRequest)
        {
            Result result = await _authService.SignUp(registerRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Register successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("confirm")]
        public async Task<IActionResult> ConfirmEmail(Guid userId)
        {
            Result result = await _authService.ConfirmEmail(userId);

            if (result.IsSuccess)
            {
                return Redirect($"{CommonObject.Domain}/Account/SignIn");
            }

            return (IActionResult)ResultExtensions.ToProblemDetails(result);
        }




        [HttpPost("google-sign-in")]
        public async Task<IActionResult> GoogleSignIn([FromBody] GoogleSignInRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.IdToken))
            {
                return BadRequest("ID token is required.");
            }

            try
            {
                // Validate the ID token with Google
                var payload = await GoogleJsonWebSignature.ValidateAsync(request.IdToken);

                // Tìm hoặc tạo người dùng trong hệ thống của bạn
                var user = await _authService.FindOrCreateUser(payload);

                // Tạo JWT token cho người dùng (nếu cần)
                var token = _authService.GenerateJwtToken(user.Email, 2, 120); // Bạn cần triển khai phương thức này

                return Ok(new { Token = token, User = user });
            }
            catch (Exception ex)
            {
                return BadRequest($"Google sign-in failed: {ex.Message}");
            }
        }
    }
}
