using Contracts.IRepository;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    internal sealed class PersonaRepository : RepositoryBase<Persona>, IPersonaRepository
    {
        public PersonaRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public void CreatePersona(Persona persona) => Create(persona);

        public void DeletePersona(Persona persona) => Delete(persona);

        public async Task<IEnumerable<Persona>> GetAllPersonasAsync(bool trackChanges) =>
        await FindAll(trackChanges)
        .OrderBy(c => c.Nombre)
        .ToListAsync();

        public async Task<IEnumerable<Persona>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.Id), trackChanges).ToListAsync();

        public async Task<Persona> GetPersonaAsync(Guid personaId, bool trackChanges)
        {
            var persona = await FindByCondition(c => c.Id.Equals(personaId), trackChanges).SingleOrDefaultAsync();
            return persona!;
        }
    }
}
