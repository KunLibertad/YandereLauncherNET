Public Class frmDebugView
    Public Sub AddTextToTheLog(text As String)
        TextBox1.AppendText($"{text}{vbCrLf}")
    End Sub
End Class