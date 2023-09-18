using AutoMapper;
using Contracts.IRepository;
using Contracts.IService;
using Entities.ConfigurationModels;
using Entities.Models;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;

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
            SetDefaultValuesToPersona(ref personaEntity, TypeOfActions.Create);
            _repository.Persona.CreatePersona(personaEntity);
            await _repository.SaveAsync();
            var personaToReturn = _mapper.Map<PersonaDto>(personaEntity);
            return personaToReturn;
        }

        public async Task<(IEnumerable<PersonaDto> personas, MetaData metaData)> GetAllPersonasAsync(PersonaParameters personaParameters, bool trackChanges)
        {
            var personasWithMetaData = await _repository.Persona.GetAllPersonasAsync(personaParameters, trackChanges);
            var personasDto = _mapper.Map<IEnumerable<PersonaDto>>(personasWithMetaData);
            return (personas: personasDto, metaData: personasWithMetaData.MetaData);
        }


        public async Task<PersonaDto> GetPersonaAsync(Guid id, bool trackChanges)
        {
            var persona = await GetPersonaAndCheckIfItExists(id, trackChanges);
            var personaDto = _mapper.Map<PersonaDto>(persona);
            return personaDto;
        }

        private async Task<Persona> GetPersonaAndCheckIfItExists(Guid id, bool trackChanges) =>
        await _repository.Persona.GetPersonaAsync(id, trackChanges) ?? throw new Exception("Persona no existe.");

        private static void SetDefaultValuesToPersona(ref Persona persona, TypeOfActions typeAction)
        {
            if (persona == null) return;
            if (typeAction == TypeOfActions.Create)
            {
                persona.DateEntry = DateTime.UtcNow;
                persona.Estado = Constants.Status.Actived;
            }
            if (typeAction == TypeOfActions.Update) persona.DateModify = DateTime.UtcNow;
        }
    }
}
