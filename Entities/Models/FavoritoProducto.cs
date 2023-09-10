using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class FavoritoProducto
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Cliente))]
        public Guid ClienteId { get; set; }
        [ForeignKey(nameof(Producto))]
        public Guid ProductoId { get; set; }
        public int? DiasRecompra { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime? DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid? IdUserModify { get; set; }
        public string? Estado { get; set; }
        public Producto? Producto { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
