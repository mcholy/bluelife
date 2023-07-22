namespace Contracts.IRepository
{
    public interface IRepositoryManager
    {
        IPersonaRepository Persona { get; }
        Task SaveAsync();
    }
}
