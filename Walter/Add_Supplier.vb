Imports System.Data.OleDb
Public Class Add_Supplier

    Private Sub AS_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AS_Done.Click

        'SQL Stuff that took bloody ages'
        Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        'Dim adapter As New OleDbDataAdapter("select * FROM Contacts", conn)'
        Dim sql As String = String.Empty
        sql = "INSERT INTO Supplier (Supplier_Name, Address1, Address2, Postcode) VALUES('" + AS_Supplier_name.Text + "', '" + AS_Address1.Text + "', '" + AS_Address2.Text + "', '" + AS_Postcode.Text + "')"
        'MsgBox(sql)
        conn.Open()
        Dim command As New OleDbCommand(sql, conn)
        Dim rowsAffected As Integer
        rowsAffected = command.ExecuteNonQuery()
        MsgBox("Query affected " & rowsAffected & " rows!")
        conn.Close()

        Add_Material_invoice.ADM_Supplier_Name.Text = AS_Supplier_name.Text
        Add_Material_invoice.Enabled = True
        Me.Close()
    End Sub

End Class