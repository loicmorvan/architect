using Foundation.Tests.TestTypes;
using Microsoft.Extensions.DependencyInjection;

namespace Foundation.Tests;

public class TypedFactoryCreatorTests
{
    [Fact]
    public void OtherServiceCanBeInjected()
    {
        var services = new ServiceCollection();
        services.AddTransient<IService, Component>();
        services.AddTransient<IOtherService, OtherComponent>();

        var provider = services.BuildServiceProvider();

        var factory = TypedFactoryCreator.Create<IFactory>(services, provider);
        var service = factory.CreateService(12);
        var result = service.DoSomething(23);
        Assert.Equal("65-23-12", result);
    }
}
