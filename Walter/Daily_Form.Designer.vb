<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Daily_Form
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
        Me.DF_Task = New System.Windows.Forms.TextBox()
        Me.DF_Hours_worked = New System.Windows.Forms.TextBox()
        Me.NJ_Cancel = New System.Windows.Forms.Button()
        Me.NJ_Done = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DF_Job = New System.Windows.Forms.ComboBox()
        Me.DF_Worker = New System.Windows.Forms.ComboBox()
        Me.DF_Date = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'DF_Task
        '
        Me.DF_Task.Location = New System.Drawing.Point(116, 145)
        Me.DF_Task.Name = "DF_Task"
        Me.DF_Task.Size = New System.Drawing.Size(227, 20)
        Me.DF_Task.TabIndex = 26
        '
        'DF_Hours_worked
        '
        Me.DF_Hours_worked.Location = New System.Drawing.Point(116, 90)
        Me.DF_Hours_worked.Name = "DF_Hours_worked"
        Me.DF_Hours_worked.Size = New System.Drawing.Size(227, 20)
        Me.DF_Hours_worked.TabIndex = 25
        '
        'NJ_Cancel
        '
        Me.NJ_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.NJ_Cancel.Location = New System.Drawing.Point(260, 171)
        Me.NJ_Cancel.Name = "NJ_Cancel"
        Me.NJ_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.NJ_Cancel.TabIndex = 22
        Me.NJ_Cancel.Text = "Cancel"
        Me.NJ_Cancel.UseVisualStyleBackColor = True
        '
        'NJ_Done
        '
        Me.NJ_Done.Location = New System.Drawing.Point(179, 171)
        Me.NJ_Done.Name = "NJ_Done"
        Me.NJ_Done.Size = New System.Drawing.Size(75, 23)
        Me.NJ_Done.TabIndex = 21
        Me.NJ_Done.Text = "Done"
        Me.NJ_Done.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Task:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Hours Worked:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Worker:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Job:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Please Enter the Details For Each Job an Worker:"
        '
        'DF_Job
        '
        Me.DF_Job.FormattingEnabled = True
        Me.DF_Job.Location = New System.Drawing.Point(116, 37)
        Me.DF_Job.Name = "DF_Job"
        Me.DF_Job.Size = New System.Drawing.Size(227, 21)
        Me.DF_Job.TabIndex = 28
        '
        'DF_Worker
        '
        Me.DF_Worker.FormattingEnabled = True
        Me.DF_Worker.Location = New System.Drawing.Point(116, 64)
        Me.DF_Worker.Name = "DF_Worker"
        Me.DF_Worker.Size = New System.Drawing.Size(227, 21)
        Me.DF_Worker.TabIndex = 30
        '
        'DF_Date
        '
        Me.DF_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DF_Date.Location = New System.Drawing.Point(116, 119)
        Me.DF_Date.Name = "DF_Date"
        Me.DF_Date.Size = New System.Drawing.Size(200, 20)
        Me.DF_Date.TabIndex = 31
        '
        'Daily_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.NJ_Cancel
        Me.ClientSize = New System.Drawing.Size(356, 202)
        Me.Controls.Add(Me.DF_Date)
        Me.Controls.Add(Me.DF_Worker)
        Me.Controls.Add(Me.DF_Job)
        Me.Controls.Add(Me.DF_Task)
        Me.Controls.Add(Me.DF_Hours_worked)
        Me.Controls.Add(Me.NJ_Cancel)
        Me.Controls.Add(Me.NJ_Done)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Daily_Form"
        Me.Text = "Daily Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DF_Task As System.Windows.Forms.TextBox
    Friend WithEvents DF_Hours_worked As System.Windows.Forms.TextBox
    Friend WithEvents NJ_Cancel As System.Windows.Forms.Button
    Friend WithEvents NJ_Done As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DF_Job As System.Windows.Forms.ComboBox
    Friend WithEvents DF_Worker As System.Windows.Forms.ComboBox
    Friend WithEvents DF_Date As System.Windows.Forms.DateTimePicker
End Class
