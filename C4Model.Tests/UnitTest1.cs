namespace C4Model.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // workspace {
        //   softwareSystem {
        //     container {
        //       component = component
        //       component2 = component
        //       component -> component2
        //     }
        //   }
        // }

        var workspace = new Workspace();
        var softwareSystem = workspace.CreateSoftwareSystem();
        var container = softwareSystem.CreateContainer();
        var component = container.CreateComponent();
        var component2 = container.CreateComponent();
        workspace.CreateRelationship(component, component2);
    }
}
