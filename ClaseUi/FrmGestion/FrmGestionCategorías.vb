Imports System.Windows.Forms
Imports ClaseLn
Public Class FrmGestionCategorías

	Private categoriasLN As New CategoriasLN
	Private helpersUI As New HelpersUI
	Private modificando As Boolean = False
	Public modificado As Boolean
	Public categoriaId As Integer

	Private Sub FrmGestionCategorías_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		GroupBox1.Visible = False
		CargarGrillaCategorías()
		btnGuardar.Enabled = False
		modificado = False
	End Sub
	Public Sub CargarGrillaCategorías()
		Dim ds As DataSet = categoriasLN.CargarGrillaCategorías()
		dgvCategorias.DataSource = ds.Tables(0)
		dgvCategorias.Columns("Id").Visible = False
        dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) 
		Dim selectedRow As DataGridViewRow
		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			selectedRow = dgvCategorias.Rows(e.RowIndex)
		End If
		Dim ds As DataSet = categoriasLN.ConsultaModificacion(selectedRow.Cells("id").Value)
		For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
			categoriaId = ds.Tables(0).Rows(i)(0).ToString()
			txtNombre.Text = ds.Tables(0).Rows(i)(1).ToString()
			txtDescripcion.Text = ds.Tables(0).Rows(i)(2).ToString()
			modificando = True
		Next
		GroupBox1.Visible = True
		btnGuardar.Enabled = True
		btnNuevo.Enabled = False
	End Sub

	Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		GroupBox1.Visible = True
		btnGuardar.Enabled = True
	End Sub

	Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click


		If String.IsNullOrWhiteSpace(txtNombre.Text) Then
			MsgBox("Ingrese el nombre de la categoria", MsgBoxStyle.Critical, "Categoria")
			Return
		End If

		Dim nombre = helpersUI.NormalizarTexto(txtNombre.Text)
		Dim descripcion = helpersUI.NormalizarTexto(txtDescripcion.Text)

		If modificando Then
			categoriasLN.Modificar(nombre, descripcion, categoriaId)
			MsgBox("Registro actualizado con exito", MsgBoxStyle.OkOnly, "Categoria")
		Else
			categoriasLN.GuardarNuevo(nombre, descripcion)
			MsgBox("Registro agregado con exito", MsgBoxStyle.OkOnly, "Categoria")
		End If
		CargarGrillaCategorías()
		txtNombre.Text = ""
		txtDescripcion.Text = ""
		modificando = False
		categoriaId = 0
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

		With FrmGestionProducto
		End With
		FrmGestionProducto.ShowDialog()
		modificado = True
		Me.Close()
	End Sub

	Private Sub FrmGestionCategorías_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		modificado = True
	End Sub

    Private Sub dgvCategorias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCategorias.CellContentClick

    End Sub
End Class