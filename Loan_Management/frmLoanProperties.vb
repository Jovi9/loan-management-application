Public Class frmLoanProperties

    Dim db As programCode
    Public addNew As Boolean
    Public updateRec As Boolean
    Public isEditing As Boolean


    Private Sub createReconstruct()
        Dim con = MessageBox.Show("Are you sure want to Reconstruct this Loan?", "Reconstruct Loan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If con = Windows.Forms.DialogResult.Yes Then
            'reconstruct na to
            db = New programCode
            db.updateLoanReconstruct(txtloanID)
            db.getIDNumber("loanid", "loan_information", txtloanID)
            getReconstruct()
            cboStatus.Text = "RC"
            saveLoan()
            db.updateDaysLeft()
            db.getLoanInformation(txtloanID, txtborrowerno, cbopayment_term, txt_duration, date_released, cbointRate, txtloanamount, txtinterest, txtreleasedamount, txttotalamount, txtduedate, txtpaidamount, txtbalance, cboStatus, txtperday, txtdaysleft)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub getReconstruct()

        Dim duration = txt_duration.Text
        Dim interest_rate As Double = Val(cbointRate.Text)
        Dim paid_amnt As Double = db.getTotalPayment(txtloanID)
        Dim balance As Double = txtbalance.Text.Replace(",", "")

        txt_duration.Text = duration

        Dim newInterestAmount, newTotalAmount, newBalance As Double
        newInterestAmount = balance * (interest_rate / 100)
        newTotalAmount = balance + newInterestAmount
        newBalance = newTotalAmount - paid_amnt

        txtloanamount.Text = Format(balance, "#,##0.00")
        txtinterest.Text = Format(Math.Abs(newInterestAmount), "#,##0.00")
        txtreleasedamount.Text = "0.00"
        txttotalamount.Text = Format(newTotalAmount, "#,##0.00")
        txtduedate.Text = Format(date_released.Value, "yyyy-MM-dd")
        txtpaidamount.Text = Format(paid_amnt, "#,##0.00")
        txtbalance.Text = Format(newBalance, "#,##0.00")
        txtperday.Text = "0.00"
    End Sub

    Private Sub updateLoan()
        db = New programCode
        If db.updateLoan(txtloanID, txtborrowerno, cbopayment_term, txt_duration, date_released, cbointRate, txtloanamount, txtinterest, txtreleasedamount, txttotalamount, txtduedate, txtpaidamount, txtbalance, txtperday, cboStatus) = True Then
            MessageBox.Show("Changes on loan have been saved successfully.", "Update Loan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to update Loan.", "Update Loan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        disableFields()
        enableCtrlButtons()
        addNew = False
        updateRec = False
        isEditing = False
    End Sub

    Private Sub saveLoan()
        db = New programCode
        If db.saveLoan(txtloanID, txtborrowerno, cbopayment_term, txt_duration, date_released, cbointRate, txtloanamount, txtinterest, txtreleasedamount, txttotalamount, txtduedate, txtpaidamount, txtbalance, txtperday, cboStatus) = True Then
            MessageBox.Show("Loan have been saved successfully.", "New Loan", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to add new Loan.", "New Loan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        disableFields()
        enableCtrlButtons()
        addNew = False
        updateRec = False
        isEditing = False
    End Sub

    Private Function aa_FieldsAreEmpty() As Boolean
        'icheck kung blanko su mga box
        If txtloanID.Text.Trim() = "" Or
            txtborrowerno.Text.Trim() = "" Or txtname.Text.Trim() = "" Or
            cbopayment_term.Text.Trim() = "" Or txt_duration.Text.Trim() = "" Or txt_duration.Text = "0" Or
            cbointRate.Text.Trim() = "" Or cbointRate.Text = "0" Or
            txtloanamount.Text.Trim() = "" Or
            txtinterest.Text.Trim() = "" Or cboStatus.Text = "" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub computeLoan()
        db = New programCode

        Dim duration As Double = Val(txt_duration.Text)
        Dim release_date As Date = date_released.Value
        Dim interest_rate As Double = Val(cbointRate.Text)
        Dim loan_amnt As Double
        Dim interest_amount As Double
        Dim released_amnt As Double
        Dim total_amnt As Double
        Dim due_date As Date
        Dim paid_amnt As Double = db.getTotalPayment(txtloanID)
        Dim balance As Double
        Dim perday As Double
        Dim numDays As Double

        If cboStatus.Text = "" Then
            clearSubField()
            Exit Sub
        End If

        If txtloanamount.Text.Trim() = "" Then
            Exit Sub
        Else
            loan_amnt = txtloanamount.Text.Replace(",", "")
            interest_amount = loan_amnt * (interest_rate / 100)

            If interest_rate = -16 Then
                released_amnt = loan_amnt - Math.Abs(interest_amount)
                total_amnt = loan_amnt
                balance = total_amnt - paid_amnt
            Else
                released_amnt = loan_amnt
                total_amnt = loan_amnt + interest_amount
                balance = total_amnt - paid_amnt
            End If

            If cbopayment_term.Text = "Daily" Then
                due_date = release_date.AddDays(duration)
            ElseIf cbopayment_term.Text = "Weekly" Then
                numDays = 7 * duration
                due_date = release_date.AddDays(numDays)
            ElseIf cbopayment_term.Text = "Monthly" Then
                due_date = release_date.AddMonths(duration)
            End If
            perday = total_amnt / duration

            'fill upan su mga textbox
            txt_duration.Text = Format(duration, "#,##0")
            txtloanamount.Text = Format(loan_amnt, "#,##0.00")
            txtinterest.Text = Format(Math.Abs(interest_amount), "#,##0.00")
            txtreleasedamount.Text = Format(released_amnt, "#,##0.00")
            txttotalamount.Text = Format(total_amnt, "#,##0.00")
            txtduedate.Text = Format(due_date, "yyyy-MM-dd")
            txtpaidamount.Text = Format(paid_amnt, "#,##0.00")
            txtbalance.Text = Format(balance, "#,##0.00")
            txtperday.Text = Format(perday, "#,##0.00")
        End If
    End Sub

    Private Sub formLoansRefresh()
        db = New programCode
        db.populateLoanListDGV(frmLoans.dgvLoanList, Convert.ToString(frmLoans.dropStatus.Text), Convert.ToString(frmLoans.dropCollector.Text), frmLoans.txtSearchNAME.Text, frmLoans.txtSearchNAME.Text)
        frmLoans.dgvLoanList.ClearSelection()
        frmLoans.clearFields()
    End Sub

    Private Sub disableFields()
        btnFindID.Enabled = False
        'txtname.Enabled = False
        cbopayment_term.Enabled = False
        txt_duration.Enabled = False
        date_released.Enabled = False
        cbointRate.Enabled = False
        txtloanamount.Enabled = False
        cboStatus.Enabled = False
        'dgvLedger.Enabled = True
    End Sub

    Private Sub enableFields()
        btnFindID.Enabled = True
        'txtname.Enabled = True
        cbopayment_term.Enabled = True
        txt_duration.Enabled = True
        date_released.Enabled = True
        cbointRate.Enabled = True
        txtloanamount.Enabled = True
        cboStatus.Enabled = True
        'dgvLedger.Enabled = False
    End Sub

    Private Sub clearFields()
        txtloanID.Clear()
        txtborrowerno.Clear()
        txtname.Clear()
        cbopayment_term.Text = ""
        txt_duration.Clear()
        'date_released.Value = Date.Now
        cbointRate.Text = ""
        txtloanamount.Clear()
        txtinterest.Clear()
        txtreleasedamount.Clear()
        txttotalamount.Clear()
        txtduedate.Clear()
        txtpaidamount.Clear()
        txtbalance.Clear()
        txtperday.Clear()
        txtdaysleft.Clear()
        cboStatus.SelectedIndex = 0
    End Sub

    Private Sub clearSubField()
        txtinterest.Clear()
        txtreleasedamount.Clear()
        txttotalamount.Clear()
        txtduedate.Clear()
        txtpaidamount.Clear()
        txtbalance.Clear()
        txtperday.Clear()
        txtdaysleft.Clear()
    End Sub

    Private Sub disableCtrlButtons()
        'btnsearch.Enabled = False
        btnnew.Enabled = False
        btnupdate.Enabled = False
        btnsave.Enabled = True
        btnCancel.Enabled = True
        If addNew = True Then
            btnReconstruct.Visible = False
        Else
            btnReconstruct.Visible = True
        End If
        btnprint.Enabled = False
        btnDelete.Enabled = False
        btnquit.Enabled = False

    End Sub

    Private Sub enableCtrlButtons()
        'btnsearch.Enabled = True
        btnnew.Enabled = True
        btnupdate.Enabled = True
        btnsave.Enabled = False
        btnCancel.Enabled = False
        btnReconstruct.Visible = False
        btnprint.Enabled = True
        btnDelete.Enabled = True
        btnquit.Enabled = True
    End Sub

    Private Sub frmLoanProperties_Load(sender As Object, e As EventArgs) Handles Me.Load
        db = New programCode
        db.populateCombobox("interest_rate", "interestrate", cbointRate)
    End Sub

    Private Sub frmLoanProperties_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.E) Then
            If isEditing = True And updateRec = True Then
                btnFindID.Enabled = False
            ElseIf isEditing = True And updateRec = False Then
                btnFindID.Enabled = True
                btnFindID.PerformClick()
            Else
                Exit Sub
            End If
        End If

        If (e.Control AndAlso e.KeyCode = Keys.N) Then
            btnnew.PerformClick()
        End If

        If (e.Control AndAlso e.KeyCode = Keys.U) Then
            btnupdate.PerformClick()
        End If

        If (e.Control AndAlso e.KeyCode = Keys.S) Then
            btnsave.PerformClick()
        End If

        If (e.KeyCode = Keys.Escape) Then
            If isEditing = True Then
                btnCancel.PerformClick()
            Else
                btnquit.PerformClick()
            End If
        End If

        If (e.KeyCode = Keys.P) Then
            btnprint.PerformClick()
        End If

        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnquit.Click
        Me.ActiveControl = Nothing
        clearFields()
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtloanID.Text.Trim() = "" Or txtborrowerno.Text.Trim() = "" Or txtname.Text.Trim() = "" Then
            Exit Sub
        Else
            Dim con = MessageBox.Show("Are you sure you want to delete this Loan?", "Delete Loan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If con = DialogResult.Yes Then
                frmDeleteFromLoan_Ledger.loanid = txtloanID.Text
                frmDeleteFromLoan_Ledger.borrowerid = txtborrowerno.Text
                frmDeleteFromLoan_Ledger.fullname = txtname.Text
                frmDeleteFromLoan_Ledger.dor = date_released.Value
                frmDeleteFromLoan_Ledger.ShowDialog()
                clearFields()
                formLoansRefresh()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        addNew = True
        updateRec = False
        isEditing = True
        cboStatus.Text = "AA"

        clearFields()
        enableFields()
        disableCtrlButtons()
        txtname.Select()
        db = New programCode
        db.getIDNumber("loanid", "loan_information", txtloanID)
    End Sub

    Private Sub btnFindID_Click(sender As Object, e As EventArgs) Handles btnFindID.Click
        Me.ActiveControl = Nothing
        frmLoadBorrowers.isFromLoanInfo = True
        frmLoadBorrowers.ShowDialog()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtborrowerno.Text.Trim() = "" Or txtloanID.Text.Trim() = "" Then
            MessageBox.Show("Please select a valid Record.", "Loan Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            addNew = False
            updateRec = True
            isEditing = True

            enableFields()
            disableCtrlButtons()
            btnFindID.Enabled = False
            txtname.Select()
        End If
    End Sub

    Private Sub btnReconstruct_Click(sender As Object, e As EventArgs) Handles btnReconstruct.Click
        If cbointRate.Text = "-16" Then
            Exit Sub
        Else
            createReconstruct()
            formLoansRefresh()
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        db = New programCode
        If addNew = True And updateRec = False Then
            'ssave REAC
            If cboStatus.Text.Trim() = "" Then
                MessageBox.Show("Please select a valid Loan Status.", "Loan Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cboStatus.Select()
                cboStatus.SelectAll()
                Exit Sub
            Else
                If cboStatus.Text = "AA" Or cboStatus.Text = "RC" Then
                    If aa_FieldsAreEmpty() = True Then
                        MessageBox.Show("All fields must not be empty.", "Loan Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        computeLoan()
                        saveLoan()
                        db.updateDaysLeft()
                        db.updateLoanStatus_DUENOW()
                        db.updateLoanStatus_PD()
                        db.getLoanInformation(txtloanID, txtborrowerno, cbopayment_term, txt_duration, date_released, cbointRate, txtloanamount, txtinterest, txtreleasedamount, txttotalamount, txtduedate, txtpaidamount, txtbalance, cboStatus, txtperday, txtdaysleft)
                        formLoansRefresh()
                    End If
                ElseIf cboStatus.Text = "CA" Then
                    MessageBox.Show("Warning: You do not have clearance for this operation.", "Loan Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Please select a valid Loan Status.", "Loan Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cboStatus.Select()
                    cboStatus.SelectAll()
                End If
                'MessageBox.Show("New Record Inserted")
            End If
        ElseIf addNew = False And updateRec = True Then
            'UPDATE rec
            If cboStatus.Text.Trim() = "" Then
                MessageBox.Show("Please select a valid Loan Status.", "Loan Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cboStatus.Select()
                cboStatus.SelectAll()
                Exit Sub
            Else
                If cboStatus.Text = "AA" Then
                    If aa_FieldsAreEmpty() = True Then
                        MessageBox.Show("All fields must not be empty.", "Loan Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        computeLoan()
                        updateLoan()
                        db.updateDaysLeft()
                        db.updateLoanStatus_DUENOW()
                        db.updateLoanStatus_PD()
                        db.getLoanInformation(txtloanID, txtborrowerno, cbopayment_term, txt_duration, date_released, cbointRate, txtloanamount, txtinterest, txtreleasedamount, txttotalamount, txtduedate, txtpaidamount, txtbalance, cboStatus, txtperday, txtdaysleft)
                        formLoansRefresh()
                    End If
                ElseIf cboStatus.Text = "CA" Then
                    If txt_duration.Text.Trim() = "" Then
                        txt_duration.Text = 0
                    End If
                    updateLoan()
                    db.updateDaysLeft()
                    db.updateLoanStatus_DUENOW()
                    db.updateLoanStatus_PD()
                    db.getLoanInformation(txtloanID, txtborrowerno, cbopayment_term, txt_duration, date_released, cbointRate, txtloanamount, txtinterest, txtreleasedamount, txttotalamount, txtduedate, txtpaidamount, txtbalance, cboStatus, txtperday, txtdaysleft)
                    formLoansRefresh()
                ElseIf cboStatus.Text = "RC" Then
                    MessageBox.Show("Warning: You do not have clearance for this operation. Instead, please use the Reconstruct button.", "Loan Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Please select a valid Loan Status.", "Loan Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    cboStatus.Select()
                    cboStatus.SelectAll()
                End If
            End If
            'MessageBox.Show("Record has been Updated")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        db = New programCode
        If addNew = True Or updateRec = False Then
            clearFields()
            disableFields()
            enableCtrlButtons()
            addNew = False
            updateRec = False
            isEditing = False
        ElseIf addNew = False And updateRec = True Then
            db.getLoanInformation(txtloanID, txtborrowerno, cbopayment_term, txt_duration, date_released, cbointRate, txtloanamount, txtinterest, txtreleasedamount, txttotalamount, txtduedate, txtpaidamount, txtbalance, cboStatus, txtperday, txtdaysleft)
            disableFields()
            enableCtrlButtons()
            addNew = False
            updateRec = False
            isEditing = False
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        db = New programCode
        If txtloanID.Text.Trim() = "" Then
            MessageBox.Show("No Record Selected.", "Print Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            db.printLedger("INDIVIDUAL", "", Convert.ToString(txtloanID.Text))
            frmPreviewReport.ShowDialog()
        End If
    End Sub

    Private Sub txt_duration_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_duration.KeyPress
        db = New programCode
        db.onlyAcceptNumber(e)
    End Sub

    Private Sub txt_duration_TextChanged(sender As Object, e As EventArgs) Handles txt_duration.TextChanged
        If isEditing = True Then
            If txt_duration.Text = "100" Then
                cbointRate.Text = "-16"
                cbointRate.Enabled = True
            ElseIf txt_duration.Text = "55" Or txt_duration.Text = "40" Then
                cbointRate.Text = "10"
                cbointRate.Enabled = False
            ElseIf txt_duration.Text = "58" Then
                cbointRate.Text = "16"
                cbointRate.Enabled = False
            Else
                cbointRate.Text = ""
                cbointRate.Enabled = True
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub txt_duration_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_duration.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.A Then
            txt_duration.Select()
            txt_duration.SelectAll()
        End If
    End Sub

    Private Sub txtloanamount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtloanamount.KeyPress
        db = New programCode
        db.onlyAcceptNumber(e)
    End Sub

    Private Sub txtloanamount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtloanamount.KeyDown
        If e.KeyCode = Keys.Enter Then
            'compute payment
            computeLoan()
        ElseIf e.Control AndAlso e.KeyCode = Keys.A Then
            txtloanamount.Select()
            txtloanamount.SelectAll()
        End If
    End Sub

    Private Sub txtloanID_TextChanged(sender As Object, e As EventArgs) Handles txtloanID.TextChanged
        If frmLoans.isFromLoan = True Then
            db = New programCode
            db.getLoanInformation(txtloanID, txtborrowerno, cbopayment_term, txt_duration, date_released, cbointRate, txtloanamount, txtinterest, txtreleasedamount, txttotalamount, txtduedate, txtpaidamount, txtbalance, cboStatus, txtperday, txtdaysleft)
            db.getBorrowerName_LI(txtborrowerno, txtname)
            frmLoans.isFromLoan = False
        End If
    End Sub


End Class