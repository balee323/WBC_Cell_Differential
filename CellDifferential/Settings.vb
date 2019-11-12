Imports Newtonsoft.Json
Imports NLog

Public Enum CounterType
    Peripheral = 1
    BoneMarrow = 2
End Enum

Public Class Settings : Implements ISettings

    Private _dataRepo As IDataRepo
    Private _counterType As CounterType
    Private _cells As List(Of Cell)
    Private _logger As Logger = NLog.LogManager.GetCurrentClassLogger()

    Public Sub New(cells As List(Of Cell), counterType As CounterType)
        _counterType = counterType
        _cells = cells
        _dataRepo = New SqlLiteManager(_counterType)

    End Sub

    Public Sub SaveSettings() Implements ISettings.SaveSettings

        Dim cellSettings As List(Of CellSetting) = CreateCellSettings()

        Dim jsonStr = JsonConvert.SerializeObject(cellSettings, Formatting.Indented)
        cellSettings = JsonConvert.DeserializeObject(Of List(Of CellSetting))(jsonStr)

        _dataRepo.SaveUserData(jsonStr)

    End Sub

    Private Function CreateCellSettings() As List(Of CellSetting)

        Dim cellSettings As New List(Of CellSetting)

        For Each cell In _cells
            cellSettings.Add(New CellSetting With {.CellType = cell.getCellType(), .KeyMap = cell.getKeyMap(), .File = "File", .Position = cell.getPosition()})
        Next

        Return cellSettings

    End Function


    Public Sub Loadsettings() Implements ISettings.LoadSettings
        Try

            Dim jsonStr = _dataRepo.LoadUserSettings()
            Dim cellSettings As List(Of CellSetting) = JsonConvert.DeserializeObject(Of List(Of CellSetting))(jsonStr)

            Globals.ProgressBar.Increment(5)

            For Each cell In _cells
                For Each cellsetting In cellSettings
                    If (cell.getPosition = cellsetting.Position) Then
                        cell.ChangeCellType(cellsetting.CellType)
                        cell.changeKeyMap(cellsetting.KeyMap)
                        Exit For 'found it
                    End If
                Next

            Next
        Catch ex As Exception
            _logger.Error(ex)
        End Try

    End Sub

End Class
