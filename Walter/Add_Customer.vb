Imports System.Data.OleDb

Public Class Add_Customer

    Private Sub NJ_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJ_Done.Click

        'SQL Stuff that took bloody ages'
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        'Dim adapter As New OleDbDataAdapter("select * FROM Contacts", conn)'
        Dim sql As String = String.Empty
        sql = "INSERT INTO Customer (Customer_Name, Address1, Address2, Postcode) VALUES('" + AC_Customer_name.Text + "', '" + AC_Address1.Text + "', '" + AC_Address2.Text + "', '" + AC_Postcode.Text + "')"
        'MsgBox(sql)
        conn.Open()
        Dim command As New OleDbCommand(sql, conn)
        Dim rowsAffected As Integer
        rowsAffected = command.ExecuteNonQuery()
        MsgBox("Query affected " & rowsAffected & " rows!")
        conn.Close()



        NewJob.NJ_Customer.Text = AC_Customer_name.Text
        NewJob.Enabled = True
        Me.Close()
    End Sub
End Class