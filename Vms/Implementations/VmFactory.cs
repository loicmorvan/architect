namespace Shell.Implementations;

using Interfaces;
using Microsoft.Extensions.DependencyInjection;

public class VmFactory : IVmFactory
{
    private readonly IDictionary<Type, Type> componentsPerService = new Dictionary<Type, Type>();
    private readonly IServiceProvider serviceProvider;

    public VmFactory(IServiceCollection services, IServiceProvider serviceProvider)
    {
        componentsPerService.Add(
            typeof(IWorkspaceVm),
            services
                .First(x => x.ServiceType == typeof(IWorkspaceVm)) // Not sure...
                .ImplementationType
                    ?? throw new NotSupportedException());

        this.serviceProvider = serviceProvider;
    }

    public IWorkspaceVm CreateWorkspaceVm(Guid id)
    {
        return (IWorkspaceVm)ActivatorUtilities.CreateInstance(serviceProvider, componentsPerService[typeof(IWorkspaceVm)] , id);
    }
}
