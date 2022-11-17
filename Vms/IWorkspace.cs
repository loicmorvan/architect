using System.Collections.ObjectModel;
using System.Reactive;
using ReactiveUI;

namespace Vms;

public interface IWorkspace
{
    ReactiveCommand<Unit, ISoftwareSystem> CreateSoftwareSystem { get; }
    ObservableCollection<ISoftwareSystem> SoftwareSystems { get; }
}
