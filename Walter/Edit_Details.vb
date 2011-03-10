Imports System.Data.OleDb, Walter.SQLStuff

Public Class Edit_Details
    Private Sub EDS_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDS_Cancel.Click, EDC_Cancel.Click, EDW_Cancel.Click, EDJ_Cancel.Click
        MainMenu.Visible = True
        Me.Visible = False
        'WalterDAL.
    End Sub


    'Edit Details of Job'
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


    'Edit Details of Worker'
    Private Sub EDW_Worker_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EDW_Worker.GotFocus
        Populate_ComboBox(EDW_Worker, "SELECT Worker_Name FROM Worker")
    End Sub

    Private Sub EDW_Worker_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles EDW_Worker.SelectedIndexChanged
        'Special Populating SQL Query'
        Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim mySelectQuery As String = "SELECT * FROM Worker WHERE Worker_Name = '" + EDW_Worker.Text + "'"
        Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            EDW_Worker_Name.Text = myReader.GetString(1)
            EDW_A1.Text = myReader.GetValue(2)
            EDW_A2.Text = myReader.GetValue(3)
            EDW_Postcode.Text = myReader.GetString(4)
            EDW_HR.Text = myReader.GetString(5)
        End While
        myReader.Close()
        myConnection.Close()
        'End of Special Query'
    End Sub


    Private Sub EDW_Done_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EDW_Done.Click
        Dim dlgRes As DialogResult
        dlgRes = MessageBox.Show("Are you Sure you want to change this Record?", "Edit Details of Job", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgRes = DialogResult.Yes Then
            SQLWriting("UPDATE Worker SET Worker_Name = '" + EDW_Worker_Name.Text + "', Address1 = '" + EDW_A1.Text + "', Address2 = '" + EDW_A2.Text + "', Postcode = '" + EDW_Postcode.Text + "' , Hourly_Rate = " + EDW_HR.Text + " WHERE WorkerID = " & SQLReading("SELECT WorkerID FROM Worker WHERE Worker_Name = '" + EDW_Worker.Text + "'"))
            MainMenu.Visible = True
            Me.Close()
        End If
    End Sub


    'Edit Details of Customer'

    Private Sub EDC_Customer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EDC_Customer.GotFocus
        Populate_ComboBox(EDC_Customer, "SELECT Customer_Name FROM Customer")
    End Sub

    Private Sub EDC_Customer_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles EDC_Customer.SelectedIndexChanged
        'Special Populating SQL Query'
        Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim mySelectQuery As String = "SELECT * FROM Customer WHERE Customer_Name = '" + EDC_Customer.Text + "'"
        Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            EDC_Customer_Name.Text = myReader.GetString(1)
            EDC_A1.Text = myReader.GetValue(2)
            EDC_A2.Text = myReader.GetValue(3)
            EDC_P.Text = myReader.GetString(4)
        End While
        myReader.Close()
        myConnection.Close()
        'End of Special Query'
    End Sub

    Private Sub EDC_Done_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EDC_Done.Click
        Dim dlgRes As DialogResult
        dlgRes = MessageBox.Show("Are you Sure you want to change this Record?", "Edit Details of Job", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgRes = DialogResult.Yes Then
            SQLWriting("UPDATE Customer SET Customer_Name = '" + EDC_Customer_Name.Text + "', Address1 = '" + EDC_A1.Text + "', Address2 = '" + EDC_A2.Text + "', Postcode = '" + EDC_P.Text + "' WHERE CustomerID = " & SQLReading("SELECT CustomerID FROM Customer WHERE Customer_Name = '" + EDC_Customer.Text + "'"))
            MainMenu.Visible = True
            Me.Close()
        End If
    End Sub


    'edit details of Supplier'
    Private Sub EDS_Supplier_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EDS_Supplier.GotFocus
        Populate_ComboBox(EDS_Supplier, "SELECT Supplier_Name FROM Supplier")
    End Sub

    Private Sub EDS_Supplier_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles EDS_Supplier.SelectedIndexChanged
        'Special Populating SQL Query'
        Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim mySelectQuery As String = "SELECT * FROM Supplier WHERE Supplier_Name = '" + EDS_Supplier.Text + "'"
        Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            EDS_SN.Text = myReader.GetString(1)
            EDS_A1.Text = myReader.GetValue(2)
            EDS_A2.Text = myReader.GetValue(3)
            EDS_P.Text = myReader.GetString(4)
        End While
        myReader.Close()
        myConnection.Close()
        'End of Special Query'
    End Sub


    Private Sub EDS_Done_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EDS_Done.Click
        Dim dlgRes As DialogResult
        dlgRes = MessageBox.Show("Are you Sure you want to change this Record?", "Edit Details of Job", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgRes = DialogResult.Yes Then
            SQLWriting("UPDATE Supplier SET Supplier_Name = '" + EDS_SN.Text + "', Address1 = '" + EDS_A1.Text + "', Address2 = '" + EDS_A2.Text + "', Postcode = '" + EDS_P.Text + "' WHERE SupplierID = " & SQLReading("SELECT SupplierID FROM Supplier WHERE Supplier_Name = '" + EDS_SN.Text + "'"))
            MainMenu.Visible = True
            Me.Close()
        End If
    End Sub
End Class




