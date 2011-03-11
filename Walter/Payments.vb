Public Class Payments

    Private Sub P_Job_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles P_Job.GotFocus
        Populate_ComboBox(P_Job, "SELECT Job_Name FROM Jobs")
    End Sub


    Private Sub P_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_Done.Click
        P_Date.CustomFormat = "dd/MM/yyyy"
        SQLWriting("INSERT INTO Payments_Made(JobID, Amount, Date_of_Payment) VALUES(" & SQLReading("SELECT JobID FROM Jobs WHERE Job_Name = '" + P_Job.Text + "'") & ", " + P_Amount.Text + ", '" + P_Date.Text + "')")
        MainMenu.Visible = True
        Me.Close()
    End Sub

    Private Sub P_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P_Cancel.Click
        MainMenu.Visible = True
        Me.Close()
    End Sub
End Class