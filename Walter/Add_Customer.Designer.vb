<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Customer
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
        Me.AC_Postcode = New System.Windows.Forms.TextBox()
        Me.AC_Address2 = New System.Windows.Forms.TextBox()
        Me.AC_Address1 = New System.Windows.Forms.TextBox()
        Me.AC_Customer_name = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NJ_Cancel = New System.Windows.Forms.Button()
        Me.NJ_Done = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AC_Postcode
        '
        Me.AC_Postcode.Location = New System.Drawing.Point(116, 84)
        Me.AC_Postcode.Name = "AC_Postcode"
        Me.AC_Postcode.Size = New System.Drawing.Size(156, 20)
        Me.AC_Postcode.TabIndex = 60
        '
        'AC_Address2
        '
        Me.AC_Address2.Location = New System.Drawing.Point(116, 58)
        Me.AC_Address2.Name = "AC_Address2"
        Me.AC_Address2.Size = New System.Drawing.Size(156, 20)
        Me.AC_Address2.TabIndex = 59
        '
        'AC_Address1
        '
        Me.AC_Address1.Location = New System.Drawing.Point(116, 32)
        Me.AC_Address1.Name = "AC_Address1"
        Me.AC_Address1.Size = New System.Drawing.Size(156, 20)
        Me.AC_Address1.TabIndex = 58
        '
        'AC_Customer_name
        '
        Me.AC_Customer_name.Location = New System.Drawing.Point(116, 6)
        Me.AC_Customer_name.Name = "AC_Customer_name"
        Me.AC_Customer_name.Size = New System.Drawing.Size(156, 20)
        Me.AC_Customer_name.TabIndex = 57
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Postcode:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Address:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 13)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Customer Name:"
        '
        'NJ_Cancel
        '
        Me.NJ_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NJ_Cancel.Location = New System.Drawing.Point(197, 111)
        Me.NJ_Cancel.Name = "NJ_Cancel"
        Me.NJ_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.NJ_Cancel.TabIndex = 62
        Me.NJ_Cancel.Text = "Cancel"
        Me.NJ_Cancel.UseVisualStyleBackColor = True
        '
        'NJ_Done
        '
        Me.NJ_Done.Location = New System.Drawing.Point(116, 111)
        Me.NJ_Done.Name = "NJ_Done"
        Me.NJ_Done.Size = New System.Drawing.Size(75, 23)
        Me.NJ_Done.TabIndex = 61
        Me.NJ_Done.Text = "Done"
        Me.NJ_Done.UseVisualStyleBackColor = True
        '
        'Add_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.NJ_Cancel
        Me.ClientSize = New System.Drawing.Size(284, 146)
        Me.Controls.Add(Me.NJ_Cancel)
        Me.Controls.Add(Me.NJ_Done)
        Me.Controls.Add(Me.AC_Postcode)
        Me.Controls.Add(Me.AC_Address2)
        Me.Controls.Add(Me.AC_Address1)
        Me.Controls.Add(Me.AC_Customer_name)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Name = "Add_Customer"
        Me.Text = "Add_Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AC_Postcode As System.Windows.Forms.TextBox
    Friend WithEvents AC_Address2 As System.Windows.Forms.TextBox
    Friend WithEvents AC_Address1 As System.Windows.Forms.TextBox
    Friend WithEvents AC_Customer_name As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents NJ_Cancel As System.Windows.Forms.Button
    Friend WithEvents NJ_Done As System.Windows.Forms.Button
End Class
