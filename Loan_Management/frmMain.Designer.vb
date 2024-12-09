<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblHeadername = New System.Windows.Forms.Label()
        Me.picHeader = New System.Windows.Forms.PictureBox()
        Me.btnminimize = New System.Windows.Forms.Button()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.menuBar = New System.Windows.Forms.MenuStrip()
        Me.manageToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.navSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.navLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.navQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.navBorrowers = New System.Windows.Forms.ToolStripMenuItem()
        Me.navLoans = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.lblSessionname = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuBar.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblHeadername)
        Me.pnlHeader.Controls.Add(Me.picHeader)
        Me.pnlHeader.Controls.Add(Me.btnminimize)
        Me.pnlHeader.Controls.Add(Me.btnquit)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.ForeColor = System.Drawing.Color.White
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1025, 36)
        Me.pnlHeader.TabIndex = 9
        '
        'lblHeadername
        '
        Me.lblHeadername.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblHeadername.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadername.Location = New System.Drawing.Point(40, 0)
        Me.lblHeadername.Name = "lblHeadername"
        Me.lblHeadername.Size = New System.Drawing.Size(214, 36)
        Me.lblHeadername.TabIndex = 4
        Me.lblHeadername.Text = "Loan Management"
        Me.lblHeadername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picHeader
        '
        Me.picHeader.BackgroundImage = Global.Loan_Management.My.Resources.Resources.icon_header
        Me.picHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHeader.Dock = System.Windows.Forms.DockStyle.Left
        Me.picHeader.Location = New System.Drawing.Point(0, 0)
        Me.picHeader.Name = "picHeader"
        Me.picHeader.Size = New System.Drawing.Size(40, 36)
        Me.picHeader.TabIndex = 6
        Me.picHeader.TabStop = False
        '
        'btnminimize
        '
        Me.btnminimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnminimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnminimize.FlatAppearance.BorderSize = 0
        Me.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnminimize.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnminimize.Location = New System.Drawing.Point(913, 0)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(56, 36)
        Me.btnminimize.TabIndex = 0
        Me.btnminimize.TabStop = False
        Me.btnminimize.Text = "0"
        Me.btnminimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnminimize.UseVisualStyleBackColor = True
        '
        'btnquit
        '
        Me.btnquit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnquit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnquit.FlatAppearance.BorderSize = 0
        Me.btnquit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquit.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnquit.Location = New System.Drawing.Point(969, 0)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(56, 36)
        Me.btnquit.TabIndex = 0
        Me.btnquit.TabStop = False
        Me.btnquit.Text = "r"
        Me.btnquit.UseVisualStyleBackColor = True
        '
        'menuBar
        '
        Me.menuBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.menuBar.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuBar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.manageToolStrip, Me.viewToolStripMenuItem})
        Me.menuBar.Location = New System.Drawing.Point(0, 36)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Size = New System.Drawing.Size(1025, 28)
        Me.menuBar.TabIndex = 10
        Me.menuBar.Text = "MenuStrip1"
        '
        'manageToolStrip
        '
        Me.manageToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.navSettings, Me.navLogout, Me.navQuit})
        Me.manageToolStrip.ForeColor = System.Drawing.Color.White
        Me.manageToolStrip.Name = "manageToolStrip"
        Me.manageToolStrip.Size = New System.Drawing.Size(67, 24)
        Me.manageToolStrip.Text = "Menu"
        '
        'navSettings
        '
        Me.navSettings.ForeColor = System.Drawing.Color.White
        Me.navSettings.Name = "navSettings"
        Me.navSettings.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.navSettings.Size = New System.Drawing.Size(243, 26)
        Me.navSettings.Text = "Preferences"
        '
        'navLogout
        '
        Me.navLogout.ForeColor = System.Drawing.Color.White
        Me.navLogout.Name = "navLogout"
        Me.navLogout.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.navLogout.Size = New System.Drawing.Size(243, 26)
        Me.navLogout.Text = "Logout"
        '
        'navQuit
        '
        Me.navQuit.ForeColor = System.Drawing.Color.White
        Me.navQuit.Name = "navQuit"
        Me.navQuit.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.navQuit.Size = New System.Drawing.Size(243, 26)
        Me.navQuit.Text = "Exit"
        '
        'viewToolStripMenuItem
        '
        Me.viewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.navBorrowers, Me.navLoans})
        Me.viewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.viewToolStripMenuItem.Name = "viewToolStripMenuItem"
        Me.viewToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.viewToolStripMenuItem.Text = "View"
        '
        'navBorrowers
        '
        Me.navBorrowers.ForeColor = System.Drawing.Color.White
        Me.navBorrowers.Name = "navBorrowers"
        Me.navBorrowers.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.navBorrowers.Size = New System.Drawing.Size(216, 26)
        Me.navBorrowers.Text = "Borrowers"
        '
        'navLoans
        '
        Me.navLoans.ForeColor = System.Drawing.Color.White
        Me.navLoans.Name = "navLoans"
        Me.navLoans.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.navLoans.Size = New System.Drawing.Size(216, 26)
        Me.navLoans.Text = "Loans"
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pnlBottom.Controls.Add(Me.lblSessionname)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.ForeColor = System.Drawing.Color.White
        Me.pnlBottom.Location = New System.Drawing.Point(0, 659)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1025, 31)
        Me.pnlBottom.TabIndex = 11
        '
        'lblSessionname
        '
        Me.lblSessionname.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSessionname.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSessionname.Location = New System.Drawing.Point(0, 0)
        Me.lblSessionname.Name = "lblSessionname"
        Me.lblSessionname.Size = New System.Drawing.Size(1025, 31)
        Me.lblSessionname.TabIndex = 3
        Me.lblSessionname.Text = "User:"
        Me.lblSessionname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1025, 690)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.menuBar)
        Me.Controls.Add(Me.pnlHeader)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loan Management"
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.picHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuBar.ResumeLayout(False)
        Me.menuBar.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeadername As Label
    Friend WithEvents picHeader As PictureBox
    Friend WithEvents btnminimize As Button
    Friend WithEvents btnquit As Button
    Friend WithEvents menuBar As MenuStrip
    Friend WithEvents manageToolStrip As ToolStripMenuItem
    Friend WithEvents navSettings As ToolStripMenuItem
    Friend WithEvents navLogout As ToolStripMenuItem
    Friend WithEvents navQuit As ToolStripMenuItem
    Friend WithEvents viewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents navBorrowers As ToolStripMenuItem
    Friend WithEvents navLoans As ToolStripMenuItem
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents lblSessionname As Label
End Class
