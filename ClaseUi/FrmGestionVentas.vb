Imports System.Windows.Forms
Imports ClaseLn

Public Class FrmGestionVentas

	Private helpersLN As New HelpersLN
	Private ventasLN As New VentasLN



#Region "Eventos"
	Private Sub FrmGestionVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LlenarCboClientes()
		LlenarDgv(New Dictionary(Of String, String))
	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()
		MDIPrincipal.Show()
	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		FrmArmadoVenta.Show()
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

	'Carga DataGridView con datos
	Public Function LlenarDgv(ByVal parametros As Dictionary(Of String, String)) As DataSet
		Dim dsa1 As DataSet
		dsa1 = ventasLN.CargarGrillaVentas(parametros) 'Si parametros esta vacio, busca todos los clientes en la bd
		'If dsa1.Tables(0).Rows.Count() <> 0 Then
		'	ClienteID = dsa1.Tables(0).Rows(0)(13)
		'End If
		dgvProveedores.DataSource = dsa1.Tables(0)
		dgvProveedores.Columns("Id").Visible = False
		Return dsa1
	End Function
#End Region

End Class