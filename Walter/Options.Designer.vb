<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.O_P1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.O_P2 = New System.Windows.Forms.TextBox()
        Me.O_Set = New System.Windows.Forms.Button()
        Me.O_Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password Reset:"
        '
        'O_P1
        '
        Me.O_P1.Location = New System.Drawing.Point(158, 30)
        Me.O_P1.Name = "O_P1"
        Me.O_P1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.O_P1.Size = New System.Drawing.Size(139, 20)
        Me.O_P1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Confirm New Password:"
        '
        'O_P2
        '
        Me.O_P2.Location = New System.Drawing.Point(158, 56)
        Me.O_P2.Name = "O_P2"
        Me.O_P2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.O_P2.Size = New System.Drawing.Size(139, 20)
        Me.O_P2.TabIndex = 4
        '
        'O_Set
        '
        Me.O_Set.Location = New System.Drawing.Point(141, 82)
        Me.O_Set.Name = "O_Set"
        Me.O_Set.Size = New System.Drawing.Size(75, 23)
        Me.O_Set.TabIndex = 5
        Me.O_Set.Text = "Set"
        Me.O_Set.UseVisualStyleBackColor = True
        '
        'O_Back
        '
        Me.O_Back.Location = New System.Drawing.Point(222, 82)
        Me.O_Back.Name = "O_Back"
        Me.O_Back.Size = New System.Drawing.Size(75, 23)
        Me.O_Back.TabIndex = 6
        Me.O_Back.Text = "Back"
        Me.O_Back.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 114)
        Me.Controls.Add(Me.O_Back)
        Me.Controls.Add(Me.O_Set)
        Me.Controls.Add(Me.O_P2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.O_P1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Options"
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents O_P1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents O_P2 As System.Windows.Forms.TextBox
    Friend WithEvents O_Set As System.Windows.Forms.Button
    Friend WithEvents O_Back As System.Windows.Forms.Button
End Class
