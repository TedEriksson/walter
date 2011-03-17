<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoices
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
        Me.I_Type = New System.Windows.Forms.ComboBox()
        Me.I_N = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'I_Type
        '
        Me.I_Type.FormattingEnabled = True
        Me.I_Type.Items.AddRange(New Object() {"Job", "Customer", "Worker", "Supplier"})
        Me.I_Type.Location = New System.Drawing.Point(12, 25)
        Me.I_Type.Name = "I_Type"
        Me.I_Type.Size = New System.Drawing.Size(121, 21)
        Me.I_Type.TabIndex = 0
        Me.I_Type.Text = "Select Type"
        '
        'I_N
        '
        Me.I_N.FormattingEnabled = True
        Me.I_N.Location = New System.Drawing.Point(140, 24)
        Me.I_N.Name = "I_N"
        Me.I_N.Size = New System.Drawing.Size(196, 21)
        Me.I_N.TabIndex = 1
        Me.I_N.Text = "Then Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pick an Invoice option:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(342, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Invoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 55)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.I_N)
        Me.Controls.Add(Me.I_Type)
        Me.Name = "Invoices"
        Me.Text = "Invoices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents I_Type As System.Windows.Forms.ComboBox
    Friend WithEvents I_N As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
