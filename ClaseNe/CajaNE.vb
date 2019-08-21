Public Class CajaNE
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

	Private _UsuarioId As Integer

	Public Property UsuarioId As Integer
		Get
			Return _UsuarioId
		End Get
		Set(ByVal value As Integer)
			_UsuarioId = CStr(value)
		End Set
	End Property

	Private _Tipo As String

	Public Property Tipo As String
		Get
			Return _Tipo
		End Get
		Set(ByVal value As String)
			_Tipo = CStr(value)
		End Set
	End Property

	Private _Movimiento As String

	Public Property Movimiento As String
		Get
			Return _Movimiento
		End Get
		Set(ByVal value As String)
			_Movimiento = CStr(value)
		End Set
	End Property

	Private _Usuario As String

	Public Property Usuario As String
		Get
			Return _Usuario
		End Get
		Set(ByVal value As String)
			_Usuario = CStr(value)
		End Set
	End Property
End Class
