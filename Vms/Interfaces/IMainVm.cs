using Application;
using ReactiveUI;
using System.Reactive;

namespace Shell.Interfaces;
public interface IMainVm
{
    ReactiveCommand<Unit, WorkspaceCreated> NewWorkspace { get; }

    IWorkspaceVm? CurrentWorkspace { get; }
}