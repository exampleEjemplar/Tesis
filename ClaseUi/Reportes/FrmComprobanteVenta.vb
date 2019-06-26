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
    Dim reportpath As String

    Private Sub FrmComprobanteVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rpVentas.RefreshReport()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim rpVentasDS As New ReportDataSource
        Dim CompVentasNE As New ComprobanteVentasNE
        Dim UltimaVenta As DataSet = VentasLN.ObtenerUltimaVenta()
        Dim idVenta As Integer

        idVenta = UltimaVenta.Tables(0).Rows(0).Item(0).ToString

        Dim dsProducto As DataSet = VentasLN.ObtenerDatosProducto(idVenta)
        Dim dsCliente As DataSet = VentasLN.ObtenerDatosCliente(idVenta)
        CompVentasNE.Comprobante = helpersUI.AgregarNumerosComprobante(idVenta)
        Try
            'Cargo datos en objeto
            For i As Integer = 0 To dsProducto.Tables(0).Rows.Count - 1

                CompVentasNE.Producto = dsProducto.Tables(0).Rows(i)(1).ToString
                CompVentasNE.PrecioUnit = dsProducto.Tables(0).Rows(i).Item(2).ToString
                CompVentasNE.UnidadPeso = dsProducto.Tables(0).Rows(i).Item(3).ToString
                CompVentasNE.Cantidad = dsProducto.Tables(0).Rows(i).Item(4).ToString
            Next
            CompVentasNE.NombreCliente = dsCliente.Tables(0).Rows(0).Item(0).ToString
            CompVentasNE.TipoDoc = dsCliente.Tables(0).Rows(0).Item(1).ToString
            CompVentasNE.Documento = dsCliente.Tables(0).Rows(0).Item(2).ToString 'y esto
            CompVentasNE.DomicilioCliente = dsCliente.Tables(0).Rows(0).Item(3).ToString
            CompVentasNE.Total = dsCliente.Tables(0).Rows(0).Item(4).ToString

            'reportpath = "ClaseIU.Reportes.ComprobanteVenta.rdlc"
            'rpVentas.LocalReport.ReportEmbeddedResource = reportpath
            ComprobanteVentasNEBindingSource.DataSource = CompVentasNE

            rpVentas.RefreshReport()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#End Region
End Class