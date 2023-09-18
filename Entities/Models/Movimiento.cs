using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Movimiento
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        [ForeignKey(nameof(Producto))]
        public Guid ProductoId { get; set; }
        [ForeignKey(nameof(TipoMovimiento))]
        public Guid TipoMovimientoId { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime? DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid? IdUserModify { get; set; }
        public string? Estado { get; set; }
        public decimal? Cantidad { get; set; }
        public Producto? Producto { get; set; }
        public TipoMovimiento? TipoMovimiento { get; set; }

    }
}
