namespace AppointmentApp.Domain;

public class Appointment
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Branch { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public DateTime RequestDate { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public string RequestedBy { get; set; } = string.Empty; 
    public AppointmentStatus Status { get; set; }
    public string? RejectionReason { get; set; } //null olabilir.
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public List<AuditLog> AuditLogs { get; set; } = new();
}