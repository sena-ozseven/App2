 namespace AppointmentApp.Domain;

public class AuditLog
{
    public int Id { get; set; }
    public int AppointmentId { get; set; }
    public required string Action { get; set; } //null olmaması gerektiği için required.
    public required string ChangedBy { get; set; }
    public DateTime ChangedAt { get; set; } = DateTime.UtcNow;
    public string? Notes { get; set; }
}