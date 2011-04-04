<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoices
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
        Me.I_Type = New System.Windows.Forms.ComboBox()
        Me.I_N = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.I_Back = New System.Windows.Forms.Button()
        Me.I_Date1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.I_Date2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.I_Total = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'I_Type
        '
        Me.I_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.I_Type.FormattingEnabled = True
        Me.I_Type.Items.AddRange(New Object() {"Job", "Worker", "Supplier"})
        Me.I_Type.Location = New System.Drawing.Point(12, 27)
        Me.I_Type.Name = "I_Type"
        Me.I_Type.Size = New System.Drawing.Size(165, 21)
        Me.I_Type.TabIndex = 0
        '
        'I_N
        '
        Me.I_N.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.I_N.FormattingEnabled = True
        Me.I_N.Location = New System.Drawing.Point(183, 27)
        Me.I_N.Name = "I_N"
        Me.I_N.Size = New System.Drawing.Size(266, 21)
        Me.I_N.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pick an Invoice option:"
        '
        'I_Back
        '
        Me.I_Back.Location = New System.Drawing.Point(374, 448)
        Me.I_Back.Name = "I_Back"
        Me.I_Back.Size = New System.Drawing.Size(75, 23)
        Me.I_Back.TabIndex = 5
        Me.I_Back.Text = "Back"
        Me.I_Back.UseVisualStyleBackColor = True
        '
        'I_Date1
        '
        Me.I_Date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.I_Date1.Location = New System.Drawing.Point(53, 54)
        Me.I_Date1.Name = "I_Date1"
        Me.I_Date1.Size = New System.Drawing.Size(188, 20)
        Me.I_Date1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Dates:"
        '
        'I_Date2
        '
        Me.I_Date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.I_Date2.Location = New System.Drawing.Point(263, 54)
        Me.I_Date2.Name = "I_Date2"
        Me.I_Date2.Size = New System.Drawing.Size(186, 20)
        Me.I_Date2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(247, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "-"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 80)
        Me.DataGridView1.MaximumSize = New System.Drawing.Size(437, 337)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(437, 337)
        Me.DataGridView1.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(223, 426)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total:"
        '
        'I_Total
        '
        Me.I_Total.Location = New System.Drawing.Point(263, 423)
        Me.I_Total.Name = "I_Total"
        Me.I_Total.Size = New System.Drawing.Size(186, 20)
        Me.I_Total.TabIndex = 12
        '
        'Invoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 483)
        Me.Controls.Add(Me.I_Total)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.I_Date2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.I_Date1)
        Me.Controls.Add(Me.I_Back)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.I_N)
        Me.Controls.Add(Me.I_Type)
        Me.Name = "Invoices"
        Me.Text = "Invoices"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents I_Type As System.Windows.Forms.ComboBox
    Friend WithEvents I_N As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents I_Back As System.Windows.Forms.Button
    Friend WithEvents I_Date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents I_Date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents I_Total As System.Windows.Forms.TextBox
End Class
