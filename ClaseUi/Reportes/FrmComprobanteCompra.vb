Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe
Imports Microsoft.Reporting.WinForms

Public Class FrmComprobanteCompra

	Private helpersLN As New HelpersLN
	Private helpersUI As New HelpersUI
	Private ComprasLN As New ComprasLN
	Public ListaCompras As New List(Of TipoDeComprasNE)


#Region "Eventos"

	Private Sub FrmComprobanteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Dim rpComprasDS As New ReportDataSource
		Dim ListaDeCompComprasNE As List(Of ComprobanteComprasNE) = New List(Of ComprobanteComprasNE)
		Dim idCompra As Integer

		'Si accedo desde el frmGestionVenta uso ese Id, si no, uso el ultimo.
		Dim compraDeGestion As Integer = FrmGestionCompras.idCompra
		compraDeGestion = FrmConsultaMovimientoCaja.compId
		If compraDeGestion = 0 Then
			idCompra = ComprasLN.ObtenerUltimaCompra().Tables(0).Rows(0).Item(0).ToString
		Else
			idCompra = compraDeGestion
		End If

		'Consulto los productos y cliente de la venta
		Dim dsProducto As DataSet = ComprasLN.ObtenerDatosProducto(idCompra)
		Dim dsCliente As DataSet = ComprasLN.ObtenerDatosCliente(idCompra)
		Dim dsCompra As DataSet = ComprasLN.ObtenerUnaCompra(idCompra)

		Try
			'Cargo datos de los productos en la lista de productos del comprobante
			For i As Integer = 0 To dsProducto.Tables(0).Rows.Count - 1

				Dim CompComprasNE As New ComprobanteComprasNE With {
					.Comprobante = dsCompra.Tables(0).Rows(0).Item(5).ToString,
					.Producto = dsProducto.Tables(0).Rows(i)(1).ToString,
					.PrecioUnit = dsProducto.Tables(0).Rows(i).Item(2).ToString,
					.UnidadPeso = dsProducto.Tables(0).Rows(i).Item(3).ToString,
					.Cantidad = dsProducto.Tables(0).Rows(i).Item(4).ToString
				}

				ListaDeCompComprasNE.Add(CompComprasNE)
			Next

			'Le agrego los datos del cliente a solo un comprobante de venta, con eso alcanza para mostrarlo
			ListaDeCompComprasNE.FirstOrDefault().NombreProveedor = dsCliente.Tables(0).Rows(0).Item(0).ToString
			ListaDeCompComprasNE.FirstOrDefault().TipoDoc = dsCliente.Tables(0).Rows(0).Item(1).ToString
			ListaDeCompComprasNE.FirstOrDefault().Documento = dsCliente.Tables(0).Rows(0).Item(2).ToString
			ListaDeCompComprasNE.FirstOrDefault().DomicilioProveedor = dsCliente.Tables(0).Rows(0).Item(3).ToString
			ListaDeCompComprasNE.FirstOrDefault().Total = dsCliente.Tables(0).Rows(0).Item(4).ToString

			'TODO HACERLO PARA COMPRAS
			ComprobanteVentasNEBindingSource.DataSource = ListaDeCompComprasNE
			'Saque el refresh del principio, perdia performance y funciona igual solo con el ultimo.
			'Tambien lo hice automatico sin necesidad de tocar un boton para generar
			rpCompras.RefreshReport()

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
		End Try
	End Sub

	Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()
	End Sub

#End Region


End Class