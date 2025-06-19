using System.Linq.Expressions;

namespace BLL
{
    internal interface IManager<T>
    {
        public Task Add(T entity);
        public Task Update(int id, T entity);
        public void Delete(T entity);
        public Task<T?> GetById(int id);
        public Task<T?> Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = true);
        public Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        public Task AddRange(IEnumerable<T> entitie);
    }
}
