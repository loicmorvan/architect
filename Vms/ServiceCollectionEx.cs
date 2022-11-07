using Microsoft.Extensions.DependencyInjection;
using Shell.Implementations;

namespace Shell;

public static class ServiceCollectionEx
{
    public static IServiceCollection AddTypedFactory<TFactory>(this IServiceCollection services)
    {
        services.Add(new ServiceDescriptor(
            typeof(TypedFactory<TFactory>),
            (provider) => new TypedFactory<TFactory>(services, provider),
            ServiceLifetime.Singleton));

        return services;
    }
}
