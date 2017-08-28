Imports System.Data.SqlClient
Public Class FrmHeadAcc
    Private Sub FrmHeadAcc_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.clear()
        controlsvisible(GrpBoxBtnCnt, btncontrols.deflt)
        BtnAdd.Focus()
    End Sub
    Private Sub clear()
        pro_textbxclear(GrpBoxHeadAcc)
        GrpBoxHeadAcc.Enabled = False
        Txt_HeadaName.Enabled = True
        Txt_HEADACODE.Enabled = True
    End Sub
    Private Sub Frmmastproduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbActive.DataSource = actinact
        CmbActive.Text = CmbActive.Items(0)
        Cmbheadatype.DataSource = headactype
        Cmbheadatype.Text = Cmbheadatype.Items(0)
    End Sub
    Private Sub FrmHeadAcc_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With TabHeadAccount
            .Location = New Point(5, 5)
            .Size = New Size(Me.Width - 15, Me.Height - Me.GrpBoxBtnCnt.Height - 10)
        End With
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Me.clear()
        Txt_HEADACODE.ReadOnly = True
        GrpBoxHeadAcc.Enabled = True
        controlsvisible(GrpBoxBtnCnt, btncontrols.add)
        Txt_HeadaName.Focus()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.clear()
        controlsvisible(GrpBoxBtnCnt, btncontrols.cancel)
        BtnAdd.Focus()
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
            strsql = "insert into headacc([Heada_Name],[Heada_Code],[heada_Type],[Address1],[Address2],[Phone1],[Phone2],"
            strsql = strsql & vbCrLf & "[EMail],[Join_Date],[Active])"
            strsql = strsql & vbCrLf & " values(@parm1,@parm2,@parm3,@parm4,@parm5,@parm6,@parm7,@parm8,@parm9,@parm10)"
            sqlcmd = New SqlCommand(strsql, dbcon)
            sqlcmd.Parameters.Add(New SqlParameter("@parm1", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm2", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm3", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm4", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm5", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm6", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm7", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm8", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm9", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm10", SqlDbType.VarChar))

            sqlcmd.Parameters(0).Value = Trim(Txt_HeadaName.Text)
            sqlcmd.Parameters(1).Value = Trim(Txt_HEADACODE.Text)
            sqlcmd.Parameters(2).Value = Trim(Cmbheadatype.Text)
            sqlcmd.Parameters(3).Value = Trim(TxtAddress1.Text)
            sqlcmd.Parameters(4).Value = Trim(Txtaddress2.Text)
            sqlcmd.Parameters(5).Value = Trim(TxtPhone1.Text)
            sqlcmd.Parameters(6).Value = Trim(TxtPhone2.Text)
            sqlcmd.Parameters(7).Value = Trim(TxtEmail.Text)
            sqlcmd.Parameters(8).Value = Trim(DTP_dateofjoin.Value)
            sqlcmd.Parameters(9).Value = Trim(CmbActive.Text)

            datareader = Nothing
            datareader = sqlcmd.ExecuteReader()
            MsgBox("Congratulation! " & vbCrLf & "HeadAccount Has Been Syccessfully Created.", vbInformation, Gsmt.dialogcapt)
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
    Private Sub Txt_HeadaName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Txt_HeadaName.Validating
        If Trim(Txt_HeadaName.Text) <> "" Then
            Try
                conopen()

                strsql = "SELECT heada_name FROM headacc where heada_name=@parm"
                datareader = validatenames(strsql, Trim(Txt_HeadaName.Text))
                If datareader.Read Then
                    MsgBox("Sorry! You Entered UserName Already Exists" & vbCrLf & "Please Enter Another", vbInformation, Gsmt.dialogcapt)
                    Txt_HeadaName.Focus()
                Else
                    datareader.Close()
                    strsql = "SELECT count(heada_CODE) as maxheadacc_code FROM headacc"
                    datareader = fn_maxNoGeneration(strsql)
                    If datareader.Read Then
                        Txt_HEADACODE.Text = Val(datareader.Item("maxheadacc_code")) + 1
                    Else
                        Txt_HEADACODE.Text = 1
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conclose()
                datareader.Close()
            End Try
        Else
            MsgBox("Please Enter HeadAccountName", vbInformation, Gsmt.dialogcapt)
            Txt_HeadaName.Focus()
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
            TabHeadAccount.SelectTab(1)
            strsql = ""
            strsql = "select [Heada_Name],[Heada_Code],[heada_Type],[Address1],[Address2],[Phone1]"
            strsql = strsql & vbCrLf & ",[Phone2],[EMail],[Join_Date],[Active],[Updated_Date],[Updated_Time] from HeadAcc"
            strsql = strsql & vbCrLf & "order by [heada_Type],[heada_Code],[heada_Name]"
            dataadapter = fn_tabledataadapter(strsql)

            dataadapter.Fill(sqldataset)
            datareader = sqlcmd.ExecuteReader
            DataGridHeadAccView.DataSource = sqldataset.Tables(0)
        Catch ex As Exception
            disp_msg(ex.ToString)
        Finally
            conclose()
            dataadapter.Dispose()
            datareader.Close()
        End Try
    End Sub

    Private Sub DataGridHeadAccView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridHeadAccView.KeyDown
        If e.KeyCode = Keys.F Then

        ElseIf e.KeyCode = Keys.Escape Then
            Me.clear()
            controlsvisible(GrpBoxBtnCnt, btncontrols.cancel)
            BtnAdd.Focus()
            TabHeadAccount.SelectTab(0)
            BtnClose.Focus()
        ElseIf e.KeyCode = Keys.E Then

            Me.clear()
            GrpBoxHeadAcc.Enabled = True
            controlsvisible(GrpBoxBtnCnt, btncontrols.view)
            BtnDelete.Enabled = False
            With DataGridHeadAccView
                Txt_HeadaName.Text = .CurrentRow.Cells.Item(0).Value.ToString
                Txt_HEADACODE.Text = .CurrentRow.Cells.Item(1).Value.ToString
                Cmbheadatype.Text = .CurrentRow.Cells.Item(2).Value.ToString
                TxtAddress1.Text = .CurrentRow.Cells.Item(3).Value.ToString
                Txtaddress2.Text = .CurrentRow.Cells.Item(4).Value.ToString
                TxtPhone1.Text = .CurrentRow.Cells.Item(5).Value.ToString
                TxtPhone2.Text = .CurrentRow.Cells.Item(6).Value.ToString
                TxtEmail.Text = .CurrentRow.Cells.Item(7).Value.ToString
                DTP_dateofjoin.Value = CDate(.CurrentRow.Cells.Item(8).Value.ToString)
                CmbActive.Text = .CurrentRow.Cells.Item(9).Value.ToString
            End With
            Txt_HeadaName.Enabled = False
            Txt_HEADACODE.Enabled = False
            TabHeadAccount.SelectTab(0)
            Cmbheadatype.Focus()
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
            strsql = "update headacc set [heada_Type]=@parm1,[Address1]=@parm2,[Address2]=@parm3,[Phone1]=@parm4"
            strsql = strsql & vbCrLf & ",[Phone2]=@parm5,[EMail]=@parm6,[Join_Date]=@parm7,[Active]=@parm8,"
            strsql = strsql & vbCrLf & "[Updated_Date]=@parm9,[Updated_Time]=@parm10 where [Heada_Code] =@parm11 "
            sqlcmd = New SqlCommand(strsql, dbcon)
            sqlcmd.Parameters.Add(New SqlParameter("@parm1", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm2", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm3", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm4", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm5", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm6", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm7", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm8", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm9", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm10", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm11", SqlDbType.VarChar))

            sqlcmd.Parameters(0).Value = Trim(Cmbheadatype.Text)
            sqlcmd.Parameters(1).Value = Trim(TxtAddress1.Text)
            sqlcmd.Parameters(2).Value = Trim(Txtaddress2.Text)
            sqlcmd.Parameters(3).Value = Trim(TxtPhone1.Text)
            sqlcmd.Parameters(4).Value = Trim(TxtPhone2.Text)
            sqlcmd.Parameters(5).Value = Trim(TxtEmail.Text)
            sqlcmd.Parameters(6).Value = Trim(DTP_dateofjoin.Value)
            sqlcmd.Parameters(7).Value = Trim(CmbActive.Text)
            sqlcmd.Parameters(8).Value = DateString
            sqlcmd.Parameters(9).Value = TimeString
            sqlcmd.Parameters(10).Value = Trim(Txt_HEADACODE.Text)

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
