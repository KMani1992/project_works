<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransRpt
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
        Me.TabTransRpt = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpBoxproCreate = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTP_TransDtTo = New System.Windows.Forms.DateTimePicker()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.DTP_TransDtFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbProName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabTransRpt.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrpBoxproCreate.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabTransRpt
        '
        Me.TabTransRpt.Controls.Add(Me.TabPage1)
        Me.TabTransRpt.Controls.Add(Me.TabPage2)
        Me.TabTransRpt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabTransRpt.Location = New System.Drawing.Point(0, 0)
        Me.TabTransRpt.Name = "TabTransRpt"
        Me.TabTransRpt.SelectedIndex = 0
        Me.TabTransRpt.Size = New System.Drawing.Size(1088, 526)
        Me.TabTransRpt.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1080, 500)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Transaction Report  Filter"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GrpBoxproCreate)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1074, 494)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1068, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transaction Report  Filter"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrpBoxproCreate
        '
        Me.GrpBoxproCreate.Controls.Add(Me.Label3)
        Me.GrpBoxproCreate.Controls.Add(Me.DTP_TransDtTo)
        Me.GrpBoxproCreate.Controls.Add(Me.BtnClose)
        Me.GrpBoxproCreate.Controls.Add(Me.BtnView)
        Me.GrpBoxproCreate.Controls.Add(Me.DTP_TransDtFrom)
        Me.GrpBoxproCreate.Controls.Add(Me.Label9)
        Me.GrpBoxproCreate.Controls.Add(Me.CmbProName)
        Me.GrpBoxproCreate.Controls.Add(Me.Label2)
        Me.GrpBoxproCreate.Location = New System.Drawing.Point(257, 134)
        Me.GrpBoxproCreate.Name = "GrpBoxproCreate"
        Me.GrpBoxproCreate.Size = New System.Drawing.Size(561, 227)
        Me.GrpBoxproCreate.TabIndex = 31
        Me.GrpBoxproCreate.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(322, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "To :"
        '
        'DTP_TransDtTo
        '
        Me.DTP_TransDtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_TransDtTo.Location = New System.Drawing.Point(378, 38)
        Me.DTP_TransDtTo.Name = "DTP_TransDtTo"
        Me.DTP_TransDtTo.Size = New System.Drawing.Size(147, 22)
        Me.DTP_TransDtTo.TabIndex = 33
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(285, 155)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(79, 35)
        Me.BtnClose.TabIndex = 32
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(206, 155)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(79, 35)
        Me.BtnView.TabIndex = 31
        Me.BtnView.Text = "&View"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'DTP_TransDtFrom
        '
        Me.DTP_TransDtFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_TransDtFrom.Location = New System.Drawing.Point(149, 38)
        Me.DTP_TransDtFrom.Name = "DTP_TransDtFrom"
        Me.DTP_TransDtFrom.Size = New System.Drawing.Size(151, 22)
        Me.DTP_TransDtFrom.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "From :"
        '
        'CmbProName
        '
        Me.CmbProName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProName.FormattingEnabled = True
        Me.CmbProName.Location = New System.Drawing.Point(149, 82)
        Me.CmbProName.Name = "CmbProName"
        Me.CmbProName.Size = New System.Drawing.Size(376, 24)
        Me.CmbProName.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Name :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1080, 500)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Transaction Report  View"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ReportViewer)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1074, 494)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'ReportViewer
        '
        Me.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer.Location = New System.Drawing.Point(3, 42)
        Me.ReportViewer.Name = "ReportViewer"
        Me.ReportViewer.Size = New System.Drawing.Size(1068, 418)
        Me.ReportViewer.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(3, 460)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1068, 31)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(186, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = " Press <Esc> To Go Back"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(3, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(1068, 26)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Transaction Report  View"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmTransRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 526)
        Me.Controls.Add(Me.TabTransRpt)
        Me.Name = "FrmTransRpt"
        Me.Text = "Transaction Report"
        Me.TabTransRpt.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpBoxproCreate.ResumeLayout(False)
        Me.GrpBoxproCreate.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabTransRpt As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GrpBoxproCreate As System.Windows.Forms.GroupBox
    Friend WithEvents DTP_TransDtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbProName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DTP_TransDtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents ReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
