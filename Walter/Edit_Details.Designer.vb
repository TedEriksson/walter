<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Details
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.EDJ_Customer = New System.Windows.Forms.ComboBox()
        Me.EDJ_Job = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EDJ_Address2 = New System.Windows.Forms.TextBox()
        Me.EDJ_Address1 = New System.Windows.Forms.TextBox()
        Me.EDJ_Postcode = New System.Windows.Forms.TextBox()
        Me.EDJ_Initial_Budget = New System.Windows.Forms.TextBox()
        Me.EDJ_Job_Name = New System.Windows.Forms.TextBox()
        Me.EDJ_Cancel = New System.Windows.Forms.Button()
        Me.NJ_Done = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.EDW_Worker = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EDW_HR = New System.Windows.Forms.TextBox()
        Me.EDW_Postcode = New System.Windows.Forms.TextBox()
        Me.EDW_A2 = New System.Windows.Forms.TextBox()
        Me.EDW_A1 = New System.Windows.Forms.TextBox()
        Me.EDW_Worker_Name = New System.Windows.Forms.TextBox()
        Me.EDW_Cancel = New System.Windows.Forms.Button()
        Me.EDW_Done = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.EDC_Customer = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.EDC_Cancel = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.EDS_Cancel = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 6)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(311, 266)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.EDJ_Customer)
        Me.TabPage1.Controls.Add(Me.EDJ_Job)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.EDJ_Address2)
        Me.TabPage1.Controls.Add(Me.EDJ_Address1)
        Me.TabPage1.Controls.Add(Me.EDJ_Postcode)
        Me.TabPage1.Controls.Add(Me.EDJ_Initial_Budget)
        Me.TabPage1.Controls.Add(Me.EDJ_Job_Name)
        Me.TabPage1.Controls.Add(Me.EDJ_Cancel)
        Me.TabPage1.Controls.Add(Me.NJ_Done)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(303, 234)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Job"
        '
        'EDJ_Customer
        '
        Me.EDJ_Customer.FormattingEnabled = True
        Me.EDJ_Customer.Location = New System.Drawing.Point(113, 64)
        Me.EDJ_Customer.Name = "EDJ_Customer"
        Me.EDJ_Customer.Size = New System.Drawing.Size(180, 21)
        Me.EDJ_Customer.TabIndex = 30
        '
        'EDJ_Job
        '
        Me.EDJ_Job.FormattingEnabled = True
        Me.EDJ_Job.Location = New System.Drawing.Point(113, 11)
        Me.EDJ_Job.Name = "EDJ_Job"
        Me.EDJ_Job.Size = New System.Drawing.Size(181, 21)
        Me.EDJ_Job.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Job:"
        '
        'EDJ_Address2
        '
        Me.EDJ_Address2.Location = New System.Drawing.Point(113, 142)
        Me.EDJ_Address2.Name = "EDJ_Address2"
        Me.EDJ_Address2.Size = New System.Drawing.Size(181, 20)
        Me.EDJ_Address2.TabIndex = 27
        '
        'EDJ_Address1
        '
        Me.EDJ_Address1.Location = New System.Drawing.Point(113, 116)
        Me.EDJ_Address1.Name = "EDJ_Address1"
        Me.EDJ_Address1.Size = New System.Drawing.Size(181, 20)
        Me.EDJ_Address1.TabIndex = 26
        '
        'EDJ_Postcode
        '
        Me.EDJ_Postcode.Location = New System.Drawing.Point(113, 168)
        Me.EDJ_Postcode.Name = "EDJ_Postcode"
        Me.EDJ_Postcode.Size = New System.Drawing.Size(181, 20)
        Me.EDJ_Postcode.TabIndex = 25
        '
        'EDJ_Initial_Budget
        '
        Me.EDJ_Initial_Budget.Location = New System.Drawing.Point(113, 90)
        Me.EDJ_Initial_Budget.Name = "EDJ_Initial_Budget"
        Me.EDJ_Initial_Budget.Size = New System.Drawing.Size(181, 20)
        Me.EDJ_Initial_Budget.TabIndex = 24
        '
        'EDJ_Job_Name
        '
        Me.EDJ_Job_Name.Location = New System.Drawing.Point(113, 38)
        Me.EDJ_Job_Name.Name = "EDJ_Job_Name"
        Me.EDJ_Job_Name.Size = New System.Drawing.Size(181, 20)
        Me.EDJ_Job_Name.TabIndex = 22
        '
        'EDJ_Cancel
        '
        Me.EDJ_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.EDJ_Cancel.Location = New System.Drawing.Point(219, 200)
        Me.EDJ_Cancel.Name = "EDJ_Cancel"
        Me.EDJ_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.EDJ_Cancel.TabIndex = 21
        Me.EDJ_Cancel.Text = "Cancel"
        Me.EDJ_Cancel.UseVisualStyleBackColor = True
        '
        'NJ_Done
        '
        Me.NJ_Done.Location = New System.Drawing.Point(138, 200)
        Me.NJ_Done.Name = "NJ_Done"
        Me.NJ_Done.Size = New System.Drawing.Size(75, 23)
        Me.NJ_Done.TabIndex = 20
        Me.NJ_Done.Text = "Done"
        Me.NJ_Done.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Postcode:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Initial Budget:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Customer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Job Name:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.EDW_Worker)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.EDW_HR)
        Me.TabPage2.Controls.Add(Me.EDW_Postcode)
        Me.TabPage2.Controls.Add(Me.EDW_A2)
        Me.TabPage2.Controls.Add(Me.EDW_A1)
        Me.TabPage2.Controls.Add(Me.EDW_Worker_Name)
        Me.TabPage2.Controls.Add(Me.EDW_Cancel)
        Me.TabPage2.Controls.Add(Me.EDW_Done)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(303, 234)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Worker"
        '
        'EDW_Worker
        '
        Me.EDW_Worker.FormattingEnabled = True
        Me.EDW_Worker.Location = New System.Drawing.Point(113, 11)
        Me.EDW_Worker.Name = "EDW_Worker"
        Me.EDW_Worker.Size = New System.Drawing.Size(181, 21)
        Me.EDW_Worker.TabIndex = 44
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Worker:"
        '
        'EDW_HR
        '
        Me.EDW_HR.Location = New System.Drawing.Point(113, 142)
        Me.EDW_HR.Name = "EDW_HR"
        Me.EDW_HR.Size = New System.Drawing.Size(181, 20)
        Me.EDW_HR.TabIndex = 42
        '
        'EDW_Postcode
        '
        Me.EDW_Postcode.Location = New System.Drawing.Point(113, 116)
        Me.EDW_Postcode.Name = "EDW_Postcode"
        Me.EDW_Postcode.Size = New System.Drawing.Size(181, 20)
        Me.EDW_Postcode.TabIndex = 41
        '
        'EDW_A2
        '
        Me.EDW_A2.Location = New System.Drawing.Point(113, 90)
        Me.EDW_A2.Name = "EDW_A2"
        Me.EDW_A2.Size = New System.Drawing.Size(181, 20)
        Me.EDW_A2.TabIndex = 39
        '
        'EDW_A1
        '
        Me.EDW_A1.Location = New System.Drawing.Point(113, 64)
        Me.EDW_A1.Name = "EDW_A1"
        Me.EDW_A1.Size = New System.Drawing.Size(181, 20)
        Me.EDW_A1.TabIndex = 38
        '
        'EDW_Worker_Name
        '
        Me.EDW_Worker_Name.Location = New System.Drawing.Point(113, 38)
        Me.EDW_Worker_Name.Name = "EDW_Worker_Name"
        Me.EDW_Worker_Name.Size = New System.Drawing.Size(181, 20)
        Me.EDW_Worker_Name.TabIndex = 37
        '
        'EDW_Cancel
        '
        Me.EDW_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.EDW_Cancel.Location = New System.Drawing.Point(219, 200)
        Me.EDW_Cancel.Name = "EDW_Cancel"
        Me.EDW_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.EDW_Cancel.TabIndex = 36
        Me.EDW_Cancel.Text = "Cancel"
        Me.EDW_Cancel.UseVisualStyleBackColor = True
        '
        'EDW_Done
        '
        Me.EDW_Done.Location = New System.Drawing.Point(138, 200)
        Me.EDW_Done.Name = "EDW_Done"
        Me.EDW_Done.Size = New System.Drawing.Size(75, 23)
        Me.EDW_Done.TabIndex = 35
        Me.EDW_Done.Text = "Done"
        Me.EDW_Done.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Hourly Rate:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Postcode:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Address:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Worker Name:"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.EDC_Customer)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.TextBox5)
        Me.TabPage3.Controls.Add(Me.TextBox9)
        Me.TabPage3.Controls.Add(Me.TextBox10)
        Me.TabPage3.Controls.Add(Me.TextBox11)
        Me.TabPage3.Controls.Add(Me.EDC_Cancel)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(303, 234)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Customer"
        '
        'EDC_Customer
        '
        Me.EDC_Customer.FormattingEnabled = True
        Me.EDC_Customer.Location = New System.Drawing.Point(113, 11)
        Me.EDC_Customer.Name = "EDC_Customer"
        Me.EDC_Customer.Size = New System.Drawing.Size(181, 21)
        Me.EDC_Customer.TabIndex = 55
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Customer:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(113, 116)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(181, 20)
        Me.TextBox5.TabIndex = 53
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(113, 90)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(181, 20)
        Me.TextBox9.TabIndex = 52
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(113, 64)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(181, 20)
        Me.TextBox10.TabIndex = 51
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(113, 38)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(181, 20)
        Me.TextBox11.TabIndex = 50
        '
        'EDC_Cancel
        '
        Me.EDC_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.EDC_Cancel.Location = New System.Drawing.Point(219, 200)
        Me.EDC_Cancel.Name = "EDC_Cancel"
        Me.EDC_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.EDC_Cancel.TabIndex = 49
        Me.EDC_Cancel.Text = "Cancel"
        Me.EDC_Cancel.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(138, 200)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "Done"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 119)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Postcode:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Address:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Customer Name:"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.ComboBox4)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.TextBox12)
        Me.TabPage4.Controls.Add(Me.TextBox13)
        Me.TabPage4.Controls.Add(Me.TextBox14)
        Me.TabPage4.Controls.Add(Me.TextBox15)
        Me.TabPage4.Controls.Add(Me.EDS_Cancel)
        Me.TabPage4.Controls.Add(Me.Button6)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Location = New System.Drawing.Point(4, 28)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(303, 234)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Supplier"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(113, 11)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(181, 21)
        Me.ComboBox4.TabIndex = 55
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 13)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "Supplier:"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(113, 116)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(181, 20)
        Me.TextBox12.TabIndex = 53
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(113, 90)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(181, 20)
        Me.TextBox13.TabIndex = 52
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(113, 64)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(181, 20)
        Me.TextBox14.TabIndex = 51
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(113, 38)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(181, 20)
        Me.TextBox15.TabIndex = 50
        '
        'EDS_Cancel
        '
        Me.EDS_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.EDS_Cancel.Location = New System.Drawing.Point(219, 200)
        Me.EDS_Cancel.Name = "EDS_Cancel"
        Me.EDS_Cancel.Size = New System.Drawing.Size(75, 23)
        Me.EDS_Cancel.TabIndex = 49
        Me.EDS_Cancel.Text = "Cancel"
        Me.EDS_Cancel.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(138, 200)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 48
        Me.Button6.Text = "Done"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 119)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 13)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "Postcode:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 67)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 13)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "Address:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 13)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "Supplier Name:"
        '
        'Edit_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 265)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Edit_Details"
        Me.Text = "Edit Details"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents EDJ_Address2 As System.Windows.Forms.TextBox
    Friend WithEvents EDJ_Address1 As System.Windows.Forms.TextBox
    Friend WithEvents EDJ_Postcode As System.Windows.Forms.TextBox
    Friend WithEvents EDJ_Initial_Budget As System.Windows.Forms.TextBox
    Friend WithEvents EDJ_Job_Name As System.Windows.Forms.TextBox
    Friend WithEvents EDJ_Cancel As System.Windows.Forms.Button
    Friend WithEvents NJ_Done As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EDJ_Job As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EDW_Worker As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents EDW_HR As System.Windows.Forms.TextBox
    Friend WithEvents EDW_Postcode As System.Windows.Forms.TextBox
    Friend WithEvents EDW_A2 As System.Windows.Forms.TextBox
    Friend WithEvents EDW_A1 As System.Windows.Forms.TextBox
    Friend WithEvents EDW_Worker_Name As System.Windows.Forms.TextBox
    Friend WithEvents EDW_Cancel As System.Windows.Forms.Button
    Friend WithEvents EDW_Done As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents EDC_Customer As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents EDC_Cancel As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents EDS_Cancel As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents EDJ_Customer As System.Windows.Forms.ComboBox
End Class
