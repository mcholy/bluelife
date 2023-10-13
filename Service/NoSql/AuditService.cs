using Contracts.IRepository.NoSql;
using Contracts.IService.NoSql;
using Entities.ConfigurationModels;
using Entities.Models;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;

namespace Service.NoSql
{
    internal sealed partial class AuditService : IAuditService
    {

        private readonly IMongoRepositoryManager _repository;

        public AuditService(IMongoRepositoryManager repository)
        {
            _repository = repository;
        }
        public Task<AuditDto> CreateAuditAsync(AuditForCreationDto audit)
        {
            var auditEntity = MapDtoToEntity(audit);
            SetDefaultValuesToAudit(ref auditEntity, TypeOfActions.Create);
            _repository.Audit.CreateAudit(auditEntity);
            var auditToReturn = MapEntityToDto(auditEntity);
            return Task.FromResult(auditToReturn);
        }

        public async Task<(IEnumerable<AuditDto> audits, MetaData metaData)> GetAllAuditsAsync(AuditParameters auditParameters)
        {
            var auditWithMetaData = await _repository.Audit.GetAllAuditsAsync(auditParameters);
            List<AuditDto> auditsDto = new();
            foreach (var item in auditWithMetaData)
            {
                auditsDto.Add(MapEntityToDto(item));
            }
            return (audits: auditsDto, metaData: auditWithMetaData.MetaData);
        }

        public async Task<AuditDto> GetAuditAsync(string id)
        {
            var audit = await GetAuditAndCheckIfItExists(id);
            var auditDto = MapEntityToDto(audit);
            return auditDto;
        }

        private async Task<Audit> GetAuditAndCheckIfItExists(string id) =>
        await _repository.Audit.GetAuditAsync(id) ?? throw new Exception("Audit no existe.");

    }
}
