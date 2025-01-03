using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Domain.Entities;
using Seed.Infrastructure.Interfaces.IRepositories.IGeneric;

namespace Seed.Infrastructure.Interfaces.IRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<bool> EmailExistsAsync(string email);
        Task<bool> UserNameExistsAsync(string userName);
        Task<User> GetUserByEmailAndPasswordAsync(string email, string password);
    }
}
