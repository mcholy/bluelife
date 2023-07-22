using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Producto
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid IdUserModify { get; set; }
        public string? Estado { get; set; }
        public ICollection<Cliente>? Clientes { get; set; }
        public ICollection<Movimiento>? Movimientos { get; set; }
        public ICollection<RepartoDetalle>? RepartoDetalles { get; set; }
    }
}
