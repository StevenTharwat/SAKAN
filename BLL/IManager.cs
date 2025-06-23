using System.Linq.Expressions;

namespace BLL
{
    internal interface IManager<T>
    {
        public Task AddAsync(T entity);
        public Task UpdateAsync(int id, T entity);
        public void Delete(T entity);
        public Task<T?> GetByIdAsync(int id);
        public Task<T?> GetAsync(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = true);
        public Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        public Task AddRangeAsync(IEnumerable<T> entitie);
    }
}
