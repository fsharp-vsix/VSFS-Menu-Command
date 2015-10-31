namespace System
open System.Reflection
open System.Runtime.CompilerServices

//[<assembly: InternalsVisibleToAttribute("FSharpVSPowerTools.Tests")>]
[<assembly: AssemblyTitleAttribute "VSFSMenuCommand">]
[<assembly: AssemblyProductAttribute "VSFSMenuCommand">]
[<assembly: AssemblyDescriptionAttribute "F# Demands A Menu Command">]
[<assembly: AssemblyVersionAttribute "0.0.0.01">]
[<assembly: AssemblyFileVersionAttribute "0.0.0.01">]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.0.01"