Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        OpenFileDialog1.FileName = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog2.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog2.FileName
        OpenFileDialog2.FileName = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastReverse()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        AxWindowsMediaPlayer1.Ctlcontrols.fastForward()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxWindowsMediaPlayer1.Ctlcontrols.previous()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxWindowsMediaPlayer1.Ctlcontrols.next()
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(AxWindowsMediaPlayer1.Ctlcontrols.currentPosition / AxWindowsMediaPlayer1.Ctlcontrols.currentItem.duration)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (AxWindowsMediaPlayer1.URL <> "") Then
            Dim d As Single = AxWindowsMediaPlayer1.currentMedia.duration
            Dim cp As Single = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
            Dim percentage As Single = cp / d * 100
            If (percentage > 0) Then
                ProgressBar1.Value = percentage
            End If
        End If
    End Sub
End Class
