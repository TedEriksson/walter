Public Class Job_Status

    Private Sub JS_Job_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles JS_Job.GotFocus
        Populate_ComboBox(JS_Job, "SELECT Job_Name FROM Jobs")
    End Sub


    Private Sub JS_Job_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles JS_Job.SelectedIndexChanged
        Dim income_var As String
        income_var = 0
        Try
            income_var = SQLReading("SELECT SUM(Amount) FROM Payments_Made WHERE JobID = " & SQLReading("SELECT JobID FROM Jobs WHERE Job_Name = '" + JS_Job.Text + "'"))
        Catch ex As Exception
            MsgBox("Customer has not yet made a payment for this job.")
        End Try

        JS_Income.Text = "£" & income_var
         End Sub
End Class