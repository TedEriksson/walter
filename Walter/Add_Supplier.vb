Imports System.Data.OleDb
Public Class Add_Supplier

    Private Sub AS_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AS_Done.Click
        SQLWriting("INSERT INTO Supplier (Supplier_Name, Address1, Address2, Postcode) VALUES('" + AS_Supplier_name.Text + "', '" + AS_Address1.Text + "', '" + AS_Address2.Text + "', '" + AS_Postcode.Text + "')")
        Add_Material_invoice.ADM_Supplier_Name.Text = AS_Supplier_name.Text
        Add_Material_invoice.Enabled = True
        Me.Close()
    End Sub

    Private Sub AS_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AS_Cancel.Click
        Add_Material_invoice.Enabled = True
        Me.Visible = False
    End Sub
End Class