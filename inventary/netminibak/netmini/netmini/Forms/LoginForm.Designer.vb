<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtPwd As System.Windows.Forms.TextBox
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents Btncancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Btncancel = New System.Windows.Forms.Button()
        Me.CmbUserName = New System.Windows.Forms.ComboBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(172, 24)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(172, 81)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(173, 101)
        Me.txtPwd.MaxLength = 20
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(220, 20)
        Me.txtPwd.TabIndex = 2
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(197, 161)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(94, 23)
        Me.BtnLogin.TabIndex = 3
        Me.BtnLogin.Text = "&Login"
        '
        'Btncancel
        '
        Me.Btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btncancel.Location = New System.Drawing.Point(300, 161)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.Size = New System.Drawing.Size(94, 23)
        Me.Btncancel.TabIndex = 4
        Me.Btncancel.Text = "&Cancel"
        '
        'CmbUserName
        '
        Me.CmbUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbUserName.FormattingEnabled = True
        Me.CmbUserName.Location = New System.Drawing.Point(173, 45)
        Me.CmbUserName.MaxLength = 50
        Me.CmbUserName.Name = "CmbUserName"
        Me.CmbUserName.Size = New System.Drawing.Size(220, 21)
        Me.CmbUserName.TabIndex = 1
        '
        'LoginForm
        '
        Me.AcceptButton = Me.BtnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Btncancel
        Me.ClientSize = New System.Drawing.Size(401, 192)
        Me.Controls.Add(Me.CmbUserName)
        Me.Controls.Add(Me.Btncancel)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "LoginForm"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbUserName As System.Windows.Forms.ComboBox

End Class
