Public Class frmLogin


    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        Dim success As Boolean
        success = login(txtUsername.Text, txtPassword.Text)
        If success = True Then
            frmHome.Enabled = True
            Me.Close()
        Else

        End If
    End Sub
End Class