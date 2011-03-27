<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Worker
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
        Me.AW_Postcode = New System.Windows.Forms.TextBox()
        Me.AW_Address2 = New System.Windows.Forms.TextBox()
        Me.AW_Address1 = New System.Windows.Forms.TextBox()
        Me.AW_Worker_name = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AW_HR = New System.Windows.Forms.TextBox()
        Me.AW_Cancel = New System.Windows.Forms.Button()
        Me.AW_Done = New System.Windows.Forms.Button()
        Me.AW_WN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'AW_Postcode
        '
        Me.AW_Postcode.Location = New System.Drawing.Point(116, 84)
        Me.AW_Postcode.Name = "AW_Postcode"
        Me.AW_Postcode.Size = New System.Drawing.Size(156, 20)
        Me.AW_Postcode.TabIndex = 67
        '
        'AW_Address2
        '
        Me.AW_Address2.Location = New System.Drawing.Point(116, 58)
        Me.AW_Address2.Name = "AW_Address2"
        Me.AW_Address2.Size = New System.Drawing.Size(156, 20)
        Me.AW_Address2.TabIndex = 66
        '
        'AW_Address1
        '
        Me.AW_Address1.Location = New System.Drawing.Point(116, 32)
        Me.AW_Address1.Name = "AW_Address1"
        Me.AW_Address1.Size = New System.Drawing.Size(156, 20)
        Me.AW_Address1.TabIndex = 65
        '
        'AW_Worker_name
        '
        Me.AW_Worker_name.Location = New System.Drawing.Point(116, 6)
        Me.AW_Worker_name.Name = "AW_Worker_name"
        Me.AW_Worker_name.Size = New System.Drawing.Size(156, 20)
        Me.AW_Worker_name.TabIndex = 64
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Postcode:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Address:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Worker Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Hourly Rate:"
        '
        'AW_HR
        '
        Me.AW_HR.Location = New System.Drawing.Point(116, 110)
        Me.AW_HR.Name = "AW_HR"
        Me.AW_HR.Size = New System.Drawing.Size(156, 20)
        Me.AW_HR.TabIndex = 69
        '
        'AW_Cancel
        '
        Me.AW_Cancel.Location = New System.Drawing.Point(197, 136)
        Me.AW_Cancel.Name = "AW_Cancel"
        Me.AW_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.AW_Cancel.TabIndex = 70
        Me.AW_Cancel.Text = "Cancel"
        Me.AW_Cancel.UseVisualStyleBackColor = True
        '
        'AW_Done
        '
        Me.AW_Done.Location = New System.Drawing.Point(116, 136)
        Me.AW_Done.Name = "AW_Done"
        Me.AW_Done.Size = New System.Drawing.Size(75, 23)
        Me.AW_Done.TabIndex = 71
        Me.AW_Done.Text = "Done"
        Me.AW_Done.UseVisualStyleBackColor = True
        '
        'AW_WN
        '
        Me.AW_WN.Location = New System.Drawing.Point(116, 6)
        Me.AW_WN.Name = "AW_WN"
        Me.AW_WN.Size = New System.Drawing.Size(156, 20)
        Me.AW_WN.TabIndex = 64
        '
        'Add_Worker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 174)
        Me.Controls.Add(Me.AW_Done)
        Me.Controls.Add(Me.AW_Cancel)
        Me.Controls.Add(Me.AW_HR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AW_Postcode)
        Me.Controls.Add(Me.AW_Address2)
        Me.Controls.Add(Me.AW_Address1)
        Me.Controls.Add(Me.AW_Worker_name)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Name = "Add_Worker"
        Me.Text = "Add_Worker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AW_Postcode As System.Windows.Forms.TextBox
    Friend WithEvents AW_Address2 As System.Windows.Forms.TextBox
    Friend WithEvents AW_Address1 As System.Windows.Forms.TextBox
    Friend WithEvents AW_Worker_name As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AW_HR As System.Windows.Forms.TextBox
    Friend WithEvents AW_Cancel As System.Windows.Forms.Button
    Friend WithEvents AW_Done As System.Windows.Forms.Button
    Friend WithEvents AW_WN As System.Windows.Forms.TextBox
End Class
