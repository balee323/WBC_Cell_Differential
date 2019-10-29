Imports System.Security.Permissions
Imports Microsoft.Win32
Imports WBCDifferential


Public Class Settings : Implements ISettings


    Public Sub New(Cells As List(Of Cell))
        cellList = Cells
    End Sub


    Private cellList As List(Of Cell)

    Public Sub SavePeripheralKeyBindings() Implements ISettings.SavePeripheralKeyBindings
        Throw New NotImplementedException()
    End Sub

    Public Sub SaveBoneMarrowKeyBindings() Implements ISettings.SaveBoneMarrowKeyBindings
        Throw New NotImplementedException()
    End Sub

    Public Sub LoadPeripheralKeyBindings() Implements ISettings.LoadPeripheralKeyBindings
        Throw New NotImplementedException()
    End Sub

    Public Sub LoadBoneMarrowKeyBindings() Implements ISettings.LoadBoneMarrowKeyBindings
        Throw New NotImplementedException()
    End Sub

    Public Sub SavePeripheralCountingChannelNames() Implements ISettings.SavePeripheralCountingChannelNames
        Throw New NotImplementedException()
    End Sub

    Public Sub SaveBoneMarrowCountingChannelNames() Implements ISettings.SaveBoneMarrowCountingChannelNames
        Throw New NotImplementedException()
    End Sub

    Public Sub LoadPeripheralCountingChannelNames() Implements ISettings.LoadPeripheralCountingChannelNames
        Throw New NotImplementedException()
    End Sub

    Public Sub LoadBoneMarrowCountingChannelNames() Implements ISettings.LoadBoneMarrowCountingChannelNames
        Throw New NotImplementedException()
    End Sub


End Class
