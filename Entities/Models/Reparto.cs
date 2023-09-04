using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Reparto
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Cliente))]
        public Guid ClienteId { get; set; }
        [ForeignKey(nameof(Usuario))]
        public string? TrabajadorId { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string? Comentario { get; set; }
        public string? EstadoReparto { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime? DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid? IdUserModify { get; set; }
        public string? Estado { get; set; }
        public Cliente? Cliente { get; set; }
        public Usuario? Usuario { get; set; }
        public ICollection<RepartoDetalle>? RepartoDetalles { get; set; }
    }
}
