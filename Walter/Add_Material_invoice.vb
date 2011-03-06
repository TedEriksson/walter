Imports System.Data.OleDb, Walter.SQLStuff
Public Class Add_Material_invoice

    Private Sub ADM_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADM_Cancel.Click
        MainMenu.Visible = True
        Me.Visible = False
    End Sub

    Private Sub ADM_Supplier_Name_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ADM_Supplier_Name.GotFocus
        Populate_ComboBox(ADM_Supplier_Name, "SELECT Supplier_Name FROM Supplier")
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
        Populate_ComboBox(AMI_Job_Name, "SELECT Job_Name FROM Jobs")
    End Sub
End Class