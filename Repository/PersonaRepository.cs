using Contracts.IRepository;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Extensions;
using Shared.RequestFeatures;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Repository
{
    internal sealed class PersonaRepository : RepositoryBase<Persona>, IPersonaRepository
    {
        public PersonaRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

        public void CreatePersona(Persona persona) => Create(persona);

        public void DeletePersona(Persona persona) => Delete(persona);

        public async Task<PagedList<Persona>> GetAllPersonasAsync(PersonaParameters personaParameters, bool trackChanges)
        {
            var personas = await FindAll(trackChanges)
                .Search(personaParameters.SearchTerm)
                .OrderBy(c => c.Nombre)
                .Skip((personaParameters.PageNumber - 1) * personaParameters.PageSize)
                .Take(personaParameters.PageSize)
                .ToListAsync();
            var count = await FindAll(trackChanges).CountAsync();
            return PagedList<Persona>.ToPagedList(personas, count, personaParameters.PageNumber, personaParameters.PageSize);
        }

        public async Task<IEnumerable<Persona>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.Id), trackChanges).ToListAsync();

        public async Task<Persona> GetPersonaAsync(Guid personaId, bool trackChanges)
        {
            var persona = await FindByCondition(c => c.Id.Equals(personaId), trackChanges).SingleOrDefaultAsync();
            return persona!;
        }
    }
}
