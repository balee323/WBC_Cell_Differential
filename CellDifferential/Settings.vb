Imports System.Security.Permissions
Imports Microsoft.Win32

Public Class Settings

    Public Structure RegistryKeyName
        Public Shared PeriheralKeys As String = "KeyMappings1"
        Public Shared BoneMarrowKeys As String = "KeyMappings2"
        Public Shared PeripheralChannels As String = "ChannelNames1"
        ' Public Shared BoneMarrowChannels As String = "ChannelNames2"
    End Structure






    'get key values  (variables used by both forms)
    Public Shared Key1 As String
    Public Shared Key2 As String
    Public Shared Key3 As String
    Public Shared Key4 As String
    Public Shared Key5 As String
    Public Shared Key6 As String
    Public Shared Key7 As String
    Public Shared Key8 As String
    Public Shared Key9 As String
    Public Shared Key10 As String
    Public Shared Key11 As String
    Public Shared Key12 As String
    Public Shared Key13 As String
    Public Shared Key14 As String
    Public Shared Key15 As String
    Public Shared Key16 As String

    Public Shared Cell1 As String
    Public Shared Cell2 As String
    Public Shared Cell3 As String
    Public Shared Cell4 As String
    Public Shared Cell5 As String
    Public Shared Cell6 As String
    Public Shared Cell7 As String
    Public Shared Cell8 As String
    Public Shared Cell9 As String
    Public Shared Cell10 As String
    Public Shared Cell11 As String
    Public Shared Cell12 As String
    Public Shared Cell13 As String
    Public Shared Cell14 As String
    Public Shared Cell15 As String
    Public Shared Cell16 As String



    ' Create a subkey named WBCDifferential under HKEY_CURRENT_USER.

    Dim WBCDifferential As RegistryKey = _
      Registry.CurrentUser.CreateSubKey("WBCDifferentialCounter3.1")


    Public Sub SavePeripheralKeyBindings()

        Registry.CurrentUser.OpenSubKey("WBCDifferentialCounter3.1")

        Dim Key As String

        Key = "KeyMappings1"

        Dim passed As Boolean = False

        passed = exists(Key)

        If passed Then
            WBCDifferential.DeleteSubKeyTree("KeyMappings1")
        End If


        Dim KeyMappings As RegistryKey =
        WBCDifferential.CreateSubKey("KeyMappings1")

        KeyMappings.SetValue("Cell1", AllCells.PeripheralCells(0).getKeyMapChar()) 'seg
        KeyMappings.SetValue("Cell2", AllCells.PeripheralCells(1).getKeyMapChar()) 'lym
        KeyMappings.SetValue("Cell3", AllCells.PeripheralCells(2).getKeyMapChar()) 'mono
        KeyMappings.SetValue("Cell4", AllCells.PeripheralCells(3).getKeyMapChar()) 'eos
        KeyMappings.SetValue("Cell5", AllCells.PeripheralCells(4).getKeyMapChar()) 'baso
        KeyMappings.SetValue("Cell6", AllCells.PeripheralCells(5).getKeyMapChar()) 'band
        KeyMappings.SetValue("Cell7", AllCells.PeripheralCells(6).getKeyMapChar()) 'meta
        KeyMappings.SetValue("Cell8", AllCells.PeripheralCells(7).getKeyMapChar()) 'myelo
        KeyMappings.SetValue("Cell9", AllCells.PeripheralCells(8).getKeyMapChar()) 'ProMyelo
        KeyMappings.SetValue("Cell10", AllCells.PeripheralCells(9).getKeyMapChar()) 'Blast
        KeyMappings.SetValue("Cell11", AllCells.PeripheralCells(10).getKeyMapChar()) 'NRBC

        KeyMappings.Close()
        ' WBCDifferential.Close()

    End Sub
    Public Sub SavePeripheralCountChannels()

        Registry.CurrentUser.OpenSubKey("WBCDifferentialCounter3.1")

        Dim Key As String

        Key = "KeyMappings1"

        Dim passed As Boolean = False

        passed = exists(Key)

        If passed Then
            WBCDifferential.DeleteSubKeyTree("ChannelNames1")
        End If


        Dim KeyMappings As RegistryKey =
        WBCDifferential.CreateSubKey("ChannelNames1")

        KeyMappings.SetValue("Cell1", AllCells.PeripheralCells(0).getCellType()) 'seg
        KeyMappings.SetValue("Cell2", AllCells.PeripheralCells(1).getCellType()) 'lym
        KeyMappings.SetValue("Cell3", AllCells.PeripheralCells(2).getCellType()) 'mono
        KeyMappings.SetValue("Cell4", AllCells.PeripheralCells(3).getCellType()) 'eos
        KeyMappings.SetValue("Cell5", AllCells.PeripheralCells(4).getCellType()) 'baso
        KeyMappings.SetValue("Cell6", AllCells.PeripheralCells(5).getCellType()) 'band
        KeyMappings.SetValue("Cell7", AllCells.PeripheralCells(6).getCellType()) 'meta
        KeyMappings.SetValue("Cell8", AllCells.PeripheralCells(7).getCellType()) 'myelo
        KeyMappings.SetValue("Cell9", AllCells.PeripheralCells(8).getCellType()) 'ProMyelo
        KeyMappings.SetValue("Cell10", AllCells.PeripheralCells(9).getCellType()) 'Blast
        KeyMappings.SetValue("Cell11", AllCells.PeripheralCells(10).getCellType()) 'NRBC

        KeyMappings.Close()
        ' WBCDifferential.Close()

    End Sub

    Public Sub SaveBoneMarrowKeyBindings()



        Dim Key As String

        Key = "KeyMappings2"

        Dim passed As Boolean = False

        passed = exists(Key)

        If passed Then
            WBCDifferential.DeleteSubKeyTree("KeyMappings2")
        End If


        Dim KeyMappings As RegistryKey =
        WBCDifferential.CreateSubKey("KeyMappings2")


        'keymap settings

        KeyMappings.SetValue("Cell1", AllCells.BoneMarrowCells(0).getKeyMapChar()) 'seg
        KeyMappings.SetValue("Cell2", AllCells.BoneMarrowCells(1).getKeyMapChar()) 'lym
        KeyMappings.SetValue("Cell3", AllCells.BoneMarrowCells(2).getKeyMapChar()) 'PlasmaCell
        KeyMappings.SetValue("Cell4", AllCells.BoneMarrowCells(3).getKeyMapChar()) 'mono
        KeyMappings.SetValue("Cell5", AllCells.BoneMarrowCells(4).getKeyMapChar()) 'eos
        KeyMappings.SetValue("Cell6", AllCells.BoneMarrowCells(5).getKeyMapChar()) 'baso
        KeyMappings.SetValue("Cell7", AllCells.BoneMarrowCells(6).getKeyMapChar()) 'band
        KeyMappings.SetValue("Cell8", AllCells.BoneMarrowCells(7).getKeyMapChar()) 'User1
        KeyMappings.SetValue("Cell9", AllCells.BoneMarrowCells(8).getKeyMapChar()) 'meta
        KeyMappings.SetValue("Cell10", AllCells.BoneMarrowCells(9).getKeyMapChar()) 'myelo
        KeyMappings.SetValue("Cell11", AllCells.BoneMarrowCells(10).getKeyMapChar()) 'ProMyelo
        KeyMappings.SetValue("Cell12", AllCells.BoneMarrowCells(11).getKeyMapChar()) 'Blast
        KeyMappings.SetValue("Cell13", AllCells.BoneMarrowCells(12).getKeyMapChar()) 'Normoblast
        KeyMappings.SetValue("Cell14", AllCells.BoneMarrowCells(13).getKeyMapChar()) 'ProNormoblast
        KeyMappings.SetValue("Cell15", AllCells.BoneMarrowCells(14).getKeyMapChar()) 'User2
        KeyMappings.SetValue("Cell16", AllCells.BoneMarrowCells(15).getKeyMapChar()) 'User3


        KeyMappings.Close()
        'WBCDifferential.Close()



    End Sub


    Public Sub LoadSettings1()


        Dim KeyMappings As RegistryKey = WBCDifferential.OpenSubKey("KeyMappings1")
        Key1 = CStr(KeyMappings.GetValue("Cell1"))
        Key2 = CStr(KeyMappings.GetValue("Cell2"))
        Key3 = CStr(KeyMappings.GetValue("Cell3"))
        Key4 = CStr(KeyMappings.GetValue("Cell4"))
        Key5 = CStr(KeyMappings.GetValue("Cell5"))
        Key6 = CStr(KeyMappings.GetValue("Cell6"))
        Key7 = CStr(KeyMappings.GetValue("Cell7"))
        Key8 = CStr(KeyMappings.GetValue("Cell8"))
        Key9 = CStr(KeyMappings.GetValue("Cell9"))
        Key10 = CStr(KeyMappings.GetValue("Cell10"))
        Key11 = CStr(KeyMappings.GetValue("Cell11"))
        Key12 = CStr(KeyMappings.GetValue("Cell12"))
        Key13 = CStr(KeyMappings.GetValue("Cell13"))

    End Sub


    Public Sub LoadBoneMarrowKeyBindings()


        Dim KeyMappings As RegistryKey = WBCDifferential.OpenSubKey("KeyMappings2")
        Key1 = CStr(KeyMappings.GetValue("Cell1"))
        Key2 = CStr(KeyMappings.GetValue("Cell2"))
        Key3 = CStr(KeyMappings.GetValue("Cell3"))
        Key4 = CStr(KeyMappings.GetValue("Cell4"))
        Key5 = CStr(KeyMappings.GetValue("Cell5"))
        Key6 = CStr(KeyMappings.GetValue("Cell6"))
        Key7 = CStr(KeyMappings.GetValue("Cell7"))
        Key8 = CStr(KeyMappings.GetValue("Cell8"))
        Key9 = CStr(KeyMappings.GetValue("Cell9"))
        Key10 = CStr(KeyMappings.GetValue("Cell10"))
        Key11 = CStr(KeyMappings.GetValue("Cell11"))
        Key12 = CStr(KeyMappings.GetValue("Cell12"))
        Key13 = CStr(KeyMappings.GetValue("Cell13"))
        Key14 = CStr(KeyMappings.GetValue("Cell14"))
        Key15 = CStr(KeyMappings.GetValue("Cell15"))
        Key16 = CStr(KeyMappings.GetValue("Cell16"))

    End Sub


    Public Function exists(key As String) As Boolean
        Dim YesExists As Boolean = False


        If WBCDifferential.ToString <> Nothing And WBCDifferential.GetSubKeyNames.Count > 0 Then
            If WBCDifferential.GetSubKeyNames.Contains(key) Then
                YesExists = True

            End If
        End If

        Return YesExists
    End Function


    Sub CloseRegistry()
        WBCDifferential.Close()
    End Sub



End Class
