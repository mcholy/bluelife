namespace Shared.DataTransferObjects
{
    public record ProductoDto
    {
        public Guid Id { get; init; }
        public string? Nombre { get; init; }
        public string? Estado { get; init; }
    }
}
