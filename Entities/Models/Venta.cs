using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Venta
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Cliente))]
        public Guid ClienteId { get; set; }
        [ForeignKey(nameof(Trabajador))]
        public Guid? TrabajadorId { get; set; }
        [ForeignKey(nameof(EstadoVenta))]
        public Guid IdEstadoVenta { get; set; }
        public string? Comentario { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime? DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid? IdUserModify { get; set; }
        public string? Estado { get; set; }
        public Cliente? Cliente { get; set; }
        public Trabajador? Trabajador { get; set; }
        public EstadoVenta? EstadoVenta { get; set; }
        public ICollection<VentaDetalle>? VentaDetalles { get; set; }
    }
}
