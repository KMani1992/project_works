Imports System.Data.SqlClient
Imports System.IO
Module ModGen
    Public Gsmt As New ClsComVar
    Public strsql As String
    Public sqlcmd As SqlCommand
    Public datareader As SqlDataReader
    Public mod_datareader As SqlDataReader
    Public dataadapter As SqlDataAdapter
    Public sqldataset As DataSet
    Public parm As SqlParameter
    Public parm1 As SqlParameter
    Public parm2 As SqlParameter
    Public actinact(2) As String
    Public headactype(2) As String
    Dim constr As String
    Public dbcon As SqlConnection

    Public Sub conopen()
        Try
            constr = "data source=" & Gsmt.servername & ";initial catalog=" & Gsmt.dbname & ";user id=" & Gsmt.usname & ";password=" & Gsmt.pword
            dbcon = New SqlConnection(constr)
            dbcon.Open()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub conclose()
        Try
            dbcon.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Enum btncontrols As Integer
        deflt = 0
        add = 1
        save = 2
        edit = 3
        delete = 4
        view = 5
        cancel = 6
        close = 7
    End Enum
    Public Sub main()
        Try
            Gsmt.dialogcapt = "NetMini"
            Call readCompany()
            conopen()
            If dbcon.State = 1 Then
                MDInetmini.Show()
            Else
                MsgBox("Sorry! Server Connection Cant Established, Please Contact System Admin", vbInformation, Gsmt.dialogcapt)
                End
            End If
            actinact(0) = "Y"
            actinact(1) = "N"
            headactype(0) = "CREDIT"
            headactype(1) = "DEBIT"
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Gsmt.dialogcapt)
        Finally
            conclose()
        End Try
    End Sub
    Public Function readrecordset(ByVal qry As String) As SqlDataReader
        Try
            ' conopen()
            ' strsql = "SELECT OPER_NAME FROM Operator"
            sqlcmd = New SqlCommand(qry, dbcon)

            datareader = Nothing
            datareader = sqlcmd.ExecuteReader
        Catch ex As Exception
            Throw ex
        Finally
            readrecordset = datareader
            ' mod_datareader.Close()
            'conclose()
        End Try

    End Function
    Private Sub readCompany()
        Try
            Dim readr As StreamReader
            Dim pat As String
            Dim data As String
            Dim datatmp As String
            pat = Path.GetDirectoryName(Application.ExecutablePath)
            readr = New StreamReader(pat & "\company.mem")

            Do While (readr.Peek()) > 0
                data = readr.ReadLine
                'If Trim(data) <> vbEmpty Then 
                datatmp = Left(data, InStr(data, ":") - 1)
                Select Case datatmp
                    Case "Company"
                        Gsmt.compname = Mid(data, InStr(data, ":") + 1)
                    Case "Server"
                        Gsmt.servername = Mid(data, InStr(data, ":") + 1)
                    Case "Database"
                        Gsmt.dbname = Mid(data, InStr(data, ":") + 1)
                    Case "Username"
                        Gsmt.usname = Mid(data, InStr(data, ":") + 1)
                    Case "Password"
                        Gsmt.pword = Mid(data, InStr(data, ":") + 1)
                End Select
            Loop

        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Gsmt.dialogcapt)
        End Try
    End Sub
    Public Function Encription(ByVal pass As String) As String
        Dim i As Int32
        Dim encripted As String
        encripted = ""
        Try
            If pass = "" Then
                Encription = ""
                Exit Function
            End If
            pass = StrReverse(pass)
            For i = 1 To Len(pass)
                encripted = encripted & Chr(Asc(Mid(pass, i, 1)) / 3 * 5)
            Next
            If encripted <> "" Then Encription = encripted
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Gsmt.dialogcapt)
        End Try
        Encription = encripted
    End Function

    Public Function Decription(ByVal pass As String) As String
        Dim i As Int32
        Dim decripted As String
        decripted = ""
        Try
            If pass = "" Then
                Decription = ""
                Exit Function
            End If
            For i = 1 To Len(pass)
                decripted = decripted & Chr(Asc(Mid(pass, i, 1)) / 5 * 3)
            Next
            decripted = StrReverse(decripted)
            If decripted <> "" Then Decription = decripted
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Gsmt.dialogcapt)
        End Try
        Decription = decripted
    End Function
    Public Function validatenames(ByVal qry As String, ByVal chkval As String) As SqlDataReader
        Try
            'conopen()
            If qry = "" Or chkval = "" Then
                datareader = Nothing
                validatenames = datareader
                Exit Function
            End If
            sqlcmd = New SqlCommand(qry, dbcon)
            sqlcmd.Parameters.Add(New SqlParameter("@parm", SqlDbType.VarChar))
            sqlcmd.Parameters(0).Value = chkval


            'If mod_datareader.IsClosed = False Then
            '    mod_datareader.Close()
            'End If

            datareader = Nothing
            datareader = sqlcmd.ExecuteReader
        Catch ex As Exception
            Throw ex
        Finally
            validatenames = datareader
            'mod_datareader.Close()
            'conclose()
        End Try

    End Function
    Public Function fn_maxNoGeneration(ByVal qry As String) As SqlDataReader
        Try
            'conopen()
            If qry = "" Then
                datareader = Nothing
                fn_maxNoGeneration = datareader
                Exit Function
            End If
            sqlcmd = New SqlCommand(qry, dbcon)

            'If datareader.IsClosed = False Then
            '    datareader.Close()
            'End If

            datareader = Nothing
            datareader = sqlcmd.ExecuteReader
        Catch ex As Exception
            Throw ex
        Finally
            fn_maxNoGeneration = datareader
            'conclose()
            'datareader.Close()
        End Try
    End Function
    Public Function fn_tabledataadapter(ByVal qry As String) As SqlDataAdapter
        Try
            ' conopen()
            dataadapter = New SqlDataAdapter
            If qry = "" Then
                datareader = Nothing
                fn_tabledataadapter = dataadapter
                Exit Function
            End If

            'If datareader.IsClosed = False Then
            '    datareader.Close()
            'End If

            datareader = Nothing
            sqlcmd = New SqlCommand(qry, dbcon)
            dataadapter = New SqlDataAdapter(sqlcmd)
        Catch ex As Exception
            Throw ex
        Finally
            fn_tabledataadapter = dataadapter
            'conclose()
            'dataadapter.Dispose()
        End Try
    End Function
    Public Sub controlsvisible(ByRef frm As GroupBox, ByVal btncapt As Int32)
        Select Case btncapt
            Case btncontrols.add
                controlsvisiblecon(frm, False, True, False, False, False, True)
            Case btncontrols.save
                controlsvisiblecon(frm, True, False, False, False, True, True)
            Case btncontrols.edit
                controlsvisiblecon(frm, True, False, False, False, True, True)
            Case btncontrols.delete
                controlsvisiblecon(frm, True, False, False, False, True, True)
            Case btncontrols.view
                controlsvisiblecon(frm, False, False, True, True, False, True)
            Case btncontrols.cancel
                controlsvisiblecon(frm, True, False, False, False, True, True)
            Case btncontrols.deflt
                controlsvisiblecon(frm, True, False, False, False, True, True)
        End Select
    End Sub
    Private Sub controlsvisiblecon(ByRef frm As GroupBox, ByVal add As Boolean, ByVal save As Boolean, ByVal edit As Boolean,
                                   ByVal delete As Boolean, ByVal view As Boolean, ByVal cancel As Boolean)
        Dim btncapt As String
        Try
            For Each childcon As Control In frm.Controls
                If TypeOf childcon Is Button Then
                    btncapt = childcon.Name.ToString
                    Select Case btncapt
                        Case "BtnAdd"
                            childcon.Enabled = add
                        Case "BtnSave"
                            childcon.Enabled = save
                        Case "BtnEdit"
                            childcon.Enabled = edit
                        Case "BtnDelete"
                            childcon.Enabled = delete
                        Case "BtnView"
                            childcon.Enabled = view
                        Case "BtnCancel"
                            childcon.Enabled = cancel
                    End Select
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Gsmt.dialogcapt)
        End Try
    End Sub
    Public Sub pro_textbxclear(ByRef chb As GroupBox)

        Try
            For Each childcon As Control In chb.Controls
                If TypeOf childcon Is TextBox Then
                    childcon.Enabled = True
                    childcon.Text = ""
                End If

                ''btncapt = childcon.Name.ToString()
                'Select Case btncapt.ToLower
                '   Case Left(btncapt.ToLower, 3) = "txt"
                '' MsgBox("tts")
                'End Select
            Next
        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, Gsmt.dialogcapt)
        End Try
    End Sub
    Public Sub disp_msg(ByVal msg_string As String)
        If msg_string <> "" Then MsgBox(msg_string, vbInformation, Gsmt.dialogcapt)
    End Sub
End Module


