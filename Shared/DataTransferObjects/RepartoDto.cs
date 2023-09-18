using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class VentaDto
    {
        public Guid Id { get; set; }     
        public Guid ClienteId { get; set; }
        public Guid TrabajadorId { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string? Comentario { get; set; }
        public string? EstadoVenta { get; set; }
        public string? Estado { get; set; }
    }
}
