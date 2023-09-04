using Contracts.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.DataTransferObjects;

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

        [HttpGet]
        public async Task<IActionResult> GetPersonas()
        {
            var personas = await _service.PersonaService.GetAllPersonasAsync(trackChanges: false);
            return Ok(personas);
        }

        [HttpGet("{id:guid}", Name = "PersonaById")]
        public async Task<IActionResult> GetPersona(Guid id)
        {
            var persona = await _service.PersonaService.GetPersonaAsync(id, trackChanges: false);
            return Ok(persona);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePersona([FromBody] PersonaForCreationDto persona)
        {
            var createdPersona = await _service.PersonaService.CreatePersonaAsync(persona);
            return CreatedAtRoute("PersonaById", new { id = createdPersona.Id }, createdPersona);
        }
    }
}
