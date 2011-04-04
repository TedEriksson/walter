Imports System.Data.OleDb

Public Class Daily_Form

    Private Sub NJ_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJ_Cancel.Click
        MainMenu.Visible = True
        Me.Visible = False
    End Sub

    Private Sub DF_Job_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DF_Job.GotFocus
        Populate_ComboBox(DF_Job, "SELECT Job_Name FROM Jobs")
    End Sub

    Private Sub DF_Worker_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DF_Worker.GotFocus
        Populate_ComboBox(DF_Worker, "SELECT Worker_Name FROM Worker")
        DF_Worker.Items.Add("Add New Worker")
    End Sub

    Private Sub NJ_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJ_Done.Click
        DF_Date.CustomFormat = "dd/MM/yyyy"
        SQLWriting("INSERT INTO Workers_Hours(WorkerID, JobID, Date_worked, Hours_worked, Task) VALUES('" & SQLReading("SELECT WorkerID FROM Worker WHERE Worker_Name = '" + DF_Worker.Text + "'") & "'," & SQLReading("SELECT JobID FROM Jobs WHERE Job_Name = '" + DF_Job.Text + "'") & ",'" + DF_Date.Text + "','" + DF_Hours_worked.Text + "', '" + DF_Task.Text + "')")
        MainMenu.Visible = True
        Me.Visible = False
    End Sub

    Private Sub DF_SAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DF_SAN.Click
        DF_Date.CustomFormat = "dd/MM/yyyy"
        SQLWriting("INSERT INTO Workers_Hours(WorkerID, JobID, Date_worked, Hours_worked, Task) VALUES('" & SQLReading("SELECT WorkerID FROM Worker WHERE Worker_Name = '" + DF_Worker.Text + "'") & "'," & SQLReading("SELECT JobID FROM Jobs WHERE Job_Name = '" + DF_Job.Text + "'") & ",'" + DF_Date.Text + "','" + DF_Hours_worked.Text + "', '" + DF_Task.Text + "')")
    End Sub

    Private Sub DF_Worker_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DF_Worker.SelectedIndexChanged
        Dim WorkerText As String
        WorkerText = DF_Worker.Text
        If WorkerText = "Add New Worker" Then
            Add_Worker.Visible = True
            Me.Enabled = False
        End If
    End Sub

    Private Sub DF_Hours_worked_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DF_Hours_worked.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub Daily_Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DF_Job.DropDownStyle = 2
        DF_Worker.DropDownStyle = 2
    End Sub
End Class