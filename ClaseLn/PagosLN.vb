Imports ClaseDa
Imports ClaseNe
Public Class PagosLN
	Private pagosDA As PagosDA


	Public Sub New()
		pagosDA = New PagosDA
	End Sub

	Public Function CargarGrillaPagos(ByVal parametros As Dictionary(Of String, String), orderby As List(Of Tuple(Of Integer, String, Integer)))
		Return pagosDA.CargarGrillaPagos(parametros, orderby)
	End Function

	Public Sub Registrar(listaDeProductosId As List(Of TipoDeComprasNE))
		pagosDA.Registrar(listaDeProductosId)
	End Sub

	Public Function ObtenerUltimoPago()
		Return pagosDA.ObtenerUltimoPago
	End Function
	Public Function ObtenerDatosCliente(ByVal idcompra As String) As DataSet
		Return pagosDA.ObtenerDatosCliente(idcompra)
	End Function

	Public Function ObtenerDatosProducto(ByVal idcompra As String) As DataSet
		Return pagosDA.ObtenerDatosProducto(idcompra)
	End Function
End Class
