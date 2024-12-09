<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadBorrowers
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoadBorrowers))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.dropCollector = New System.Windows.Forms.ComboBox()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.lblHeadername = New System.Windows.Forms.Label()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.dgv_borrower = New System.Windows.Forms.DataGridView()
        Me.borrowerid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.collector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHeader.SuspendLayout()
        CType(Me.dgv_borrower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnprint)
        Me.pnlHeader.Controls.Add(Me.dropCollector)
        Me.pnlHeader.Controls.Add(Me.btnquit)
        Me.pnlHeader.Controls.Add(Me.txtsearch)
        Me.pnlHeader.Controls.Add(Me.lblHeadername)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.ForeColor = System.Drawing.Color.White
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1027, 60)
        Me.pnlHeader.TabIndex = 129
        '
        'btnprint
        '
        Me.btnprint.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.Color.White
        Me.btnprint.Image = Global.Loan_Management.My.Resources.Resources.btnPrint
        Me.btnprint.Location = New System.Drawing.Point(900, 10)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(50, 40)
        Me.btnprint.TabIndex = 24
        Me.btnprint.TabStop = False
        Me.btnprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnprint.UseVisualStyleBackColor = False
        '
        'dropCollector
        '
        Me.dropCollector.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dropCollector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropCollector.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropCollector.FormattingEnabled = True
        Me.dropCollector.Location = New System.Drawing.Point(657, 14)
        Me.dropCollector.Margin = New System.Windows.Forms.Padding(4)
        Me.dropCollector.Name = "dropCollector"
        Me.dropCollector.Size = New System.Drawing.Size(231, 30)
        Me.dropCollector.TabIndex = 9
        '
        'btnquit
        '
        Me.btnquit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnquit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnquit.FlatAppearance.BorderSize = 0
        Me.btnquit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquit.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnquit.Location = New System.Drawing.Point(971, 0)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(56, 60)
        Me.btnquit.TabIndex = 1
        Me.btnquit.TabStop = False
        Me.btnquit.Text = "r"
        Me.btnquit.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsearch.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(227, 13)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(410, 32)
        Me.txtsearch.TabIndex = 0
        '
        'lblHeadername
        '
        Me.lblHeadername.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblHeadername.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadername.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblHeadername.Location = New System.Drawing.Point(0, 0)
        Me.lblHeadername.Name = "lblHeadername"
        Me.lblHeadername.Size = New System.Drawing.Size(217, 60)
        Me.lblHeadername.TabIndex = 4
        Me.lblHeadername.Text = "Search Borrower:"
        Me.lblHeadername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.ForeColor = System.Drawing.Color.White
        Me.pnlBottom.Location = New System.Drawing.Point(0, 615)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1027, 10)
        Me.pnlBottom.TabIndex = 132
        '
        'dgv_borrower
        '
        Me.dgv_borrower.AllowUserToAddRows = False
        Me.dgv_borrower.AllowUserToDeleteRows = False
        Me.dgv_borrower.AllowUserToResizeColumns = False
        Me.dgv_borrower.AllowUserToResizeRows = False
        Me.dgv_borrower.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_borrower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_borrower.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_borrower.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_borrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_borrower.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.borrowerid, Me.fullname, Me.address, Me.contact_no, Me.collector})
        Me.dgv_borrower.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_borrower.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_borrower.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_borrower.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgv_borrower.Location = New System.Drawing.Point(0, 60)
        Me.dgv_borrower.MultiSelect = False
        Me.dgv_borrower.Name = "dgv_borrower"
        Me.dgv_borrower.ReadOnly = True
        Me.dgv_borrower.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgv_borrower.RowHeadersVisible = False
        Me.dgv_borrower.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_borrower.RowTemplate.Height = 24
        Me.dgv_borrower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_borrower.Size = New System.Drawing.Size(1027, 555)
        Me.dgv_borrower.TabIndex = 133
        Me.dgv_borrower.TabStop = False
        '
        'borrowerid
        '
        Me.borrowerid.HeaderText = "Borrower ID"
        Me.borrowerid.Name = "borrowerid"
        Me.borrowerid.ReadOnly = True
        Me.borrowerid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.borrowerid.Width = 120
        '
        'fullname
        '
        Me.fullname.HeaderText = "Name"
        Me.fullname.Name = "fullname"
        Me.fullname.ReadOnly = True
        Me.fullname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fullname.Width = 69
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.address.Width = 91
        '
        'contact_no
        '
        Me.contact_no.HeaderText = "Contact Number"
        Me.contact_no.Name = "contact_no"
        Me.contact_no.ReadOnly = True
        Me.contact_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.contact_no.Width = 152
        '
        'collector
        '
        Me.collector.HeaderText = "Collector"
        Me.collector.Name = "collector"
        Me.collector.ReadOnly = True
        Me.collector.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmLoadBorrowers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1027, 625)
        Me.Controls.Add(Me.dgv_borrower)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlHeader)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoadBorrowers"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borrower List"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgv_borrower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents dropCollector As ComboBox
    Friend WithEvents btnquit As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents lblHeadername As Label
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents btnprint As Button
    Friend WithEvents dgv_borrower As DataGridView
    Friend WithEvents borrowerid As DataGridViewTextBoxColumn
    Friend WithEvents fullname As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents contact_no As DataGridViewTextBoxColumn
    Friend WithEvents collector As DataGridViewTextBoxColumn
End Class
