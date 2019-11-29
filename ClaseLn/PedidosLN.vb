Imports ClaseDa
Imports ClaseNe
Public Class PedidosLN
	Private pedidosDA As PedidosDA


	Public Sub New()
		pedidosDA = New PedidosDA
	End Sub
	Public Sub ActualizarPedido(ped As VentasNE)
		pedidosDA.ActualizarPedido(ped)
	End Sub

	Public Function ObtenerUnPedido(id As Integer) As DataSet
		Return pedidosDA.ObtenerUnPedido(id)
	End Function

	Public Function CargarGrillaPedidos(ByVal parametros As Dictionary(Of String, String), orderby As List(Of Tuple(Of Integer, String, Integer)), ascOrDesc as string)
		Return pedidosDA.CargarGrillaPedidos(parametros, orderby, ascOrDesc)
	End Function

	Public Sub Registrar(listaDeProductosId As List(Of TipoDeVentasNE), clienteId As Integer, Optional seña As Double = 0.0)
		pedidosDA.Registrar(listaDeProductosId, clienteId, seña)
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

    Public Function cargarcombo() As DataSet
        Return pedidosDA.Cargarcombopedido()
    End Function
End Class
