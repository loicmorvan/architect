using System.Collections.ObjectModel;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using C4Model;
using DynamicData;
using ReactiveUI;

namespace Vms.Implementations;

public class WorkspaceVm : IWorkspace
{
    private readonly ObservableCollection<ISoftwareSystem> softwareSystems = new ObservableCollection<ISoftwareSystem>();
    private readonly CompositeDisposable disposables = new();

    public WorkspaceVm(Workspace workspace, IFactory factory)
    {
        softwareSystems.AddRange(workspace.SoftwareSystems.Select(factory.CreateSoftwareSystem));

        CreateSoftwareSystem = ReactiveCommand
            .Create(() =>
            {
                var softwareSystem = workspace.CreateSoftwareSystem();
                return factory.CreateSoftwareSystem(softwareSystem);
            })
            .DisposeWith(disposables);

        CreateSoftwareSystem
            .Subscribe(softwareSystems.Add)
            .DisposeWith(disposables);
    }

    public ObservableCollection<ISoftwareSystem> SoftwareSystems => softwareSystems;

    public ReactiveCommand<System.Reactive.Unit, ISoftwareSystem> CreateSoftwareSystem { get; }
}
