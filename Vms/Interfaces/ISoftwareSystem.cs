using System.Collections.ObjectModel;
using System.Reactive;
using ReactiveUI;

namespace Vms.Interfaces;

public interface ISoftwareSystem
{
    string Title { get; set; }
    string Description { get; set; }

    ReactiveCommand<Unit, IContainer> CreateContainer { get; }

    ObservableCollection<IContainer> Containers { get; }
}
