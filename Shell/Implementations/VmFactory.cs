namespace Shell.Implementations;

using System;
using Interfaces;
internal class VmFactory : IVmFactory
{
    public IWorkspaceVm CreateWorkspaceVm(Guid id)
    {
        return new WorkspaceVm(id);
    }
}