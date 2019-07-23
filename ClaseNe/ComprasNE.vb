Public Class ComprasNE

	Private _Id As Integer

	Public Property Id As Integer
		Get
			Return _Id
		End Get
		Set(ByVal value As Integer)
			_Id = CStr(value)
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

	Private _ProveedorId As Integer

	Public Property ProveedorId As Integer
		Get
			Return _ProveedorId
		End Get
		Set(ByVal value As Integer)
			_ProveedorId = CStr(value)
		End Set
	End Property

	Private _Total As Double

	Public Property Total As Double
		Get
			Return _Total
		End Get
		Set(ByVal value As Double)
			_Total = CStr(value)
		End Set
	End Property
End Class

Public Class TipoDeComprasNE

	Private _Id As Integer

	Public Property Id As Integer
		Get
			Return _Id
		End Get
		Set(ByVal value As Integer)
			_Id = CStr(value)
		End Set
	End Property

	Private _VentaId As Integer

	Public Property VentaId As Integer
		Get
			Return _VentaId
		End Get
		Set(ByVal value As Integer)
			_VentaId = CStr(value)
		End Set
	End Property

	Private _ProductoId As Integer

	Public Property ProductoId As Integer
		Get
			Return _ProductoId
		End Get
		Set(ByVal value As Integer)
			_ProductoId = CStr(value)
		End Set
	End Property

	Private _Cantidad As Double

	Public Property Cantidad As Double
		Get
			Return _Cantidad
		End Get
		Set(ByVal value As Double)
			_Cantidad = CStr(value)
		End Set
	End Property

	Private _Precio As Double

	Public Property Precio As Double
		Get
			Return _Precio
		End Get
		Set(ByVal value As Double)
			_Precio = CStr(value)
		End Set
	End Property

	Private _SubTotal As Double

	Public Property SubTotal As Double
		Get
			Return _SubTotal
		End Get
		Set(ByVal value As Double)
			_SubTotal = CStr(value)
		End Set
	End Property

	Private _Fecha As DateTime

	Private _IVA As Double

	Public Property IVA As Double
		Get
			Return _IVA
		End Get
		Set(ByVal value As Double)
			_IVA = CStr(value)
		End Set
	End Property
End Class

Public Class ComprobanteComprasNE
	Private _Comprobante As String

	Public Property Comprobante As String
		Get
			Return _Comprobante
		End Get
		Set(ByVal value As String)
			_Comprobante = CStr(value)
		End Set
	End Property


	Private _NombreProveedor As String

	Public Property NombreProveedor As String
		Get
			Return _NombreProveedor
		End Get
		Set(ByVal value As String)
			_NombreProveedor = CStr(value)
		End Set
	End Property

	Private _TipoDoc As String

	Public Property TipoDoc As String
		Get
			Return _TipoDoc
		End Get
		Set(ByVal value As String)
			_TipoDoc = CStr(value)
		End Set
	End Property

	Private _Documento As String

	Public Property Documento As String
		Get
			Return _Documento
		End Get
		Set(ByVal value As String)
			_Documento = CStr(value)
		End Set
	End Property

	Private _DomicilioProveedor As String

	Public Property DomicilioProveedor As String
		Get
			Return _DomicilioProveedor
		End Get
		Set(ByVal value As String)
			_DomicilioProveedor = CStr(value)
		End Set
	End Property

	Private _UnidadPeso As String

	Public Property UnidadPeso As String
		Get
			Return _UnidadPeso
		End Get
		Set(ByVal value As String)
			_UnidadPeso = CStr(value)
		End Set
	End Property

	Private _Cantidad As String

	Public Property Cantidad As String
		Get
			Return _Cantidad
		End Get
		Set(ByVal value As String)
			_Cantidad = CStr(value)
		End Set
	End Property

	Private _Producto As String

	Public Property Producto As String
		Get
			Return _Producto
		End Get
		Set(ByVal value As String)
			_Producto = CStr(value)
		End Set
	End Property

	Private _PrecioUnit As Double

	Public Property PrecioUnit As Double
		Get
			Return _PrecioUnit
		End Get
		Set(ByVal value As Double)
			_PrecioUnit = value
		End Set
	End Property
	Private _Total As Double

	Public Property Total As Double
		Get
			Return _Total
		End Get
		Set(ByVal value As Double)
			_Total = value
		End Set
	End Property
End Class