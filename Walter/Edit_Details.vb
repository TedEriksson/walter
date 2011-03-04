Imports System.Data.OleDb

Public Class Edit_Details

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub EDJ_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDJ_Cancel.Click
        MainMenu.Visible = True
        Me.Visible = False
    End Sub

    Private Sub EDW_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDW_Cancel.Click
        MainMenu.Visible = True
        Me.Visible = False
    End Sub

    Private Sub EDC_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDC_Cancel.Click
        MainMenu.Visible = True
        Me.Visible = False
    End Sub

    Private Sub EDS_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDS_Cancel.Click
        MainMenu.Visible = True
        Me.Visible = False
    End Sub

    Private Sub EDJ_Job_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EDJ_Job.GotFocus
        EDJ_Job.Items.Clear()
        'SQL Reading'
        Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim mySelectQuery As String = "SELECT Job_Name FROM Jobs"
        Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            EDJ_Job.Items.Add(myReader.GetValue(0))
        End While
        myReader.Close()
        myConnection.Close()
    End Sub

    Private Sub EDJ_Job_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDJ_Job.SelectedIndexChanged
        Dim CustomerID As Integer
        'SQL Reading'

        'Query 1!'
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

        'Query 2!'
        mySelectQuery = "SELECT Customer_Name FROM Customer WHERE CustomerID = " & CustomerID
        Dim myCommand2 As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        myReader = myCommand2.ExecuteReader()
        While myReader.Read()
            EDJ_Customer.Text = myReader.GetValue(0)
        End While
        myReader.Close()
        myConnection.Close()

    End Sub

    Private Sub NJ_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJ_Done.Click
        Dim JobID As Integer
        Dim dlgRes As DialogResult
        dlgRes = MessageBox.Show("Are you Sure you want to change this Record?", "Edit Details of Job", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgRes = DialogResult.Yes Then
            'SQL Reading'
            Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
            Dim mySelectQuery As String = "SELECT JobID FROM Jobs WHERE Job_Name = '" + EDJ_Job.Text + "'"
            Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
            myConnection.Open()
            Dim myReader As OleDbDataReader
            myReader = myCommand.ExecuteReader()
            While myReader.Read()
                JobID = myReader.GetValue(0)
            End While
            myReader.Close()
            myConnection.Close()

            Dim customerID As Integer
            Dim customername As String
            customername = EDJ_Customer.Text
            'SQL Reading'
            Dim myConnection1 As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
            Dim mySelectQuery1 As String = "SELECT CustomerID FROM Customer WHERE Customer_Name = '" + customername + "'"
            Dim myCommand1 As New OleDbCommand(mySelectQuery1, myConnection1)
            myConnection1.Open()
            Dim myReader1 As OleDbDataReader
            myReader1 = myCommand1.ExecuteReader()
            While myReader1.Read()
                customerID = myReader1.GetValue(0)
            End While
            myReader1.Close()
            myConnection1.Close()


            'SQL Writing'
            Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
            Dim sql As String = String.Empty
            sql = "UPDATE Jobs SET Job_Name = '" + EDJ_Job_Name.Text + "', CustomerID = " + customerID.ToString + ", Initial_Budget = '" + EDJ_Initial_Budget.Text + "', Address1 = '" + EDJ_Address1.Text + "', Address2 = '" + EDJ_Address2.Text + "', Postcode = '" + EDJ_Postcode.Text + "' WHERE JobID = " & JobID
            conn.Open()
            Dim command As New OleDbCommand(sql, conn)
            Dim rowsAffected As Integer
            rowsAffected = command.ExecuteNonQuery()
            MsgBox("Query affected " & rowsAffected & " rows!")
            conn.Close()

            MainMenu.Visible =True 
            Me.Close()
        End If
    End Sub

    Private Sub EDJ_Customer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EDJ_Customer.GotFocus
        EDJ_Customer.Items.Clear()
        Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim mySelectQuery As String = "SELECT Customer_Name FROM Customer"
        Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        ' Always call Read before accessing data.
        While myReader.Read()
            EDJ_Customer.Items.Add(myReader.GetValue(0)) 'AAAWWW YEEEAAAHHHH'
        End While
        ' always call Close when done reading.
        myReader.Close()
        ' Close the connection when done with it.
        myConnection.Close()
    End Sub
End Class