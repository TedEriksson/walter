<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewJob
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NJ_Done = New System.Windows.Forms.Button()
        Me.NJ_Cancel = New System.Windows.Forms.Button()
        Me.NW_JobName = New System.Windows.Forms.TextBox()
        Me.NJ_InitialBudget = New System.Windows.Forms.TextBox()
        Me.NJ_Postcode = New System.Windows.Forms.TextBox()
        Me.NJ_Address1 = New System.Windows.Forms.TextBox()
        Me.NJ_Address2 = New System.Windows.Forms.TextBox()
        Me.NJ_Customer = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Enter the Details of The New Job:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Job Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Initial Budget:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Postcode:"
        '
        'NJ_Done
        '
        Me.NJ_Done.Location = New System.Drawing.Point(116, 197)
        Me.NJ_Done.Name = "NJ_Done"
        Me.NJ_Done.Size = New System.Drawing.Size(75, 23)
        Me.NJ_Done.TabIndex = 14
        Me.NJ_Done.Text = "Done"
        Me.NJ_Done.UseVisualStyleBackColor = True
        '
        'NJ_Cancel
        '
        Me.NJ_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NJ_Cancel.Location = New System.Drawing.Point(197, 197)
        Me.NJ_Cancel.Name = "NJ_Cancel"
        Me.NJ_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.NJ_Cancel.TabIndex = 15
        Me.NJ_Cancel.Text = "Cancel"
        Me.NJ_Cancel.UseVisualStyleBackColor = True
        '
        'NW_JobName
        '
        Me.NW_JobName.Location = New System.Drawing.Point(116, 39)
        Me.NW_JobName.Name = "NW_JobName"
        Me.NW_JobName.Size = New System.Drawing.Size(156, 20)
        Me.NW_JobName.TabIndex = 8
        '
        'NJ_InitialBudget
        '
        Me.NJ_InitialBudget.Location = New System.Drawing.Point(116, 90)
        Me.NJ_InitialBudget.Name = "NJ_InitialBudget"
        Me.NJ_InitialBudget.Size = New System.Drawing.Size(156, 20)
        Me.NJ_InitialBudget.TabIndex = 10
        '
        'NJ_Postcode
        '
        Me.NJ_Postcode.Location = New System.Drawing.Point(116, 171)
        Me.NJ_Postcode.Name = "NJ_Postcode"
        Me.NJ_Postcode.Size = New System.Drawing.Size(156, 20)
        Me.NJ_Postcode.TabIndex = 13
        '
        'NJ_Address1
        '
        Me.NJ_Address1.Location = New System.Drawing.Point(116, 119)
        Me.NJ_Address1.Name = "NJ_Address1"
        Me.NJ_Address1.Size = New System.Drawing.Size(156, 20)
        Me.NJ_Address1.TabIndex = 11
        '
        'NJ_Address2
        '
        Me.NJ_Address2.Location = New System.Drawing.Point(116, 145)
        Me.NJ_Address2.Name = "NJ_Address2"
        Me.NJ_Address2.Size = New System.Drawing.Size(156, 20)
        Me.NJ_Address2.TabIndex = 12
        '
        'NJ_Customer
        '
        Me.NJ_Customer.FormattingEnabled = True
        Me.NJ_Customer.Location = New System.Drawing.Point(116, 64)
        Me.NJ_Customer.Name = "NJ_Customer"
        Me.NJ_Customer.Size = New System.Drawing.Size(156, 21)
        Me.NJ_Customer.TabIndex = 9
        '
        'NewJob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.NJ_Cancel
        Me.ClientSize = New System.Drawing.Size(284, 232)
        Me.Controls.Add(Me.NJ_Customer)
        Me.Controls.Add(Me.NJ_Address2)
        Me.Controls.Add(Me.NJ_Address1)
        Me.Controls.Add(Me.NJ_Postcode)
        Me.Controls.Add(Me.NJ_InitialBudget)
        Me.Controls.Add(Me.NW_JobName)
        Me.Controls.Add(Me.NJ_Cancel)
        Me.Controls.Add(Me.NJ_Done)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "NewJob"
        Me.Text = "New Job"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NJ_Done As System.Windows.Forms.Button
    Friend WithEvents NJ_Cancel As System.Windows.Forms.Button
    Friend WithEvents NW_JobName As System.Windows.Forms.TextBox
    Friend WithEvents NJ_InitialBudget As System.Windows.Forms.TextBox
    Friend WithEvents NJ_Postcode As System.Windows.Forms.TextBox
    Friend WithEvents NJ_Address1 As System.Windows.Forms.TextBox
    Friend WithEvents NJ_Address2 As System.Windows.Forms.TextBox
    Friend WithEvents NJ_Customer As System.Windows.Forms.ComboBox
End Class
