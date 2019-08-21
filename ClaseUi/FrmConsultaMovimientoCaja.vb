Imports ClaseLn
Public Class FrmConsultaMovimientoCaja

	Dim cajaLn As New CajaLN
	Dim helpersUI As New HelpersUI
	Public compId As Integer

	Private Sub FrmConsultaCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim ds As DataSet = cajaLn.CargarUnMovimiento(FrmGestionCaja.movCajaId)
		Dim fila = ds.Tables(0).Rows(0)

		txtUsuario.Text = fila(3)
		txtTipo.Text = FrmGestionCaja.movCajaId.Item2
		txtNumeroDeComprobante.Text = "0001-" + helpersUI.AgregarNumerosComprobante(fila(0))
		txtMonto.Text = fila(2)
		txtFecha.Text = fila(1)
		compId = fila(0)

	End Sub

		Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

		With FrmGestionCaja
		End With
		FrmGestionCaja.Show()
		Close()

		End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If FrmGestionCaja.movCajaId.Item2 = "Venta" Then
			FrmComprobanteVenta.ShowDialog()
		Else
			FrmComprobanteCompra.ShowDialog()
		End If
	End Sub
End Class