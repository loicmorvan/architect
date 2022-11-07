namespace Shell.Implementations;

using Microsoft.Extensions.DependencyInjection;
using System.Dynamic;

public class TypedFactory<TFactory> : DynamicObject
{
    private readonly Dictionary<Type, Type> componentsPerService = new();
    private readonly IServiceProvider serviceProvider;

    public TypedFactory(IServiceCollection services, IServiceProvider serviceProvider)
    {
        foreach (var method in typeof(TFactory).GetMethods())
        {
            if (method.ReturnType == typeof(void))
            {
                continue;
            }

            var outputType = method.ReturnType;
            componentsPerService.Add(
                outputType,
                services
                    // Not sure we should take the first...
                    .First(x => x.ServiceType == outputType)
                    .ImplementationType
                        ?? throw new NotSupportedException());
        }

        this.serviceProvider = serviceProvider;
    }

    public override bool TryInvokeMember(InvokeMemberBinder binder, object?[]? args, out object? result)
    {
        var curratedArgs = 
            (args ?? Array.Empty<object>())
                .Where(x => x is not null)
                .Cast<object>()
                .ToArray();

        result = ActivatorUtilities.CreateInstance(serviceProvider, componentsPerService[binder.ReturnType], curratedArgs);
        
        return true;
    }
}
