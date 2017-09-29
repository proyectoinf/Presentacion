Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "proyecto" And TextBox2.Text = "acepta" Then
            MsgBox("Login Correcto", MsgBoxStyle.Information)
        Else
            MsgBox("Login Incorrecto", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
