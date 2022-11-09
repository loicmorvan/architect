using Microsoft.Extensions.DependencyInjection;

namespace Foundation.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var services = new ServiceCollection();
        services.AddTransient<IService, Component>();

        var factory = FactoryCreator.Create<IFactory>(services);

        Assert.NotNull(factory.CreateService(54, 54f));
    }
}
