using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Trabajador
    {
        public Guid Id { get; set; }
        [ForeignKey(nameof(Persona))]
        public Guid PersonaId { get; set; }
        [ForeignKey(nameof(TipoTrabajador))]
        public Guid TipoTrabajadorId { get; set; }
        [ForeignKey(nameof(Empresa))]
        public Guid EmpresaId { get; set; }
        public string? Alias { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime? DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid? IdUserModify { get; set; }
        public string? Estado { get; set; }
        public Persona? Persona { get; set; }
        public TipoTrabajador? TipoTrabajador { get; set; }
        public Empresa? Empresa { get; set; }
        public ICollection<Venta>? Ventas { get; set; }

    }
}
