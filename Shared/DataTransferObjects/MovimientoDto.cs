using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class MovimientoDto
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public Guid ProductoId { get; set; }
        public Guid TipoMovimientoId { get; set; }
        public string? Estado { get; init; }
    }
}
