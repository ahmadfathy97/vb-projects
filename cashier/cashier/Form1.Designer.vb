<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"فول", "طعمية", "بطاطس صوابع", "بانية", "بطاطس شيبسي", "بيض", "باذنجان", "مسقعة"})
        Me.ComboBox1.Location = New System.Drawing.Point(358, 212)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox1.Size = New System.Drawing.Size(331, 36)
        Me.ComboBox1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(622, 306)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox1.Size = New System.Drawing.Size(67, 228)
        Me.ListBox1.TabIndex = 3
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.NumericUpDown1.Location = New System.Drawing.Point(237, 213)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumericUpDown1.Size = New System.Drawing.Size(115, 36)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(43, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 36)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "اضافة"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(43, 306)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(165, 38)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "حذف"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(43, 350)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(165, 38)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "حذف الكل"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arabic Typesetting", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(190, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 93)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "مطعم عباد الرحمن"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(358, 306)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox2.Size = New System.Drawing.Size(258, 228)
        Me.ListBox2.TabIndex = 10
        '
        'ListBox3
        '
        Me.ListBox3.Enabled = False
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 16
        Me.ListBox3.Location = New System.Drawing.Point(236, 306)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox3.Size = New System.Drawing.Size(116, 228)
        Me.ListBox3.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(623, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "الكمية"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(547, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "الصنف"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(287, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "السعر"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Label5.Location = New System.Drawing.Point(110, 441)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(26, 29)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "0"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(731, 598)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
