Public Class Form1
    Private Sub BtnShow_Click(sender As Object, e As EventArgs) Handles BtnShow.Click
        Dim MyText As String
        MyText = "Visual Basic 2022"
        MsgBox(Len(MyText))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
