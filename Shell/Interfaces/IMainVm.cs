using Application;
using ReactiveUI;
using System.Reactive;

namespace Shell.Interfaces;
internal interface IMainVm
{
    ReactiveCommand<Unit, WorkspaceCreated> NewWorkspace { get; }

    IWorkspaceVm? CurrentWorkspace { get; }
}