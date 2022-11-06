namespace Shell.Interfaces;

public interface IVmFactory
{
    IWorkspaceVm CreateWorkspaceVm(Guid id);
}
