Imports ClaseDa
Imports ClaseNe
Public Class MovimientoEstadoPedidoLN
	Private MovimientoEstadoPedidoDA As MovimientoEstadoPedidoDA


	Public Sub New()
		MovimientoEstadoPedidoDA = New MovimientoEstadoPedidoDA
	End Sub

	Public Function CargarMovimientosEstado() As DataSet
		Return MovimientoEstadoPedidoDA.CargarMovimientosEstado()
	End Function

End Class

