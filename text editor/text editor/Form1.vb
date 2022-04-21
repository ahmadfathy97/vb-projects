Public Class Form1

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim startTxt As Single = 0
        Dim endTxt As Single = RichTextBox1.Text.LastIndexOf(TextBox1.Text)

        While startTxt < endTxt
            RichTextBox1.Find("", startTxt, RichTextBox1.TextLength, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectionBackColor = Color.Transparent
            startTxt += 1
        End While
        startTxt = 0
        While startTxt < endTxt
            RichTextBox1.Find(TextBox1.Text, startTxt, RichTextBox1.TextLength, RichTextBoxFinds.MatchCase)
            RichTextBox1.SelectionBackColor = Color.SeaGreen
            startTxt += 1
        End While
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        If (OpenFileDialog1.FileName <> "") Then
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialogue1.ShowDialog()
        If (SaveFileDialogue1.FileName <> "") Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialogue1.FileName, RichTextBox1.Text, False)
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub

End Class
