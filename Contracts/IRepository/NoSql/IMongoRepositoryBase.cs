using Entities.Models;
using System.Linq.Expressions;

namespace Contracts.IRepository.NoSql
{
    public interface IMongoRepositoryBase<T> where T : IEntity
    {
        Task<IEnumerable<T>> GetAllAsync(int? skip = null, int? limit = null);
        Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> expression);
        Task<T> GetByIdAsync(string id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
