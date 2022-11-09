using Microsoft.Extensions.DependencyInjection;
using Foundation;

System.Console.WriteLine("Started");

var services = new ServiceCollection();
services.AddTransient<IService, Component>();
services.AddTransient<IOtherService, OtherComponent>();

System.Console.WriteLine("Configured");

var provider = services.BuildServiceProvider();

System.Console.WriteLine("Built");

var factory = FactoryCreator.Create<IFactory>(services, provider);

System.Console.WriteLine("Factory created");

factory.CreateService(54, 54f);

System.Console.WriteLine("Created service");

factory.CreateOtherService("salut");

System.Console.WriteLine("Created other service");

public class OtherComponent: IOtherService
{
    public OtherComponent(string value)
    {
        
    }
}