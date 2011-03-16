<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.WalterStart = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.L_P = New System.Windows.Forms.TextBox()
        Me.Quit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WalterStart
        '
        Me.WalterStart.Location = New System.Drawing.Point(112, 38)
        Me.WalterStart.Name = "WalterStart"
        Me.WalterStart.Size = New System.Drawing.Size(75, 23)
        Me.WalterStart.TabIndex = 0
        Me.WalterStart.Text = "Start Walter"
        Me.WalterStart.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'L_P
        '
        Me.L_P.Location = New System.Drawing.Point(87, 12)
        Me.L_P.Name = "L_P"
        Me.L_P.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.L_P.Size = New System.Drawing.Size(100, 20)
        Me.L_P.TabIndex = 4
        Me.L_P.Text = "Admin"
        '
        'Quit
        '
        Me.Quit.Location = New System.Drawing.Point(14, 38)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(75, 23)
        Me.Quit.TabIndex = 5
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(202, 71)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.L_P)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WalterStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WalterStart As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents L_P As System.Windows.Forms.TextBox
    Friend WithEvents Quit As System.Windows.Forms.Button
End Class
