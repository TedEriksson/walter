Imports System.Data.OleDb

Public Class Add_Customer

    Private Sub NJ_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJ_Done.Click
        SQLWriting("INSERT INTO Customer (Customer_Name, Address1, Address2, Postcode) VALUES('" + AC_Customer_name.Text + "', '" + AC_Address1.Text + "', '" + AC_Address2.Text + "', '" + AC_Postcode.Text + "')")
        NewJob.NJ_Customer.Text = AC_Customer_name.Text
        NewJob.Enabled = True
        Me.Close()
    End Sub
End Class