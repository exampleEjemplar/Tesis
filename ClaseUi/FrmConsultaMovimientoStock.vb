Imports System.Windows.Forms
Imports ClaseLn
Public Class FrmConsultaMovimientoStock

    Dim productosLN As New ProductoLN

    Private Sub FrmConsultaCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As DataSet = productosLN.CargarTodosMovimientos(FrmGestionStock.productoId)

        Dim examples As List(Of Stock) = New List(Of Stock)

        Dim parcial = 0
        Dim ordenado = ds.Tables(0).AsEnumerable.OrderByDescending(Function(x) x(3))
        Dim listaParcial = New List(Of Integer)
        For index = 0 To ordenado.Count - 1
            listaParcial.Add(ordenado(index)(1))
        Next

        Dim listafinal = New List(Of Integer)
        Dim total = ordenado.Sum(Function(x) x(1))
        For index = 0 To listaParcial.Count - 1
            Dim resultado = 0
            If index = 0 Then
                listafinal.Add(total)
                Continue For
            End If
            If listaParcial(index - 1) > 0 Then
                resultado = total - listaParcial(index - 1)
            Else
                resultado = total + (listaParcial(index - 1) * -1)
            End If
            listafinal.Add(resultado)
            total = resultado
        Next


        For i As Integer = 0 To ordenado.Count - 1
            parcial = listafinal(i)
            examples.Add(New Stock With {
            .Id = ordenado(i)(0).ToString(),
            .Movimiento = ordenado(i)(1).ToString(),
            .Producto = ordenado(i)(2).ToString(),
            .Fecha = ordenado(i)(3).ToString(),
            .Proveedor = ordenado(i)(4).ToString(),
            .MovimientoParcial = parcial
                              })
        Next


        dgvCotizaciones.DataSource = examples
        dgvCotizaciones.Columns("Id").Visible = False
        dgvCotizaciones.Columns("Proveedor").Visible = False
        dgvCotizaciones.Columns("Fecha").DefaultCellStyle.Format = "dd-MM-yyyy HH:mm:ss"
        dgvCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCotizaciones.AutoResizeColumns()
        txtProducto.Text = ds.Tables(0).Rows(0)(2).ToString()
        txtProveedor.Text = ds.Tables(0).Rows(0)(4).ToString()
        txtCantidadMov.Text = ds.Tables(0).Rows.Count.ToString()
        txtStockActual.Text = listaParcial.Sum(Function(x) x)
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