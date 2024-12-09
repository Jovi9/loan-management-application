Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class programCode : Inherits database

    Public com As MySqlCommand
    Public reader As MySqlDataReader

    Public Sub printLedger(ByRef opt As String, ByVal collector As String, ByVal loanid As String)
        Dim adapter As New MySqlDataAdapter
        Dim dataSet As New DataSet
        Dim printQuery As String = ""

        If opt = "ALL" Then
            printQuery = "select * from borrowers_information inner join loan_information on borrowers_information.borrowerid = loan_information.borrowerid inner join loan_ledger on loan_information.loanid = loan_ledger.loanid where borrowers_information.collector=@collector and not loan_information.loan_status='CA' order by borrowers_information._area, borrowers_information.fullname, loan_information.release_date, loan_information.loan_status, loan_information.loanid, loan_ledger.payment_date"
        ElseIf opt = "INDIVIDUAL" Then
            printQuery = "select * from borrowers_information inner join loan_information on borrowers_information.borrowerid = loan_information.borrowerid inner join loan_ledger on loan_information.loanid = loan_ledger.loanid where loan_information.loanid=@loanid order by loan_ledger.payment_date"
        Else
            Exit Sub
        End If
        ' where loan_information.loanid='00000000235'
        Try
            openConnection()
            com = New MySqlCommand(printQuery, getDBCon)
            com.Parameters.Add("@collector", MySqlDbType.VarChar).Value = collector
            com.Parameters.Add("@loanid", MySqlDbType.VarChar).Value = loanid
            adapter.SelectCommand = com
            adapter.Fill(dataSet, "borrowers_information")

            Dim report As New rptLedgerHistory

            report.SetDataSource(dataSet)
            frmPreviewReport.reportBalance.ReportSource = report
            frmPreviewReport.reportBalance.Refresh()
            frmPreviewReport.reportBalance.Zoom(75)

            com.Dispose()
            adapter.Dispose()
            dataSet.Dispose()
            closeConnection()
        Catch ex As Exception
            closeConnection()
        End Try
    End Sub

    Public Sub printBorrowersList(ByVal collector As String)
        Dim adapter As New MySqlDataAdapter
        Dim dataSet As New DataSet

        Dim printQuery As String = "select * from borrowers_information where collector=@collector order by _area, fullname"

        Try
            openConnection()
            com = New MySqlCommand(printQuery, getDBCon)
            com.Parameters.Add("@collector", MySqlDbType.VarChar).Value = collector
            adapter.SelectCommand = com
            adapter.Fill(dataSet, "borrowers_information")

            Dim report As New rptBorrowersList
            Dim txtCust As CrystalDecisions.CrystalReports.Engine.TextObject

            txtCust = report.ReportDefinition.ReportObjects("crCustomer")
            txtCust.Text = collector & " Customers"

            report.SetDataSource(dataSet)
            frmPreviewReport.reportBalance.ReportSource = report
            frmPreviewReport.reportBalance.Refresh()
            frmPreviewReport.reportBalance.Zoom(2)

            com.Dispose()
            adapter.Dispose()
            dataSet.Dispose()
            closeConnection()
        Catch ex As Exception
            closeConnection()
        End Try
    End Sub

    Public Sub printBalanceReport(ByVal loan_status As ComboBox, ByVal collector As ComboBox)
        Dim adapter As New MySqlDataAdapter
        Dim dataSet As New DataSet
        Dim printQuery As String = ""

        If loan_status.Text = "ALL" Then
            printQuery = "select * from borrowers_information inner join loan_information on borrowers_information.borrowerid = loan_information.borrowerid where not loan_status='CA' and collector=@collector order by _area, fullname, release_date, loan_status, loanid"
        Else
            printQuery = "select * from borrowers_information inner join loan_information on borrowers_information.borrowerid = loan_information.borrowerid where loan_status=@loan_status and collector=@collector order by _area, fullname, release_date, loan_status, loanid"
        End If

        Try
            openConnection()
            com = New MySqlCommand(printQuery, getDBCon)
            com.Parameters.Add("@loan_status", MySqlDbType.VarChar).Value = loan_status.Text
            com.Parameters.Add("@collector", MySqlDbType.VarChar).Value = collector.Text
            adapter.SelectCommand = com
            adapter.Fill(dataSet, "borrowers_information")

            Dim report As New rptBalanceSummary
            Dim txtCust As CrystalDecisions.CrystalReports.Engine.TextObject
            txtCust = report.ReportDefinition.ReportObjects("crCustomer")
            txtCust.Text = collector.Text & " Customers"
            report.SetDataSource(dataSet)
            frmPreviewReport.reportBalance.ReportSource = report
            frmPreviewReport.reportBalance.Refresh()
            frmPreviewReport.reportBalance.Zoom(2)

            com.Dispose()
            adapter.Dispose()
            dataSet.Dispose()
            closeConnection()

        Catch ex As Exception
            closeConnection()
        End Try
    End Sub

    Public Sub updateLoanReconstruct(ByVal txtloanID As TextBox)
        Dim exex As String = "update loan_information set loan_status=@status where loanid=@id"
        com = New MySqlCommand(exex, getDBCon)
        openConnection()
        com.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtloanID.Text
        com.Parameters.Add("@status", MySqlDbType.VarChar).Value = "CA"
        com.ExecuteNonQuery()
        closeConnection()
    End Sub

    Public Sub getLoanInformation(ByVal txtloanID As TextBox, ByVal txtborrowerno As TextBox, ByVal cbopayment_term As ComboBox, ByVal txt_duration As TextBox, ByVal date_released As DateTimePicker, ByVal cbointRate As ComboBox,
                                  ByVal txtloanamount As TextBox, ByVal txtinterest As TextBox, ByVal txtreleasedamount As TextBox, ByVal txttotalamount As TextBox,
                                  ByVal txtduedate As TextBox, ByVal txtpaidamount As TextBox, ByVal txtbalance As TextBox, ByVal cboStatus As ComboBox,
                                  ByVal txtperday As TextBox, ByVal txtdaysleft As TextBox)
        'ikua su loan info gamit ang loan id sa dgv
        Try
            openConnection()
            Dim exex As String = "select borrowerid,loan_type,duration,release_date,interest_rate,loan_amnt,interest_amnt,released_amnt,total_amnt,due_date,paid_amnt,balance,loan_status,perday,days_left from loan_information where loanid=@loanid"
            com = New MySqlCommand(exex, getDBCon)
            com.Parameters.Add("@loanid", MySqlDbType.VarChar).Value = txtloanID.Text
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                txtborrowerno.Text = reader(0)
                cbopayment_term.Text = reader(1)
                txt_duration.Text = reader(2)
                date_released.Value = Format(reader(3), "yyyy-MMM-dd")
                cbointRate.Text = reader(4)
                txtloanamount.Text = Format(reader(5), "#,##0.00")
                txtinterest.Text = Format(reader(6), "#,##0.00")
                txtreleasedamount.Text = Format(reader(7), "#,##0.00")
                txttotalamount.Text = Format(reader(8), "#,##0.00")
                txtduedate.Text = Format(reader(9), "yyyy-MM-dd")
                txtpaidamount.Text = Format(reader(10), "#,##0.00")
                txtbalance.Text = Format(reader(11), "#,##0.00")
                cboStatus.Text = reader(12)
                txtperday.Text = Format(reader(13), "#,##0.00")
                txtdaysleft.Text = reader(14)
            End If
        Catch ex As Exception
        Finally
            com.Dispose()
            reader.Close()
            closeConnection()
        End Try
    End Sub

    Public Function updateLoan(ByVal txtloanID As TextBox, ByVal txtborrowerno As TextBox, ByVal cbopayment_term As ComboBox, ByVal txt_duration As TextBox,
                             ByVal date_released As DateTimePicker, ByVal cbointRate As ComboBox, ByVal txtloanamount As TextBox, ByVal txtinterest As TextBox,
                             ByVal txtreleasedamount As TextBox, ByVal txttotalamount As TextBox, ByVal txtduedate As TextBox, ByVal txtpaidamount As TextBox,
                             ByVal txtbalance As TextBox, ByVal txtperday As TextBox, ByVal loan_status As ComboBox) As Boolean
        Dim exex As String = "update loan_information set borrowerid=@borrowerid,loan_type=@loan_type,duration=@duration,release_date=@release_date,interest_rate=@interest_rate,loan_amnt=@loan_amnt,interest_amnt=@interest_amnt,released_amnt=@released_amnt,total_amnt=@total_amnt,due_date=@due_date,paid_amnt=@paid_amnt,balance=@balance,perday=@perday,loan_status=@loan_status where loanid=@loanid"
        com = New MySqlCommand(exex, getDBCon)
        With com
            .Parameters.Add("@loanid", MySqlDbType.VarChar).Value = txtloanID.Text
            .Parameters.Add("@borrowerid", MySqlDbType.VarChar).Value = txtborrowerno.Text
            .Parameters.Add("@loan_type", MySqlDbType.VarChar).Value = cbopayment_term.Text
            .Parameters.Add("@duration", MySqlDbType.Double).Value = txt_duration.Text
            .Parameters.Add("@release_date", MySqlDbType.Date).Value = Format(date_released.Value, "yyyy-MM-dd")
            .Parameters.Add("@interest_rate", MySqlDbType.Double).Value = cbointRate.Text
            .Parameters.Add("@loan_amnt", MySqlDbType.Double).Value = txtloanamount.Text.Replace(",", "")
            .Parameters.Add("@interest_amnt", MySqlDbType.Double).Value = txtinterest.Text.Replace(",", "")
            .Parameters.Add("@released_amnt", MySqlDbType.Double).Value = txtreleasedamount.Text.Replace(",", "")
            .Parameters.Add("@total_amnt", MySqlDbType.Double).Value = txttotalamount.Text.Replace(",", "")
            .Parameters.Add("@due_date", MySqlDbType.Date).Value = txtduedate.Text
            .Parameters.Add("@paid_amnt", MySqlDbType.Double).Value = txtpaidamount.Text.Replace(",", "")
            .Parameters.Add("@balance", MySqlDbType.Double).Value = txtbalance.Text.Replace(",", "")
            'com.Parameters.Add("@last_payment_date",MySqlDbType.Date).Value=
            .Parameters.Add("@perday", MySqlDbType.Double).Value = txtperday.Text.Replace(",", "")
            .Parameters.Add("@loan_status", MySqlDbType.VarChar).Value = loan_status.Text
        End With

        openConnection()
        If com.ExecuteNonQuery = 1 Then
            Return True
        Else
            Return False
        End If
        closeConnection()

    End Function

    Public Function saveLoan(ByVal txtloanID As TextBox, ByVal txtborrowerno As TextBox, ByVal cbopayment_term As ComboBox, ByVal txt_duration As TextBox,
                             ByVal date_released As DateTimePicker, ByVal cbointRate As ComboBox, ByVal txtloanamount As TextBox, ByVal txtinterest As TextBox,
                             ByVal txtreleasedamount As TextBox, ByVal txttotalamount As TextBox, ByVal txtduedate As TextBox, ByVal txtpaidamount As TextBox,
                             ByVal txtbalance As TextBox, ByVal txtperday As TextBox, ByVal loan_status As ComboBox) As Boolean
        Dim exex As String = "insert into loan_information (loanid,borrowerid,loan_type,duration,release_date,interest_rate,loan_amnt,interest_amnt,released_amnt,total_amnt,due_date,paid_amnt,balance,perday,loan_status) values (@loanid,@borrowerid,@loan_type,@duration,@release_date,@interest_rate,@loan_amnt,@interest_amnt,@released_amnt,@total_amnt,@due_date,@paid_amnt,@balance,@perday,@loan_status)"
        com = New MySqlCommand(exex, getDBCon)
        With com
            .Parameters.Add("@loanid", MySqlDbType.VarChar).Value = txtloanID.Text
            .Parameters.Add("@borrowerid", MySqlDbType.VarChar).Value = txtborrowerno.Text
            .Parameters.Add("@loan_type", MySqlDbType.VarChar).Value = cbopayment_term.Text
            .Parameters.Add("@duration", MySqlDbType.Double).Value = txt_duration.Text
            .Parameters.Add("@release_date", MySqlDbType.Date).Value = Format(date_released.Value, "yyyy-MM-dd")
            .Parameters.Add("@interest_rate", MySqlDbType.Double).Value = cbointRate.Text
            .Parameters.Add("@loan_amnt", MySqlDbType.Double).Value = txtloanamount.Text.Replace(",", "")
            .Parameters.Add("@interest_amnt", MySqlDbType.Double).Value = txtinterest.Text.Replace(",", "")
            .Parameters.Add("@released_amnt", MySqlDbType.Double).Value = txtreleasedamount.Text.Replace(",", "")
            .Parameters.Add("@total_amnt", MySqlDbType.Double).Value = txttotalamount.Text.Replace(",", "")
            .Parameters.Add("@due_date", MySqlDbType.Date).Value = txtduedate.Text
            .Parameters.Add("@paid_amnt", MySqlDbType.Double).Value = txtpaidamount.Text.Replace(",", "")
            .Parameters.Add("@balance", MySqlDbType.Double).Value = txtbalance.Text.Replace(",", "")
            'com.Parameters.Add("@last_payment_date",MySqlDbType.Date).Value=
            .Parameters.Add("@perday", MySqlDbType.Double).Value = txtperday.Text.Replace(",", "")
            .Parameters.Add("@loan_status", MySqlDbType.VarChar).Value = loan_status.Text
        End With

        openConnection()
        If com.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If
        closeConnection()

    End Function

    Public Sub getBorrowerName_LI(ByVal txtborrowerno As TextBox, ByVal txtname As TextBox)
        'ikua su pangalan gamit su borrower id, sa loan info
        Try
            openConnection()
            Dim exex As String = "select fullname from borrowers_information where borrowerid=@borrowerid"
            com = New MySqlCommand(exex, getDBCon)
            com.Parameters.Add("@borrowerid", MySqlDbType.VarChar).Value = txtborrowerno.Text
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                txtname.Text = reader(0)
            End If
        Catch ex As Exception
        Finally
            com.Dispose()
            reader.Close()
            closeConnection()
        End Try
    End Sub

    'delete payment
    Public Function deletePayment(ByVal txtloanid As TextBox, ByVal lbldateof_Payment As Label) As Boolean
        Dim exex As String = "delete from loan_ledger where loanid=@id and payment_date=@date"
        com = New MySqlCommand(exex, getDBCon)
        With com
            .Parameters.Add("@id", MySqlDbType.VarChar).Value = txtloanid.Text
            .Parameters.Add("@date", MySqlDbType.Date).Value = lbldateof_Payment.Text
        End With

        openConnection()
        If com.ExecuteNonQuery() = 1 Then
            'delete
            Return True
        Else
            MessageBox.Show("Failed to delete payment.", "Delete Payment", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        closeConnection()
    End Function

    'check if payment date exists
    Public Function paymentDate_alreadyExists(ByVal dateof_payment As DateTimePicker, ByVal txtloanid As TextBox) As Boolean
        Try
            openConnection()
            com = New MySqlCommand("", getDBCon)
            With com
                .CommandText = "select * from loan_ledger where payment_date=@pdate and loanid=@id"
                .Parameters.Add("@pdate", MySqlDbType.Date).Value = Format(dateof_payment.Value, "yyyy-MM-dd")
                .Parameters.Add("@id", MySqlDbType.VarChar).Value = txtloanid.Text
            End With
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                Return True
                'messagebox payment day already exists
                'exit sub
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        Finally
            com.Dispose()
            reader.Close()
            closeConnection()
        End Try
    End Function

    '   update loan paid amnt, balance, last payment date
    Public Function updateLoanInfo(ByVal txtloanid As TextBox) As Boolean
        Dim semi_total As Double = getTotalPayment(txtloanid)
        Dim semi_balance As Double = getTotalBalance(txtloanid)
        Dim lastPDate As Date = getLatestPaymentDate(txtloanid)
        Try
            com = New MySqlCommand("", getDBCon)
            With com
                .CommandText = "update loan_information set paid_amnt=@paid_amnt,balance=@balance,last_payment_date=@lpdate where loanid=@id"
                .Parameters.Add("@id", MySqlDbType.VarChar).Value = txtloanid.Text
                .Parameters.Add("@paid_amnt", MySqlDbType.Double).Value = semi_total
                .Parameters.Add("@balance", MySqlDbType.Double).Value = semi_balance
                .Parameters.Add("@lpdate", MySqlDbType.Date).Value = Format(lastPDate, "yyyy-MM-dd")
            End With

            openConnection()
            If com.ExecuteNonQuery() = 1 Then
                'update
                Return True
            Else
                MessageBox.Show("Failed to update payment.", "Post Payment", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
            closeConnection()

        Catch ex As Exception
            Return False
        Finally
            com.Dispose()
            closeConnection()
        End Try
    End Function

    Public Function getTotalBalance(ByVal id As TextBox) As Double
        Dim totalB As Double = 0
        Dim totalp As Double = getTotalPayment(id)
        Dim exex As String = "select (total_amnt - @totalP) as totalBal from loan_information where loanid=@id"
        com = New MySqlCommand(exex, getDBCon)
        com.Parameters.Add("@id", MySqlDbType.VarChar).Value = id.Text
        com.Parameters.AddWithValue("@totalP", totalp)

        openConnection()
        totalB = com.ExecuteScalar
        closeConnection()

        Return totalB
    End Function

    Public Function getTotalPayment(ByVal id As TextBox) As Double
        Dim totalP As Double = 0

        Dim exex As String = "select sum(payed_amnt) as TotalPayment from loan_ledger where loanid=@id"
        com = New MySqlCommand(exex, getDBCon)
        com.Parameters.Add("@id", MySqlDbType.VarChar).Value = id.Text

        openConnection()
        Try
            totalP = com.ExecuteScalar()
        Catch ex As InvalidCastException
            totalP = 0
        End Try
        closeConnection()

        Return totalP

    End Function

    Public Function getLatestPaymentDate(ByVal txtloanid As TextBox) As Date
        Dim lastPdate As Date
        Try
            Dim exex As String = "select payment_date from loan_ledger where loanid=@id order by payment_date desc"
            com = New MySqlCommand(exex, getDBCon)
            com.Parameters.Add("@id", MySqlDbType.VarChar).Value = txtloanid.Text

            openConnection()
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                lastPdate = Format(reader(0), "yyyy-MM-dd")
            End If
        Catch ex As Exception
        Finally
            com.Dispose()
            reader.Close()
            closeConnection()
        End Try
        Return lastPdate
    End Function

    Public Function addPayment_toLedger(ByVal txtloanid As TextBox, ByVal txtborrowerID As TextBox, ByVal dateof_payment As DateTimePicker, ByVal txtpayday As TextBox, ByVal txtORnumber As TextBox) As Boolean
        Try
            com = New MySqlCommand("", getDBCon)
            With com
                .CommandText = "insert into loan_ledger (loanid,borrowerid,payment_date,payed_amnt,or_no) values (@loanid,@borrowerid,@payment_date,@payed_amnt,@or_no)"
                .Parameters.Add("@loanid", MySqlDbType.VarChar).Value = txtloanid.Text
                .Parameters.Add("@borrowerid", MySqlDbType.VarChar).Value = txtborrowerID.Text
                .Parameters.Add("@payment_date", MySqlDbType.Date).Value = Format(dateof_payment.Value, "yyyy-MM-dd")
                .Parameters.Add("@payed_amnt", MySqlDbType.Double).Value = txtpayday.Text
                .Parameters.Add("@or_no", MySqlDbType.VarChar).Value = txtORnumber.Text
            End With

            openConnection()
            If com.ExecuteNonQuery() = 1 Then
                'refresh
                Return True
            Else
                Return False
            End If
            closeConnection()

        Catch ex As Exception
            Return False
        Finally
            com.Dispose()
            closeConnection()
        End Try
    End Function

    Public Function onlyAcceptNumber(e As KeyPressEventArgs)
        'number sana sa textbox
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
        Return 0
    End Function

    '   populate ledger payment history
    Public Sub getLedger(ByVal dgv As DataGridView, ByVal id As String)
        Try
            openConnection()
            Dim ex As String = "select payment_date,payed_amnt,or_no,perday from loan_ledger as ll, loan_information as li where ll.loanid=@loanid and li.loanid=@loanid order by payment_date desc"
            com = New MySqlCommand(ex, getDBCon)
            com.Parameters.Add("@loanid", MySqlDbType.VarChar).Value = id
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()
            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1), reader(2), reader(3))
                'dgv.Rows.Add(Format(db.reader(0), "yyyy-MMM-dd"), Format(db.reader(1), "#,##0.00"), db.reader(2), Format(db.reader(3), "#,##0.00"), Format(db.reader(4), "#,##0.00"), db.reader(5))
            Loop

        Catch ex As Exception
        Finally
            com.Dispose()
            reader.Close()
            closeConnection()
        End Try
    End Sub

    '   get borrowername in form loans
    Public Sub getBorrowerName(ByVal borrowerID As TextBox, ByVal txtname As TextBox)
        Try
            openConnection()
            Dim exex As String = "select fullname from borrowers_information where borrowerid=@id"
            com = New MySqlCommand(exex, getDBCon)
            com.Parameters.Add("@id", MySqlDbType.VarChar).Value = borrowerID.Text
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                txtname.Text = reader(0)
            Else
                Exit Sub
            End If
        Catch ex As Exception
        Finally
            com.Dispose()
            reader.Close()
            closeConnection()
        End Try
    End Sub

    '   getloan info using loan ID
    Public Sub getLoanInformation_viaLoanID(ByVal loanid As TextBox, ByVal txtborrowerID As TextBox, ByVal txtreleasedate As TextBox, ByVal txtduedate As TextBox, ByVal txtstats As TextBox, ByVal txtloanamnt As TextBox, ByVal txtpaidamnt As TextBox, ByVal txtbalance As TextBox)
        Try
            openConnection()
            Dim exex As String = "select loanid,borrowerid,release_date,due_date,loan_status,loan_amnt,paid_amnt,balance,perday,days_left from loan_information where loanid=@loanid"
            com = New MySqlCommand(exex, getDBCon)
            com.Parameters.Add("@loanid", MySqlDbType.VarChar).Value = loanid.Text

            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                loanid.Text = reader(0)
                txtborrowerID.Text = reader(1)
                txtreleasedate.Text = Format(reader(2), "yyyy-MMM-dd")
                txtduedate.Text = Format(reader(3), "yyyy-MMM-dd")
                txtstats.Text = reader(4)
                txtloanamnt.Text = Format(reader(5), "#,##0.00")
                txtpaidamnt.Text = Format(reader(6), "#,##0.00")
                txtbalance.Text = Format(reader(7), "#,##0.00")
            Else
                Exit Sub
            End If

        Catch ex As Exception
        Finally
            com.Dispose()
            reader.Close()
            closeConnection()
        End Try
    End Sub

    '   populate loan list dg in loans form
    Public Sub populateLoanListDGV(ByVal dgvLoanList As DataGridView, ByVal loan_Status As String, ByVal collector As String, ByVal search As String, ByVal loanid As String)
        Try
            openConnection()
            Dim ex As String = ""
            If loan_Status = "ALL" And collector = "ALL" Then
                ex = "select loanid,loan_status,fullname,loan_type,duration,release_date,interest_rate,loan_amnt,perday,collector from loan_information as li, borrowers_information as bi where not loan_status='CA' and li.borrowerid=bi.borrowerid and (fullname like @fullname or loanid like @loanid) order by fullname, release_date, loan_status, loanid"
            ElseIf loan_Status = "ALL" And Not collector = "ALL" Then
                ex = "select loanid,loan_status,fullname,loan_type,duration,release_date,interest_rate,loan_amnt,perday,collector from loan_information as li, borrowers_information as bi where not loan_status='CA' and collector=@collector and li.borrowerid=bi.borrowerid and (fullname like @fullname or loanid like @loanid) order by fullname, release_date, loan_status, loanid"
            ElseIf Not loan_Status = "ALL" And collector = "ALL" Then
                ex = "select loanid,loan_status,fullname,loan_type,duration,release_date,interest_rate,loan_amnt,perday,collector from loan_information as li, borrowers_information as bi where loan_status=@loan_status and li.borrowerid=bi.borrowerid and (fullname like @fullname or loanid like @loanid) order by fullname, release_date, loan_status, loanid"
            Else
                ex = "select loanid,loan_status,fullname,loan_type,duration,release_date,interest_rate,loan_amnt,perday,collector from loan_information as li, borrowers_information as bi where li.borrowerid=bi.borrowerid and loan_status=@loan_status and collector=@collector and (fullname like @fullname or loanid like @loanid) order by fullname, release_date, loan_status, loanid"
            End If
            com = New MySqlCommand(ex, getDBCon)
            With com
                .Parameters.Add("@loanid", MySqlDbType.VarChar).Value = "%" & loanid & "%"
                .Parameters.Add("@fullname", MySqlDbType.VarChar).Value = "%" & search & "%"
                .Parameters.Add("@loan_status", MySqlDbType.VarChar).Value = loan_Status
                .Parameters.Add("@collector", MySqlDbType.VarChar).Value = collector
            End With

            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgvLoanList.Rows.Clear()
            Do While reader.Read = True
                dgvLoanList.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), reader(6), reader(7), reader(8), reader(9))
                'dgv.Rows.Add(db.reader(0), db.reader(1), db.reader(2), db.reader(3), db.reader(4), Format(db.reader(5), "yyyy-MMM-dd"), db.reader(6), Format(db.reader(7), "#,##0.00"), Format(db.reader(8), "yyyy-MMM-dd"), Format(db.reader(9), "#,##0.00"))
            Loop

        Catch ex As Exception
        Finally
            com.Dispose()
            reader.Close()
            closeConnection()
        End Try
    End Sub

    '   populate borrowers datagrid
    Public Sub populateBorrowerDGV(ByVal dgv As DataGridView, ByVal search As String, ByVal collector As String)
        Try
            openConnection()
            Dim ex As String
            If collector = "ALL" Then
                ex = "select borrowerid,fullname,concat(address, ', ', _area) as address, contact_no,collector from borrowers_information where fullname like @fullname order by collector, _area, fullname"
            Else
                ex = "select borrowerid,fullname,concat(address, ', ', _area) as address, contact_no,collector from borrowers_information where fullname like @fullname and collector=@collector order by collector, _area, fullname"
            End If
            com = New MySqlCommand(ex, getDBCon)
            com.Parameters.Add("@fullname", MySqlDbType.VarChar).Value = "%" & search & "%"
            com.Parameters.Add("@collector", MySqlDbType.VarChar).Value = collector

            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            dgv.Rows.Clear()

            Do While reader.Read = True
                dgv.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4))
            Loop

        Catch ex As Exception
            dgv.Rows.Clear()
        Finally
            com.Dispose()
            reader.Close()
            closeConnection()
        End Try

    End Sub

    Public Sub setDoubleBuffer(ByVal control As DataGridView)
        GetType(Control).InvokeMember("DoubleBuffered", BindingFlags.SetProperty Or BindingFlags.Instance Or BindingFlags.NonPublic, Nothing, control, New Object() {True})
    End Sub

    '   populate fields of borrower information
    Public Sub getBorrowerInformation(ByVal borrowerid As String, ByVal fullname As TextBox, ByVal address As TextBox, ByVal area As ComboBox, ByVal contact As MaskedTextBox, ByVal collector As ComboBox)
        Try
            openConnection()
            Dim exex As String = "select fullname,address,_area,contact_no,collector from borrowers_information where borrowerid=@borrowerid"
            com = New MySqlCommand(exex, getDBCon)
            com.Parameters.Add("@borrowerid", MySqlDbType.VarChar).Value = borrowerid
            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                fullname.Text = reader(0)
                address.Text = reader(1)
                area.Text = reader(2)
                contact.Text = reader(3)
                collector.Text = reader(4)
            End If
        Catch ex As Exception
        Finally
            com.Dispose()
            reader.Close()
            closeConnection()
        End Try
    End Sub

    '   update borrower info
    Public Function updateBorrower(ByVal borrowerid As String, ByVal fullname As String, ByVal address As String, ByVal area As String, ByVal contact As String, ByVal collector As String) As Boolean

        Dim ex As String = "update borrowers_information set fullname=@fullname,address=@address,_area=@_area,contact_no=@contact_no,collector=@collector where borrowerid=@borrowerid"
        com = New MySqlCommand(ex, getDBCon)
        With com
            .Parameters.Add("@borrowerid", MySqlDbType.VarChar).Value = borrowerid
            .Parameters.Add("@fullname", MySqlDbType.VarChar).Value = fullname
            .Parameters.Add("@address", MySqlDbType.VarChar).Value = address
            .Parameters.Add("@_area", MySqlDbType.VarChar).Value = area
            .Parameters.Add("@contact_no", MySqlDbType.VarChar).Value = contact
            .Parameters.Add("@collector", MySqlDbType.VarChar).Value = collector
        End With

        openConnection()
        If com.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

    End Function

    '   save borrower information
    Public Function saveBorrower(ByVal borrowerid As String, ByVal fullname As String, ByVal address As String, ByVal area As String, ByVal contact As String, ByVal collector As String) As Boolean

        Dim ex As String = "insert into borrowers_information (borrowerid,fullname,address,_area,contact_no,collector)" &
                                "values (@borrowerid,@fullname,@address,@_area,@contact_no,@collector)"
        com = New MySqlCommand(ex, getDBCon)
        With com
            .Parameters.Add("@borrowerid", MySqlDbType.VarChar).Value = borrowerid
            .Parameters.Add("@fullname", MySqlDbType.VarChar).Value = fullname
            .Parameters.Add("@address", MySqlDbType.VarChar).Value = address
            .Parameters.Add("@_area", MySqlDbType.VarChar).Value = area
            .Parameters.Add("@contact_no", MySqlDbType.VarChar).Value = contact
            .Parameters.Add("@collector", MySqlDbType.VarChar).Value = collector
        End With

        openConnection()
        If com.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If
        closeConnection()

    End Function

    '   populate combobox from database
    Public Sub populateCombobox(ByVal colname As String, ByVal tblname As String, ByVal cbo As ComboBox)
        Try
            openConnection()
            Dim ex As String = $"select {colname} from {tblname} order by {colname}"
            com = New MySqlCommand(ex, getDBCon)

            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            cbo.Items.Clear()
            cbo.Items.Add("ALL")
            Do While reader.Read = True
                cbo.Items.Add(reader(colname))
            Loop

        Catch ex As Exception

        Finally
            com.Dispose()
            reader.Close()
            closeConnection()
        End Try
    End Sub

    '   generate loan id and borrowerid
    Public Sub getIDNumber(ByVal colname As String, ByVal tblname As String, ByVal id As TextBox)
        Dim cust_id As String
        Try
            openConnection()
            Dim ex As String = $"select {colname} from {tblname} order by {colname} desc"
            com = New MySqlCommand(ex, getDBCon)

            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                cust_id = Val(reader(0)) + 1
                id.Text = cust_id.ToString().PadLeft(11, "0")
            Else
                id.Text = "00000000001"

            End If
        Catch ex As Exception
        Finally
            com.Dispose()
            reader.Close()
            closeConnection()
        End Try

    End Sub

    '   login form
    Public Function login_Credentials(ByVal user As String, ByVal pass As String) As Boolean
        Dim strUser As String
        Try
            openConnection()
            Dim ex As String = "select username,userpass,fullname,role from user_accounts where username=@user and userpass=sha1(@pass)"
            com = New MySqlCommand(ex, getDBCon())
            com.Parameters.Add("@user", MySqlDbType.VarChar).Value = user
            com.Parameters.Add("@pass", MySqlDbType.Blob).Value = pass

            reader = com.ExecuteReader(CommandBehavior.CloseConnection)
            If reader.Read = True Then
                strUser = "User: " & reader(0)
                frmMain.lblSessionname.Text = strUser.ToString
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        Finally
            com.Dispose()
            reader.Close()
            closeConnection()
        End Try
    End Function

    '   update days remaining until due date
    Public Sub updateDaysLeft()
        Dim exex As String = "update loan_information set days_left=datediff(due_date, current_date()) where not loan_status=@status"
        ' where not loan_status='CA' and not loan_status='RC'
        com = New MySqlCommand(exex, getDBCon)
        com.Parameters.Add("@status", MySqlDbType.VarChar).Value = "CA"

        openConnection()
        com.ExecuteNonQuery()
        closeConnection()
    End Sub

    '   update loan status PD
    Public Sub updateLoanStatus_PD()
        Dim exex As String = "update loan_information set loan_status=@status where datediff(due_date, current_date())<0 and not loan_status='CA' and not loan_status='RC'"
        com = New MySqlCommand(exex, getDBCon)
        com.Parameters.Add("@status", MySqlDbType.VarChar).Value = "PD"

        openConnection()
        com.ExecuteNonQuery()
        closeConnection()
    End Sub

    '   update loan status due date now
    Public Sub updateLoanStatus_DUENOW()
        Dim exex As String = "update loan_information set loan_status=@status where datediff(due_date, current_date())=0 and not loan_status='CA' and not loan_status='RC'"
        com = New MySqlCommand(exex, getDBCon)

        com.Parameters.Add("@status", MySqlDbType.VarChar).Value = "DUE"

        openConnection()
        com.ExecuteNonQuery()
        closeConnection()
    End Sub

End Class
