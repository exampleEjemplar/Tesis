Public Class ProductosNE

    Private _Id As Integer

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = CStr(value)
        End Set
    End Property

    Private _CodBarra As String

    Public Property CodBarra As String
        Get
            Return _CodBarra
        End Get
        Set(ByVal value As String)
            _CodBarra = CStr(value)
        End Set
    End Property

    Private _nombreprducto As String

    Public Property nombreprducto As String
        Get
            Return _nombreprducto
        End Get
        Set(ByVal value As String)
            _nombreprducto = CStr(value)
        End Set
    End Property

    Private _foto() As Byte

    Public Property foto()
        Get
            Return _foto
        End Get
        Set(ByVal value)
            _foto = value
        End Set
    End Property

    Private _precio As Double

    Public Property precio As Double
        Get
            Return _precio
        End Get
        Set(ByVal value As Double)
            _precio = CStr(value)
        End Set
    End Property

    Private _utilidad As Double

    Public Property utilidad As Double
        Get
            Return _utilidad
        End Get
        Set(ByVal value As Double)
            _utilidad = CStr(value)
        End Set
    End Property

    Private _materialid As Integer

    Public Property materialid As Integer
        Get
            Return _materialid
        End Get
        Set(ByVal value As Integer)
            _materialid = CStr(value)
        End Set
    End Property

    Private _peso As Double

    Public Property peso As Double
        Get
            Return _peso
        End Get
        Set(ByVal value As Double)
            _peso = CStr(value)
        End Set
    End Property

    Private _tamaño As Double

    Public Property tamaño As Double
        Get
            Return _tamaño
        End Get
        Set(ByVal value As Double)
            _tamaño = CStr(value)
        End Set
    End Property

    Private _color As String

    Public Property color As String
        Get
            Return _color
        End Get
        Set(ByVal value As String)
            _color = CStr(value)
        End Set
    End Property

    Private _proveedorId As String

    Public Property proveedorId As Integer
        Get
            Return _proveedorId
        End Get
        Set(ByVal value As Integer)
            _proveedorId = CStr(value)
        End Set
    End Property

    Private _stockmin As Integer

    Public Property stockmin As Integer
        Get
            Return _stockmin
        End Get
        Set(ByVal value As Integer)
            _stockmin = CStr(value)
        End Set
    End Property

    Private _stockmax As Integer

    Public Property stockmax As Integer
        Get
            Return _stockmax
        End Get
        Set(ByVal value As Integer)
            _stockmax = CStr(value)
        End Set
    End Property

    Private _unidad As String

    Public Property Unidad As String
        Get
            Return _unidad
        End Get
        Set(ByVal value As String)
            _unidad = CStr(value)
        End Set
    End Property

    Private _TipodeProductoId As Integer

    Public Property TipodeProductoId As Integer
        Get
            Return _TipodeProductoId
        End Get
        Set(ByVal value As Integer)
            _TipodeProductoId = CStr(value)
        End Set
    End Property

    Private _categoriaId As Integer

    Public Property categoriaId As Integer
        Get
            Return _categoriaId
        End Get
        Set(ByVal value As Integer)
            _categoriaId = CStr(value)
        End Set
    End Property



    Private _StockODeTercero As Integer
    Public Property StockODeTercero As Integer
        Get
            Return _StockODeTercero
        End Get
        Set(ByVal value As Integer)
            _StockODeTercero = CStr(value)
        End Set
    End Property


End Class
