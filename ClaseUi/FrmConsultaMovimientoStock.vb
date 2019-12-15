Imports System.Windows.Forms
Imports ClaseLn
Public Class FrmConsultaMovimientoStock

	Dim productosLN As New ProductoLN

	Private Sub FrmConsultaCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim ds As DataSet = productosLN.CargarTodosMovimientos(FrmGestionStock.productoId)

		Dim examples As List(Of Stock) = New List(Of Stock)

		Dim parcial = 0

		For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
			If i = 0 Then
				parcial = Convert.ToInt16(ds.Tables(0).Rows(i)(1))
			Else
				parcial += ds.Tables(0).Rows(i)(1)
			End If
			examples.Add(New Stock With {
			.Id = ds.Tables(0).Rows(i)(0).ToString(),
			.Movimiento = ds.Tables(0).Rows(i)(1).ToString(),
			.Producto = ds.Tables(0).Rows(i)(2).ToString(),
			.Fecha = ds.Tables(0).Rows(i)(3).ToString(),
			.Proveedor = ds.Tables(0).Rows(i)(4).ToString(),
			.MovimientoParcial = parcial
							  })
		Next


		dgvCotizaciones.DataSource = examples
		dgvCotizaciones.Columns("Id").Visible = False
        dgvCotizaciones.Columns("Proveedor").Visible = False
        dgvCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCotizaciones.AutoResizeColumns()
        txtProducto.Text = ds.Tables(0).Rows(0)(2).ToString()
		txtProveedor.Text = ds.Tables(0).Rows(0)(4).ToString()
		txtCantidadMov.Text = ds.Tables(0).Rows.Count.ToString()
		txtStockActual.Text = parcial
		txtProducto.ReadOnly = False
		txtProveedor.ReadOnly = False
		txtCantidadMov.ReadOnly = False
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Close()
	End Sub
End Class

Public Class Stock
	Private _Id As String

	Public Property Id As String
		Get
			Return _Id
		End Get
		Set(ByVal value As String)
			_Id = CStr(value)
		End Set
	End Property
	Private _Movimiento As String

	Public Property Movimiento As String
		Get
			Return _Movimiento
		End Get
		Set(ByVal value As String)
			_Movimiento = CStr(value)
		End Set
	End Property
	Private _Fecha As String

	Public Property Fecha As String
		Get
			Return _Fecha
		End Get
		Set(ByVal value As String)
			_Fecha = CStr(value)
		End Set
	End Property
	Private _Producto As String

	Public Property Producto As String
		Get
			Return _Producto
		End Get
		Set(ByVal value As String)
			_Producto = CStr(value)
		End Set
	End Property
	Private _Proveedor As String

	Public Property Proveedor As String
		Get
			Return _Proveedor
		End Get
		Set(ByVal value As String)
			_Proveedor = CStr(value)
		End Set
	End Property
	Private _MovimientoParcial As String

	Public Property MovimientoParcial As String
		Get
			Return _MovimientoParcial
		End Get
		Set(ByVal value As String)
			_MovimientoParcial = CStr(value)
		End Set
	End Property

End Class