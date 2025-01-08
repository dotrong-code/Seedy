using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Application.Common.Result;
using Seed.Infrastructure.DTOs.User;
using Seed.Infrastructure.DTOs.User.Update;

namespace Seed.Application.Interface.IService
{
    public interface IUserService
    {
        Task<Result> GetUserByEmail(string email);
        Task<Result> GetAllUsersAsync(
        string? fullName = null,
        string? email = null,
        string? phoneNumber = null,
        string? address = null,
        DateTime? dateOfBirth = null,
        int? role = null,
        int pageNumber = 1,
        int pageSize = 10);
        Task<Result> GetUserByIdAsync(Guid id);
        Task<Result> UpdateUserAsync(UpdateUserRequest updateUserRequest);
        Task<Result> DeleteUserAsync(Guid id);
        Task<Result> GetAllRolesAsync();
    }
}
