using C4Model;

namespace Vms;

public interface IFactory
{
    IWorkspace CreateWorkspace(Workspace workspace);
    ISoftwareSystem CreateSoftwareSystem(SoftwareSystem softwareSystem);
    IContainer CreateContainer(Container container);
    IComponent CreateComponent(Component component);
}
