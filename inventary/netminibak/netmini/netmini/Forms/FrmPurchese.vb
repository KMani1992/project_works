Imports System.Data.SqlClient
Public Class FrmPurchese
    Dim G_sno As Long
    Private Sub FrmPurchese_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        GrpBoxPurchese.Enabled = False
        controlsvisible(GrpBoxBtnCnt, btncontrols.deflt)
        BtnAdd.Focus()
    End Sub
    Private Sub Purchese_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.clear()
            conopen()
            strsql = "SELECT PRO_NAME + '@' + pro_code as pro_name FROM Product order by PRO_NAME"
            datareader = readrecordset(strsql)
            With ColProname
                .Items.Clear()
                Do While datareader.Read
                    .Items.Add(datareader.Item("pro_name"))
                Loop
            End With
            datareader.Close()
            strsql = "SELECT heada_name FROM headacc order by heada_name"
            datareader = readrecordset(strsql)
            With Cmbpartyname
                .Items.Clear()
                Do While datareader.Read
                    .Items.Add(datareader.Item("heada_name"))
                Loop
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Gsmt.dialogcapt)
        Finally
            conclose()
            datareader.Close()
        End Try
    End Sub

    Private Sub Purchese_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With Tabpurchese
            .Location = New Point(5, 5)
            .Size = New Size(Me.Width - 15, Me.Height - Me.GrpBoxBtnCnt.Height - 10)
        End With
    End Sub
    Private Sub clear()
        Dim rowcnt As Long
        Txt_purno.ReadOnly = False
        pro_textbxclear(GrpBoxPurchese)
        Txt_purno.ReadOnly = True
        GrpBoxPurchese.Enabled = False
        rowcnt = DataGridpurchese.Rows.Count
        DataGridpurchese.Rows.Clear()
        Cmbpartyname.Tag = ""
        G_sno = 0
        TxtSPurno.Text = ""
        
        With ColProname
            If .Items.Count > 0 Then
                .Sorted = True
            End If
        End With
        With Cmbpartyname
            If .Items.Count > 0 Then
                .Text = .Items(0)
            End If
        End With
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
        Dim rc As Long
        Dim pro_val As String
        Try
            With DataGridpurchese
                conopen()
                For rc = 0 To .Rows.Count - 2

                    ''for purchase table processing
                    sqlcmd = Nothing
                    strsql = ""
                    strsql = "insert into purchese([Purchese_No],[Pro_code],[heada_code],[Pieces],[Amount],[Purchese_Date])"
                    strsql = strsql & vbCrLf & " values(@parm1,@parm2,@parm3,@parm4,@parm5,@parm6)"
                    sqlcmd = New SqlCommand(strsql, dbcon)
                    sqlcmd.Parameters.Add(New SqlParameter("@parm1", SqlDbType.VarChar))
                    sqlcmd.Parameters.Add(New SqlParameter("@parm2", SqlDbType.VarChar))
                    sqlcmd.Parameters.Add(New SqlParameter("@parm3", SqlDbType.VarChar))
                    sqlcmd.Parameters.Add(New SqlParameter("@parm4", SqlDbType.VarChar))
                    sqlcmd.Parameters.Add(New SqlParameter("@parm5", SqlDbType.VarChar))
                    sqlcmd.Parameters.Add(New SqlParameter("@parm6", SqlDbType.VarChar))


                    pro_val = .Rows(rc).Cells(1).Value.ToString

                    sqlcmd.Parameters(0).Value = Trim(Txt_purno.Text)
                    sqlcmd.Parameters(1).Value = Mid(pro_val, InStr(pro_val, "@") + 1)
                    sqlcmd.Parameters(2).Value = Trim(Cmbpartyname.Tag)
                    sqlcmd.Parameters(3).Value = .Rows(rc).Cells(2).Value.ToString
                    sqlcmd.Parameters(4).Value = .Rows(rc).Cells(3).Value.ToString
                    sqlcmd.Parameters(5).Value = Trim(DTPpurdate.Value)

                    If datareader.IsClosed = False Then
                        datareader.Close()
                    End If
                    datareader = Nothing
                    datareader = sqlcmd.ExecuteReader()


                    '' for InventTrans table insertion
                    sqlcmd = Nothing
                    strsql = ""
                    strsql = "insert into [InventTrans]([Bill_No],[Pro_code],[Pieces],[Amount],[Trantype],[Bill_Date])"
                    strsql = strsql & vbCrLf & " values(@parm1,@parm2,@parm3,@parm4,@parm5,@parm6)"
                    sqlcmd = New SqlCommand(strsql, dbcon)
                    sqlcmd.Parameters.Add(New SqlParameter("@parm1", SqlDbType.VarChar))
                    sqlcmd.Parameters.Add(New SqlParameter("@parm2", SqlDbType.VarChar))
                    sqlcmd.Parameters.Add(New SqlParameter("@parm3", SqlDbType.VarChar))
                    sqlcmd.Parameters.Add(New SqlParameter("@parm4", SqlDbType.VarChar))
                    sqlcmd.Parameters.Add(New SqlParameter("@parm5", SqlDbType.VarChar))
                    sqlcmd.Parameters.Add(New SqlParameter("@parm6", SqlDbType.VarChar))


                    pro_val = .Rows(rc).Cells(1).Value.ToString

                    sqlcmd.Parameters(0).Value = Trim(Txt_purno.Text)
                    sqlcmd.Parameters(1).Value = Mid(pro_val, InStr(pro_val, "@") + 1)
                    sqlcmd.Parameters(2).Value = .Rows(rc).Cells(2).Value.ToString
                    sqlcmd.Parameters(3).Value = .Rows(rc).Cells(3).Value.ToString
                    sqlcmd.Parameters(4).Value = "R"
                    sqlcmd.Parameters(5).Value = Trim(DTPpurdate.Value)

                    If datareader.IsClosed = False Then
                        datareader.Close()
                    End If
                    datareader = Nothing
                    datareader = sqlcmd.ExecuteReader()
                Next rc
                MsgBox("Congratulation! " & vbCrLf & "Information Has Been Syccessfully Saved." & vbCrLf & "Your Purchese No Is : " & Txt_purno.Text, vbInformation, Gsmt.dialogcapt)
                Me.clear()
                controlsvisible(GrpBoxBtnCnt, btncontrols.cancel)
                BtnAdd.Focus()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conclose()
            datareader.Close()
        End Try
    End Sub
    Private Sub Cmbpartyname_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Cmbpartyname.Validating
        If Trim(Cmbpartyname.Text) <> "" Then
            Try
                conopen()
                Cmbpartyname.Tag = ""
                strsql = "SELECT heada_CODE FROM headacc where heada_NAME=@parm"
                datareader = validatenames(strsql, Trim(Cmbpartyname.Text))
                If datareader.Read = False Then
                    MsgBox("Sorry! Please Enter Valid HeadAccountName", vbInformation, Gsmt.dialogcapt)
                    Cmbpartyname.Focus()
                Else
                    Cmbpartyname.Tag = datareader.Item("heada_CODE")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conclose()
                datareader.Close()
            End Try
        Else
            MsgBox("Please Enter HeadAccountName", vbInformation, Gsmt.dialogcapt)
            Cmbpartyname.Focus()
        End If
    End Sub
  
    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Try
            Me.clear()
            Txt_purno.ReadOnly = True
            GrpBoxPurchese.Enabled = True
            controlsvisible(GrpBoxBtnCnt, btncontrols.add)
            DTPpurdate.Focus()

            conopen()
            datareader.Close()
            strsql = "SELECT isnull(max(Purchese_No),0) as maxpurchese_no FROM purchese"
            datareader = fn_maxNoGeneration(strsql)
            If datareader.Read Then
                Txt_purno.Text = Val(datareader.Item("maxpurchese_no")) + 1
            Else
                Txt_purno.Text = 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conclose()
            datareader.Close()
        End Try
    End Sub

    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        Me.clear()
        Tabpurchese.SelectTab(1)
        TxtSPurno.Focus()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TxtSPurno.Text = ""
        ' DataGridPurcheseview.Rows.Clear()
        Me.clear()
        TxtSPurno.Focus()
    End Sub

    Private Sub BtnViewPurchese_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewPurchese.Click

        Try
            conopen()
            dataadapter = New SqlDataAdapter
            sqldataset = New DataSet
           ' Me.clear()
            controlsvisible(GrpBoxBtnCnt, btncontrols.view)
            BtnDelete.Enabled = False

            strsql = "select [Purchese_No],pr.Pro_name as [Product_Name],h.Heada_Name,[Pieces],[Amount],[Purchese_Date] from purchese p "
            strsql = strsql & vbCrLf & " left join HeadAcc h on p.heada_code = h.Heada_Code"
            strsql = strsql & vbCrLf & " left join Product pr on pr.Pro_code =p.Pro_code"
            'strsql = strsql & vbCrLf & " where isnull(p.billstatus,'')<>'C' and "
            'strsql = strsql & vbCrLf & " where CONVERT(DATE,P.Purchese_Date,103) between '" & FormatDateTime(DtpSPurdateFrom.Value, DateFormat.GeneralDate) & "'"
            'strsql = strsql & vbCrLf & " and  '" & FormatDateTime(DtpSPurdateTo.Value, DateFormat.GeneralDate) & "'"
            strsql = ""
            If Val(TxtSPurno.Text.ToString) <> Val("") Then
                strsql = " and ISNULL(p.purchese_no,0)='" & Val(TxtSPurno.Text) & "'"
            End If
            strsql = strsql & " order by p.[Purchese_No],pr.Pro_name,h.Heada_Name "



            datareader = Nothing
            sqlcmd = New SqlCommand("select [Purchese_No],pr.Pro_name as [Product_Name],h.Heada_Name,[Pieces],[Amount],[Purchese_Date] from purchese p " &
                                    " left join HeadAcc h on p.heada_code = h.Heada_Code" &
                                    " left join Product pr on pr.Pro_code =p.Pro_code" &
                                    " where isnull(p.billstatus,'')<>'C' and " &
                                    "CONVERT(DATE,P.Purchese_Date,103) between '" & FormatDateTime(DtpSPurdateFrom.Value, DateFormat.GeneralDate) & "'  and  '" & FormatDateTime(DtpSPurdateTo.Value, DateFormat.GeneralDate) & "'" &
                                    strsql, dbcon)
            dataadapter = New SqlDataAdapter(sqlcmd)

            dataadapter.Fill(sqldataset)
            datareader = sqlcmd.ExecuteReader
            DataGridPurcheseview.DataSource = sqldataset.Tables(0)
            Tabpurchese.SelectTab(1)
        Catch ex As Exception
            disp_msg(ex.ToString)
        Finally
            conclose()
            dataadapter.Dispose()
            datareader.Close()
        End Try
    End Sub

    Private Sub DataGridPurchese_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridpurchese.KeyDown
        Dim pro_val As String
        If e.KeyCode = Keys.Escape Then
            BtnSave.Focus()
        ElseIf e.KeyCode = Keys.Tab Then
            G_sno = 0
            With DataGridpurchese
                For i = 0 To .Rows.Count - 2
                    Try
                        pro_val = .Rows(i).Cells(1).Value.ToString
                        conopen()
                        If pro_val <> "" Then
                            strsql = "SELECT [SellingRate] FROM product where [Pro_code]=@parm"
                            datareader = validatenames(strsql, Mid(Trim(pro_val), InStr(pro_val, "@") + 1))
                            If datareader.Read = False Then
                                MsgBox("Sorry! Please Enter Valid Product", vbInformation, Gsmt.dialogcapt)
                            Else
                                .Rows(i).Cells(1).Tag = datareader.Item("SellingRate")
                                .Rows(i).Cells(3).Value = .Rows(i).Cells(2).Value * .Rows(i).Cells(1).Tag
                                G_sno = G_sno + 1
                                .Rows(i).Cells(0).Value = G_sno
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        conclose()
                        datareader.Close()
                    End Try
                Next i
            End With
        End If
    End Sub
    Private Sub DataGridPurcheseview_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridPurcheseview.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.clear()
            controlsvisible(GrpBoxBtnCnt, btncontrols.cancel)
            BtnAdd.Focus()
            Tabpurchese.SelectTab(0)
            BtnClose.Focus()
        ElseIf e.KeyCode = Keys.C Then
            Try
                conopen()
                Me.clear()
                controlsvisible(GrpBoxBtnCnt, btncontrols.view)
                BtnDelete.Enabled = False
                Tabpurchese.SelectTab(1)

                If MsgBox("Are You Sure Want To Cancel The Bill?", vbQuestion + vbYesNo, Gsmt.dialogcapt) = vbYes Then
                    strsql = ""
                    strsql = "update purchese set billstatus='C' where [Purchese_No]='" & DataGridPurcheseview.CurrentRow.Cells.Item(0).Value.ToString & "'"
                    sqlcmd = New SqlCommand(strsql, dbcon)
                    sqlcmd.ExecuteNonQuery()
                    BtnViewPurchese_Click("", System.EventArgs.Empty)
                End If
            Catch ex As Exception
                disp_msg(ex.ToString)
            Finally
                sqlcmd.Dispose()
                conclose()
            End Try
        End If
    End Sub

    Private Sub DtpSPurdateTo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DtpSPurdateTo.Validating
        If DtpSPurdateTo.Value.Date < DtpSPurdateFrom.Value.Date Then
            disp_msg("Please Enter Valid From To Date")
            DtpSPurdateTo.Focus()
        End If
    End Sub
End Class