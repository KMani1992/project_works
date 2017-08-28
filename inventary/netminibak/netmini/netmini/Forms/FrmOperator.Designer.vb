<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOperator
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
        Me.TabOperator = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GrpBoxCont = New System.Windows.Forms.GroupBox()
        Me.GrpBoxBtnCnt = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpBoxoperCreate = New System.Windows.Forms.GroupBox()
        Me.TxtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtOperatorCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTP_dateofCreation = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbActive = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_ShortName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_OperatorName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GrpBxchngpwd = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Txtchgconfirmpass = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txtchgnewpass = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtOldPassword = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridOperatorView = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabOperator.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GrpBoxCont.SuspendLayout()
        Me.GrpBoxBtnCnt.SuspendLayout()
        Me.GrpBoxoperCreate.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GrpBxchngpwd.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridOperatorView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabOperator
        '
        Me.TabOperator.Controls.Add(Me.TabPage1)
        Me.TabOperator.Controls.Add(Me.TabPage2)
        Me.TabOperator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabOperator.Location = New System.Drawing.Point(0, 0)
        Me.TabOperator.Name = "TabOperator"
        Me.TabOperator.SelectedIndex = 0
        Me.TabOperator.Size = New System.Drawing.Size(984, 561)
        Me.TabOperator.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GrpBoxCont)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(976, 535)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Operator Creation "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GrpBoxCont
        '
        Me.GrpBoxCont.Controls.Add(Me.GrpBoxBtnCnt)
        Me.GrpBoxCont.Controls.Add(Me.Label1)
        Me.GrpBoxCont.Controls.Add(Me.GrpBoxoperCreate)
        Me.GrpBoxCont.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpBoxCont.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpBoxCont.Location = New System.Drawing.Point(3, 3)
        Me.GrpBoxCont.Name = "GrpBoxCont"
        Me.GrpBoxCont.Size = New System.Drawing.Size(970, 529)
        Me.GrpBoxCont.TabIndex = 1
        Me.GrpBoxCont.TabStop = False
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
        Me.GrpBoxBtnCnt.Location = New System.Drawing.Point(3, 467)
        Me.GrpBoxBtnCnt.Name = "GrpBoxBtnCnt"
        Me.GrpBoxBtnCnt.Size = New System.Drawing.Size(964, 59)
        Me.GrpBoxBtnCnt.TabIndex = 23
        Me.GrpBoxBtnCnt.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(551, 16)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(79, 35)
        Me.BtnClose.TabIndex = 15
        Me.BtnClose.Text = "Cl&ose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(472, 16)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(79, 35)
        Me.BtnCancel.TabIndex = 14
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(393, 16)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(79, 35)
        Me.BtnView.TabIndex = 13
        Me.BtnView.Text = "&View"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(315, 16)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(79, 35)
        Me.BtnDelete.TabIndex = 12
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(237, 16)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(79, 35)
        Me.BtnEdit.TabIndex = 11
        Me.BtnEdit.Text = "&Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(159, 16)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(79, 35)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(81, 16)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(79, 35)
        Me.BtnAdd.TabIndex = 9
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
        Me.Label1.Size = New System.Drawing.Size(964, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Operator Creation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrpBoxoperCreate
        '
        Me.GrpBoxoperCreate.Controls.Add(Me.TxtConfirmPassword)
        Me.GrpBoxoperCreate.Controls.Add(Me.Label7)
        Me.GrpBoxoperCreate.Controls.Add(Me.TxtPassword)
        Me.GrpBoxoperCreate.Controls.Add(Me.Label6)
        Me.GrpBoxoperCreate.Controls.Add(Me.TxtOperatorCode)
        Me.GrpBoxoperCreate.Controls.Add(Me.Label5)
        Me.GrpBoxoperCreate.Controls.Add(Me.DTP_dateofCreation)
        Me.GrpBoxoperCreate.Controls.Add(Me.Label9)
        Me.GrpBoxoperCreate.Controls.Add(Me.CmbActive)
        Me.GrpBoxoperCreate.Controls.Add(Me.Label4)
        Me.GrpBoxoperCreate.Controls.Add(Me.Txt_ShortName)
        Me.GrpBoxoperCreate.Controls.Add(Me.Label3)
        Me.GrpBoxoperCreate.Controls.Add(Me.Txt_OperatorName)
        Me.GrpBoxoperCreate.Controls.Add(Me.Label2)
        Me.GrpBoxoperCreate.Location = New System.Drawing.Point(130, 57)
        Me.GrpBoxoperCreate.Name = "GrpBoxoperCreate"
        Me.GrpBoxoperCreate.Size = New System.Drawing.Size(514, 290)
        Me.GrpBoxoperCreate.TabIndex = 31
        Me.GrpBoxoperCreate.TabStop = False
        '
        'TxtConfirmPassword
        '
        Me.TxtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(173, 150)
        Me.TxtConfirmPassword.MaxLength = 20
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(252, 22)
        Me.TxtConfirmPassword.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Confirm password :"
        '
        'TxtPassword
        '
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassword.Location = New System.Drawing.Point(173, 119)
        Me.TxtPassword.MaxLength = 20
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(252, 22)
        Me.TxtPassword.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Password :"
        '
        'TxtOperatorCode
        '
        Me.TxtOperatorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOperatorCode.Location = New System.Drawing.Point(173, 55)
        Me.TxtOperatorCode.MaxLength = 4
        Me.TxtOperatorCode.Name = "TxtOperatorCode"
        Me.TxtOperatorCode.Size = New System.Drawing.Size(252, 22)
        Me.TxtOperatorCode.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Operator Code :"
        '
        'DTP_dateofCreation
        '
        Me.DTP_dateofCreation.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_dateofCreation.Location = New System.Drawing.Point(173, 181)
        Me.DTP_dateofCreation.Name = "DTP_dateofCreation"
        Me.DTP_dateofCreation.Size = New System.Drawing.Size(253, 22)
        Me.DTP_dateofCreation.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(105, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "D.O.C :"
        '
        'CmbActive
        '
        Me.CmbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbActive.FormattingEnabled = True
        Me.CmbActive.Location = New System.Drawing.Point(173, 212)
        Me.CmbActive.Name = "CmbActive"
        Me.CmbActive.Size = New System.Drawing.Size(253, 24)
        Me.CmbActive.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Active :"
        '
        'Txt_ShortName
        '
        Me.Txt_ShortName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_ShortName.Location = New System.Drawing.Point(173, 88)
        Me.Txt_ShortName.MaxLength = 20
        Me.Txt_ShortName.Name = "Txt_ShortName"
        Me.Txt_ShortName.Size = New System.Drawing.Size(252, 22)
        Me.Txt_ShortName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ShortName :"
        '
        'Txt_OperatorName
        '
        Me.Txt_OperatorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_OperatorName.Location = New System.Drawing.Point(173, 27)
        Me.Txt_OperatorName.MaxLength = 50
        Me.Txt_OperatorName.Name = "Txt_OperatorName"
        Me.Txt_OperatorName.Size = New System.Drawing.Size(252, 22)
        Me.Txt_OperatorName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Operator Name :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(976, 535)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Operator View"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GrpBxchngpwd)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.DataGridOperatorView)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(970, 529)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'GrpBxchngpwd
        '
        Me.GrpBxchngpwd.Controls.Add(Me.Button1)
        Me.GrpBxchngpwd.Controls.Add(Me.Button2)
        Me.GrpBxchngpwd.Controls.Add(Me.Txtchgconfirmpass)
        Me.GrpBxchngpwd.Controls.Add(Me.Label11)
        Me.GrpBxchngpwd.Controls.Add(Me.Txtchgnewpass)
        Me.GrpBxchngpwd.Controls.Add(Me.Label13)
        Me.GrpBxchngpwd.Controls.Add(Me.TxtOldPassword)
        Me.GrpBxchngpwd.Controls.Add(Me.Label10)
        Me.GrpBxchngpwd.Location = New System.Drawing.Point(270, 153)
        Me.GrpBxchngpwd.Name = "GrpBxchngpwd"
        Me.GrpBxchngpwd.Size = New System.Drawing.Size(403, 161)
        Me.GrpBxchngpwd.TabIndex = 35
        Me.GrpBxchngpwd.TabStop = False
        Me.GrpBxchngpwd.Text = "Change Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 35)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "&Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(125, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 35)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "&Change Password"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Txtchgconfirmpass
        '
        Me.Txtchgconfirmpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtchgconfirmpass.Location = New System.Drawing.Point(131, 81)
        Me.Txtchgconfirmpass.MaxLength = 20
        Me.Txtchgconfirmpass.Name = "Txtchgconfirmpass"
        Me.Txtchgconfirmpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtchgconfirmpass.Size = New System.Drawing.Size(252, 20)
        Me.Txtchgconfirmpass.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Confirm password :"
        '
        'Txtchgnewpass
        '
        Me.Txtchgnewpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtchgnewpass.Location = New System.Drawing.Point(131, 50)
        Me.Txtchgnewpass.MaxLength = 20
        Me.Txtchgnewpass.Name = "Txtchgnewpass"
        Me.Txtchgnewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtchgnewpass.Size = New System.Drawing.Size(252, 20)
        Me.Txtchgnewpass.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "New Password :"
        '
        'TxtOldPassword
        '
        Me.TxtOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOldPassword.Location = New System.Drawing.Point(131, 22)
        Me.TxtOldPassword.MaxLength = 20
        Me.TxtOldPassword.Name = "TxtOldPassword"
        Me.TxtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtOldPassword.Size = New System.Drawing.Size(252, 20)
        Me.TxtOldPassword.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Old Password :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(3, 495)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(964, 31)
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
        Me.Label8.Size = New System.Drawing.Size(314, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Press <E> To Edit, Press <Esc> To Go Back"
        '
        'DataGridOperatorView
        '
        Me.DataGridOperatorView.AllowUserToAddRows = False
        Me.DataGridOperatorView.AllowUserToDeleteRows = False
        Me.DataGridOperatorView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridOperatorView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridOperatorView.Location = New System.Drawing.Point(3, 42)
        Me.DataGridOperatorView.Name = "DataGridOperatorView"
        Me.DataGridOperatorView.ReadOnly = True
        Me.DataGridOperatorView.Size = New System.Drawing.Size(964, 484)
        Me.DataGridOperatorView.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(3, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(964, 26)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Operator View"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmOperator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.TabOperator)
        Me.Name = "FrmOperator"
        Me.Text = "FrmOperator"
        Me.TabOperator.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GrpBoxCont.ResumeLayout(False)
        Me.GrpBoxBtnCnt.ResumeLayout(False)
        Me.GrpBoxoperCreate.ResumeLayout(False)
        Me.GrpBoxoperCreate.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GrpBxchngpwd.ResumeLayout(False)
        Me.GrpBxchngpwd.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridOperatorView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabOperator As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GrpBoxCont As System.Windows.Forms.GroupBox
    Friend WithEvents DTP_dateofCreation As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GrpBoxBtnCnt As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents CmbActive As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_ShortName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_OperatorName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridOperatorView As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtOperatorCode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GrpBxchngpwd As System.Windows.Forms.GroupBox
    Friend WithEvents TxtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Txtchgconfirmpass As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txtchgnewpass As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GrpBoxoperCreate As System.Windows.Forms.GroupBox
End Class
