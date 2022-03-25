Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (TextBox1.Text = "test" And TextBox2.Text = "12345") Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("wrong email or password!")
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class
