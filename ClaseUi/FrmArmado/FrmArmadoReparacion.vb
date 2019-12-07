Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports System.Windows.Forms.ListView
Imports ClaseLn
Imports ClaseNe

Public Class FrmArmadoReparacion

    Private helpersLN As New HelpersLN
    Private helpersUI As New HelpersUI
    Private pedidosLN As New PedidosLN
    Private clientesLN As New ClientesLN
    Dim moveItem As Boolean
    Private listita As List(Of ListViewItem)
    Private selectedProducto As ListViewItem
    Dim product As New ProductoLN
	Dim total As Double
	Public primerOrder As Boolean = True
	Public OrderBy As New List(Of Tuple(Of Integer, String, Integer)) 'Index, nombrevista, nombre base, prioridad



#Region "Eventos"

	Private Sub FrmGestionVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Cargar()
	End Sub

	Public Sub LlenarCboOrden()
		cboOrden.DataSource = {"asc", "desc"}
		cboOrden.SelectedItem = "desc"
	End Sub

	Private Sub Cargar()
		LlenarCboOrden()
		InicializarOrderBy()
		txtDevolucion.Text = 7
		lstProdDispo.Clear()
		total = 0.00
		lblTotal.Text = total.ToString("0.00")
		LlenarCboClientes()
		GroupBox1.Visible = False
		lblInstrucciones.Visible = True
		btnLimpiar.Enabled = False
		lblClienteTelefono.Visible = True
		btnQuitarItem.Enabled = False
	End Sub

	Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		primerOrder = True
		Me.Close()
	End Sub

	Private Sub CboCliente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectionChangeCommitted
		lblPrioridad1.Visible = True
		lblPrioridad1.Text = OrderBy.FirstOrDefault(Function(x) x.Item1 = 1).Item2.Replace("'", "")
		lblInstrucciones.Visible = False
		Dim ds As DataSet = clientesLN.ConsultaModificacion(cboCliente.SelectedValue)
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
            End If

            If String.IsNullOrEmpty(lblClienteTelefono.Text) Then
                lblClienteTelefono.Visible = False
            End If

        Next

        LlenarLvi(New Dictionary(Of String, String))
        btnLimpiar.Enabled = True
        btnQuitarItem.Enabled = True

    End Sub

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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Enabled = True
        Dim DiccionarioDeStringYCantidad = New Dictionary(Of Integer, Integer)
        Dim listaDeInteger = New List(Of Integer)

        ListView1.Sort()

        For Each item As ListViewItem In ListView1.Items
            listaDeInteger.Add(item.Tag.item(0))
        Next

        For Each item As Integer In listaDeInteger
            If Not DiccionarioDeStringYCantidad.Keys.Contains(item) Then
                Dim cantidad = listaDeInteger.Where(Function(s) s = item).Count
                DiccionarioDeStringYCantidad.Add(item, cantidad)
            End If
        Next

        If DiccionarioDeStringYCantidad.Count = 0 Then
            MsgBox("Debe agregar algún producto a la lista", MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtDevolucion.Text) Then
            MsgBox("El pedido de reparación debe tener algún tiempo aproximado de entrega", MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        Dim listaDeVentas = New List(Of TipoDeVentasNE)
        For Each item As KeyValuePair(Of Integer, Integer) In DiccionarioDeStringYCantidad
            Dim product = ObtainProductInformation(item.Key)
            Dim venta = New TipoDeVentasNE With {
                .Cantidad = item.Value,
                .ProductoId = item.Key,
                .Precio = product.precio,
                .Dias = txtDevolucion.Text
            }
            listaDeVentas.Add(venta)
            FrmComprobanteVenta.ListaVentas.Add(venta)
        Next

		pedidosLN.Registrar(listaDeVentas, cboCliente.SelectedValue, 0)
		MsgBox("Pedido de reparacion realizado con éxito", MsgBoxStyle.OkOnly, "Exito")
        Cargar()
		FrmGestionReparaciones.recargar = True

		'FrmComprobanteVenta.ShowDialog()


		ListView1.Clear()
        LlenarCboClientes()

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        If MsgBox("Desea limpiar la lista de ventas?", MsgBoxStyle.YesNo, "Ventas") = MsgBoxResult.Yes Then
            ListView1.Clear()
            total = 0.0
            lblTotal.Text = total.ToString("0.00")
            selectedProducto = Nothing
        End If
    End Sub

    Private Sub BtnQuitarItem_Click(sender As Object, e As EventArgs) Handles btnQuitarItem.Click
        If selectedProducto IsNot Nothing Then
            ListView1.Items.Remove(selectedProducto)
            total -= selectedProducto.Tag(3)
            lblTotal.Text = total.ToString("0.00")
            selectedProducto = Nothing
        End If
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        selectedProducto = ListView1.FocusedItem
    End Sub

    Private Sub BtnLimpiarFiltros_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltros.Click
		If MsgBox("Desea limpiar la búsqueda?", MsgBoxStyle.YesNo, "Búsqueda") = MsgBoxResult.No Then
			Return
		End If
		txtBusNombreProducto.Text = ""
        chkSoloCliente.Checked = False
        Search()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Search()
    End Sub

#End Region

#Region "Metodos"

    Public Sub Search()
        Dim parametros As Dictionary(Of String, String) = New Dictionary(Of String, String)
        If String.IsNullOrWhiteSpace(txtBusNombreProducto.Text) = False Then
            parametros.Add("Nombre", txtBusNombreProducto.Text)
        End If
        If chkSoloCliente.Checked Then
            parametros.Add("ClienteId", cboCliente.SelectedValue)
        End If
        LlenarLvi(parametros)
    End Sub

    Public Function LlenarCboClientes()
        Try
            Dim ds1 As DataSet
            ds1 = helpersLN.CargarCboTodosClientes()
            cboCliente.DataSource = ds1.Tables(0)
            cboCliente.DisplayMember = "Nombre"
            cboCliente.ValueMember = "id"
            cboCliente.SelectedValue = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return cboCliente.SelectedValue
        MessageBox.Show(cboCliente.SelectedValue)
    End Function

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

	Public Sub LlenarLvi(ByVal parametros As Dictionary(Of String, String))
        parametros.Add("EsReparacion", "S")
		Dim ds2 As DataSet = helpersLN.CargarTodosProductos(parametros, OrderBy, cboOrden.SelectedItem, "")

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
        For i As Integer = 0 To ds2.Tables(0).Rows.Count - 1
            Dim listaViewItem As ListViewItem = New ListViewItem
#Region "Img stuff"

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
            listaViewItem.Text = ds2.Tables(0).Rows(i).Item(1).ToString()
            listaViewItem.Tag = ds2.Tables(0).Rows(i)
            listaViewItem.ImageIndex = ik
            lstProdDispo.Items.Add(ds2.Tables(0).Rows(i).Item(1).ToString(), ik)
            listita.Add(listaViewItem)
        Next
        If cboOrden.SelectedItem = "asc" Then
            lstProdDispo.Sorting = SortOrder.Ascending
        Else
            lstProdDispo.Sorting = SortOrder.Descending
        End If
        lstProdDispo.LargeImageList = ImageList
	End Sub

    Private Function ObtainProductInformation(ByVal id As Integer) As ProductosNE
        Dim producto = New ProductosNE
        Dim ds = product.CargarUnProducto(id, "")
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
			Dim precioCosto As Decimal = ds.Tables(0).Rows(i).Item(4)
			Dim utilidad As Decimal = ds.Tables(0).Rows(i).Item(5)
			producto.Id = ds.Tables(0).Rows(i).Item(0)
			producto.precio = (precioCosto * utilidad / 100 + (precioCosto)).ToString("0.00")
		Next
        Return producto
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        FrmGestionProductoAReparar.ShowDialog()
    End Sub

    Private Sub FrmGestionArmado_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If FrmGestionProductoAReparar.modificado Then
            Search()
            FrmGestionProductoAReparar.modificado = False
        End If
        If FrmGestionCliente.modificado Then
            Cargar()
            ListView1.Clear()
            LlenarCboClientes()
            FrmGestionCliente.modificado = False
        End If
    End Sub

    Private Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        FrmGestionCliente.ShowDialog()
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