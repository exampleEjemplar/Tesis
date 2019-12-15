Imports System.Windows.Forms

Public Class FrmDetallePedidoDeReposicion
	Public agrupado As IGrouping(Of String, ProductosConStock)
	Public base As String
	Public index As Integer

	Private Sub FrmDetallePedidoDeReposicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		txtBusNombreProducto.Text = ""
		GroupBox1.Visible = False
		Dim listaDeProductos = agrupado.ToList()
		dgvProductos.DataSource = listaDeProductos
		dgvProductos.Columns("id").Visible = False
		dgvProductos.Columns("ProveedorId").Visible = False

		dgvProductos.Columns("Nombre").HeaderText = "Producto"
		dgvProductos.Columns("StockMinimo").HeaderText = "Stock Mínimo"
		dgvProductos.Columns("StockMaximo").HeaderText = "Stock Máximo"
		dgvProductos.Columns("StockActual").HeaderText = "Stock Actual"
		dgvProductos.Columns("ProveedorNombre").HeaderText = "Proveedor"
		dgvProductos.Columns("AComprar").HeaderText = "A Comprar"
		dgvProductos.Columns("HacerPedido").HeaderText = "Pedir este producto"
		dgvProductos.Columns("PrecioProducto").HeaderText = "Precio del producto"
		dgvProductos.Columns("PrecioProducto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
		dgvProductos.Columns("PrecioProducto").DefaultCellStyle.Format = "c2"
		lblBase.Text = base
	End Sub

	Public Function CalcularSegunBase(stockMin As Integer, stockMax As Integer, stockActual As Integer) As Integer
		Dim operacion As Integer = 0
		Select Case base
			Case "Stock Máximo"
				operacion = stockMax - stockActual
			Case "Stock Mínimo"
				operacion = stockMin - stockActual
			Case "Promedio"
				operacion = ((stockMax + stockMin) / 2) - stockActual
			Case Else
				operacion = 0
		End Select
		Return If(operacion >= 0, operacion, 0)
	End Function

	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvProductos.CellMouseDoubleClick
		Try
			Dim selectedRow As DataGridViewRow = Nothing
			If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
				selectedRow = dgvProductos.Rows(e.RowIndex)
			End If
			lblProveedor.Text = selectedRow.Cells("ProveedorNombre").Value
			lblProducto.Text = selectedRow.Cells("Nombre").Value
			lblAComprar.Text = selectedRow.Cells("AComprar").Value
			lblMaximo.Text = selectedRow.Cells("StockMaximo").Value
			lblStockMinimo.Text = selectedRow.Cells("StockMinimo").Value
			txtForzado.Text = selectedRow.Cells("AComprar").Value
			index = selectedRow.Cells("id").RowIndex
			GroupBox1.Visible = True
			btnGuardarProveedor.Enabled = False
			btnCancelarProveedor.Enabled = False
		Catch
		End Try
	End Sub

	Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
		GroupBox1.Visible = False
		btnGuardarProveedor.Enabled = True
		btnCancelarProveedor.Enabled = True
	End Sub

	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick
		Try
			Dim cell As DataGridViewCheckBoxCell = Nothing
			If dgvProductos.Columns(0).HeaderText = "Pedir este producto" Then
				cell = dgvProductos.Rows(e.RowIndex).Cells(0)
			Else
				cell = dgvProductos.Rows(e.RowIndex).Cells(8)
			End If
			If cell.Value = True Then
				cell.Value = False
			Else
				cell.Value = True
			End If
		Catch
		End Try
	End Sub

	Private Sub btnguardarmodificacion_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
		If Not String.IsNullOrEmpty(txtForzado.Text) Then
			Dim value As Integer
			If Not Integer.TryParse(txtForzado.Text, value) Then
				MsgBox("La cantidad a comprar debe ser un número", MsgBoxStyle.Critical, "Producto")
				Return
			End If
			If value = 0 Then
				MsgBox("La cantidad a comprar debe ser un número distinto a 0", MsgBoxStyle.Critical, "Producto")
				Return
			End If
		Else
			MsgBox("Debe agregar una cantidad a comprar", MsgBoxStyle.Critical, "Producto")
			Return
		End If
		dgvProductos.Rows(index).Cells("AComprar").Value = txtForzado.Text
		GroupBox1.Visible = False
		btnGuardarProveedor.Enabled = True
		btnCancelarProveedor.Enabled = True
	End Sub
	Private Sub btnCancelarProveedor_Click(sender As Object, e As EventArgs) Handles btnCancelarProveedor.Click
		Dispose()
		Close()
	End Sub

	Private Sub btnGuardarProveedor_Click(sender As Object, e As EventArgs) Handles btnGuardarProveedor.Click
		Dim agrupadoProveedorFrmPedido = FrmPedidoDeReposicion.agrupado.FirstOrDefault(Function(x) x.Key = agrupado.Key)
		For i = 0 To agrupadoProveedorFrmPedido.Count - 1
			Dim proveedorFrmPedido = agrupadoProveedorFrmPedido(i)
			proveedorFrmPedido.AComprar = dgvProductos.Rows(i).Cells("AComprar").Value
			proveedorFrmPedido.HacerPedido = dgvProductos.Rows(i).Cells("HacerPedido").Value
		Next
		FrmPedidoDeReposicion.recargar = True
		Close()
	End Sub





	Private Const CP_NOCLOSE_BUTTON As Integer = &H200
	Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
		Get
			Dim myCp As CreateParams = MyBase.CreateParams
			myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
			Return myCp
		End Get
	End Property

	Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
		Buscar()
	End Sub

	Public Sub Limpiar()
		For i = 0 To agrupado.Count - 1
			dgvProductos.Rows(i).Visible = True
		Next
	End Sub

	Public Sub Buscar()
		If Not String.IsNullOrWhiteSpace(txtBusNombreProducto.Text) Then
			For i = 0 To agrupado.Count - 1
				dgvProductos.CurrentCell = Nothing
				If Not agrupado(i).Nombre.ToLower().Contains(txtBusNombreProducto.Text.ToLower()) Then
					dgvProductos.Rows(i).Visible = False
				Else
					dgvProductos.Rows(i).Visible = True
				End If
			Next
		Else
			MsgBox("El texto de búsqueda está vacío", MsgBoxStyle.Critical, "Stock")
		End If
	End Sub

	Private Sub btnLimpiarFiltros_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltros.Click
		Limpiar()
		txtBusNombreProducto.Text = ""
	End Sub
End Class