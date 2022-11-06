using Application;
using MediatR;
using ReactiveUI;
using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using Shell.Interfaces;

namespace Shell.Implementations;
public class MainVm : ReactiveObject, IMainVm, IDisposable
{
    private readonly CompositeDisposable disposables = new();
    private readonly ObservableAsPropertyHelper<IWorkspaceVm?> currentWorkspace;

    public MainVm(IMediator mediator, IVmFactory factory)
    {
        NewWorkspace = ReactiveCommand
            .CreateFromTask(() => mediator.Send(new NewWorkspace()))
            .DisposeWith(disposables);

        currentWorkspace = NewWorkspace
            .Select(x => x.WorkspaceId)
            .Select(x => factory.CreateWorkspaceVm(x))
            .ToProperty(this, x => x.CurrentWorkspace)
            .DisposeWith(disposables);
    }

    public ReactiveCommand<System.Reactive.Unit, WorkspaceCreated> NewWorkspace { get; }


    public IWorkspaceVm? CurrentWorkspace => currentWorkspace.Value;

    public void Dispose()
    {
        disposables.Dispose();
    }
}
