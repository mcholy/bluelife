using AutoMapper;
using Contracts.IRepository;
using Contracts.IService;
using Entities.Models;
using Microsoft.Extensions.Logging;
using Shared.DataTransferObjects;

namespace Service
{
    internal sealed class PersonaService : IPersonaService
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public PersonaService(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PersonaDto> CreatePersonaAsync(PersonaForCreationDto persona)
        {
            var personaEntity = _mapper.Map<Persona>(persona);
            _repository.Persona.CreatePersona(personaEntity);
            await _repository.SaveAsync();
            var personaToReturn = _mapper.Map<PersonaDto>(personaEntity);
            return personaToReturn;
        }

        public async Task<IEnumerable<PersonaDto>> GetAllPersonasAsync(bool trackChanges)
        {
            var personas = await _repository.Persona.GetAllPersonasAsync(trackChanges);
            var personasDto = _mapper.Map<IEnumerable<PersonaDto>>(personas);
            return personasDto;
        }


        public async Task<PersonaDto> GetPersonaAsync(Guid id, bool trackChanges)
        {
            var persona = await GetPersonaAndCheckIfItExists(id, trackChanges);
            var personaDto = _mapper.Map<PersonaDto>(persona);
            return personaDto;
        }

        private async Task<Persona> GetPersonaAndCheckIfItExists(Guid id, bool trackChanges) =>
        await _repository.Persona.GetPersonaAsync(id, trackChanges) ?? throw new Exception("Persona no existe.");
    }
}
