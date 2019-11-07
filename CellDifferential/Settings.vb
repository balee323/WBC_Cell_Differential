Imports System.Security.Permissions
Imports Microsoft.Win32
Imports Newtonsoft.Json
Imports WBCDifferential


Public Enum CounterType
    Peripheral = 1
    BoneMarrow = 2
End Enum

Public Class Settings : Implements ISettings

    Private _dataRepo As IDataRepo
    Private _cellList As List(Of Cell)
    Private _counterType As CounterType

    Public Sub New(cells As List(Of Cell), counterType As CounterType)
        _counterType = counterType
        _cellList = cells
        _dataRepo = New SqlLiteManager(_counterType)

    End Sub

    Public Sub SaveKeyBindings() Implements ISettings.SaveKeyBindings


        'we need a convert to settings function() for the cells...

        'then a modify cells funtion() once the cell settings load...

        Dim cellSettings As New List(Of CellSetting)
        cellSettings.Add(New CellSetting With {.CellType = "NRBC", .KeyMap = 104, .File = "File", .Position = 0})
        cellSettings.Add(New CellSetting With {.CellType = "blast", .KeyMap = 106, .File = "File", .Position = 1})


        Dim jsonStr = JsonConvert.SerializeObject(cellSettings, Formatting.Indented)

        'Dim userControlSettings = JsonConvert.DeserializeObject(Of CellSetting)(jsonStr)

        cellSettings = JsonConvert.DeserializeObject(Of List(Of CellSetting))(jsonStr)


        _dataRepo.SaveUserData(jsonStr)


    End Sub

    Public Sub SaveCountingChannelNames() Implements ISettings.SaveCountingChannelNames
        Throw New NotImplementedException()
    End Sub

    Public Sub LoadKeyBindings() Implements ISettings.LoadKeyBindings
        Throw New NotImplementedException()
    End Sub

    Public Sub LoadCountingChannelNames() Implements ISettings.LoadCountingChannelNames
        Throw New NotImplementedException()
    End Sub






End Class
