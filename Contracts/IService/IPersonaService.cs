using Shared.DataTransferObjects;
using Shared.RequestFeatures;

namespace Contracts.IService
{
    public interface IPersonaService
    {
        Task<(IEnumerable<PersonaDto> personas, MetaData metaData)> GetAllPersonasAsync(PersonaParameters personaParameters, bool trackChanges);
        Task<PersonaDto> GetPersonaAsync(Guid id, bool trackChanges);
        Task<PersonaDto> CreatePersonaAsync(PersonaForCreationDto persona);
    }
}
