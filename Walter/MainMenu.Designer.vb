<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.M_NewJob = New System.Windows.Forms.Button()
        Me.M_Results = New System.Windows.Forms.Button()
        Me.M_EditDetails = New System.Windows.Forms.Button()
        Me.M_Quit = New System.Windows.Forms.Button()
        Me.Worker_hours = New System.Windows.Forms.Button()
        Me.Material_invoice = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Payments_button = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'M_NewJob
        '
        Me.M_NewJob.Location = New System.Drawing.Point(150, 88)
        Me.M_NewJob.Name = "M_NewJob"
        Me.M_NewJob.Size = New System.Drawing.Size(75, 23)
        Me.M_NewJob.TabIndex = 0
        Me.M_NewJob.Text = "New Job"
        Me.M_NewJob.UseVisualStyleBackColor = True
        '
        'M_Results
        '
        Me.M_Results.Location = New System.Drawing.Point(150, 117)
        Me.M_Results.Name = "M_Results"
        Me.M_Results.Size = New System.Drawing.Size(75, 23)
        Me.M_Results.TabIndex = 2
        Me.M_Results.Text = "Results"
        Me.M_Results.UseVisualStyleBackColor = True
        '
        'M_EditDetails
        '
        Me.M_EditDetails.Location = New System.Drawing.Point(150, 146)
        Me.M_EditDetails.Name = "M_EditDetails"
        Me.M_EditDetails.Size = New System.Drawing.Size(75, 23)
        Me.M_EditDetails.TabIndex = 3
        Me.M_EditDetails.Text = "Edit Details"
        Me.M_EditDetails.UseVisualStyleBackColor = True
        '
        'M_Quit
        '
        Me.M_Quit.Location = New System.Drawing.Point(150, 204)
        Me.M_Quit.Name = "M_Quit"
        Me.M_Quit.Size = New System.Drawing.Size(75, 23)
        Me.M_Quit.TabIndex = 5
        Me.M_Quit.Text = "Quit"
        Me.M_Quit.UseVisualStyleBackColor = True
        '
        'Worker_hours
        '
        Me.Worker_hours.Location = New System.Drawing.Point(12, 88)
        Me.Worker_hours.Name = "Worker_hours"
        Me.Worker_hours.Size = New System.Drawing.Size(110, 52)
        Me.Worker_hours.TabIndex = 9
        Me.Worker_hours.Text = "Manage Worker Hours "
        Me.Worker_hours.UseVisualStyleBackColor = True
        '
        'Material_invoice
        '
        Me.Material_invoice.Location = New System.Drawing.Point(12, 146)
        Me.Material_invoice.Name = "Material_invoice"
        Me.Material_invoice.Size = New System.Drawing.Size(110, 52)
        Me.Material_invoice.TabIndex = 10
        Me.Material_invoice.Text = "Add Material Invoice"
        Me.Material_invoice.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Daily Form:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Other Tools:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Walter.My.Resources.Resources.walter1
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Payments_button
        '
        Me.Payments_button.Location = New System.Drawing.Point(150, 175)
        Me.Payments_button.Name = "Payments_button"
        Me.Payments_button.Size = New System.Drawing.Size(75, 23)
        Me.Payments_button.TabIndex = 14
        Me.Payments_button.Text = "Payments"
        Me.Payments_button.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(237, 237)
        Me.Controls.Add(Me.Payments_button)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Material_invoice)
        Me.Controls.Add(Me.Worker_hours)
        Me.Controls.Add(Me.M_Quit)
        Me.Controls.Add(Me.M_EditDetails)
        Me.Controls.Add(Me.M_Results)
        Me.Controls.Add(Me.M_NewJob)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.TransparencyKey = System.Drawing.Color.DarkRed
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents M_NewJob As System.Windows.Forms.Button
    Friend WithEvents M_Results As System.Windows.Forms.Button
    Friend WithEvents M_EditDetails As System.Windows.Forms.Button
    Friend WithEvents M_Quit As System.Windows.Forms.Button
    Friend WithEvents Worker_hours As System.Windows.Forms.Button
    Friend WithEvents Material_invoice As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Payments_button As System.Windows.Forms.Button

End Class
