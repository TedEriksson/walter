<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Results
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
        Me.R_Job_status = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'R_Job_status
        '
        Me.R_Job_status.Location = New System.Drawing.Point(12, 12)
        Me.R_Job_status.Name = "R_Job_status"
        Me.R_Job_status.Size = New System.Drawing.Size(75, 23)
        Me.R_Job_status.TabIndex = 0
        Me.R_Job_status.Text = "Job Status"
        Me.R_Job_status.UseVisualStyleBackColor = True
        '
        'Results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 231)
        Me.Controls.Add(Me.R_Job_status)
        Me.Name = "Results"
        Me.Text = "Results"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents R_Job_status As System.Windows.Forms.Button
End Class
