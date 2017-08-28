<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmproduct
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
        Me.Tabpromaster = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GrpBoxBtnCnt = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpBoxproCreate = New System.Windows.Forms.GroupBox()
        Me.Txtprocode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtSellingRate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPurcheseRate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTP_dateofCreation = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbActive = New System.Windows.Forms.ComboBox()
        Me.TxtDisplayOrder = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_ShortName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_ProductName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridProView = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Tabpromaster.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrpBoxBtnCnt.SuspendLayout()
        Me.GrpBoxproCreate.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridProView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabpromaster
        '
        Me.Tabpromaster.Controls.Add(Me.TabPage1)
        Me.Tabpromaster.Controls.Add(Me.TabPage2)
        Me.Tabpromaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabpromaster.Location = New System.Drawing.Point(0, 0)
        Me.Tabpromaster.Name = "Tabpromaster"
        Me.Tabpromaster.SelectedIndex = 0
        Me.Tabpromaster.Size = New System.Drawing.Size(984, 561)
        Me.Tabpromaster.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(976, 535)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Product Master Entry"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GrpBoxBtnCnt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GrpBoxproCreate)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(970, 529)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
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
        Me.Label1.Text = "Product Master"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrpBoxproCreate
        '
        Me.GrpBoxproCreate.Controls.Add(Me.Txtprocode)
        Me.GrpBoxproCreate.Controls.Add(Me.Label10)
        Me.GrpBoxproCreate.Controls.Add(Me.TxtSellingRate)
        Me.GrpBoxproCreate.Controls.Add(Me.Label7)
        Me.GrpBoxproCreate.Controls.Add(Me.TxtPurcheseRate)
        Me.GrpBoxproCreate.Controls.Add(Me.Label6)
        Me.GrpBoxproCreate.Controls.Add(Me.DTP_dateofCreation)
        Me.GrpBoxproCreate.Controls.Add(Me.Label9)
        Me.GrpBoxproCreate.Controls.Add(Me.CmbActive)
        Me.GrpBoxproCreate.Controls.Add(Me.TxtDisplayOrder)
        Me.GrpBoxproCreate.Controls.Add(Me.Label5)
        Me.GrpBoxproCreate.Controls.Add(Me.Label4)
        Me.GrpBoxproCreate.Controls.Add(Me.Txt_ShortName)
        Me.GrpBoxproCreate.Controls.Add(Me.Label3)
        Me.GrpBoxproCreate.Controls.Add(Me.Txt_ProductName)
        Me.GrpBoxproCreate.Controls.Add(Me.Label2)
        Me.GrpBoxproCreate.Location = New System.Drawing.Point(134, 64)
        Me.GrpBoxproCreate.Name = "GrpBoxproCreate"
        Me.GrpBoxproCreate.Size = New System.Drawing.Size(499, 303)
        Me.GrpBoxproCreate.TabIndex = 31
        Me.GrpBoxproCreate.TabStop = False
        '
        'Txtprocode
        '
        Me.Txtprocode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtprocode.Location = New System.Drawing.Point(160, 53)
        Me.Txtprocode.MaxLength = 10
        Me.Txtprocode.Name = "Txtprocode"
        Me.Txtprocode.Size = New System.Drawing.Size(252, 22)
        Me.Txtprocode.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(47, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 16)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Product Code :"
        '
        'TxtSellingRate
        '
        Me.TxtSellingRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSellingRate.Location = New System.Drawing.Point(160, 177)
        Me.TxtSellingRate.MaxLength = 40
        Me.TxtSellingRate.Name = "TxtSellingRate"
        Me.TxtSellingRate.Size = New System.Drawing.Size(252, 22)
        Me.TxtSellingRate.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Selling Rate :"
        '
        'TxtPurcheseRate
        '
        Me.TxtPurcheseRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPurcheseRate.Location = New System.Drawing.Point(160, 147)
        Me.TxtPurcheseRate.MaxLength = 40
        Me.TxtPurcheseRate.Name = "TxtPurcheseRate"
        Me.TxtPurcheseRate.Size = New System.Drawing.Size(252, 22)
        Me.TxtPurcheseRate.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Purchese Rate :"
        '
        'DTP_dateofCreation
        '
        Me.DTP_dateofCreation.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_dateofCreation.Location = New System.Drawing.Point(160, 117)
        Me.DTP_dateofCreation.Name = "DTP_dateofCreation"
        Me.DTP_dateofCreation.Size = New System.Drawing.Size(253, 22)
        Me.DTP_dateofCreation.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(94, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "D.O.C :"
        '
        'CmbActive
        '
        Me.CmbActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbActive.FormattingEnabled = True
        Me.CmbActive.Location = New System.Drawing.Point(160, 240)
        Me.CmbActive.Name = "CmbActive"
        Me.CmbActive.Size = New System.Drawing.Size(253, 24)
        Me.CmbActive.TabIndex = 8
        '
        'TxtDisplayOrder
        '
        Me.TxtDisplayOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDisplayOrder.Location = New System.Drawing.Point(160, 211)
        Me.TxtDisplayOrder.MaxLength = 40
        Me.TxtDisplayOrder.Name = "TxtDisplayOrder"
        Me.TxtDisplayOrder.Size = New System.Drawing.Size(252, 22)
        Me.TxtDisplayOrder.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "DisplayOrder :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Active :"
        '
        'Txt_ShortName
        '
        Me.Txt_ShortName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_ShortName.Location = New System.Drawing.Point(160, 85)
        Me.Txt_ShortName.MaxLength = 30
        Me.Txt_ShortName.Name = "Txt_ShortName"
        Me.Txt_ShortName.Size = New System.Drawing.Size(252, 22)
        Me.Txt_ShortName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ShortName :"
        '
        'Txt_ProductName
        '
        Me.Txt_ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_ProductName.Location = New System.Drawing.Point(160, 25)
        Me.Txt_ProductName.MaxLength = 40
        Me.Txt_ProductName.Name = "Txt_ProductName"
        Me.Txt_ProductName.Size = New System.Drawing.Size(252, 22)
        Me.Txt_ProductName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 28)
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
        Me.TabPage2.Size = New System.Drawing.Size(976, 535)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Product Master View"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.DataGridProView)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(970, 529)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
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
        'DataGridProView
        '
        Me.DataGridProView.AllowUserToAddRows = False
        Me.DataGridProView.AllowUserToDeleteRows = False
        Me.DataGridProView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridProView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridProView.Location = New System.Drawing.Point(3, 42)
        Me.DataGridProView.Name = "DataGridProView"
        Me.DataGridProView.ReadOnly = True
        Me.DataGridProView.Size = New System.Drawing.Size(964, 484)
        Me.DataGridProView.TabIndex = 1
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
        Me.Label12.Text = "Product Master View"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frmproduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Tabpromaster)
        Me.Name = "Frmproduct"
        Me.Text = "Product Master"
        Me.Tabpromaster.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpBoxBtnCnt.ResumeLayout(False)
        Me.GrpBoxproCreate.ResumeLayout(False)
        Me.GrpBoxproCreate.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridProView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabpromaster As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GrpBoxBtnCnt As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents CmbActive As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDisplayOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_ShortName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_ProductName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridProView As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DTP_dateofCreation As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtSellingRate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtPurcheseRate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txtprocode As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GrpBoxproCreate As System.Windows.Forms.GroupBox

End Class
