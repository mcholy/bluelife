namespace Contracts.IRepository.NoSql
{
    public interface IMongoRepositoryManager
    {
        IAuditRepository Audit { get; }
    }
}
