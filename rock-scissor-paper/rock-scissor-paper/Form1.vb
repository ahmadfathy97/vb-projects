Public Class Form1
    Dim comp_score As Single = 0
    Dim user_score As Single = 0

    Public Function winner(ByVal comp As Single, ByVal user As Single) As Single
        ' if user choose paper
        If (user = 1) Then
            If (comp = 2) Then
                comp_score += 1
            ElseIf (comp = 3) Then
                user_score += 1
            End If
        End If

        ' if user choose scissor
        If (user = 2) Then
            If (comp = 3) Then
                comp_score += 1
            ElseIf (comp = 1) Then
                user_score += 1
            End If
        End If

        ' if user choose rock
        If (user = 3) Then
            If (comp = 1) Then
                comp_score += 1
            ElseIf (comp = 2) Then
                user_score += 1
            End If
        End If

        comp_score_label.Text = comp_score
        user_score_label.Text = user_score
        winner = 0
    End Function

    Public Function random() As Single
        Dim r = Int(Rnd() * 3) + 1
        If (r = 1) Then
            comp_pic.Image = My.Resources.paper
        End If
        If (r = 2) Then
            comp_pic.Image = My.Resources.scissor
        End If
        If (r = 3) Then
            comp_pic.Image = My.Resources.rock
        End If
        random = r
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scissor_btn.Click
        Dim compChoise = random()
        user_pic.Image = My.Resources.scissor
        winner(compChoise, 2)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        comp_pic.Image = My.Resources.rock
    End Sub

    Private Sub paper_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paper_btn.Click
        Dim compChoise = random()
        user_pic.Image = My.Resources.paper
        winner(compChoise, 1)
    End Sub

    Private Sub rock_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rock_btn.Click
        Dim compChoise = random()
        user_pic.Image = My.Resources.rock
        winner(compChoise, 3)
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class
