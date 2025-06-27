using Microsoft.EntityFrameworkCore;

namespace LibraryManagement
{
    public class WeatherForecastRepository(WeatherDbContext dbContext) : IWeatherForecastRepository
    {
        private readonly WeatherDbContext _dbContext = dbContext;
        public async Task<List<WeatherForecast>> GetForecasts()
        {
            return await _dbContext.WeatherForecasts.ToListAsync();
        }
    }
}
