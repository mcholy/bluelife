namespace Contracts.IService
{
    public interface IServiceManager
    {
        IPersonaService PersonaService { get; }
        IAuthenticationService AuthenticationService { get; }
    }
}
