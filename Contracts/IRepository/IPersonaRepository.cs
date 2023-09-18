using Entities.Models;
using Shared.RequestFeatures;

namespace Contracts.IRepository
{
    public interface IPersonaRepository
    {
        Task<PagedList<Persona>> GetAllPersonasAsync(PersonaParameters personaParameters, bool trackChanges);
        Task<Persona> GetPersonaAsync(Guid personaId, bool trackChanges);
        void CreatePersona(Persona persona);
        Task<IEnumerable<Persona>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        void DeletePersona(Persona persona);
    }
}
