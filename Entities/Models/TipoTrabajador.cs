using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class TipoTrabajador
    {

        public Guid Id { get; set; }
        public string Nombre { get; set; }  
        public DateTime DateEntry { get; set; }
        public DateTime DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid IdUserModify { get; set; }
        public string? Estado { get; set; }
        public ICollection<Trabajador>? Trabajadores { get; set; }
    }
}
