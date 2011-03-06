Imports System.Data.OleDb
Module SQLStuff
    Public Sub Populate_ComboBox(ByVal varcombo, ByVal mySelectQuery)
        varcombo.Items.Clear()
        Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        ' Always call Read before accessing data.
        While myReader.Read()
            varcombo.Items.Add(myReader.GetValue(0)) 'AAAWWW YEEEAAAHHHH'
        End While
        ' always call Close when done reading.
        myReader.Close()
        ' Close the connection when done with it.
        myConnection.Close()
        varcombo = vbNull
        mySelectQuery = vbNullString
    End Sub

    Public Function SQLReading(ByVal mySelectQuery)
        'SQL Reading'
        Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim varread As Object
        Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        varread = vbNull
        While myReader.Read()
            varread = myReader.GetValue(0)
        End While
        myReader.Close()
        myConnection.Close()
        Return varread
    End Function

    Public Sub SQLWriting(ByVal sql)
        'SQL Writing'
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        conn.Open()
        Dim command As New OleDbCommand(sql, conn)
        command.ExecuteNonQuery()
        conn.Close()
    End Sub
End Module
