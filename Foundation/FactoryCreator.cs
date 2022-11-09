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
        System.Console.WriteLine("Creating method " + info.Name);

        var parameters = info.GetParameters().Select(x => x.ParameterType).ToArray();
        System.Console.WriteLine(parameters.Select(x => x.ToString()).Aggregate((x, y) => x + ", " + y));

        var builder = typeBuilder.DefineMethod(info.Name, MethodAttributes.Public | MethodAttributes.Virtual, info.ReturnType, parameters);
        var gen = builder.GetILGenerator();

        var localArray = gen.DeclareLocal(typeof(object[]));

        // create and store all parameters in an array
        gen.EmitWriteLine("Creating arguments array");
        gen.Emit(OpCodes.Ldc_I4, parameters.Length);
        gen.Emit(OpCodes.Newarr, typeof(object));
        gen.Emit(OpCodes.Stloc, localArray.LocalIndex); // stores the array instance
        for (int i = 0; i < parameters.Length; ++i)
        {
            gen.Emit(OpCodes.Ldloc, localArray.LocalIndex); // array instance
            gen.Emit(OpCodes.Ldc_I4, i); // index in the array
            gen.Emit(OpCodes.Ldarg, i + 1); // object to store
            gen.Emit(OpCodes.Stelem, parameters[i]); // do store the object into the arry at the given index
        }

        // push serviceProvider to the stack
        gen.EmitWriteLine("push serviceProvider to the stack");
        gen.Emit(OpCodes.Ldarg_0);
        gen.Emit(OpCodes.Ldfld, serviceProviderField);

        // push componentType to the stack
        gen.EmitWriteLine("push componentType to the stack");
        gen.Emit(OpCodes.Ldtoken, componentType);
        gen.Emit(OpCodes.Call, typeof(Type).GetMethod("GetTypeFromHandle") ?? throw new Exception("typeof not found?"));

        // push array
        gen.EmitWriteLine("push array");
        gen.Emit(OpCodes.Ldloc, localArray.LocalIndex);

        // call ActivatorUtilities.CreateInstance
        gen.EmitWriteLine("call ActivatorUtilities.CreateInstance");
        gen.Emit(
            OpCodes.Call,
            typeof(ActivatorUtilities).GetMethod("CreateInstance", new[] { typeof(IServiceProvider), typeof(Type), typeof(object[]) })
                ?? throw new Exception("method ActivatorUtilities.CreateInstance not found"));

        gen.EmitWriteLine("return");
        gen.Emit(OpCodes.Ret);
    }
}
