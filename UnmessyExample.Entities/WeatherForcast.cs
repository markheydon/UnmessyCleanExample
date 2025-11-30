namespace UnmessyExample.Domain;

/// <summary>
/// The domain representation of a single weather forecast.
/// </summary>
/// <remarks>
/// This entity is immutable and enforces basic domain invariants.
/// </remarks>
public class WeatherForecast
{
    /// <summary>
    /// The date of the weather forecast.
    /// </summary>
    public DateOnly Date { get; }

    /// <summary>
    /// The temperature in Celsius.
    /// </summary>
    public int TemperatureC { get; }

    /// <summary>
    /// The summary description of the weather.
    /// </summary>
    public string? Summary { get; }

    /// <summary>
    /// The temperature in Fahrenheit.
    /// </summary>
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    /// <summary>
    /// Initializes a new instance of the <see cref="WeatherForecast"/> class.
    /// </summary>
    /// <param name="date">The date of the forecast.</param>
    /// <param name="temperatureC">The temperature in Celsius.</param>
    /// <param name="summary">The summary description.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if temperature is outside realistic bounds.</exception>
    public WeatherForecast(DateOnly date, int temperatureC, string? summary)
    {
        if (temperatureC < -100 || temperatureC > 100)
            throw new ArgumentOutOfRangeException(nameof(temperatureC), "TemperatureC must be from -100 to 100 (inclusive).");

        Date = date;
        TemperatureC = temperatureC;
        Summary = summary;
    }

    /// <summary>
    /// Returns true if the forecast is for a hot day.
    /// </summary>
    public bool IsHot() => TemperatureC >= 30;

    /// <summary>
    /// Returns true if the forecast is for a freezing day.
    /// </summary>
    public bool IsFreezing() => TemperatureC <= 0;
}