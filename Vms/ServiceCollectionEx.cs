using Hemel.DependencyInjection.TypedFactory;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Vms.Implementations;

namespace Vms;

public static class ServiceCollectionEx
{
    public static IServiceCollection AddVms(this IServiceCollection services)
    {
        services.AddTransient<IWorkspace, WorkspaceVm>();
        services.AddTransient<ISoftwareSystem, SoftwareSystemVm>();
        services.AddTransient<IContainer, ContainerVm>();
        services.AddTransient<IComponent, ComponentVm>();
        services.AddTypedFactory<IFactory>();

        services.AddInfrastructure();

        return services;
    }
}
