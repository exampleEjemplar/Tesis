Imports System.Windows.Forms
Imports ClaseLn
Public Class FrmConsultaMovimientoStock

	Dim productosLN As New ProductoLN

	Private Sub FrmConsultaCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim ds As DataSet = productosLN.CargarTodosMovimientos(FrmGestionStock.productoId)
		dgvCotizaciones.DataSource = ds.Tables(0)
		dgvCotizaciones.Columns("Id").Visible = False
		dgvCotizaciones.Columns("Proveedor").Visible = False
		dgvCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
		dgvCotizaciones.AutoResizeColumns()
		txtProducto.Text = ds.Tables(0).Rows(0)(2).ToString()
		txtProveedor.Text = ds.Tables(0).Rows(0)(4).ToString()
		txtCantidadMov.Text = ds.Tables(0).Rows.Count.ToString()
		'txtStockActual.Text = ds.Tables(0).Rows.Sum(Function(item) item.Cost)

		'For i As Integer = 0 To ds.Tables(0).Rows.Count
		'	Dim cantidad ds.Tables(0).Rows(i)(1)
		'Next

		txtProducto.Enabled = False
		txtProveedor.Enabled = False
		txtCantidadMov.Enabled = False
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

		With FrmGestionStock
		End With
		FrmGestionStock.Show()
		Close()

	End Sub
End Class