using Contracts.IRepository;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IPersonaRepository> _personaRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _personaRepository = new Lazy<IPersonaRepository>(() => new PersonaRepository(repositoryContext));
        }
        public IPersonaRepository Persona => _personaRepository.Value;
        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
