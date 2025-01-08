using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Seed.Application.Common.Result;
using Seed.Application.Common;
using Seed.Application.DTOs.Common;
using Seed.Application.Interface.IService;
using Seed.Infrastructure.DTOs.User;
using Seed.Infrastructure.DTOs.User.Update;
using Seed.Infrastructure.DTOs.User.Get;

namespace Seed.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IUserService _userService;
        public UserController(IHttpContextAccessor contextAccessor, IUserService userService)
        {
            _contextAccessor = contextAccessor;
            _userService = userService;
        }
        [Authorize]
        [HttpGet("user-infor")]
        public async Task<IResult> GetUserInfor()
        {
            CurrentUserObject c = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            var result = await _userService.GetUserByEmail(c.Email);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Register successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        [Authorize]
        [HttpGet("users/search")]
        public async Task<IResult> GetAllUsers(
        [FromQuery] string? fullName = null,
        [FromQuery] string? email = null,
        [FromQuery] string? phoneNumber = null,
        [FromQuery] string? address = null,
        [FromQuery] DateTime? dateOfBirth = null,
        [FromQuery] int? role = null,
        [FromQuery] int pageNumber = 1,
        [FromQuery] int pageSize = 10)
        {
            var result = await _userService.GetAllUsersAsync(
                fullName, email, phoneNumber, address, dateOfBirth, role, pageNumber, pageSize);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "All users retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpGet]
        public async Task<IResult> GetUserById([FromQuery] GetUserRequest request)
        {
            var result = await _userService.GetUserByIdAsync(request.Id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "User retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpPut]
        public async Task<IResult> UpdateUser([FromBody] UpdateUserRequest updateUserRequest)
        {
            var result = await _userService.UpdateUserAsync(updateUserRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "User updated successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
        [HttpDelete]
        public async Task<IResult> DeleteUser([FromQuery] GetUserRequest request)
        {
            var result = await _userService.DeleteUserAsync(request.Id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "User deleted successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet("roleList")]
        public async Task<IResult> GetAllRoles()
        {
            var result = await _userService.GetAllRolesAsync();
            return result.IsSuccess
               ? ResultExtensions.ToSuccessDetails(result, "All roles retrieved successfully")
               : ResultExtensions.ToProblemDetails(result);
        }
    }
}
