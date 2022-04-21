Public Class Form1
    Dim totalPrice As Double = 0
    Dim p As Double
    Public Function itemPrice(ByVal q As Single) As Double
        If (q = 0) Then
            p = 2.5
        ElseIf (q = 1) Then
            p = 3
        ElseIf (q = 2) Then
            p = 3
        ElseIf (q = 3) Then
            p = 2.5
        ElseIf (q = 4) Then
            p = 3.5
        ElseIf (q = 5) Then
            p = 3
        ElseIf (q = 6) Then
            p = 3.5
        ElseIf (q = 7) Then
            p = 4
        End If
        itemPrice = p
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Add(NumericUpDown1.Value)
        ListBox2.Items.Add(ComboBox1.SelectedItem)
        ListBox3.Items.Add(itemPrice(ComboBox1.SelectedIndex) * NumericUpDown1.Value)
        totalPrice += itemPrice(ComboBox1.SelectedIndex) * NumericUpDown1.Value
        Label5.Text = totalPrice
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        totalPrice = 0
        Label5.Text = totalPrice
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim x As Single = ListBox2.SelectedIndex
        totalPrice -= ListBox3.Items(x)
        ListBox1.Items.RemoveAt(x)
        ListBox2.Items.RemoveAt(x)
        ListBox3.Items.RemoveAt(x)
        Label5.Text = totalPrice
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(itemPrice(0))
    End Sub
End Class
