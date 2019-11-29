Imports System.Drawing
Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe

Public Class FrmPedidoDeReposicion

	Private helpersLN As New HelpersLN
	Private productoLn As New ProductoLN
	Public idVenta As Integer
	Public filaSeleccionada As Integer
	Public primerOrder As Boolean = True
	Public agrupado As List(Of IGrouping(Of String, ProductosConStock))

	Private Sub FrmPedidoDeReposicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LlenarCboBase()
		DgvProveedoresSet()
	End Sub

	Public Sub LlenarCboBase()
		cboBaseCalculo.DataSource = {"Stock Máximo", "Stock Mínimo", "Promedio"}
		cboBaseCalculo.SelectedItem = "Stock Máximo"
	End Sub

	Public Sub DgvProveedoresSet()
		Dim ds = productoLn.CargarGrillaStock(New Dictionary(Of String, String), New List(Of Tuple(Of Integer, String, Integer)), "asc").Tables(0)
		If ds.Rows.Count = 0 Then
			MsgBox("No hay productos para revisar", MsgBoxStyle.OkOnly, "Stock")
		End If

		dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		Dim listaDeProductos = New List(Of ProductosConStock)


		For i = 0 To ds.Rows.Count - 1
			listaDeProductos.Add(New ProductosConStock With {
			  .Id = ds.Rows(i)(0).ToString(),
			  .Nombre = ds.Rows(i)(1).ToString(),
			  .ProveedorId = ds.Rows(i)(6).ToString(),
			  .ProveedorNombre = ds.Rows(i)(5).ToString(),
			  .StockActual = ds.Rows(i)(2),
			  .StockMaximo = ds.Rows(i)(3),
			  .StockMinimo = ds.Rows(i)(4)
		  })
		Next


		Dim listaDeNombres = New List(Of ProductosConStock)
		Dim agrupadosPorProveedorNombre = listaDeProductos.GroupBy(Function(x) x.ProveedorNombre).ToList()
		For index = 0 To agrupadosPorProveedorNombre.Count - 1
			listaDeNombres.Add(New ProductosConStock With {.ProveedorNombre = agrupadosPorProveedorNombre(index).Key})
		Next

		dgvProveedores.DataSource = listaDeNombres

		agrupado = agrupadosPorProveedorNombre

		dgvProveedores.Columns("id").Visible = False
		dgvProveedores.Columns("Nombre").Visible = False
		dgvProveedores.Columns("ProveedorId").Visible = False
		dgvProveedores.Columns("StockMinimo").Visible = False
		dgvProveedores.Columns("StockMaximo").Visible = False
		dgvProveedores.Columns("StockActual").Visible = False
		dgvProveedores.Columns("ProveedorNombre").HeaderText = "Proveedor"
		dgvProveedores.Columns("AComprar").Visible = False
		dgvProveedores.Columns("ProveedorNombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

		Dim CheckBoxColumn As New DataGridViewCheckBoxColumn()
		dgvProveedores.Columns.Add(CheckBoxColumn)
		CheckBoxColumn.HeaderText = "Generar"
		CheckBoxColumn.Width = 50
		For index = 0 To listaDeNombres.Count - 1
			Dim cell = dgvProveedores.Rows(index).Cells(8)
			cell.Value = True
		Next
		dgvProveedores.AllowUserToAddRows = False

	End Sub

	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellContentClick
		Dim cell As DataGridViewCheckBoxCell = dgvProveedores.Rows(e.RowIndex).Cells(8)
		If cell.Value = True Then
			cell.Value = False
		Else
			cell.Value = True
		End If
	End Sub

	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvProveedores.CellMouseDoubleClick
		Dim selectedRow As DataGridViewRow = Nothing
		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			selectedRow = dgvProveedores.Rows(e.RowIndex)
		End If
		Dim providerNombre = selectedRow.Cells("ProveedorNombre").Value
		FrmDetallePedidoDeReposicion.agrupado = agrupado.FirstOrDefault(Function(x) x.Key = providerNombre)
		FrmDetallePedidoDeReposicion.base = cboBaseCalculo.SelectedItem
		FrmDetallePedidoDeReposicion.ShowDialog()
		Dim asdasd = ""
	End Sub

End Class

Public Class ProductosConStock
	Private _Id As String

	Public Property Id As String
		Get
			Return _Id
		End Get
		Set(ByVal value As String)
			_Id = value
		End Set
	End Property
	Private _Nombre As String

	Public Property Nombre As String
		Get
			Return _Nombre
		End Get
		Set(ByVal value As String)
			_Nombre = value
		End Set
	End Property
	Private _ProveedorId As String

	Public Property ProveedorId As String
		Get
			Return _ProveedorId
		End Get
		Set(ByVal value As String)
			_ProveedorId = value
		End Set
	End Property
	Private _ProveedorNombre As String

	Public Property ProveedorNombre As String
		Get
			Return _ProveedorNombre
		End Get
		Set(ByVal value As String)
			_ProveedorNombre = value
		End Set
	End Property
	Private _StockMinimo As Integer

	Public Property StockMinimo As Integer
		Get
			Return _StockMinimo
		End Get
		Set(ByVal value As Integer)
			_StockMinimo = CStr(value)
		End Set
	End Property
	Private _StockMaximo As Integer

	Public Property StockMaximo As Integer
		Get
			Return _StockMaximo
		End Get
		Set(ByVal value As Integer)
			_StockMaximo = CStr(value)
		End Set
	End Property
	Private _StockActual As Integer

	Public Property StockActual As Integer
		Get
			Return _StockActual
		End Get
		Set(ByVal value As Integer)
			_StockActual = CStr(value)
		End Set
	End Property

	Private _AComprar As Integer

	Public Property AComprar As Integer
		Get
			Return _AComprar
		End Get
		Set(ByVal value As Integer)
			_AComprar = CStr(value)
		End Set
	End Property
End Class

