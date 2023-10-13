using Contracts.IService.NoSql;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;
using System.Text.Json;

namespace BlueLife.Controllers
{
    [Route("api/audits")]
    [ApiController]
    [Authorize]
    public class AuditsController : ControllerBase
    {
        private readonly IMongoServiceManager _service;

        public AuditsController(IMongoServiceManager service)
        {
            _service = service;
        }

        [HttpGet(Name = "GetAudits")]
        public async Task<IActionResult> GetAudits([FromQuery] AuditParameters auditParameters)
        {
            var (audits, metaData) = await _service.AuditService.GetAllAuditsAsync(auditParameters);
            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metaData));
            return Ok(audits);
        }

        [HttpGet("{id}", Name = "AuditById")]
        public async Task<IActionResult> GetAudit(string id)
        {
            var audit = await _service.AuditService.GetAuditAsync(id);
            return Ok(audit);
        }

        [HttpPost(Name = "CreateAudit")]
        public async Task<IActionResult> CreateAudit([FromBody] AuditForCreationDto audit)
        {
            var createdAudit = await _service.AuditService.CreateAuditAsync(audit);
            return CreatedAtRoute("AuditById", new { id = createdAudit.Id }, createdAudit);
        }
    }
}
