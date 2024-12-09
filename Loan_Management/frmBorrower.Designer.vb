<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrower
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBorrower))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.lblHeadername = New System.Windows.Forms.Label()
        Me.dropcollector = New System.Windows.Forms.ComboBox()
        Me.droparea = New System.Windows.Forms.ComboBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.lblLFMname = New System.Windows.Forms.Label()
        Me.txtborrowerno = New System.Windows.Forms.TextBox()
        Me.lblcollector = New System.Windows.Forms.Label()
        Me.lblcontact = New System.Windows.Forms.Label()
        Me.lblarea = New System.Windows.Forms.Label()
        Me.lblbrgy = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblborrowerno = New System.Windows.Forms.Label()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtcontact = New System.Windows.Forms.MaskedTextBox()
        Me.pnlHeader.SuspendLayout()
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
        Me.pnlHeader.Size = New System.Drawing.Size(771, 55)
        Me.pnlHeader.TabIndex = 31
        '
        'btnquit
        '
        Me.btnquit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnquit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnquit.FlatAppearance.BorderSize = 0
        Me.btnquit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquit.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnquit.Location = New System.Drawing.Point(715, 0)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(56, 55)
        Me.btnquit.TabIndex = 11
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
        Me.lblHeadername.Size = New System.Drawing.Size(389, 55)
        Me.lblHeadername.TabIndex = 4
        Me.lblHeadername.Text = "Borrower Information"
        Me.lblHeadername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dropcollector
        '
        Me.dropcollector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dropcollector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.dropcollector.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dropcollector.Enabled = False
        Me.dropcollector.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropcollector.FormattingEnabled = True
        Me.dropcollector.Location = New System.Drawing.Point(217, 298)
        Me.dropcollector.Margin = New System.Windows.Forms.Padding(4)
        Me.dropcollector.Name = "dropcollector"
        Me.dropcollector.Size = New System.Drawing.Size(231, 28)
        Me.dropcollector.TabIndex = 4
        '
        'droparea
        '
        Me.droparea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.droparea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.droparea.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.droparea.Enabled = False
        Me.droparea.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.droparea.FormattingEnabled = True
        Me.droparea.Location = New System.Drawing.Point(217, 226)
        Me.droparea.Margin = New System.Windows.Forms.Padding(4)
        Me.droparea.Name = "droparea"
        Me.droparea.Size = New System.Drawing.Size(231, 28)
        Me.droparea.TabIndex = 2
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Enabled = False
        Me.txtAddress.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(217, 190)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(512, 28)
        Me.txtAddress.TabIndex = 1
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtname.Enabled = False
        Me.txtname.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(217, 154)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(511, 28)
        Me.txtname.TabIndex = 0
        '
        'lblLFMname
        '
        Me.lblLFMname.AutoSize = True
        Me.lblLFMname.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLFMname.Location = New System.Drawing.Point(217, 136)
        Me.lblLFMname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLFMname.Name = "lblLFMname"
        Me.lblLFMname.Size = New System.Drawing.Size(172, 14)
        Me.lblLFMname.TabIndex = 59
        Me.lblLFMname.Text = "(Lastname, Firstname, MI)"
        '
        'txtborrowerno
        '
        Me.txtborrowerno.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtborrowerno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtborrowerno.Enabled = False
        Me.txtborrowerno.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtborrowerno.Location = New System.Drawing.Point(217, 97)
        Me.txtborrowerno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtborrowerno.Name = "txtborrowerno"
        Me.txtborrowerno.ReadOnly = True
        Me.txtborrowerno.Size = New System.Drawing.Size(231, 29)
        Me.txtborrowerno.TabIndex = 10
        Me.txtborrowerno.TabStop = False
        '
        'lblcollector
        '
        Me.lblcollector.AutoSize = True
        Me.lblcollector.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcollector.Location = New System.Drawing.Point(56, 301)
        Me.lblcollector.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcollector.Name = "lblcollector"
        Me.lblcollector.Size = New System.Drawing.Size(125, 20)
        Me.lblcollector.TabIndex = 58
        Me.lblcollector.Text = "Collector : *"
        '
        'lblcontact
        '
        Me.lblcontact.AutoSize = True
        Me.lblcontact.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontact.Location = New System.Drawing.Point(56, 265)
        Me.lblcontact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcontact.Name = "lblcontact"
        Me.lblcontact.Size = New System.Drawing.Size(120, 20)
        Me.lblcontact.TabIndex = 53
        Me.lblcontact.Text = "Contact No."
        '
        'lblarea
        '
        Me.lblarea.AutoSize = True
        Me.lblarea.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblarea.Location = New System.Drawing.Point(56, 229)
        Me.lblarea.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(65, 20)
        Me.lblarea.TabIndex = 54
        Me.lblarea.Text = "Area :"
        '
        'lblbrgy
        '
        Me.lblbrgy.AutoSize = True
        Me.lblbrgy.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbrgy.Location = New System.Drawing.Point(56, 193)
        Me.lblbrgy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblbrgy.Name = "lblbrgy"
        Me.lblbrgy.Size = New System.Drawing.Size(136, 20)
        Me.lblbrgy.TabIndex = 55
        Me.lblbrgy.Text = "Brgy/Street :"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(56, 157)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(94, 20)
        Me.lblname.TabIndex = 56
        Me.lblname.Text = "Name : *"
        '
        'lblborrowerno
        '
        Me.lblborrowerno.AutoSize = True
        Me.lblborrowerno.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblborrowerno.Location = New System.Drawing.Point(56, 98)
        Me.lblborrowerno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblborrowerno.Name = "lblborrowerno"
        Me.lblborrowerno.Size = New System.Drawing.Size(143, 20)
        Me.lblborrowerno.TabIndex = 57
        Me.lblborrowerno.Text = "Borrower No :"
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.ForeColor = System.Drawing.Color.White
        Me.pnlBottom.Location = New System.Drawing.Point(0, 451)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(771, 10)
        Me.pnlBottom.TabIndex = 65
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
        Me.btnCancel.Location = New System.Drawing.Point(579, 372)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 53)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Image = Global.Loan_Management.My.Resources.Resources.btnSearch
        Me.btnsearch.Location = New System.Drawing.Point(79, 372)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(119, 53)
        Me.btnsearch.TabIndex = 5
        Me.btnsearch.TabStop = False
        Me.btnsearch.Text = "Search"
        Me.btnsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsearch.UseVisualStyleBackColor = False
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
        Me.btnnew.Location = New System.Drawing.Point(204, 372)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(119, 53)
        Me.btnnew.TabIndex = 6
        Me.btnnew.TabStop = False
        Me.btnnew.Text = "&New"
        Me.btnnew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnnew.UseVisualStyleBackColor = False
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
        Me.btnupdate.Location = New System.Drawing.Point(329, 372)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(119, 53)
        Me.btnupdate.TabIndex = 7
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
        Me.btnsave.Location = New System.Drawing.Point(454, 372)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(119, 53)
        Me.btnsave.TabIndex = 8
        Me.btnsave.TabStop = False
        Me.btnsave.Text = "Save"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'txtcontact
        '
        Me.txtcontact.AsciiOnly = True
        Me.txtcontact.Enabled = False
        Me.txtcontact.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact.Location = New System.Drawing.Point(217, 262)
        Me.txtcontact.Mask = "0000-000-0000"
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(231, 28)
        Me.txtcontact.TabIndex = 3
        '
        'frmBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(771, 461)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.dropcollector)
        Me.Controls.Add(Me.droparea)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblLFMname)
        Me.Controls.Add(Me.txtborrowerno)
        Me.Controls.Add(Me.lblcollector)
        Me.Controls.Add(Me.lblcontact)
        Me.Controls.Add(Me.lblarea)
        Me.Controls.Add(Me.lblbrgy)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblborrowerno)
        Me.Controls.Add(Me.pnlHeader)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(771, 461)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(771, 461)
        Me.Name = "frmBorrower"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrower Information"
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnquit As Button
    Friend WithEvents lblHeadername As Label
    Friend WithEvents dropcollector As ComboBox
    Friend WithEvents droparea As ComboBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents lblLFMname As Label
    Friend WithEvents txtborrowerno As TextBox
    Friend WithEvents lblcollector As Label
    Friend WithEvents lblcontact As Label
    Friend WithEvents lblarea As Label
    Friend WithEvents lblbrgy As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lblborrowerno As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents btnnew As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents txtcontact As MaskedTextBox
End Class
