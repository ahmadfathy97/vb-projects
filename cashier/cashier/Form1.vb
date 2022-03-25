Public Class Form1
    ' total price starts with 0
    Dim totalPrice As Double = 0

    ' function that return the item price
    Public Function itemPrice(ByVal item As String) As Double
        Dim p As Double
        If (item = "مسقعة") Then
            p = 2.5
        ElseIf (item = "فول") Then
            p = 3
        ElseIf (item = "طعمية") Then
            p = 3
        ElseIf (item = "بطاطس صوابع") Then
            p = 2.5
        ElseIf (item = "بانية") Then
            p = 3.5
        ElseIf (item = "بطاطس شيبسي") Then
            p = 3
        ElseIf (item = "بيض") Then
            p = 3.5
        ElseIf (item = "باذنجان") Then
            p = 4
        End If
        itemPrice = p
    End Function

    ' click event that add:
    ' the item
    ' its price 
    ' and how many sandwich of it to each listbox
    ' and then add the price of these sandwiches to the total price 
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (NumericUpDown1.Value > 0 And ComboBox1.SelectedIndex >= 0) Then
            ListBox1.Items.Add(NumericUpDown1.Value)
            ListBox2.Items.Add(ComboBox1.SelectedItem)
            ListBox3.Items.Add(itemPrice(ComboBox1.SelectedItem) * NumericUpDown1.Value)
            totalPrice += itemPrice(ComboBox1.SelectedItem) * NumericUpDown1.Value
            Label5.Text = totalPrice
        End If

    End Sub

    ' click event that clear all the items in all list boxes, and make the total price equal to 0 
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        totalPrice = 0
        Label5.Text = totalPrice
    End Sub

    ' click event that remove the selected item and subtract its price from the total price 
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim index As Single = ListBox2.SelectedIndex
        If (ListBox2.SelectedIndex >= 0) Then
            totalPrice -= ListBox3.Items(index)
            Label5.Text = totalPrice
            ListBox1.Items.RemoveAt(index)
            ListBox2.Items.RemoveAt(index)
            ListBox3.Items.RemoveAt(index)
        End If

    End Sub
End Class
