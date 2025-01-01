using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seed.Domain.Entities;
using Seed.Infrastructure.Interfaces.IRepositories.IGeneric;

namespace Seed.Infrastructure.Interfaces.IRepositories
{
    public interface IOrderItemRepository : IGenericRepository<OrderItem>
    {
    }
}
