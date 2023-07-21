using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Reparto
    {
        public Guid Id { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Fecha_Entrega { get; set; } 
        public string? Comentario { get; set; }
        public string? EstadoReparto { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime DateModify { get; set; }
        public int IdUserEntry { get; set; }
        public int IdUserModify { get; set; }
        public string? Estado { get; set; }
    }
}
