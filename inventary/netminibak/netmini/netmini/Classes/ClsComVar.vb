Public Class ClsComVar
    Private company As String
    Private Server As String
    Private Database As String
    Private Password As String
    Private Username As String
    Public dialogcapt As String
    Private OperCode As String
    Private Opername As String
    Public Property compname() As String
        Get
            Return company
        End Get
        Set(ByVal value As String)
            company = value
        End Set
    End Property
    Public Property servername() As String
        Get
            Return server
        End Get
        Set(ByVal value As String)
            Server = value
        End Set
    End Property
    Public Property dbname() As String
        Get
            Return Database
        End Get
        Set(ByVal value As String)
            Database = value
        End Set
    End Property
    Public Property usname() As String
        Get
            Return Username
        End Get
        Set(ByVal value As String)
            Username = value
        End Set
    End Property
    Public Property pword() As String
        Get
            Return Password
        End Get
        Set(ByVal value As String)
            Password = value
        End Set
    End Property
    Public Property Operatorname() As String
        Get
            Return Opername
        End Get
        Set(ByVal value As String)
            Opername = value
        End Set
    End Property
    Public Property OperatorCode() As String
        Get
            Return OperCode
        End Get
        Set(ByVal value As String)
            OperCode = value
        End Set
    End Property
End Class
