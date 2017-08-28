Imports System.Data.SqlClient
Public Class ClsConManager
    Dim con As SqlConnection
    Dim constr As String
    Public Function dbcon() As SqlConnection
        Try
            constr = "data source=" & Gsmt.servername & ";initial catalog=" & Gsmt.dbname & ";user id=" & Gsmt.usname & ";password=" & Gsmt.pword
            con = New SqlConnection(constr)
            dbcon = con
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub conopen()
        Try
            conopen()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub conclose()
        Try
            conclose()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
