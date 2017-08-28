Imports System.Data.SqlClient
Public Class FrmOperator
    Dim ds As DataSet
    Private Sub FrmOperator_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.clear()
        GrpBxchngpwd.Visible = False
        controlsvisible(GrpBoxBtnCnt, btncontrols.deflt)
        BtnAdd.Focus()
    End Sub

    Private Sub FrmOperator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbActive.DataSource = actinact
        CmbActive.Text = CmbActive.Items(0)
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Me.clear()
        TxtOperatorCode.ReadOnly = True
        GrpBoxoperCreate.Enabled = True
        controlsvisible(GrpBoxBtnCnt, btncontrols.add)
        Txt_OperatorName.Focus()
    End Sub
    Private Sub clear()
        GrpBxchngpwd.Visible = False
        TxtOperatorCode.ReadOnly = False
        pro_textbxclear(GrpBoxoperCreate)
        GrpBoxoperCreate.Enabled = False
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.clear()
        controlsvisible(GrpBoxBtnCnt, btncontrols.cancel)
        BtnAdd.Focus()
    End Sub

    Private Sub FrmOperator_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With TabOperator
            .Location = New Point(5, 5)
            .Size = New Size(Me.Width - 15, Me.Height - Me.GrpBoxBtnCnt.Height - 10)
        End With
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.clear()
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            conopen()
            sqlcmd = Nothing
            strsql = ""
            strsql = "insert into operator(oper_name,oper_code,short_name,password,confirm_password,dateofcreation,active)"
            strsql = strsql & vbCrLf & " values(@parm1,@parm2,@parm3,@parm4,@parm5,@parm6,@parm7)"
            sqlcmd = New SqlCommand(strsql, dbcon)
            sqlcmd.Parameters.Add(New SqlParameter("@parm1", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm2", SqlDbType.Int))
            sqlcmd.Parameters.Add(New SqlParameter("@parm3", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm4", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm5", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm6", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm7", SqlDbType.VarChar))

            sqlcmd.Parameters(0).Value = Trim(Txt_OperatorName.Text)
            sqlcmd.Parameters(1).Value = Val(Trim(TxtOperatorCode.Text))
            sqlcmd.Parameters(2).Value = Trim(Txt_ShortName.Text)
            sqlcmd.Parameters(3).Value = Encription(Trim(TxtPassword.Text))
            sqlcmd.Parameters(4).Value = Encription(Trim(TxtConfirmPassword.Text))
            sqlcmd.Parameters(5).Value = Trim(DTP_dateofCreation.Value)
            sqlcmd.Parameters(6).Value = Trim(CmbActive.Text)

            'If datareader.IsClosed = False Then
            '    datareader.Close()
            'End If
            datareader = Nothing
            datareader = sqlcmd.ExecuteReader()
            MsgBox("Congratulation! " & vbCrLf & "Operator Has Been Syccessfully Created.", vbInformation, Gsmt.dialogcapt)
            Me.clear()
            controlsvisible(GrpBoxBtnCnt, btncontrols.cancel)
            BtnAdd.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conclose()
            datareader.Close()
        End Try
    End Sub
    Private Sub Txt_OperatorName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Txt_OperatorName.Validating
        If Trim(Txt_OperatorName.Text) <> "" Then
            Try
                conopen()

                strsql = "SELECT OPER_CODE FROM Operator where OPER_NAME=@parm"
                datareader = validatenames(strsql, Trim(Txt_OperatorName.Text))
                If datareader.Read Then
                    MsgBox("Sorry! You Entered UserName Already Exists" & vbCrLf & "Please Enter Another", vbInformation, Gsmt.dialogcapt)
                    Txt_OperatorName.Focus()
                Else
                    datareader.Close()
                    strsql = "SELECT max(OPER_CODE) as maxoper_code FROM Operator"
                    datareader = fn_maxNoGeneration(strsql)
                    If datareader.Read Then
                        TxtOperatorCode.Text = Val(datareader.Item("maxoper_code")) + 1
                    Else
                        TxtOperatorCode.Text = 1
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conclose()
                datareader.Close()
            End Try
        Else
            MsgBox("Please Enter UserName", vbInformation, Gsmt.dialogcapt)
            Txt_OperatorName.Focus()
        End If
    End Sub

    Private Sub TxtConfirmPassword_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtConfirmPassword.Validating
        If Trim(TxtPassword.Text) = "" Then
            disp_msg("Please Enter Password")
            TxtPassword.Focus()
        ElseIf Trim(TxtPassword.Text) <> "" And Trim(TxtPassword.Text) <> Trim(TxtConfirmPassword.Text) Then
            disp_msg("Sorry! You Entered Password and Confirm Password are Not Matching," & vbCrLf & "Please Verify.")
            TxtPassword.Focus()
        End If
    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        Try
            conopen()
            dataadapter = New SqlDataAdapter
            sqldataset = New DataSet
            Me.clear()
            controlsvisible(GrpBoxBtnCnt, btncontrols.view)
            BtnDelete.Enabled = False
            TabOperator.SelectTab(1)
            strsql = ""
            strsql = "select Oper_Name,Oper_Code,Short_Name,"
            strsql = strsql & vbCrLf & "DateOfCreation,Active from operator order by Oper_name "
            dataadapter = fn_tabledataadapter(strsql)
            dataadapter.Fill(sqldataset)
            datareader = sqlcmd.ExecuteReader
            DataGridOperatorView.DataSource = sqldataset.Tables(0)
        Catch ex As Exception
            disp_msg(ex.ToString)
        Finally
            conclose()
            dataadapter.Dispose()
            datareader.Close()
        End Try
    End Sub

    Private Sub DataGridOperatorView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridOperatorView.KeyDown
        If e.KeyCode = Keys.F Then

        ElseIf e.KeyCode = Keys.Escape Then
            Me.clear()
            controlsvisible(GrpBoxBtnCnt, btncontrols.cancel)
            BtnAdd.Focus()
            TabOperator.SelectTab(0)
            BtnClose.Focus()
        ElseIf e.KeyCode = Keys.E Then

            Me.clear()
            GrpBoxoperCreate.Enabled = True
            controlsvisible(GrpBoxBtnCnt, btncontrols.view)
            BtnDelete.Enabled = False
            With DataGridOperatorView
                Txt_OperatorName.Text = .CurrentRow.Cells.Item(0).Value.ToString
                TxtOperatorCode.Text = .CurrentRow.Cells.Item(1).Value.ToString
                Txt_ShortName.Text = .CurrentRow.Cells.Item(2).Value.ToString
                DTP_dateofCreation.Value = CDate(.CurrentRow.Cells.Item(3).Value.ToString)
                CmbActive.Text = .CurrentRow.Cells.Item(4).Value.ToString
            End With
            Txt_OperatorName.Enabled = False
            TxtOperatorCode.Enabled = False
            TxtPassword.Enabled = False
            TxtConfirmPassword.Enabled = False
            TabOperator.SelectTab(0)
            Txt_ShortName.Focus()
        ElseIf e.KeyCode = Keys.C Then
            'GrpBxchngpwd.Visible = True
            'pro_textbxclear(GrpBxchngpwd)
            'TxtOldPassword.Focus()
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Try
            conopen()
            datareader = Nothing
            strsql = "update operator set Short_Name=@parm1,DateOfCreation=@parm2,Active=@parm3 where Oper_Code =@parm4 "
            sqlcmd = New SqlCommand(strsql, dbcon)
            sqlcmd.Parameters.Add(New SqlParameter("@parm1", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm2", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm3", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm4", SqlDbType.Int))
      
            sqlcmd.Parameters(0).Value = Trim(Txt_ShortName.Text)
            sqlcmd.Parameters(1).Value = Trim(DTP_dateofCreation.Value)
            sqlcmd.Parameters(2).Value = Trim(CmbActive.Text)
            sqlcmd.Parameters(3).Value = Val(Trim(TxtOperatorCode.Text))
            sqlcmd.ExecuteNonQuery()
            disp_msg("Successfully Updated!")
            Me.clear()
            controlsvisible(GrpBoxBtnCnt, btncontrols.cancel)
            BtnAdd.Focus()
        Catch ex As Exception
            disp_msg(ex.Message)
        Finally
            conclose()
        End Try
    End Sub
End Class