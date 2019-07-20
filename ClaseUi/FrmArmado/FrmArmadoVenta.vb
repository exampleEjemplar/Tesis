Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports System.Windows.Forms.ListView
Imports ClaseLn
Imports ClaseNe

Public Class FrmArmadoVenta

    Private helpersLN As New HelpersLN
    Private helpersUI As New HelpersUI
    Private ventasLN As New VentasLN
    Private clientesLN As New ClientesLN
    Dim moveItem As Boolean
    Private listita As List(Of ListViewItem)
    Private selectedProducto As ListViewItem
	Dim product As New ProductoLN
	Dim total As Double



#Region "Eventos"

	Private Sub FrmGestionVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Cargar()
	End Sub

	Private Sub Cargar()
		lstProdDispo.Clear()
		total = 0.00
		lblTotal.Text = total.ToString("0.00")
		LlenarCboClientes()
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

	Private Sub CboCliente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectionChangeCommitted
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

			If ds.Tables(0).Rows(i)(9).ToString() <> "NULL" Or ds.Tables(0).Rows(i)(14).ToString() <> Nothing Then
				lblClienteTelefono.Text = ds.Tables(0).Rows(i)(9).ToString() + ds.Tables(0).Rows(i)(10).ToString()
			ElseIf ds.Tables(0).Rows(i)(11).ToString() <> "NULL" Or ds.Tables(0).Rows(i)(14).ToString() <> Nothing Then
				lblClienteTelefono.Text = ds.Tables(0).Rows(i)(11).ToString() + ds.Tables(0).Rows(i)(12).ToString()
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

		Dim listaDeVentas = New List(Of TipoDeVentasNE)
		For Each item As KeyValuePair(Of Integer, Integer) In DiccionarioDeStringYCantidad
			Dim product = ObtainProductInformation(item.Key)
			Dim venta = New TipoDeVentasNE
			venta.Cantidad = item.Value
			venta.ProductoId = item.Key
			venta.Precio = product.precio
			listaDeVentas.Add(venta)
			FrmComprobanteVenta.ListaVentas.Add(venta)
		Next

		ventasLN.Registrar(listaDeVentas, cboCliente.SelectedValue)
		MsgBox("Venta realizada con éxito", MsgBoxStyle.OkOnly, "Exito")
		Cargar()
		FrmComprobanteVenta.Show()


		ListView1.Clear()
		LlenarCboClientes()

	End Sub

	Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
		If MsgBox("Desea limpiar la lista de ventas?", MsgBoxStyle.YesNo, "Ventas") = MsgBoxResult.Yes Then
			ListView1.Clear()
			total = 0.0
			lblTotal.Text = total.ToString("0.00")
		End If
	End Sub

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

	Private Sub btnLimpiarFiltros_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltros.Click
		If MsgBox("Desea limpiar los filtros?", MsgBoxStyle.YesNo, "Filtros") = MsgBoxResult.No Then
			Return
		End If
		cboBusProveedor.SelectedValue = 0
		cboBusProveedor.SelectedItem = Nothing
		rbtEntreFechas.Checked = False
		rbtFechaExacta.Checked = False
		txtBusNombreProducto.Text = ""
		dtpFechaDesde.Value = Date.Now
		dtpFechaHasta.Value = Date.Now
	End Sub

	Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
		Search()
	End Sub

#End Region

#Region "Metodos"

	Public Sub Search()
		Dim parametros As Dictionary(Of String, String) = New Dictionary(Of String, String)
		If String.IsNullOrWhiteSpace(cboBusProveedor.SelectedValue) = False Then
			parametros.Add("ProveedorId", cboBusProveedor.SelectedValue)
		End If
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

	Public Function LlenarCboProveedores()
		Try
			Dim ds1 As DataSet
			ds1 = helpersLN.CargarCboTodosProveedores()
			cboBusProveedor.DataSource = ds1.Tables(0)
			cboBusProveedor.DisplayMember = "Nombre"
			cboBusProveedor.ValueMember = "id"
			cboBusProveedor.SelectedValue = 0
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return cboCliente.SelectedValue
		MessageBox.Show(cboCliente.SelectedValue)
	End Function

	Public Sub LlenarLvi(ByVal parametros As Dictionary(Of String, String))
		Dim ds2 As DataSet = helpersLN.CargarTodosProductos(parametros)
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

		lstProdDispo.LargeImageList = ImageList
		gboFiltros.Enabled = True
	End Sub

	Private Function ObtainProductInformation(ByVal id As Integer) As ProductosNE
        Dim producto = New ProductosNE
        Dim ds = product.CargarUnProducto(id)
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            producto.Id = ds.Tables(0).Rows(i).Item(0)
            producto.precio = ds.Tables(0).Rows(i).Item(4)
        Next
        Return producto
    End Function

	Private Function CargarDatosComprobante()
		Dim CompVentasNE As New ComprobanteVentasNE With {
			.Comprobante = helpersUI.AgregarNumerosComprobante(ventasLN.ObtenerUltimaVenta)
		}
		Return CompVentasNE
	End Function

	Private Sub ListView1_CausesValidationChanged(sender As Object, e As EventArgs) Handles ListView1.CausesValidationChanged
		MsgBox("cambio", MsgBoxStyle.OkOnly, "Error")
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
		FrmGestionProducto.ShowDialog()
	End Sub

	Private Sub FrmGestionArmado_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
		If FrmGestionProducto.modificado Then
			Search()
		End If
		If FrmGestionCliente.modificado Then
			LlenarCboClientes()
		End If
	End Sub

	Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
		FrmGestionCliente.ShowDialog()
	End Sub


#End Region

End Class