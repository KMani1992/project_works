<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDInetmini
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeadAccToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurcheseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusoperator = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusdate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ExitToolStripMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(915, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HeadAccToolStripMenuItem, Me.ProductMasterToolStripMenuItem, Me.OperatorToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MasterToolStripMenuItem.Text = "&Master"
        '
        'HeadAccToolStripMenuItem
        '
        Me.HeadAccToolStripMenuItem.Name = "HeadAccToolStripMenuItem"
        Me.HeadAccToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.HeadAccToolStripMenuItem.Text = "&HeaddAccounts"
        '
        'ProductMasterToolStripMenuItem
        '
        Me.ProductMasterToolStripMenuItem.Name = "ProductMasterToolStripMenuItem"
        Me.ProductMasterToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ProductMasterToolStripMenuItem.Text = "&ProductMaster"
        '
        'OperatorToolStripMenuItem
        '
        Me.OperatorToolStripMenuItem.Name = "OperatorToolStripMenuItem"
        Me.OperatorToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.OperatorToolStripMenuItem.Text = "&Operator"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurcheseToolStripMenuItem, Me.SalesToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.TransactionToolStripMenuItem.Text = "&Transaction"
        '
        'PurcheseToolStripMenuItem
        '
        Me.PurcheseToolStripMenuItem.Name = "PurcheseToolStripMenuItem"
        Me.PurcheseToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.PurcheseToolStripMenuItem.Text = "&Purchese"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.SalesToolStripMenuItem.Text = "&Sales"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'TransactionReportToolStripMenuItem
        '
        Me.TransactionReportToolStripMenuItem.Name = "TransactionReportToolStripMenuItem"
        Me.TransactionReportToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.TransactionReportToolStripMenuItem.Text = "&TransactionReport"
        '
        'ExitToolStripMenu
        '
        Me.ExitToolStripMenu.Name = "ExitToolStripMenu"
        Me.ExitToolStripMenu.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenu.Text = "&Exit"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusoperator, Me.ToolStripStatusdate})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(915, 22)
        Me.StatusStrip.TabIndex = 9
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusoperator
        '
        Me.ToolStripStatusoperator.Name = "ToolStripStatusoperator"
        Me.ToolStripStatusoperator.Size = New System.Drawing.Size(15, 17)
        Me.ToolStripStatusoperator.Text = "::"
        '
        'ToolStripStatusdate
        '
        Me.ToolStripStatusdate.Name = "ToolStripStatusdate"
        Me.ToolStripStatusdate.Size = New System.Drawing.Size(15, 17)
        Me.ToolStripStatusdate.Text = "::"
        '
        'MDInetmini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 453)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDInetmini"
        Me.Text = "NetMini"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HeadAccToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurcheseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusoperator As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusdate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TransactionReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenu As System.Windows.Forms.ToolStripMenuItem

End Class
