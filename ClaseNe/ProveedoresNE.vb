Public Class ProveedoresNE

    Private _Id As Integer

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = CStr(value)
        End Set
    End Property

    Private _TipoDocumentoId As Integer

    Public Property TipoDocumentoId As Integer
        Get
            Return _TipoDocumentoId
        End Get
        Set(ByVal value As Integer)
            _TipoDocumentoId = CStr(value)
        End Set
    End Property

    Private _NumeroDocumento As Integer

    Public Property NumeroDocumento As Integer
        Get
            Return _NumeroDocumento
        End Get
        Set(ByVal value As Integer)
            _NumeroDocumento = CStr(value)
        End Set
    End Property

    Private _NumeroCalle As Integer

    Public Property NumeroCalle As Integer
        Get
            Return _NumeroCalle
        End Get
        Set(ByVal value As Integer)
            _NumeroCalle = CStr(value)
        End Set
    End Property

    Private _Piso As Integer

    Public Property Piso As Integer
        Get
            Return _Piso
        End Get
        Set(ByVal value As Integer)
            _Piso = CStr(value)
        End Set
    End Property

    Private _Manzana As Integer

    Public Property Manzana As Integer
        Get
            Return _Manzana
        End Get
        Set(ByVal value As Integer)
            _Manzana = CStr(value)
        End Set
    End Property

    Private _Lote As Integer

    Public Property Lote As Integer
        Get
            Return _Lote
        End Get
        Set(ByVal value As Integer)
            _Lote = CStr(value)
        End Set
    End Property

    Private _CiudadId As Integer

    Public Property CiudadId As Integer
        Get
            Return _CiudadId
        End Get
        Set(ByVal value As Integer)
            _CiudadId = CStr(value)
        End Set
    End Property

    Private _Car_Telefono As Integer

    Public Property Car_Telefono As Integer
        Get
            Return _Car_Telefono
        End Get
        Set(ByVal value As Integer)
            _Car_Telefono = CStr(value)
        End Set
    End Property

    Private _NumeroTelefono As Integer

    Public Property NumeroTelefono As Integer
        Get
            Return _NumeroTelefono
        End Get
        Set(ByVal value As Integer)
            _NumeroTelefono = CStr(value)
        End Set
    End Property

    Private _Car_Celular As Integer

    Public Property Car_Celular As Integer
        Get
            Return _Car_Celular
        End Get
        Set(ByVal value As Integer)
            _Car_Celular = CStr(value)
        End Set
    End Property

    Private _NumeroCelular As Integer

    Public Property NumeroCelular As Integer
        Get
            Return _NumeroCelular
        End Get
        Set(ByVal value As Integer)
            _NumeroCelular = CStr(value)
        End Set
    End Property

    Private _Nombre As String

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = CStr(value)
        End Set
    End Property

    Private _UsuarioId As Integer

    Public Property UsuarioId As Integer
        Get
            Return _UsuarioId
        End Get
        Set(ByVal value As Integer)
            _UsuarioId = CStr(value)
        End Set
    End Property

    Private _Apellido As String

    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = CStr(value)
        End Set
    End Property

    Private _Calle As String

    Public Property Calle As String
        Get
            Return _Calle
        End Get
        Set(ByVal value As String)
            _Calle = CStr(value)
        End Set
    End Property

    Private _Departamento As String

    Public Property Departamento As String
        Get
            Return _Departamento
        End Get
        Set(ByVal value As String)
            _Departamento = CStr(value)
        End Set
    End Property

    Private _Barrio As String

    Public Property Barrio As String
        Get
            Return _Barrio
        End Get
        Set(ByVal value As String)
            _Barrio = CStr(value)
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

    Private _Email As String

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = CStr(value)
        End Set
    End Property

    Private _FisicaOJuridica As String

    Public Property FisicaOJuridica As String
        Get
            Return _FisicaOJuridica
        End Get
        Set(ByVal value As String)
            _FisicaOJuridica = CStr(value)
        End Set
    End Property

    Private _FechaNacimiento As Date

    Public Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(ByVal value As Date)
            _FechaNacimiento = CStr(value)
        End Set
    End Property

    Private _FechaAlta As Date

    Public Property FechaAlta As Date
        Get
            Return _FechaAlta
        End Get
        Set(ByVal value As Date)
            _FechaAlta = CStr(value)
        End Set
    End Property
End Class
