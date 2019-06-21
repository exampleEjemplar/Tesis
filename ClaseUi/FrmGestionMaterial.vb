Imports System.Windows.Forms
Imports ClaseLn
Public Class FrmGestionMaterial

	Private materialesLN As New MaterialesLN
	Private modificando As Boolean = False
	Public materialId As Integer

	Private Sub FrmGestionCategorías_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		GroupBox1.Visible = False
		CargarGrillaCategorías()
		btnGuardar.Enabled = False
	End Sub
	Public Sub CargarGrillaCategorías()
		Dim ds As DataSet = materialesLN.CargarGrillaMateriales()
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
		Dim ds As DataSet = materialesLN.ConsultaModificacion(selectedRow.Cells("id").Value)
		For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
			txtNombre.Text = ds.Tables(0).Rows(i)(0).ToString()
			txtCoti.Text = ds.Tables(0).Rows(i)(1).ToString()
			dtpfecha.Value = ds.Tables(0).Rows(i)(2).ToString()
			dtpfecha.Enabled = False
			materialId = ds.Tables(0).Rows(i)(3).ToString()
			modificando = True
		Next

	End Sub

	Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

		If String.IsNullOrWhiteSpace(txtNombre.Text) Then
			MsgBox("Ingrese el nombre del material", MsgBoxStyle.Critical, "Material")
			Return
		End If

		If String.IsNullOrWhiteSpace(txtCoti.Text) Then
			MsgBox("Ingrese la cotizacion del material", MsgBoxStyle.Critical, "Material")
			Return
		End If

		Dim value As Integer
		If Not Double.TryParse(txtCoti.Text, value) Then
			Return
		End If

		If modificando Then
			materialesLN.NuevaCotizacion(materialId, Math.Round(value, 2))
		Else
			materialesLN.GuardarNuevo(txtNombre.Text, Math.Round(value, 2))
		End If

		modificando = False

	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCotizacionesHist.Click
		FrmConsultaCotizaciones.Show()
	End Sub

	Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		GroupBox1.Visible = True
		lblFecha.Visible = False
		dtpfecha.Visible = False
	End Sub
End Class