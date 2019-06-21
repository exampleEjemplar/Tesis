﻿Imports System.Windows.Forms
Imports ClaseLn
Public Class FrmGestionCategorías

	Private categoriasLN As New CategoriasLN

	Private Sub FrmGestionCategorías_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		GroupBox1.Visible = False
		CargarGrillaCategorías()
		btnGuardar.Enabled = False
	End Sub
	Public Sub CargarGrillaCategorías()
		Dim ds As DataSet = categoriasLN.CargarGrillaCategorías()
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
		Dim ds As DataSet = categoriasLN.ConsultaModificacion(selectedRow.Cells("id").Value)
		For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

		Next

	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		GroupBox1.Visible = True
		btnGuardar.Enabled = True
	End Sub

	Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
		If String.IsNullOrWhiteSpace(txtNombre.Text) Then
			MsgBox("Ingrese el nombre de la categoria", MsgBoxStyle.Critical, "Categoria")
			Return
		End If

		categoriasLN.GuardarNuevo(txtNombre.Text, txtDescripcion.Text)

	End Sub
End Class