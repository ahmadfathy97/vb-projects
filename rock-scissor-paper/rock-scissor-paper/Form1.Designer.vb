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
        Me.user_pic = New System.Windows.Forms.PictureBox()
        Me.comp_pic = New System.Windows.Forms.PictureBox()
        Me.paper_btn = New System.Windows.Forms.Button()
        Me.scissor_btn = New System.Windows.Forms.Button()
        Me.rock_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comp_score_label = New System.Windows.Forms.Label()
        Me.user_score_label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.user_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comp_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'user_pic
        '
        Me.user_pic.Image = Global.rock_scissor_paper.My.Resources.Resources.paper
        Me.user_pic.Location = New System.Drawing.Point(340, 93)
        Me.user_pic.Name = "user_pic"
        Me.user_pic.Size = New System.Drawing.Size(176, 191)
        Me.user_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.user_pic.TabIndex = 0
        Me.user_pic.TabStop = False
        '
        'comp_pic
        '
        Me.comp_pic.Image = Global.rock_scissor_paper.My.Resources.Resources.paper
        Me.comp_pic.Location = New System.Drawing.Point(85, 93)
        Me.comp_pic.Name = "comp_pic"
        Me.comp_pic.Size = New System.Drawing.Size(176, 191)
        Me.comp_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.comp_pic.TabIndex = 1
        Me.comp_pic.TabStop = False
        '
        'paper_btn
        '
        Me.paper_btn.Location = New System.Drawing.Point(77, 335)
        Me.paper_btn.Name = "paper_btn"
        Me.paper_btn.Size = New System.Drawing.Size(108, 40)
        Me.paper_btn.TabIndex = 2
        Me.paper_btn.Text = "paper"
        Me.paper_btn.UseVisualStyleBackColor = True
        '
        'scissor_btn
        '
        Me.scissor_btn.Location = New System.Drawing.Point(244, 335)
        Me.scissor_btn.Name = "scissor_btn"
        Me.scissor_btn.Size = New System.Drawing.Size(108, 40)
        Me.scissor_btn.TabIndex = 3
        Me.scissor_btn.Text = "scissor"
        Me.scissor_btn.UseVisualStyleBackColor = True
        '
        'rock_btn
        '
        Me.rock_btn.Location = New System.Drawing.Point(416, 335)
        Me.rock_btn.Name = "rock_btn"
        Me.rock_btn.Size = New System.Drawing.Size(108, 40)
        Me.rock_btn.TabIndex = 4
        Me.rock_btn.Text = "rock"
        Me.rock_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 409)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Comp Score"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(402, 409)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "My Score"
        '
        'comp_score_label
        '
        Me.comp_score_label.AutoSize = True
        Me.comp_score_label.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comp_score_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.comp_score_label.Location = New System.Drawing.Point(126, 451)
        Me.comp_score_label.Name = "comp_score_label"
        Me.comp_score_label.Size = New System.Drawing.Size(0, 34)
        Me.comp_score_label.TabIndex = 7
        '
        'user_score_label
        '
        Me.user_score_label.AutoSize = True
        Me.user_score_label.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_score_label.ForeColor = System.Drawing.Color.Green
        Me.user_score_label.Location = New System.Drawing.Point(450, 451)
        Me.user_score_label.Name = "user_score_label"
        Me.user_score_label.Size = New System.Drawing.Size(0, 34)
        Me.user_score_label.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "computer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(411, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Me"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 528)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.user_score_label)
        Me.Controls.Add(Me.comp_score_label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rock_btn)
        Me.Controls.Add(Me.scissor_btn)
        Me.Controls.Add(Me.paper_btn)
        Me.Controls.Add(Me.comp_pic)
        Me.Controls.Add(Me.user_pic)
        Me.Name = "Form1"
        Me.Text = "Rock Scissor Paper"
        CType(Me.user_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comp_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents user_pic As System.Windows.Forms.PictureBox
    Friend WithEvents comp_pic As System.Windows.Forms.PictureBox
    Friend WithEvents paper_btn As System.Windows.Forms.Button
    Friend WithEvents scissor_btn As System.Windows.Forms.Button
    Friend WithEvents rock_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comp_score_label As System.Windows.Forms.Label
    Friend WithEvents user_score_label As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
