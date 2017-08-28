Imports System.Data.SqlClient
Public Class Frmproduct
    Dim ds As DataSet

    Private Sub Frmproduct_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.clear()
        controlsvisible(GrpBoxBtnCnt, btncontrols.deflt)
        BtnAdd.Focus()
    End Sub
    Private Sub clear()
        pro_textbxclear(GrpBoxproCreate)
        GrpBoxproCreate.Enabled = False
        Txt_ProductName.Enabled = True
        Txtprocode.Enabled = True
        TxtDisplayOrder.Enabled = True
    End Sub
    Private Sub Frmmastproduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbActive.DataSource = actinact
        CmbActive.Text = CmbActive.Items(0)
    End Sub

    Private Sub Frmmastproduct_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        With Tabpromaster
            .Location = New Point(5, 5)
            .Size = New Size(Me.Width - 15, Me.Height - Me.GrpBoxBtnCnt.Height - 10)
        End With
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        Me.clear()
        Txtprocode.ReadOnly = True
        GrpBoxproCreate.Enabled = True
        controlsvisible(GrpBoxBtnCnt, btncontrols.add)
        Txt_ProductName.Focus()
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
            strsql = "insert into product([Pro_name],[Pro_code],[ShortName],[DtOfCreation],[PurcheseRate],[SellingRate],[DisplayOrder],[Active])"
            strsql = strsql & vbCrLf & " values(@parm1,@parm2,@parm3,@parm4,@parm5,@parm6,@parm7,@parm8)"
            sqlcmd = New SqlCommand(strsql, dbcon)
            sqlcmd.Parameters.Add(New SqlParameter("@parm1", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm2", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm3", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm4", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm5", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm6", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm7", SqlDbType.Int))
            sqlcmd.Parameters.Add(New SqlParameter("@parm8", SqlDbType.VarChar))

            sqlcmd.Parameters(0).Value = Trim(Txt_ProductName.Text)
            sqlcmd.Parameters(1).Value = Trim(Trim(Txtprocode.Text))
            sqlcmd.Parameters(2).Value = Trim(Txt_ShortName.Text)
            sqlcmd.Parameters(3).Value = Trim(DTP_dateofCreation.Value)
            sqlcmd.Parameters(4).Value = Val(Trim(TxtPurcheseRate.Text))
            sqlcmd.Parameters(5).Value = Val(Trim(TxtSellingRate.Text))
            sqlcmd.Parameters(6).Value = Val(Trim(TxtDisplayOrder.Text))
            sqlcmd.Parameters(7).Value = Trim(CmbActive.Text)

            'If datareader.IsClosed = False Then
            '    datareader.Close()
            'End If
            datareader = Nothing
            datareader = sqlcmd.ExecuteReader()
            MsgBox("Congratulation! " & vbCrLf & "Product Has Been Syccessfully Created.", vbInformation, Gsmt.dialogcapt)
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
    Private Sub Txt_ProductName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Txt_ProductName.Validating
        If Trim(Txt_ProductName.Text) <> "" Then
            Try
                conopen()

                strsql = "SELECT PRO_CODE FROM Product where PRO_NAME=@parm"
                datareader = validatenames(strsql, Trim(Txt_ProductName.Text))
                If datareader.Read Then
                    MsgBox("Sorry! You Entered ProductName Already Exists" & vbCrLf & "Please Enter Another", vbInformation, Gsmt.dialogcapt)
                    Txt_ProductName.Focus()
                Else
                    datareader.Close()
                    strsql = "SELECT count(pro_code) as cntpro_code,MAX(displayorder) as maxdisp_order FROM product"
                    datareader = fn_maxNoGeneration(strsql)
                    If datareader.Read Then
                        If Len(Trim(Txt_ProductName.Text)) > 2 Then Txtprocode.Text = Mid(Trim(Txt_ProductName.Text), 1, 3).ToUpper & Val(datareader.Item("cntpro_code")) + 1
                        TxtDisplayOrder.Text = Val(datareader.Item("maxdisp_order")) + 1
                    Else
                        If Len(Trim(Txt_ProductName.Text)) > 2 Then Txtprocode.Text = Mid(Trim(Txt_ProductName.Text), 1, 3).ToUpper & 1
                        TxtDisplayOrder.Text = 1
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conclose()
                datareader.Close()
            End Try
        Else
            MsgBox("Please Enter ProductName", vbInformation, Gsmt.dialogcapt)
            Txt_ProductName.Focus()
        End If
    End Sub

  

    Private Sub TxtDisplayOrder_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtDisplayOrder.Validating
        If Trim(TxtDisplayOrder.Text) <> "" Then
            Try
                conopen()
                strsql = "SELECT displayorder FROM product where displayorder=@parm"
                datareader = validatenames(strsql, Trim(TxtDisplayOrder.Text))
                If datareader.Read Then
                    MsgBox("Sorry! You Entered DisplayOrder Already Exists" & vbCrLf & "Please Enter Another", vbInformation, Gsmt.dialogcapt)
                    TxtDisplayOrder.Focus()
                Else
                    datareader.Close()
                    strsql = "SELECT max(displayorder) as maxoper_code FROM product"
                    datareader = fn_maxNoGeneration(strsql)
                    If datareader.Read Then
                        TxtDisplayOrder.Text = Val(datareader.Item("maxoper_code")) + 1
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conclose()
                datareader.Close()
            End Try
        Else
            MsgBox("Please Enter DisplayOrder", vbInformation, Gsmt.dialogcapt)
            TxtDisplayOrder.Focus()
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
            Tabpromaster.SelectTab(1)
            strsql = ""
            strsql = "select [Pro_name],[Pro_code],[ShortName],[DtOfCreation],"
            strsql = strsql & vbCrLf & "[PurcheseRate],[SellingRate],[DisplayOrder],[Active] from product order  by displayorder,pro_name"
            dataadapter = fn_tabledataadapter(strsql)
            dataadapter.Fill(sqldataset)
            datareader = sqlcmd.ExecuteReader
            DataGridProView.DataSource = sqldataset.Tables(0)
        Catch ex As Exception
            disp_msg(ex.ToString)
        Finally
            conclose()
            dataadapter.Dispose()
            datareader.Close()
        End Try
    End Sub

    Private Sub DataGridProView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridProView.KeyDown
        If e.KeyCode = Keys.F Then

        ElseIf e.KeyCode = Keys.Escape Then
            Me.clear()
            controlsvisible(GrpBoxBtnCnt, btncontrols.cancel)
            BtnAdd.Focus()
            Tabpromaster.SelectTab(0)
            BtnClose.Focus()
        ElseIf e.KeyCode = Keys.E Then
            Me.clear()
            GrpBoxproCreate.Enabled = True
            controlsvisible(GrpBoxBtnCnt, btncontrols.view)
            BtnDelete.Enabled = False
            With DataGridProView
                Txt_ProductName.Text = .CurrentRow.Cells.Item(0).Value.ToString
                Txtprocode.Text = .CurrentRow.Cells.Item(1).Value.ToString
                Txt_ShortName.Text = .CurrentRow.Cells.Item(2).Value.ToString
                DTP_dateofCreation.Value = CDate(.CurrentRow.Cells.Item(3).Value.ToString)
                TxtPurcheseRate.Text = .CurrentRow.Cells.Item(4).Value.ToString
                TxtSellingRate.Text = .CurrentRow.Cells.Item(5).Value.ToString
                TxtDisplayOrder.Text = .CurrentRow.Cells.Item(6).Value.ToString
                CmbActive.Text = .CurrentRow.Cells.Item(7).Value.ToString
            End With
            Txt_ProductName.Enabled = False
            Txtprocode.Enabled = False
            TxtDisplayOrder.Enabled = False
            Tabpromaster.SelectTab(0)
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
            strsql = "update product set ShortName=@parm1,DtOfCreation=@parm2,purcheserate=@parm3,sellingrate=@parm4,Active=@parm5,displayorder=@parm6 where pro_Code =@parm7 "
            sqlcmd = New SqlCommand(strsql, dbcon)
            sqlcmd.Parameters.Add(New SqlParameter("@parm1", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm2", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm3", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm4", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm5", SqlDbType.VarChar))
            sqlcmd.Parameters.Add(New SqlParameter("@parm6", SqlDbType.Int))
            sqlcmd.Parameters.Add(New SqlParameter("@parm7", SqlDbType.VarChar))

            sqlcmd.Parameters(0).Value = Trim(Txt_ShortName.Text)
            sqlcmd.Parameters(1).Value = Trim(DTP_dateofCreation.Value)
            sqlcmd.Parameters(2).Value = Val(Trim(TxtPurcheseRate.Text))
            sqlcmd.Parameters(3).Value = Val(Trim(TxtSellingRate.Text))
            sqlcmd.Parameters(4).Value = Trim(CmbActive.Text)
            sqlcmd.Parameters(5).Value = Val(Trim(TxtDisplayOrder.Text))
            sqlcmd.Parameters(6).Value = Trim(Txtprocode.Text)

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

    Private Sub TxtSellingRate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtSellingRate.Validating
        If Val(TxtPurcheseRate.Text) > (TxtSellingRate.Text) Then
            MsgBox("Purchese Rate Is Greater Than Selling Rate,Please Verify", vbExclamation, Gsmt.dialogcapt)
        End If
    End Sub
End Class
