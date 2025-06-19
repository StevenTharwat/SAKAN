using DAL;
using DAL.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BLL
{
    public class Manager<T> : IManager<T> where T : class
    {
        private readonly Context _context;
        private DbSet<T> _dbSet;
        public Manager(Context context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRange(IEnumerable<T> entitie)
        {
            await _dbSet.AddRangeAsync(entitie);
        }

        public void Delete(T entity)
        {
            // Soft delete implementation
            if (entity is ISoftDelete softDeleteEntity)
            {
                softDeleteEntity.IsDeleted = true;
                _dbSet.Update(entity);
            }
            else
            {
                _dbSet.Remove(entity);
            }
        }

        public async Task<T?> Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = true)
        {
            IQueryable<T> query;
            if (tracked)
            {
                query = _dbSet;
            }
            else
            {
                query = _dbSet.AsNoTracking();
            }
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var property in includeProperties
                    .Split([','], StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(property);
                }
            }
            if (typeof(ISoftDelete).IsAssignableFrom(typeof(T)))
            {
                query = query.Where(e => !( (ISoftDelete) e ).IsDeleted);
            }
            query = query.Where(filter);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
        {
            IQueryable<T> query = _dbSet;

            if (typeof(ISoftDelete).IsAssignableFrom(typeof(T)))
            {
                query = query.Where(e => !( (ISoftDelete) e ).IsDeleted);
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var property in includeProperties
                    .Split([','], StringSplitOptions.RemoveEmptyEntries))
                {

                    query = query.Include(property);
                }
            }

            return await query.ToListAsync();
        }

        public async Task<T?> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task Update(int id, T entity)
        {
            T? oldItem = await GetById(id);
            if (oldItem == null) return;
            var entry = _context.Entry<T>(oldItem);
            entry.CurrentValues.SetValues(entity);
            entry.State = EntityState.Modified;
            _dbSet.Update(oldItem);
        }
    }
}
