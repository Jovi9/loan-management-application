<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.pnlLoginHeader = New System.Windows.Forms.Panel()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.lblHeadername = New System.Windows.Forms.Label()
        Me.picHeader = New System.Windows.Forms.PictureBox()
        Me.pic_pass = New System.Windows.Forms.PictureBox()
        Me.pic_user = New System.Windows.Forms.PictureBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.lblemptypass = New System.Windows.Forms.Label()
        Me.lblemptyuser = New System.Windows.Forms.Label()
        Me.pnlLoginBottom = New System.Windows.Forms.Panel()
        Me.pnlLoginHeader.SuspendLayout()
        CType(Me.picHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_pass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLoginHeader
        '
        Me.pnlLoginHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pnlLoginHeader.Controls.Add(Me.btnquit)
        Me.pnlLoginHeader.Controls.Add(Me.lblHeadername)
        Me.pnlLoginHeader.Controls.Add(Me.picHeader)
        Me.pnlLoginHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLoginHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoginHeader.Name = "pnlLoginHeader"
        Me.pnlLoginHeader.Size = New System.Drawing.Size(531, 40)
        Me.pnlLoginHeader.TabIndex = 24
        '
        'btnquit
        '
        Me.btnquit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnquit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnquit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnquit.FlatAppearance.BorderSize = 0
        Me.btnquit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnquit.Font = New System.Drawing.Font("Marlett", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnquit.ForeColor = System.Drawing.Color.White
        Me.btnquit.Location = New System.Drawing.Point(475, 0)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(56, 40)
        Me.btnquit.TabIndex = 3
        Me.btnquit.TabStop = False
        Me.btnquit.Text = "r"
        Me.btnquit.UseVisualStyleBackColor = True
        '
        'lblHeadername
        '
        Me.lblHeadername.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblHeadername.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadername.ForeColor = System.Drawing.Color.White
        Me.lblHeadername.Location = New System.Drawing.Point(40, 0)
        Me.lblHeadername.Name = "lblHeadername"
        Me.lblHeadername.Size = New System.Drawing.Size(214, 40)
        Me.lblHeadername.TabIndex = 7
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
        Me.picHeader.Size = New System.Drawing.Size(40, 40)
        Me.picHeader.TabIndex = 8
        Me.picHeader.TabStop = False
        '
        'pic_pass
        '
        Me.pic_pass.BackColor = System.Drawing.Color.Transparent
        Me.pic_pass.Image = Global.Loan_Management.My.Resources.Resources.login_pass
        Me.pic_pass.Location = New System.Drawing.Point(35, 564)
        Me.pic_pass.Name = "pic_pass"
        Me.pic_pass.Size = New System.Drawing.Size(54, 52)
        Me.pic_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_pass.TabIndex = 27
        Me.pic_pass.TabStop = False
        '
        'pic_user
        '
        Me.pic_user.BackColor = System.Drawing.Color.Transparent
        Me.pic_user.Image = Global.Loan_Management.My.Resources.Resources.login_user
        Me.pic_user.Location = New System.Drawing.Point(35, 458)
        Me.pic_user.Name = "pic_user"
        Me.pic_user.Size = New System.Drawing.Size(54, 52)
        Me.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_user.TabIndex = 28
        Me.pic_user.TabStop = False
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Verdana", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(95, 564)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(400, 52)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtusername.Font = New System.Drawing.Font("Verdana", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(95, 458)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(400, 52)
        Me.txtusername.TabIndex = 0
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.Image = Global.Loan_Management.My.Resources.Resources.btnLogin
        Me.btnlogin.Location = New System.Drawing.Point(265, 673)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(230, 53)
        Me.btnlogin.TabIndex = 2
        Me.btnlogin.TabStop = False
        Me.btnlogin.Text = "Login"
        Me.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'lblemptypass
        '
        Me.lblemptypass.AutoSize = True
        Me.lblemptypass.BackColor = System.Drawing.Color.Transparent
        Me.lblemptypass.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemptypass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblemptypass.Location = New System.Drawing.Point(95, 619)
        Me.lblemptypass.Name = "lblemptypass"
        Me.lblemptypass.Size = New System.Drawing.Size(212, 23)
        Me.lblemptypass.TabIndex = 25
        Me.lblemptypass.Text = "Password is empty"
        Me.lblemptypass.Visible = False
        '
        'lblemptyuser
        '
        Me.lblemptyuser.AutoSize = True
        Me.lblemptyuser.BackColor = System.Drawing.Color.Transparent
        Me.lblemptyuser.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemptyuser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.lblemptyuser.Location = New System.Drawing.Point(95, 513)
        Me.lblemptyuser.Name = "lblemptyuser"
        Me.lblemptyuser.Size = New System.Drawing.Size(217, 23)
        Me.lblemptyuser.TabIndex = 26
        Me.lblemptyuser.Text = "Username is empty"
        Me.lblemptyuser.Visible = False
        '
        'pnlLoginBottom
        '
        Me.pnlLoginBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.pnlLoginBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlLoginBottom.Location = New System.Drawing.Point(0, 760)
        Me.pnlLoginBottom.Name = "pnlLoginBottom"
        Me.pnlLoginBottom.Size = New System.Drawing.Size(531, 10)
        Me.pnlLoginBottom.TabIndex = 29
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Loan_Management.My.Resources.Resources.frmLogin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnquit
        Me.ClientSize = New System.Drawing.Size(531, 770)
        Me.Controls.Add(Me.pnlLoginHeader)
        Me.Controls.Add(Me.pic_pass)
        Me.Controls.Add(Me.pic_user)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.lblemptypass)
        Me.Controls.Add(Me.lblemptyuser)
        Me.Controls.Add(Me.pnlLoginBottom)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(531, 770)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(531, 770)
        Me.Name = "frmLogin"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        Me.pnlLoginHeader.ResumeLayout(False)
        CType(Me.picHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_pass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlLoginHeader As Panel
    Friend WithEvents btnquit As Button
    Friend WithEvents lblHeadername As Label
    Friend WithEvents picHeader As PictureBox
    Friend WithEvents pic_pass As PictureBox
    Friend WithEvents pic_user As PictureBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents lblemptypass As Label
    Friend WithEvents lblemptyuser As Label
    Friend WithEvents pnlLoginBottom As Panel
End Class
