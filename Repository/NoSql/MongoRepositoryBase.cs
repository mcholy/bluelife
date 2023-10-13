using Contracts.IRepository.NoSql;
using Contracts.IRepository;
using MongoDB.Driver;
using System.Linq.Expressions;
using Entities.Models;

namespace Repository.NoSql
{
    public class MongoRepositoryBase<T> : IMongoRepositoryBase<T> where T : IEntity
    {
        private readonly IMongoCollection<T> _collection;

        public MongoRepositoryBase(IMongoCollection<T> collection)
        {
            _collection = collection;
        }

        public async Task<IEnumerable<T>> GetAllAsync(int? skip = null, int? limit = null)
        {
            if (skip.HasValue && limit.HasValue)
            {
                return await _collection.Find(_ => true).Skip(skip).Limit(limit).ToListAsync();
            }
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return await _collection.Find(expression).ToListAsync();
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await _collection.Find(entity => entity.Id == id).FirstOrDefaultAsync();
        }

        public async Task CreateAsync(T entity)
        {
            await _collection.InsertOneAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            var filter = Builders<T>.Filter.Eq(e => e.Id, entity.Id);
            await _collection.ReplaceOneAsync(filter, entity);
        }

        public async Task DeleteAsync(T entity)
        {
            var filter = Builders<T>.Filter.Eq(e => e.Id, entity.Id);
            await _collection.DeleteOneAsync(filter);
        }

        public async Task<long> CountAsync()
        {
            return await _collection.EstimatedDocumentCountAsync();
        }
    }
}
