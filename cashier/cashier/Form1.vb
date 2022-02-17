Public Class Form1
    Dim totalPrice As Double = 0
    Public Function itemPrice(ByVal itemIndex As Single) As Double
        Dim p As Double
        If (itemIndex = 0) Then
            p = 2.5
        ElseIf (itemIndex = 1) Then
            p = 3
        ElseIf (itemIndex = 2) Then
            p = 3
        ElseIf (itemIndex = 3) Then
            p = 2.5
        ElseIf (itemIndex = 4) Then
            p = 3.5
        ElseIf (itemIndex = 5) Then
            p = 3
        ElseIf (itemIndex = 6) Then
            p = 3.5
        ElseIf (itemIndex = 7) Then
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
        Dim index As Single = ListBox2.SelectedIndex
        totalPrice -= ListBox3.Items(index)
        Label5.Text = totalPrice
        ListBox1.Items.Remove(ListBox1.Items(index))
        ListBox2.Items.Remove(ListBox2.SelectedItem)
        ListBox3.Items.Remove(ListBox3.Items(index))
    End Sub

    'Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
    'TextBox1.Text = ListBox1.SelectedItem
    'End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '   Dim price As Double = itemPrice(ListBox1.SelectedIndex)
    '   totalPrice -= ListBox1.SelectedItem * price
    '   ListBox1.Items(ListBox1.SelectedIndex) = TextBox1.Text
    '   ListBox3.Items(ListBox1.SelectedIndex) = TextBox1.Text * price
    '   totalPrice += TextBox1.Text * price
    '   Label5.Text = totalPrice
    'End Sub
End Class
