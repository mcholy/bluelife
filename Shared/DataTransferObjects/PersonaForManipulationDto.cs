using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
    public abstract record PersonaForManipulationDto
    {
        [Required(ErrorMessage = "Nombre es un campo requerido.")]
        [MaxLength(30, ErrorMessage = "El máximo número de carácteres es 30.")]
        public string? Nombre { get; init; }
        [Required(ErrorMessage = "ApPaterno es un campo requerido.")]
        [MaxLength(20, ErrorMessage = "El máximo número de carácteres es 20.")]
        public string? ApPaterno { get; init; }
        [Required(ErrorMessage = "ApMaterno es un campo requerido.")]
        [MaxLength(20, ErrorMessage = "El máximo número de carácteres es 20.")]
        public string? ApMaterno { get; init; }
        [Range(8, 14, ErrorMessage = "Documento es un campo requerido y no puede tener menos de 8 ni más de 14 carácteres.")]
        public string? Documento { get; init; }
        [Range(9, 13, ErrorMessage = "Celular es un campo requerido y no puede tener menos de 9 ni más de 13 carácteres.")]
        public string? Celular { get; init; }
        [Required(ErrorMessage = "Direccion es un campo requerido.")]
        [MaxLength(100, ErrorMessage = "El máximo número de carácteres es 100.")]
        public string? Direccion { get; init; }
    }
}
