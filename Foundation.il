.class public auto ansi beforefieldinit Foundation.Factory
	extends [System.Runtime]System.Object
	implements Foundation.IFactory
{
	// Methods
	.method public final hidebysig newslot virtual 
		instance class Foundation.IService Create (
			int32 'value'
		) cil managed 
	{
		.custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = (
			01 00 01 00 00
		)
		// Method begins at RVA 0x209c
		// Header size: 12
		// Code size: 12 (0xc)
		.maxstack 1
		.locals init (
			[0] class Foundation.IService
		)

		IL_0000: nop
		IL_0001: ldarg.1
		IL_0002: newobj instance void Foundation.Component::.ctor(int32)
		IL_0007: stloc.0
		IL_0008: br.s IL_000a

		IL_000a: ldloc.0
		IL_000b: ret
	} // end of method Factory::Create

	.method public final hidebysig newslot virtual 
		instance class Foundation.IOtherService Create (
			float32 'value'
		) cil managed 
	{
		.custom instance void System.Runtime.CompilerServices.NullableContextAttribute::.ctor(uint8) = (
			01 00 01 00 00
		)
		// Method begins at RVA 0x20b4
		// Header size: 12
		// Code size: 12 (0xc)
		.maxstack 1
		.locals init (
			[0] class Foundation.IOtherService
		)

		IL_0000: nop
		IL_0001: ldarg.1
		IL_0002: newobj instance void Foundation.OtherComponent::.ctor(float32)
		IL_0007: stloc.0
		IL_0008: br.s IL_000a

		IL_000a: ldloc.0
		IL_000b: ret
	} // end of method Factory::Create

	.method public hidebysig specialname rtspecialname 
		instance void .ctor () cil managed 
	{
		// Method begins at RVA 0x20cc
		// Header size: 1
		// Code size: 8 (0x8)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: call instance void [System.Runtime]System.Object::.ctor()
		IL_0006: nop
		IL_0007: ret
	} // end of method Factory::.ctor

} // end of class Foundation.Factory
