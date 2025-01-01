using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Domain.Entities;
using Seed.Infrastructure.Interfaces.IRepositories.IGeneric;
using Seed.Infrastructure.Interfaces.IRepositories;
using Seed.Infrastructure.DB;
using Seed.Infrastructure.Implement.Repositories.Generic;

namespace Seed.Infrastructure.Implement.Repositories
{
    public class CartItemRepository : GenericRepository<CartItem>, ICartItemRepository
    {
        public CartItemRepository(SeedContext context) : base(context) { }
    }
}
