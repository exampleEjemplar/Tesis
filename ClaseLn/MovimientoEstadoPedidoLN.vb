﻿Imports ClaseDa
Imports ClaseNe
Public Class MovimientoEstadoPedidoLN
	Private MovimientoEstadoPedidoDA As MovimientoEstadoPedidoDA


	Public Sub New()
		MovimientoEstadoPedidoDA = New MovimientoEstadoPedidoDA
	End Sub

	Public Function CargarMovimientosAgrupadoPorProveedor() As DataSet
		Return MovimientoEstadoPedidoDA.CargarMovimientosAgrupadoPorProveedor()
	End Function

	Public Function CargarMovimientosEstado(ByVal idpedido As Integer) As DataSet
        Return MovimientoEstadoPedidoDA.CargarMovimientosEstado(idpedido)
    End Function

End Class

