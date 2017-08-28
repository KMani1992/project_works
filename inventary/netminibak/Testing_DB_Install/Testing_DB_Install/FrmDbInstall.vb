Imports System.Data.SqlClient
Public Class FrmDbInstall
    Dim dr As SqlDataReader
    Private Sub FrmDbInstall_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''calling compaymem reading and initiate server connection
        Call main()
        '' display installation details
        Call pr_Display()
    End Sub
    Private Sub pr_clear()
        ''for clearing all fields
        LblCmpCode.Text = ""
        LblCmpName.Text = ""
        LblSrvName.Text = ""
        LblFinYear.Text = ""
        With PrgDbInstall
            .Minimum = 0
            .Maximum = 100
            .Value = 0
            .Visible = False
        End With
    End Sub
    Private Sub pr_Display()
        Call pr_clear()
        LblCmpCode.Text = G_gst.Prop_CmpCode
        LblCmpName.Text = G_gst.Prop_CmpName
        LblSrvName.Text = G_gst.Prop_ServerName
        LblFinYear.Text = G_gst.Prop_TransPeriod
        'G_gst.Prop_DBName = Trim(G_gst.Prop_CmpCode & "A" & Mid(G_gst.Prop_TransPeriod, InStr(G_gst.Prop_TransPeriod, ",") + 3, 2) & Mid(G_gst.Prop_TransPeriod, InStrRev(G_gst.Prop_TransPeriod, ",") + 3, 2))
        G_gst.Prop_DBName = G_gst.Prop_DBName
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        End
    End Sub

    Private Sub BtnDbInstall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDbInstall.Click
        Try
            If Me.fn_dbcheck(G_gst.Prop_DBName) = False Then
                Call pr_dbcreate(G_gst.Prop_DBName, con)
                Call pr_conopen()
                Call pr_TblExecute(con)
                Call ins_defltrws()
                Call pr_stat_upd("DBInstallation Over - Success")
                MsgBox("Congratulation! Database Installation " & vbCr & "Has-Been Completed Successfully.", vbInformation, G_gst.Prop_AppCapt)
            Else
                If MsgBox("DBName [ " & G_gst.Prop_DBName & " ] Already Exists Do You Want To reinstall?", vbQuestion + vbYesNo, G_gst.Prop_AppCapt) = vbYes Then
                    G_gst.Prop_Re_DBName = "re" & G_gst.Prop_DBName
                    Call pr_dbcreate(G_gst.Prop_Re_DBName, con, True)
                    con.Close()
                    Call pr_conopen()
                    Call pr_re_conopen()
                    Call pr_reinstall()
                    Call ins_defltrws()
                    Call pr_stat_upd("DBInstallation Over - Success")
                    MsgBox("Congratulation! Database Installation " & vbCr & "Has-Been Completed Successfully.", vbInformation, G_gst.Prop_AppCapt)
                    re_con.Dispose()
                    re_con.Close()
                End If
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, G_gst.Prop_AppCapt)
        Finally
            cmd.Dispose()
            BtnExit.Focus()
        End Try
    End Sub
    Private Sub ins_defltrws()
        Try
            If dr.IsClosed = False Then
                dr.Close()
            End If
            cmd = New SqlCommand("if not exists (select * from operator where oper_name ='supervisor') insert into operator(oper_name,oper_code,short_name,password,confirm_password,dateofcreation,active) values('Supervisor',1,'Super','²¶²','²¶²','2014/09/09','Y')", con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
        End Try
    End Sub
    Private Sub pr_Tblcompare()
        ''procedure for altering column
        Dim adflag, altrflg As Boolean
        Dim dbtyp As String
        Dim dt As New DataTable


        Try
            adflag = False
            altrflg = False
            dbtyp = ""
            For Each Tblnm As String In G_TBL_LST
                If fn_Tblcheck(Tblnm, con) = True Then

                    If dr.IsClosed = False Then
                        dr.Close()
                    End If

                    da = New SqlDataAdapter("sp_columns " & Tblnm, re_con)
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        ''redb column looping
                        For i = 0 To dt.Rows.Count - 1
                            adflag = True
                            altrflg = False
                            ''column with dbtype generation
                            dbtyp = dt.Rows(i).Item("column_name") & " " & dt.Rows(i).Item("type_name")
                            If dt.Rows(i).Item("type_name").ToString.ToUpper = UCase("numeric") Then
                                dbtyp = dbtyp & "(" & dt.Rows(i).Item("precision") & IIf(dt.Rows(i).Item("scale") <> 0, "," & dt.Rows(i).Item("scale"), "") & ")"
                            ElseIf Trim(dt.Rows(i).Item("type_name").ToString.ToUpper) = UCase("char") Or Trim(dt.Rows(i).Item("type_name").ToString.ToUpper) = UCase("varchar") Or Trim(dt.Rows(i).Item("type_name").ToString.ToUpper) = UCase("nvarchar") Then
                                dbtyp = dbtyp & "(" & dt.Rows(i).Item("precision") & ")"
                            End If

                            If dr.IsClosed = False Then
                                dr.Close()
                            End If


                            ''for existing column check
                            cmd = New SqlCommand("sp_columns " & Tblnm & ",null,null,'" & dt.Rows(i).Item("column_name") & "'", con)
                            dr = cmd.ExecuteReader
                            If dr.Read Then
                                adflag = False
                                If dr.Item("type_name").ToString <> dt.Rows(i).Item("type_name").ToString Or dr.Item("precision").ToString <> dt.Rows(i).Item("precision").ToString Or dr.Item("scale").ToString <> dt.Rows(i).Item("scale").ToString Then
                                    altrflg = True
                                End If
                            End If

                            If dr.IsClosed = False Then
                                dr.Close()
                            End If

                            If adflag Then
                                ''for adding new column
                                cmd = New SqlCommand("alter table " & Tblnm & " add " & dbtyp & IIf(dt.Rows(i).Item("column_def").ToString <> "", " default " & dt.Rows(i).Item("column_def"), ""), con)
                                cmd.ExecuteScalar()
                            ElseIf altrflg Then
                                ''for altering existing column
                                cmd = New SqlCommand("alter table " & Tblnm & " alter column " & dbtyp, con)
                                cmd.ExecuteScalar()
                            End If
                        Next

                    End If
                Else
                    Call pr_TblCreate(Tblnm, con)
                End If
                da.Dispose()
                dt.Clear()
                cmd.Dispose()
            Next
        Catch ex As Exception
            Throw ex
        Finally
            da.Dispose()
            dt.Clear()
            cmd.Dispose()
        End Try

    End Sub
    Private Sub pr_reinstall()
        Try
            Call pr_TblExecute(re_con)
            Call pr_Tblcompare()
        Catch ex As Exception
            ' MsgBox(ex.Message, vbExclamation, G_gst.Prop_AppCapt)
            'End
            Throw ex
        End Try
    End Sub

    Private Sub pr_TblExecute(ByVal con As SqlConnection)
        Try
            For Each Tblnm As String In G_TBL_LST
                Call pr_stat_upd("Processing - " & Tblnm)
                Call pr_TblCreate(Tblnm, con)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub pr_dbcreate(ByVal dbname As String, ByVal con As SqlConnection, Optional ByVal dropdb As Boolean = False)
        Try

            If dr.IsClosed = False Then
                dr.Close()
            End If


            If dropdb Then
                If fn_dbcheck(dbname) = True Then
                    cmd = New SqlCommand("select spid from master.dbo.sysprocesses where dbid in(select dbid from master.dbo.sysdatabases where name='" & dbname & "')", con)
                    If dr.IsClosed = False Then
                        dr.Close()
                    End If
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                       
                        cmd = New SqlCommand("exec kill " & dr.Item("spid"), con)

                        If dr.IsClosed = False Then
                            dr.Close()
                        End If
                        cmd.ExecuteScalar()
                    End If

                    If dr.IsClosed = False Then
                        dr.Close()
                    End If

                    cmd = New SqlCommand("drop database " & dbname, con)
                    cmd.ExecuteScalar()
                End If
            End If

            If dr.IsClosed = False Then
                dr.Close()
            End If



            cmd = New SqlCommand("create database " & UCase(dbname) & _
                                 " on (name ='" & dbname & "',filename='" & G_gst.Prop_DBPath & "\" & dbname & ".mdf')" & _
                                 " log on (name ='" & dbname & "_log',filename='" & G_gst.Prop_DBPath & "\" & dbname & "_log.ldf')", con)
            cmd.ExecuteScalar()
            Call pr_stat_upd("Database Created Successfully")
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
        End Try
    End Sub
    Private Sub pr_TblCreate(ByVal Tblname As String, ByVal con As SqlConnection)
        Try
            Dim Tblqry As String
            Tblqry = ""
            Tblqry = "create table " & Tblname
            Select Case UCase(Tblname)
                Case UCase("HeadAcc")
                    Tblqry = Tblqry & "( " & _
                        "[Heada_Name] varchar(40)," & _
                        "[Heada_Code] varchar(10)," & _
                        "[heada_Type] varchar(20)," & _
                        "[Address1] varchar(40)," & _
                        "[Address2]  varchar(40)," & _
                        "[Phone1] varchar(13)," & _
                        "[Phone2]  varchar(13)," & _
                        "[EMail] varchar(30)," & _
                        "[Join_Date] datetime, " & _
                        "[Active] varchar(1)," & _
                        "[Updated_Date] varchar(15) default convert(varchar,getdate(),103)," & _
                        "[Updated_Time] varchar(15) default convert(varchar,getdate(),108))"
                Case UCase("purchese")
                    Tblqry = Tblqry & "(" & _
                        "[Purchese_No] varchar(10),[Pro_code] varchar(10), " & _
                        "[heada_code] varchar(10)," & _
                        "[Pieces] int,[Amount] numeric(10,2)," & _
                        "[Purchese_Date] datetime," & _
                        "[BillStatus] varchar(1)," & _
                        "[Updated_Date] varchar(15) default convert(varchar,getdate(),103)," & _
                        "[Updated_Time] varchar(15) default convert(varchar,getdate(),108))"
                Case UCase("sales")
                    Tblqry = Tblqry & "(" & _
                        "[Bill_No] varchar(10),[Bill_Date] datetime," & _
                        "[heada_code] varchar(10)," & _
                        "[Pro_code] varchar(10)," & _
                        "[Pieces] int,[Amount] numeric(10,2)," & _
                        "[BillStatus] varchar(1)," & _
                        "[Updated_Date] varchar(15) default convert(varchar,getdate(),103)," & _
                        "[Updated_Time] varchar(15) default convert(varchar,getdate(),108))"
                Case UCase("operator")
                    Tblqry = Tblqry & "(" & _
                        "[Oper_Name] varchar(50)," & _
                        "[Oper_Code] int unique," & _
                        "[Short_Name] varchar(20)," & _
                        "[Password] varchar(20)," & _
                        "[Confirm_Password] varchar(20)," & _
                        "[DateOfCreation] datetime," & _
                        "[Active] varchar(1) default 'Y')"
                Case UCase("product")
                    Tblqry = Tblqry & "(" & _
                        "[Pro_name] varchar(40),[Pro_code] varchar(10)," & _
                        "[ShortName] varchar(30),[DtOfCreation]  datetime default convert(varchar,getdate(),103)," & _
                        "[PurcheseRate] numeric(10,2),[SellingRate] numeric(10,2)," & _
                        "[DisplayOrder] int, [Active] varchar(1))"
                Case UCase("InventTrans")
                    Tblqry = Tblqry & "(" & _
                        "[Bill_No] varchar(10),[Bill_Date] datetime," & _
                        "[Pro_code] varchar(10)," & _
                        "[Pieces] int,[Amount] numeric(10,2)," & _
                        "[Trantype] varchar(1)," & _
                        "[BillStatus] varchar(1)," & _
                        "[Updated_Date] varchar(15) default convert(varchar,getdate(),103)," & _
                        "[Updated_Time] varchar(15) default convert(varchar,getdate(),108))"
                Case Else
                    Tblqry = ""
            End Select
            If Tblqry <> "" Then
                If dr.IsClosed = False Then
                    dr.Close()
                End If
                cmd = New SqlCommand(Tblqry, con)
                cmd.ExecuteScalar()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function fn_dbcheck(ByVal dbname As String) As Boolean
        Dim dbchk As Boolean
        dbchk = False
        Try
            cmd = New SqlCommand("select * from master.dbo.sysdatabases where name ='" & dbname & "'", con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                dbchk = True
            Else
                dbchk = False
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, vbExclamation, G_gst.Prop_AppCapt)
            Throw ex
        Finally
            cmd.Dispose()
            fn_dbcheck = dbchk
        End Try
    End Function
    Private Function fn_Tblcheck(ByVal Tblname As String, ByVal con As SqlConnection) As Boolean
        Dim Tblchk As Boolean
        Tblchk = False
        Try
            If dr.IsClosed = False Then
                dr.Close()
            End If
            dr = Nothing

            cmd = New SqlCommand("select * from sysobjects where xtype='u' and name ='" & Tblname & "'", con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                Tblchk = True
            Else
                Tblchk = False
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, vbExclamation, G_gst.Prop_AppCapt)
            Throw ex
        Finally
            cmd.Dispose()
            fn_Tblcheck = Tblchk
        End Try
    End Function
End Class
