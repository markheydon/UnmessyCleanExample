using Microsoft.Extensions.DependencyInjection;
using UnmessyExample.Application;

namespace UnmessyExample.Infrastructure;

/// <summary>
/// Extension methods for registering application services.
/// </summary>
public static class DependencyInjection
{
    /// <summary>
    /// Adds infrastructure services to the specified service collection.
    /// </summary>
    /// <param name="services">The instance of <see cref="IServiceCollection"/> to add services to.</param>
    /// <returns>The <see cref="IServiceCollection"/> for chaining.</returns>
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // Register the weather respository.
        services.AddScoped<IWeatherForecastRepository, MockWeatherForecastRepository>();

        return services;
    }
}
