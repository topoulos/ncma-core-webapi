namespace Ncma.Repository.EFCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using Omu.ValueInjecter;

    public class BaseRepository<T> : IRepository<T> where T : class, IDataModel
    {
        internal readonly NcmaContext _context;

        public BaseRepository(NcmaContext context)
        {
            _context = context;
        }

        public async Task<T> DeleteAsync(int id, bool isHardDelete = false)
        {
            T entity = await _context.Set<T>().Where(m => m.Id == id).SingleAsync();

            if (isHardDelete)
            {
                _context.Set<T>().Remove(entity);
            }
            else
            {
                entity.IsActive = false;
            }

            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            using (var context = new NcmaContext())
            {
                return await context.Set<T>().FindAsync(id);
            }
        }

        public IEnumerable<T> Include(params Expression<Func<T, object>>[] includes)
        {
            DbSet<T> dbSet = _context.Set<T>();

            IEnumerable<T> query = null;
            foreach (Expression<Func<T, object>> include in includes)
            {
                query = dbSet.Include(include);
            }

            return query ?? dbSet;
        }

        public async Task<T> SaveAsync(int? id, T entity)
        {
            bool creating = !id.HasValue;

            if (creating)
            {
                _context.Set<T>().Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }

            T updating = await _context.Set<T>().FindAsync(id);
            updating = Mapper.Map<T>(entity);
            _context.Set<T>().Update(updating);
            await _context.SaveChangesAsync();
            return updating;
        }

        public async Task<List<T>> GetActiveAsync()
        {
            return await _context.Set<T>()
                .Where(x => x.IsActive)
                .ToListAsync();
        }

        public async Task<List<T>> GetInactiveAsync()
        {
            return await _context.Set<T>()
                .Where(x => x.IsActive == false)
                .ToListAsync();
        }

        public async Task<List<T>> QueryAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>()
                .Where(predicate)
                .ToListAsync();
        }
    }
}