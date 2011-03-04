<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Supplier
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
        Me.AS_Cancel = New System.Windows.Forms.Button()
        Me.AS_Done = New System.Windows.Forms.Button()
        Me.AS_Postcode = New System.Windows.Forms.TextBox()
        Me.AS_Address2 = New System.Windows.Forms.TextBox()
        Me.AS_Address1 = New System.Windows.Forms.TextBox()
        Me.AS_Supplier_name = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AS_Cancel
        '
        Me.AS_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.AS_Cancel.Location = New System.Drawing.Point(197, 111)
        Me.AS_Cancel.Name = "AS_Cancel"
        Me.AS_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.AS_Cancel.TabIndex = 71
        Me.AS_Cancel.Text = "Cancel"
        Me.AS_Cancel.UseVisualStyleBackColor = True
        '
        'AS_Done
        '
        Me.AS_Done.Location = New System.Drawing.Point(116, 111)
        Me.AS_Done.Name = "AS_Done"
        Me.AS_Done.Size = New System.Drawing.Size(75, 23)
        Me.AS_Done.TabIndex = 70
        Me.AS_Done.Text = "Done"
        Me.AS_Done.UseVisualStyleBackColor = True
        '
        'AS_Postcode
        '
        Me.AS_Postcode.Location = New System.Drawing.Point(116, 84)
        Me.AS_Postcode.Name = "AS_Postcode"
        Me.AS_Postcode.Size = New System.Drawing.Size(156, 20)
        Me.AS_Postcode.TabIndex = 69
        '
        'AS_Address2
        '
        Me.AS_Address2.Location = New System.Drawing.Point(116, 58)
        Me.AS_Address2.Name = "AS_Address2"
        Me.AS_Address2.Size = New System.Drawing.Size(156, 20)
        Me.AS_Address2.TabIndex = 68
        '
        'AS_Address1
        '
        Me.AS_Address1.Location = New System.Drawing.Point(116, 32)
        Me.AS_Address1.Name = "AS_Address1"
        Me.AS_Address1.Size = New System.Drawing.Size(156, 20)
        Me.AS_Address1.TabIndex = 67
        '
        'AS_Supplier_name
        '
        Me.AS_Supplier_name.Location = New System.Drawing.Point(116, 6)
        Me.AS_Supplier_name.Name = "AS_Supplier_name"
        Me.AS_Supplier_name.Size = New System.Drawing.Size(156, 20)
        Me.AS_Supplier_name.TabIndex = 66
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "Postcode:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Address:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 13)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "Supplier Name:"
        '
        'Add_Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 142)
        Me.Controls.Add(Me.AS_Cancel)
        Me.Controls.Add(Me.AS_Done)
        Me.Controls.Add(Me.AS_Postcode)
        Me.Controls.Add(Me.AS_Address2)
        Me.Controls.Add(Me.AS_Address1)
        Me.Controls.Add(Me.AS_Supplier_name)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Name = "Add_Supplier"
        Me.Text = "Add_Supplier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AS_Cancel As System.Windows.Forms.Button
    Friend WithEvents AS_Done As System.Windows.Forms.Button
    Friend WithEvents AS_Postcode As System.Windows.Forms.TextBox
    Friend WithEvents AS_Address2 As System.Windows.Forms.TextBox
    Friend WithEvents AS_Address1 As System.Windows.Forms.TextBox
    Friend WithEvents AS_Supplier_name As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
