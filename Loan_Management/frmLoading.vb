Public Class frmLoading

    Private Sub frmLoading_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim gp As New System.Drawing.Drawing2D.GraphicsPath

        Dim chgcorn As Integer = 110

        Dim r1 As New Rectangle(0, Me.Height - chgcorn, chgcorn, chgcorn)
        Dim r2 As New Rectangle(Me.Width - chgcorn + 1, Me.Height - chgcorn, chgcorn, chgcorn)

        'creating the upper Arc
        gp.AddArc(0, 0, chgcorn, chgcorn, 180, 90)
        gp.AddArc(Me.Width - chgcorn + 1, 0, chgcorn, chgcorn, 270, 90)

        'Creating the Body
        gp.AddRectangle(New Rectangle(0, chgcorn / 2, Me.Width, Me.Height - chgcorn))

        'creating the lower Arc
        gp.AddArc(r1, -270, 90)
        gp.AddArc(r2, 360, 90)

        Region = New Region(gp)

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick

        progressBar.Increment(1)
        If progressBar.Value = 2 Then
            Dim db = New programCode
            db.updateDaysLeft()
            db.updateLoanStatus_DUENOW()
            db.updateLoanStatus_PD()
            'MessageBox.Show("UPDATE SUCCESS")
        End If

    End Sub

    Private Sub frmLoading_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub
End Class
