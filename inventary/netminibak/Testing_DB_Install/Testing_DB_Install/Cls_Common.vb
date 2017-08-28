Public Class Cls_Common
    Private G_App_caption As String
    Private G_CmpCode As String
    Private G_CmpName As String
    Private G_ServerName As String
    Private G_ServerPass As String
    Private G_Tran_Period As String
    Private G_dbname As String
    Private G_re_dbname As String
    Private G_dbpath As String
    Public Property Prop_AppCapt() As String
        Get
            Prop_AppCapt = G_App_caption
        End Get
        Set(ByVal value As String)
            G_App_caption = value
        End Set
    End Property
    Public Property Prop_CmpCode() As String
        Get
            Prop_CmpCode = G_CmpCode
        End Get
        Set(ByVal value As String)
            G_CmpCode = value
        End Set
    End Property
    Public Property Prop_CmpName() As String
        Get
            Prop_CmpName = G_CmpName
        End Get
        Set(ByVal value As String)
            G_CmpName = value
        End Set
    End Property
    Public Property Prop_ServerName() As String
        Get
            Prop_ServerName = G_ServerName
        End Get
        Set(ByVal value As String)
            G_ServerName = value
        End Set
    End Property
    Public Property Prop_ServerPass() As String
        Get
            Prop_ServerPass = G_ServerPass
        End Get
        Set(ByVal value As String)
            G_ServerPass = value
        End Set
    End Property
    Public Property Prop_TransPeriod() As String
        Get
            Prop_TransPeriod = G_Tran_Period
        End Get
        Set(ByVal value As String)
            G_Tran_Period = value
        End Set
    End Property
    Public Property Prop_DBName() As String
        Get
            Prop_DBName = G_dbname
        End Get
        Set(ByVal value As String)
            G_dbname = value
        End Set
    End Property
    Public Property Prop_Re_DBName() As String
        Get
            Prop_Re_DBName = G_re_dbname
        End Get
        Set(ByVal value As String)
            G_re_dbname = value
        End Set
    End Property
    Public Property Prop_DBPath() As String
        Get
            Prop_DBPath = G_dbpath
        End Get
        Set(ByVal value As String)
            G_dbpath = value
        End Set
    End Property
End Class
