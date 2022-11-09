using System.Reflection;
using System.Reflection.Emit;
using Microsoft.Extensions.DependencyInjection;

namespace Foundation;

public static class FactoryCreator
{
    public static TFactory Create<TFactory>(IServiceCollection services, IServiceProvider serviceProvider)
    {
        var factoryType = typeof(TFactory);
        var assemblyName = "TypedFactory_Implementations";
        var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(assemblyName), AssemblyBuilderAccess.Run);
        var moduleBuilder = assemblyBuilder.DefineDynamicModule(assemblyName);
        var typeBuilder = moduleBuilder.DefineType($"TypedFactory__{factoryType.Name}__Implementation");
        typeBuilder.AddInterfaceImplementation(factoryType);

        var serviceProviderField = typeBuilder.DefineField("serviceProvider", typeof(IServiceProvider), FieldAttributes.Private);
        var ctor = typeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, new[] { typeof(IServiceProvider) });
        var ctorGen = ctor.GetILGenerator();
        ctorGen.Emit(OpCodes.Ldarg_0);
        ctorGen.Emit(OpCodes.Call, typeof(object).GetConstructor(BindingFlags.Public | BindingFlags.Instance, Type.EmptyTypes) ?? throw new Exception());
        ctorGen.Emit(OpCodes.Ldarg_0);
        ctorGen.Emit(OpCodes.Ldarg_1);
        ctorGen.Emit(OpCodes.Stfld, serviceProviderField);
        ctorGen.Emit(OpCodes.Ret);

        foreach (var method in factoryType.GetMethods().Where(x => x.Name.StartsWith("Create")))
        {
            ImplementCreateMethod(
                typeBuilder,
                method,
                services.First(x => x.ServiceType == method.ReturnType).ImplementationType ?? throw new Exception(),
                serviceProviderField);
        }

        var type = typeBuilder.CreateType() ?? throw new Exception("unable to create type");

        return (TFactory)(Activator.CreateInstance(type, serviceProvider) ?? throw new Exception());
    }

    private static void ImplementCreateMethod(TypeBuilder typeBuilder, MethodInfo info, Type componentType, FieldBuilder serviceProviderField)
    {
        var parameters = info.GetParameters().Select(x => x.ParameterType).ToArray();
        var createMethodBuilder1 = typeBuilder.DefineMethod(info.Name, MethodAttributes.Public | MethodAttributes.Virtual, info.ReturnType, parameters);
        var createMethodGenerator1 = createMethodBuilder1.GetILGenerator();
        createMethodGenerator1.Emit(OpCodes.Ldarg_0);
        createMethodGenerator1.Emit(OpCodes.Ldfld, serviceProviderField);
        for (short i = 0; i < parameters.Length; ++i)
        {
            createMethodGenerator1.Emit(OpCodes.Ldarg, i + 1);
        }
        createMethodGenerator1.Emit(
            OpCodes.Newobj,
            componentType.GetConstructor(BindingFlags.Instance | BindingFlags.Public, parameters.Prepend(typeof(IServiceProvider)).ToArray())
                ?? throw new Exception("constructor not found on component"));
        createMethodGenerator1.Emit(OpCodes.Ret);
    }
}
