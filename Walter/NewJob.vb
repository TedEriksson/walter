Imports System.Data.OleDb


Public Class NewJob

    Private Sub NJ_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJ_Cancel.Click
        MainMenu.Visible = True
        Me.Visible = False
    End Sub

    Private Sub NewJob_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
    End Sub

    Private Sub NJ_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJ_Done.Click

        Dim customerID As Integer
        Dim CustomerText As String
        CustomerText = NJ_Customer.Text

        'SQL Reading'
        Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim mySelectQuery As String = "SELECT CustomerID FROM Customer WHERE Customer_Name = '" + CustomerText + "'"
        Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            customerID = myReader.GetValue(0)
        End While
        myReader.Close()
        myConnection.Close()

        'SQL Writing'
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim sql As String = String.Empty
        sql = "INSERT INTO Jobs (Job_Name, CustomerID, Initial_Budget, Address1, Address2, Postcode) VALUES('" + NW_JobName.Text + "'," + customerID.ToString + ",'" + NJ_InitialBudget.Text + "','" + NJ_Address1.Text + "','" + NJ_Address2.Text + "','" + NJ_Postcode.Text + "')"
        conn.Open()
        Dim command As New OleDbCommand(sql, conn)
        Dim rowsAffected As Integer
        rowsAffected = command.ExecuteNonQuery()
        MsgBox("Query affected " & rowsAffected & " rows!")
        conn.Close()

        MainMenu.Visible = True
        Me.Visible = False

    End Sub

    Private Sub NJ_Customer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NJ_Customer.GotFocus
        NJ_Customer.Items.Clear()
        Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim mySelectQuery As String = "SELECT Customer_Name FROM Customer"
        Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        ' Always call Read before accessing data.
        While myReader.Read()
            NJ_Customer.Items.Add(myReader.GetValue(0)) 'AAAWWW YEEEAAAHHHH'
        End While
        ' always call Close when done reading.
        myReader.Close()
        ' Close the connection when done with it.
        myConnection.Close()

        NJ_Customer.Items.Add("Add New Customer")



    End Sub

    Private Sub NJ_Customer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJ_Customer.SelectedIndexChanged
        Dim CustomerText As String

        CustomerText = NJ_Customer.Text

        If CustomerText = "Add New Customer" Then
            Add_Customer.Visible = True
            Me.Enabled = False
        End If




    End Sub
End Class