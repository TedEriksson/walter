Imports System.Data.OleDb

Public Class Options

    Private Sub O_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O_Back.Click
        MainMenu.Visible = True
        Me.Close()
    End Sub

    Private Sub O_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O_Set.Click
        Dim pass As String
        pass = O_P1.Text
        If O_P1.Text = O_P2.Text And O_P1.Text <> "" Then

            SQLWritingLogin("UPDATE Options SET Pass='" + pass + "' WHERE User ='Admin'")
            MsgBox("Password Changed")
        Else
            MsgBox("Please Make sure the passwords are the same!")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WalterAbout.Visible = True
    End Sub

    Private Sub O_Backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O_Backup.Click
        Dim dlg As SaveFileDialog = New SaveFileDialog
        dlg.OverwritePrompt = True
        dlg.FileName = "walter_database.mdb"
        'dlg.ShowDialog()
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileCopy(Application.StartupPath & "\..\..\Resources\walter_database.mdb", dlg.FileName)
        End If

    End Sub

    Private Sub O_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O_Delete.Click
        SQLWriting("DELETE * FROM Customer")
        SQLWriting("DELETE * FROM Jobs")
        SQLWriting("DELETE * FROM Worker")
        SQLWriting("DELETE * FROM Supplier")
        SQLWriting("DELETE * FROM supplier_outgoings")
        SQLWriting("DELETE * FROM Workers_hours")
    End Sub
End Class