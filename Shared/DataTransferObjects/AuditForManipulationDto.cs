namespace Shared.DataTransferObjects
{
    public abstract record AuditForManipulationDto
    {
        public string? UserName { get; init; }
        public string? CompanyName { get; init; }
        public string? Details { get; init; }
    }
}
