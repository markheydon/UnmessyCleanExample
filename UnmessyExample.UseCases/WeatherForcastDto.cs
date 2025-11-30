namespace UnmessyExample.Application;

/// <summary>
/// A single weather forecast data transfer object (DTO) for the application layer.
/// </summary>
/// <remarks>
/// This is what should be getting passed from the application layer into the UI.
/// </remarks>
public class WeatherForecastDto
{
    /// <summary>
    /// The date of the weather forecast.
    /// </summary>
    public DateOnly Date { get; init; }

    /// <summary>
    /// The temperature in Celsius.
    /// </summary>
    public int TemperatureC { get; init; }

    /// <summary>
    /// The temperature in Fahrenheit.
    /// </summary>
    public int TemperatureF { get; init; }

    /// <summary>
    /// The summary description of the weather.
    /// </summary>
    public string? Summary { get; init; }
}