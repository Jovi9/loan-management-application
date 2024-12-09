Public Class frmMain

    Private Sub fadein()
        Dim fade As Double
        For fade = 0.0 To 1 Step 0.1
            Me.Opacity = fade
            Me.Refresh()
        Next
    End Sub

    Private Sub preventFLicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub

    Private Sub maximiseOrRestore()
        Dim isMaximised As Boolean = False
        Dim normalBounds As Rectangle

        If Not isMaximised Then
            normalBounds = Bounds
            Bounds = Screen.PrimaryScreen.WorkingArea
        Else
            Bounds = normalBounds
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        preventFLicker()
        maximiseOrRestore()
        fadein()
        menuBar.Renderer = New ToolStripProfessionalRenderer(New menuCustomColor)

    End Sub

    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        maximiseOrRestore()
        Me.ActiveControl = Nothing

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Dim confirm = MessageBox.Show("Are you sure you want to quit application?", "Quit Loan Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = Windows.Forms.DialogResult.Yes Then
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub btnquit_Click(sender As Object, e As EventArgs) Handles btnquit.Click

        Me.ActiveControl = Nothing
        Application.Exit()

    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click

        Me.ActiveControl = Nothing
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub navLogout_Click(sender As Object, e As EventArgs) Handles navLogout.Click

        Me.Hide()
        frmLogin.Show()

    End Sub

    Private Sub navQuit_Click(sender As Object, e As EventArgs) Handles navQuit.Click

        Me.ActiveControl = Nothing
        btnquit.PerformClick()

    End Sub

    Private Sub navBorrowers_Click(sender As Object, e As EventArgs) Handles navBorrowers.Click
        Me.ActiveControl = Nothing
        frmBorrower.ShowDialog()
    End Sub

    Private Sub navLoans_Click(sender As Object, e As EventArgs) Handles navLoans.Click
        Me.ActiveControl = Nothing
        frmLoans.ShowDialog()
        'Dim frm_users As New frmLoans
        'With frm_users
        '    .MdiParent = Me
        '    '.Dock = DockStyle.Fill
        '    '.WindowState = FormWindowState.Maximized
        'End With
        'frm_users.Show()
    End Sub
End Class

Public Class menuCustomColor : Inherits ProfessionalColorTable
    Public Overrides ReadOnly Property MenuBorder() As System.Drawing.Color
        Get
            Return Color.FromArgb(34, 42, 53)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemBorder As Color
        Get
            Return Color.FromArgb(51, 63, 80)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelected As Color
        Get
            Return Color.FromArgb(51, 63, 80)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientBegin As Color
        Get
            Return Color.FromArgb(51, 63, 80)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientEnd As Color
        Get
            Return Color.FromArgb(51, 63, 80)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientBegin As Color
        Get
            Return Color.FromArgb(51, 63, 80)
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientEnd As Color
        Get
            Return Color.FromArgb(51, 63, 80)
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
        Get
            Return Color.FromArgb(34, 42, 53)
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientBegin As Color
        Get
            Return Color.FromArgb(34, 42, 53)
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientEnd As Color
        Get
            Return Color.FromArgb(34, 42, 53)
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientMiddle As Color
        Get
            Return Color.FromArgb(34, 42, 53)
        End Get
    End Property

End Class