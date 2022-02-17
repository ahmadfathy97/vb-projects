Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SaveFileDialogue1.ShowDialog()
        My.Computer.FileSystem.WriteAllText(SaveFileDialogue1.FileName, RichTextBox1.Text, False)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim startTxt As Single = 0
        Dim endTxt As Single = RichTextBox1.Text.LastIndexOf(TextBox1.Text)

        While startTxt < endTxt
            RichTextBox1.Find(TextBox1.Text, startTxt, RichTextBox1.TextLength, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectionBackColor = Color.SeaGreen
            startTxt += 1
        End While
    End Sub
End Class
