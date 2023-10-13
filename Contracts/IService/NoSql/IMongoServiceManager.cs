namespace Contracts.IService.NoSql
{
    public interface IMongoServiceManager
    {
        IAuditService AuditService { get; }
    }
}
