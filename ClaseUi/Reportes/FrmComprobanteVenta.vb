Imports ClaseLn
Imports ClaseNe
Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmComprobanteVenta

    Private helpersLN As New HelpersLN
    Private helpersUI As New HelpersUI
    Private CompVentasNE As ComprobanteVentasNE


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

        'CompVentasNE.Comprobante = helpersUI.AgregarNumerosComprobante(VentasLN.ObtenerUltimaVenta)

        Try
            reportpath = "ClaseIU.ComprobanteVenta.rdlc"
            rpVentas.LocalReport.ReportEmbeddedResource = reportpath
            'Me.ComprobanteVentasNEBindingSource.DataSource = 

            rpVentas.RefreshReport()

        Catch ex As Exception

        End Try
    End Sub

#End Region
End Class