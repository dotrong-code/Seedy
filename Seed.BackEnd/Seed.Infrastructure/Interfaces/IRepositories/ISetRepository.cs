using Seed.Domain.Entities;
using Seed.Infrastructure.DTOs.Set.Get;
using Seed.Infrastructure.Interfaces.IRepositories.IGeneric;

namespace Seed.Infrastructure.Interfaces.IRepositories
{
    public interface ISetRepository : IGenericRepository<Set>
    {
        public Task<IEnumerable<GetListSet>> GetListSet();
        public Task<GetSetDetail> GetSetDetail(Guid id);
    }
}
