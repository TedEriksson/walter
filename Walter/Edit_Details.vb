Imports System.Data.OleDb, Walter.SQLStuff

Public Class Edit_Details
    Private Sub EDS_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDS_Cancel.Click, EDC_Cancel.Click, EDW_Cancel.Click, EDJ_Cancel.Click
        MainMenu.Visible = True
        Me.Visible = False
    End Sub

    Private Sub EDJ_Job_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EDJ_Job.GotFocus
        Populate_ComboBox(EDJ_Job, "SELECT Job_Name FROM Jobs")
    End Sub

    Private Sub EDJ_Job_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDJ_Job.SelectedIndexChanged
        Dim CustomerID As Integer
        'Special Populating SQL Query'
        Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim mySelectQuery As String = "SELECT * FROM Jobs WHERE Job_Name = '" + EDJ_Job.Text + "'"
        Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            EDJ_Job_Name.Text = myReader.GetString(1)
            CustomerID = myReader.GetValue(2)
            EDJ_Initial_Budget.Text = myReader.GetValue(3)
            EDJ_Address1.Text = myReader.GetString(4)
            EDJ_Address2.Text = myReader.GetString(5)
            EDJ_Postcode.Text = myReader.GetString(6)
        End While
        myReader.Close()
        myConnection.Close()
        'End of Special Query'
        EDJ_Customer.Text = SQLReading("SELECT Customer_Name FROM Customer WHERE CustomerID = " & CustomerID)
    End Sub

    Private Sub NJ_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJ_Done.Click
        Dim dlgRes As DialogResult
        dlgRes = MessageBox.Show("Are you Sure you want to change this Record?", "Edit Details of Job", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgRes = DialogResult.Yes Then
            SQLWriting("UPDATE Jobs SET Job_Name = '" + EDJ_Job_Name.Text + "', CustomerID = " + SQLReading("SELECT CustomerID FROM Customer WHERE Customer_Name = '" + EDJ_Customer.Text + "'").ToString + ", Initial_Budget = '" + EDJ_Initial_Budget.Text + "', Address1 = '" + EDJ_Address1.Text + "', Address2 = '" + EDJ_Address2.Text + "', Postcode = '" + EDJ_Postcode.Text + "' WHERE JobID = " & SQLReading("SELECT JobID FROM Jobs WHERE Job_Name = '" + EDJ_Job.Text + "'"))
            MainMenu.Visible = True
            Me.Close()
        End If
    End Sub

    Private Sub EDJ_Customer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EDJ_Customer.GotFocus
        Populate_ComboBox(EDJ_Customer, "SELECT Customer_Name FROM Customer")
    End Sub
End Class