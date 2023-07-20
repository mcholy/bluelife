namespace Shared.DataTransferObjects
{
    public record ProductoDto
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Estado { get; set; }
    }
}
