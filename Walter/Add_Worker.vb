Public Class Add_Worker
    Private Sub AW_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AW_Done.Click
        SQLWriting("INSERT INTO Worker(Worker_Name, Address1, Address2, Postcode, Hourly_Rate) VALUES('" + AW_Worker_name.Text + "', '" + AW_Address1.Text + "', '" + AW_Address2.Text + "', '" + AW_Postcode.Text + "', " + AW_HR.Text + ")")
        Daily_Form.DF_Worker.Text = AW_Worker_name.Text
        Daily_Form.Enabled = True
        Me.Close()
    End Sub

    Private Sub AW_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AW_Cancel.Click
        Daily_Form.Enabled = True
        Me.Close()
    End Sub
End Class