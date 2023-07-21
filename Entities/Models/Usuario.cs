using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Contraseña { get; set; }
        public string? Email { get; set; }
        public TipoUsuario? TipoUsuario { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime DateModify { get; set; }
        public int IdUserEntry { get; set; }
        public int IdUserModify { get; set; }
        public string? Estado { get; set; }
    }
}
