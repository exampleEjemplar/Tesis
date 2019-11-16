Imports ClaseDa
Imports ClaseNe
Public Class ComprasLN
	Private ComprasDA As ComprasDA


	Public Sub New()
		ComprasDA = New ComprasDA
	End Sub

	Public Function ObtenerUnaCompra(id As Integer)
		Return ComprasDA.ObtenerUnaCompra(id)
	End Function

	Public Function CargarGrillaCompras(ByVal parametros As Dictionary(Of String, String))
		Return ComprasDA.CargarGrillaCompras(parametros)
	End Function

	Public Sub Registrar(listaDeProductosId As List(Of TipoDeComprasNE), clienteId As Integer, nroComprobante As String)
		ComprasDA.Registrar(listaDeProductosId, clienteId, nroComprobante)
	End Sub

	Public Function ObtenerUltimaCompra()
		Return ComprasDA.ObtenerUltimaCompra
	End Function
	Public Function ObtenerDatosCliente(ByVal idcompra As String) As DataSet
		Return ComprasDA.ObtenerDatosCliente(idcompra)
	End Function

	Public Function ObtenerDatosProducto(ByVal idcompra As String) As DataSet
		Return ComprasDA.ObtenerDatosProducto(idcompra)
	End Function
End Class
