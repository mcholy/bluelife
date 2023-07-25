using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    internal class UsuarioDto
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Contrasenia { get; set; }
        public string? Email { get; set; }
        public Guid TipoUsuarioId { get; set; }
        public Guid PersonaId { get; set; }
        public string? Estado { get; set; }
    }
}
