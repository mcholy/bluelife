using Entities.Models;
using Shared.RequestFeatures;

namespace Contracts.IRepository.NoSql
{
    public interface IAuditRepository
    {
        Task<PagedList<Audit>> GetAllAuditsAsync(AuditParameters auditParameters);
        Task<Audit> GetAuditAsync(string auditId);
        void CreateAudit(Audit audit);
        void DeleteAuditAsync(Audit audit);
    }
}
