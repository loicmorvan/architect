using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Disposables;
using C4Model;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace Vms.Implementations;

internal class SoftwareSystemVm : ReactiveObject, ISoftwareSystem
{
    private readonly SoftwareSystem softwareSystem;
    private readonly CompositeDisposable disposables = new();

    public SoftwareSystemVm(SoftwareSystem softwareSystem)
    {
        this.softwareSystem = softwareSystem;

        Title = softwareSystem.Name;
        this.WhenAnyValue(x => x.Title)
            .Subscribe(x => softwareSystem.Name = x)
            .DisposeWith(disposables);

        Description = softwareSystem.Description;
        this.WhenAnyValue(x => x.Description)
            .Subscribe(x => softwareSystem.Description = x)
            .DisposeWith(disposables);
    }

    [Reactive]
    public string Title { get; set; }

    [Reactive]
    public string Description { get; set; }

    public ReactiveCommand<System.Reactive.Unit, IContainer> CreateContainer => throw new NotImplementedException();

    public ObservableCollection<IContainer> Containers => throw new NotImplementedException();
}
