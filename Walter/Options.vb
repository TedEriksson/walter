Imports System.IO

Public Class Options

    Private Sub O_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O_Back.Click
        MainMenu.Visible = True
        Me.Close()
    End Sub

    Private Sub O_Set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles O_Set.Click
        If O_P1.Text = O_P2.Text And O_P1.Text <> "" Then
            Using writer As StreamWriter = New StreamWriter("Options.txt")
                writer.Write(O_P1.Text)
            End Using
            MsgBox("Password Changed")
        Else
            MsgBox("Please Make sure the passwords are the same!")
        End If
    End Sub
End Class