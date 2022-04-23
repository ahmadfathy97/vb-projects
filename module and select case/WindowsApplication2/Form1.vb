Public Class Form1



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ColorDialog1.ShowDialog()
        Button2.BackColor = ColorDialog1.Color
        Module1.clr = ColorDialog1.Color
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Module1.test = TextBox1.Text
        Select Case TextBox1.Text
            Case "tech", "techno", "technology"
                Form2.Show()
                Me.Hide()
            Case Else
                MsgBox("try again")
        End Select
    End Sub
End Class
