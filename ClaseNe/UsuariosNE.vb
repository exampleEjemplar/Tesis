Public Class UsuariosNE

    Private _Id As Integer

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = CStr(value)
        End Set
    End Property

    Private _UserName As String

    Public Property UserName As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            _UserName = CStr(value)
        End Set
    End Property

    Private _Contrasena As String

    Public Property Contrasena As String
        Get
            Return _Contrasena
        End Get
        Set(ByVal value As String)
            _Contrasena = CStr(value)
        End Set
    End Property

    Private _RolId As Integer

    Public Property RolId As Integer
        Get
            Return _RolId
        End Get
        Set(ByVal value As Integer)
            _RolId = CStr(value)
        End Set
    End Property

    Private _ActivoSN As String

    Public Property ActivoSN As String
        Get
            Return _ActivoSN
        End Get
        Set(ByVal value As String)
            _ActivoSN = CStr(value)
        End Set
    End Property

End Class
