using UnmessyExample.Domain;
using UnmessyExample.Application;

namespace UnmessyExample.Infrastructure;

/// <summary>
/// Mock version of the weather forecast repository for demonstration purposes.
/// </summary>
public class MockWeatherForecastRepository : IWeatherForecastRepository
{
    /// <inheritdoc/>
    public async Task<IEnumerable<WeatherForecast>> GetForecastsAsync()
    {
        var startDate = DateOnly.FromDateTime(DateTime.Now);
        var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
        var forecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = summaries[Random.Shared.Next(summaries.Length)]
        });

        // Add a random delay to make it a bit more realistic.
        var delay = Task.Delay(Random.Shared.Next(100, 1000));
        await delay;

        // Return the mock data as a completed task.
        return forecasts;
    }
}