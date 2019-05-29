Imports System.Windows.Forms
Imports ClaseLn

Public Class FrmGestionVentas

	Private helpersLN As New HelpersLN

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		FrmArmadoVenta.Show()
	End Sub

	Private Sub FrmGestionVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LlenarCboClientes()
	End Sub

	Public Function LlenarCboClientes()
		Try
			Dim ds1 As DataSet
			ds1 = helpersLN.CargarCboTodosClientes()
			cboCliente.DataSource = ds1.Tables(0)
			cboCliente.DisplayMember = "nombre"
			cboCliente.ValueMember = "id"
			cboCliente.SelectedValue = 0

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return cboCliente.SelectedValue
		MessageBox.Show(cboCliente.SelectedValue)
	End Function
End Class