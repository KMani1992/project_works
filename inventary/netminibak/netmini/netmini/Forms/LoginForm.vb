Imports System.Data.SqlClient
Public Class LoginForm
    Dim login As Boolean
    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        Try
            conopen()
            If Trim(CmbUserName.Text) = "" Or Trim(txtPwd.Text) = "" Then
                MsgBox("Please Enter Your User Name and Password", vbInformation, Gsmt.dialogcapt)
                CmbUserName.Focus()
                Exit Sub
            End If

            strsql = "SELECT oper_name,oper_code FROM operator where oper_code=@parm1 and password=@parm2"
            sqlcmd = New SqlCommand(strsql, dbcon)
            parm1 = New SqlParameter("@parm1", SqlDbType.VarChar, 0)
            parm2 = New SqlParameter("@parm2", SqlDbType.VarChar, 0)
            sqlcmd.Parameters.Add(parm1)
            sqlcmd.Parameters.Add(parm2)
            sqlcmd.Parameters(0).Value = Trim(CmbUserName.Tag)
            sqlcmd.Parameters(1).Value = Encription(Trim(txtPwd.Text))
            'If datareader.IsClosed = False Then
            '    datareader.Close()
            'End If
            datareader = Nothing
            datareader = sqlcmd.ExecuteReader
            If datareader.Read Then
                Gsmt.Operatorname = datareader.Item("oper_name")
                Gsmt.OperatorCode = datareader.Item("oper_code")
                MDInetmini.ToolStripStatusoperator.Text = "Operator : " & Gsmt.Operatorname
                MDInetmini.ToolStripStatusdate.Text = "Date : " & Date.Now
                MDInetmini.Text = MDInetmini.Text & Space(5) & "Operator : " & Gsmt.Operatorname
                login = True
                Me.Close()
            Else
                login = False
                MsgBox("Sory! Login Failed, " & vbCrLf & " Please Check Your User Name and Password", vbInformation, Gsmt.dialogcapt)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Gsmt.dialogcapt)
        Finally
            conclose()
            datareader.Close()
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancel.Click
        End
    End Sub

    Private Sub LoginForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        With MDInetmini
            .ToolStripStatusdate.Text = "::"
            .ToolStripStatusoperator.Text = "::"
        End With
        login = False
        txtPwd.Text = ""
        If CmbUserName.Items.Count > 0 Then CmbUserName.SelectedItem = CmbUserName.Items(0)
    End Sub

    Private Sub LoginForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If login = False Then End
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conopen()
            strsql = "SELECT OPER_NAME FROM Operator order by OPER_NAME"
            datareader = readrecordset(strsql)
            With CmbUserName
                .Items.Clear()
                Do While datareader.Read
                    .Items.Add(datareader.Item("OPER_NAME"))
                Loop
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Gsmt.dialogcapt)
        Finally
            conclose()
            datareader.Close()
        End Try
    End Sub

    Private Sub CmbUserName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbUserName.GotFocus
        SendKeys.Send("{F4}")
    End Sub
    Private Sub CmbUserName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CmbUserName.Validating
        With CmbUserName
            If .Text = "" Then
                MsgBox("Please Choose Valid User Name", vbInformation, Gsmt.dialogcapt)
                Exit Sub
            End If
            .Tag = ""
            Try
                conopen()
                strsql = "SELECT OPER_CODE FROM Operator where OPER_NAME=@parm"
                datareader = validatenames(strsql, Trim(CmbUserName.Text))
                If datareader.Read Then
                    CmbUserName.Tag = datareader.Item("OPER_CODE")
                Else
                    MsgBox("Please Choose Valid User Name", vbInformation, Gsmt.dialogcapt)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbInformation, Gsmt.dialogcapt)
            Finally
                conclose()
                datareader.Close()
            End Try
        End With
    End Sub
End Class
