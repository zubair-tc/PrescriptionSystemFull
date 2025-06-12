using System.Linq.Expressions;

namespace PrescriptionSystem.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        // Basic CRUD Operations
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

        // Pagination
        //Task<IEnumerable<T>> GetPagedAsync(int pageNumber, int pageSize);

        // Aggregates
        //Task<int> CountAsync();
        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);

        // Modification Operations
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task Update(T entity);
        Task Remove(T entity);
        Task RemoveRange(IEnumerable<T> entities);

        // Related Data Loading
        Task<T> GetByIdWithIncludesAsync(int id, params Expression<Func<T, object>>[] includes);
        Task<IEnumerable<T>> GetAllWithIncludesAsync(params Expression<Func<T, object>>[] includes);
    }
}
