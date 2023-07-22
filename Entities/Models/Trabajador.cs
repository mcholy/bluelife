using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Trabajador
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Persona))]
        public Guid PersonaId { get; set; }
        public string? Alias { get; set; }
        [ForeignKey(nameof(TipoTrabajador))]
        public Guid TipoTrabajadorId { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid IdUserModify { get; set; }
        public string? Estado { get; set; }
        public Persona? Persona { get; set; }
        public TipoTrabajador? TipoTrabajador { get; set; }

    }
}
