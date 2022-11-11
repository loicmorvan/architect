using Application;
using Foundation;
using Infrastructure;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Shell.Implementations;
using Shell.Interfaces;

namespace Vms;

public static class ServiceCollectionEx
{
    public static IServiceCollection AddVms(this IServiceCollection services)
    {
        services.AddTransient<IMainVm, MainVm>();
        services.AddTransient<IWorkspaceVm, WorkspaceVm>();
        services.AddTypedFactory<IVmFactory>();

        services.AddMediatR(typeof(AssemblyMarker));
        services.AddTransient<NewWorkspaceHandler>();
        
        services.AddInfrastructure();

        return services;
    }
}
