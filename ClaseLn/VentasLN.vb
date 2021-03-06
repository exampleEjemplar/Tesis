﻿Imports ClaseDa
Imports ClaseNe
Public Class VentasLN
	Private ventasDA As VentasDA
    Public contador As Integer

    Public Sub New()
		ventasDA = New VentasDA
	End Sub


	Public Sub RegistrarDesdePedido(listaDeProductosId As List(Of TipoDeVentasNE), clienteId As Integer)
		ventasDA.RegistrarDesdePedido(listaDeProductosId, clienteId)
	End Sub

    Public Sub Anular(id As Integer)
        ventasDA.Anular(id)
    End Sub

    Public Function CargarGrillaVentas(ByVal parametros As Dictionary(Of String, String), orderby As List(Of Tuple(Of Integer, String, Integer)), ascOrDesc as string)
		Return ventasDA.CargarGrillaVentas(parametros, orderby, ascOrDesc)
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

    Public Function GeneraGraficoTotalportipo(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return ventasDA.GeneraGraficoTotalportipo(fechadesde, fechahasta)
    End Function

    Public Sub Controlfecha(ByVal fechadesde As String, ByVal fechahasta As String)
        ventasDA.Controlfecha(fechadesde, fechahasta)
        contador = ventasDA.contador
    End Sub
End Class
