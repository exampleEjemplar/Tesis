Imports System.Globalization
Imports System.Windows.Forms
Imports System.Windows.Forms.CheckedListBox
Imports ClaseLn
Imports ClaseNe

Public Class FrmModificarPrecioProducto
	Private productometodo As New ProductoLN
	Private helpersLN As New HelpersLN
	Private listaDeProductos As New List(Of Tuple(Of Integer, Boolean, ProductosNE))

	Private Sub FrmModificarPrecioProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Cargar()
	End Sub

	Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
		Dim producto = listaDeProductos.Where(Function(s) s.Item1 = e.Index).FirstOrDefault().Item3
		If e.NewValue = CheckState.Unchecked Then
			listaDeProductos.RemoveAll(Function(s) s.Item1 = e.Index)
			listaDeProductos.Add(New Tuple(Of Integer, Boolean, ProductosNE)(e.Index, False, producto))
		Else
			listaDeProductos.RemoveAll(Function(s) s.Item1 = e.Index)
			listaDeProductos.Add(New Tuple(Of Integer, Boolean, ProductosNE)(e.Index, True, producto))
		End If

	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		If Not listaDeProductos.Any(Function(s) s.Item2 = True) Then
			MsgBox("Debe seleccionar un producto", MsgBoxStyle.Critical, "Producto")
			Return
		End If

		If String.IsNullOrEmpty(txtMonto.Text) And String.IsNullOrEmpty(txtPorcentaje.Text) Then
			MsgBox("Debe escribir algun tipo de cambio de precio", MsgBoxStyle.Critical, "Producto")
			Return
		End If
		If Not String.IsNullOrEmpty(txtMonto.Text) And Not String.IsNullOrEmpty(txtPorcentaje.Text) Then
			MsgBox("Debe seleccionar solo un tipo de cambio de precio", MsgBoxStyle.Critical, "Producto")
			Return
		End If

		If Not String.IsNullOrEmpty(txtMonto.Text) Then
			Dim value As Decimal
			Dim newText = txtMonto.Text.Replace(",", ".")
			If Not Decimal.TryParse(newText, value) Then
				MsgBox("Ingrese el precio en un formato correcto (123.00)", MsgBoxStyle.Critical, "Producto")
				Return
			End If
			If value < 0 Then
				MsgBox("El valor de un producto no puede ser negativo", MsgBoxStyle.Critical, "Producto")
				Return
			End If
			value = Decimal.Parse(newText, CultureInfo.InvariantCulture)
			productometodo.ModificarPrecios(listaDeProductos.Where(Function(s) s.Item2 = True), value.ToString(), False)
		End If

		If Not String.IsNullOrEmpty(txtPorcentaje.Text) Then
			Dim value As Decimal
			Dim newText = txtPorcentaje.Text.Replace(",", ".")
			If Not Decimal.TryParse(newText, value) Then
				MsgBox("Ingrese el porcentaje en un formato correcto (95)", MsgBoxStyle.Critical, "Producto")
				Return
			End If
			newText = ((value / 100) + 1).ToString().Replace(",", ".")
			productometodo.ModificarPrecios(listaDeProductos.Where(Function(s) s.Item2 = True), newText, True)
		End If

		MsgBox("Precios modificados", MsgBoxStyle.OkOnly, "Producto")
		Cargar()
	End Sub

	Private Sub Cargar()
		txtMonto.Text = ""
		txtPorcentaje.Text = ""
		CheckedListBox1.Items.Clear()
		listaDeProductos = New List(Of Tuple(Of Integer, Boolean, ProductosNE))
		Dim productos = helpersLN.CargarTodosProductos(New Dictionary(Of String, String)).Tables(0)
		For i As Integer = 0 To productos.Rows.Count - 1
			CheckedListBox1.Items.Add(productos.Rows(i)(1) + "                      $" + productos.Rows(i)(3).ToString(), CheckState.Unchecked)
			Dim producto = New ProductosNE With {
			.Id = productos.Rows(i)(0),
			.nombreprducto = productos.Rows(i)(1),
			.proveedorId = productos.Rows(i)(5),
			.FechaAlta = productos.Rows(i)(6)
			}
			' p.Id,p.Nombre,p.Foto,p.Precio,prov.Nombre as Proveedor, prov.id , fechaalta
			listaDeProductos.Add(New Tuple(Of Integer, Boolean, ProductosNE)(CheckedListBox1.Items.Count - 1, False, producto))
		Next
	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If MsgBox("Desea chequear todos los productos?", MsgBoxStyle.YesNo, "Producto") = MsgBoxResult.Yes Then
			Dim count = ChequearDeschequearGeneral(True)
			MsgBox(count + " productos fueron chequeados", MsgBoxStyle.OkOnly, "Producto")
		End If
	End Sub

	Private Sub btnLimpiarFiltros_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltros.Click
		If MsgBox("Desea deschequear todos los productos y limpiar los filtros?", MsgBoxStyle.YesNo, "Producto") = MsgBoxResult.Yes Then
			Dim count = ChequearDeschequearGeneral(False)
			MsgBox(count + " productos fueron deschequeados", MsgBoxStyle.OkOnly, "Producto")
		End If
	End Sub

	Private Function ChequearDeschequearGeneral(chequear As Boolean)
		Dim count = 0
		For i As Integer = 0 To CheckedListBox1.Items.Count - 1
			Me.CheckedListBox1.SetItemChecked(i, chequear)
			count += 1
		Next
		Return count
	End Function

	Private Function ChequearDeschequearConFiltros(parametros As Dictionary(Of String, String), chequear As Boolean)
		Dim listaDeIntegers = New List(Of Integer)
		For Each item As KeyValuePair(Of String, String) In parametros
			If item.Key = "Proveedor" Then
				For Each tupla As Tuple(Of Integer, Boolean, ProductosNE) In listaDeProductos.Where(Function(x) x.Item3.proveedorId = item.Value)
					If Not listaDeIntegers.Contains(tupla.Item1) Then
						listaDeIntegers.Add(tupla.Item1)
					End If
				Next
				Continue For
			End If
			If item.Key = "Nombre" Then
				For Each tupla As Tuple(Of Integer, Boolean, ProductosNE) In listaDeProductos.Where(Function(x) x.Item3.nombreprducto = item.Value)
					If Not listaDeIntegers.Contains(tupla.Item1) Then
						listaDeIntegers.Add(tupla.Item1)
					End If
				Next
				Continue For
			End If
			If item.Key = "FechaDesde" And Not parametros.Keys.Contains("FechaHasta") Then
				Dim fecha = Date.ParseExact(item.Value, "dd/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
				For Each tupla As Tuple(Of Integer, Boolean, ProductosNE) In listaDeProductos.Where(Function(x) x.Item3.FechaAlta > fecha).Where(Function(x) x.Item3.FechaAlta < fecha.AddHours(23).AddMinutes(59))
					If Not listaDeIntegers.Contains(tupla.Item1) Then
						listaDeIntegers.Add(tupla.Item1)
					End If
				Next
				Continue For
			End If
			If item.Key = "FechaDesde" And parametros.Keys.Contains("FechaHasta") Then
				'Dim fechadesde = Date.ParseExact(item.Value, "dd/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
				'For Each tupla As Tuple(Of Integer, Boolean, ProductosNE) In listaDeProductos.Where(Function(x) x.Item3.FechaAlta > fecha).Where(Function(x) x.Item3.FechaAlta < fecha.AddHours(23).AddMinutes(59))
				'	If Not listaDeIntegers.Contains(tupla.Item1) Then
				'		listaDeIntegers.Add(tupla.Item1)
				'	End If
				'Next
				Continue For
			End If
			If item.Key = "FechaHasta" Then

				Continue For
			End If
		Next
		Dim count = 0
		For i As Integer = 0 To CheckedListBox1.Items.Count - 1
			Me.CheckedListBox1.SetItemChecked(i, chequear)
			count += 1
		Next
		Return count
	End Function

	'Llena el combobox proveedores
	Public Function LlenarCboProveedores()
		Try
			Dim ds1 As DataSet
			ds1 = helpersLN.CargarCboTodosProveedores()
			cboProveedor.DataSource = ds1.Tables(0)
			cboProveedor.DisplayMember = "Nombre"
			cboProveedor.ValueMember = "id"
			cboProveedor.SelectedValue = 0
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return cboProveedor.SelectedValue
	End Function

	'Validas los radio buton de fecha de cargado de producto
	Private Sub RbtEntreFechas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEntreFechas.CheckedChanged, rbtFechaExacta.CheckedChanged

		If rbtFechaExacta.Checked Then
			lblFechaExacta.Visible = True
			lbldesde.Visible = False
			rbtEntreFechas.Checked = False
			lblHasta.Visible = False
			dtpFechaHasta.Visible = False
			dtpFechaDesde.Visible = True
		ElseIf rbtEntreFechas.Checked Then
			lblFechaExacta.Visible = False
			rbtFechaExacta.Checked = False
			lblHasta.Visible = True
			dtpFechaHasta.Visible = True
			dtpFechaDesde.Visible = True
			lbldesde.Visible = True
		ElseIf Not rbtEntreFechas.Checked And Not rbtFechaExacta.Checked Then
			dtpFechaHasta.Visible = False
			dtpFechaDesde.Visible = False
			lblFechaExacta.Visible = False
			lblHasta.Visible = False
			lbldesde.Visible = False
		End If

	End Sub

	Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
		'dtpFechaHasta.Visible = False
		'dtpFechaDesde.Visible = True
		Dim parametros As Dictionary(Of String, String) = New Dictionary(Of String, String)
		If String.IsNullOrWhiteSpace(dtpFechaDesde.Value.ToString()) = False And dtpFechaDesde.Visible Then
			parametros.Add("FechaDesde", dtpFechaDesde.Value.Date.ToString("dd/MM/yyyy HH:mm:ss"))
		End If
		If String.IsNullOrWhiteSpace(dtpFechaHasta.Value.ToString()) = False And dtpFechaDesde.Visible And dtpFechaHasta.Visible Then
			If dtpFechaHasta.Value <= dtpFechaDesde.Value Then
				MsgBox("La fecha desde no puede ser mayor que la fecha hasta", MsgBoxStyle.OkOnly, "Error")
				Return
			End If
			parametros.Add("FechaHasta", dtpFechaHasta.Value.Date.ToString("dd/MM/yyyy HH:mm:ss"))
		End If
		If String.IsNullOrWhiteSpace(txtBusNombreProducto.Text) = False Then
			parametros.Add("Nombre", txtBusNombreProducto.Text)
		End If
		If String.IsNullOrWhiteSpace(txtBusNombreProducto.Text) = False Then
			parametros.Add("Proveedor", cboProveedor.SelectedValue)
		End If
	End Sub

End Class