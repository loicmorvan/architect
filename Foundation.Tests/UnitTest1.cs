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

        var provider = services.BuildServiceProvider();

        var factory = FactoryCreator.Create<IFactory>(services, provider);

        Assert.NotNull(factory.CreateService(54, 54f));
        Assert.NotNull(factory.CreateOtherService("salut"));
    }
}

public class OtherComponent: IOtherService
{
    public OtherComponent(IServiceProvider serviceProvider, string value)
    {
        
    }
}