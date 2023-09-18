using Entities.Models;

namespace Repository.Extensions
{
    public static class RepositoryPersonaExtensions
    {
        /* public static IQueryable<Persona> FilterPersonas(this IQueryable<Persona> personas, uint minAge, uint maxAge) =>
             personas.Where(e => (e.Age >= minAge && e.Age <= maxAge)); 
        */
        public static IQueryable<Persona> Search(this IQueryable<Persona> personas, string? searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm)) return personas;
            var lowerCaseTerm = searchTerm.Trim().ToLower();
            return personas.Where(e => e.Nombre!.ToLower().Contains(lowerCaseTerm) || e.ApPaterno!.ToLower().Contains(lowerCaseTerm)
            || e.ApMaterno!.ToLower().Contains(lowerCaseTerm) || e.Documento!.ToLower().Contains(lowerCaseTerm));
        }
    }
}
