// IL code: Foundation
.class private auto ansi '<Module>'
{
} // end of class <Module>

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
	extends [System.Runtime]System.Attribute
{
	.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
		01 00 00 00
	)
	.custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = (
		01 00 00 00
	)
	// Methods
	.method public hidebysig specialname rtspecialname 
		instance void .ctor () cil managed 
	{
		// Method begins at RVA 0x2050
		// Header size: 1
		// Code size: 8 (0x8)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: call instance void [System.Runtime]System.Attribute::.ctor()
		IL_0006: nop
		IL_0007: ret
	} // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.NullableAttribute
	extends [System.Runtime]System.Attribute
{
	.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
		01 00 00 00
	)
	.custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = (
		01 00 00 00
	)
	.custom instance void [System.Runtime]System.AttributeUsageAttribute::.ctor(valuetype [System.Runtime]System.AttributeTargets) = (
		01 00 84 6b 00 00 02 00 54 02 0d 41 6c 6c 6f 77
		4d 75 6c 74 69 70 6c 65 00 54 02 09 49 6e 68 65
		72 69 74 65 64 00
	)
	// Fields
	.field public initonly uint8[] NullableFlags

	// Methods
	.method public hidebysig specialname rtspecialname 
		instance void .ctor (
			uint8 ''
		) cil managed 
	{
		// Method begins at RVA 0x2059
		// Header size: 1
		// Code size: 24 (0x18)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: call instance void [System.Runtime]System.Attribute::.ctor()
		IL_0006: nop
		IL_0007: ldarg.0
		IL_0008: ldc.i4.1
		IL_0009: newarr [System.Runtime]System.Byte
		IL_000e: dup
		IL_000f: ldc.i4.0
		IL_0010: ldarg.1
		IL_0011: stelem.i1
		IL_0012: stfld uint8[] System.Runtime.CompilerServices.NullableAttribute::NullableFlags
		IL_0017: ret
	} // end of method NullableAttribute::.ctor

	.method public hidebysig specialname rtspecialname 
		instance void .ctor (
			uint8[] ''
		) cil managed 
	{
		// Method begins at RVA 0x2072
		// Header size: 1
		// Code size: 15 (0xf)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: call instance void [System.Runtime]System.Attribute::.ctor()
		IL_0006: nop
		IL_0007: ldarg.0
		IL_0008: ldarg.1
		IL_0009: stfld uint8[] System.Runtime.CompilerServices.NullableAttribute::NullableFlags
		IL_000e: ret
	} // end of method NullableAttribute::.ctor

} // end of class System.Runtime.CompilerServices.NullableAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.NullableContextAttribute
	extends [System.Runtime]System.Attribute
{
	.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
		01 00 00 00
	)
	.custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = (
		01 00 00 00
	)
	.custom instance void [System.Runtime]System.AttributeUsageAttribute::.ctor(valuetype [System.Runtime]System.AttributeTargets) = (
		01 00 4c 14 00 00 02 00 54 02 0d 41 6c 6c 6f 77
		4d 75 6c 74 69 70 6c 65 00 54 02 09 49 6e 68 65
		72 69 74 65 64 00
	)
	// Fields
	.field public initonly uint8 Flag

	// Methods
	.method public hidebysig specialname rtspecialname 
		instance void .ctor (
			uint8 ''
		) cil managed 
	{
		// Method begins at RVA 0x2082
		// Header size: 1
		// Code size: 15 (0xf)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: call instance void [System.Runtime]System.Attribute::.ctor()
		IL_0006: nop
		IL_0007: ldarg.0
		IL_0008: ldarg.1
		IL_0009: stfld uint8 System.Runtime.CompilerServices.NullableContextAttribute::Flag
		IL_000e: ret
	} // end of method NullableContextAttribute::.ctor

} // end of class System.Runtime.CompilerServices.NullableContextAttribute

.class public auto ansi beforefieldinit Foundation.Component
	extends [System.Runtime]System.Object
	implements Foundation.IService
{
	// Fields
	.field private initonly int32 'value'

	// Methods
	.method public hidebysig specialname rtspecialname 
		instance void .ctor (
			int32 'value',
			float32 otherValue
		) cil managed 
	{
		// Method begins at RVA 0x2092
		// Header size: 1
		// Code size: 16 (0x10)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: call instance void [System.Runtime]System.Object::.ctor()
		IL_0006: nop
		IL_0007: nop
		IL_0008: ldarg.0
		IL_0009: ldarg.1
		IL_000a: stfld int32 Foundation.Component::'value'
		IL_000f: ret
	} // end of method Component::.ctor

} // end of class Foundation.Component

.class public auto ansi abstract sealed beforefieldinit Foundation.FactoryCreator
	extends [System.Runtime]System.Object
{
	.custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = (
		01 00 01 00 00
	)
	.custom instance void System.Runtime.CompilerServices.NullableAttribute::.ctor(uint8) = (
		01 00 00 00 00
	)
	// Nested Types
	.class nested private auto ansi sealed serializable beforefieldinit '<>c'
		extends [System.Runtime]System.Object
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		// Fields
		.field public static initonly class Foundation.FactoryCreator/'<>c' '<>9'
		.custom instance void System.Runtime.CompilerServices.NullableAttribute::.ctor(uint8) = (
			01 00 00 00 00
		)
		.field public static class [System.Runtime]System.Func`2<class [System.Runtime]System.Reflection.ParameterInfo, class [System.Runtime]System.Type> '<>9__1_0'
		.custom instance void System.Runtime.CompilerServices.NullableAttribute::.ctor(uint8) = (
			01 00 00 00 00
		)

		// Methods
		.method private hidebysig specialname rtspecialname static 
			void .cctor () cil managed 
		{
			// Method begins at RVA 0x2335
			// Header size: 1
			// Code size: 11 (0xb)
			.maxstack 8

			IL_0000: newobj instance void Foundation.FactoryCreator/'<>c'::.ctor()
			IL_0005: stsfld class Foundation.FactoryCreator/'<>c' Foundation.FactoryCreator/'<>c'::'<>9'
			IL_000a: ret
		} // end of method '<>c'::.cctor

		.method public hidebysig specialname rtspecialname 
			instance void .ctor () cil managed 
		{
			// Method begins at RVA 0x2341
			// Header size: 1
			// Code size: 8 (0x8)
			.maxstack 8

			IL_0000: ldarg.0
			IL_0001: call instance void [System.Runtime]System.Object::.ctor()
			IL_0006: nop
			IL_0007: ret
		} // end of method '<>c'::.ctor

		.method assembly hidebysig 
			instance class [System.Runtime]System.Type '<ImplementCreateMethod>b__1_0' (
				class [System.Runtime]System.Reflection.ParameterInfo x
			) cil managed 
		{
			.custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = (
				01 00 00 00 00
			)
			// Method begins at RVA 0x234a
			// Header size: 1
			// Code size: 7 (0x7)
			.maxstack 8

			IL_0000: ldarg.1
			IL_0001: callvirt instance class [System.Runtime]System.Type [System.Runtime]System.Reflection.ParameterInfo::get_ParameterType()
			IL_0006: ret
		} // end of method '<>c'::'<ImplementCreateMethod>b__1_0'

	} // end of class <>c

	.class nested private auto ansi sealed serializable beforefieldinit '<>c__0`1'<TFactory>
		extends [System.Runtime]System.Object
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		// Fields
		.field public static initonly class Foundation.FactoryCreator/'<>c__0`1'<!TFactory> '<>9'
		.custom instance void System.Runtime.CompilerServices.NullableAttribute::.ctor(uint8) = (
			01 00 00 00 00
		)
		.field public static class [System.Runtime]System.Func`2<class [System.Runtime]System.Reflection.MethodInfo, bool> '<>9__0_0'
		.custom instance void System.Runtime.CompilerServices.NullableAttribute::.ctor(uint8) = (
			01 00 00 00 00
		)

		// Methods
		.method private hidebysig specialname rtspecialname static 
			void .cctor () cil managed 
		{
			// Method begins at RVA 0x2352
			// Header size: 1
			// Code size: 11 (0xb)
			.maxstack 8

			IL_0000: newobj instance void class Foundation.FactoryCreator/'<>c__0`1'<!TFactory>::.ctor()
			IL_0005: stsfld class Foundation.FactoryCreator/'<>c__0`1'<!0> class Foundation.FactoryCreator/'<>c__0`1'<!TFactory>::'<>9'
			IL_000a: ret
		} // end of method '<>c__0`1'::.cctor

		.method public hidebysig specialname rtspecialname 
			instance void .ctor () cil managed 
		{
			// Method begins at RVA 0x235e
			// Header size: 1
			// Code size: 8 (0x8)
			.maxstack 8

			IL_0000: ldarg.0
			IL_0001: call instance void [System.Runtime]System.Object::.ctor()
			IL_0006: nop
			IL_0007: ret
		} // end of method '<>c__0`1'::.ctor

		.method assembly hidebysig 
			instance bool '<Create>b__0_0' (
				class [System.Runtime]System.Reflection.MethodInfo x
			) cil managed 
		{
			.custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = (
				01 00 00 00 00
			)
			// Method begins at RVA 0x2367
			// Header size: 1
			// Code size: 17 (0x11)
			.maxstack 8

			IL_0000: ldarg.1
			IL_0001: callvirt instance string [System.Runtime]System.Reflection.MemberInfo::get_Name()
			IL_0006: ldstr "Create"
			IL_000b: callvirt instance bool [System.Runtime]System.String::StartsWith(string)
			IL_0010: ret
		} // end of method '<>c__0`1'::'<Create>b__0_0'

	} // end of class <>c__0`1

	.class nested private auto ansi sealed beforefieldinit '<>c__DisplayClass0_0`1'<TFactory>
		extends [System.Runtime]System.Object
	{
		.custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (
			01 00 00 00
		)
		// Fields
		.field public class [System.Runtime]System.Reflection.MethodInfo 'method'
		.custom instance void System.Runtime.CompilerServices.NullableAttribute::.ctor(uint8) = (
			01 00 00 00 00
		)

		// Methods
		.method public hidebysig specialname rtspecialname 
			instance void .ctor () cil managed 
		{
			// Method begins at RVA 0x2379
			// Header size: 1
			// Code size: 8 (0x8)
			.maxstack 8

			IL_0000: ldarg.0
			IL_0001: call instance void [System.Runtime]System.Object::.ctor()
			IL_0006: nop
			IL_0007: ret
		} // end of method '<>c__DisplayClass0_0`1'::.ctor

		.method assembly hidebysig 
			instance bool '<Create>b__1' (
				class [Microsoft.Extensions.DependencyInjection.Abstractions]Microsoft.Extensions.DependencyInjection.ServiceDescriptor x
			) cil managed 
		{
			.custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = (
				01 00 00 00 00
			)
			// Method begins at RVA 0x2382
			// Header size: 1
			// Code size: 23 (0x17)
			.maxstack 8

			IL_0000: ldarg.1
			IL_0001: callvirt instance class [System.Runtime]System.Type [Microsoft.Extensions.DependencyInjection.Abstractions]Microsoft.Extensions.DependencyInjection.ServiceDescriptor::get_ServiceType()
			IL_0006: ldarg.0
			IL_0007: ldfld class [System.Runtime]System.Reflection.MethodInfo class Foundation.FactoryCreator/'<>c__DisplayClass0_0`1'<!TFactory>::'method'
			IL_000c: callvirt instance class [System.Runtime]System.Type [System.Runtime]System.Reflection.MethodInfo::get_ReturnType()
			IL_0011: call bool [System.Runtime]System.Type::op_Equality(class [System.Runtime]System.Type, class [System.Runtime]System.Type)
			IL_0016: ret
		} // end of method '<>c__DisplayClass0_0`1'::'<Create>b__1'

	} // end of class <>c__DisplayClass0_0`1


	// Methods
	.method public hidebysig static 
		!!TFactory Create<TFactory> (
			class [Microsoft.Extensions.DependencyInjection.Abstractions]Microsoft.Extensions.DependencyInjection.IServiceCollection services,
			class [System.ComponentModel]System.IServiceProvider serviceProvider
		) cil managed 
	{
		.param type TFactory
			.custom instance void System.Runtime.CompilerServices.NullableAttribute::.ctor(uint8) = (
				01 00 02 00 00
			)
		// Method begins at RVA 0x20a4
		// Header size: 12
		// Code size: 451 (0x1c3)
		.maxstack 7
		.locals init (
			[0] class [System.Runtime]System.Type,
			[1] string,
			[2] class [System.Reflection.Emit]System.Reflection.Emit.AssemblyBuilder,
			[3] class [System.Reflection.Emit]System.Reflection.Emit.ModuleBuilder,
			[4] class [System.Reflection.Emit]System.Reflection.Emit.TypeBuilder,
			[5] class [System.Reflection.Emit]System.Reflection.Emit.FieldBuilder,
			[6] class [System.Reflection.Emit]System.Reflection.Emit.ConstructorBuilder,
			[7] class [System.Reflection.Emit.ILGeneration]System.Reflection.Emit.ILGenerator,
			[8] class [System.Runtime]System.Type,
			[9] class [System.Runtime]System.Collections.Generic.IEnumerator`1<class [System.Runtime]System.Reflection.MethodInfo>,
			[10] class Foundation.FactoryCreator/'<>c__DisplayClass0_0`1'<!!TFactory>,
			[11] !!TFactory
		)

		IL_0000: nop
		IL_0001: ldtoken !!TFactory
		IL_0006: call class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
		IL_000b: stloc.0
		IL_000c: ldstr "TypedFactory_Implementations"
		IL_0011: stloc.1
		IL_0012: ldloc.1
		IL_0013: newobj instance void [System.Runtime]System.Reflection.AssemblyName::.ctor(string)
		IL_0018: ldc.i4.1
		IL_0019: call class [System.Reflection.Emit]System.Reflection.Emit.AssemblyBuilder [System.Reflection.Emit]System.Reflection.Emit.AssemblyBuilder::DefineDynamicAssembly(class [System.Runtime]System.Reflection.AssemblyName, valuetype [System.Reflection.Emit]System.Reflection.Emit.AssemblyBuilderAccess)
		IL_001e: stloc.2
		IL_001f: ldloc.2
		IL_0020: ldloc.1
		IL_0021: callvirt instance class [System.Reflection.Emit]System.Reflection.Emit.ModuleBuilder [System.Reflection.Emit]System.Reflection.Emit.AssemblyBuilder::DefineDynamicModule(string)
		IL_0026: stloc.3
		IL_0027: ldloc.3
		IL_0028: ldstr "TypedFactory__"
		IL_002d: ldloc.0
		IL_002e: callvirt instance string [System.Runtime]System.Reflection.MemberInfo::get_Name()
		IL_0033: ldstr "__Implementation"
		IL_0038: call string [System.Runtime]System.String::Concat(string, string, string)
		IL_003d: callvirt instance class [System.Reflection.Emit]System.Reflection.Emit.TypeBuilder [System.Reflection.Emit]System.Reflection.Emit.ModuleBuilder::DefineType(string)
		IL_0042: stloc.s 4
		IL_0044: ldloc.s 4
		IL_0046: ldloc.0
		IL_0047: callvirt instance void [System.Reflection.Emit]System.Reflection.Emit.TypeBuilder::AddInterfaceImplementation(class [System.Runtime]System.Type)
		IL_004c: nop
		IL_004d: ldloc.s 4
		IL_004f: ldstr "serviceProvider"
		IL_0054: ldtoken [System.ComponentModel]System.IServiceProvider
		IL_0059: call class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
		IL_005e: ldc.i4.1
		IL_005f: callvirt instance class [System.Reflection.Emit]System.Reflection.Emit.FieldBuilder [System.Reflection.Emit]System.Reflection.Emit.TypeBuilder::DefineField(string, class [System.Runtime]System.Type, valuetype [System.Runtime]System.Reflection.FieldAttributes)
		IL_0064: stloc.s 5
		IL_0066: ldloc.s 4
		IL_0068: ldc.i4.6
		IL_0069: ldc.i4.1
		IL_006a: ldc.i4.1
		IL_006b: newarr [System.Runtime]System.Type
		IL_0070: dup
		IL_0071: ldc.i4.0
		IL_0072: ldtoken [System.ComponentModel]System.IServiceProvider
		IL_0077: call class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
		IL_007c: stelem.ref
		IL_007d: callvirt instance class [System.Reflection.Emit]System.Reflection.Emit.ConstructorBuilder [System.Reflection.Emit]System.Reflection.Emit.TypeBuilder::DefineConstructor(valuetype [System.Runtime]System.Reflection.MethodAttributes, valuetype [System.Runtime]System.Reflection.CallingConventions, class [System.Runtime]System.Type[])
		IL_0082: stloc.s 6
		IL_0084: ldloc.s 6
		IL_0086: callvirt instance class [System.Reflection.Emit.ILGeneration]System.Reflection.Emit.ILGenerator [System.Reflection.Emit]System.Reflection.Emit.ConstructorBuilder::GetILGenerator()
		IL_008b: stloc.s 7
		IL_008d: ldloc.s 7
		IL_008f: ldsfld valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode [System.Reflection.Primitives]System.Reflection.Emit.OpCodes::Ldarg_0
		IL_0094: callvirt instance void [System.Reflection.Emit.ILGeneration]System.Reflection.Emit.ILGenerator::Emit(valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode)
		IL_0099: nop
		IL_009a: ldloc.s 7
		IL_009c: ldsfld valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode [System.Reflection.Primitives]System.Reflection.Emit.OpCodes::Call
		IL_00a1: ldtoken [System.Runtime]System.Object
		IL_00a6: call class [System.Runtime]System.Type [System.Runtime]System.Type::GetTypeFromHandle(valuetype [System.Runtime]System.RuntimeTypeHandle)
		IL_00ab: ldc.i4.s 20
		IL_00ad: ldsfld class [System.Runtime]System.Type[] [System.Runtime]System.Type::EmptyTypes
		IL_00b2: call instance class [System.Runtime]System.Reflection.ConstructorInfo [System.Runtime]System.Type::GetConstructor(valuetype [System.Runtime]System.Reflection.BindingFlags, class [System.Runtime]System.Type[])
		IL_00b7: dup
		IL_00b8: brtrue.s IL_00c1

		IL_00ba: pop
		IL_00bb: newobj instance void [System.Runtime]System.Exception::.ctor()
		IL_00c0: throw

		IL_00c1: callvirt instance void [System.Reflection.Emit.ILGeneration]System.Reflection.Emit.ILGenerator::Emit(valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode, class [System.Runtime]System.Reflection.ConstructorInfo)
		IL_00c6: nop
		IL_00c7: ldloc.s 7
		IL_00c9: ldsfld valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode [System.Reflection.Primitives]System.Reflection.Emit.OpCodes::Ldarg_1
		IL_00ce: callvirt instance void [System.Reflection.Emit.ILGeneration]System.Reflection.Emit.ILGenerator::Emit(valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode)
		IL_00d3: nop
		IL_00d4: ldloc.s 7
		IL_00d6: ldsfld valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode [System.Reflection.Primitives]System.Reflection.Emit.OpCodes::Stfld
		IL_00db: ldloc.s 5
		IL_00dd: callvirt instance void [System.Reflection.Emit.ILGeneration]System.Reflection.Emit.ILGenerator::Emit(valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode, class [System.Runtime]System.Reflection.FieldInfo)
		IL_00e2: nop
		IL_00e3: ldloc.s 7
		IL_00e5: ldsfld valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode [System.Reflection.Primitives]System.Reflection.Emit.OpCodes::Ret
		IL_00ea: callvirt instance void [System.Reflection.Emit.ILGeneration]System.Reflection.Emit.ILGenerator::Emit(valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode)
		IL_00ef: nop
		IL_00f0: nop
		IL_00f1: ldloc.0
		IL_00f2: callvirt instance class [System.Runtime]System.Reflection.MethodInfo[] [System.Runtime]System.Type::GetMethods()
		IL_00f7: ldsfld class [System.Runtime]System.Func`2<class [System.Runtime]System.Reflection.MethodInfo, bool> class Foundation.FactoryCreator/'<>c__0`1'<!!TFactory>::'<>9__0_0'
		IL_00fc: dup
		IL_00fd: brtrue.s IL_0116

		IL_00ff: pop
		IL_0100: ldsfld class Foundation.FactoryCreator/'<>c__0`1'<!0> class Foundation.FactoryCreator/'<>c__0`1'<!!TFactory>::'<>9'
		IL_0105: ldftn instance bool class Foundation.FactoryCreator/'<>c__0`1'<!!TFactory>::'<Create>b__0_0'(class [System.Runtime]System.Reflection.MethodInfo)
		IL_010b: newobj instance void class [System.Runtime]System.Func`2<class [System.Runtime]System.Reflection.MethodInfo, bool>::.ctor(object, native int)
		IL_0110: dup
		IL_0111: stsfld class [System.Runtime]System.Func`2<class [System.Runtime]System.Reflection.MethodInfo, bool> class Foundation.FactoryCreator/'<>c__0`1'<!!TFactory>::'<>9__0_0'

		IL_0116: call class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0> [System.Linq]System.Linq.Enumerable::Where<class [System.Runtime]System.Reflection.MethodInfo>(class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0>, class [System.Runtime]System.Func`2<!!0, bool>)
		IL_011b: callvirt instance class [System.Runtime]System.Collections.Generic.IEnumerator`1<!0> class [System.Runtime]System.Collections.Generic.IEnumerable`1<class [System.Runtime]System.Reflection.MethodInfo>::GetEnumerator()
		IL_0120: stloc.s 9
		.try
		{
			IL_0122: br.s IL_016c
			// loop start (head: IL_016c)
				IL_0124: newobj instance void class Foundation.FactoryCreator/'<>c__DisplayClass0_0`1'<!!TFactory>::.ctor()
				IL_0129: stloc.s 10
				IL_012b: ldloc.s 10
				IL_012d: ldloc.s 9
				IL_012f: callvirt instance !0 class [System.Runtime]System.Collections.Generic.IEnumerator`1<class [System.Runtime]System.Reflection.MethodInfo>::get_Current()
				IL_0134: stfld class [System.Runtime]System.Reflection.MethodInfo class Foundation.FactoryCreator/'<>c__DisplayClass0_0`1'<!!TFactory>::'method'
				IL_0139: nop
				IL_013a: ldloc.s 4
				IL_013c: ldloc.s 10
				IL_013e: ldfld class [System.Runtime]System.Reflection.MethodInfo class Foundation.FactoryCreator/'<>c__DisplayClass0_0`1'<!!TFactory>::'method'
				IL_0143: ldarg.0
				IL_0144: ldloc.s 10
				IL_0146: ldftn instance bool class Foundation.FactoryCreator/'<>c__DisplayClass0_0`1'<!!TFactory>::'<Create>b__1'(class [Microsoft.Extensions.DependencyInjection.Abstractions]Microsoft.Extensions.DependencyInjection.ServiceDescriptor)
				IL_014c: newobj instance void class [System.Runtime]System.Func`2<class [Microsoft.Extensions.DependencyInjection.Abstractions]Microsoft.Extensions.DependencyInjection.ServiceDescriptor, bool>::.ctor(object, native int)
				IL_0151: call !!0 [System.Linq]System.Linq.Enumerable::First<class [Microsoft.Extensions.DependencyInjection.Abstractions]Microsoft.Extensions.DependencyInjection.ServiceDescriptor>(class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0>, class [System.Runtime]System.Func`2<!!0, bool>)
				IL_0156: callvirt instance class [System.Runtime]System.Type [Microsoft.Extensions.DependencyInjection.Abstractions]Microsoft.Extensions.DependencyInjection.ServiceDescriptor::get_ImplementationType()
				IL_015b: dup
				IL_015c: brtrue.s IL_0165

				IL_015e: pop
				IL_015f: newobj instance void [System.Runtime]System.Exception::.ctor()
				IL_0164: throw

				IL_0165: call void Foundation.FactoryCreator::ImplementCreateMethod(class [System.Reflection.Emit]System.Reflection.Emit.TypeBuilder, class [System.Runtime]System.Reflection.MethodInfo, class [System.Runtime]System.Type)
				IL_016a: nop
				IL_016b: nop

				IL_016c: ldloc.s 9
				IL_016e: callvirt instance bool [System.Runtime]System.Collections.IEnumerator::MoveNext()
				IL_0173: brtrue.s IL_0124
			// end loop

			IL_0175: leave.s IL_0184
		} // end .try
		finally
		{
			IL_0177: ldloc.s 9
			IL_0179: brfalse.s IL_0183

			IL_017b: ldloc.s 9
			IL_017d: callvirt instance void [System.Runtime]System.IDisposable::Dispose()
			IL_0182: nop

			IL_0183: endfinally
		} // end handler

		IL_0184: ldloc.s 4
		IL_0186: callvirt instance class [System.Runtime]System.Type [System.Reflection.Emit]System.Reflection.Emit.TypeBuilder::CreateType()
		IL_018b: dup
		IL_018c: brtrue.s IL_019a

		IL_018e: pop
		IL_018f: ldstr "unable to create type"
		IL_0194: newobj instance void [System.Runtime]System.Exception::.ctor(string)
		IL_0199: throw

		IL_019a: stloc.s 8
		IL_019c: ldloc.s 8
		IL_019e: ldc.i4.1
		IL_019f: newarr [System.Runtime]System.Object
		IL_01a4: dup
		IL_01a5: ldc.i4.0
		IL_01a6: ldarg.1
		IL_01a7: stelem.ref
		IL_01a8: call object [System.Runtime]System.Activator::CreateInstance(class [System.Runtime]System.Type, object[])
		IL_01ad: dup
		IL_01ae: brtrue.s IL_01b7

		IL_01b0: pop
		IL_01b1: newobj instance void [System.Runtime]System.Exception::.ctor()
		IL_01b6: throw

		IL_01b7: unbox.any !!TFactory
		IL_01bc: stloc.s 11
		IL_01be: br.s IL_01c0

		IL_01c0: ldloc.s 11
		IL_01c2: ret
	} // end of method FactoryCreator::Create

	.method private hidebysig static 
		void ImplementCreateMethod (
			class [System.Reflection.Emit]System.Reflection.Emit.TypeBuilder typeBuilder,
			class [System.Runtime]System.Reflection.MethodInfo info,
			class [System.Runtime]System.Type componentType
		) cil managed 
	{
		// Method begins at RVA 0x2284
		// Header size: 12
		// Code size: 165 (0xa5)
		.maxstack 5
		.locals init (
			[0] class [System.Runtime]System.Type[],
			[1] class [System.Reflection.Emit]System.Reflection.Emit.MethodBuilder,
			[2] class [System.Reflection.Emit.ILGeneration]System.Reflection.Emit.ILGenerator,
			[3] int16,
			[4] bool
		)

		IL_0000: nop
		IL_0001: ldarg.1
		IL_0002: callvirt instance class [System.Runtime]System.Reflection.ParameterInfo[] [System.Runtime]System.Reflection.MethodBase::GetParameters()
		IL_0007: ldsfld class [System.Runtime]System.Func`2<class [System.Runtime]System.Reflection.ParameterInfo, class [System.Runtime]System.Type> Foundation.FactoryCreator/'<>c'::'<>9__1_0'
		IL_000c: dup
		IL_000d: brtrue.s IL_0026

		IL_000f: pop
		IL_0010: ldsfld class Foundation.FactoryCreator/'<>c' Foundation.FactoryCreator/'<>c'::'<>9'
		IL_0015: ldftn instance class [System.Runtime]System.Type Foundation.FactoryCreator/'<>c'::'<ImplementCreateMethod>b__1_0'(class [System.Runtime]System.Reflection.ParameterInfo)
		IL_001b: newobj instance void class [System.Runtime]System.Func`2<class [System.Runtime]System.Reflection.ParameterInfo, class [System.Runtime]System.Type>::.ctor(object, native int)
		IL_0020: dup
		IL_0021: stsfld class [System.Runtime]System.Func`2<class [System.Runtime]System.Reflection.ParameterInfo, class [System.Runtime]System.Type> Foundation.FactoryCreator/'<>c'::'<>9__1_0'

		IL_0026: call class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!1> [System.Linq]System.Linq.Enumerable::Select<class [System.Runtime]System.Reflection.ParameterInfo, class [System.Runtime]System.Type>(class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0>, class [System.Runtime]System.Func`2<!!0, !!1>)
		IL_002b: call !!0[] [System.Linq]System.Linq.Enumerable::ToArray<class [System.Runtime]System.Type>(class [System.Runtime]System.Collections.Generic.IEnumerable`1<!!0>)
		IL_0030: stloc.0
		IL_0031: ldarg.0
		IL_0032: ldarg.1
		IL_0033: callvirt instance string [System.Runtime]System.Reflection.MemberInfo::get_Name()
		IL_0038: ldc.i4.s 70
		IL_003a: ldarg.1
		IL_003b: callvirt instance class [System.Runtime]System.Type [System.Runtime]System.Reflection.MethodInfo::get_ReturnType()
		IL_0040: ldloc.0
		IL_0041: callvirt instance class [System.Reflection.Emit]System.Reflection.Emit.MethodBuilder [System.Reflection.Emit]System.Reflection.Emit.TypeBuilder::DefineMethod(string, valuetype [System.Runtime]System.Reflection.MethodAttributes, class [System.Runtime]System.Type, class [System.Runtime]System.Type[])
		IL_0046: stloc.1
		IL_0047: ldloc.1
		IL_0048: callvirt instance class [System.Reflection.Emit.ILGeneration]System.Reflection.Emit.ILGenerator [System.Reflection.Emit]System.Reflection.Emit.MethodBuilder::GetILGenerator()
		IL_004d: stloc.2
		IL_004e: ldc.i4.0
		IL_004f: stloc.3
		IL_0050: br.s IL_0068
		// loop start (head: IL_0068)
			IL_0052: nop
			IL_0053: ldloc.2
			IL_0054: ldsfld valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode [System.Reflection.Primitives]System.Reflection.Emit.OpCodes::Ldarg_S
			IL_0059: ldloc.3
			IL_005a: ldc.i4.1
			IL_005b: add
			IL_005c: callvirt instance void [System.Reflection.Emit.ILGeneration]System.Reflection.Emit.ILGenerator::Emit(valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode, int32)
			IL_0061: nop
			IL_0062: nop
			IL_0063: ldloc.3
			IL_0064: ldc.i4.1
			IL_0065: add
			IL_0066: conv.i2
			IL_0067: stloc.3

			IL_0068: ldloc.3
			IL_0069: ldloc.0
			IL_006a: ldlen
			IL_006b: conv.i4
			IL_006c: clt
			IL_006e: stloc.s 4
			IL_0070: ldloc.s 4
			IL_0072: brtrue.s IL_0052
		// end loop

		IL_0074: ldloc.2
		IL_0075: ldsfld valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode [System.Reflection.Primitives]System.Reflection.Emit.OpCodes::Newobj
		IL_007a: ldarg.2
		IL_007b: ldc.i4.s 20
		IL_007d: ldloc.0
		IL_007e: callvirt instance class [System.Runtime]System.Reflection.ConstructorInfo [System.Runtime]System.Type::GetConstructor(valuetype [System.Runtime]System.Reflection.BindingFlags, class [System.Runtime]System.Type[])
		IL_0083: dup
		IL_0084: brtrue.s IL_0092

		IL_0086: pop
		IL_0087: ldstr "constructor not found on component"
		IL_008c: newobj instance void [System.Runtime]System.Exception::.ctor(string)
		IL_0091: throw

		IL_0092: callvirt instance void [System.Reflection.Emit.ILGeneration]System.Reflection.Emit.ILGenerator::Emit(valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode, class [System.Runtime]System.Reflection.ConstructorInfo)
		IL_0097: nop
		IL_0098: ldloc.2
		IL_0099: ldsfld valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode [System.Reflection.Primitives]System.Reflection.Emit.OpCodes::Ret
		IL_009e: callvirt instance void [System.Reflection.Emit.ILGeneration]System.Reflection.Emit.ILGenerator::Emit(valuetype [System.Reflection.Primitives]System.Reflection.Emit.OpCode)
		IL_00a3: nop
		IL_00a4: ret
	} // end of method FactoryCreator::ImplementCreateMethod

} // end of class Foundation.FactoryCreator

.class interface public auto ansi abstract Foundation.IFactory
{
	.custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = (
		01 00 01 00 00
	)
	// Methods
	.method public hidebysig newslot abstract virtual 
		instance class Foundation.IService CreateService (
			int32 'value',
			float32 otherValue
		) cil managed 
	{
	} // end of method IFactory::CreateService

	.method public hidebysig newslot abstract virtual 
		instance class Foundation.IOtherService CreateOtherService (
			string test
		) cil managed 
	{
	} // end of method IFactory::CreateOtherService

} // end of class Foundation.IFactory

.class interface public auto ansi abstract Foundation.IOtherService
{
} // end of class Foundation.IOtherService

.class interface public auto ansi abstract Foundation.IService
{
} // end of class Foundation.IService

