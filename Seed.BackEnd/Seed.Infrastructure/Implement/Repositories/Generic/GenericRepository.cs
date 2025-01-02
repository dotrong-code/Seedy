using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Seed.Infrastructure.Common;
using Seed.Infrastructure.DB;
using Seed.Infrastructure.Interfaces.IRepositories.IGeneric;

namespace Seed.Infrastructure.Implement.Repositories.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbSet<T> _dbSet; 
        private readonly SeedContext _context;

        public GenericRepository(SeedContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(filter);
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.AnyAsync(filter);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.CountAsync(filter);
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public async Task UpdateRangeAsync(IEnumerable<T> entities)
        {
            _dbSet.UpdateRange(entities);
        }

        public async Task DeleteAsync(object id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task DeleteRangeAsync(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public async Task<Pagination<TResult>> ToPaginationAsync<TResult>(
            int pageIndex,
            int pageSize,
            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IQueryable<T>>? include = null,
            Expression<Func<T, object>>? orderBy = null,
            bool ascending = true,
            Expression<Func<T, TResult>> selector = null)
        {
            IQueryable<T> query = _dbSet.AsNoTracking();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (include != null)
            {
                query = include(query);
            }

            orderBy ??= x => EF.Property<object>(x, "Id");

            query = ascending ? query.OrderBy(orderBy) : query.OrderByDescending(orderBy);

            var projectedQuery = query.Select(selector);

            return await Pagination<TResult>.ToPagedList(projectedQuery, pageIndex, pageSize);
        }
    }
}
