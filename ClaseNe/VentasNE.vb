Public Class VentasNE

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

	Private _ClienteId As Integer

	Public Property ClienteId As Integer
		Get
			Return _ClienteId
		End Get
		Set(ByVal value As Integer)
			_ClienteId = CStr(value)
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

Public Class TipoDeVentasNE

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