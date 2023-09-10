using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class VentaDetalle
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Venta))]
        public Guid VentaId { get; set; }
        [ForeignKey(nameof(Producto))]
        public Guid ProductoId { get; set; }    
        public decimal Cantidad { get; set; }   
        public DateTime DateEntry { get; set; }
        public DateTime? DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid? IdUserModify { get; set; }
        public string? Estado { get; set; }
        public Venta? Venta { get; set; }
        public Producto? Producto { get; set; }
    }
}
