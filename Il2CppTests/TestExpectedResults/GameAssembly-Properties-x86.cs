﻿using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 0: mscorlib.dll - 0
[assembly: AssemblyCompany] // 0x1000EC00
[assembly: AssemblyCopyright] // 0x1000EC00
[assembly: AssemblyDefaultAlias] // 0x1000EC00
[assembly: AssemblyDelaySign] // 0x1000EC00
[assembly: AssemblyDescription] // 0x1000EC00
[assembly: AssemblyFileVersion] // 0x1000EC00
[assembly: AssemblyInformationalVersion] // 0x1000EC00
[assembly: AssemblyKeyFile] // 0x1000EC00
[assembly: AssemblyProduct] // 0x1000EC00
[assembly: AssemblyTitle] // 0x1000EC00
[assembly: CLSCompliant] // 0x1000EC00
[assembly: CompilationRelaxations] // 0x1000EC00
[assembly: ComVisible] // 0x1000EC00
[assembly: Debuggable] // 0x1000EC00
[assembly: DefaultDependency] // 0x1000EC00
[assembly: Guid] // 0x1000EC00
[assembly: NeutralResourcesLanguage] // 0x1000EC00
[assembly: RuntimeCompatibility] // 0x1000EC00
[assembly: SatelliteContractVersion] // 0x1000EC00
[assembly: StringFreezing] // 0x1000EC00
[assembly: TypeLibVersion] // 0x1000EC00

// Image 1: Properties.dll - 1810
[assembly: CompilationRelaxations] // 0x1000D0F0
[assembly: Debuggable] // 0x1000D0F0
[assembly: RuntimeCompatibility] // 0x1000D0F0

// Namespace: <global namespace>
internal static class Consts // TypeDefIndex: 100
{
	// Fields
	public const string MonoVersion = "2.6.5.0";
	public const string MonoCompany = "MONO development team";
	public const string MonoProduct = "MONO Common language infrastructure";
	public const string MonoCopyright = "(c) various MONO Authors";
	public const string FxVersion = "2.0.0.0";
	public const string VsVersion = "8.0.0.0";
	public const string FxFileVersion = "2.0.50727.1433";
	public const string VsFileVersion = "8.0.50727.1433";
	public const string AssemblyI18N = "I18N, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
	public const string AssemblyMicrosoft_VisualStudio = "Microsoft.VisualStudio, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblyMicrosoft_VisualStudio_Web = "Microsoft.VisualStudio.Web, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblyMicrosoft_VSDesigner = "Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblyMono_Http = "Mono.Http, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
	public const string AssemblyMono_Posix = "Mono.Posix, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
	public const string AssemblyMono_Security = "Mono.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
	public const string AssemblyMono_Messaging_RabbitMQ = "Mono.Messaging.RabbitMQ, Version=2.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
	public const string AssemblyCorlib = "mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string AssemblySystem = "System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string AssemblySystem_Data = "System.Data, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string AssemblySystem_Design = "System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_DirectoryServices = "System.DirectoryServices, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_Drawing = "System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_Drawing_Design = "System.Drawing.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_Messaging = "System.Messaging, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_Security = "System.Security, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_ServiceProcess = "System.ServiceProcess, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_Web = "System.Web, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_Windows_Forms = "System.Windows.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string AssemblySystem_Core = "System.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
}

// Namespace: <global namespace>
internal sealed class Locale // TypeDefIndex: 101
{
	// Constructors
	private Locale(); // 0x100BF000

	// Methods
	public static string GetText(string msg); // 0x100F7810
	public static string GetText(string fmt, params /* 0x10009AD0 */ object[] args); // 0x10261460
}

// Namespace: Il2CppTests.TestSources
internal class Test // TypeDefIndex: 1811
{
	// Properties
	private int prop1 { get; set; } // 0x100BF0C0 0x100EB270
	protected int prop2 { get; private set; } // 0x100C5B30 0x100C5B50
	protected int prop3 { private get; set; } // 0x100BFC20 0x100C5B40
	public static int prop4 { private get; set; } // 0x1034DAF0 0x1034DB20
	public string this[int i] { get; } // 0x1034DA90 
	public string this[double d] { get; } // 0x1034DA60 
	public string this[long l] { set; } // 0x100C5530
	public string this[float f] { get; set; } // 0x1034DAC0 0x100C5530
	public bool this[int i, int j] { get; } // 0x100E5880 

	// Constructors
	public Test(); // 0x100BF000
}

