namespace Vms.Interfaces;

public interface IVmFactory
{
    IWorkspaceVm CreateWorkspaceVm(Guid id);
}
