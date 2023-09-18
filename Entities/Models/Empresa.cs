using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Empresa
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Nombre es un campo requerido.")]
        [MaxLength(60, ErrorMessage = "Máxima cantidad de carácteres para nombre es 60.")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Direccion es un campo requerido.")]
        [MaxLength(60, ErrorMessage = "Máxima cantidad de carácteres para dirección es 60.")]
        public string? Celular { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Ruc { get; set; }
        public string? Pais { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime? DateModify { get; set; }
        public Guid IdUserEntry { get; set; }
        public Guid? IdUserModify { get; set; }
        public string? Estado { get; set; }
        public ICollection<Trabajador>? Trabajadores { get; set; }
        public ICollection<TipoTrabajador>? TipoTrabajadores { get; set; }
        public ICollection<TipoMovimiento>? TipoMovimientos { get; set; }
        public ICollection<Persona>? Personas { get; set; }
        public ICollection<Producto>? Productos { get; set; }
        public ICollection<Cliente>? Clientes { get; set; }
        public ICollection<EstadoVenta>? EstadoVentas { get; set; }
    }
}
