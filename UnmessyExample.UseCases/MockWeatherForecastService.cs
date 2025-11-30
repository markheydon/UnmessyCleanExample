

namespace UnmessyExample.Application;

public class MockWeatherForecastService : IWeatherForecastService
{
    private readonly IWeatherForecastRepository _repository;

    public MockWeatherForecastService(IWeatherForecastRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<WeatherForecastDto>> GetForecastsAsync()
    {
        // Call into the mock repository to get the data.
        var forecasts = await _repository.GetForecastsAsync();

        // Convert to DTOs.
        var dtos = forecasts.Select(forecast => new WeatherForecastDto
        {
            Date = forecast.Date,
            TemperatureC = forecast.TemperatureC,
            TemperatureF = forecast.TemperatureF,
            Summary = forecast.Summary
        });

        return dtos;
    }
}
