using AutoMapper;
using Contracts.IRepository;
using Contracts.IService;
using Microsoft.Extensions.Logging;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IPersonaService> _personaService;

        public ServiceManager(IRepositoryManager repositoryManager,
            IMapper mapper)
        {
            _personaService = new Lazy<IPersonaService>(() => new PersonaService(repositoryManager, mapper));
        }

        public IPersonaService PersonaService => _personaService.Value;

    }
}
