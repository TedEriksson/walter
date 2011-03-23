Imports System.Data.OleDb, System.IO
Module SQLStuff

    'Fields/Variables
    Public walterDbConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
    Public walterDbCommand As New OleDbCommand("", walterDbConnection)

    'Methods/Subs
    Public Sub Populate_ComboBox(ByVal varcombo, ByVal mySelectQuery)
        varcombo.Items.Clear()
        walterDbCommand = New OleDbCommand(mySelectQuery, walterDbConnection)
        Dim myReader As OleDbDataReader
        myReader = walterDbCommand.ExecuteReader()
        While myReader.Read()
            varcombo.Items.Add(myReader.GetValue(0))
        End While
        myReader.Close()
        varcombo = vbNull
        mySelectQuery = vbNullString
    End Sub

    Public Function SQLReading(ByVal mySelectQuery)
        Dim varread As Object
        walterDbCommand = New OleDbCommand(mySelectQuery, walterDbConnection)
        Dim myReader As OleDbDataReader
        myReader = walterDbCommand.ExecuteReader()
        varread = vbNull
        While myReader.Read()
            varread = myReader.GetValue(0)
        End While
        myReader.Close()
        Return varread
    End Function

    Public Function CreateInvoice(ByVal mySelectQuery)
        Dim stringythingy As String
        stringythingy = ""
        walterDbCommand = New OleDbCommand(mySelectQuery, walterDbConnection)
        Dim myReader As OleDbDataReader
        myReader = walterDbCommand.ExecuteReader()
        While myReader.Read()
            If stringythingy = "" Then
                stringythingy = myReader.GetValue(0)
            Else
                stringythingy = stringythingy + ", " & myReader.GetValue(0)
            End If
        End While
        myReader.Close()
        mySelectQuery = vbNullString
        Return stringythingy
        stringythingy = ""
    End Function

    Public Function GetTable() As DataTable
        Dim myselectquery As String
        Dim table As New DataTable
        table.Columns.Add("Task", GetType(String))
        table.Columns.Add("Hours Worked", GetType(Integer))
        myselectquery = "SELECT Task FROM Workers_hours WHERE WorkerID = " & SQLReading("SELECT WorkerID FROM Worker WHERE Worker_Name = '" + Invoices.I_N.Text + "'")
        walterDbCommand = New OleDbCommand(myselectquery, walterDbConnection)
        Dim myReader As OleDbDataReader
        myReader = walterDbCommand.ExecuteReader()
        While myReader.Read()
            table.Rows.Add(myReader.GetValue(0))
        End While
        myReader.Close()
        Return table
    End Function

    Public Sub SQLWriting(ByVal sql)

        walterDbCommand = New OleDbCommand(sql, walterDbConnection)
        walterDbCommand.ExecuteNonQuery()
        MsgBox("Success!")
    End Sub

    Public Sub SQLWritingLogin(ByVal Log)
        walterDbCommand = New OleDbCommand(Log, walterDbConnection)
        walterDbCommand.ExecuteScalar()
    End Sub
End Module
