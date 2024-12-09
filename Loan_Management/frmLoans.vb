Public Class frmLoans
    Dim db As programCode
    Public isFromLoan As Boolean

    Private Sub deletePayment()
        If lbldateof_Payment.Text.Trim() = "" Or txtloanid.Text.Trim() = "" Then
            Exit Sub
        Else
            Dim con = MessageBox.Show("Are you sure you want to delete this payment?", "Delete Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If con = Windows.Forms.DialogResult.Yes Then
                db = New programCode
                If db.deletePayment(txtloanid, lbldateof_Payment) = True Then
                    'refresh
                Else
                    MessageBox.Show("Failed to delete payment.", "Delete Payment", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                db.getLedger(dgvLedger, txtloanid.Text)
                db.getLatestPaymentDate(txtloanid)
                db.updateLoanInfo(txtloanid)
                db.getLoanInformation_viaLoanID(txtloanid, txtborrowerID, txtreleasedate, txtduedate, txtstats, txtloanamnt, txtpaidamnt, txtbalance)
                db.getBorrowerName(txtborrowerID, txtname)

                'dgv.SelectedCells(0).Value = txtloanid.Text
                lbldateof_Payment.Text = ""
            Else
                lbldateof_Payment.Text = ""
                Exit Sub
            End If
        End If
    End Sub

    Private Sub addPayment_VIA_ORNumber()
        db = New programCode

        If txtpayday.Text.Trim() = "" Or txtloanid.Text.Trim() = "" Then
            Exit Sub
        Else
            If dateof_payment.Value < txtreleasedate.Text Then
                MessageBox.Show("Failed to add payment, payment date is out of range.", "Post Payment", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If db.paymentDate_alreadyExists(dateof_payment, txtloanid) = True Then
                    MessageBox.Show("Payment DATE already exists.", "Post Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    dateof_payment.Select()
                    Exit Sub
                Else
                    addPayment_toLedger()
                    db.getLatestPaymentDate(txtloanid)
                    db.updateLoanInfo(txtloanid)
                    db.getLoanInformation_viaLoanID(txtloanid, txtborrowerID, txtreleasedate, txtduedate, txtstats, txtloanamnt, txtpaidamnt, txtbalance)
                    db.getBorrowerName(txtborrowerID, txtname)
                    db.getLedger(dgvLedger, txtloanid.Text)
                    txtpayday.Clear()
                    txtORnumber.Clear()
                    txtpayday.Select()

                    'dgvLoanList.SelectedCells(0).Value = txtloanid.Text
                End If
            End If
        End If
    End Sub

    Private Sub addPayment_toLedger()
        db = New programCode
        If db.addPayment_toLedger(txtloanid, txtborrowerID, dateof_payment, txtpayday, txtORnumber) = True Then
            'refresh
        Else
            MessageBox.Show("Failed to add payment.", "Post Payment", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub clearFields()
        txtloanid.Clear()
        txtborrowerID.Clear()
        txtname.Clear()
        txtreleasedate.Clear()
        txtduedate.Clear()
        txtstats.Clear()
        txtloanamnt.Clear()
        txtpaidamnt.Clear()
        txtbalance.Clear()
        lbldateof_Payment.Text = ""
    End Sub

    Private Sub frmLoans_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            menuBar.Renderer = New ToolStripProfessionalRenderer(New menuCustomColor)
            db = New programCode
            clearFields()
            txtpayday.Clear()
            txtORnumber.Clear()
            txtSearchNAME.Clear()
            txtSearchNAME.Select()
            db.setDoubleBuffer(dgvLoanList)
            db.setDoubleBuffer(dgvLedger)
            db.populateCombobox("collector_name", "collectors", dropCollector)
            dropStatus.SelectedIndex = 0
            dropCollector.SelectedIndex = 0
            db.populateLoanListDGV(dgvLoanList, Convert.ToString(dropStatus.Text), Convert.ToString(dropCollector.Text), Convert.ToString(txtSearchNAME.Text), Convert.ToString(txtSearchNAME.Text))
        Catch ex As System.ArgumentOutOfRangeException

        End Try
    End Sub

    Private Sub frmLoans_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.E) Then
            txtSearchNAME.Select()
            txtSearchNAME.SelectAll()
        End If

        If e.KeyCode = Keys.Escape Then
            btnquit.PerformClick()
        End If

        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmLoans_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'LoadLoanInformation_DGV()
        db = New programCode
        db.getLedger(dgvLedger, txtloanid.Text)
        'If Not txtloanid.Text.Trim() = "" Then
        '    dgvLoanList.SelectedCells(0).Value = txtloanid.Text
        'End If
    End Sub

    Private Sub navBorrowers_Click(sender As Object, e As EventArgs) Handles navBorrowers.Click
        frmBorrower.ShowDialog()
    End Sub

    Private Sub navLoanProperties_Click(sender As Object, e As EventArgs) Handles navLoanProperties.Click
        frmLoanProperties.ShowDialog()
    End Sub

    Private Sub navRefresh_Click(sender As Object, e As EventArgs) Handles navRefresh.Click
        clearFields()
        txtpayday.Clear()
        txtORnumber.Clear()
        txtSearchNAME.Clear()
        txtSearchNAME.Select()
        dropStatus.SelectedIndex = 0
        db.populateLoanListDGV(dgvLoanList, Convert.ToString(dropStatus.Text), Convert.ToString(dropCollector.Text), Convert.ToString(txtSearchNAME.Text), Convert.ToString(txtSearchNAME.Text))
        dgvLoanList.ClearSelection()
    End Sub

    Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnquit.Click
        Me.ActiveControl = Nothing
        Me.Close()
    End Sub

    Private Sub txtSearchNAME_TextChanged(sender As Object, e As EventArgs) Handles txtSearchNAME.TextChanged
        clearFields()
        txtpayday.Clear()
        txtORnumber.Clear()
        db.populateLoanListDGV(dgvLoanList, Convert.ToString(dropStatus.Text), Convert.ToString(dropCollector.Text), Convert.ToString(txtSearchNAME.Text), Convert.ToString(txtSearchNAME.Text))
        dgvLoanList.ClearSelection()
    End Sub

    Private Sub dropStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropStatus.SelectedIndexChanged
        clearFields()
        db.populateLoanListDGV(dgvLoanList, Convert.ToString(dropStatus.Text), Convert.ToString(dropCollector.Text), Convert.ToString(txtSearchNAME.Text), Convert.ToString(txtSearchNAME.Text))
        dgvLoanList.ClearSelection()
        txtpayday.Clear()
        txtORnumber.Clear()
        txtSearchNAME.Select()
        txtSearchNAME.SelectAll()
    End Sub

    Private Sub dropCollector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropCollector.SelectedIndexChanged
        clearFields()
        db.populateLoanListDGV(dgvLoanList, Convert.ToString(dropStatus.Text), Convert.ToString(dropCollector.Text), Convert.ToString(txtSearchNAME.Text), Convert.ToString(txtSearchNAME.Text))
        dgvLoanList.ClearSelection()
        txtpayday.Clear()
        txtORnumber.Clear()
        txtSearchNAME.Select()
        txtSearchNAME.SelectAll()
    End Sub

    Private Sub dgvLoanList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoanList.CellClick
        Try
            txtloanid.Text = dgvLoanList.CurrentRow.Cells(0).Value
            txtpayday.Select()
            txtpayday.Clear()
            txtORnumber.Clear()
            lbldateof_Payment.Text = ""
        Catch ex As NullReferenceException

        End Try
    End Sub

    Private Sub dgvLoanList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoanList.CellDoubleClick
        isFromLoan = True
        frmLoanProperties.txtloanID.Text = dgvLoanList.CurrentRow.Cells(0).Value
        frmLoanProperties.ShowDialog()
    End Sub

    Private Sub dgvLoanList_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvLoanList.CellMouseMove
        If e.RowIndex > -1 Then
            'dgvLoanList.ClearSelection()
            dgvLoanList.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(34, 42, 53)
            dgvLoanList.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
        End If
    End Sub

    Private Sub dgvLoanList_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoanList.CellMouseLeave
        If e.RowIndex > -1 Then
            'dgvLoanList.ClearSelection()
            dgvLoanList.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            dgvLoanList.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub dgvLedger_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLedger.CellClick
        Try
            lbldateof_Payment.Text = Format(dgvLedger.CurrentRow.Cells(0).Value, "yyyy-MM-dd")
        Catch ex As NullReferenceException

        End Try
    End Sub

    Private Sub txtloanid_TextChanged(sender As Object, e As EventArgs) Handles txtloanid.TextChanged
        db = New programCode
        db.getLoanInformation_viaLoanID(txtloanid, txtborrowerID, txtreleasedate, txtduedate, txtstats, txtloanamnt, txtpaidamnt, txtbalance)
        db.getBorrowerName(txtborrowerID, txtname)
        db.getLedger(dgvLedger, txtloanid.Text)

    End Sub

    Private Sub txtpayday_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpayday.KeyPress
        db = New programCode
        db.onlyAcceptNumber(e)
    End Sub

    Private Sub txtpayday_TextChanged(sender As Object, e As EventArgs) Handles txtpayday.TextChanged
        lbldateof_Payment.Text = ""
    End Sub

    Private Sub txtpayday_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpayday.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.A Then
            txtpayday.Select()
            txtpayday.SelectAll()
        End If
    End Sub

    Private Sub txtORnumber_TextChanged(sender As Object, e As EventArgs) Handles txtORnumber.TextChanged
        lbldateof_Payment.Text = ""
    End Sub

    Private Sub txtORnumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtORnumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            addPayment_VIA_ORNumber()
        End If
    End Sub

    Private Sub btnDeletePayment_Click(sender As Object, e As EventArgs) Handles btnDeletePayment.Click
        deletePayment()
    End Sub

    Private Sub navPrint_Click(sender As Object, e As EventArgs) Handles navPrint.Click
        db = New programCode
        If dropCollector.Text = "ALL" Then
            MessageBox.Show("Choose Collector.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            db.printBalanceReport(dropStatus, dropCollector)
            frmPreviewReport.ShowDialog()
        End If
    End Sub

    Private Sub navPrintLedger_Click(sender As Object, e As EventArgs) Handles navPrintLedger.Click
        db = New programCode
        If dropCollector.Text = "ALL" Then
            MessageBox.Show("Choose Collector.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            db.printLedger("ALL", Convert.ToString(dropCollector.Text), "")
            frmPreviewReport.ShowDialog()
        End If
    End Sub
End Class