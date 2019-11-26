Imports System.Globalization
Imports System.Windows.Forms
Imports System.Windows.Forms.CheckedListBox
Imports ClaseLn
Imports ClaseNe

Public Class FrmModificarPrecioProducto
	Private productometodo As New ProductoLN
	Private categoriasLn As New CategoriasLN

	Private helpersLN As New HelpersLN
	Private listaDeProductos As List(Of Tuple(Of Integer, Boolean, ProductosNE))

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

		Dim cantidad = 0
		Dim monto = Not String.IsNullOrWhiteSpace(txtMonto.Text)
		cantidad = If(monto, cantidad + 1, cantidad)
		Dim porcentaje = Not String.IsNullOrWhiteSpace(txtPorcentaje.Text)
		cantidad = If(porcentaje, cantidad + 1, cantidad)
		Dim adicion = Not String.IsNullOrWhiteSpace(txtAdicionar.Text)
		cantidad = If(adicion, cantidad + 1, cantidad)

		If cantidad > 1 Then
			MsgBox("Debe seleccionar solo un tipo de cambio de precio", MsgBoxStyle.Critical, "Producto")
			Return
		ElseIf cantidad = 0 Then
			MsgBox("Debe escribir algun tipo de cambio de precio", MsgBoxStyle.Critical, "Producto")
			Return
		End If

		If monto Then
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
			productometodo.ModificarPrecios(listaDeProductos.Where(Function(s) s.Item2 = True), value.ToString(), "monto")
		End If

		If porcentaje Then
			Dim value As Decimal
			Dim newText = txtPorcentaje.Text.Replace(",", ".")
			If Not Decimal.TryParse(newText, value) Then
				MsgBox("Ingrese el porcentaje en un formato correcto (95)", MsgBoxStyle.Critical, "Producto")
				Return
			End If
			newText = ((value / 100) + 1).ToString().Replace(",", ".")
			productometodo.ModificarPrecios(listaDeProductos.Where(Function(s) s.Item2 = True), newText, "porcentaje")
		End If

		If adicion Then
			Dim value As Decimal
			Dim newText = txtAdicionar.Text.Replace(",", ".")
			If Not Decimal.TryParse(newText, value) Then
				MsgBox("Ingrese el precio en un formato correcto (123.00)", MsgBoxStyle.Critical, "Producto")
				Return
			End If
			value = Decimal.Parse(newText, CultureInfo.InvariantCulture)
			productometodo.ModificarPrecios(listaDeProductos.Where(Function(s) s.Item2 = True), value.ToString(), "adicion")
		End If

		MsgBox("Precios modificados", MsgBoxStyle.OkOnly, "Producto")
		Cargar()
	End Sub

	Private Sub Cargar()
		txtMonto.Text = ""
		txtPorcentaje.Text = ""
		txtAdicionar.Text = ""
		lbldesde.Visible = False
		lblFechaExacta.Visible = False
		lblHasta.Visible = False
		LimpiarFiltros()
		LlenarCboProveedores()
		LlenarCboCategorias()
		CheckedListBox1.Items.Clear()
		listaDeProductos = New List(Of Tuple(Of Integer, Boolean, ProductosNE))
		Dim parametros = New Dictionary(Of String, String)
		parametros.Add("EsReparacion", "N")
		Dim productos = helpersLN.CargarTodosProductos(parametros).Tables(0)
		For i As Integer = 0 To productos.Rows.Count - 1
			Dim stringProducto = productos.Rows(i)(1)
			For y As Integer = productos.Rows(i)(1).length To 40
				stringProducto += " "
			Next
			CheckedListBox1.Items.Add(stringProducto + productos.Rows(i)(3).ToString(), CheckState.Unchecked)
			Dim producto = New ProductosNE With {
			.Id = productos.Rows(i)(0),
			.nombreprducto = productos.Rows(i)(1),
			.proveedorId = productos.Rows(i)(5),
			.FechaAlta = productos.Rows(i)(6),
			.categoriaId = productos.Rows(i)(7)
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
			MsgBox(count.ToString() + " producto/os fueron chequeados", MsgBoxStyle.OkOnly, "Producto")
		End If
	End Sub

	Private Sub btnLimpiarFiltros_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltros.Click
		If MsgBox("Desea deschequear todos los productos y limpiar la búsqueda?", MsgBoxStyle.YesNo, "Producto") = MsgBoxResult.Yes Then
			LimpiarFiltros()
			Dim count = ChequearDeschequearGeneral(False)
			MsgBox(count.ToString() + " producto/os fueron deschequeados", MsgBoxStyle.OkOnly, "Producto")
		End If
	End Sub

	Private Function ChequearDeschequearGeneral(chequear As Boolean)
		Dim count = 0
		For i As Integer = 0 To CheckedListBox1.Items.Count - 1
			If Not CheckedListBox1.GetItemChecked(i) = chequear Then
				count += 1
			End If
			Me.CheckedListBox1.SetItemChecked(i, chequear)
		Next
		Return count
	End Function

	Private Function ChequearDeschequearConFiltros(parametros As Dictionary(Of String, String), chequear As Boolean)
		Dim listaDeTuplas = New List(Of Tuple(Of Integer, Boolean, ProductosNE))
		For Each asdasdasd As Tuple(Of Integer, Boolean, ProductosNE) In listaDeProductos
			listaDeTuplas.Add(asdasdasd)
		Next
		For Each item As KeyValuePair(Of String, String) In parametros
			Select Case item.Key
				Case "Proveedor"
					listaDeTuplas.RemoveAll(Function(x) x.Item3.proveedorId <> item.Value)
				Case "Categoria"
					listaDeTuplas.RemoveAll(Function(x) x.Item3.categoriaId <> item.Value)
				Case "Nombre"
					listaDeTuplas.RemoveAll(Function(x) x.Item3.nombreprducto <> item.Value)
				Case "FechaDesde"
					Dim fechadesde = Date.ParseExact(item.Value, "dd/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
					listaDeTuplas.RemoveAll(Function(x) x.Item3.FechaAlta < fechadesde)
					If parametros.Keys.Contains("FechaHasta") Then
						Dim fechaHasta = Date.ParseExact(parametros.Where(Function(x) x.Key = "FechaHasta").FirstOrDefault().Value, "dd/M/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
						listaDeTuplas.RemoveAll(Function(x) x.Item3.FechaAlta > fechaHasta.AddHours(23).AddMinutes(59).AddSeconds(59))
					Else
						listaDeTuplas.RemoveAll(Function(x) x.Item3.FechaAlta > fechadesde.AddHours(23).AddMinutes(59).AddSeconds(59))
					End If
			End Select
		Next
		Dim count = 0
		For i = 0 To listaDeTuplas.Count - 1
			If Not CheckedListBox1.GetItemChecked(listaDeTuplas(i).Item1) Then
				count += 1
			End If
			Me.CheckedListBox1.SetItemChecked(listaDeTuplas(i).Item1, chequear)
		Next
		Return count
	End Function

	'Llena el combobox proveedores
	Public Function LlenarCboProveedores()
		Try
			Dim ds1 As DataSet
			ds1 = helpersLN.CargarCboTodosProveedores("False")
			cboProveedor.DataSource = ds1.Tables(0)
			cboProveedor.DisplayMember = "Nombre"
			cboProveedor.ValueMember = "id"
			cboProveedor.SelectedValue = 0
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return cboProveedor.SelectedValue
	End Function

	'Llena el combobox proveedores
	Public Function LlenarCboCategorias()
		Try
			Dim ds1 As DataSet
			ds1 = categoriasLn.CargarGrillaCategorías()
			cboCategorias.DataSource = ds1.Tables(0)
			cboCategorias.DisplayMember = "Nombre"
			cboCategorias.ValueMember = "id"
			cboCategorias.SelectedValue = 0
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
		If String.IsNullOrWhiteSpace(cboProveedor.SelectedValue) = False Then
			parametros.Add("Proveedor", cboProveedor.SelectedValue)
		End If
		If String.IsNullOrWhiteSpace(cboCategorias.SelectedValue) = False Then
			parametros.Add("Categoria", cboCategorias.SelectedValue)
		End If
		Dim count = ChequearDeschequearConFiltros(parametros, True)
		MsgBox(count.ToString() + " producto/os fueron chequeados", MsgBoxStyle.OkOnly, "Producto")
	End Sub

	Private Sub LimpiarFiltros()
		rbtEntreFechas.Checked = False
		rbtFechaExacta.Checked = False
		dtpFechaDesde.Value = Date.Now
		dtpFechaHasta.Value = Date.Now
		dtpFechaDesde.Visible = False
		dtpFechaHasta.Visible = False
		LlenarCboProveedores()
		txtBusNombreProducto.Text = ""
	End Sub

	Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles btnTtpGral.MouseHover, btnTtpAdicion.MouseHover, btnTtpExacto.MouseHover, btnTtpPorcentaje.MouseHover
		Select Case sender.Name
			Case "btnTtpGral"
				ttpInfoGral.Visible = True
			Case "btnTtpAdicion"
				ttpAdicionar.Visible = True
			Case "btnTtpExacto"
				ttpExacto.Visible = True
			Case "btnTtpPorcentaje"
				ttpPorcentaje.Visible = True
			Case Else
		End Select
	End Sub

	Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles btnTtpGral.MouseLeave, btnTtpAdicion.MouseLeave, btnTtpExacto.MouseLeave, btnTtpPorcentaje.MouseLeave
		Select Case sender.Name
			Case "btnTtpGral"
				ttpInfoGral.Visible = False
			Case "btnTtpAdicion"
				ttpAdicionar.Visible = False
			Case "btnTtpExacto"
				ttpExacto.Visible = False
			Case "btnTtpPorcentaje"
				ttpPorcentaje.Visible = False
			Case Else
		End Select
	End Sub

End Class