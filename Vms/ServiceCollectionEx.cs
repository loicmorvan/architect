using Foundation;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Vms.Implementations;
using Vms.Interfaces;

namespace Vms;

public static class ServiceCollectionEx
{
    public static IServiceCollection AddVms(this IServiceCollection services)
    {
        services.AddTransient<IMain, MainVm>();
        services.AddTransient<IWorkspace, WorkspaceVm>();
        services.AddTransient<ISoftwareSystem, SoftwareSystemVm>();
        services.AddTransient<IContainer, ContainerVm>();
        services.AddTransient<IComponent, ComponentVm>();
        services.AddTypedFactory<IFactory>();

        services.AddInfrastructure();

        return services;
    }
}
