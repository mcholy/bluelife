using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    internal class VentaDetalleDto
    {
        public Guid Id { get; set; }
        public Guid VentaId { get; set; }
        public Guid ProductoId { get; set; }
        public decimal Cantidad { get; set; }
        public string? Estado { get; set; }
    }
}
