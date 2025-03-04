using Seed.Domain.Entities;
using Seed.Infrastructure.DTOs.User.Get;
using Seed.Infrastructure.Interfaces.IRepositories.IGeneric;

namespace Seed.Infrastructure.Interfaces.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<bool> EmailExistsAsync(string email);
        Task<bool> UserNameExistsAsync(string userName);
        Task<User> GetUserByEmailAndPasswordAsync(string email, string password);
        Task<(List<GetUserResponse> Users, int TotalCount)> GetAllUsersAsync(
        string? fullName = null,
        string? email = null,
        string? phoneNumber = null,
        string? address = null,
        DateTime? dateOfBirth = null,
        int? role = null,
        int pageNumber = 1,
        int pageSize = 10);
        Task<User> GetUserByIdAsync(Guid id);
        Task<List<Role>> GetAllRolesAsync();
        Task<int> DeleteUserAsync(Guid id);

        Task<List<User>> GetUsers();
    }
}
