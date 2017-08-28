Imports System.Data.SqlClient
Public Class FrmSales
    Dim G_sno As Long
    Private Sub FrmSales_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        GrpBoxSales.Enabled = False
        controlsvisible(GrpBoxBtnCnt, btncontrols.deflt)
        BtnAdd.Focus()
    End Sub
    Private Sub clear()
        Dim rowcnt As Long
        Txt_salno.ReadOnly = False
        pro_textbxclear(GrpBoxSales)
        Txt_salno.ReadOnly = True
        GrpBoxSales.Enabled = False
        rowcnt = DataGridSales.Rows.Count
        DataGridSales.Rows.Clear()
        Cmbpartyname.Tag = ""
        G_sno = 0
        TxtSSalNo.Text = ""

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

    Private Sub FrmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub FrmSales_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With Tabsales
            .Location = New Point(5, 5)
            .Size = New Size(Me.Width - 15, Me.Height - Me.GrpBoxBtnCnt.Height - 10)
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
            With DataGridSales
                conopen()
                For rc = 0 To .Rows.Count - 2

                    ''for sales table insert
                    sqlcmd = Nothing
                    strsql = ""
                    strsql = "insert into sales([Bill_No],[Pro_code],[heada_code],[Pieces],[Amount],[Bill_Date])"
                    strsql = strsql & vbCrLf & " values(@parm1,@parm2,@parm3,@parm4,@parm5,@parm6)"
                    sqlcmd = New SqlCommand(strsql, dbcon)
                    sqlcmd.Parameters.Add(New SqlParameter("@parm1", SqlDbType.VarChar))
                    sqlcmd.Parameters.Add(New SqlParameter("@parm2", SqlDbType.VarChar))
                    sqlcmd.Parameters.Add(New SqlParameter("@parm3", SqlDbType.VarChar))
                    sqlcmd.Parameters.Add(New SqlParameter("@parm4", SqlDbType.VarChar))
                    sqlcmd.Parameters.Add(New SqlParameter("@parm5", SqlDbType.VarChar))
                    sqlcmd.Parameters.Add(New SqlParameter("@parm6", SqlDbType.VarChar))


                    pro_val = .Rows(rc).Cells(1).Value.ToString

                    sqlcmd.Parameters(0).Value = Trim(Txt_salno.Text)
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

                    sqlcmd.Parameters(0).Value = Trim(Txt_salno.Text)
                    sqlcmd.Parameters(1).Value = Mid(pro_val, InStr(pro_val, "@") + 1)
                    sqlcmd.Parameters(2).Value = .Rows(rc).Cells(2).Value.ToString
                    sqlcmd.Parameters(3).Value = .Rows(rc).Cells(3).Value.ToString
                    sqlcmd.Parameters(4).Value = "I"
                    sqlcmd.Parameters(5).Value = Trim(DTPpurdate.Value)

                    If datareader.IsClosed = False Then
                        datareader.Close()
                    End If
                    datareader = Nothing
                    datareader = sqlcmd.ExecuteReader()
                Next rc
                MsgBox("Congratulation! " & vbCrLf & "Information Has Been Syccessfully Saved." & vbCrLf & "Your Sale BillNo Is : " & Txt_salno.Text, vbInformation, Gsmt.dialogcapt)
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
            Txt_salno.ReadOnly = True
            GrpBoxSales.Enabled = True
            controlsvisible(GrpBoxBtnCnt, btncontrols.add)
            DTPpurdate.Focus()

            conopen()
            datareader.Close()
            strsql = "SELECT isnull(max([Bill_No]),0) as maxsale_no FROM sales"
            datareader = fn_maxNoGeneration(strsql)
            If datareader.Read Then
                Txt_salno.Text = Val(datareader.Item("maxsale_no")) + 1
            Else
                Txt_salno.Text = 1
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
        Tabsales.SelectTab(1)
        TxtSSalNo.Focus()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        TxtSSalNo.Text = ""
        ' DataGridPurcheseview.Rows.Clear()
        Me.clear()
        TxtSSalNo.Focus()
    End Sub

    Private Sub BtnViewPurchese_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewPurchese.Click

        Try
            conopen()
            dataadapter = New SqlDataAdapter
            sqldataset = New DataSet
            ' Me.clear()
            controlsvisible(GrpBoxBtnCnt, btncontrols.view)
            BtnDelete.Enabled = False

            strsql = "select [Bill_No],pr.Pro_name as [Product_Name],h.Heada_Name ,[Pieces],[Amount],[Bill_Date] from sales s "
            strsql = strsql & vbCrLf & " left join HeadAcc h on s.heada_code = h.Heada_Code"
            strsql = strsql & vbCrLf & " left join Product pr on pr.Pro_code =s.Pro_code"
            'strsql = strsql & vbCrLf & " where isnull(p.billstatus,'')<>'C' and "
            'strsql = strsql & vbCrLf & " where CONVERT(DATE,P.Purchese_Date,103) between '" & FormatDateTime(DtpSPurdateFrom.Value, DateFormat.GeneralDate) & "'"
            'strsql = strsql & vbCrLf & " and  '" & FormatDateTime(DtpSPurdateTo.Value, DateFormat.GeneralDate) & "'"
            strsql = ""
            If Val(TxtSSalNo.Text.ToString) <> Val("") Then
                strsql = " and ISNULL(s.Bill_No,0)='" & Val(TxtSSalNo.Text) & "'"
            End If
            strsql = strsql & " order by s.[Bill_No],pr.Pro_name,h.Heada_Name "



            datareader = Nothing
            sqlcmd = New SqlCommand("select [Bill_No],pr.Pro_name as [Product_Name],h.Heada_Name ,[Pieces],[Amount],[Bill_Date] from sales s " &
                                    " left join HeadAcc h on s.heada_code = h.Heada_Code" &
                                    " left join Product pr on pr.Pro_code =s.Pro_code" &
                                    " where isnull(s.billstatus,'')<>'C' and " &
                                    "CONVERT(DATE,s.bill_Date,103) between '" & FormatDateTime(DTPFromDate.Value, DateFormat.GeneralDate) & "'  and  '" & FormatDateTime(DTPToDate.Value, DateFormat.GeneralDate) & "'" &
                                    strsql, dbcon)
            dataadapter = New SqlDataAdapter(sqlcmd)

            dataadapter.Fill(sqldataset)
            datareader = sqlcmd.ExecuteReader
            DataGridSalesview.DataSource = sqldataset.Tables(0)
            Tabsales.SelectTab(1)
        Catch ex As Exception
            disp_msg(ex.ToString)
        Finally
            conclose()
            dataadapter.Dispose()
            datareader.Close()
        End Try
    End Sub

    Private Sub DataGridSales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridSales.KeyDown
        Dim pro_val As String
        Dim cur_pic, rec_pic, iss_pic As Int32
        If e.KeyCode = Keys.Escape Then
            BtnSave.Focus()
        ElseIf e.KeyCode = Keys.Tab Then
            G_sno = 0
            
            With DataGridSales
                For i = 0 To .Rows.Count - 2
                    Try
                        pro_val = .Rows(i).Cells(1).Value.ToString
                        conopen()
                        If pro_val <> "" Then
                            cur_pic = 0
                            iss_pic = 0
                            rec_pic = 0

                            If datareader.IsClosed = False Then
                                datareader.Close()
                            End If

                            strsql = "SELECT isnull(sum(pieces),0) as rec_pic FROM [InventTrans] where isnull(billstatus,'')<>'C' and isnull(trantype,'')='R' and [Pro_code]=@parm"
                            datareader = validatenames(strsql, Mid(Trim(pro_val), InStr(pro_val, "@") + 1))
                            If datareader.Read = True Then
                                rec_pic = datareader.Item("rec_pic")
                            End If

                            If datareader.IsClosed = False Then
                                datareader.Close()
                            End If

                            strsql = "SELECT isnull(sum(pieces),0) as iss_pic FROM [InventTrans] where isnull(billstatus,'')<>'C' and isnull(trantype,'')='I' and [Pro_code]=@parm"
                            datareader = validatenames(strsql, Mid(Trim(pro_val), InStr(pro_val, "@") + 1))

                            If datareader.Read = True Then
                                iss_pic = datareader.Item("iss_pic")
                            End If

                            If datareader.IsClosed = False Then
                                datareader.Close()
                            End If

                            cur_pic = .Rows(i).Cells(2).Value
                            If rec_pic >= iss_pic + cur_pic Then
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
                            Else
                                MsgBox("Sorry! Stock Exced Available Stock Please Enter Valid Piece", vbInformation, Gsmt.dialogcapt)
                                .Rows(i).Cells(1).Tag = 0
                                .Rows(i).Cells(3).Value = 0
                                .Rows(i).Cells(2).Value = 0
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
    Private Sub DataGridPurcheseview_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridSalesview.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.clear()
            controlsvisible(GrpBoxBtnCnt, btncontrols.cancel)
            BtnAdd.Focus()
            Tabsales.SelectTab(0)
            BtnClose.Focus()
        ElseIf e.KeyCode = Keys.C Then
            Try
                conopen()
                Me.clear()
                controlsvisible(GrpBoxBtnCnt, btncontrols.view)
                BtnDelete.Enabled = False
                Tabsales.SelectTab(1)

                If MsgBox("Are You Sure Want To Cancel The Bill?", vbQuestion + vbYesNo, Gsmt.dialogcapt) = vbYes Then
                    strsql = ""
                    strsql = "update sales set billstatus='C' where [bill_No]='" & DataGridSalesview.CurrentRow.Cells.Item(0).Value.ToString & "'"
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

    Private Sub DtpSPurdateTo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DTPToDate.Validating
        If DTPToDate.Value.Date < DTPFromDate.Value.Date Then
            disp_msg("Please Enter Valid From To Date")
            DTPToDate.Focus()
        End If
    End Sub
End Class
