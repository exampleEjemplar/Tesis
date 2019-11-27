Imports ClaseDa
Imports ClaseNe
Public Class VentasLN
	Private ventasDA As VentasDA
    Public contador As Integer

    Public Sub New()
		ventasDA = New VentasDA
	End Sub

	Public Function Anular(id As Integer)
		Return ventasDA.Anular(id)
	End Function

	Public Function CargarGrillaVentas(ByVal parametros As Dictionary(Of String, String))
		Return ventasDA.CargarGrillaVentas(parametros)
	End Function

	Public Sub Registrar(listaDeProductosId As List(Of TipoDeVentasNE), clienteId As Integer)
		ventasDA.Registrar(listaDeProductosId, clienteId)
	End Sub

	Public Function ObtenerUnaVenta(id As Integer)
		Return ventasDA.ObtenerUnaVenta(id)
	End Function

	Public Function ObtenerUltimaVenta()
        Return ventasDA.ObtenerUltimaVenta
    End Function
    Public Function ObtenerDatosCliente(ByVal idventa As String) As DataSet
        Return ventasDA.ObtenerDatosCliente(idventa)
    End Function

    Public Function ObtenerDatosProducto(ByVal idventa As String) As DataSet
        Return ventasDA.ObtenerDatosProducto(idventa)
    End Function

    Public Function GeneraGraficoCantVentasFecha(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return ventasDA.GeneraGraficoCantVentasFecha(fechadesde, fechahasta)
    End Function

    Public Function GeneraGraficoCantidadportipo(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return ventasDA.GeneraGraficoCantidadportipo(fechadesde, fechahasta)
    End Function

    Public Function GeneraGraficoCantidadVendedor(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return ventasDA.GeneraGraficoCantidadVendedor(fechadesde, fechahasta)
    End Function

    Public Function GeneraGraficoFacturacionPorMes(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return ventasDA.GeneraGraficoFacturacionPorMes(fechadesde, fechahasta)
    End Function

    Public Sub Controlfecha(ByVal fechadesde As String, ByVal fechahasta As String)
        ventasDA.Controlfecha(fechadesde, fechahasta)
        contador = ventasDA.contador
    End Sub
End Class
