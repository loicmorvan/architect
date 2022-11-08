using System.Reflection;
using System.Reflection.Emit;

namespace Foundation;

public static class FactoryCreator
{
    public static IFactory Create()
    {
        var assemblyName = "Factory_Implementation";
        var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName(assemblyName), AssemblyBuilderAccess.Run);
        var moduleBuilder = assemblyBuilder.DefineDynamicModule(assemblyName);
        var typeBuilder = moduleBuilder.DefineType("TypedFactory__IFactory");
        typeBuilder.AddInterfaceImplementation(typeof(IFactory));

        var constructorBuilder = typeBuilder.DefineConstructor(MethodAttributes.Public, CallingConventions.Any, Type.EmptyTypes);
        var constructorGenerator = constructorBuilder.GetILGenerator();
        constructorGenerator.Emit(OpCodes.Ldarg_0);

        var createMethodBuilder1 = typeBuilder.DefineMethod("Create", MethodAttributes.Public, typeof(IService), new[] { typeof(int) });
        var createMethodGenerator1 = createMethodBuilder1.GetILGenerator();
        createMethodGenerator1.Emit(OpCodes.Newobj, typeof(Component));
        createMethodGenerator1.Emit(OpCodes.Ret);

        var createMethodBuilder2 = typeBuilder.DefineMethod("Create", MethodAttributes.Public, typeof(IOtherService), new[] { typeof(float) });
        var createMethodGenerator2 = createMethodBuilder2.GetILGenerator();
        createMethodGenerator2.Emit(OpCodes.Newobj, typeof(OtherComponent));
        createMethodGenerator2.Emit(OpCodes.Ret);

        var type = typeBuilder.CreateType() ?? throw new Exception("unable to create type");

        return (IFactory)(Activator.CreateInstance(type) ?? throw new Exception());
    }
}
