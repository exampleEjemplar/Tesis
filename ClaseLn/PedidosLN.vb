Imports ClaseDa
Imports ClaseNe
Public Class PedidosLN
	Private pedidosDA As PedidosDA


	Public Sub New()
		pedidosDA = New PedidosDA
	End Sub

	Public Function CargarGrillaVentas(ByVal parametros As Dictionary(Of String, String))
		Return pedidosDA.CargarGrillaVentas(parametros)
	End Function

	Public Sub Registrar(listaDeProductosId As List(Of TipoDeVentasNE), clienteId As Integer)
		pedidosDA.Registrar(listaDeProductosId, clienteId)
	End Sub

	Public Function ObtenerUltimoPedido()
		Return pedidosDA.ObtenerUltimoPedido()
	End Function
	Public Function ObtenerDatosCliente(ByVal idventa As String) As DataSet
		Return pedidosDA.ObtenerDatosCliente(idventa)
	End Function

	Public Function ObtenerDatosProducto(ByVal idventa As String) As DataSet
		Return pedidosDA.ObtenerDatosProducto(idventa)
	End Function
End Class
