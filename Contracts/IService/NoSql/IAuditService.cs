using Shared.DataTransferObjects;
using Shared.RequestFeatures;

namespace Contracts.IService.NoSql
{
    public interface IAuditService
    {
        Task<(IEnumerable<AuditDto> audits, MetaData metaData)> GetAllAuditsAsync(AuditParameters auditParameters);
        Task<AuditDto> GetAuditAsync(string id);
        Task<AuditDto> CreateAuditAsync(AuditForCreationDto audit);
    }
}
