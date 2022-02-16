Public Class Form1
    Dim degree As Single = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles q1_num1.Click

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim r As New Random
        Dim q1_n1 As Single = r.Next(0, 100)
        Dim q1_n2 As Single = r.Next(0, 100)
        Dim q2_n1 As Single = r.Next(0, 100)
        Dim q2_n2 As Single = r.Next(0, 100)
        Dim q3_n1 As Single = r.Next(0, 100)
        Dim q3_n2 As Single = r.Next(0, 100)
        Dim q4_n1 As Single = r.Next(0, 100)
        Dim q4_n2 As Single = r.Next(0, 100)
        Dim q5_n1 As Single = r.Next(0, 100)
        Dim q5_n2 As Single = r.Next(0, 100)
        q1_num1.Text = q1_n1
        q1_num2.Text = q1_n2
        q2_num1.Text = q2_n1
        q2_num2.Text = q2_n2
        q3_num1.Text = q3_n1
        q3_num2.Text = q3_n2
        q4_num1.Text = q4_n1
        q4_num2.Text = q4_n2
        q5_num1.Text = q5_n1
        q5_num2.Text = q5_n2
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If (NumericUpDown1.Text.Length = 0 Or NumericUpDown2.Text.Length = 0 Or NumericUpDown3.Text.Length = 0 Or NumericUpDown4.Text.Length = 0 Or NumericUpDown5.Text.Length = 0) Then
        'MsgBox("You must solve all problems")
        'Else
        If (Int(q1_num1.Text) + Int(q1_num2.Text) = NumericUpDown1.Value) Then
            degree = degree + 1
        End If
        If (Int(q2_num1.Text) + Int(q2_num2.Text) = NumericUpDown2.Value) Then
            degree = degree + 1
        End If
        If (Int(q3_num1.Text) + Int(q3_num2.Text) = NumericUpDown3.Value) Then
            degree = degree + 1
        End If
        If (Int(q4_num1.Text) + Int(q4_num2.Text) = NumericUpDown4.Value) Then
            degree = degree + 1
        End If
        If (Int(q5_num1.Text) + Int(q5_num2.Text) = NumericUpDown5.Value) Then
            degree = degree + 1
        End If
        If (degree >= 3) Then
            Label6.ForeColor = Color.Green
        Else
            Label6.ForeColor = Color.Red
        End If
        Label6.Text = degree & " / 5"
        degree = 0
        'End If
    End Sub

    Private Sub MessageBox(ByVal p1 As Object)
        Throw New NotImplementedException
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub
End Class