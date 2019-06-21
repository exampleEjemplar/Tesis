Imports System.Windows.Forms
Imports ClaseLn
Public Class FrmGestionTipoDeProducto

	Private tipoDeProductosLN As New TipoDeProductosLN

	Private Sub FrmGestionCategorías_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		GroupBox1.Visible = False
		CargarGrillaCategorías()
		btnGuardar.Enabled = False
	End Sub
	Public Sub CargarGrillaCategorías()
		Dim ds As DataSet = tipoDeProductosLN.CargarGrillaTipoDeProductos()
		dgvCategorias.DataSource = ds.Tables(0)
		dgvCategorias.Columns("Id").Visible = False
		dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
		dgvCategorias.AutoResizeColumns()
	End Sub
	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvCategorias.CellMouseDoubleClick
		Dim selectedRow As DataGridViewRow
		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			selectedRow = dgvCategorias.Rows(e.RowIndex)
		End If
		Dim ds As DataSet = tipoDeProductosLN.ConsultaModificacion(selectedRow.Cells("id").Value)
		For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

		Next

	End Sub

End Class