<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanProperties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoanProperties))
        Me.btnReconstruct = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.lblloanid = New System.Windows.Forms.Label()
        Me.txtloanID = New System.Windows.Forms.TextBox()
        Me.lbldaysrem = New System.Windows.Forms.Label()
        Me.txtdaysleft = New System.Windows.Forms.TextBox()
        Me.lblperday = New System.Windows.Forms.Label()
        Me.txtperday = New System.Windows.Forms.TextBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.lblPress_Compute = New System.Windows.Forms.Label()
        Me.lblbalance = New System.Windows.Forms.Label()
        Me.txtbalance = New System.Windows.Forms.TextBox()
        Me.lblpaidamount = New System.Windows.Forms.Label()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.txtpaidamount = New System.Windows.Forms.TextBox()
        Me.lblduedate = New System.Windows.Forms.Label()
        Me.txtduedate = New System.Windows.Forms.TextBox()
        Me.txttotalamount = New System.Windows.Forms.TextBox()
        Me.lblreleasedamount = New System.Windows.Forms.Label()
        Me.txtreleasedamount = New System.Windows.Forms.TextBox()
        Me.date_released = New System.Windows.Forms.DateTimePicker()
        Me.lblinterest = New System.Windows.Forms.Label()
        Me.txtinterest = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.lbltotalamnt = New System.Windows.Forms.Label()
        Me.txtloanamount = New System.Windows.Forms.TextBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.lblHeadername = New System.Windows.Forms.Label()
        Me.grpLoanInfo = New System.Windows.Forms.GroupBox()
        Me.cbointRate = New System.Windows.Forms.ComboBox()
        Me.lblloanamount = New System.Windows.Forms.Label()
        Me.txt_duration = New System.Windows.Forms.TextBox()
        Me.cbopayment_term = New System.Windows.Forms.ComboBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.btnFindID = New System.Windows.Forms.Button()
        Me.lblpaymentTerm = New System.Windows.Forms.Label()
        Me.lblReleaseDate = New System.Windows.Forms.Label()
        Me.txtborrowerno = New System.Windows.Forms.TextBox()
        Me.lblduration = New System.Windows.Forms.Label()
        Me.lblborrowerno = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.grpLoanInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReconstruct
        '
        Me.btnReconstruct.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnReconstruct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReconstruct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnReconstruct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnReconstruct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReconstruct.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReconstruct.ForeColor = System.Drawing.Color.White
        Me.btnReconstruct.Location = New System.Drawing.Point(403, 442)
        Me.btnReconstruct.Name = "btnReconstruct"
        Me.btnReconstruct.Size = New System.Drawing.Size(119, 53)
        Me.btnReconstruct.TabIndex = 21
        Me.btnReconstruct.TabStop = False
        Me.btnReconstruct.Text = "Reconstruct"
        Me.btnReconstruct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReconstruct.UseVisualStyleBackColor = False
        Me.btnReconstruct.Visible = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Image = Global.Loan_Management.My.Resources.Resources.btnUpdate
        Me.btnupdate.Location = New System.Drawing.Point(403, 442)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(119, 53)
        Me.btnupdate.TabIndex = 20
        Me.btnupdate.TabStop = False
        Me.btnupdate.Text = "Update"
        Me.btnupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Enabled = False
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Image = Global.Loan_Management.My.Resources.Resources.btnSave
        Me.btnsave.Location = New System.Drawing.Point(528, 442)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(119, 53)
        Me.btnsave.TabIndex = 22
        Me.btnsave.TabStop = False
        Me.btnsave.Text = "Save"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'lblloanid
        '
        Me.lblloanid.AutoSize = True
        Me.lblloanid.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloanid.Location = New System.Drawing.Point(524, 38)
        Me.lblloanid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblloanid.Name = "lblloanid"
        Me.lblloanid.Size = New System.Drawing.Size(81, 18)
        Me.lblloanid.TabIndex = 131
        Me.lblloanid.Text = "Loan No:"
        '
        'txtloanID
        '
        Me.txtloanID.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtloanID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtloanID.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloanID.Location = New System.Drawing.Point(697, 33)
        Me.txtloanID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtloanID.Name = "txtloanID"
        Me.txtloanID.ReadOnly = True
        Me.txtloanID.Size = New System.Drawing.Size(188, 28)
        Me.txtloanID.TabIndex = 9
        Me.txtloanID.TabStop = False
        '
        'lbldaysrem
        '
        Me.lbldaysrem.AutoSize = True
        Me.lbldaysrem.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldaysrem.Location = New System.Drawing.Point(524, 310)
        Me.lbldaysrem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldaysrem.Name = "lbldaysrem"
        Me.lbldaysrem.Size = New System.Drawing.Size(98, 18)
        Me.lbldaysrem.TabIndex = 129
        Me.lbldaysrem.Text = "Days Rem:"
        '
        'txtdaysleft
        '
        Me.txtdaysleft.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtdaysleft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdaysleft.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdaysleft.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdaysleft.Location = New System.Drawing.Point(697, 307)
        Me.txtdaysleft.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdaysleft.Name = "txtdaysleft"
        Me.txtdaysleft.ReadOnly = True
        Me.txtdaysleft.Size = New System.Drawing.Size(188, 26)
        Me.txtdaysleft.TabIndex = 17
        Me.txtdaysleft.TabStop = False
        Me.txtdaysleft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblperday
        '
        Me.lblperday.AutoSize = True
        Me.lblperday.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblperday.Location = New System.Drawing.Point(524, 276)
        Me.lblperday.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblperday.Name = "lblperday"
        Me.lblperday.Size = New System.Drawing.Size(111, 18)
        Me.lblperday.TabIndex = 127
        Me.lblperday.Text = "Per-D/W/M:"
        '
        'txtperday
        '
        Me.txtperday.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtperday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtperday.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtperday.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtperday.Location = New System.Drawing.Point(697, 273)
        Me.txtperday.Margin = New System.Windows.Forms.Padding(4)
        Me.txtperday.Name = "txtperday"
        Me.txtperday.ReadOnly = True
        Me.txtperday.Size = New System.Drawing.Size(188, 26)
        Me.txtperday.TabIndex = 16
        Me.txtperday.TabStop = False
        Me.txtperday.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboStatus
        '
        Me.cboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStatus.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cboStatus.Enabled = False
        Me.cboStatus.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"AA", "RC", "CA"})
        Me.cboStatus.Location = New System.Drawing.Point(174, 33)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(188, 26)
        Me.cboStatus.TabIndex = 0
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstatus.Location = New System.Drawing.Point(11, 36)
        Me.lblstatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(68, 18)
        Me.lblstatus.TabIndex = 124
        Me.lblstatus.Text = "Status:"
        '
        'lblPress_Compute
        '
        Me.lblPress_Compute.AutoSize = True
        Me.lblPress_Compute.Font = New System.Drawing.Font("Verdana", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPress_Compute.Location = New System.Drawing.Point(174, 301)
        Me.lblPress_Compute.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPress_Compute.Name = "lblPress_Compute"
        Me.lblPress_Compute.Size = New System.Drawing.Size(208, 17)
        Me.lblPress_Compute.TabIndex = 123
        Me.lblPress_Compute.Text = "(press Enter to compute)"
        '
        'lblbalance
        '
        Me.lblbalance.AutoSize = True
        Me.lblbalance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbalance.Location = New System.Drawing.Point(524, 242)
        Me.lblbalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(77, 18)
        Me.lblbalance.TabIndex = 122
        Me.lblbalance.Text = "Balance:"
        '
        'txtbalance
        '
        Me.txtbalance.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtbalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbalance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbalance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbalance.Location = New System.Drawing.Point(697, 239)
        Me.txtbalance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.ReadOnly = True
        Me.txtbalance.Size = New System.Drawing.Size(188, 26)
        Me.txtbalance.TabIndex = 15
        Me.txtbalance.TabStop = False
        Me.txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblpaidamount
        '
        Me.lblpaidamount.AutoSize = True
        Me.lblpaidamount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaidamount.Location = New System.Drawing.Point(524, 208)
        Me.lblpaidamount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpaidamount.Name = "lblpaidamount"
        Me.lblpaidamount.Size = New System.Drawing.Size(119, 18)
        Me.lblpaidamount.TabIndex = 121
        Me.lblpaidamount.Text = "Paid Amount:"
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.ForeColor = System.Drawing.Color.White
        Me.pnlBottom.Location = New System.Drawing.Point(0, 515)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(930, 10)
        Me.pnlBottom.TabIndex = 50
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Enabled = False
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = Global.Loan_Management.My.Resources.Resources.btnCancel
        Me.btnCancel.Location = New System.Drawing.Point(653, 442)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 53)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnnew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Image = Global.Loan_Management.My.Resources.Resources.btnNew
        Me.btnnew.Location = New System.Drawing.Point(278, 442)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(119, 53)
        Me.btnnew.TabIndex = 19
        Me.btnnew.TabStop = False
        Me.btnnew.Text = "New"
        Me.btnnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'txtpaidamount
        '
        Me.txtpaidamount.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtpaidamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpaidamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpaidamount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaidamount.Location = New System.Drawing.Point(697, 205)
        Me.txtpaidamount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpaidamount.Name = "txtpaidamount"
        Me.txtpaidamount.ReadOnly = True
        Me.txtpaidamount.Size = New System.Drawing.Size(188, 26)
        Me.txtpaidamount.TabIndex = 14
        Me.txtpaidamount.TabStop = False
        Me.txtpaidamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblduedate
        '
        Me.lblduedate.AutoSize = True
        Me.lblduedate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblduedate.Location = New System.Drawing.Point(524, 174)
        Me.lblduedate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblduedate.Name = "lblduedate"
        Me.lblduedate.Size = New System.Drawing.Size(90, 18)
        Me.lblduedate.TabIndex = 120
        Me.lblduedate.Text = "Due Date:"
        '
        'txtduedate
        '
        Me.txtduedate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtduedate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtduedate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtduedate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtduedate.Location = New System.Drawing.Point(697, 171)
        Me.txtduedate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtduedate.Name = "txtduedate"
        Me.txtduedate.ReadOnly = True
        Me.txtduedate.Size = New System.Drawing.Size(188, 26)
        Me.txtduedate.TabIndex = 13
        Me.txtduedate.TabStop = False
        Me.txtduedate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttotalamount
        '
        Me.txttotalamount.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txttotalamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotalamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttotalamount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalamount.Location = New System.Drawing.Point(697, 137)
        Me.txttotalamount.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotalamount.Name = "txttotalamount"
        Me.txttotalamount.ReadOnly = True
        Me.txttotalamount.Size = New System.Drawing.Size(188, 26)
        Me.txttotalamount.TabIndex = 12
        Me.txttotalamount.TabStop = False
        Me.txttotalamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblreleasedamount
        '
        Me.lblreleasedamount.AutoSize = True
        Me.lblreleasedamount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreleasedamount.Location = New System.Drawing.Point(524, 106)
        Me.lblreleasedamount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblreleasedamount.Name = "lblreleasedamount"
        Me.lblreleasedamount.Size = New System.Drawing.Size(159, 18)
        Me.lblreleasedamount.TabIndex = 118
        Me.lblreleasedamount.Text = "Released Amount:"
        '
        'txtreleasedamount
        '
        Me.txtreleasedamount.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtreleasedamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtreleasedamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtreleasedamount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreleasedamount.Location = New System.Drawing.Point(697, 103)
        Me.txtreleasedamount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtreleasedamount.Name = "txtreleasedamount"
        Me.txtreleasedamount.ReadOnly = True
        Me.txtreleasedamount.Size = New System.Drawing.Size(188, 26)
        Me.txtreleasedamount.TabIndex = 11
        Me.txtreleasedamount.TabStop = False
        Me.txtreleasedamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'date_released
        '
        Me.date_released.CustomFormat = "yyyy-MMM-dd"
        Me.date_released.Enabled = False
        Me.date_released.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_released.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date_released.Location = New System.Drawing.Point(174, 204)
        Me.date_released.Name = "date_released"
        Me.date_released.Size = New System.Drawing.Size(188, 26)
        Me.date_released.TabIndex = 6
        '
        'lblinterest
        '
        Me.lblinterest.AutoSize = True
        Me.lblinterest.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinterest.Location = New System.Drawing.Point(524, 72)
        Me.lblinterest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinterest.Name = "lblinterest"
        Me.lblinterest.Size = New System.Drawing.Size(82, 18)
        Me.lblinterest.TabIndex = 117
        Me.lblinterest.Text = "Interest:"
        '
        'txtinterest
        '
        Me.txtinterest.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtinterest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtinterest.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtinterest.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinterest.Location = New System.Drawing.Point(697, 69)
        Me.txtinterest.Margin = New System.Windows.Forms.Padding(4)
        Me.txtinterest.Name = "txtinterest"
        Me.txtinterest.ReadOnly = True
        Me.txtinterest.Size = New System.Drawing.Size(188, 26)
        Me.txtinterest.TabIndex = 10
        Me.txtinterest.TabStop = False
        Me.txtinterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(153, 442)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(119, 53)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.Color.White
        Me.btnprint.Image = Global.Loan_Management.My.Resources.Resources.btnPrint
        Me.btnprint.Location = New System.Drawing.Point(778, 442)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(119, 53)
        Me.btnprint.TabIndex = 24
        Me.btnprint.TabStop = False
        Me.btnprint.Text = "Print"
        Me.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'lbltotalamnt
        '
        Me.lbltotalamnt.AutoSize = True
        Me.lbltotalamnt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamnt.Location = New System.Drawing.Point(524, 140)
        Me.lbltotalamnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotalamnt.Name = "lbltotalamnt"
        Me.lbltotalamnt.Size = New System.Drawing.Size(125, 18)
        Me.lbltotalamnt.TabIndex = 119
        Me.lbltotalamnt.Text = "Total Amount:"
        '
        'txtloanamount
        '
        Me.txtloanamount.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtloanamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtloanamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtloanamount.Enabled = False
        Me.txtloanamount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloanamount.Location = New System.Drawing.Point(174, 271)
        Me.txtloanamount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtloanamount.Name = "txtloanamount"
        Me.txtloanamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtloanamount.Size = New System.Drawing.Size(188, 26)
        Me.txtloanamount.TabIndex = 8
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
        Me.pnlHeader.Size = New System.Drawing.Size(930, 55)
        Me.pnlHeader.TabIndex = 48
        '
        'btnquit
        '
        Me.btnquit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnquit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnquit.FlatAppearance.BorderSize = 0
        Me.btnquit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquit.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnquit.Location = New System.Drawing.Point(874, 0)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(56, 55)
        Me.btnquit.TabIndex = 25
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
        Me.lblHeadername.Size = New System.Drawing.Size(327, 55)
        Me.lblHeadername.TabIndex = 4
        Me.lblHeadername.Text = "Loan Information"
        Me.lblHeadername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpLoanInfo
        '
        Me.grpLoanInfo.BackColor = System.Drawing.Color.Silver
        Me.grpLoanInfo.Controls.Add(Me.lblloanid)
        Me.grpLoanInfo.Controls.Add(Me.txtloanID)
        Me.grpLoanInfo.Controls.Add(Me.lbldaysrem)
        Me.grpLoanInfo.Controls.Add(Me.txtdaysleft)
        Me.grpLoanInfo.Controls.Add(Me.lblperday)
        Me.grpLoanInfo.Controls.Add(Me.txtperday)
        Me.grpLoanInfo.Controls.Add(Me.cboStatus)
        Me.grpLoanInfo.Controls.Add(Me.lblstatus)
        Me.grpLoanInfo.Controls.Add(Me.lblPress_Compute)
        Me.grpLoanInfo.Controls.Add(Me.lblbalance)
        Me.grpLoanInfo.Controls.Add(Me.txtbalance)
        Me.grpLoanInfo.Controls.Add(Me.lblpaidamount)
        Me.grpLoanInfo.Controls.Add(Me.txtpaidamount)
        Me.grpLoanInfo.Controls.Add(Me.lblduedate)
        Me.grpLoanInfo.Controls.Add(Me.txtduedate)
        Me.grpLoanInfo.Controls.Add(Me.lbltotalamnt)
        Me.grpLoanInfo.Controls.Add(Me.txttotalamount)
        Me.grpLoanInfo.Controls.Add(Me.lblreleasedamount)
        Me.grpLoanInfo.Controls.Add(Me.txtreleasedamount)
        Me.grpLoanInfo.Controls.Add(Me.date_released)
        Me.grpLoanInfo.Controls.Add(Me.lblinterest)
        Me.grpLoanInfo.Controls.Add(Me.txtinterest)
        Me.grpLoanInfo.Controls.Add(Me.txtloanamount)
        Me.grpLoanInfo.Controls.Add(Me.cbointRate)
        Me.grpLoanInfo.Controls.Add(Me.lblloanamount)
        Me.grpLoanInfo.Controls.Add(Me.txt_duration)
        Me.grpLoanInfo.Controls.Add(Me.cbopayment_term)
        Me.grpLoanInfo.Controls.Add(Me.txtname)
        Me.grpLoanInfo.Controls.Add(Me.lblname)
        Me.grpLoanInfo.Controls.Add(Me.lblInterestRate)
        Me.grpLoanInfo.Controls.Add(Me.btnFindID)
        Me.grpLoanInfo.Controls.Add(Me.lblpaymentTerm)
        Me.grpLoanInfo.Controls.Add(Me.lblReleaseDate)
        Me.grpLoanInfo.Controls.Add(Me.txtborrowerno)
        Me.grpLoanInfo.Controls.Add(Me.lblduration)
        Me.grpLoanInfo.Controls.Add(Me.lblborrowerno)
        Me.grpLoanInfo.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLoanInfo.Location = New System.Drawing.Point(12, 65)
        Me.grpLoanInfo.Name = "grpLoanInfo"
        Me.grpLoanInfo.Size = New System.Drawing.Size(900, 355)
        Me.grpLoanInfo.TabIndex = 49
        Me.grpLoanInfo.TabStop = False
        Me.grpLoanInfo.Text = "Information"
        '
        'cbointRate
        '
        Me.cbointRate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbointRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbointRate.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cbointRate.Enabled = False
        Me.cbointRate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbointRate.FormattingEnabled = True
        Me.cbointRate.Location = New System.Drawing.Point(174, 237)
        Me.cbointRate.Margin = New System.Windows.Forms.Padding(4)
        Me.cbointRate.Name = "cbointRate"
        Me.cbointRate.Size = New System.Drawing.Size(188, 26)
        Me.cbointRate.TabIndex = 7
        '
        'lblloanamount
        '
        Me.lblloanamount.AutoSize = True
        Me.lblloanamount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloanamount.Location = New System.Drawing.Point(11, 274)
        Me.lblloanamount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblloanamount.Name = "lblloanamount"
        Me.lblloanamount.Size = New System.Drawing.Size(124, 18)
        Me.lblloanamount.TabIndex = 116
        Me.lblloanamount.Text = "Loan Amount:"
        '
        'txt_duration
        '
        Me.txt_duration.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_duration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_duration.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_duration.Enabled = False
        Me.txt_duration.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_duration.Location = New System.Drawing.Point(174, 171)
        Me.txt_duration.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_duration.Name = "txt_duration"
        Me.txt_duration.Size = New System.Drawing.Size(188, 26)
        Me.txt_duration.TabIndex = 5
        '
        'cbopayment_term
        '
        Me.cbopayment_term.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbopayment_term.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbopayment_term.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cbopayment_term.Enabled = False
        Me.cbopayment_term.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbopayment_term.FormattingEnabled = True
        Me.cbopayment_term.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly"})
        Me.cbopayment_term.Location = New System.Drawing.Point(174, 137)
        Me.cbopayment_term.Margin = New System.Windows.Forms.Padding(4)
        Me.cbopayment_term.Name = "cbopayment_term"
        Me.cbopayment_term.Size = New System.Drawing.Size(188, 26)
        Me.cbopayment_term.TabIndex = 4
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtname.Enabled = False
        Me.txtname.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(174, 103)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(333, 26)
        Me.txtname.TabIndex = 3
        Me.txtname.TabStop = False
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(11, 106)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(62, 18)
        Me.lblname.TabIndex = 111
        Me.lblname.Text = "Name:"
        '
        'lblInterestRate
        '
        Me.lblInterestRate.AutoSize = True
        Me.lblInterestRate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestRate.Location = New System.Drawing.Point(11, 240)
        Me.lblInterestRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(126, 18)
        Me.lblInterestRate.TabIndex = 115
        Me.lblInterestRate.Text = "Interest Rate:"
        '
        'btnFindID
        '
        Me.btnFindID.BackColor = System.Drawing.Color.White
        Me.btnFindID.BackgroundImage = Global.Loan_Management.My.Resources.Resources.browse
        Me.btnFindID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFindID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFindID.Enabled = False
        Me.btnFindID.Location = New System.Drawing.Point(368, 65)
        Me.btnFindID.Name = "btnFindID"
        Me.btnFindID.Size = New System.Drawing.Size(40, 30)
        Me.btnFindID.TabIndex = 2
        Me.btnFindID.UseVisualStyleBackColor = False
        '
        'lblpaymentTerm
        '
        Me.lblpaymentTerm.AutoSize = True
        Me.lblpaymentTerm.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaymentTerm.Location = New System.Drawing.Point(11, 140)
        Me.lblpaymentTerm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblpaymentTerm.Name = "lblpaymentTerm"
        Me.lblpaymentTerm.Size = New System.Drawing.Size(136, 18)
        Me.lblpaymentTerm.TabIndex = 112
        Me.lblpaymentTerm.Text = "Payment Term:"
        '
        'lblReleaseDate
        '
        Me.lblReleaseDate.AutoSize = True
        Me.lblReleaseDate.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReleaseDate.Location = New System.Drawing.Point(11, 210)
        Me.lblReleaseDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReleaseDate.Name = "lblReleaseDate"
        Me.lblReleaseDate.Size = New System.Drawing.Size(123, 18)
        Me.lblReleaseDate.TabIndex = 114
        Me.lblReleaseDate.Text = "Release Date:"
        '
        'txtborrowerno
        '
        Me.txtborrowerno.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtborrowerno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtborrowerno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtborrowerno.Enabled = False
        Me.txtborrowerno.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtborrowerno.Location = New System.Drawing.Point(174, 67)
        Me.txtborrowerno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtborrowerno.Name = "txtborrowerno"
        Me.txtborrowerno.ReadOnly = True
        Me.txtborrowerno.Size = New System.Drawing.Size(188, 28)
        Me.txtborrowerno.TabIndex = 1
        Me.txtborrowerno.TabStop = False
        '
        'lblduration
        '
        Me.lblduration.AutoSize = True
        Me.lblduration.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblduration.Location = New System.Drawing.Point(11, 174)
        Me.lblduration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblduration.Name = "lblduration"
        Me.lblduration.Size = New System.Drawing.Size(84, 18)
        Me.lblduration.TabIndex = 113
        Me.lblduration.Text = "Duration:"
        '
        'lblborrowerno
        '
        Me.lblborrowerno.AutoSize = True
        Me.lblborrowerno.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblborrowerno.Location = New System.Drawing.Point(11, 68)
        Me.lblborrowerno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblborrowerno.Name = "lblborrowerno"
        Me.lblborrowerno.Size = New System.Drawing.Size(122, 18)
        Me.lblborrowerno.TabIndex = 110
        Me.lblborrowerno.Text = "Borrower No :"
        '
        'frmLoanProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(930, 525)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.grpLoanInfo)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnReconstruct)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(930, 525)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(930, 525)
        Me.Name = "frmLoanProperties"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Information"
        Me.pnlHeader.ResumeLayout(False)
        Me.grpLoanInfo.ResumeLayout(False)
        Me.grpLoanInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReconstruct As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents lblloanid As Label
    Friend WithEvents txtloanID As TextBox
    Friend WithEvents lbldaysrem As Label
    Friend WithEvents txtdaysleft As TextBox
    Friend WithEvents lblperday As Label
    Friend WithEvents txtperday As TextBox
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents lblstatus As Label
    Friend WithEvents lblPress_Compute As Label
    Friend WithEvents lblbalance As Label
    Friend WithEvents txtbalance As TextBox
    Friend WithEvents lblpaidamount As Label
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnnew As Button
    Friend WithEvents txtpaidamount As TextBox
    Friend WithEvents lblduedate As Label
    Friend WithEvents txtduedate As TextBox
    Friend WithEvents txttotalamount As TextBox
    Friend WithEvents lblreleasedamount As Label
    Friend WithEvents txtreleasedamount As TextBox
    Friend WithEvents date_released As DateTimePicker
    Friend WithEvents lblinterest As Label
    Friend WithEvents txtinterest As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents lbltotalamnt As Label
    Friend WithEvents txtloanamount As TextBox
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnquit As Button
    Friend WithEvents lblHeadername As Label
    Friend WithEvents grpLoanInfo As GroupBox
    Friend WithEvents cbointRate As ComboBox
    Friend WithEvents lblloanamount As Label
    Friend WithEvents txt_duration As TextBox
    Friend WithEvents cbopayment_term As ComboBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents btnFindID As Button
    Friend WithEvents lblpaymentTerm As Label
    Friend WithEvents lblReleaseDate As Label
    Friend WithEvents txtborrowerno As TextBox
    Friend WithEvents lblduration As Label
    Friend WithEvents lblborrowerno As Label
End Class
