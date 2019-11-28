Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports System.Windows.Forms.ListView
Imports ClaseLn
Imports ClaseNe

Public Class FrmArmadoPago

	Private helpersLN As New HelpersLN
	Private helpersUI As New HelpersUI
	Private pagosLN As New PagosLN
	Private proveedoresLN As New ProveedoresLN
	Dim moveItem As Boolean
	Private listita As List(Of ListViewItem)
	Private selectedProducto As ListViewItem
	Dim product As New ProductoLN
	Dim total As Double
	Public modificado = False
	Public primerOrder As Boolean = True
	Public OrderBy As New List(Of Tuple(Of Integer, String, Integer)) 'Index, nombrevista, nombre base, prioridad


#Region "Eventos"

	Private Sub FrmArmadoCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Cargar()
		LlenarCboProveedores()
		modificado = False
	End Sub

	'Te lleva al frm de gestion de producto.
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevoServicio.Click
		FrmGestionServicio.ShowDialog()
	End Sub

	'Te lleva al frm de gestion de proveedores.
	Private Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoProveedor.Click
		FrmGestionProveedores.ShowDialog()
	End Sub

	Private Sub Cargar()
		InicializarOrderBy()
		cboProveedor.Enabled = True
		ListView1.Clear()
		lstProdDispo.Clear()
		total = 0.00
		lblTotal.Text = total.ToString("0.00")
		gboFiltros.Enabled = False
		dtpFechaHasta.Visible = False
		dtpFechaDesde.Visible = False
		'lblFechaExacta.Visible = False
		lblHasta.Visible = False
		lblDesde.Visible = False
		btnLimpiar.Enabled = False
		btnQuitarItem.Enabled = False
	End Sub

	Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		primerOrder = True
		Me.Close()
	End Sub

	Private Sub PrepararTodo()
		btnLimpiar.Enabled = True
		btnQuitarItem.Enabled = True
	End Sub

	'Agrega la nueva compra y abre el comprobante correspondiente
	Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		btnNuevo.Enabled = True
		Dim DiccionarioDeStringYCantidad = New Dictionary(Of Integer, Integer)
		Dim listaDeInteger = New List(Of Integer)

		ListView1.Sort()

		'Lista de id de los productos en el LVI de la derecha
		For Each item As ListViewItem In ListView1.Items
			listaDeInteger.Add(item.Tag.item(0))
		Next

		'Nos fijamos la cantidad y que productos estan en el carrito
		For Each item As Integer In listaDeInteger
			If Not DiccionarioDeStringYCantidad.Keys.Contains(item) Then
				'Contamos la cantidad de cierto producto
				Dim cantidad = listaDeInteger.Where(Function(s) s = item).Count
				'Y agregamos. El key es el id del producto y el value su cantidad
				DiccionarioDeStringYCantidad.Add(item, cantidad)
			End If
		Next

		'Si el carrito esta vacio, devolvemos vacio
		If DiccionarioDeStringYCantidad.Count = 0 Then
			MsgBox("Debe agregar algún producto a la lista", MsgBoxStyle.OkOnly, "Error")
			Return
		End If

		'Agrupamos la informacion necesaria para imprimir el comprobante
		Dim listaDeCompras = New List(Of TipoDeComprasNE)
		For Each item As KeyValuePair(Of Integer, Integer) In DiccionarioDeStringYCantidad
			Dim product = ObtainProductInformation(item.Key)
			Dim compra = New TipoDeComprasNE With {
				.Cantidad = item.Value,
				.ProductoId = item.Key,
				.Precio = product.precio,
				.ProveedorId = product.proveedorId
			}
			listaDeCompras.Add(compra)
			FrmComprobanteCompra.ListaCompras.Add(compra)
		Next

		'Registramos la compra y sus respectivos detalles
		pagosLN.Registrar(listaDeCompras)
		MsgBox("Pago realizado con éxito", MsgBoxStyle.OkOnly, "Exito")
		Cargar()
		PrepararTodo()
		LlenarCboProveedores()
		'Imprimimos el comprobante
		'FrmComprobanteVenta.ShowDialog()
		modificado = True


		'ListView1.Clear()
		'LlenarCboProveedores()

	End Sub

	'Limpia el LVI de la derecha y recalcula el total de la compra
	Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
		If MsgBox("Desea limpiar la lista de servicios?", MsgBoxStyle.YesNo, "Compras") = MsgBoxResult.Yes Then
			ListView1.Clear()
			total = 0.0
			lblTotal.Text = total.ToString("0.00")
		End If
		If lstProdDispo.Items.Count = 0 Then
			CargarProductosConProveedor()
		End If
	End Sub

	'Quita el producto seleccionado y recalcula el total de la compra
	Private Sub BtnQuitarItem_Click(sender As Object, e As EventArgs) Handles btnQuitarItem.Click
		If selectedProducto IsNot Nothing Then
			ListView1.Items.Remove(selectedProducto)
			total -= selectedProducto.Tag(3)
			lblTotal.Text = total.ToString("0.00")
			selectedProducto = Nothing
			If lstProdDispo.Items.Count = 0 Then
				CargarProductosConProveedor()
			End If
		Else
			MsgBox("Debe seleccionar un producto", MsgBoxStyle.OkOnly, "Compras")
		End If
	End Sub

	Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
		selectedProducto = ListView1.FocusedItem
	End Sub

	'Validas los radio buton de fecha de cargado de producto
	Private Sub RbtEntreFechas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEntreFechas.CheckedChanged, rbtFechaExacta.CheckedChanged

		If rbtFechaExacta.Checked Then
			'lblFechaExacta.Visible = True
			lblDesde.Visible = True
			rbtEntreFechas.Checked = False
			lblHasta.Visible = False
			dtpFechaHasta.Visible = False
			dtpFechaDesde.Visible = True
		ElseIf rbtEntreFechas.Checked Then
			'lblFechaExacta.Visible = False
			rbtFechaExacta.Checked = False
			lblHasta.Visible = True
			dtpFechaHasta.Visible = True
			dtpFechaDesde.Visible = True
			lblDesde.Visible = True
		ElseIf Not rbtEntreFechas.Checked And Not rbtFechaExacta.Checked Then
			dtpFechaHasta.Visible = False
			dtpFechaDesde.Visible = False
			'lblFechaExacta.Visible = False
			lblHasta.Visible = False
			lblDesde.Visible = False
		End If

	End Sub

	Private Sub BtnLimpiarFiltros_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltros.Click
		If MsgBox("Desea limpiar la búsqueda?", MsgBoxStyle.YesNo, "Búsqueda") = MsgBoxResult.No Then
			Return
		End If
		rbtEntreFechas.Checked = False
		rbtFechaExacta.Checked = False
		txtBusNombreProducto.Text = ""
		dtpFechaDesde.Value = Date.Now
		dtpFechaHasta.Value = Date.Now
		If lstProdDispo.Items.Count = 0 And ListView1.Items.Count = 0 Then
			CargarProductosConProveedor()
		End If
		'Search()
	End Sub

	Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
		Search()
	End Sub

#End Region

#Region "Drag And Drop"

	Private Sub LstProdDispo_MouseDown(sender As Object, e As MouseEventArgs) Handles lstProdDispo.MouseDown
		moveItem = True
	End Sub

	Private Sub LstProdDispo_MouseMove(sender As Object, e As MouseEventArgs) Handles lstProdDispo.MouseMove
		Try
			If moveItem Then
				Dim asdas As New Label
				If Not lstProdDispo.SelectedItems.Count = 0 Then
					asdas.Text = lstProdDispo.SelectedItems.Item(0).Text
					asdas.DoDragDrop(asdas.Text, DragDropEffects.Copy)
				End If
			End If
			moveItem = False
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

	Private Sub ListView1_DragDrop(sender As Object, e As DragEventArgs) Handles ListView1.DragDrop

		Dim ItemSelected = listita.Where(Function(s) s.Text = e.Data.GetData(DataFormats.Text)).FirstOrDefault()
		If ItemSelected IsNot Nothing Then
			Dim cloneOfItem = ItemSelected.Clone()
			ListView1.Items.Add(cloneOfItem)
			total += ItemSelected.Tag(3)
			lblTotal.Text = total.ToString("0.00")


			Dim pos As Int32
			Dim listItem As ListViewItem

			For pos = lstProdDispo.Items.Count - 1 To 0 Step -1
				listItem = lstProdDispo.Items(pos)
				If listItem.Text = e.Data.GetData(DataFormats.Text) Then
					lstProdDispo.Items.Remove(listItem)
				End If
			Next

		End If

	End Sub

	Private Sub ListView1_DragEnter(sender As Object, e As DragEventArgs) Handles ListView1.DragEnter
		If e.Data.GetDataPresent(DataFormats.Text) Then
			e.Effect = DragDropEffects.Copy
		Else
			e.Effect = DragDropEffects.None
		End If
	End Sub

#End Region

#Region "Metodos"

	Public Function LlenarCboProveedores()
		Try
			Dim ds1 As DataSet
			ds1 = helpersLN.CargarCboTodosProveedores("True")
			cboProveedor.DataSource = ds1.Tables(0)
			cboProveedor.DisplayMember = "Nombre"
			cboProveedor.ValueMember = "id"
			cboProveedor.SelectedValue = 0
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return cboProveedor.SelectedValue
	End Function

	'Agrega los parametros de busqueda al diccionario y llama al metodo que carga el LVI
	Public Sub Search()
		Dim parametros As Dictionary(Of String, String) = New Dictionary(Of String, String)
		If String.IsNullOrWhiteSpace(dtpFechaDesde.Value.ToString()) = False And dtpFechaDesde.Visible Then
			parametros.Add("FechaDesde", dtpFechaDesde.Value.Date.ToString("dd/MM/yyyy"))
		End If
		If String.IsNullOrWhiteSpace(dtpFechaHasta.Value.ToString()) = False And dtpFechaDesde.Visible And dtpFechaHasta.Visible Then
			If dtpFechaHasta.Value <= dtpFechaDesde.Value Then
				MsgBox("La fecha desde no puede ser mayor que la fecha hasta", MsgBoxStyle.OkOnly, "Error")
				Return
			End If
			parametros.Add("FechaHasta", dtpFechaHasta.Value.Date.ToString("dd/MM/yyyy"))
		End If
		If String.IsNullOrWhiteSpace(txtBusNombreProducto.Text) = False Then
			parametros.Add("Nombre", txtBusNombreProducto.Text)
		End If
		LlenarLvi(parametros)
	End Sub

	'Llena el ListViewItem de la derecha con los productos disponibles segun filtro
	Public Sub LlenarLvi(ByVal parametros As Dictionary(Of String, String))
		'Cargamos el dataset con los productos seleccionados por filtro
		parametros.Add("EsReparacion", "N")
		Dim ds2 As DataSet = helpersLN.CargarTodosProductos(parametros, OrderBy, "true")

		If primerOrder Then
			primerOrder = False
			For i = 0 To ds2.Tables(0).Columns.Count - 1
				If ds2.Tables(0).Columns(i).ColumnName = "Foto" Or ds2.Tables(0).Columns(i).ColumnName = "Id" Or ds2.Tables(0).Columns(i).ColumnName = "id1" Or ds2.Tables(0).Columns(i).ColumnName = "Column1" Or ds2.Tables(0).Columns(i).ColumnName = "precio1" Then
					Continue For
				End If
				If ds2.Tables(0).Columns(i).ColumnName = "Fecha de Alta" Then
					chbListaParaOrdenar.Items.Add(ds2.Tables(0).Columns(i).ColumnName, CheckState.Checked)
					Continue For
				End If
				chbListaParaOrdenar.Items.Add(ds2.Tables(0).Columns(i).ColumnName)
			Next
			chbListaParaOrdenar.SetItemChecked(3, True)
		End If
		'Vaciamos el LVI por si llegara a haber items 
		lstProdDispo.Clear()
		lstProdDispo.Scrollable = True

		If ds2.Tables(0).Rows.Count = 0 Then
			MsgBox("No se encontró ningún producto bajo los parámetros solicitados", MsgBoxStyle.OkOnly, "Productos")
			Return
		End If

		listita = New List(Of ListViewItem)
		'Iteramos todos los productos recibidos
		For i As Integer = 0 To ds2.Tables(0).Rows.Count - 1
			Dim listaViewItem As ListViewItem = New ListViewItem
			'Creamos un memoryStream para llenarlo segun lo recibido y lo agregamos a las imagenes del LVI

			'Asignamos el texto del item
			listaViewItem.Text = ds2.Tables(0).Rows(i).Item(1).ToString()
			listaViewItem.Font = Font
			'Asignamos toda la info para cuando se pase a la otra columna
			listaViewItem.Tag = ds2.Tables(0).Rows(i)

			listaViewItem.BackColor = Color.AliceBlue
			'Y a las listas para tenerlo en el resto del frm
			lstProdDispo.Items.Add(listaViewItem)
			listita.Add(listaViewItem)
		Next

		gboFiltros.Enabled = True
	End Sub

	Private Sub chbListaParaOrdenar_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chbListaParaOrdenar.ItemCheck
		If Not String.IsNullOrEmpty(chbListaParaOrdenar.SelectedItem) Then

			Dim count = OrderBy.Where(Function(x) Not x.Item2 = "").Count()
			Dim suma = False
			Dim resta = False
			If e.NewValue = CheckState.Checked Then
				count += 1
				suma = True
			ElseIf e.NewValue = CheckState.Unchecked Then
				resta = True
			End If
			If OrderBy.FirstOrDefault(Function(x) x.Item2.Replace("'", "") = chbListaParaOrdenar.SelectedItem) IsNot Nothing Then
				suma = False
				count -= 1
			End If
			If count > 3 Then
				MsgBox("Se puede ordenar hasta por 3 campos máximo", MsgBoxStyle.OkOnly, "Ordenar")
				e.NewValue = CheckState.Unchecked
				Return
			End If

			Dim number = 0
			Dim prueba = OrderBy.LastOrDefault(Function(x) Not x.Item2 = "")
			If prueba IsNot Nothing Then
				number = prueba.Item1
			End If
			If suma Then
				OrderBy.RemoveAll(Function(x) x.Item1 = number + 1)
				OrderBy.Add(New Tuple(Of Integer, String, Integer)(number + 1, "'" + chbListaParaOrdenar.SelectedItem.ToString + "'", number + 1))
			End If
			If resta Then
				OrderBy.RemoveAll(Function(x) x.Item2 = "'" + chbListaParaOrdenar.SelectedItem.ToString + "'")
				OrderBy.Add(New Tuple(Of Integer, String, Integer)(number, "", number))
			End If
			OrderBy = OrderBy.OrderBy(Function(x) x.Item1).ToList()
			ImpactarOrderBy()
		End If
	End Sub

	Public Sub InicializarOrderBy()
		chbListaParaOrdenar.Items.Clear()
		OrderBy = New List(Of Tuple(Of Integer, String, Integer))
		OrderBy.Add(New Tuple(Of Integer, String, Integer)(1, "'Fecha de Alta'", 1))
		OrderBy.Add(New Tuple(Of Integer, String, Integer)(2, "", 2))
		OrderBy.Add(New Tuple(Of Integer, String, Integer)(3, "", 3))
		lblPrioridad1.Visible = False
		lblPrioridad2.Visible = False
		lblPrioridad3.Visible = False
	End Sub

	Public Sub ImpactarOrderBy()
		Dim count = OrderBy.Where(Function(x) Not x.Item2 = "").Count()

		If count >= 1 Then
			lblPrioridad1.Visible = True
			lblPrioridad1.Text = OrderBy(0).Item2.Replace("'", "")
		Else
			lblPrioridad1.Visible = False
		End If
		If count >= 2 Then
			lblPrioridad2.Visible = True
			lblPrioridad2.Text = OrderBy(1).Item2.Replace("'", "")
		Else
			lblPrioridad2.Visible = False
		End If
		If count >= 3 Then
			lblPrioridad3.Visible = True
			lblPrioridad3.Text = OrderBy(2).Item2.Replace("'", "")
		Else
			lblPrioridad3.Visible = False
		End If
	End Sub

	'Traemos toda la informacion de un producto en especifico para los comprobantes.
	Private Function ObtainProductInformation(ByVal id As Integer) As ProductosNE
		Dim producto = New ProductosNE
		Dim ds = product.CargarUnProducto(id, "")
		For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
			producto.Id = ds.Tables(0).Rows(i).Item(0)
			producto.precio = ds.Tables(0).Rows(i).Item(4)
			producto.proveedorId = ds.Tables(0).Rows(i).Item(10)
		Next
		Return producto
	End Function

	'Trae el numero de comprobante segun el ID en BD
	Private Function CargarDatosComprobante()
		Dim CompComprasNE As New ComprobanteComprasNE With {
			.Comprobante = helpersUI.AgregarNumerosComprobante(pagosLN.ObtenerUltimoPago)
		}
		Return CompComprasNE
	End Function

	'Verifica si se hicieron cambios en los frm externos solo si salieron desde este.
	Private Sub FrmGestionArmado_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
		'En caso de que haya habido algun cambio, recarga los datos correspondientes
		If FrmGestionServicio.modificado Then
			Search()
			FrmGestionServicio.modificado = False
		End If
		If FrmGestionProveedores.modificado Then
			Cargar()
			'LlenarCboProveedores()
			FrmGestionProveedores.modificado = False
		End If
	End Sub

	Private Sub cboProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProveedor.SelectionChangeCommitted
		lblPrioridad1.Visible = True
		lblPrioridad1.Text = OrderBy.FirstOrDefault(Function(x) x.Item1 = 1).Item2.Replace("'", "")
		lblInstrucciones.Visible = False
		Dim ds As DataSet = proveedoresLN.ConsultaModificacion(cboProveedor.SelectedValue)
		GroupBox1.Visible = True
		'Datos lbl arriba izquierda
		For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
			lblNombre.Text = ds.Tables(0).Rows(i)(3).ToString() + " " + ds.Tables(0).Rows(i)(4).ToString()

			Dim piso As String = If(ds.Tables(0).Rows(i)(14).ToString() <> "" Or ds.Tables(0).Rows(i)(14).ToString() <> Nothing, "Piso " + ds.Tables(0).Rows(i)(14).ToString() + " ", "")
			Dim dpto As String = If(ds.Tables(0).Rows(i)(15).ToString() <> "" Or ds.Tables(0).Rows(i)(15).ToString() <> Nothing, "Dpto " + ds.Tables(0).Rows(i)(15).ToString() + " ", "")
			Dim mzan As String = If(ds.Tables(0).Rows(i)(16).ToString() <> "" Or ds.Tables(0).Rows(i)(16).ToString() <> Nothing, "Manzana " + ds.Tables(0).Rows(i)(16).ToString() + " ", "")
			Dim lote As String = If(ds.Tables(0).Rows(i)(17).ToString() <> "" Or ds.Tables(0).Rows(i)(17).ToString() <> Nothing, "Lote " + ds.Tables(0).Rows(i)(17).ToString() + " ", "")
			Dim barrio As String = If(ds.Tables(0).Rows(i)(18).ToString() <> "" Or ds.Tables(0).Rows(i)(18).ToString() <> Nothing, "B° " + ds.Tables(0).Rows(i)(18).ToString() + " ", "")

			'Obtengo la localidad y le seteo el valor
			Dim ds1 As DataSet = helpersLN.CargarCMBLocalidadesUnico(ds.Tables(0).Rows(i)(8).ToString())
			Dim localidad As String = ds1.Tables(0).Rows(0)(1).ToString()
			Dim direccionSinLocalidad = ds.Tables(0).Rows(i)(6).ToString() + " " + ds.Tables(0).Rows(i)(7).ToString() + piso + dpto + mzan + lote + barrio

			lblClienteDireccion.Text = If(direccionSinLocalidad <> " ", direccionSinLocalidad + ", " + localidad, localidad)
			lblClienteDNI.Text = ds.Tables(0).Rows(i)(1).ToString() + "  " + ds.Tables(0).Rows(i)(2).ToString()

			If Not String.IsNullOrEmpty(ds.Tables(0).Rows(i)(9).ToString()) And Not String.IsNullOrEmpty(ds.Tables(0).Rows(i)(14).ToString()) Then
				lblClienteTelefono.Text = ds.Tables(0).Rows(i)(9).ToString() + ds.Tables(0).Rows(i)(10).ToString()
			ElseIf Not String.IsNullOrEmpty(ds.Tables(0).Rows(i)(11).ToString()) And Not String.IsNullOrEmpty(ds.Tables(0).Rows(i)(14).ToString()) Then
				lblClienteTelefono.Text = ds.Tables(0).Rows(i)(11).ToString() + ds.Tables(0).Rows(i)(12).ToString()
			Else
				lblClienteTelefono.Text = "-"
			End If


		Next
		CargarProductosConProveedor()
	End Sub

	Sub CargarProductosConProveedor()
		PrepararTodo()
		Dim parametros As New Dictionary(Of String, String)
		parametros.Add("ProveedorId", cboProveedor.SelectedValue.ToString())
		LlenarLvi(parametros)
		cboProveedor.Enabled = False
	End Sub

#End Region

	Private Const CP_NOCLOSE_BUTTON As Integer = &H200
	Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
		Get
			Dim myCp As CreateParams = MyBase.CreateParams
			myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
			Return myCp
		End Get
	End Property
End Class