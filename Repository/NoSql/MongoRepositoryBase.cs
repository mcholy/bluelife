using Contracts.IRepository.NoSql;
using Contracts.IRepository;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Repository.NoSql
{
    public class MongoRepositoryBase<T> : IMongoRepositoryBase<T> where T : IEntity
    {
        private readonly IMongoCollection<T> _collection;

        public MongoRepositoryBase(IMongoCollection<T> collection)
        {
            _collection = collection;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> expression)
        {
            return await _collection.Find(expression).ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
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
    }
}
