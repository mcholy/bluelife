using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Contrasenia { get; set; }
        public string? Email { get; set; }
        [ForeignKey(nameof(TipoUsuario))]
        public Guid TipoUsuarioId { get; set; }
        [ForeignKey(nameof(Persona))]
        public Guid PersonaId { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid IdUserModify { get; set; }
        public string? Estado { get; set; }
        public TipoUsuario? TipoUsuario { get; set; }
        public Persona? Persona { get; set; }
    }
}
