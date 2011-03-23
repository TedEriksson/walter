Public Class Login

    Private Sub WalterStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WalterStart.Click
        If L_P.Text = SQLReading("SELECT Pass FROM Options") Then
            MainMenu.Enabled = True
            Me.Close()
        Else
            MsgBox("Incorrect Password!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Quit.Click
        Application.Exit()
    End Sub
End Class