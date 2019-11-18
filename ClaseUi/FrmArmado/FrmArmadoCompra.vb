Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports System.Windows.Forms.ListView
Imports ClaseLn
Imports ClaseNe

Public Class FrmArmadoCompra

	Private helpersLN As New HelpersLN
	Private helpersUI As New HelpersUI
	Private comprasLn As New ComprasLN
	Private proveedoresLN As New ProveedoresLN
	Dim moveItem As Boolean
	Private listita As List(Of ListViewItem)
	Private selectedProducto As ListViewItem
	Dim product As New ProductoLN
	Dim total As Double
	Public modificado = False



#Region "Eventos"

	Private Sub FrmArmadoCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Cargar()
		modificado = False
	End Sub

	'Te lleva al frm de gestion de producto.
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
		FrmGestionProducto.ShowDialog()
	End Sub

	'Te lleva al frm de gestion de proveedores.
	Private Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarProveedor.Click
		FrmGestionProveedores.ShowDialog()
	End Sub

	Private Sub Cargar()
		lstProdDispo.Clear()
		total = 0.00
		lblTotal.Text = total.ToString("0.00")
		LlenarCboProveedores()
		GroupBox1.Visible = False
		gboFiltros.Enabled = False
		dtpFechaHasta.Visible = False
		dtpFechaDesde.Visible = False
		lblFechaExacta.Visible = False
		lblHasta.Visible = False
		lbldesde.Visible = False
		lblInstrucciones.Visible = True
		btnLimpiar.Enabled = False
		btnQuitarItem.Enabled = False
	End Sub

	Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()
	End Sub

	'Carga todos los datos del proveedor seleccionado y carga el LVI segun ese proveedor
	Private Sub CboCliente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboProveedor.SelectionChangeCommitted
		lblInstrucciones.Visible = False
		GroupBox1.Visible = True
		'Traemos los datos del un proveedor seleccionado
		Dim ds As DataSet = proveedoresLN.ConsultaModificacion(cboProveedor.SelectedValue)
		'Y validamos si tiene ciertos datos para armar la información
		For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
			'Nombre + apellido o Nombre Fiscal + Razon Social
			lblNombre.Text = ds.Tables(0).Rows(i)(3).ToString() + " " + ds.Tables(0).Rows(i)(4).ToString()

			'TODO Seria mas facil identificar lso datos poniendolos en variables.

			'							Si											el dato no esta vacío											le agregamos la leyenda correspondiente + el dato, si no, va vacío
			Dim piso As String = If(ds.Tables(0).Rows(i)(14).ToString() <> "" Or ds.Tables(0).Rows(i)(14).ToString() <> Nothing, "Piso " + ds.Tables(0).Rows(i)(14).ToString() + " ", "")
			Dim dpto As String = If(ds.Tables(0).Rows(i)(15).ToString() <> "" Or ds.Tables(0).Rows(i)(15).ToString() <> Nothing, "Dpto " + ds.Tables(0).Rows(i)(15).ToString() + " ", "")
			Dim mzan As String = If(ds.Tables(0).Rows(i)(16).ToString() <> "" Or ds.Tables(0).Rows(i)(16).ToString() <> Nothing, "Manzana " + ds.Tables(0).Rows(i)(16).ToString() + " ", "")
			Dim lote As String = If(ds.Tables(0).Rows(i)(17).ToString() <> "" Or ds.Tables(0).Rows(i)(17).ToString() <> Nothing, "Lote " + ds.Tables(0).Rows(i)(17).ToString() + " ", "")
			Dim barrio As String = If(ds.Tables(0).Rows(i)(18).ToString() <> "" Or ds.Tables(0).Rows(i)(18).ToString() <> Nothing, "B° " + ds.Tables(0).Rows(i)(18).ToString() + " ", "")

			'Aca sumo todos los datos que acabamos de validar
			Dim direccionSinLocalidad = ds.Tables(0).Rows(i)(6).ToString() + " " + ds.Tables(0).Rows(i)(7).ToString() + piso + dpto + mzan + lote + barrio

			'Obtengo la localidad y le seteo el valor
			Dim ds1 As DataSet = helpersLN.CargarCMBLocalidadesUnico(ds.Tables(0).Rows(i)(8).ToString())
			Dim localidad As String = ds1.Tables(0).Rows(0)(1).ToString()

			'Si los datos validados tienen algo, lo sumamos a la localidad, si no solo ponemos la localidad que es el unico dato obligatorio
			lblClienteDireccion.Text = If(direccionSinLocalidad <> " ", direccionSinLocalidad + ", " + localidad, localidad)
			'Tipo DNI + N°
			lblClienteDNI.Text = ds.Tables(0).Rows(i)(1).ToString() + "  " + ds.Tables(0).Rows(i)(2).ToString()

			'Validamos si el teléfono tiene datos o no y de que tipo es.
			'Tiene mas prioridad el celular, si esta vacio caracteristica o numero, paso a chequear telefono. Caso contrario no muestro nada.
			If Not String.IsNullOrEmpty(ds.Tables(0).Rows(i)(9).ToString()) And Not String.IsNullOrEmpty(ds.Tables(0).Rows(i)(14).ToString()) Then
				lblClienteTelefono.Text = ds.Tables(0).Rows(i)(9).ToString() + ds.Tables(0).Rows(i)(10).ToString()
			ElseIf Not String.IsNullOrEmpty(ds.Tables(0).Rows(i)(11).ToString()) And Not String.IsNullOrEmpty(ds.Tables(0).Rows(i)(14).ToString()) Then
				lblClienteTelefono.Text = ds.Tables(0).Rows(i)(11).ToString() + ds.Tables(0).Rows(i)(12).ToString()
			End If

			If String.IsNullOrEmpty(lblClienteTelefono.Text) Then
				lblClienteTelefono.Visible = False
			End If

		Next

		Dim parametros = New Dictionary(Of String, String) From {
			{"ProveedorId", cboProveedor.SelectedValue}
		}
		'Lleno el ListViewItem con los productos del proveedor seleccionado
		LlenarLvi(parametros)
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
				.Precio = product.precio
			}
			listaDeCompras.Add(compra)
			FrmComprobanteCompra.ListaCompras.Add(compra)
		Next

		'Registramos la compra y sus respectivos detalles

		comprasLn.Registrar(listaDeCompras, cboProveedor.SelectedValue, CargarDatosComprobante())
		MsgBox("Compra realizada con éxito", MsgBoxStyle.OkOnly, "Exito")
		Cargar()
		'Imprimimos el comprobante
		FrmComprobanteCompra.ShowDialog()
		modificado = True


		ListView1.Clear()
		LlenarCboProveedores()

	End Sub

	'Limpia el LVI de la derecha y recalcula el total de la compra
	Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
		If MsgBox("Desea limpiar la lista de compras?", MsgBoxStyle.YesNo, "Compras") = MsgBoxResult.Yes Then
			ListView1.Clear()
			total = 0.0
			lblTotal.Text = total.ToString("0.00")
		End If
	End Sub

	'Quita el producto seleccionado y recalcula el total de la compra
	Private Sub BtnQuitarItem_Click(sender As Object, e As EventArgs) Handles btnQuitarItem.Click
		If selectedProducto IsNot Nothing Then
			ListView1.Items.Remove(selectedProducto)
			total -= selectedProducto.Tag(3)
			lblTotal.Text = total.ToString("0.00")
		End If
	End Sub

	Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
		selectedProducto = ListView1.FocusedItem
	End Sub

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

	Private Sub BtnLimpiarFiltros_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltros.Click
		If MsgBox("Desea limpiar los filtros?", MsgBoxStyle.YesNo, "Filtros") = MsgBoxResult.No Then
			Return
		End If
		rbtEntreFechas.Checked = False
		rbtFechaExacta.Checked = False
		txtBusNombreProducto.Text = ""
		dtpFechaDesde.Value = Date.Now
		dtpFechaHasta.Value = Date.Now
		Search()
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
			CantidadDragAndDrop.ShowDialog()
			For index = 1 To CantidadDragAndDrop.cantidad
				Dim cloneOfItem = ItemSelected.Clone()
				ListView1.Items.Add(cloneOfItem)
				total += ItemSelected.Tag(3)
				lblTotal.Text = total.ToString("0.00")
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

	'Llena el ListViewItem de la derecha con los productos disponibles segun filtro
	Public Sub LlenarLvi(ByVal parametros As Dictionary(Of String, String))
		'Cargamos el dataset con los productos seleccionados por filtro
		Dim ds2 As DataSet = helpersLN.CargarTodosProductos(parametros)
		'Vaciamos el LVI por si llegara a haber items 
		lstProdDispo.Clear()
		lstProdDispo.Scrollable = True

		If ds2.Tables(0).Rows.Count = 0 Then
			MsgBox("No se encontró ningún producto bajo los parámetros solicitados", MsgBoxStyle.OkOnly, "Productos")
			Return
		End If

		Dim ik As Integer
		Dim imagen As ImageList = New ImageList
		Dim ImageList = New ImageList()

		listita = New List(Of ListViewItem)
		'Iteramos todos los productos recibidos
		For i As Integer = 0 To ds2.Tables(0).Rows.Count - 1
			Dim listaViewItem As ListViewItem = New ListViewItem
			'Creamos un memoryStream para llenarlo segun lo recibido y lo agregamos a las imagenes del LVI
#Region "Img stuff" 'Creamos un memoryStream para llenarlo segun lo recibido y lo agregamos a las imagenes del LVI

			If i = 0 Then
				ik = 0
			Else
				ik += 1
			End If
			Dim ms As MemoryStream = New MemoryStream()

			Dim img As Byte() = CType(ds2.Tables(0).Rows(i).Item(2), Byte())
			If img IsNot Nothing Then
				ms.Write(img, 0, img.GetUpperBound(0) + 1)
				Dim imgImagen As Image = Image.FromStream(ms)

				ImageList.Images.Add(Image.FromStream(ms))
				ImageList.ImageSize = New Size(90, 90)

			End If
#End Region
			'Asignamos el texto del item
			listaViewItem.Text = ds2.Tables(0).Rows(i).Item(1).ToString()
			'Asignamos toda la info para cuando se pase a la otra columna
			listaViewItem.Tag = ds2.Tables(0).Rows(i)
			'Asignamos la imagen
			listaViewItem.ImageIndex = ik
			'Y a las listas para tenerlo en el resto del frm
			lstProdDispo.Items.Add(ds2.Tables(0).Rows(i).Item(1).ToString(), ik)
			listita.Add(listaViewItem)
		Next

		lstProdDispo.LargeImageList = ImageList
		gboFiltros.Enabled = True
	End Sub

	'Traemos toda la informacion de un producto en especifico para los comprobantes.
	Private Function ObtainProductInformation(ByVal id As Integer) As ProductosNE
		Dim producto = New ProductosNE
		Dim ds = product.CargarUnProducto(id, "")
		For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
			producto.Id = ds.Tables(0).Rows(i).Item(0)
			producto.precio = ds.Tables(0).Rows(i).Item(4)
		Next
		Return producto
	End Function

	'Trae el numero de comprobante segun el ID en BD
	Private Function CargarDatosComprobante()
		Dim nroComprobante = ""
		If String.IsNullOrWhiteSpace(txtNroComprobante.Text) Then
			nroComprobante = helpersUI.AgregarNumerosComprobante(comprasLn.ObtenerUltimaCompra.Tables(0).Rows(0).Item(0))
		Else
			nroComprobante = txtNroComprobante.Text
		End If
		Return nroComprobante
	End Function

	'Verifica si se hicieron cambios en los frm externos solo si salieron desde este.
	Private Sub FrmGestionArmado_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
		'En caso de que haya habido algun cambio, recarga los datos correspondientes
		If FrmGestionProducto.modificado Then
			Search()
			FrmGestionProducto.modificado = False
		End If
		If FrmGestionProveedores.modificado Then
			Cargar()
			ListView1.Clear()
			LlenarCboProveedores()
			FrmGestionProveedores.modificado = False
		End If
	End Sub

#End Region

End Class