using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Usuario : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        [ForeignKey(nameof(Persona))]
        public Guid PersonaId { get; set; }
        [ForeignKey(nameof(Empresa))]
        public Guid? EmpresaId { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime? DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid? IdUserModify { get; set; }
        public string? Estado { get; set; }
        public Persona? Persona { get; set; }
        public Empresa? Empresa { get; set; }
    }
}
