using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Seed.Domain.Entities;
using Seed.Infrastructure.DB;
using Seed.Infrastructure.Implement.Repositories.Generic;
using Seed.Infrastructure.Interfaces.IRepositories;

namespace Seed.Infrastructure.Implement.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(SeedContext context) : base(context) { }
        // Kiểm tra xem Email đã tồn tại hay chưa
        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _dbSet.AsNoTracking().AnyAsync(user => user.Email == email);
        }

        // Kiểm tra xem Username đã tồn tại hay chưa
        public async Task<bool> UserNameExistsAsync(string userName)
        {
            return await _dbSet.AsNoTracking().AnyAsync(user => user.Username == userName);
        }
    }
}