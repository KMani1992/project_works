<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHeadAcc
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
        Me.TabHeadAccount = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GrpBoxHeadAcc = New System.Windows.Forms.GroupBox()
        Me.CmbActive = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Cmbheadatype = New System.Windows.Forms.ComboBox()
        Me.DTP_dateofjoin = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtPhone2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPhone1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtaddress2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtAddress1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_HEADACODE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_HeadaName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrpBoxBtnCnt = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridHeadAccView = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabHeadAccount.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrpBoxHeadAcc.SuspendLayout()
        Me.GrpBoxBtnCnt.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridHeadAccView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabHeadAccount
        '
        Me.TabHeadAccount.Controls.Add(Me.TabPage1)
        Me.TabHeadAccount.Controls.Add(Me.TabPage2)
        Me.TabHeadAccount.Location = New System.Drawing.Point(0, 0)
        Me.TabHeadAccount.Name = "TabHeadAccount"
        Me.TabHeadAccount.SelectedIndex = 0
        Me.TabHeadAccount.Size = New System.Drawing.Size(1063, 535)
        Me.TabHeadAccount.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1055, 509)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Head Account Creation Entry"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GrpBoxHeadAcc)
        Me.GroupBox1.Controls.Add(Me.GrpBoxBtnCnt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1049, 503)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GrpBoxHeadAcc
        '
        Me.GrpBoxHeadAcc.Controls.Add(Me.CmbActive)
        Me.GrpBoxHeadAcc.Controls.Add(Me.Label11)
        Me.GrpBoxHeadAcc.Controls.Add(Me.Cmbheadatype)
        Me.GrpBoxHeadAcc.Controls.Add(Me.DTP_dateofjoin)
        Me.GrpBoxHeadAcc.Controls.Add(Me.Label9)
        Me.GrpBoxHeadAcc.Controls.Add(Me.TxtEmail)
        Me.GrpBoxHeadAcc.Controls.Add(Me.Label10)
        Me.GrpBoxHeadAcc.Controls.Add(Me.TxtPhone2)
        Me.GrpBoxHeadAcc.Controls.Add(Me.Label7)
        Me.GrpBoxHeadAcc.Controls.Add(Me.TxtPhone1)
        Me.GrpBoxHeadAcc.Controls.Add(Me.Label8)
        Me.GrpBoxHeadAcc.Controls.Add(Me.Txtaddress2)
        Me.GrpBoxHeadAcc.Controls.Add(Me.Label6)
        Me.GrpBoxHeadAcc.Controls.Add(Me.TxtAddress1)
        Me.GrpBoxHeadAcc.Controls.Add(Me.Label5)
        Me.GrpBoxHeadAcc.Controls.Add(Me.Label4)
        Me.GrpBoxHeadAcc.Controls.Add(Me.Txt_HEADACODE)
        Me.GrpBoxHeadAcc.Controls.Add(Me.Label3)
        Me.GrpBoxHeadAcc.Controls.Add(Me.Txt_HeadaName)
        Me.GrpBoxHeadAcc.Controls.Add(Me.Label2)
        Me.GrpBoxHeadAcc.Location = New System.Drawing.Point(84, 61)
        Me.GrpBoxHeadAcc.Name = "GrpBoxHeadAcc"
        Me.GrpBoxHeadAcc.Size = New System.Drawing.Size(547, 326)
        Me.GrpBoxHeadAcc.TabIndex = 24
        Me.GrpBoxHeadAcc.TabStop = False
        '
        'CmbActive
        '
        Me.CmbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbActive.FormattingEnabled = True
        Me.CmbActive.Location = New System.Drawing.Point(219, 285)
        Me.CmbActive.Name = "CmbActive"
        Me.CmbActive.Size = New System.Drawing.Size(253, 24)
        Me.CmbActive.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(139, 289)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 16)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Active :"
        '
        'Cmbheadatype
        '
        Me.Cmbheadatype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbheadatype.FormattingEnabled = True
        Me.Cmbheadatype.Location = New System.Drawing.Point(219, 82)
        Me.Cmbheadatype.Name = "Cmbheadatype"
        Me.Cmbheadatype.Size = New System.Drawing.Size(253, 24)
        Me.Cmbheadatype.TabIndex = 3
        '
        'DTP_dateofjoin
        '
        Me.DTP_dateofjoin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_dateofjoin.Location = New System.Drawing.Point(219, 254)
        Me.DTP_dateofjoin.Name = "DTP_dateofjoin"
        Me.DTP_dateofjoin.Size = New System.Drawing.Size(253, 22)
        Me.DTP_dateofjoin.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(140, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "D.O.J :"
        '
        'TxtEmail
        '
        Me.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmail.Location = New System.Drawing.Point(219, 224)
        Me.TxtEmail.MaxLength = 30
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(252, 22)
        Me.TxtEmail.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(136, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "E-mail :"
        '
        'TxtPhone2
        '
        Me.TxtPhone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPhone2.Location = New System.Drawing.Point(219, 196)
        Me.TxtPhone2.MaxLength = 13
        Me.TxtPhone2.Name = "TxtPhone2"
        Me.TxtPhone2.Size = New System.Drawing.Size(252, 22)
        Me.TxtPhone2.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(125, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Phone 2 :"
        '
        'TxtPhone1
        '
        Me.TxtPhone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPhone1.Location = New System.Drawing.Point(219, 168)
        Me.TxtPhone1.MaxLength = 13
        Me.TxtPhone1.Name = "TxtPhone1"
        Me.TxtPhone1.Size = New System.Drawing.Size(252, 22)
        Me.TxtPhone1.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(125, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Phone 1 :"
        '
        'Txtaddress2
        '
        Me.Txtaddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtaddress2.Location = New System.Drawing.Point(219, 140)
        Me.Txtaddress2.MaxLength = 20
        Me.Txtaddress2.Name = "Txtaddress2"
        Me.Txtaddress2.Size = New System.Drawing.Size(252, 22)
        Me.Txtaddress2.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(114, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Address 2 :"
        '
        'TxtAddress1
        '
        Me.TxtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAddress1.Location = New System.Drawing.Point(219, 112)
        Me.TxtAddress1.MaxLength = 20
        Me.TxtAddress1.Name = "TxtAddress1"
        Me.TxtAddress1.Size = New System.Drawing.Size(252, 22)
        Me.TxtAddress1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(114, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Address 1 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Heada Account Type :"
        '
        'Txt_HEADACODE
        '
        Me.Txt_HEADACODE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_HEADACODE.Location = New System.Drawing.Point(219, 54)
        Me.Txt_HEADACODE.MaxLength = 10
        Me.Txt_HEADACODE.Name = "Txt_HEADACODE"
        Me.Txt_HEADACODE.Size = New System.Drawing.Size(252, 22)
        Me.Txt_HEADACODE.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Heada Account Code :"
        '
        'Txt_HeadaName
        '
        Me.Txt_HeadaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_HeadaName.Location = New System.Drawing.Point(219, 25)
        Me.Txt_HeadaName.MaxLength = 40
        Me.Txt_HeadaName.Name = "Txt_HeadaName"
        Me.Txt_HeadaName.Size = New System.Drawing.Size(252, 22)
        Me.Txt_HeadaName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Heada Account Name :"
        '
        'GrpBoxBtnCnt
        '
        Me.GrpBoxBtnCnt.Controls.Add(Me.BtnClose)
        Me.GrpBoxBtnCnt.Controls.Add(Me.BtnCancel)
        Me.GrpBoxBtnCnt.Controls.Add(Me.BtnView)
        Me.GrpBoxBtnCnt.Controls.Add(Me.BtnDelete)
        Me.GrpBoxBtnCnt.Controls.Add(Me.BtnEdit)
        Me.GrpBoxBtnCnt.Controls.Add(Me.BtnSave)
        Me.GrpBoxBtnCnt.Controls.Add(Me.BtnAdd)
        Me.GrpBoxBtnCnt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrpBoxBtnCnt.Location = New System.Drawing.Point(3, 441)
        Me.GrpBoxBtnCnt.Name = "GrpBoxBtnCnt"
        Me.GrpBoxBtnCnt.Size = New System.Drawing.Size(1043, 59)
        Me.GrpBoxBtnCnt.TabIndex = 23
        Me.GrpBoxBtnCnt.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(549, 16)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(79, 35)
        Me.BtnClose.TabIndex = 17
        Me.BtnClose.Text = "Cl&ose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(471, 16)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(79, 35)
        Me.BtnCancel.TabIndex = 16
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(393, 16)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(79, 35)
        Me.BtnView.TabIndex = 15
        Me.BtnView.Text = "&View"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(315, 16)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(79, 35)
        Me.BtnDelete.TabIndex = 14
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(237, 16)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(79, 35)
        Me.BtnEdit.TabIndex = 13
        Me.BtnEdit.Text = "&Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(159, 16)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(79, 35)
        Me.BtnSave.TabIndex = 12
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(81, 16)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(79, 35)
        Me.BtnAdd.TabIndex = 11
        Me.BtnAdd.Text = "&Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1043, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Head Account Creation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1055, 509)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Head Account Creation View"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.DataGridHeadAccView)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1049, 503)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(3, 469)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1043, 31)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(314, 18)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Press <E> To Edit, Press <Esc> To Go Back"
        '
        'DataGridHeadAccView
        '
        Me.DataGridHeadAccView.AllowUserToAddRows = False
        Me.DataGridHeadAccView.AllowUserToDeleteRows = False
        Me.DataGridHeadAccView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridHeadAccView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridHeadAccView.Location = New System.Drawing.Point(3, 42)
        Me.DataGridHeadAccView.Name = "DataGridHeadAccView"
        Me.DataGridHeadAccView.ReadOnly = True
        Me.DataGridHeadAccView.Size = New System.Drawing.Size(1043, 458)
        Me.DataGridHeadAccView.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(3, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(1043, 26)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Head Account View"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmHeadAcc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1063, 535)
        Me.Controls.Add(Me.TabHeadAccount)
        Me.Name = "FrmHeadAcc"
        Me.Text = "HeadAccount"
        Me.TabHeadAccount.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpBoxHeadAcc.ResumeLayout(False)
        Me.GrpBoxHeadAcc.PerformLayout()
        Me.GrpBoxBtnCnt.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridHeadAccView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabHeadAccount As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridHeadAccView As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBoxBtnCnt As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GrpBoxHeadAcc As System.Windows.Forms.GroupBox
    Friend WithEvents CmbActive As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Cmbheadatype As System.Windows.Forms.ComboBox
    Friend WithEvents DTP_dateofjoin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtPhone2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtPhone1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txtaddress2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_HEADACODE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_HeadaName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
