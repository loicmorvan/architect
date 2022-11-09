using System.Reflection;
using System.Reflection.Emit;

namespace Foundation;

public static class FactoryCreator
{
    public static TFactory Create<TFactory>()
    {
        var assemblyName = "Factory_Implementation";
        var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(assemblyName), AssemblyBuilderAccess.Run);
        var moduleBuilder = assemblyBuilder.DefineDynamicModule(assemblyName);
        var typeBuilder = moduleBuilder.DefineType("TypedFactory__IFactory");
        typeBuilder.AddInterfaceImplementation(typeof(TFactory));

        var createMethodBuilder1 = typeBuilder.DefineMethod("CreateService", MethodAttributes.Public | MethodAttributes.Virtual, typeof(IService), new[] { typeof(int) });
        var createMethodGenerator1 = createMethodBuilder1.GetILGenerator();
        createMethodGenerator1.Emit(OpCodes.Ldarg_1);
        createMethodGenerator1.Emit(OpCodes.Newobj, typeof(Component).GetConstructor(BindingFlags.Instance | BindingFlags.Public, new[] { typeof(int) }) ?? throw new Exception("constructor not found on Component"));
        createMethodGenerator1.Emit(OpCodes.Ret);

        var type = typeBuilder.CreateType() ?? throw new Exception("unable to create type");

        return (TFactory)(Activator.CreateInstance(type) ?? throw new Exception());
    }
}
