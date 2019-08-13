Imports System.Globalization
Imports System.Windows.Forms
Imports ClaseLn

Public Class FrmGestionStock

	Private productosLN As New ProductoLN
	Public productoId As String

	Public Sub CargarGrilla()

		dgvGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

		Dim ds As DataSet = productosLN.CargarGrillaStock()

		dgvGrilla.DataSource = ds.Tables(0)
		dgvGrilla.Columns("Id").Visible = False

		'Dim examples As List(Of Example) = New List(Of Example)
		'For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

		'	If examples.Where(Function(s) s.Id = ds.Tables(0).Rows(i)(0).ToString()).FirstOrDefault() IsNot Nothing Then

		'		For Each example As Example In examples
		'			If example.Id = ds.Tables(0).Rows(i)(0).ToString() And Date.ParseExact(example.Fecha, "dd/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture) < Date.ParseExact(ds.Tables(0).Rows(i)(3).ToString(), "dd/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture) Then
		'				examples.Add(New Example With {
		'				  .Id = ds.Tables(0).Rows(i)(0).ToString(),
		'				  .Material = ds.Tables(0).Rows(i)(1).ToString(),
		'				  .Cotizacion = ds.Tables(0).Rows(i)(2).ToString(),
		'				  .Fecha = ds.Tables(0).Rows(i)(3).ToString()
		'				  })
		'				examples.Remove(example)
		'				Exit For
		'			End If
		'		Next
		'	Else
		'		examples.Add(New Example With {
		'				  .Id = ds.Tables(0).Rows(i)(0).ToString(),
		'				  .Material = ds.Tables(0).Rows(i)(1).ToString(),
		'				  .Cotizacion = ds.Tables(0).Rows(i)(2).ToString(),
		'				  .Fecha = ds.Tables(0).Rows(i)(3).ToString()
		'				  })
		'	End If

		'Next
		'dgvGrilla.Columns("Material").DisplayIndex = 0
		'dgvGrilla.Columns("Cotizacion").DisplayIndex = 1
		'dgvGrilla.Columns("Fecha").DisplayIndex = 2


	End Sub

	Private Sub FrmGestionStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		CargarGrilla()
	End Sub

	Private Sub btnSalirr_Click(sender As Object, e As EventArgs) Handles btnSalirr.Click
		Close()
	End Sub

	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvGrilla.CellMouseDoubleClick
		Dim selectedRow As DataGridViewRow
		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			selectedRow = dgvGrilla.Rows(e.RowIndex)
		End If
		productoId = selectedRow.Cells("id").Value
		FrmConsultaMovimientoStock.ShowDialog()
	End Sub
End Class