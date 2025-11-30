using Microsoft.Extensions.DependencyInjection;

namespace UnmessyExample.Application;

/// <summary>
/// Extension methods for registering application services.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Adds application services to the specified service collection.
    /// </summary>
    /// <param name="services">The instance of <see cref="IServiceCollection"/> to add services to.</param>
    /// <returns>The <see cref="IServiceCollection"/> for chaining.</returns>
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Register the weather service.
        services.AddScoped<IWeatherForecastService, MockWeatherForecastService>();

        return services;
    }
}
