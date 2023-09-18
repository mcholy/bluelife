namespace Shared.DataTransferObjects
{
    public record ClienteDto
    {
        public Guid Id { get; init; }
        public string? Nombre { get; init; }
        public string? ApPaterno { get; init; }
        public string? ApMaterno { get; init; }
        public string? Documento { get; init; }
        public string? Celular { get; init; }
        public string? Direccion { get; init; }
        public Guid ProductoId { get; init; }
        public string? DiasRecompra { get; init; }
        public string? Referencia { get; init; }
        public string? Localizacion { get; init; }
        public string? Estado { get; init; }
    }
}
