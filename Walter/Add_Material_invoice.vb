Imports System.Data.OleDb
Public Class Add_Material_invoice

    Private Sub ADM_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADM_Cancel.Click
        MainMenu.Visible = True
        Me.Visible = False
    End Sub

    Private Sub ADM_Supplier_Name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ADM_Supplier_Name.GotFocus
        ADM_Supplier_Name.Items.Clear()
        Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim mySelectQuery As String = "SELECT Supplier_Name FROM Supplier"
        Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        ' Always call Read before accessing data.
        While myReader.Read()
            ADM_Supplier_Name.Items.Add(myReader.GetValue(0)) 'AAAWWW YEEEAAAHHHH'
        End While
        ' always call Close when done reading.
        myReader.Close()
        ' Close the connection when done with it.
        myConnection.Close()

        ADM_Supplier_Name.Items.Add("Add New Supplier")



    End Sub

    Private Sub ADM_Supplier_Name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADM_Supplier_Name.SelectedIndexChanged
        Dim SupplierText As String

        SupplierText = ADM_Supplier_Name.Text

        If SupplierText = "Add New Supplier" Then
            Add_Supplier.Visible = True
            Me.Enabled = False
        End If
    End Sub


    Private Sub AMI_Job_Name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles AMI_Job_Name.GotFocus
        AMI_Job_Name.Items.Clear()
        Dim myConnection As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" & Application.StartupPath & "\..\..\walter_database.mdb")
        Dim mySelectQuery As String = "SELECT Job_Name FROM Jobs"
        Dim myCommand As New OleDbCommand(mySelectQuery, myConnection)
        myConnection.Open()
        Dim myReader As OleDbDataReader
        myReader = myCommand.ExecuteReader()
        ' Always call Read before accessing data.
        While myReader.Read()
            AMI_Job_Name.Items.Add(myReader.GetValue(0)) 'AAAWWW YEEEAAAHHHH'
        End While
        ' always call Close when done reading.
        myReader.Close()
        ' Close the connection when done with it.
        myConnection.Close()
    End Sub
End Class