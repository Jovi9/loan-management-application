Public Class frmLogin

    Dim db As programCode

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Dim usern As String = txtusername.Text
        Dim pass As String = txtpassword.Text

        If usern.Trim = "" And pass = "" Then
            lblemptyuser.Visible = True
            lblemptypass.Visible = True
            txtusername.Select()
            txtusername.SelectAll()
        ElseIf usern.Trim() = "" And Not pass = "" Then
            lblemptyuser.Visible = True
            txtusername.Select()
            txtusername.SelectAll()
        ElseIf Not usern.Trim() = "" And pass = "" Then
            lblemptypass.Visible = True
            txtpassword.Select()
            txtpassword.SelectAll()
        Else
            btnlogin.Text = "Verifying..."
            db = New programCode
            If db.login_Credentials(usern, pass) = True Then
                frmMain.Show()
                Me.Close()
            Else
                MessageBox.Show("Login Denied: Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                btnlogin.Text = "Login"
                txtusername.Select()
                txtusername.SelectAll()
            End If
        End If
    End Sub

    Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnquit.Click
        Me.ActiveControl = Nothing
        Application.Exit()
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        lblemptyuser.Visible = False
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        lblemptypass.Visible = False
    End Sub

End Class