using Microsoft.EntityFrameworkCore;
namespace SmartHome.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        // Тут будуть ваші таблиці. Наприклад, таблиця пристроїв:
        // public DbSet<Device> Devices { get; set; }
        // public DbSet<SensorReading> SensorReadings { get; set; }
    }
}