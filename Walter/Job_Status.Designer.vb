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
        Me.JS_Job = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.JS_T = New System.Windows.Forms.Label()
        Me.JS_O = New System.Windows.Forms.Label()
        Me.JS_I = New System.Windows.Forms.Label()
        Me.JS_Done = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'JS_Job
        '
        Me.JS_Job.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.JS_Job.FormattingEnabled = True
        Me.JS_Job.Location = New System.Drawing.Point(116, 12)
        Me.JS_Job.Name = "JS_Job"
        Me.JS_Job.Size = New System.Drawing.Size(217, 21)
        Me.JS_Job.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Job:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Income:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Outgoings:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Total:"
        '
        'JS_T
        '
        Me.JS_T.AutoSize = True
        Me.JS_T.Location = New System.Drawing.Point(113, 119)
        Me.JS_T.Name = "JS_T"
        Me.JS_T.Size = New System.Drawing.Size(0, 13)
        Me.JS_T.TabIndex = 36
        '
        'JS_O
        '
        Me.JS_O.AutoSize = True
        Me.JS_O.Location = New System.Drawing.Point(113, 90)
        Me.JS_O.Name = "JS_O"
        Me.JS_O.Size = New System.Drawing.Size(0, 13)
        Me.JS_O.TabIndex = 35
        '
        'JS_I
        '
        Me.JS_I.AutoSize = True
        Me.JS_I.Location = New System.Drawing.Point(113, 57)
        Me.JS_I.Name = "JS_I"
        Me.JS_I.Size = New System.Drawing.Size(0, 13)
        Me.JS_I.TabIndex = 34
        '
        'JS_Done
        '
        Me.JS_Done.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.JS_Done.Location = New System.Drawing.Point(258, 165)
        Me.JS_Done.Name = "JS_Done"
        Me.JS_Done.Size = New System.Drawing.Size(75, 23)
        Me.JS_Done.TabIndex = 37
        Me.JS_Done.Text = "Done"
        Me.JS_Done.UseVisualStyleBackColor = True
        '
        'Job_Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.JS_Done
        Me.ClientSize = New System.Drawing.Size(345, 200)
        Me.Controls.Add(Me.JS_Done)
        Me.Controls.Add(Me.JS_T)
        Me.Controls.Add(Me.JS_O)
        Me.Controls.Add(Me.JS_I)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.JS_Job)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Job_Status"
        Me.Text = "Job Status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JS_Job As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents JS_T As System.Windows.Forms.Label
    Friend WithEvents JS_O As System.Windows.Forms.Label
    Friend WithEvents JS_I As System.Windows.Forms.Label
    Friend WithEvents JS_Done As System.Windows.Forms.Button
End Class
