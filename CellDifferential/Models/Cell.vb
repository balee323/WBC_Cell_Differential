﻿Imports System.Windows.Forms.Form


Public Class Cell
    Private _KeyMap As Integer = 0
    Private _ImageFile As String = ""
    Private _Count As Integer = 0

    Public Property EnableInCounter As Boolean = True
    Public Property CellType As String = Me.CellType
    Public Property Position As Integer = Me.Position



    Public Sub New(CellType As String, KeyMap As Integer, ImageFile As String, Position As Integer)
        Me.CellType = CellType 'Seg, Lym, etc..
        Me._KeyMap = KeyMap
        Me._ImageFile = ImageFile
        Me.Position = Position

    End Sub

    Public Sub New(CellType As String, KeyMap As String, ImageFile As String, Position As Integer)
        Me._CellType = CellType 'Seg, Lym, etc..
        Me._KeyMap = Asc(KeyMap) 'string to Ascii number
        Me._ImageFile = ImageFile
        Me._Position = Position

    End Sub

    Public Function getCellType() As String
        Return Me.CellType
    End Function

    Public Function getCount() As Integer
        Return _Count
    End Function
    Public Function getPosition() As Integer
        Return _Position
    End Function
    Public Function getKeyMap() As Integer
        Return _KeyMap
    End Function

    Public Function getKeyMapChar() As String
        Return ChrW(_KeyMap)
    End Function


    Public Sub addToCount()
        _Count = _Count + 1
    End Sub

    Public Sub UndoCount()
        _Count = _Count - 1
    End Sub

    Public Sub ResetCount()
        _Count = 0
    End Sub
    Public Sub changeKeyMap(Key As String)
        _KeyMap = Asc(Key)

    End Sub
    Public Sub changeKeyMap(Key As Integer)
        _KeyMap = Key

    End Sub
    Public Sub changeImage(ImageFile As String)
        Me._ImageFile = ImageFile
    End Sub

    Public Sub ChangeCellType(celltype As String)

        If celltype <> "" Then
            Me._CellType = celltype
        Else
            MessageBox.Show("Cell Type cannot be blank")
            Return
        End If

    End Sub


End Class
