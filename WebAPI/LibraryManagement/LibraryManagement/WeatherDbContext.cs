using Microsoft.EntityFrameworkCore;

namespace LibraryManagement
{
    public class WeatherDbContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public WeatherDbContext(DbContextOptions<WeatherDbContext> options) : base(options) { }
    }
}
