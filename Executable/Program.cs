using Microsoft.Extensions.DependencyInjection;
using Foundation;
using System.Reflection.Emit;

var services = new ServiceCollection();
services.AddTransient<IService, Component>();
services.AddTransient<IOtherService, OtherComponent>();

var provider = services.BuildServiceProvider();
var factory = FactoryCreator.Create<IFactory>(services, provider);

factory.CreateService(54, 54f);
factory.CreateOtherService("salut");

public class OtherComponent: IOtherService
{
    public OtherComponent(string value)
    {

    }
}