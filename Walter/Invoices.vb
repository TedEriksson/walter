﻿Public Class Invoices
    Private Sub I_N_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles I_N.GotFocus
        Dim table As String
        If I_Type.Text = "Job" Then
            table = "Jobs"
        Else
            table = I_Type.Text
        End If
        If I_Type.Text = "Job" Or I_Type.Text = "Worker" Or I_Type.Text = "Supplier" Then Populate_ComboBox(I_N, "SELECT " + I_Type.Text + "_Name FROM " & table)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Create Invoice
    End Sub

    Private Sub I_Back_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles I_Back.Click
        MainMenu.Visible = True
        Me.Close()
    End Sub

    Private Sub I_Type_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles I_Type.SelectedIndexChanged
        I_N.Text = ""
    End Sub
End Class