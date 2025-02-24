using Microsoft.EntityFrameworkCore;
using Seed.Domain.Entities;
using Seed.Infrastructure.DB;
using Seed.Infrastructure.DTOs.Set.Get;
using Seed.Infrastructure.Implement.Repositories.Generic;
using Seed.Infrastructure.Interfaces.IRepositories;

namespace Seed.Infrastructure.Implement.Repositories
{
    public class SetRepository : GenericRepository<Set>, ISetRepository
    {
        public SetRepository(SeedContext context) : base(context) { }

        public async Task<IEnumerable<GetListSet>> GetListSet()
        {
            return await _context.Sets
                .Select(s => new GetListSet
                {
                    Id = s.Id,
                    Price = s.Price,
                    ImageUrl = s.ImageUrl ?? string.Empty, // Ensure it's not null
                    StockQuantity = s.StockQuantity
                })
                .ToListAsync();
        }
        public async Task<GetSetDetail> GetGetSetDetail(Guid Id)
        {
            return await _context.Sets
                .Where(s => s.Id == Id)
                .Select(s => new GetSetDetail
                {
                    Id = s.Id,
                    Price = s.Price,
                    Description = s.Description,
                    Name = s.Name,
                    Note = s.Note,
                    ListImageUrl = s.SetProducts
                        .Select(sp => sp.Product != null ? sp.Product.ImageUrl : string.Empty) // Handle potential null Product
                        .ToList()
                })
                .SingleOrDefaultAsync();
        }

        public Task<GetSetDetail> GetGetSetDetail()
        {
            throw new NotImplementedException();
        }
    }
}

