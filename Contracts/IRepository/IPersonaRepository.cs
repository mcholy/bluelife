using Entities.Models;

namespace Contracts.IRepository
{
    public interface IPersonaRepository
    {
        Task<IEnumerable<Persona>> GetAllPersonasAsync(bool trackChanges);
        Task<Persona> GetPersonaAsync(Guid personaId, bool trackChanges);
        void CreatePersona(Persona persona);
        Task<IEnumerable<Persona>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        void DeletePersona(Persona persona);
    }
}
