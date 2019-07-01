Imports System.Windows.Forms
Imports ClaseLn

Public Class FrmGestionCompras

	Private helpersLN As New HelpersLN
	Private comprasLN As New ComprasLN



#Region "Eventos"
	Private Sub FrmGestionCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LlenarCboProveedores()
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
	Public Function LlenarCboProveedores()
		Try
			Dim ds1 As DataSet
			ds1 = helpersLN.CargarCboTodosClientes()
			cboProveedor.DataSource = ds1.Tables(0)
			cboProveedor.DisplayMember = "Nombre"
			cboProveedor.ValueMember = "id"
			cboProveedor.SelectedValue = 0

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return cboProveedor.SelectedValue
		MessageBox.Show(cboProveedor.SelectedValue)
	End Function

	'Carga DataGridView con datos
	Public Function LlenarDgv(ByVal parametros As Dictionary(Of String, String)) As DataSet
		Dim dsa1 As DataSet
		dsa1 = comprasLN.CargarGrillaCompras(parametros) 'Si parametros esta vacio, busca todos los clientes en la bd
		'If dsa1.Tables(0).Rows.Count() <> 0 Then
		'	ClienteID = dsa1.Tables(0).Rows(0)(13)
		'End If
		dgvProveedores.DataSource = dsa1.Tables(0)
		dgvProveedores.Columns("Id").Visible = False
		Return dsa1
	End Function
#End Region

End Class