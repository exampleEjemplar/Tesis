Imports System.Windows.Forms
Imports ClaseLn

Public Class FrmGestionVentas

	Private helpersLN As New HelpersLN
	Private ventasLN As New VentasLN

#Region "Eventos"
	Private Sub FrmGestionVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LlenarCboClientes()
		LlenarDgv(New Dictionary(Of String, String))
		dtpFechaHasta.Visible = False
		dtpFechaDesde.Visible = False
		lblFechaExacta.Visible = False
		lblHasta.Visible = False
		lbldesde.Visible = False
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

	Public Function LlenarDgv(ByVal parametros As Dictionary(Of String, String)) As DataSet
		Dim dsa1 As DataSet
		dsa1 = ventasLN.CargarGrillaVentas(parametros) 'Si parametros esta vacio, busca todos los clientes en la bd
		dgvProveedores.DataSource = dsa1.Tables(0)
		dgvProveedores.Columns("Id").Visible = False
		Return dsa1
	End Function

	Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
		Dim parametros As Dictionary(Of String, String) = New Dictionary(Of String, String)
		If String.IsNullOrWhiteSpace(cboCliente.SelectedValue) = False Then
			parametros.Add("ClienteId", cboCliente.SelectedValue)
		End If
		If String.IsNullOrWhiteSpace(dtpFechaDesde.Value.ToString()) = False And dtpFechaDesde.Visible Then
			parametros.Add("FechaDesde", dtpFechaDesde.Value.Date.ToString("dd/MM/yyyy"))
		End If
		If String.IsNullOrWhiteSpace(dtpFechaHasta.Value.ToString()) = False And dtpFechaDesde.Visible And dtpFechaHasta.Visible Then
			parametros.Add("FechaHasta", dtpFechaHasta.Value.Date.ToString("dd/MM/yyyy"))
		End If
		LlenarDgv(parametros)
	End Sub

	Private Sub rbtEntreFechas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEntreFechas.CheckedChanged, rbtFechaExacta.CheckedChanged

		If rbtFechaExacta.Checked Then
			lblFechaExacta.Visible = True
			lbldesde.Visible = False
			rbtEntreFechas.Checked = False
			lblHasta.Visible = False
			dtpFechaHasta.Visible = False
			dtpFechaDesde.Visible = True
		ElseIf rbtEntreFechas.checked Then
			lblFechaExacta.Visible = False
			rbtFechaExacta.Checked = False
			lblHasta.Visible = True
			dtpFechaHasta.Visible = True
			dtpFechaDesde.Visible = True
			lbldesde.Visible = True
		ElseIf Not rbtEntreFechas.Checked And Not rbtFechaExacta.Checked Then
			dtpFechaHasta.Visible = False
			dtpFechaDesde.Visible = False
			lblFechaExacta.Visible = False
			lblHasta.Visible = False
			lbldesde.Visible = False
		End If

	End Sub

#End Region

End Class