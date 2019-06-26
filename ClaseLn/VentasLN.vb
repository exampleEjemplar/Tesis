Imports ClaseDa
Imports ClaseNe
Public Class VentasLN
	Private ventasDA As VentasDA


	Public Sub New()
		ventasDA = New VentasDA
	End Sub

	Public Function CargarGrillaVentas(ByVal parametros As Dictionary(Of String, String))
		Return ventasDA.CargarGrillaVentas(parametros)
	End Function

    Public Sub Registrar(listaDeProductosId As List(Of TipoDeVentasNE), clienteId As Integer)
        ventasDA.Registrar(listaDeProductosId, clienteId)
    End Sub

    Public Function ObtenerUltimaVenta()
        Return ventasDA.ObtenerUltimaVenta
    End Function
End Class
