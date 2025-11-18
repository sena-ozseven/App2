using AppointmentApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace AppointmentApp.Infrastructure;


//options --> Dependency Injection & Configuration
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<AuditLog> AuditLogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
    }
}
