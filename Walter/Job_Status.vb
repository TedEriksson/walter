Public Class Job_Status

    Private Sub JS_Job_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles JS_Job.GotFocus
        Populate_ComboBox(JS_Job, "SELECT Job_Name FROM Jobs")
    End Sub


    Private Sub JS_Job_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles JS_Job.SelectedIndexChanged
        Dim varincome As Integer
        varincome = 0
        Try
            varincome = SQLReading("SELECT SUM(Amount) FROM Payments_Made WHERE JobID = " & SQLReading("SELECT JobID From Jobs WHERE Job_Name = '" + JS_Job.Text + "'"))
        Catch ex As InvalidCastException
            MsgBox("The Customer has not made a payment fo this job yet.")
        End Try
        JS_I.Text = "£" & varincome

    End Sub
End Class