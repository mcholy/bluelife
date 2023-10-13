using Contracts.IService.NoSql;
using Entities.ConfigurationModels;
using Entities.Models;
using MongoDB.Bson;
using Shared.DataTransferObjects;

namespace Service.NoSql
{
    internal sealed partial class AuditService : IAuditService
    {

        private static Audit MapDtoToEntity(AuditForCreationDto dto)
        {
            return new Audit
            {
                UserName = dto.UserName,
                CompanyName = dto.CompanyName,
                Details = dto.Details,
            };
        }

        private static AuditDto MapEntityToDto(Audit entity)
        {
            return new AuditDto
            {
                Id = entity.Id,
                UserName = entity.UserName,
                CompanyName = entity.CompanyName,
                Details = entity.Details,
                DateEntry = entity.DateEntry
            };
        }

        private static void SetDefaultValuesToAudit(ref Audit audit, TypeOfActions typeAction)
        {
            if (audit == null) return;
            if (typeAction == TypeOfActions.Create)
            {
                audit.Id = ObjectId.GenerateNewId().ToString();
                audit.DateEntry = DateTime.UtcNow;
            }
        }
    }
}
