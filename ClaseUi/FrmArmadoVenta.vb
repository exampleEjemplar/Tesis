Imports System.Windows.Forms
Imports ClaseLn

Public Class FrmArmadoVenta

	Private helpersLN As New HelpersLN
	Private ventasLN As New VentasLN



#Region "Eventos"
	Private Sub FrmGestionVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LlenarCboClientes()
	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()
		FrmGestionVentas.Show()
	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

	End Sub
#End Region
#Region "Metodos"
	Public Function LlenarCboClientes()
		Try
			Dim ds1 As DataSet
			ds1 = helpersLN.CargarCboTodosClientes()
			cboCliente.DataSource = ds1.Tables(0)
			cboCliente.DisplayMember = "Nombre"
			cboCliente.ValueMember = "id"
			cboCliente.SelectedValue = 0

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return cboCliente.SelectedValue
		MessageBox.Show(cboCliente.SelectedValue)
	End Function
#End Region

End Class