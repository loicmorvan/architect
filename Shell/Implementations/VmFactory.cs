namespace Shell.Implementations;

using Interfaces;
using Microsoft.Extensions.DependencyInjection;

internal class VmFactory : IVmFactory
{
    private readonly IServiceProvider serviceProvider;

    public VmFactory(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    public IWorkspaceVm CreateWorkspaceVm(Guid id)
    {
        // How to retrieve WorkspaceVm from IWorkspaceVm?
        // serviceProvider should know the component type, but how to get it?
        return ActivatorUtilities.CreateInstance<WorkspaceVm>(serviceProvider, id);
    }
}
