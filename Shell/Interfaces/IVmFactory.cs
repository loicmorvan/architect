namespace Shell.Interfaces;

internal interface IVmFactory
{
    IWorkspaceVm CreateWorkspaceVm(Guid id);
}
