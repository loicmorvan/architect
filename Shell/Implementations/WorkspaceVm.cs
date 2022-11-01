using System;

namespace Shell.Implementations;
internal class WorkspaceVm : IWorkspaceVm
{
    private readonly Guid id;

    public WorkspaceVm(Guid id)
    {
        this.id = id;
    }
}
