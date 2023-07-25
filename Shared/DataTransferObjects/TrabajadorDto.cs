using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class TrabajadorDto
    {
        public Guid Id { get; set; }
        public Guid PersonaId { get; set; }
        public string? Alias { get; set; }
        public Guid TipoTrabajadorId { get; set; }
        public string? Estado { get; set; }
    }
}
