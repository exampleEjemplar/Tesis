Imports ClaseLn
Imports ClaseNe
Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmComprobanteVenta

    Private helpersLN As New HelpersLN
    Private helpersUI As New HelpersUI
    Private VentasLN As New VentasLN
    Public ListaVentas As New List(Of TipoDeVentasNE)


#Region "Eventos"

	Private Sub FrmComprobanteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Me.rpVentas.RefreshReport()
		Dim rpVentasDS As New ReportDataSource
		Dim ListaDeCompVentasNE As List(Of ComprobanteVentasNE) = New List(Of ComprobanteVentasNE)
		Dim UltimaVenta As DataSet = VentasLN.ObtenerUltimaVenta()
		Dim idVenta As Integer

		idVenta = UltimaVenta.Tables(0).Rows(0).Item(0).ToString

		Dim dsProducto As DataSet = VentasLN.ObtenerDatosProducto(idVenta)
		Dim dsCliente As DataSet = VentasLN.ObtenerDatosCliente(idVenta)
		Try
			'Cargo datos en objeto
			For i As Integer = 0 To dsProducto.Tables(0).Rows.Count - 1

				Dim CompVentasNE As New ComprobanteVentasNE
				CompVentasNE.Comprobante = helpersUI.AgregarNumerosComprobante(idVenta)
				CompVentasNE.Producto = dsProducto.Tables(0).Rows(i)(1).ToString
				CompVentasNE.PrecioUnit = dsProducto.Tables(0).Rows(i).Item(2).ToString
				CompVentasNE.UnidadPeso = dsProducto.Tables(0).Rows(i).Item(3).ToString
				CompVentasNE.Cantidad = dsProducto.Tables(0).Rows(i).Item(4).ToString
				CompVentasNE.NombreCliente = dsCliente.Tables(0).Rows(0).Item(0).ToString
				CompVentasNE.TipoDoc = dsCliente.Tables(0).Rows(0).Item(1).ToString
				CompVentasNE.Documento = dsCliente.Tables(0).Rows(0).Item(2).ToString
				CompVentasNE.DomicilioCliente = dsCliente.Tables(0).Rows(0).Item(3).ToString
				CompVentasNE.Total = dsCliente.Tables(0).Rows(0).Item(4).ToString
				ListaDeCompVentasNE.Add(CompVentasNE)
			Next

			ComprobanteVentasNEBindingSource.DataSource = ListaDeCompVentasNE

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