Imports ClaseDa
Imports ClaseNe
Public Class ComprasLN
	Private ComprasDA As ComprasDA
    Public contador As Integer


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

    Public Function GeneraGraficoMontoComprasPorMes(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return ComprasDA.GeneraGraficoMontoComprasPorMes(fechadesde, fechahasta)
    End Function

    Public Function GeneraGraficoCompraporproveedor(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return ComprasDA.GeneraGraficoCompraporproveedor(fechadesde, fechahasta)
    End Function

    Public Sub Controlfecha(ByVal fechadesde As String, ByVal fechahasta As String)
        ComprasDA.Controlfecha(fechadesde, fechahasta)
        contador = ComprasDA.contador
    End Sub

    Public Function GeneraGraficoCompracantportipo(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return ComprasDA.GeneraGraficoCompracantportipo(fechadesde, fechahasta)
    End Function
End Class
