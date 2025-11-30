namespace UnmessyExample.Application;

/// <summary>
/// Represents a service for retrieving weather forecasts.
/// </summary>
public interface IWeatherForecastService
{
    /// <summary>
    /// Gets the weather forecasts asynchronously.
    /// </summary>
    /// <remarks>Returning <see cref="IEnumerable{T}"/> from repositories and services is common and recommended, as it keeps your layers decoupled and flexible.</remarks>
    /// <returns>Returns a list of <see cref="WeatherForecastDto"/> DTOs for use in the UI.</returns>
    Task<IEnumerable<WeatherForecastDto>> GetForecastsAsync();
}