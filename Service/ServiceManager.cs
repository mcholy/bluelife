using AutoMapper;
using Contracts;
using Contracts.IRepository;
using Contracts.IService;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IPersonaService> _personaService;
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IRepositoryManager repositoryManager,
            IMapper mapper,
            ILoggerManager logger,
            UserManager<Usuario> userManager,
            IConfiguration configuration)
        {
            _personaService = new Lazy<IPersonaService>(() => new PersonaService(repositoryManager, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(logger, mapper, userManager, configuration));
        }

        public IPersonaService PersonaService => _personaService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;

    }
}
