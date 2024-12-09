Public Class frmBorrower

    Dim db As programCode
    Dim addNew As Boolean
    Dim updateRec As Boolean
    Dim isEditing As Boolean

    Private Sub disableFields()
        txtname.Enabled = False
        txtname.Enabled = False
        txtAddress.Enabled = False
        droparea.Enabled = False
        txtcontact.Enabled = False
        dropcollector.Enabled = False
    End Sub

    Private Sub enableFields()
        txtname.Enabled = True
        txtname.Enabled = True
        txtAddress.Enabled = True
        droparea.Enabled = True
        txtcontact.Enabled = True
        dropcollector.Enabled = True
    End Sub

    Private Sub clearFields()
        txtborrowerno.Clear()
        txtname.Clear()
        txtname.Clear()
        txtAddress.Clear()
        droparea.Text = ""
        txtcontact.Clear()
        dropcollector.Text = ""
    End Sub

    Private Sub disableCtrlBtns()
        btnquit.Enabled = False
        btnsearch.Enabled = False
        btnnew.Enabled = False
        btnupdate.Enabled = False
        btnsave.Enabled = True
        btnCancel.Enabled = True
    End Sub

    Private Sub enableCtrlBtns()
        btnquit.Enabled = True
        btnsearch.Enabled = True
        btnnew.Enabled = True
        btnupdate.Enabled = True
        btnsave.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Private Sub saveBorrower()
        If txtborrowerno.Text.Trim() = "" Or txtname.Text.Trim() = "" Or dropcollector.Text.Trim() = "" Then
            MessageBox.Show("Fields with (*) are required.", "New Borrower", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            db = New programCode

            If db.saveBorrower(Convert.ToString(txtborrowerno.Text), Convert.ToString(txtname.Text), Convert.ToString(txtAddress.Text), Convert.ToString(droparea.Text), Convert.ToString(txtcontact.Text), Convert.ToString(dropcollector.Text)) = True Then
                MessageBox.Show("New Borrower have been saved successfully.", "New Borrower", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to add new Borrower.", "New Borrower", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            disableFields()
            enableCtrlBtns()
            addNew = False
            updateRec = False
            isEditing = False
        End If
    End Sub

    Private Sub updateBorrower()
        If txtborrowerno.Text.Trim() = "" Or txtname.Text.Trim() = "" Or dropcollector.Text.Trim() = "" Then
            MessageBox.Show("Fields with (*) are required.", "Update Borrower", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            db = New programCode

            If db.updateBorrower(Convert.ToString(txtborrowerno.Text), Convert.ToString(txtname.Text), Convert.ToString(txtAddress.Text), Convert.ToString(droparea.Text), Convert.ToString(txtcontact.Text), Convert.ToString(dropcollector.Text)) = True Then
                MessageBox.Show("Changes on borrower have been saved successfully.", "Update Borrower", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to update Borrower.", "Update Borrower", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            disableFields()
            enableCtrlBtns()
            addNew = False
            updateRec = False
            isEditing = False
        End If
    End Sub

    Private Sub frmBorrower_Load(sender As Object, e As EventArgs) Handles Me.Load
        clearFields()
        db = New programCode
        db.populateCombobox("areaname", "areas", droparea)
        db.populateCombobox("collector_name", "collectors", dropcollector)
        droparea.Items.RemoveAt(0)
        dropcollector.Items.RemoveAt(0)
    End Sub

    Private Sub frmBorrower_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.Control AndAlso e.KeyCode = Keys.E) Then
            btnsearch.PerformClick()
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

        If (e.KeyCode = Keys.F12) Then
            If isEditing = True Then
                MessageBox.Show("Please save the record first.", "Borrowers Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf txtname.Text.Trim() = "" Then
                MessageBox.Show("Error: Failed to parse data.", "Borrowers Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db = New programCode
                'pass data to form
                'disable unnecessary buttons
                frmLoanProperties.addNew = True
                frmLoanProperties.isEditing = True
                frmLoanProperties.btnDelete.Enabled = False
                frmLoanProperties.btnnew.Enabled = False
                frmLoanProperties.btnupdate.Enabled = False
                frmLoanProperties.btnsave.Enabled = True
                frmLoanProperties.btnCancel.Enabled = True
                frmLoanProperties.btnprint.Enabled = False
                frmLoanProperties.btnquit.Enabled = False
                frmLoanProperties.cbopayment_term.Enabled = True
                frmLoanProperties.txt_duration.Enabled = True
                frmLoanProperties.date_released.Enabled = True
                frmLoanProperties.cbointRate.Enabled = True
                frmLoanProperties.txtloanamount.Enabled = True
                frmLoanProperties.cboStatus.Enabled = True
                frmLoanProperties.txtborrowerno.Text = txtborrowerno.Text
                frmLoanProperties.txtname.Text = txtname.Text
                db.getIDNumber("loanid", "loan_information", frmLoanProperties.txtloanID)

                frmLoanProperties.ShowDialog()
            End If
        End If

        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Me.ActiveControl = Nothing
        frmLoadBorrowers.isFromBorrower = True
        frmLoadBorrowers.ShowDialog()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        addNew = True
        updateRec = False
        isEditing = True

        'Dim datenow As String = Format(Date.Now, "yyyyMMddhmmss")
        clearFields()
        enableFields()
        disableCtrlBtns()
        db = New programCode
        db.getIDNumber("borrowerid", "borrowers_information", txtborrowerno)
        txtname.Select()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtborrowerno.Text.Trim() = "" Or txtname.Text.Trim() = "" Then
            MessageBox.Show("Please select a valid Record.", "Borrowers Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            addNew = False
            updateRec = True
            isEditing = True

            enableFields()
            disableCtrlBtns()
            txtname.Select()
            txtname.SelectAll()
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If addNew = True Then
            'save borrower
            saveBorrower()
        Else
            'Update borrower
            updateBorrower()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        db = New programCode
        If addNew = True Or updateRec = False Then
            clearFields()
            disableFields()
            enableCtrlBtns()
            addNew = False
            updateRec = False
            isEditing = False
        ElseIf addNew = False And updateRec = True Then
            db.getBorrowerInformation(Convert.ToString(txtborrowerno.Text), txtname, txtAddress, droparea, txtcontact, dropcollector)
            disableFields()
            enableCtrlBtns()
            addNew = False
            updateRec = False
            isEditing = False
        Else
            Exit Sub
        End If

    End Sub

    Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnquit.Click
        clearFields()
        Me.ActiveControl = Nothing
        Me.Close()
    End Sub

    Private Sub txtborrowerno_TextChanged(sender As Object, e As EventArgs) Handles txtborrowerno.TextChanged
        If frmLoadBorrowers.isFromBorrower = True Then
            db.getBorrowerInformation(Convert.ToString(txtborrowerno.Text), txtname, txtAddress, droparea, txtcontact, dropcollector)
            frmLoadBorrowers.isFromBorrower = False
        End If
    End Sub
End Class