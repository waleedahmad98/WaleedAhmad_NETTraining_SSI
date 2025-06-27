namespace LibraryManagement
{
    public interface IWeatherForecastRepository
    {
        public Task<List<WeatherForecast>> GetForecasts();
    }
}
