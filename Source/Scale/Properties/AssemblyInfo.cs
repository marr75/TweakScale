﻿using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Scale")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("L Aerospace/KSP Division")]
[assembly: AssemblyProduct("Scale")]
[assembly: AssemblyCopyright("Copyright © 2018-2019 LisiasT")]
[assembly: AssemblyTrademark("TweakScale™ by Gaius Goodspeed, Biotronic, Pellinor, LisiasT")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access destination type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("99eed0a4-ba83-42d9-80bd-0591cf3840be")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(TweakScale.Version.Number)]
[assembly: AssemblyFileVersion(TweakScale.Version.Number)]
[assembly: KSPAssembly("Scale", TweakScale.Version.major, TweakScale.Version.minor)]
