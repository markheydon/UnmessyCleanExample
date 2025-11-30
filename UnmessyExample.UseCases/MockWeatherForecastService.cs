namespace UnmessyExample.Application;

/// <summary>
/// Mock version of the weather forecast service for demonstration purposes.
/// </summary>
public class MockWeatherForecastService : IWeatherForecastService
{
    // The repository to retrieve weather forecasts.
    private readonly IWeatherForecastRepository _repository;

    /// <summary>
    /// Constructor accepting a weather forecast repository.
    /// </summary>
    /// <param name="repository">An instance of <see cref="IWeatherForecastRepository"/> that comes from DI.</param>
    public MockWeatherForecastService(IWeatherForecastRepository repository)
    {
        _repository = repository;
    }

    /// <inheritdoc/>
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
