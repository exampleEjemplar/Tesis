Imports ClaseLn
Imports ClaseNe
Imports Microsoft.Reporting.WinForms

Public Class FrmComprobanteVenta

    Private helpersLN As New HelpersLN
    Private helpersUI As New HelpersUI
    Private VentasLN As New VentasLN
    Public ListaVentas As New List(Of TipoDeVentasNE)


#Region "Eventos"

	Private Sub FrmComprobanteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Dim rpVentasDS As New ReportDataSource
		Dim ListaDeCompVentasNE As List(Of ComprobanteVentasNE) = New List(Of ComprobanteVentasNE)
		Dim idVenta As Integer

		'Si accedo desde el frmGestionVenta uso ese Id, si no, uso el ultimo.
		Dim ventaDeGestion As Integer = FrmGestionVentas.idVenta
		If ventaDeGestion = 0 Then
			idVenta = VentasLN.ObtenerUltimaVenta().Tables(0).Rows(0).Item(0).ToString
		Else
			idVenta = ventaDeGestion
		End If

		'Consulto los productos y cliente de la venta
		Dim dsProducto As DataSet = VentasLN.ObtenerDatosProducto(idVenta)
		Dim dsCliente As DataSet = VentasLN.ObtenerDatosCliente(idVenta)

		Try
			'Cargo datos de los productos en la lista de productos del comprobante
			For i As Integer = 0 To dsProducto.Tables(0).Rows.Count - 1

				Dim CompVentasNE As New ComprobanteVentasNE
				CompVentasNE.Comprobante = helpersUI.AgregarNumerosComprobante(idVenta)
				CompVentasNE.Producto = dsProducto.Tables(0).Rows(i)(1).ToString
				CompVentasNE.PrecioUnit = dsProducto.Tables(0).Rows(i).Item(2).ToString
				CompVentasNE.UnidadPeso = dsProducto.Tables(0).Rows(i).Item(3).ToString
				CompVentasNE.Cantidad = dsProducto.Tables(0).Rows(i).Item(4).ToString

				ListaDeCompVentasNE.Add(CompVentasNE)
			Next

			'Le agrego los datos del cliente a solo un comprobante de venta, con eso alcanza para mostrarlo
			ListaDeCompVentasNE.FirstOrDefault().NombreCliente = dsCliente.Tables(0).Rows(0).Item(0).ToString
			ListaDeCompVentasNE.FirstOrDefault().TipoDoc = dsCliente.Tables(0).Rows(0).Item(1).ToString
			ListaDeCompVentasNE.FirstOrDefault().Documento = dsCliente.Tables(0).Rows(0).Item(2).ToString
			ListaDeCompVentasNE.FirstOrDefault().DomicilioCliente = dsCliente.Tables(0).Rows(0).Item(3).ToString
			ListaDeCompVentasNE.FirstOrDefault().Total = dsCliente.Tables(0).Rows(0).Item(4).ToString


			ComprobanteVentasNEBindingSource.DataSource = ListaDeCompVentasNE
			'Saque el refresh del principio, perdia performance y funciona igual solo con el ultimo.
			'Tambien lo hice automatico sin necesidad de tocar un boton para generar
			rpVentas.RefreshReport()

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
		End Try
	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()
	End Sub

#End Region

End Class