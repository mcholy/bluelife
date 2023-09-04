using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Persona))]
        public Guid PersonaId { get; set; }
        [ForeignKey(nameof(Producto))]
        public Guid ProductoId { get; set; }
        public string? DiasRecompra { get; set; }
        public string? Referencia { get; set; }
        public string? Localizacion { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime? DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid? IdUserModify { get; set; }
        public string? Estado { get; set; }
        public Persona? Persona { get; set; }
        public Producto? Producto { get; set; }

    }
}
