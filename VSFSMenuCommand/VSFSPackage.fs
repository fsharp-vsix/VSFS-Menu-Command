namespace VSFSMenuCommand

open System
open System.Threading
open System.Runtime.InteropServices
open System.ComponentModel.Design
open System.Windows.Forms
open Microsoft.VisualStudio
open Microsoft.VisualStudio.Shell

[<AutoOpen>]
module Prelude =
    let inline isNull x = match x with null -> true | _ -> false

module Guids =
  let [<Literal>] guidVSFSMenuCommandPkgString      =   "E884895D-0F3D-4ABA-8CA0-15865ADEAD72"
  let [<Literal>] guidVSFSMenuCommandCmdSetString   =   "FF541739-EEC6-4A19-8F22-32C395D4FFD5"
  let             guidVSFSMenuCommandCmdSet         =   Guid guidVSFSMenuCommandCmdSetString

module CommandIDs =  let cmdidVSFSMenu = 0x100u

[< PackageRegistration (UseManagedResourcesOnly=true) >]
[< InstalledProductRegistration ("#110", "#112", "1.0", IconResourceID = 400) >]
[< ProvideMenuResource ("Menus.ctmenu", 1) >]
[< Guid "E884895D-0F3D-4ABA-8CA0-15865ADEAD72" >]
type VSFSPackage () as self =
    inherit Package ()

    let menuExecuteHandler =
        EventHandler (fun _ _ -> Thread(fun () ->
            MessageBox.Show
               "Speech is my hammer, bang the world into shape\n\
                Now let it fall.. HUH!" |> ignore).Start ())

    override __.Initialize () =
        base.Initialize ()

        let output = self.GetOutputPane ( VSConstants.GUID_OutWindowGeneralPane ,
                                          "Hip Hop |> Seq.iter printfn \"%s\""      )

        output.OutputStringThreadSafe
           "My restlessness is my nemesis\n\
            It's hard to really chill and sit still\n\
            Commit it to page, I write a rhyme\n\
            Sometimes won't finish for days\n\
            Scrutinize my literature from the large to the miniature\n\
            I mathematically administer\n\
            Subtract the wack\n\
            Selector, wheel it back, I'm feeling that\n\
            From the core to the perimeter black\n\
            You know the motto\n\
            Stay fluid even in staccato\n"
            |> ignore

        let menuService = base.GetService typeof<IMenuCommandService> :?> OleMenuCommandService

        if isNull menuService then () else
        let commandId   = CommandID (   Guids.guidVSFSMenuCommandCmdSet ,
                                        int CommandIDs.cmdidVSFSMenu    )

        let menuCommand = MenuCommand ( menuExecuteHandler, commandId   )
        menuService.AddCommand menuCommand