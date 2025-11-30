namespace UnmessyExample.Application;

public interface IWeatherForecastService
{
    Task<IEnumerable<WeatherForecastDto>> GetForecastsAsync();
}