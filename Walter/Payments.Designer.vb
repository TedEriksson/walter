<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payments
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
        Me.P_Date = New System.Windows.Forms.DateTimePicker()
        Me.P_Job = New System.Windows.Forms.ComboBox()
        Me.P_Amount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.P_Cancel = New System.Windows.Forms.Button()
        Me.P_Done = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'P_Date
        '
        Me.P_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.P_Date.Location = New System.Drawing.Point(116, 68)
        Me.P_Date.Name = "P_Date"
        Me.P_Date.Size = New System.Drawing.Size(156, 20)
        Me.P_Date.TabIndex = 39
        '
        'P_Job
        '
        Me.P_Job.FormattingEnabled = True
        Me.P_Job.Location = New System.Drawing.Point(116, 12)
        Me.P_Job.Name = "P_Job"
        Me.P_Job.Size = New System.Drawing.Size(156, 21)
        Me.P_Job.TabIndex = 37
        '
        'P_Amount
        '
        Me.P_Amount.Location = New System.Drawing.Point(116, 39)
        Me.P_Amount.Name = "P_Amount"
        Me.P_Amount.Size = New System.Drawing.Size(156, 20)
        Me.P_Amount.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Job:"
        '
        'P_Cancel
        '
        Me.P_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.P_Cancel.Location = New System.Drawing.Point(197, 94)
        Me.P_Cancel.Name = "P_Cancel"
        Me.P_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.P_Cancel.TabIndex = 41
        Me.P_Cancel.Text = "Cancel"
        Me.P_Cancel.UseVisualStyleBackColor = True
        '
        'P_Done
        '
        Me.P_Done.Location = New System.Drawing.Point(116, 94)
        Me.P_Done.Name = "P_Done"
        Me.P_Done.Size = New System.Drawing.Size(75, 23)
        Me.P_Done.TabIndex = 40
        Me.P_Done.Text = "Done"
        Me.P_Done.UseVisualStyleBackColor = True
        '
        'Payments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.P_Cancel
        Me.ClientSize = New System.Drawing.Size(284, 127)
        Me.Controls.Add(Me.P_Cancel)
        Me.Controls.Add(Me.P_Done)
        Me.Controls.Add(Me.P_Date)
        Me.Controls.Add(Me.P_Job)
        Me.Controls.Add(Me.P_Amount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Payments"
        Me.Text = "Payments"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents P_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents P_Job As System.Windows.Forms.ComboBox
    Friend WithEvents P_Amount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents P_Cancel As System.Windows.Forms.Button
    Friend WithEvents P_Done As System.Windows.Forms.Button
End Class
