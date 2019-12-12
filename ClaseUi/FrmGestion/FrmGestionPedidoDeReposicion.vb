Imports System.Windows.Forms
Imports ClaseLn

Public Class FrmGestionPedidoDeReposicion
	Private PedidoDeReposicionLN As New PedidoDeReposicionLN
	Private fecha1 As Date? = Nothing
	Private fecha2 As Date? = Nothing



	Private Sub FrmGestionPedidoDeReposicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Cargar()
	End Sub

	Public Sub Buscar()
		If rbtFechaExacta.Checked Then
			fecha1 = dtpFechaDesde.Value
			fecha2 = Nothing
		ElseIf rbtEntreFechas.Checked Then
			fecha1 = dtpFechaDesde.Value
			fecha2 = dtpFechaHasta.Value
		Else
			fecha1 = Nothing
			fecha2 = Nothing
		End If
		dgvProveedores.DataSource = PedidoDeReposicionLN.CargarPedidos(fecha1, fecha2).Tables(0)
		dgvProveedores.Columns("id").Visible = False
		dgvProveedores.Columns("Total").DefaultCellStyle.Format = "c2"
		dgvProveedores.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
		dgvProveedores.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
		dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
	End Sub

	Public Sub Cargar()
		Buscar()
		btnEliminar.Enabled = False
	End Sub

	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvProveedores.CellMouseDoubleClick
		Dim selectedRow As DataGridViewRow = Nothing
		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			selectedRow = dgvProveedores.Rows(e.RowIndex)

		End If

	End Sub
	Private Sub RbtEntreFechas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEntreFechas.CheckedChanged, rbtFechaExacta.CheckedChanged

		If rbtFechaExacta.Checked Then
			lblFechaExacta.Visible = True
			lbldesde.Visible = False
			rbtEntreFechas.Checked = False
			lblHasta.Visible = False
			dtpFechaHasta.Visible = False
			dtpFechaDesde.Visible = True
		ElseIf rbtEntreFechas.Checked Then
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

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		FrmPedidoDeReposicion.ShowDialog()
	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Close()
	End Sub
End Class