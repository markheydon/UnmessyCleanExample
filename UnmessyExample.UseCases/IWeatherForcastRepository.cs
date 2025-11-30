using UnmessyExample.Domain;

namespace UnmessyExample.Application;

/// <summary>
/// Represents a repository for retrieving weather forecasts.
/// </summary>
public interface IWeatherForecastRepository
{
    /// <summary>
    /// Gets the weather forecasts asynchronously.
    /// </summary>
    /// <remarks>Returning <see cref="IEnumerable{T}"/> from repositories and services is common and recommended, as it keeps your layers decoupled and flexible.</remarks>
    /// <returns>Returns a list of <see cref="WeatherForecast"/> domain objects.</returns>
    Task<IEnumerable<WeatherForecast>> GetForecastsAsync();
}