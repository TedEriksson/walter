<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Material_invoice
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
        Me.ADM_Supplier_Name = New System.Windows.Forms.ComboBox()
        Me.ADM_Hours_worked = New System.Windows.Forms.TextBox()
        Me.ADM_Cost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ADM_Cancel = New System.Windows.Forms.Button()
        Me.AMI_Done = New System.Windows.Forms.Button()
        Me.AMI_Save_and_new = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ADM_Supplier_Name
        '
        Me.ADM_Supplier_Name.FormattingEnabled = True
        Me.ADM_Supplier_Name.Location = New System.Drawing.Point(116, 37)
        Me.ADM_Supplier_Name.Name = "ADM_Supplier_Name"
        Me.ADM_Supplier_Name.Size = New System.Drawing.Size(156, 21)
        Me.ADM_Supplier_Name.TabIndex = 35
        '
        'ADM_Hours_worked
        '
        Me.ADM_Hours_worked.Location = New System.Drawing.Point(116, 90)
        Me.ADM_Hours_worked.Name = "ADM_Hours_worked"
        Me.ADM_Hours_worked.Size = New System.Drawing.Size(156, 20)
        Me.ADM_Hours_worked.TabIndex = 34
        '
        'ADM_Cost
        '
        Me.ADM_Cost.Location = New System.Drawing.Point(116, 64)
        Me.ADM_Cost.Name = "ADM_Cost"
        Me.ADM_Cost.Size = New System.Drawing.Size(156, 20)
        Me.ADM_Cost.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Hours Worked:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Cost:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Supplier Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Please Enter the Details For Each Job and Worker:"
        '
        'ADM_Cancel
        '
        Me.ADM_Cancel.Location = New System.Drawing.Point(197, 116)
        Me.ADM_Cancel.Name = "ADM_Cancel"
        Me.ADM_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.ADM_Cancel.TabIndex = 36
        Me.ADM_Cancel.Text = "Cancel"
        Me.ADM_Cancel.UseVisualStyleBackColor = True
        '
        'AMI_Done
        '
        Me.AMI_Done.Location = New System.Drawing.Point(116, 116)
        Me.AMI_Done.Name = "AMI_Done"
        Me.AMI_Done.Size = New System.Drawing.Size(75, 23)
        Me.AMI_Done.TabIndex = 37
        Me.AMI_Done.Text = "Done"
        Me.AMI_Done.UseVisualStyleBackColor = True
        '
        'AMI_Save_and_new
        '
        Me.AMI_Save_and_new.Location = New System.Drawing.Point(15, 116)
        Me.AMI_Save_and_new.Name = "AMI_Save_and_new"
        Me.AMI_Save_and_new.Size = New System.Drawing.Size(95, 23)
        Me.AMI_Save_and_new.TabIndex = 38
        Me.AMI_Save_and_new.Text = "Save and New"
        Me.AMI_Save_and_new.UseVisualStyleBackColor = True
        '
        'Add_Material_invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 151)
        Me.Controls.Add(Me.AMI_Save_and_new)
        Me.Controls.Add(Me.AMI_Done)
        Me.Controls.Add(Me.ADM_Cancel)
        Me.Controls.Add(Me.ADM_Supplier_Name)
        Me.Controls.Add(Me.ADM_Hours_worked)
        Me.Controls.Add(Me.ADM_Cost)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Add_Material_invoice"
        Me.Text = "Add Material Invoice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ADM_Supplier_Name As System.Windows.Forms.ComboBox
    Friend WithEvents ADM_Hours_worked As System.Windows.Forms.TextBox
    Friend WithEvents ADM_Cost As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ADM_Cancel As System.Windows.Forms.Button
    Friend WithEvents AMI_Done As System.Windows.Forms.Button
    Friend WithEvents AMI_Save_and_new As System.Windows.Forms.Button
End Class
