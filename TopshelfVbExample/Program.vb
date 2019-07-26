Imports Topshelf

Module Program

    Sub Main()
        Dim rc = HostFactory.Run(
            Sub(x)
                x.RunAsLocalSystem
                x.SetDescription("Topshelf Example for Visual Basic")
                x.SetDisplayName("TopshelfVbExample")
                x.SetServiceName("TopshelfVbExample")
                x.Service(Of TownCrier)
            End Sub)

        Dim exitCode = CInt(Convert.ChangeType(rc, rc.GetTypeCode()))
        Environment.ExitCode = exitCode
    End Sub

End Module
