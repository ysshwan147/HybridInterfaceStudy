// Copyright (c) Mixed Reality Toolkit Contributors
// Licensed under the BSD 3-Clause

using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: AssemblyProduct("Microsoft® Mixed Reality Toolkit Core Definitions")]
[assembly: AssemblyCopyright("Copyright (c) Mixed Reality Toolkit Contributors")]

[assembly: InternalsVisibleTo("MixedReality.Toolkit.Input")]

// The AssemblyVersion attribute is checked-in and is recommended not to be changed often.
// https://docs.microsoft.com/troubleshoot/visualstudio/general/assembly-version-assembly-file-version
// AssemblyFileVersion and AssemblyInformationalVersion are added by pack-upm.ps1 to match the current MRTK build version.
[assembly: AssemblyVersion("3.0.0.0")]
[assembly: AssemblyFileVersion("3.0.0")]
[assembly: AssemblyInformationalVersion("3.0.0")]