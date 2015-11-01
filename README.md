## VSFS Menu Command
----------------------------

Basic scaffold for creating and registering menu commands in Visual Studio using F#

`VSFSMenuCommand.fsproj` contains annotations explaining the way this project is configured.

![VSFS Menu Command In Action](http://i.imgur.com/IvD7GKo.png)

`%APPDATA%\Local\Microsoft\VisualStudio\12.0Exp\Extensions\Jared
Hester\VSFS Menu Command\1.0` should contain the following files when
the `Debug | Start Debugging (F5)` menu item is selected (thereby
starting the VS Experimental Instance):

   extension.vsixmanifest
   FSharp.Core.dll
   VSFSMenuCommand.dll
   VSFSMenuCommand.pdb
   VSFSMenuCommand.pkgdef