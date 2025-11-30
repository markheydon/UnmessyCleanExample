namespace UnmessyExample.Domain;

/// <summary>
/// The domain representation of a single weather forecast.
/// </summary>
/// <remarks>
/// This is what should be getting passed around within the domain layer. The infrastructure layer
/// should handle the mapping to and from the data storage format.
/// </remarks>
public class WeatherForecast
{
    /// <summary>
    /// The date of the weather forecast.
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// The temperature in Celsius.
    /// </summary>
    public int TemperatureC { get; set; }

    /// <summary>
    /// The summary description of the weather.
    /// </summary>
    public string? Summary { get; set; }

    /// <summary>
    /// The temperature in Fahrenheit.
    /// </summary>
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}