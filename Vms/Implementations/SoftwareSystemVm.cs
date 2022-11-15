using System.Collections.ObjectModel;
using System.Reactive;
using C4Model;
using ReactiveUI;
using Vms.Interfaces;

namespace Vms.Implementations;

internal class SoftwareSystemVm : ISoftwareSystem
{
    private readonly SoftwareSystem softwareSystem;

    public SoftwareSystemVm(SoftwareSystem softwareSystem)
    {
        this.softwareSystem = softwareSystem;
    }

    public string Title { get; set; } = "Untitled";
    public string Description { get; set; } = string.Empty;

    public ReactiveCommand<System.Reactive.Unit, IContainer> CreateContainer => throw new NotImplementedException();

    public ObservableCollection<IContainer> Containers => throw new NotImplementedException();
}
