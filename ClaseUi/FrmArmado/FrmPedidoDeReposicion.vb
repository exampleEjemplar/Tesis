﻿Imports System.Drawing
Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe

Public Class FrmPedidoDeReposicion

	Private helpersLN As New HelpersLN
	Private Helpersui As New HelpersUI
	Private productoLn As New ProductoLN
	Private comprasLN As New ComprasLN
	Private pedidoDeReposicionLN As New PedidoDeReposicionLN
	Public idVenta As Integer
	Public filaSeleccionada As Integer
	Public primerOrder As Boolean = True
	Public recargar As Boolean = False
	Public agrupado As List(Of IGrouping(Of String, ProductosConStock))
	Dim listaDeNombres = New List(Of ProductosConStock)

	Private Sub FrmPedidoDeReposicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LlenarCboBase()
		DgvProveedoresSet(True)
	End Sub

	Private Sub asdsaasdasdasdasdActivated(sender As Object, e As EventArgs) Handles MyBase.Activated
		If recargar Then
			CalcularTotales()
			recargar = False
		End If
	End Sub

	Public Sub LlenarCboBase()
		cboBaseCalculo.DataSource = {"Stock Máximo", "Stock Mínimo", "Promedio"}
		cboBaseCalculo.SelectedItem = "Stock Máximo"
	End Sub

	Public Sub DgvProveedoresSet(agregoColumnas As Boolean)
		Dim ds = productoLn.CargarGrillaStock(New Dictionary(Of String, String), New List(Of Tuple(Of Integer, String, Integer)), "asc").Tables(0)
		If ds.Rows.Count = 0 Then
			btnNuevo.Enabled = False
			btnRegenerar.Enabled = False
			cboBaseCalculo.Enabled = False

			MsgBox("No hay productos para revisar", MsgBoxStyle.OkOnly, "Stock")
		End If

		dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		Dim listaDeProductos = New List(Of ProductosConStock)
		listaDeNombres = New List(Of ProductosConStock)

		For i = 0 To ds.Rows.Count - 1
			listaDeProductos.Add(New ProductosConStock With {
			  .Id = ds.Rows(i)(0).ToString(),
			  .Nombre = ds.Rows(i)(1).ToString(),
			  .ProveedorId = ds.Rows(i)(6).ToString(),
			  .ProveedorNombre = ds.Rows(i)(5).ToString(),
			  .StockActual = If(IsDBNull(ds.Rows(i)(2)), 0, ds.Rows(i)(2)),
			  .StockMaximo = ds.Rows(i)(3),
			  .StockMinimo = ds.Rows(i)(4),
			  .HacerPedido = True,
			  .AComprar = CalcularSegunBase(ds.Rows(i)(4), ds.Rows(i)(3), If(IsDBNull(ds.Rows(i)(2)), 0, ds.Rows(i)(2))),
			  .PrecioProducto = ds.Rows(i)(7)
		  })
		Next


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
		dgvProveedores.Columns("PrecioProducto").Visible = False
		dgvProveedores.Columns("ProveedorNombre").HeaderText = "Proveedor"
		dgvProveedores.Columns("AComprar").Visible = False
		dgvProveedores.Columns("HacerPedido").Visible = False
		dgvProveedores.Columns("ProveedorNombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

		If agregoColumnas Then
			AñadirColumnas()
		End If

		dgvProveedores.AllowUserToAddRows = False
		CalcularTotales()
		'For index = 0 To listaDeNombres.Count - 1
		For i = 0 To agrupado.Count - 1
			Dim cell8 = dgvProveedores.Rows(i).Cells(10)
			cell8.Value = True

			Dim cell11 = dgvProveedores.Rows(i).Cells(11)
			cell11.Value = agrupado(i).Where(Function(x) x.HacerPedido = True).Sum(Function(x) x.PrecioProducto * x.AComprar).ToString("C2")
			For Each productosProveedor As ProductosConStock In agrupado(i)
				productosProveedor.HacerPedido = True
			Next
		Next
		'Next

		For Each column As DataGridViewColumn In dgvProveedores.Columns
			column.SortMode = DataGridViewColumnSortMode.NotSortable
		Next
	End Sub

	Public Sub AñadirColumnas()
		Dim CheckBoxColumn As New DataGridViewCheckBoxColumn()
		dgvProveedores.Columns.Add(CheckBoxColumn)
		Dim totalColumn As New DataGridViewTextBoxColumn()
		dgvProveedores.Columns.Add(totalColumn)
		CheckBoxColumn.Name = "ChkBox"
		totalColumn.Name = "TotalProveedor"
		CheckBoxColumn.HeaderText = "Generar"
		CheckBoxColumn.Width = 50
		totalColumn.HeaderText = "Total Proveedor"
		totalColumn.Width = 150
	End Sub

	Public Sub CalcularTotales()
		Dim Total As Decimal = 0
		For index = 0 To listaDeNombres.Count - 1
			For i = 0 To agrupado.Count - 1
				If agrupado(i).Key = dgvProveedores.Rows(index).Cells(3).Value Then
					Dim cell11 = dgvProveedores.Rows(index).Cells(11)
					Dim totalProveedor = agrupado(i).Where(Function(x) x.HacerPedido = True).Sum(Function(x) x.PrecioProducto * x.AComprar)
					cell11.Value = totalProveedor.ToString("C2")
					Total += totalProveedor
				End If
			Next
		Next
		lblTotal.Text = Total.ToString("C2")
	End Sub

	Public Function CalcularSegunBase(stockMin As Integer, stockMax As Integer, stockActual As Integer) As Integer
		Dim operacion As Integer = 0
		Select Case cboBaseCalculo.SelectedItem
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

	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellContentClick
		Dim selectedRow As DataGridViewRow = Nothing
		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			selectedRow = dgvProveedores.Rows(e.RowIndex)
			Dim cell As DataGridViewCheckBoxCell = Nothing
			cell = dgvProveedores.Rows(e.RowIndex).Cells(10)
			If cell.Value = True Then
				cell.Value = False
			Else
				cell.Value = True
			End If
			For i = 0 To agrupado.Count - 1
				If agrupado(i).Key = dgvProveedores.Rows(e.RowIndex).Cells(3).Value Then
					For Each productosProveedor As ProductosConStock In agrupado(i)
						productosProveedor.HacerPedido = cell.Value
					Next
					Exit For
				End If
			Next
			CalcularTotales()
		End If

	End Sub

	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvProveedores.CellMouseDoubleClick
		Dim selectedRow As DataGridViewRow = Nothing
		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			selectedRow = dgvProveedores.Rows(e.RowIndex)
			Dim providerNombre = selectedRow.Cells("ProveedorNombre").Value
			FrmDetallePedidoDeReposicion.agrupado = agrupado.FirstOrDefault(Function(x) x.Key = providerNombre)
			FrmDetallePedidoDeReposicion.base = cboBaseCalculo.SelectedItem
			FrmDetallePedidoDeReposicion.ShowDialog()
		End If
	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		Dim listaDeListas = New List(Of List(Of TipoDeComprasNE))
		If MsgBox("Está seguro que desea hacer la cotización?, Se cotizará mercadería por un total de " + lblTotal.Text, MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.No Then
			Return
		End If
		Dim compras = 0
		Try
			For i = 0 To agrupado.Count - 1
				Dim listaDeCompras = New List(Of TipoDeComprasNE)
				If agrupado(i).All(Function(x) x.AComprar = 0) Then
					Continue For
				End If
				If agrupado(i).All(Function(x) x.HacerPedido = False) Then
					Continue For
				End If
				For Each productosProveedor As ProductosConStock In agrupado(i).Where(Function(x) x.HacerPedido = True).Where(Function(x) x.AComprar > 0)
					Dim producto = productoLn.CargarUnProducto(productosProveedor.Id, "").Tables(0).Rows(0)
					listaDeCompras.Add(New TipoDeComprasNE With {
					.Cantidad = productosProveedor.AComprar,
					.ProductoId = productosProveedor.Id,
					.Precio = producto(4),
					.ProveedorId = producto(10)
				})
				Next
				'NO BORRAR
				'Dim nroComprobante = ""
				'Dim ultimaCompra = comprasLN.ObtenerUltimaCompra.Tables(0)
				'If ultimaCompra.Rows.Count = 0 Then
				'	nroComprobante = Helpersui.AgregarNumerosComprobante(1)
				'Else
				'	nroComprobante = Helpersui.AgregarNumerosComprobante(ultimaCompra.Rows(0).Item(0) + 1)
				'End If
				'comprasLN.Registrar(listaDeCompras, agrupado(i).FirstOrDefault().ProveedorId, nroComprobante)
				compras += 1
				listaDeListas.Add(listaDeCompras)
			Next
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			MsgBox("Ha ocurrido un error. Por favor intentelo mas tarde", MsgBoxStyle.Critical, "Stock")
			FrmGestionStock.recargar = True
			Dispose()
			Close()
			Return
		End Try
		If compras > 0 Then
			pedidoDeReposicionLN.RegistrarConjuntoPedidoDeReposición(listaDeListas)
			MsgBox("Se ha agregado la cotización del pedido de reposición. Para acceder a este, por favor ingrese en el menú de gestión de pedidos de reposición", MsgBoxStyle.OkOnly, "Stock")
			FrmGestionPedidoDeReposicion.recargar = True
			'MsgBox("Se han realizado " + compras.ToString() + " compra/s. En caso de dudas revisar la gestión de compras!", MsgBoxStyle.OkOnly, "Stock")
			'FrmGestionStock.recargar = True
			Dispose()
			Close()
		Else
			MsgBox("No había ningún producto para comprar. Revise la configuración del pedido de reposición", MsgBoxStyle.OkOnly, "Stock")
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalirrr.Click
		FrmGestionStock.recargar = True
		dgvProveedores.DataSource = Nothing
		FrmGestionStock.CargarGrilla(New Dictionary(Of String, String))
		Dispose()
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

	Private Sub btnRegenerar_Click(sender As Object, e As EventArgs) Handles btnRegenerar.Click
		If MsgBox("Está a punto de recalcular todo el pedido perdiendo su configuración en caso de haberla cambiado. Desea continuar?", MsgBoxStyle.YesNo, "Stock") = MsgBoxResult.Yes Then

			For i = 0 To agrupado.Count - 1
				For Each productosProveedor As ProductosConStock In agrupado(i)
					productosProveedor.HacerPedido = True
					productosProveedor.AComprar = CalcularSegunBase(productosProveedor.StockMinimo, productosProveedor.StockMaximo, productosProveedor.StockActual)
				Next
				Dim cell11 = dgvProveedores.Rows(i).Cells(11)
				cell11.Value = agrupado(i).Where(Function(x) x.HacerPedido = True).Sum(Function(x) x.PrecioProducto * x.AComprar).ToString("C2")
			Next

			CalcularTotales()
		End If
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

	Private _Generar As Boolean

	Public Property HacerPedido As Boolean
		Get
			Return _Generar
		End Get
		Set(ByVal value As Boolean)
			_Generar = CStr(value)
		End Set
	End Property

	Private _PrecioProducto As Decimal

	Public Property PrecioProducto As Decimal
		Get
			Return _PrecioProducto
		End Get
		Set(ByVal value As Decimal)
			_PrecioProducto = CStr(value)
		End Set
	End Property
End Class

