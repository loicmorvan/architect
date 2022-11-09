using Microsoft.Extensions.DependencyInjection;

namespace Foundation.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var services = new ServiceCollection();
        services.AddTransient<IService, Component>();
        services.AddTransient<IOtherService, OtherComponent>();

        var factory = FactoryCreator.Create<IFactory>(services);

        Assert.NotNull(factory.CreateService(54, 54f));
        Assert.NotNull(factory.CreateOtherService("salut"));
    }
}

public class OtherComponent: IOtherService
{
    public OtherComponent(string value)
    {
        
    }
}