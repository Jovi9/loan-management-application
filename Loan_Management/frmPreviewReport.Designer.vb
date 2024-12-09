<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreviewReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreviewReport))
        Me.reportBalance = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'reportBalance
        '
        Me.reportBalance.ActiveViewIndex = -1
        Me.reportBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reportBalance.Cursor = System.Windows.Forms.Cursors.Default
        Me.reportBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportBalance.Location = New System.Drawing.Point(0, 0)
        Me.reportBalance.Name = "reportBalance"
        Me.reportBalance.ShowCloseButton = False
        Me.reportBalance.ShowCopyButton = False
        Me.reportBalance.ShowGroupTreeButton = False
        Me.reportBalance.ShowLogo = False
        Me.reportBalance.ShowParameterPanelButton = False
        Me.reportBalance.Size = New System.Drawing.Size(1087, 737)
        Me.reportBalance.TabIndex = 0
        '
        'frmPreviewReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 737)
        Me.Controls.Add(Me.reportBalance)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPreviewReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Preview"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents reportBalance As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
