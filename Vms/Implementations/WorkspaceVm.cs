using Vms.Interfaces;

namespace Vms.Implementations;
public class WorkspaceVm : IWorkspaceVm
{
    private readonly Guid id;

    public WorkspaceVm(Guid id)
    {
        this.id = id;
    }
}
