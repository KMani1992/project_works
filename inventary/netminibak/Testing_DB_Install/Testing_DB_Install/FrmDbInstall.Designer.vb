<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDbInstall
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
        Me.BtnDbInstall = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblHead = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblFinYear = New System.Windows.Forms.Label()
        Me.LblCmpName = New System.Windows.Forms.Label()
        Me.LblCmpCode = New System.Windows.Forms.Label()
        Me.StatDbInstall = New System.Windows.Forms.StatusStrip()
        Me.LblSrvName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PrgDbInstall = New System.Windows.Forms.ProgressBar()
        Me.ToplStrServer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToplStrStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatDbInstall.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnDbInstall
        '
        Me.BtnDbInstall.Location = New System.Drawing.Point(63, 168)
        Me.BtnDbInstall.Name = "BtnDbInstall"
        Me.BtnDbInstall.Size = New System.Drawing.Size(131, 37)
        Me.BtnDbInstall.TabIndex = 0
        Me.BtnDbInstall.Text = "&DbInstall"
        Me.BtnDbInstall.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(200, 168)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(131, 37)
        Me.BtnExit.TabIndex = 1
        Me.BtnExit.Text = "&Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'LblHead
        '
        Me.LblHead.AutoSize = True
        Me.LblHead.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblHead.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHead.Location = New System.Drawing.Point(189, 19)
        Me.LblHead.Name = "LblHead"
        Me.LblHead.Size = New System.Drawing.Size(332, 23)
        Me.LblHead.TabIndex = 2
        Me.LblHead.Text = "Testing Database Installation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(60, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Company Code :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Company Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Financial Year :"
        '
        'LblFinYear
        '
        Me.LblFinYear.AutoSize = True
        Me.LblFinYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblFinYear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFinYear.Location = New System.Drawing.Point(221, 112)
        Me.LblFinYear.Name = "LblFinYear"
        Me.LblFinYear.Size = New System.Drawing.Size(127, 17)
        Me.LblFinYear.TabIndex = 8
        Me.LblFinYear.Text = "Apr , 2014 - Mar, 2015"
        '
        'LblCmpName
        '
        Me.LblCmpName.AutoSize = True
        Me.LblCmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCmpName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCmpName.Location = New System.Drawing.Point(221, 48)
        Me.LblCmpName.Name = "LblCmpName"
        Me.LblCmpName.Size = New System.Drawing.Size(59, 17)
        Me.LblCmpName.TabIndex = 7
        Me.LblCmpName.Text = "xxxxxxxxxx"
        '
        'LblCmpCode
        '
        Me.LblCmpCode.AutoSize = True
        Me.LblCmpCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblCmpCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCmpCode.Location = New System.Drawing.Point(221, 17)
        Me.LblCmpCode.Name = "LblCmpCode"
        Me.LblCmpCode.Size = New System.Drawing.Size(24, 17)
        Me.LblCmpCode.TabIndex = 6
        Me.LblCmpCode.Text = "xxx"
        '
        'StatDbInstall
        '
        Me.StatDbInstall.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToplStrServer, Me.ToplStrStatus})
        Me.StatDbInstall.Location = New System.Drawing.Point(0, 303)
        Me.StatDbInstall.Name = "StatDbInstall"
        Me.StatDbInstall.Size = New System.Drawing.Size(706, 22)
        Me.StatDbInstall.TabIndex = 10
        Me.StatDbInstall.Text = "StatusStrip1"
        '
        'LblSrvName
        '
        Me.LblSrvName.AutoSize = True
        Me.LblSrvName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSrvName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSrvName.Location = New System.Drawing.Point(221, 80)
        Me.LblSrvName.Name = "LblSrvName"
        Me.LblSrvName.Size = New System.Drawing.Size(49, 17)
        Me.LblSrvName.TabIndex = 12
        Me.LblSrvName.Text = "xxxxxxxx"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Server Name  :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PrgDbInstall)
        Me.GroupBox1.Controls.Add(Me.LblSrvName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LblFinYear)
        Me.GroupBox1.Controls.Add(Me.LblCmpName)
        Me.GroupBox1.Controls.Add(Me.LblCmpCode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtnExit)
        Me.GroupBox1.Controls.Add(Me.BtnDbInstall)
        Me.GroupBox1.Location = New System.Drawing.Point(132, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 243)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'PrgDbInstall
        '
        Me.PrgDbInstall.Location = New System.Drawing.Point(0, 226)
        Me.PrgDbInstall.Name = "PrgDbInstall"
        Me.PrgDbInstall.Size = New System.Drawing.Size(445, 17)
        Me.PrgDbInstall.TabIndex = 13
        '
        'ToplStrServer
        '
        Me.ToplStrServer.Name = "ToplStrServer"
        Me.ToplStrServer.Size = New System.Drawing.Size(39, 17)
        Me.ToplStrServer.Text = "Server"
        '
        'ToplStrStatus
        '
        Me.ToplStrStatus.Name = "ToplStrStatus"
        Me.ToplStrStatus.Size = New System.Drawing.Size(39, 17)
        Me.ToplStrStatus.Text = "Status"
        '
        'FrmDbInstall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 325)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatDbInstall)
        Me.Controls.Add(Me.LblHead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmDbInstall"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DbInstall"
        Me.StatDbInstall.ResumeLayout(False)
        Me.StatDbInstall.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnDbInstall As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents LblHead As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblFinYear As System.Windows.Forms.Label
    Friend WithEvents LblCmpName As System.Windows.Forms.Label
    Friend WithEvents LblCmpCode As System.Windows.Forms.Label
    Friend WithEvents StatDbInstall As System.Windows.Forms.StatusStrip
    Friend WithEvents LblSrvName As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PrgDbInstall As System.Windows.Forms.ProgressBar
    Friend WithEvents ToplStrServer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToplStrStatus As System.Windows.Forms.ToolStripStatusLabel

End Class
