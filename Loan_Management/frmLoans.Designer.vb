<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoans
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoans))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.lblHeadername = New System.Windows.Forms.Label()
        Me.pnlBox = New System.Windows.Forms.Panel()
        Me.lbldateof_Payment = New System.Windows.Forms.Label()
        Me.btnDeletePayment = New System.Windows.Forms.Button()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.dropCollector = New System.Windows.Forms.ComboBox()
        Me.dropStatus = New System.Windows.Forms.ComboBox()
        Me.txtSearchNAME = New System.Windows.Forms.TextBox()
        Me.lblSearchname = New System.Windows.Forms.Label()
        Me.grpPostpayment = New System.Windows.Forms.GroupBox()
        Me.lblEntertoPost = New System.Windows.Forms.Label()
        Me.txtORnumber = New System.Windows.Forms.TextBox()
        Me.lblORNumber = New System.Windows.Forms.Label()
        Me.txtpayday = New System.Windows.Forms.TextBox()
        Me.lblamnt = New System.Windows.Forms.Label()
        Me.dateof_payment = New System.Windows.Forms.DateTimePicker()
        Me.lblDateofPayment = New System.Windows.Forms.Label()
        Me.grpLoanInfo = New System.Windows.Forms.GroupBox()
        Me.txtborrowerID = New System.Windows.Forms.TextBox()
        Me.lblbalance = New System.Windows.Forms.Label()
        Me.txtbalance = New System.Windows.Forms.TextBox()
        Me.lblpaidAMnt = New System.Windows.Forms.Label()
        Me.txtpaidamnt = New System.Windows.Forms.TextBox()
        Me.lblloanamount = New System.Windows.Forms.Label()
        Me.txtloanamnt = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtstats = New System.Windows.Forms.TextBox()
        Me.lblReleaseDAte = New System.Windows.Forms.Label()
        Me.txtreleasedate = New System.Windows.Forms.TextBox()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.txtduedate = New System.Windows.Forms.TextBox()
        Me.txtloanid = New System.Windows.Forms.TextBox()
        Me.lblloanid = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.dgvLoanList = New System.Windows.Forms.DataGridView()
        Me.loanid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loan_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.duration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.release_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.interest_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loan_amnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.perday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCollector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvLedger = New System.Windows.Forms.DataGridView()
        Me.paymentdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amountpaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ornumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menuBar = New System.Windows.Forms.MenuStrip()
        Me.manageToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.navBorrowers = New System.Windows.Forms.ToolStripMenuItem()
        Me.navLoanProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.navRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.navPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.navPrintLedger = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlBox.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        Me.grpPostpayment.SuspendLayout()
        Me.grpLoanInfo.SuspendLayout()
        CType(Me.dgvLoanList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLedger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnquit)
        Me.pnlHeader.Controls.Add(Me.lblHeadername)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.ForeColor = System.Drawing.Color.White
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1300, 50)
        Me.pnlHeader.TabIndex = 130
        '
        'btnquit
        '
        Me.btnquit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnquit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnquit.FlatAppearance.BorderSize = 0
        Me.btnquit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquit.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnquit.Location = New System.Drawing.Point(1244, 0)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(56, 50)
        Me.btnquit.TabIndex = 17
        Me.btnquit.TabStop = False
        Me.btnquit.Text = "r"
        Me.btnquit.UseVisualStyleBackColor = True
        '
        'lblHeadername
        '
        Me.lblHeadername.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblHeadername.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadername.Location = New System.Drawing.Point(0, 0)
        Me.lblHeadername.Name = "lblHeadername"
        Me.lblHeadername.Size = New System.Drawing.Size(157, 50)
        Me.lblHeadername.TabIndex = 4
        Me.lblHeadername.Text = "Loans"
        Me.lblHeadername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlBox
        '
        Me.pnlBox.BackColor = System.Drawing.Color.DarkGray
        Me.pnlBox.Controls.Add(Me.lbldateof_Payment)
        Me.pnlBox.Controls.Add(Me.btnDeletePayment)
        Me.pnlBox.Controls.Add(Me.grpSearch)
        Me.pnlBox.Controls.Add(Me.grpPostpayment)
        Me.pnlBox.Controls.Add(Me.grpLoanInfo)
        Me.pnlBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBox.Location = New System.Drawing.Point(0, 78)
        Me.pnlBox.Name = "pnlBox"
        Me.pnlBox.Size = New System.Drawing.Size(1300, 270)
        Me.pnlBox.TabIndex = 131
        '
        'lbldateof_Payment
        '
        Me.lbldateof_Payment.AutoSize = True
        Me.lbldateof_Payment.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldateof_Payment.Location = New System.Drawing.Point(895, 216)
        Me.lbldateof_Payment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldateof_Payment.Name = "lbldateof_Payment"
        Me.lbldateof_Payment.Size = New System.Drawing.Size(0, 20)
        Me.lbldateof_Payment.TabIndex = 129
        '
        'btnDeletePayment
        '
        Me.btnDeletePayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnDeletePayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeletePayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnDeletePayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnDeletePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletePayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletePayment.ForeColor = System.Drawing.Color.White
        Me.btnDeletePayment.Location = New System.Drawing.Point(1163, 211)
        Me.btnDeletePayment.Name = "btnDeletePayment"
        Me.btnDeletePayment.Size = New System.Drawing.Size(119, 40)
        Me.btnDeletePayment.TabIndex = 14
        Me.btnDeletePayment.TabStop = False
        Me.btnDeletePayment.Text = "Delete"
        Me.btnDeletePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeletePayment.UseVisualStyleBackColor = False
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.dropCollector)
        Me.grpSearch.Controls.Add(Me.dropStatus)
        Me.grpSearch.Controls.Add(Me.txtSearchNAME)
        Me.grpSearch.Controls.Add(Me.lblSearchname)
        Me.grpSearch.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.Location = New System.Drawing.Point(15, 181)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(860, 80)
        Me.grpSearch.TabIndex = 129
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search Loan"
        '
        'dropCollector
        '
        Me.dropCollector.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dropCollector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropCollector.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropCollector.FormattingEnabled = True
        Me.dropCollector.Location = New System.Drawing.Point(637, 31)
        Me.dropCollector.Margin = New System.Windows.Forms.Padding(4)
        Me.dropCollector.Name = "dropCollector"
        Me.dropCollector.Size = New System.Drawing.Size(188, 30)
        Me.dropCollector.TabIndex = 2
        '
        'dropStatus
        '
        Me.dropStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dropStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropStatus.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropStatus.FormattingEnabled = True
        Me.dropStatus.Items.AddRange(New Object() {"ALL", "AA", "DUE", "PD", "RC", "CA"})
        Me.dropStatus.Location = New System.Drawing.Point(534, 31)
        Me.dropStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.dropStatus.Name = "dropStatus"
        Me.dropStatus.Size = New System.Drawing.Size(75, 30)
        Me.dropStatus.TabIndex = 1
        '
        'txtSearchNAME
        '
        Me.txtSearchNAME.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSearchNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchNAME.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearchNAME.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchNAME.Location = New System.Drawing.Point(169, 33)
        Me.txtSearchNAME.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchNAME.Name = "txtSearchNAME"
        Me.txtSearchNAME.Size = New System.Drawing.Size(338, 28)
        Me.txtSearchNAME.TabIndex = 0
        '
        'lblSearchname
        '
        Me.lblSearchname.AutoSize = True
        Me.lblSearchname.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchname.Location = New System.Drawing.Point(21, 40)
        Me.lblSearchname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchname.Name = "lblSearchname"
        Me.lblSearchname.Size = New System.Drawing.Size(123, 18)
        Me.lblSearchname.TabIndex = 125
        Me.lblSearchname.Text = "Search Name:"
        '
        'grpPostpayment
        '
        Me.grpPostpayment.Controls.Add(Me.lblEntertoPost)
        Me.grpPostpayment.Controls.Add(Me.txtORnumber)
        Me.grpPostpayment.Controls.Add(Me.lblORNumber)
        Me.grpPostpayment.Controls.Add(Me.txtpayday)
        Me.grpPostpayment.Controls.Add(Me.lblamnt)
        Me.grpPostpayment.Controls.Add(Me.dateof_payment)
        Me.grpPostpayment.Controls.Add(Me.lblDateofPayment)
        Me.grpPostpayment.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPostpayment.Location = New System.Drawing.Point(882, 6)
        Me.grpPostpayment.Name = "grpPostpayment"
        Me.grpPostpayment.Size = New System.Drawing.Size(400, 170)
        Me.grpPostpayment.TabIndex = 124
        Me.grpPostpayment.TabStop = False
        Me.grpPostpayment.Text = "Post Payment"
        '
        'lblEntertoPost
        '
        Me.lblEntertoPost.AutoSize = True
        Me.lblEntertoPost.Font = New System.Drawing.Font("Verdana", 7.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntertoPost.ForeColor = System.Drawing.Color.Black
        Me.lblEntertoPost.Location = New System.Drawing.Point(181, 137)
        Me.lblEntertoPost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEntertoPost.Name = "lblEntertoPost"
        Me.lblEntertoPost.Size = New System.Drawing.Size(160, 14)
        Me.lblEntertoPost.TabIndex = 128
        Me.lblEntertoPost.Text = "(press ENTER to POST)"
        '
        'txtORnumber
        '
        Me.txtORnumber.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtORnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtORnumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtORnumber.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORnumber.Location = New System.Drawing.Point(175, 105)
        Me.txtORnumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtORnumber.Name = "txtORnumber"
        Me.txtORnumber.Size = New System.Drawing.Size(180, 28)
        Me.txtORnumber.TabIndex = 5
        '
        'lblORNumber
        '
        Me.lblORNumber.AutoSize = True
        Me.lblORNumber.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblORNumber.Location = New System.Drawing.Point(81, 109)
        Me.lblORNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblORNumber.Name = "lblORNumber"
        Me.lblORNumber.Size = New System.Drawing.Size(81, 20)
        Me.lblORNumber.TabIndex = 127
        Me.lblORNumber.Text = "OR No.:"
        '
        'txtpayday
        '
        Me.txtpayday.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtpayday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpayday.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpayday.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpayday.Location = New System.Drawing.Point(175, 69)
        Me.txtpayday.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpayday.Name = "txtpayday"
        Me.txtpayday.Size = New System.Drawing.Size(180, 28)
        Me.txtpayday.TabIndex = 4
        '
        'lblamnt
        '
        Me.lblamnt.AutoSize = True
        Me.lblamnt.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamnt.Location = New System.Drawing.Point(71, 73)
        Me.lblamnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblamnt.Name = "lblamnt"
        Me.lblamnt.Size = New System.Drawing.Size(91, 20)
        Me.lblamnt.TabIndex = 125
        Me.lblamnt.Text = "Amount:"
        '
        'dateof_payment
        '
        Me.dateof_payment.CustomFormat = "yyyy-MMM-dd"
        Me.dateof_payment.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateof_payment.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateof_payment.Location = New System.Drawing.Point(175, 36)
        Me.dateof_payment.Name = "dateof_payment"
        Me.dateof_payment.Size = New System.Drawing.Size(200, 26)
        Me.dateof_payment.TabIndex = 3
        '
        'lblDateofPayment
        '
        Me.lblDateofPayment.AutoSize = True
        Me.lblDateofPayment.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateofPayment.Location = New System.Drawing.Point(13, 40)
        Me.lblDateofPayment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateofPayment.Name = "lblDateofPayment"
        Me.lblDateofPayment.Size = New System.Drawing.Size(149, 20)
        Me.lblDateofPayment.TabIndex = 107
        Me.lblDateofPayment.Text = "Payment Date:"
        '
        'grpLoanInfo
        '
        Me.grpLoanInfo.Controls.Add(Me.txtborrowerID)
        Me.grpLoanInfo.Controls.Add(Me.lblbalance)
        Me.grpLoanInfo.Controls.Add(Me.txtbalance)
        Me.grpLoanInfo.Controls.Add(Me.lblpaidAMnt)
        Me.grpLoanInfo.Controls.Add(Me.txtpaidamnt)
        Me.grpLoanInfo.Controls.Add(Me.lblloanamount)
        Me.grpLoanInfo.Controls.Add(Me.txtloanamnt)
        Me.grpLoanInfo.Controls.Add(Me.lblStatus)
        Me.grpLoanInfo.Controls.Add(Me.txtstats)
        Me.grpLoanInfo.Controls.Add(Me.lblReleaseDAte)
        Me.grpLoanInfo.Controls.Add(Me.txtreleasedate)
        Me.grpLoanInfo.Controls.Add(Me.lblDueDate)
        Me.grpLoanInfo.Controls.Add(Me.txtduedate)
        Me.grpLoanInfo.Controls.Add(Me.txtloanid)
        Me.grpLoanInfo.Controls.Add(Me.lblloanid)
        Me.grpLoanInfo.Controls.Add(Me.txtname)
        Me.grpLoanInfo.Controls.Add(Me.lblname)
        Me.grpLoanInfo.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLoanInfo.Location = New System.Drawing.Point(15, 6)
        Me.grpLoanInfo.Name = "grpLoanInfo"
        Me.grpLoanInfo.Size = New System.Drawing.Size(860, 170)
        Me.grpLoanInfo.TabIndex = 0
        Me.grpLoanInfo.TabStop = False
        Me.grpLoanInfo.Text = "Information"
        '
        'txtborrowerID
        '
        Me.txtborrowerID.Location = New System.Drawing.Point(347, 26)
        Me.txtborrowerID.Name = "txtborrowerID"
        Me.txtborrowerID.Size = New System.Drawing.Size(100, 28)
        Me.txtborrowerID.TabIndex = 18
        Me.txtborrowerID.TabStop = False
        Me.txtborrowerID.Visible = False
        '
        'lblbalance
        '
        Me.lblbalance.AutoSize = True
        Me.lblbalance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbalance.Location = New System.Drawing.Point(490, 134)
        Me.lblbalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(77, 18)
        Me.lblbalance.TabIndex = 119
        Me.lblbalance.Text = "Balance:"
        '
        'txtbalance
        '
        Me.txtbalance.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtbalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbalance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbalance.Location = New System.Drawing.Point(637, 130)
        Me.txtbalance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.ReadOnly = True
        Me.txtbalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtbalance.Size = New System.Drawing.Size(188, 26)
        Me.txtbalance.TabIndex = 13
        Me.txtbalance.TabStop = False
        Me.txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblpaidAMnt
        '
        Me.lblpaidAMnt.AutoSize = True
        Me.lblpaidAMnt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaidAMnt.Location = New System.Drawing.Point(490, 100)
        Me.lblpaidAMnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpaidAMnt.Name = "lblpaidAMnt"
        Me.lblpaidAMnt.Size = New System.Drawing.Size(119, 18)
        Me.lblpaidAMnt.TabIndex = 117
        Me.lblpaidAMnt.Text = "Paid Amount:"
        '
        'txtpaidamnt
        '
        Me.txtpaidamnt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtpaidamnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpaidamnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpaidamnt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaidamnt.Location = New System.Drawing.Point(637, 96)
        Me.txtpaidamnt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpaidamnt.Name = "txtpaidamnt"
        Me.txtpaidamnt.ReadOnly = True
        Me.txtpaidamnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtpaidamnt.Size = New System.Drawing.Size(188, 26)
        Me.txtpaidamnt.TabIndex = 12
        Me.txtpaidamnt.TabStop = False
        Me.txtpaidamnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblloanamount
        '
        Me.lblloanamount.AutoSize = True
        Me.lblloanamount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloanamount.Location = New System.Drawing.Point(490, 66)
        Me.lblloanamount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblloanamount.Name = "lblloanamount"
        Me.lblloanamount.Size = New System.Drawing.Size(124, 18)
        Me.lblloanamount.TabIndex = 115
        Me.lblloanamount.Text = "Loan Amount:"
        '
        'txtloanamnt
        '
        Me.txtloanamnt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtloanamnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtloanamnt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtloanamnt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloanamnt.Location = New System.Drawing.Point(637, 62)
        Me.txtloanamnt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtloanamnt.Name = "txtloanamnt"
        Me.txtloanamnt.ReadOnly = True
        Me.txtloanamnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtloanamnt.Size = New System.Drawing.Size(188, 26)
        Me.txtloanamnt.TabIndex = 11
        Me.txtloanamnt.TabStop = False
        Me.txtloanamnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(490, 31)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(68, 18)
        Me.lblStatus.TabIndex = 113
        Me.lblStatus.Text = "Status:"
        '
        'txtstats
        '
        Me.txtstats.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtstats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstats.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtstats.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstats.Location = New System.Drawing.Point(637, 27)
        Me.txtstats.Margin = New System.Windows.Forms.Padding(4)
        Me.txtstats.Name = "txtstats"
        Me.txtstats.ReadOnly = True
        Me.txtstats.Size = New System.Drawing.Size(188, 26)
        Me.txtstats.TabIndex = 10
        Me.txtstats.TabStop = False
        '
        'lblReleaseDAte
        '
        Me.lblReleaseDAte.AutoSize = True
        Me.lblReleaseDAte.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReleaseDAte.Location = New System.Drawing.Point(19, 99)
        Me.lblReleaseDAte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReleaseDAte.Name = "lblReleaseDAte"
        Me.lblReleaseDAte.Size = New System.Drawing.Size(123, 18)
        Me.lblReleaseDAte.TabIndex = 111
        Me.lblReleaseDAte.Text = "Release Date:"
        '
        'txtreleasedate
        '
        Me.txtreleasedate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtreleasedate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtreleasedate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreleasedate.Location = New System.Drawing.Point(152, 96)
        Me.txtreleasedate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtreleasedate.Name = "txtreleasedate"
        Me.txtreleasedate.ReadOnly = True
        Me.txtreleasedate.Size = New System.Drawing.Size(188, 26)
        Me.txtreleasedate.TabIndex = 8
        Me.txtreleasedate.TabStop = False
        Me.txtreleasedate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDueDate.Location = New System.Drawing.Point(19, 133)
        Me.lblDueDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(90, 18)
        Me.lblDueDate.TabIndex = 109
        Me.lblDueDate.Text = "Due Date:"
        '
        'txtduedate
        '
        Me.txtduedate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtduedate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtduedate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtduedate.Location = New System.Drawing.Point(152, 130)
        Me.txtduedate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtduedate.Name = "txtduedate"
        Me.txtduedate.ReadOnly = True
        Me.txtduedate.Size = New System.Drawing.Size(188, 26)
        Me.txtduedate.TabIndex = 9
        Me.txtduedate.TabStop = False
        Me.txtduedate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtloanid
        '
        Me.txtloanid.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtloanid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtloanid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtloanid.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtloanid.Location = New System.Drawing.Point(152, 28)
        Me.txtloanid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtloanid.Name = "txtloanid"
        Me.txtloanid.ReadOnly = True
        Me.txtloanid.Size = New System.Drawing.Size(188, 26)
        Me.txtloanid.TabIndex = 6
        Me.txtloanid.TabStop = False
        '
        'lblloanid
        '
        Me.lblloanid.AutoSize = True
        Me.lblloanid.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblloanid.Location = New System.Drawing.Point(19, 29)
        Me.lblloanid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblloanid.Name = "lblloanid"
        Me.lblloanid.Size = New System.Drawing.Size(79, 18)
        Me.lblloanid.TabIndex = 107
        Me.lblloanid.Text = "Loan ID:"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtname.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(152, 62)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(333, 26)
        Me.txtname.TabIndex = 7
        Me.txtname.TabStop = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(19, 65)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(62, 18)
        Me.lblname.TabIndex = 105
        Me.lblname.Text = "Name:"
        '
        'dgvLoanList
        '
        Me.dgvLoanList.AllowUserToAddRows = False
        Me.dgvLoanList.AllowUserToDeleteRows = False
        Me.dgvLoanList.AllowUserToResizeColumns = False
        Me.dgvLoanList.AllowUserToResizeRows = False
        Me.dgvLoanList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvLoanList.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvLoanList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvLoanList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLoanList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLoanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLoanList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.loanid, Me.status, Me.fullname, Me.loan_type, Me.duration, Me.release_date, Me.interest_rate, Me.loan_amnt, Me.perday, Me.colCollector})
        Me.dgvLoanList.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLoanList.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvLoanList.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvLoanList.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvLoanList.Location = New System.Drawing.Point(0, 348)
        Me.dgvLoanList.MultiSelect = False
        Me.dgvLoanList.Name = "dgvLoanList"
        Me.dgvLoanList.ReadOnly = True
        Me.dgvLoanList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvLoanList.RowHeadersVisible = False
        Me.dgvLoanList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvLoanList.RowTemplate.Height = 24
        Me.dgvLoanList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLoanList.Size = New System.Drawing.Size(875, 400)
        Me.dgvLoanList.TabIndex = 15
        Me.dgvLoanList.TabStop = False
        '
        'loanid
        '
        Me.loanid.HeaderText = "Loan ID"
        Me.loanid.Name = "loanid"
        Me.loanid.ReadOnly = True
        Me.loanid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.loanid.Visible = False
        Me.loanid.Width = 90
        '
        'status
        '
        Me.status.HeaderText = "ST"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.status.Width = 39
        '
        'fullname
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.fullname.DefaultCellStyle = DataGridViewCellStyle2
        Me.fullname.HeaderText = "Name"
        Me.fullname.Name = "fullname"
        Me.fullname.ReadOnly = True
        Me.fullname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fullname.Width = 69
        '
        'loan_type
        '
        Me.loan_type.HeaderText = "Type"
        Me.loan_type.Name = "loan_type"
        Me.loan_type.ReadOnly = True
        Me.loan_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.loan_type.Width = 61
        '
        'duration
        '
        Me.duration.HeaderText = "D/W/M"
        Me.duration.Name = "duration"
        Me.duration.ReadOnly = True
        Me.duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.duration.Width = 88
        '
        'release_date
        '
        DataGridViewCellStyle3.Format = "yyyy-MMM-dd"
        DataGridViewCellStyle3.NullValue = "NONE"
        Me.release_date.DefaultCellStyle = DataGridViewCellStyle3
        Me.release_date.HeaderText = "RDate"
        Me.release_date.Name = "release_date"
        Me.release_date.ReadOnly = True
        Me.release_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.release_date.Width = 72
        '
        'interest_rate
        '
        Me.interest_rate.HeaderText = "Rate"
        Me.interest_rate.Name = "interest_rate"
        Me.interest_rate.ReadOnly = True
        Me.interest_rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.interest_rate.Width = 58
        '
        'loan_amnt
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.loan_amnt.DefaultCellStyle = DataGridViewCellStyle4
        Me.loan_amnt.HeaderText = "Amount"
        Me.loan_amnt.Name = "loan_amnt"
        Me.loan_amnt.ReadOnly = True
        Me.loan_amnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.loan_amnt.Width = 90
        '
        'perday
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.perday.DefaultCellStyle = DataGridViewCellStyle5
        Me.perday.HeaderText = "Per-D/W/M"
        Me.perday.Name = "perday"
        Me.perday.ReadOnly = True
        Me.perday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.perday.Width = 127
        '
        'colCollector
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colCollector.DefaultCellStyle = DataGridViewCellStyle6
        Me.colCollector.HeaderText = "Collector"
        Me.colCollector.Name = "colCollector"
        Me.colCollector.ReadOnly = True
        Me.colCollector.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgvLedger
        '
        Me.dgvLedger.AllowUserToAddRows = False
        Me.dgvLedger.AllowUserToDeleteRows = False
        Me.dgvLedger.AllowUserToResizeColumns = False
        Me.dgvLedger.AllowUserToResizeRows = False
        Me.dgvLedger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLedger.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvLedger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvLedger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLedger.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLedger.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.paymentdate, Me.amountpaid, Me.ornumber})
        Me.dgvLedger.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLedger.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvLedger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLedger.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvLedger.Location = New System.Drawing.Point(875, 348)
        Me.dgvLedger.Name = "dgvLedger"
        Me.dgvLedger.ReadOnly = True
        Me.dgvLedger.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvLedger.RowHeadersVisible = False
        Me.dgvLedger.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvLedger.RowTemplate.Height = 24
        Me.dgvLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLedger.Size = New System.Drawing.Size(425, 400)
        Me.dgvLedger.TabIndex = 16
        Me.dgvLedger.TabStop = False
        '
        'paymentdate
        '
        DataGridViewCellStyle9.Format = "yyyy-MMM-dd"
        DataGridViewCellStyle9.NullValue = "NONE"
        Me.paymentdate.DefaultCellStyle = DataGridViewCellStyle9
        Me.paymentdate.HeaderText = "PDate"
        Me.paymentdate.Name = "paymentdate"
        Me.paymentdate.ReadOnly = True
        Me.paymentdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'amountpaid
        '
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0.00"
        Me.amountpaid.DefaultCellStyle = DataGridViewCellStyle10
        Me.amountpaid.HeaderText = "Amount"
        Me.amountpaid.Name = "amountpaid"
        Me.amountpaid.ReadOnly = True
        Me.amountpaid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ornumber
        '
        Me.ornumber.HeaderText = "OR No."
        Me.ornumber.Name = "ornumber"
        Me.ornumber.ReadOnly = True
        Me.ornumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'menuBar
        '
        Me.menuBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.menuBar.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.manageToolStrip})
        Me.menuBar.Location = New System.Drawing.Point(0, 50)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Size = New System.Drawing.Size(1300, 28)
        Me.menuBar.TabIndex = 18
        Me.menuBar.Text = "MenuStrip1"
        '
        'manageToolStrip
        '
        Me.manageToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.navBorrowers, Me.navLoanProperties, Me.navRefresh, Me.navPrint, Me.navPrintLedger})
        Me.manageToolStrip.ForeColor = System.Drawing.Color.White
        Me.manageToolStrip.Name = "manageToolStrip"
        Me.manageToolStrip.Size = New System.Drawing.Size(67, 24)
        Me.manageToolStrip.Text = "Menu"
        '
        'navBorrowers
        '
        Me.navBorrowers.ForeColor = System.Drawing.Color.White
        Me.navBorrowers.Name = "navBorrowers"
        Me.navBorrowers.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.navBorrowers.Size = New System.Drawing.Size(307, 26)
        Me.navBorrowers.Text = "Borrowers"
        '
        'navLoanProperties
        '
        Me.navLoanProperties.ForeColor = System.Drawing.Color.White
        Me.navLoanProperties.Name = "navLoanProperties"
        Me.navLoanProperties.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.navLoanProperties.Size = New System.Drawing.Size(307, 26)
        Me.navLoanProperties.Text = "New Loan"
        '
        'navRefresh
        '
        Me.navRefresh.ForeColor = System.Drawing.Color.White
        Me.navRefresh.Name = "navRefresh"
        Me.navRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.navRefresh.Size = New System.Drawing.Size(307, 26)
        Me.navRefresh.Text = "Refresh"
        '
        'navPrint
        '
        Me.navPrint.ForeColor = System.Drawing.Color.White
        Me.navPrint.Name = "navPrint"
        Me.navPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.navPrint.Size = New System.Drawing.Size(307, 26)
        Me.navPrint.Text = "Print Summary"
        '
        'navPrintLedger
        '
        Me.navPrintLedger.ForeColor = System.Drawing.Color.White
        Me.navPrintLedger.Name = "navPrintLedger"
        Me.navPrintLedger.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.navPrintLedger.Size = New System.Drawing.Size(307, 26)
        Me.navPrintLedger.Text = "Print Ledger"
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.ForeColor = System.Drawing.Color.White
        Me.pnlBottom.Location = New System.Drawing.Point(0, 748)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1300, 10)
        Me.pnlBottom.TabIndex = 132
        '
        'frmLoans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1300, 758)
        Me.Controls.Add(Me.dgvLedger)
        Me.Controls.Add(Me.dgvLoanList)
        Me.Controls.Add(Me.pnlBox)
        Me.Controls.Add(Me.menuBar)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlHeader)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoans"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Management"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlBox.ResumeLayout(False)
        Me.pnlBox.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.grpPostpayment.ResumeLayout(False)
        Me.grpPostpayment.PerformLayout()
        Me.grpLoanInfo.ResumeLayout(False)
        Me.grpLoanInfo.PerformLayout()
        CType(Me.dgvLoanList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLedger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuBar.ResumeLayout(False)
        Me.menuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnquit As Button
    Friend WithEvents lblHeadername As Label
    Friend WithEvents pnlBox As Panel
    Friend WithEvents lbldateof_Payment As Label
    Friend WithEvents btnDeletePayment As Button
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents dropStatus As ComboBox
    Friend WithEvents txtSearchNAME As TextBox
    Friend WithEvents lblSearchname As Label
    Friend WithEvents grpPostpayment As GroupBox
    Friend WithEvents lblEntertoPost As Label
    Friend WithEvents txtORnumber As TextBox
    Friend WithEvents lblORNumber As Label
    Friend WithEvents txtpayday As TextBox
    Friend WithEvents lblamnt As Label
    Friend WithEvents dateof_payment As DateTimePicker
    Friend WithEvents lblDateofPayment As Label
    Friend WithEvents grpLoanInfo As GroupBox
    Friend WithEvents lblbalance As Label
    Friend WithEvents txtbalance As TextBox
    Friend WithEvents lblpaidAMnt As Label
    Friend WithEvents txtpaidamnt As TextBox
    Friend WithEvents lblloanamount As Label
    Friend WithEvents txtloanamnt As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtstats As TextBox
    Friend WithEvents lblReleaseDAte As Label
    Friend WithEvents txtreleasedate As TextBox
    Friend WithEvents lblDueDate As Label
    Friend WithEvents txtduedate As TextBox
    Friend WithEvents txtloanid As TextBox
    Friend WithEvents lblloanid As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents dropCollector As ComboBox
    Friend WithEvents dgvLoanList As DataGridView
    Friend WithEvents dgvLedger As DataGridView
    Friend WithEvents paymentdate As DataGridViewTextBoxColumn
    Friend WithEvents amountpaid As DataGridViewTextBoxColumn
    Friend WithEvents ornumber As DataGridViewTextBoxColumn
    Friend WithEvents menuBar As MenuStrip
    Friend WithEvents manageToolStrip As ToolStripMenuItem
    Friend WithEvents navRefresh As ToolStripMenuItem
    Friend WithEvents navBorrowers As ToolStripMenuItem
    Friend WithEvents navLoanProperties As ToolStripMenuItem
    Friend WithEvents navPrint As ToolStripMenuItem
    Friend WithEvents txtborrowerID As TextBox
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents navPrintLedger As ToolStripMenuItem
    Friend WithEvents loanid As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents fullname As DataGridViewTextBoxColumn
    Friend WithEvents loan_type As DataGridViewTextBoxColumn
    Friend WithEvents duration As DataGridViewTextBoxColumn
    Friend WithEvents release_date As DataGridViewTextBoxColumn
    Friend WithEvents interest_rate As DataGridViewTextBoxColumn
    Friend WithEvents loan_amnt As DataGridViewTextBoxColumn
    Friend WithEvents perday As DataGridViewTextBoxColumn
    Friend WithEvents colCollector As DataGridViewTextBoxColumn
End Class
