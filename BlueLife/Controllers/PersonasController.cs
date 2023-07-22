using Contracts.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            //throw new Exception("Exception");
            var Personas = await _service.PersonaService.GetAllPersonasAsync(trackChanges: false);
            return Ok(Personas);
        }

        [HttpGet("{id:guid}", Name = "PersonaById")]
        public async Task<IActionResult> GetPersona(Guid id)
        {
            var Persona = await _service.PersonaService.GetPersonaAsync(id, trackChanges: false);
            return Ok(Persona);
        }
    }
}
