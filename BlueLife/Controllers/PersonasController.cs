using Contracts.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;
using System.Text.Json;

namespace BlueLife.Controllers
{
    [Route("api/personas")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly IServiceManager _service;

        public PersonasController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet(Name = "GetPersonas")]
        [Authorize(Roles = "Manager")]
        [Authorize]
        public async Task<IActionResult> GetPersonas([FromQuery] PersonaParameters personaParameters)
        {
            var (personas, metaData) = await _service.PersonaService.GetAllPersonasAsync(personaParameters, trackChanges: false);
            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metaData));
            return Ok(personas);
        }

        [HttpGet("{id:guid}", Name = "PersonaById")]
        public async Task<IActionResult> GetPersona(Guid id)
        {
            var persona = await _service.PersonaService.GetPersonaAsync(id, trackChanges: false);
            return Ok(persona);
        }

        [HttpPost(Name = "CreatePersona")]
        public async Task<IActionResult> CreatePersona([FromBody] PersonaForCreationDto persona)
        {
            var createdPersona = await _service.PersonaService.CreatePersonaAsync(persona);
            return CreatedAtRoute("PersonaById", new { id = createdPersona.Id }, createdPersona);
        }
    }
}
