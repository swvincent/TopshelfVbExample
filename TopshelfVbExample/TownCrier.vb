Imports System.Timers
Imports Topshelf

Public Class TownCrier
    Implements ServiceControl

    ReadOnly _timer As Timer

    Public Sub New()
        _timer = New Timer(1000) With {
            .AutoReset = True}

        AddHandler _timer.Elapsed, AddressOf OnTimedEvent
    End Sub

    Private Sub OnTimedEvent(source As Object, e As System.Timers.ElapsedEventArgs)
        Console.WriteLine($"It is {DateTime.Now} and all is well")
    End Sub

    Public Function Start(hostControl As HostControl) As Boolean Implements ServiceControl.Start
        _timer.Start()
        Return True
    End Function

    Public Function [Stop](hostControl As HostControl) As Boolean Implements ServiceControl.Stop
        _timer.Stop()
        Return True
    End Function
End Class
