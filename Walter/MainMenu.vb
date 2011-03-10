Imports System.Data.OleDb

Public Class MainMenu


    Private Sub M_Quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_Quit.Click
        walterDbConnection.Close()
        Application.Exit()
    End Sub

    Private Sub M_NewJob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_NewJob.Click
        NewJob.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Worker_hours_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Worker_hours.Click
        Daily_Form.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Material_invoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Material_invoice.Click
        Add_Material_invoice.Visible = True
        Me.Visible = False
    End Sub

    Private Sub M_EditDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles M_EditDetails.Click
        Edit_Details.Visible = True
        Me.Visible = False
    End Sub

    Private Sub MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            walterDbConnection.Open()
        Catch exc As Exception
            MsgBox("Shit just got real: " + exc.Message)
        End Try
    End Sub
End Class
