Imports System.Windows.Forms
Imports ClaseLn
Public Class FrmGestionTipoDeProducto

	Private tipoDeProductoLN As New TipoDeProductosLN
	Private modificando As Boolean = False
	Public tipoDeProductoId As Integer

	Private Sub FrmGestionCategorías_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		GroupBox1.Visible = False
		CargarGrilla()
		btnGuardar.Enabled = False
	End Sub
	Public Sub CargarGrilla()
		Dim ds As DataSet = tipoDeProductoLN.CargarGrilla()
		dgvCategorias.DataSource = ds.Tables(0)
		dgvCategorias.Columns("Id").Visible = False
		dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
		dgvCategorias.AutoResizeColumns()
	End Sub
	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvCategorias.CellMouseDoubleClick
		Try
			Dim selectedRow As DataGridViewRow
			If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
				selectedRow = dgvCategorias.Rows(e.RowIndex)
			End If
			Dim ds As DataSet = tipoDeProductoLN.ConsultaModificacion(selectedRow.Cells("id").Value)
			For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
				tipoDeProductoId = ds.Tables(0).Rows(i)(0).ToString()
				txtNombre.Text = ds.Tables(0).Rows(i)(1).ToString()
				txtDescripcion.Text = ds.Tables(0).Rows(i)(2).ToString()
				modificando = True
			Next
			GroupBox1.Visible = True
			btnGuardar.Enabled = True
			btnNuevo.Enabled = False
		Catch ex As Exception
			MsgBox("Disculpe las molestias, intente nuevamente", MsgBoxStyle.Critical, "Tipo de producto")
		End Try
	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		GroupBox1.Visible = True
		btnGuardar.Enabled = True
	End Sub

	Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

		If String.IsNullOrWhiteSpace(txtNombre.Text) Then
			MsgBox("Ingrese el nombre del tipo de producto", MsgBoxStyle.Critical, "Tipo de producto")
			Return
		End If

		If modificando Then
			tipoDeProductoLN.Modificar(txtNombre.Text, txtDescripcion.Text, tipoDeProductoId)
			MsgBox("Registro actualizado con exito", MsgBoxStyle.OkOnly, "Tipo de producto")
		Else
			tipoDeProductoLN.GuardarNuevo(txtNombre.Text, txtDescripcion.Text)
			MsgBox("Registro agregado con exito", MsgBoxStyle.OkOnly, "Tipo de producto")
		End If
		CargarGrilla()
		txtNombre.Text = ""
		txtDescripcion.Text = ""
		modificando = False
		tipoDeProductoId = 0
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

		With FrmGestionProducto
		End With
		FrmGestionProducto.Show()
		Me.Close()
	End Sub
End Class