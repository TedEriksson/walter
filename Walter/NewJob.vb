Imports System.Data.OleDb, Walter.SQLStuff

Public Class NewJob

    Private Sub NJ_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJ_Cancel.Click
        MainMenu.Visible = True
        Me.Visible = False
    End Sub

    Private Sub NJ_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJ_Done.Click
        Dim CustomerText As String
        CustomerText = NJ_Customer.Text
        SQLWriting("INSERT INTO Jobs (Job_Name, CustomerID, Initial_Budget, Address1, Address2, Postcode) VALUES('" + NW_JobName.Text + "'," + SQLReading("SELECT CustomerID FROM Customer WHERE Customer_Name = '" + CustomerText + "'").ToString + ",'" + NJ_InitialBudget.Text + "','" + NJ_Address1.Text + "','" + NJ_Address2.Text + "','" + NJ_Postcode.Text + "')")
        MainMenu.Visible = True
        Me.Visible = False
    End Sub

    Private Sub NJ_Customer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NJ_Customer.GotFocus
        Populate_ComboBox(NJ_Customer, "SELECT Customer_Name FROM Customer")
        NJ_Customer.Items.Add("Add New Customer")
    End Sub

    Private Sub NJ_Customer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NJ_Customer.SelectedIndexChanged
        If NJ_Customer.Text = "Add New Customer" Then
            Add_Customer.Visible = True
            Me.Enabled = False
        End If
    End Sub
End Class