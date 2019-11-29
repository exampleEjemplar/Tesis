Imports ClaseLn

Public Class FrmEstadisticaPedidos
	Private MovimientoEstadoPedidoLN As New MovimientoEstadoPedidoLN

	Private Sub FrmEstadisticaPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim ds = MovimientoEstadoPedidoLN.CargarMovimientosEstado()
		Dim registros = New List(Of MovimientoEstadoPedidoEstadistica)
		For i = 0 To ds.Tables(0).Rows.Count - 1
			registros.Add(New MovimientoEstadoPedidoEstadistica With {
			  .Id = ds.Tables(0).Rows(i)(0).ToString(),
			  .PedidoId = ds.Tables(0).Rows(i)(1).ToString(),
			  .Estado = ds.Tables(0).Rows(i)(2).ToString(),
			  .Fecha = ds.Tables(0).Rows(i)(3).ToString(),
			  .Activo = ds.Tables(0).Rows(i)(4).ToString()
		  })
		Next

		Dim agrupadosPorPedidoId = registros.GroupBy(Function(x) x.PedidoId).ToList()
		For index = 0 To agrupadosPorPedidoId.Count - 1
			Dim PedidoId = agrupadosPorPedidoId(index).Key

			For Each MovEstPedido As MovimientoEstadoPedidoEstadistica In agrupadosPorPedidoId(index)
				Dim esteMovimiento = registros.FirstOrDefault(Function(x) x.Id = MovEstPedido.Id)
				If MovEstPedido.Activo = "1" Then
					esteMovimiento.HorasActivo = (Date.Now - MovEstPedido.Fecha).TotalHours
					Continue For
				Else
					Dim fechaDelSiguiente = agrupadosPorPedidoId(index).Where(Function(x) Not x.Id = MovEstPedido.Id).OrderBy(Function(x) x.Fecha).FirstOrDefault().Fecha
					esteMovimiento.HorasActivo = (fechaDelSiguiente - MovEstPedido.Fecha).TotalHours
				End If
			Next
		Next
		Dim a = "asdasdda"
	End Sub
End Class

Public Class MovimientoEstadoPedidoEstadistica
	Private _Id As String

	Public Property Id As String
		Get
			Return _Id
		End Get
		Set(ByVal value As String)
			_Id = CStr(value)
		End Set
	End Property
	Private _PedidoId As String

	Public Property PedidoId As String
		Get
			Return _PedidoId
		End Get
		Set(ByVal value As String)
			_PedidoId = CStr(value)
		End Set
	End Property
	Private _Fecha As Date

	Public Property Fecha As Date
		Get
			Return _Fecha
		End Get
		Set(ByVal value As Date)
			_Fecha = CStr(value)
		End Set
	End Property
	Private _Estado As String

	Public Property Estado As String
		Get
			Return _Estado
		End Get
		Set(ByVal value As String)
			_Estado = CStr(value)
		End Set
	End Property
	Private _Activo As String

	Public Property Activo As String
		Get
			Return _Activo
		End Get
		Set(ByVal value As String)
			_Activo = CStr(value)
		End Set
	End Property

	Private _HorasActivo As String

	Public Property HorasActivo As String
		Get
			Return _HorasActivo
		End Get
		Set(ByVal value As String)
			_HorasActivo = CStr(value)
		End Set
	End Property
End Class

