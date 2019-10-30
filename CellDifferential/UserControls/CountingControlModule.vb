Public Class CountingControlModule

    Private _countingObject As CountingObject
    Public Sub New(countingObject As CountingObject)

        Me._countingObject = countingObject

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub SetState()

        TxtTotal.Text = _countingObject.Total.ToString()

    End Sub


End Class
