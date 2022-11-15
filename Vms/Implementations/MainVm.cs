using C4Model;
using ReactiveUI;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using Vms.Interfaces;

namespace Vms.Implementations;

public sealed class MainVm : ReactiveObject, IMain, IDisposable
{
    private readonly CompositeDisposable disposables = new();
    private readonly ObservableAsPropertyHelper<IWorkspace?> currentWorkspace;

    public MainVm(IFactory factory)
    {
        NewWorkspace = ReactiveCommand
            .Create(() =>
            {
                var result = new Workspace();
                return factory.CreateWorkspace(result);
            })
            .DisposeWith(disposables);

        currentWorkspace = NewWorkspace
            .ToProperty(this, x => x.CurrentWorkspace)
            .DisposeWith(disposables);
    }

    public ReactiveCommand<System.Reactive.Unit, IWorkspace> NewWorkspace { get; }

    public IWorkspace? CurrentWorkspace => currentWorkspace.Value;

    public void Dispose()
    {
        disposables.Dispose();
    }
}
