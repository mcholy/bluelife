namespace Shared.DataTransferObjects
{
    public record AuditDto
    {
        public string? Id { get; init; }
        public string? UserName { get; init; }
        public string? CompanyName { get; init; }
        public string? Details { get; init; }
        public DateTime? DateEntry { get; set; }
    }
}
