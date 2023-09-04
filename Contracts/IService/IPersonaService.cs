using Shared.DataTransferObjects;

namespace Contracts.IService
{
    public interface IPersonaService
    {
        Task<IEnumerable<PersonaDto>> GetAllPersonasAsync(bool trackChanges);
        Task<PersonaDto> GetPersonaAsync(Guid id, bool trackChanges);
        Task<PersonaDto> CreatePersonaAsync(PersonaForCreationDto persona);
    }
}
