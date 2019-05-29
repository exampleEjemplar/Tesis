Public Class MovimientoStockNE
    Private _Id As Integer

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = CStr(value)
        End Set
    End Property

    Private _Cantidad As Integer

    Public Property Cantidad As Double
        Get
            Return _Cantidad
        End Get
        Set(ByVal value As Double)
            _Cantidad = CStr(value)
        End Set
    End Property

    Private _ProductoId As Integer
    Public Property ProductoId As Double
        Get
            Return _ProductoId
        End Get
        Set(ByVal value As Double)
            _ProductoId = CStr(value)
        End Set
    End Property

    Private _Fecha As DateTime

    Public Property Fecha As DateTime
        Get
            Return _Fecha
        End Get
        Set(ByVal value As DateTime)
            _Fecha = CStr(value)
        End Set
    End Property

End Class
