namespace AppointmentApp.Application.DTOs;

public class AppointmentCreateDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Branch { get; set; } = string.Empty;
    public DateTime RequestDate { get; set; } = DateTime.Today;
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
}