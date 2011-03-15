Public Class Job_Status

    Private Sub JS_Job_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles JS_Job.GotFocus
        Populate_ComboBox(JS_Job, "SELECT Job_Name FROM Jobs")
    End Sub


    Private Sub JS_Job_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles JS_Job.SelectedIndexChanged
        Dim varincome, varoutput, vartotal, workercount, i, hr, hw As Integer
        Dim jobname As String
        varincome = 0
        varoutput = 0
        vartotal = 0
        jobname = JS_Job.Text
        Try
            varincome = SQLReading("SELECT SUM(Amount) FROM Payments_Made WHERE JobID = " & SQLReading("SELECT JobID From Jobs WHERE Job_Name = '" + jobname + "'"))
        Catch ex As InvalidCastException
            MsgBox("The Customer has not made a payment fo this job yet.")
        End Try
        JS_I.Text = "£" & varincome

        workercount = SQLReading("SELECT COUNT(*) FROM Worker")
        i = 1
        varoutput = 0
        Do Until i = workercount
            hr = 0
            hr = SQLReading("SELECT Hourly_Rate FROM Worker WHERE WorkerID = " & i)
            hw = 0
            Try
                hw = SQLReading("SELECT SUM(Hours_Worked) FROM Workers_Hours WHERE WorkerID = " & i & " AND JobID = " & SQLReading("SELECT JobID From Jobs WHERE Job_Name = '" + jobname + "'"))
            Catch ex As Exception
            End Try
            varoutput = varoutput + (hr * hw)
            i = i + 1
        Loop
        JS_O.Text = "£" & varoutput
        JS_T.Text = "£" & (varincome - varoutput)
    End Sub


    Private Sub JS_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JS_Done.Click
        MainMenu.Visible = True
        Me.Close()
    End Sub
End Class