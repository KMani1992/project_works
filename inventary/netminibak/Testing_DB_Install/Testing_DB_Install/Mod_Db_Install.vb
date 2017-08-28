Imports System.IO
Imports System.Data.SqlClient
Module Mod_Db_Install
    Public G_gst As Cls_Common
    Public con As SqlConnection
    Public re_con As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public strsql As String
    Public constr As String
    Public prsrv_dbnme As String
    Public G_TBL_LST As String() = {"operator", "product", "HeadAcc", "purchese", "sales", "InventTrans"}
    Public Sub main()
        Try
            G_gst = New Cls_Common
            G_gst.Prop_AppCapt = "DBInstall"
            
            Call pr_readCommpany()
            prsrv_dbnme = G_gst.Prop_DBName
            G_gst.Prop_DBName = "master"
            Call pr_conopen()
            G_gst.Prop_DBName = prsrv_dbnme
            FrmDbInstall.ToplStrServer.Text = G_gst.Prop_ServerName
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, G_gst.Prop_AppCapt)
        Finally
            G_gst.Prop_DBName = prsrv_dbnme
        End Try
    End Sub
    Public Sub pr_stat_upd(ByVal value As String)
        FrmDbInstall.ToplStrStatus.Text = value
    End Sub
    Public Sub pr_conopen()
        Try
            constr = ""
            constr = "data source=" & G_gst.Prop_ServerName & ";user id=sa;password=" & G_gst.Prop_ServerPass & ";initial catalog=" & G_gst.Prop_DBName
            con = New SqlConnection(constr)
            con.Open()
            Call pr_stat_upd("Connnection Verify - Ok")
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, G_gst.Prop_AppCapt)
            Call pr_stat_upd("Connnection Verify - Failed")
            ''End
        End Try
    End Sub
    Public Sub pr_re_conopen()
        Try
            constr = ""
            constr = "data source=" & G_gst.Prop_ServerName & ";user id=sa;password=" & G_gst.Prop_ServerPass & ";initial catalog=" & G_gst.Prop_Re_DBName
            re_con = New SqlConnection(constr)
            re_con.Open()
            Call pr_stat_upd("Re Database Connnection Verify - Ok")
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, G_gst.Prop_AppCapt)
            Call pr_stat_upd("Connnection Verify - Failed")
            End
        End Try
    End Sub
    Private Sub pr_readCommpany()
        Dim ln_cnt As Int32
        Dim f_data As String
        Dim fr As New StreamReader(Path.GetDirectoryName(Application.ExecutablePath) & "\Company.Mem")
        Try
            ln_cnt = 0
            While (fr.Peek) > 0
                f_data = fr.ReadLine
                f_data = Mid$(f_data, InStr(f_data, ":") + 1)
                Select Case ln_cnt
                    Case 0
                        G_gst.Prop_CmpCode = f_data
                    Case 1
                        G_gst.Prop_CmpName = f_data
                    Case 2
                        G_gst.Prop_ServerName = f_data
                    Case 3
                        G_gst.Prop_ServerPass = f_data
                    Case 4
                        G_gst.Prop_TransPeriod = f_data
                    Case 5
                        G_gst.Prop_DBPath = IIf(Right(f_data, 1) <> "\", f_data, Left(f_data, Len(f_data) - 1))
                    Case 6
                        G_gst.Prop_DBName = f_data
                    Case Else
                        Exit While
                End Select
                ln_cnt = ln_cnt + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, G_gst.Prop_AppCapt)
        Finally
            fr.Close()
        End Try
    End Sub
    Public Function fn_Encriptin(ByVal value As String) As String
        Dim l_enData As String
        Dim i As Int32
        l_enData = ""
        value = StrReverse(value)
        For i = 1 To Len(value)
            l_enData = l_enData & Chr((Asc(Mid(value, i, 1)) * 5) / 3)
        Next
        fn_Encriptin = l_enData
    End Function
    Public Function fn_Decriptin(ByVal value As String) As String
        Dim l_dcData As String
        Dim i As Int32
        l_dcData = ""
        For i = 1 To Len(value)
            l_dcData = l_dcData & Chr((Asc(Mid(value, i, 1)) * 3) / 5)
        Next
        l_dcData = StrReverse(l_dcData)
        fn_Decriptin = l_dcData
    End Function
End Module

