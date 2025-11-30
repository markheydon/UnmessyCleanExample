using Microsoft.Extensions.DependencyInjection;

namespace UnmessyExample.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Register the weather service.
        services.AddScoped<IWeatherForecastService, MockWeatherForecastService>();

        return services;
    }
}
