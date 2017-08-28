<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchese
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
        Me.Tabpurchese = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GrpBoxPurchese = New System.Windows.Forms.GroupBox()
        Me.Cmbpartyname = New System.Windows.Forms.ComboBox()
        Me.DTPpurdate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridpurchese = New System.Windows.Forms.DataGridView()
        Me.Colsno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColProname = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Colpieces = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colamt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txt_purno = New System.Windows.Forms.TextBox()
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridPurcheseview = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DtpSPurdateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnViewPurchese = New System.Windows.Forms.Button()
        Me.DtpSPurdateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSPurno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Tabpurchese.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrpBoxPurchese.SuspendLayout()
        CType(Me.DataGridpurchese, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBoxBtnCnt.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridPurcheseview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabpurchese
        '
        Me.Tabpurchese.Controls.Add(Me.TabPage1)
        Me.Tabpurchese.Controls.Add(Me.TabPage2)
        Me.Tabpurchese.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabpurchese.Location = New System.Drawing.Point(0, 0)
        Me.Tabpurchese.Name = "Tabpurchese"
        Me.Tabpurchese.SelectedIndex = 0
        Me.Tabpurchese.Size = New System.Drawing.Size(1068, 564)
        Me.Tabpurchese.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1060, 538)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Purchese Entry"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GrpBoxPurchese)
        Me.GroupBox1.Controls.Add(Me.GrpBoxBtnCnt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1054, 532)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'GrpBoxPurchese
        '
        Me.GrpBoxPurchese.Controls.Add(Me.Cmbpartyname)
        Me.GrpBoxPurchese.Controls.Add(Me.DTPpurdate)
        Me.GrpBoxPurchese.Controls.Add(Me.Label4)
        Me.GrpBoxPurchese.Controls.Add(Me.Label3)
        Me.GrpBoxPurchese.Controls.Add(Me.DataGridpurchese)
        Me.GrpBoxPurchese.Controls.Add(Me.Txt_purno)
        Me.GrpBoxPurchese.Controls.Add(Me.Label2)
        Me.GrpBoxPurchese.Location = New System.Drawing.Point(42, 49)
        Me.GrpBoxPurchese.Name = "GrpBoxPurchese"
        Me.GrpBoxPurchese.Size = New System.Drawing.Size(749, 325)
        Me.GrpBoxPurchese.TabIndex = 28
        Me.GrpBoxPurchese.TabStop = False
        '
        'Cmbpartyname
        '
        Me.Cmbpartyname.FormattingEnabled = True
        Me.Cmbpartyname.Location = New System.Drawing.Point(505, 38)
        Me.Cmbpartyname.Name = "Cmbpartyname"
        Me.Cmbpartyname.Size = New System.Drawing.Size(201, 24)
        Me.Cmbpartyname.TabIndex = 3
        '
        'DTPpurdate
        '
        Me.DTPpurdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPpurdate.Location = New System.Drawing.Point(264, 39)
        Me.DTPpurdate.Name = "DTPpurdate"
        Me.DTPpurdate.Size = New System.Drawing.Size(200, 22)
        Me.DTPpurdate.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(505, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Party Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Purchese Date :"
        '
        'DataGridpurchese
        '
        Me.DataGridpurchese.AllowUserToDeleteRows = False
        Me.DataGridpurchese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridpurchese.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Colsno, Me.ColProname, Me.Colpieces, Me.Colamt})
        Me.DataGridpurchese.Location = New System.Drawing.Point(26, 84)
        Me.DataGridpurchese.Name = "DataGridpurchese"
        Me.DataGridpurchese.Size = New System.Drawing.Size(680, 213)
        Me.DataGridpurchese.TabIndex = 4
        '
        'Colsno
        '
        Me.Colsno.HeaderText = "S.No"
        Me.Colsno.MaxInputLength = 4
        Me.Colsno.Name = "Colsno"
        Me.Colsno.ReadOnly = True
        '
        'ColProname
        '
        Me.ColProname.HeaderText = "Product Name"
        Me.ColProname.Name = "ColProname"
        Me.ColProname.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColProname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColProname.Width = 320
        '
        'Colpieces
        '
        Me.Colpieces.HeaderText = "Pieces"
        Me.Colpieces.MaxInputLength = 4
        Me.Colpieces.Name = "Colpieces"
        '
        'Colamt
        '
        Me.Colamt.HeaderText = "Pur Amt"
        Me.Colamt.MaxInputLength = 10
        Me.Colamt.Name = "Colamt"
        Me.Colamt.ReadOnly = True
        Me.Colamt.Width = 120
        '
        'Txt_purno
        '
        Me.Txt_purno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_purno.Location = New System.Drawing.Point(26, 39)
        Me.Txt_purno.MaxLength = 10
        Me.Txt_purno.Name = "Txt_purno"
        Me.Txt_purno.Size = New System.Drawing.Size(201, 22)
        Me.Txt_purno.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Purchese No :"
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
        Me.GrpBoxBtnCnt.Location = New System.Drawing.Point(3, 470)
        Me.GrpBoxBtnCnt.Name = "GrpBoxBtnCnt"
        Me.GrpBoxBtnCnt.Size = New System.Drawing.Size(1048, 59)
        Me.GrpBoxBtnCnt.TabIndex = 23
        Me.GrpBoxBtnCnt.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(551, 16)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(79, 35)
        Me.BtnClose.TabIndex = 11
        Me.BtnClose.Text = "Cl&ose"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(472, 16)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(79, 35)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnView
        '
        Me.BtnView.Location = New System.Drawing.Point(393, 16)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(79, 35)
        Me.BtnView.TabIndex = 9
        Me.BtnView.Text = "&View"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(315, 16)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(79, 35)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "&Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(237, 16)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(79, 35)
        Me.BtnEdit.TabIndex = 7
        Me.BtnEdit.Text = "&Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(159, 16)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(79, 35)
        Me.BtnSave.TabIndex = 6
        Me.BtnSave.Text = "&Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(81, 16)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(79, 35)
        Me.BtnAdd.TabIndex = 5
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
        Me.Label1.Size = New System.Drawing.Size(1048, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchese Entry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1060, 538)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Purchese Entry View"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1054, 532)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridPurcheseview)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(3, 118)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1048, 380)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        '
        'DataGridPurcheseview
        '
        Me.DataGridPurcheseview.AllowUserToAddRows = False
        Me.DataGridPurcheseview.AllowUserToDeleteRows = False
        Me.DataGridPurcheseview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPurcheseview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridPurcheseview.Location = New System.Drawing.Point(3, 16)
        Me.DataGridPurcheseview.Name = "DataGridPurcheseview"
        Me.DataGridPurcheseview.ReadOnly = True
        Me.DataGridPurcheseview.Size = New System.Drawing.Size(1042, 361)
        Me.DataGridPurcheseview.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DtpSPurdateTo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.BtnClear)
        Me.GroupBox2.Controls.Add(Me.BtnViewPurchese)
        Me.GroupBox2.Controls.Add(Me.DtpSPurdateFrom)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtSPurno)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(3, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1048, 76)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'DtpSPurdateTo
        '
        Me.DtpSPurdateTo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpSPurdateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpSPurdateTo.Location = New System.Drawing.Point(490, 37)
        Me.DtpSPurdateTo.Name = "DtpSPurdateTo"
        Me.DtpSPurdateTo.Size = New System.Drawing.Size(200, 22)
        Me.DtpSPurdateTo.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(487, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Purchese Date To :"
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(837, 28)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(94, 35)
        Me.BtnClear.TabIndex = 5
        Me.BtnClear.Text = "&Cancel"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnViewPurchese
        '
        Me.BtnViewPurchese.Location = New System.Drawing.Point(744, 28)
        Me.BtnViewPurchese.Name = "BtnViewPurchese"
        Me.BtnViewPurchese.Size = New System.Drawing.Size(94, 35)
        Me.BtnViewPurchese.TabIndex = 4
        Me.BtnViewPurchese.Text = "&View Purchese"
        Me.BtnViewPurchese.UseVisualStyleBackColor = True
        '
        'DtpSPurdateFrom
        '
        Me.DtpSPurdateFrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpSPurdateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpSPurdateFrom.Location = New System.Drawing.Point(257, 35)
        Me.DtpSPurdateFrom.Name = "DtpSPurdateFrom"
        Me.DtpSPurdateFrom.Size = New System.Drawing.Size(200, 22)
        Me.DtpSPurdateFrom.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(254, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Purchese Date From :"
        '
        'TxtSPurno
        '
        Me.TxtSPurno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSPurno.Location = New System.Drawing.Point(19, 35)
        Me.TxtSPurno.MaxLength = 10
        Me.TxtSPurno.Name = "TxtSPurno"
        Me.TxtSPurno.Size = New System.Drawing.Size(201, 20)
        Me.TxtSPurno.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Purchese No :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(3, 498)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1048, 31)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(400, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Press <C> To CancelPurchese, Press <Esc> To Go Back"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(3, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(1048, 26)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Purchese Entry View"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmPurchese
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 564)
        Me.Controls.Add(Me.Tabpurchese)
        Me.Name = "FrmPurchese"
        Me.Text = "FrmPurchese"
        Me.Tabpurchese.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpBoxPurchese.ResumeLayout(False)
        Me.GrpBoxPurchese.PerformLayout()
        CType(Me.DataGridpurchese, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBoxBtnCnt.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridPurcheseview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabpurchese As System.Windows.Forms.TabControl
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
    Friend WithEvents Txt_purno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DataGridpurchese As System.Windows.Forms.DataGridView
    Friend WithEvents DTPpurdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cmbpartyname As System.Windows.Forms.ComboBox
    Friend WithEvents Colsno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColProname As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Colpieces As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Colamt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnViewPurchese As System.Windows.Forms.Button
    Friend WithEvents DtpSPurdateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtSPurno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridPurcheseview As System.Windows.Forms.DataGridView
    Friend WithEvents GrpBoxPurchese As System.Windows.Forms.GroupBox
    Friend WithEvents DtpSPurdateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
