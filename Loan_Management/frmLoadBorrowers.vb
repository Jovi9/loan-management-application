Public Class frmLoadBorrowers

    Dim db As programCode
    Public isFromBorrower As Boolean
    Public isFromLoanInfo As Boolean

    Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnquit.Click
        Me.ActiveControl = Nothing
        Me.Close()
    End Sub

    Private Sub frmLoadBorrowers_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtsearch.Select()
        txtsearch.Clear()
        Try
            db = New programCode
            db.setDoubleBuffer(dgv_borrower)
            db.populateCombobox("collector_name", "collectors", dropCollector)
            dropCollector.SelectedIndex = 0
            db.populateBorrowerDGV(dgv_borrower, Convert.ToString(txtsearch.Text), Convert.ToString(dropCollector.Text))
        Catch ex As ArgumentOutOfRangeException

        End Try
    End Sub

    Private Sub frmLoadBorrowers_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.E Then
            txtsearch.Select()
            txtsearch.SelectAll()
        End If

        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnprint.PerformClick()
        End If

        If e.KeyCode = Keys.F5 Then
            txtsearch.Clear()
            txtsearch.Select()
            db.populateBorrowerDGV(dgv_borrower, Convert.ToString(txtsearch.Text), Convert.ToString(dropCollector.Text))
            dgv_borrower.ClearSelection()
        End If

        If e.KeyCode = Keys.Escape Then
            btnquit.PerformClick()
        End If

        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmLoadBorrowers_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        db.populateBorrowerDGV(dgv_borrower, Convert.ToString(txtsearch.Text), Convert.ToString(dropCollector.Text))
        dgv_borrower.ClearSelection()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        db.populateBorrowerDGV(dgv_borrower, Convert.ToString(txtsearch.Text), Convert.ToString(dropCollector.Text))
        dgv_borrower.ClearSelection()
    End Sub

    Private Sub dgv_borrower_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_borrower.CellDoubleClick
        Try
            If isFromBorrower = True Then
                frmBorrower.txtborrowerno.Text = dgv_borrower.CurrentRow.Cells(0).Value

            End If
            If isFromLoanInfo = True Then
                frmLoanProperties.txtborrowerno.Text = dgv_borrower.CurrentRow.Cells(0).Value
                frmLoanProperties.txtname.Text = dgv_borrower.CurrentRow.Cells(1).Value
                isFromLoanInfo = False
                frmLoanProperties.cbopayment_term.Select()
            End If
            Me.Close()
        Catch ex As NullReferenceException

        End Try
    End Sub

    Private Sub dgv_borrower_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv_borrower.CellMouseMove
        If e.RowIndex > -1 Then
            'dgvLoanList.ClearSelection()
            dgv_borrower.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(34, 42, 53)
            dgv_borrower.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        End If
    End Sub

    Private Sub dgv_borrower_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_borrower.CellMouseLeave
        If e.RowIndex > -1 Then
            'dgvLoanList.ClearSelection()
            dgv_borrower.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            dgv_borrower.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        db = New programCode
        If dropCollector.Text = "ALL" Then
            MessageBox.Show("Choose Collector.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            db.printBorrowersList(Convert.ToString(dropCollector.Text))
            frmPreviewReport.ShowDialog()
        End If
    End Sub

    Private Sub dropCollector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropCollector.SelectedIndexChanged
        db.populateBorrowerDGV(dgv_borrower, Convert.ToString(txtsearch.Text), Convert.ToString(dropCollector.Text))
        txtsearch.Select()
        txtsearch.SelectAll()
    End Sub
End Class