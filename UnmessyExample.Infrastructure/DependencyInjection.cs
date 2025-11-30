using Microsoft.Extensions.DependencyInjection;
using UnmessyExample.Application;

namespace UnmessyExample.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // Register the weather respository.
        services.AddScoped<IWeatherForecastRepository, MockWeatherForecastRepository>();

        return services;
    }
}
