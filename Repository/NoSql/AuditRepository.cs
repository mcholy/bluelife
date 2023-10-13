using Contracts.IRepository.NoSql;
using Entities.Models;
using MongoDB.Driver;
using Shared.RequestFeatures;

namespace Repository.NoSql
{
    internal sealed class AuditRepository : MongoRepositoryBase<Audit>, IAuditRepository
    {
        public AuditRepository(IMongoCollection<Audit> collection) : base(collection) { }

        public async void CreateAudit(Audit audit) => await CreateAsync(audit);

        public async void DeleteAuditAsync(Audit audit) => await DeleteAsync(audit);

        public async Task<PagedList<Audit>> GetAllAuditsAsync(AuditParameters auditParameters)
        {
            int skip = (auditParameters.PageNumber - 1) * auditParameters.PageSize;
            int limit = auditParameters.PageSize;
            var audits = await GetAllAsync(skip, limit);
            var count = (int)await CountAsync();
            return PagedList<Audit>.ToPagedList(audits, count, auditParameters.PageNumber, auditParameters.PageSize);
        }

        public Task<Audit> GetAuditAsync(string auditId)
        {
            return GetByIdAsync(auditId);
        }
    }
}
