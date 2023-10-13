using Contracts.IRepository.NoSql;
using Entities.ConfigurationModels;
using Entities.Models;

namespace Repository.NoSql
{
    public sealed class MongoRepositoryManager : IMongoRepositoryManager
    {
        private readonly MongoDbContext _repositoryContext;
        private readonly Lazy<IAuditRepository> _auditRepository;
        public MongoRepositoryManager(MongoDbContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _auditRepository = new Lazy<IAuditRepository>(() => new AuditRepository(_repositoryContext.GetCollection<Audit>(MongoCollectionNames.Audits)));
        }
        public IAuditRepository Audit => _auditRepository.Value;
    }
}
