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
    End Sub

    Private Sub NJ_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJ_Done.Click
        DF_Date.CustomFormat = "dd/MM/yyyy"
        SQLWriting("INSERT INTO Workers_Hours(WorkerID, JobID, Date_worked, Hours_worked, Task) VALUES('" & SQLReading("SELECT WorkerID FROM Worker WHERE Worker_Name = '" + DF_Worker.Text + "'") & "'," & SQLReading("SELECT JobID FROM Jobs WHERE Job_Name = '" + DF_Job.Text + "'") & ",'" + DF_Date.Text + "','" + DF_Hours_worked.Text + "', '" + DF_Task.Text + "')")
        MainMenu.Visible = True
        Me.Visible = False
    End Sub
End Class