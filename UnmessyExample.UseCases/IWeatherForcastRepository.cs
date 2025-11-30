using UnmessyExample.Domain;

namespace UnmessyExample.Application;

public interface IWeatherForecastRepository
{
    Task<IEnumerable<WeatherForecast>> GetForecastsAsync();
}