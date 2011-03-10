Imports System.Data.OleDb
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

    Public Sub SQLWriting(ByVal sql)

        walterDbCommand = New OleDbCommand(sql, walterDbConnection)
        walterDbCommand.ExecuteNonQuery()

        MsgBox("Success!")
    End Sub
End Module
