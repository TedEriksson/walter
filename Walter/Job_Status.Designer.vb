<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Job_Status
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
        Me.JS_Job = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.JS_Income = New System.Windows.Forms.Label()
        Me.JS_Outgoings = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.JS_Total = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Job:"
        '
        'JS_Job
        '
        Me.JS_Job.FormattingEnabled = True
        Me.JS_Job.Location = New System.Drawing.Point(121, 12)
        Me.JS_Job.Name = "JS_Job"
        Me.JS_Job.Size = New System.Drawing.Size(200, 21)
        Me.JS_Job.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Income:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Outgoings:"
        '
        'JS_Income
        '
        Me.JS_Income.AutoSize = True
        Me.JS_Income.Location = New System.Drawing.Point(118, 55)
        Me.JS_Income.Name = "JS_Income"
        Me.JS_Income.Size = New System.Drawing.Size(0, 13)
        Me.JS_Income.TabIndex = 4
        '
        'JS_Outgoings
        '
        Me.JS_Outgoings.AutoSize = True
        Me.JS_Outgoings.Location = New System.Drawing.Point(118, 83)
        Me.JS_Outgoings.Name = "JS_Outgoings"
        Me.JS_Outgoings.Size = New System.Drawing.Size(0, 13)
        Me.JS_Outgoings.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total:"
        '
        'JS_Total
        '
        Me.JS_Total.AutoSize = True
        Me.JS_Total.Location = New System.Drawing.Point(118, 127)
        Me.JS_Total.Name = "JS_Total"
        Me.JS_Total.Size = New System.Drawing.Size(0, 13)
        Me.JS_Total.TabIndex = 7
        '
        'Job_Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 162)
        Me.Controls.Add(Me.JS_Total)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.JS_Outgoings)
        Me.Controls.Add(Me.JS_Income)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.JS_Job)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Job_Status"
        Me.Text = "Job_Status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents JS_Job As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents JS_Income As System.Windows.Forms.Label
    Friend WithEvents JS_Outgoings As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents JS_Total As System.Windows.Forms.Label
End Class
