using ReactiveUI;
using System.Reactive;

namespace Vms.Interfaces;

public interface IMain
{
    ReactiveCommand<Unit, IWorkspace> NewWorkspace { get; }

    IWorkspace? CurrentWorkspace { get; }
}
