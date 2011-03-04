Imports System.Data.OleDb

Public Class Daily_Form

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub NJ_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJ_Cancel.Click
        MainMenu.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub DF_Job_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DF_Job.GotFocus
        'SQL Reading'
        Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim mySelectQuery As String = "SELECT Job_Name FROM Jobs"
        Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        While myReader.Read()
            DF_Job.Items.Add(myReader.GetValue(0))
        End While
        myReader.Close()
        myConnection.Close()
    End Sub

    Private Sub DF_Job_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DF_Job.SelectedIndexChanged
        
    End Sub

    Private Sub DF_Worker_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DF_Worker.GotFocus
        DF_Worker.Items.Clear()
        Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim mySelectQuery As String = "SELECT Worker_Name FROM Worker"
        Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        ' Always call Read before accessing data.
        While myReader.Read()
            DF_Worker.Items.Add(myReader.GetValue(0)) 'AAAWWW YEEEAAAHHHH'
        End While
        ' always call Close when done reading.
        myReader.Close()
        ' Close the connection when done with it.
        myConnection.Close()
    End Sub

    Private Sub NJ_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJ_Done.Click
        Dim WorkerID As String
        Dim WorkerText As String
        WorkerText = DF_Worker.Text
        Dim JobID As String


        'SQL Reading'

        Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim mySelectQuery As String = "SELECT WorkerID FROM Worker WHERE Worker_Name = '" + WorkerText + "'"
        Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        WorkerID = ""
        While myReader.Read()
            WorkerID = myReader.GetValue(0)
        End While
        myReader.Close()
        myConnection.Close()

        'SQL Reading'
        Dim myConnection2 As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim mySelectQuery2 As String = "SELECT JobID FROM Jobs WHERE Job_Name = '" + DF_Job.Text + "'"
        Dim myCommand2 As New OleDbCommand(mySelectQuery2, myConnection2)
        myConnection2.Open()
        Dim myReader2 As OleDbDataReader
        myReader2 = myCommand2.ExecuteReader()
        JobID = ""
        While myReader2.Read()
            JobID = myReader2.GetValue(0)
        End While
        myReader2.Close()
        myConnection2.Close()

        DF_Date.CustomFormat = "dd/MM/yyyy"
        'SQL Writing'
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim sql As String = String.Empty
        sql = "INSERT INTO Workers_Hours(WorkerID, JobID, Date_worked, Hours_worked) VALUES('" + WorkerID + "'," + JobID + ",'" + DF_Date.Text + "','" + DF_Hours_worked.Text + "')"
        conn.Open()
        Dim command As New OleDbCommand(sql, conn)
        Dim rowsAffected As Integer
        rowsAffected = command.ExecuteNonQuery()
        MsgBox("Query affected " & rowsAffected & " rows!")
        conn.Close()

        MainMenu.Visible = True
        Me.Visible = False
    End Sub
End Class