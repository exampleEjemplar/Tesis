Imports System.Drawing

Imports ClaseLn
Imports ClaseNe
Imports System.IO
Imports System.Windows.Forms
Imports System.Globalization

Public Class FrmGestionProducto

	Private productometodo As New ProductoLN
	Private conversionmetodo As New ConversionLN
	Private proveedoresLN As New ProveedoresLN
	Private pro As New ProductosNE
	Dim helpersLN As New HelpersLN
	Dim helpersUi As New HelpersUI
	Public modificado As Boolean = False
	Dim IMAGEN As String
	Dim busqcod As String
	Dim busqprod As String
	Dim paginaInicial As Integer = 0
	Dim filas As Integer = helpersLN.ContarFilas("Productos").Tables(0).Rows(0)(0)
	Dim totalEstaPagina As Integer = If(filas < paginaInicial + 20, filas, paginaInicial + 20)
	Public primerOrder As Boolean = True
	Public OrderBy As New List(Of Tuple(Of Integer, String, Integer)) 'Index, nombrevista, nombre base, prioridad

	'Metodo que selecciona una imagen y la carga en un PictureBox'
	Sub cargarImagen()


		Try
			Me.OpenFileDialog1.ShowDialog()
			If Me.OpenFileDialog1.FileName <> "" Then

				IMAGEN = OpenFileDialog1.FileName
				Dim largo As Double = IMAGEN.Length
				Dim imagen2 As String
				imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN), largo - 2, largo))
				If imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpg" And imagen2 <> "jpeg" And imagen2 <> "GIF" And imagen2 <> "BMP" And imagen2 <> "JPG" And imagen2 <> "JPEG" Then
					imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN), largo - 3, largo))
					If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then
						MsgBox("Formato no valido") : Exit Sub
						If imagen2 <> "log1" Then Exit Sub
					End If

				End If
				PBfoto.Load(IMAGEN)
			End If

		Catch ex As Exception

		End Try


	End Sub

	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btncargarimagen.Click
		cargarImagen()

	End Sub

	Public Function ValidarDatos()
#Region "imagen"
		Dim ms As New IO.MemoryStream()
		If PBfoto.Image IsNot Nothing Then
			PBfoto.Image.Save(ms, PBfoto.Image.RawFormat)
			pro.foto = ms.GetBuffer
		Else
			MsgBox("Debe agregar una foto", MsgBoxStyle.Critical, "Producto")
			Return False
		End If
#End Region
#Region "nombre"
		If Not String.IsNullOrEmpty(TbNombreProducto.Text) Then
			pro.nombreprducto = helpersUi.NormalizarTexto(TbNombreProducto.Text)
		Else
			MsgBox("Debe agregar un Nombre", MsgBoxStyle.Critical, "Producto")
			Return False
		End If
#End Region
#Region "codigo de barra"
		If Not String.IsNullOrEmpty(tbCodBarra.Text) Then
			pro.CodBarra = tbCodBarra.Text
		Else
			MsgBox("Debe agregar una codigo de barra", MsgBoxStyle.Critical, "Producto")
			Return False
		End If
#End Region
#Region "Precio"
		If Not String.IsNullOrEmpty(TbPrecio.Text) Then
			Dim value As Decimal
			Dim newText = TbPrecio.Text.Replace(",", ".")
			If Not Decimal.TryParse(newText, value) Then
				MsgBox("Ingrese el precio en un formato correcto (123.00)", MsgBoxStyle.Critical, "Producto")
				Return False
			End If
			If value = 0 Then
				MsgBox("Ingrese el precio en un formato correcto (123.00)", MsgBoxStyle.Critical, "Producto")
				Return False
			End If
			pro.precio = newText.ToString()
		Else
			MsgBox("Debe agregar un precio", MsgBoxStyle.Critical, "Producto")
			Return False
		End If
#End Region
#Region "material"
		If Not String.IsNullOrEmpty(CmbMaterial.SelectedValue) Then
			pro.materialid = CmbMaterial.SelectedValue
		Else
			MsgBox("Debe seleccionar un Material", MsgBoxStyle.Critical, "Producto")
			Return False
		End If
#End Region
#Region "proveedor"
		If Not String.IsNullOrEmpty(cmbProveedor.SelectedValue) Then
			pro.proveedorId = cmbProveedor.SelectedValue
		Else
			MsgBox("Debe seleccionar un proveedor", MsgBoxStyle.Critical, "Producto")
			Return False
		End If
#End Region
#Region "Tipo producto"
		If Not String.IsNullOrEmpty(CmbTipoprodcuto.SelectedValue) Then
			pro.TipodeProductoId = CmbTipoprodcuto.SelectedValue
		Else
			MsgBox("Debe cargar un tipo de producto", MsgBoxStyle.Critical, "Producto")
			Return False
		End If
#End Region
#Region "categoria"
		If Not String.IsNullOrEmpty(CmbCategoria.SelectedValue) Then
			pro.categoriaId = CmbCategoria.SelectedValue
		Else
			MsgBox("Debe cargar una categoria", MsgBoxStyle.Critical, "Producto")
			Return False
		End If
#End Region
#Region "Utilidad"
		If Not String.IsNullOrEmpty(TbUtilidad.Text) Then
			Dim value As Decimal
			Dim newText = TbUtilidad.Text.Replace(",", ".")
			If Not Decimal.TryParse(newText, value) Then
				MsgBox("Ingrese la utilidad en un formato correcto (123.00)", MsgBoxStyle.Critical, "Producto")
				Return False
			End If
			If value = 0 Then
				MsgBox("Ingrese la utilidad  en un formato correcto (123.00)", MsgBoxStyle.Critical, "Producto")
				Return False
			End If
			pro.utilidad = newText
		Else
			MsgBox("Debe agregar una utilidad", MsgBoxStyle.Critical, "Producto")
			Return False
		End If
#End Region
		'Segun el tipo de producto, puede ser propio
		If rdpropios.Checked Then
			pro.StockODeTercero = 0

#Region "unidad de peso"
			If Not String.IsNullOrEmpty(cmbUnidad.SelectedValue) Then
				pro.Unidad = cmbUnidad.SelectedValue
			Else
				MsgBox("Debe agregar una unidad de peso", MsgBoxStyle.Critical, "Producto")
				Return False
			End If
#End Region

#Region "Peso"
			If Not String.IsNullOrEmpty(TbPeso.Text) Then
				pro.peso = TbPeso.Text
			Else
				MsgBox("Debe cargar un peso", MsgBoxStyle.Critical, "Producto")
				Return False
			End If
#End Region
#Region "color"
			If Not String.IsNullOrEmpty(TbColor.Text) Then
				pro.color = helpersUi.NormalizarTexto(TbColor.Text)
			Else
				MsgBox("Debe cargar un color", MsgBoxStyle.Critical, "Producto")
				Return False
			End If
#End Region
#Region "stockmin"
			If Not String.IsNullOrEmpty(TbStockmin.Text) Then
				pro.stockmin = TbStockmin.Text
			Else
				MsgBox("Debe cargar un stock minimo", MsgBoxStyle.Critical, "Producto")
				Return False
			End If
#End Region
#Region "stockmax"
			If Not String.IsNullOrEmpty(TbStockMax.Text) Then
				pro.stockmax = TbStockMax.Text
			Else
				MsgBox("Debe cargar un stock maximo", MsgBoxStyle.Critical, "Producto")
				Return False
			End If
#End Region

			' O de terceros
		Else
			pro.Unidad = 4
			pro.StockODeTercero = 1
			pro.peso = 1
			pro.tamaño = 0
			pro.color = ""
			pro.stockmin = 0
			pro.stockmax = 0
		End If
		pro.tamaño = 0
		pro.Problema = ""
		pro.EsReparacion = "N"
		pro.EsServicio = "N"
		Return True
	End Function

	Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
		Try
			If ValidarDatos() = False Then
				Return
			End If
			productometodo.Grabarproductos(pro)
			Dgvproductosset()
			cereacampos()
			bloquearcampos()
			btnBuscar.Enabled = True
			btnmodificar.Enabled = True
			btnNuevo.Enabled = True
			MsgBox("Producto Agregado", MsgBoxStyle.OkOnly, "Producto")
			modificado = True
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error: Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Exit Sub
		End Try
	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles Button2.Click
		primerOrder = True
		modificado = True
		Me.Close()
	End Sub

	Private Sub FrmGestionProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LlenarCboOrden()
		InicializarOrderBy()
		DataGridView1.RowTemplate.Height = 30
		busqcod = ""
		busqprod = ""
		btnmodificar.Visible = False
		btnguardarmodificacion.Visible = False
		'bbusqueda.Visible = False
		bloquearcampos()
		LlenarCMBTipo()
		LlenarCMBMaterial()
		LlenarCMBproveedor()
		LlenarCMBUnidadDePeso()
		LlenarCMBCategoria()
		Dgvproductosset()
		btnmodificar.Enabled = False
		modificado = False

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
		lblPrioridad1.Text = OrderBy.FirstOrDefault(Function(x) x.Item1 = 1).Item2.Replace("'", "")
		lblPrioridad2.Visible = False
		lblPrioridad3.Visible = False
	End Sub

	Public Sub LlenarCboOrden()
		cboOrden.DataSource = {"asc", "desc"}
		cboOrden.SelectedItem = "desc"
	End Sub

	Public Function Dgvproductosset()
		Try
			Dim dsa1 As DataTable
			dsa1 = productometodo.CargaGrillaproductossinbusqueda(txtBusCodigo.Text, txtBusNombreProd.Text, OrderBy, cboOrden.SelectedItem, "N", paginaInicial)

			If primerOrder Then
				primerOrder = False
				For i = 0 To dsa1.Columns.Count - 1
					If dsa1.Columns(i).ColumnName = "id" Or dsa1.Columns(i).ColumnName = "nombre1" Or dsa1.Columns(i).ColumnName = "Nombre2" Or dsa1.Columns(i).ColumnName = "Nombre3" Or dsa1.Columns(i).ColumnName = "foto" Or dsa1.Columns(i).ColumnName = "TipoProductoID" Or dsa1.Columns(i).ColumnName = "problema" Or dsa1.Columns(i).ColumnName = "UnidadDePeso" Then
						Continue For
					End If
					If dsa1.Columns(i).ColumnName = "Fecha de Alta" Then
						chbListaParaOrdenar.Items.Add(dsa1.Columns(i).ColumnName, CheckState.Checked)
						Continue For
					End If
					chbListaParaOrdenar.Items.Add(dsa1.Columns(i).ColumnName)
				Next
				chbListaParaOrdenar.SetItemChecked(15, True)
			End If

			DataGridView1.DataSource = dsa1
			DataGridView1.Columns(0).HeaderText = "Código"
			DataGridView1.Columns(1).HeaderText = "Código Barras"
			DataGridView1.Columns(2).HeaderText = "Nombre de Producto"
			DataGridView1.Columns(3).HeaderText = "Categoría de Producto"
			DataGridView1.Columns(4).HeaderText = "Tipo de Produco"
			DataGridView1.Columns(5).HeaderText = "Material de Producto"
			DataGridView1.Columns(6).HeaderText = "Precio Público"
			For i = 7 To 21
				DataGridView1.Columns(i).Visible = False
			Next
			DataGridView1.Columns("problema").Visible = False
			DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
			DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
			DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
			DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
			DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
			DataGridView1.Sort(DataGridView1.Columns(2), System.ComponentModel.ListSortDirection.Ascending)
			DataGridView1.AllowUserToAddRows = False
			DataGridView1.AllowUserToDeleteRows = False
			For X = 0 To DataGridView1.Rows.Count - 1
				If DataGridView1.Rows(X).Cells(1).Value = Nothing Then
					DataGridView1.Rows.Remove(DataGridView1.Rows(X))
				End If
			Next
			If paginaInicial <= 0 Then
				btnAnterior.Enabled = False
			Else
				btnAnterior.Enabled = True
			End If
			If filas <= (paginaInicial + 20) Then
				btnSiguiente.Enabled = False
			Else
				btnSiguiente.Enabled = True
			End If
			ConfigurarPaginado()
			Return dsa1
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error: Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Exit Function
		End Try
	End Function

	Sub ConfigurarPaginado()
		filas = helpersLN.ContarFilas("Productos").Tables(0).Rows(0)(0)
		totalEstaPagina = If(filas < paginaInicial + 20, filas, paginaInicial + 20)
		lblPagina.Text = "De " + (paginaInicial + 1).ToString() + " a " + totalEstaPagina.ToString() + " productos. " + filas.ToString() + " en total."
	End Sub

	'Public Function DgvproductosBusq() As DataTable
	'	Try
	'		Dim dsa1 As DataTable
	'		'dsa1 = productometodo.CargaGrillaProductos(parametros) 'Si parametros esta vacio, busca todos los clientes en la bd
	'		dsa1 = productometodo.CargaGrillaproductossinbusqueda(txtBusCodigo.Text, txtBusNombreProd.Text, OrderBy, "", paginaInicial)
	'		DataGridView1.DataSource = dsa1

	'		DataGridView1.AllowUserToAddRows = False
	'		DataGridView1.AllowUserToDeleteRows = False
	'		For X = 0 To DataGridView1.Rows.Count - 1
	'			If DataGridView1.Rows(X).Cells(1).Value = Nothing Then
	'				DataGridView1.Rows.Remove(DataGridView1.Rows(X))
	'			End If
	'			Return dsa1
	'		Next

	'	Catch ex As Exception
	'		MessageBox.Show(ex.Message, "Error: Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)

	'	End Try


	'End Function

	Private Sub DataGridView1_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridView1.DoubleClick
		'productometodo.Cargargrilladobleclick()
		If (DataGridView1.Item(21, DataGridView1.CurrentRow.Index).Value) = 0 Then
			rdpropios.Checked = True
			gboStock.Enabled = False
			gboCaracteristicas.Enabled = False
		Else
			rdterceros.Checked = True
		End If
		tbCodigo.Text = (DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value)
		tbCodBarra.Text = (DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)

		Dim ms As MemoryStream = New MemoryStream()

		Dim img As Byte() = CType((DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value), Byte())


		If img Is Nothing Then
			MessageBox.Show("Imagen no encontrada en la base de datos")
		End If

		ms.Write(img, 0, img.GetUpperBound(0) + 1)
		Dim imgImagen As System.Drawing.Image = System.Drawing.Image.FromStream(ms)

		PBfoto.Image = imgImagen
		TbNombreProducto.Text = (DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value)
		TbPrecio.Text = (DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value)
		TbUtilidad.Text = (DataGridView1.Item(11, DataGridView1.CurrentRow.Index).Value)
		CmbMaterial.SelectedValue = (DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value)
		TbPeso.Text = (DataGridView1.Item(12, DataGridView1.CurrentRow.Index).Value)
		TbColor.Text = (DataGridView1.Item(14, DataGridView1.CurrentRow.Index).Value)
		cmbProveedor.SelectedValue = (DataGridView1.Item(15, DataGridView1.CurrentRow.Index).Value)
		TbStockmin.Text = (DataGridView1.Item(16, DataGridView1.CurrentRow.Index).Value)
		TbStockMax.Text = (DataGridView1.Item(17, DataGridView1.CurrentRow.Index).Value)
		CmbTipoprodcuto.SelectedValue = (DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value)
		cmbUnidad.SelectedValue = (DataGridView1.Item(19, DataGridView1.CurrentRow.Index).Value)
		CmbCategoria.SelectedValue = (DataGridView1.Item(20, DataGridView1.CurrentRow.Index).Value)
		btnBuscar.Enabled = False
		btnNuevo.Enabled = False
		btnGuardar.Visible = False
		btnguardarmodificacion.Visible = False
		btnmodificar.Enabled = True
		bloquearcampos()
		btncargarimagen.Enabled = False
		Habilitarcampos()
		btnguardarmodificacion.Visible = True
		btncargarimagen.Enabled = True

	End Sub

	Public Sub LlenarCMBTipo()
		Try
			Dim ds1 As DataSet
			ds1 = productometodo.CargarCMBTipo()
			CmbTipoprodcuto.DataSource = ds1.Tables(0)
			CmbTipoprodcuto.DisplayMember = "nombre"
			CmbTipoprodcuto.ValueMember = "id"
			CmbTipoprodcuto.SelectedValue = 0


		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

	Public Function LlenarCMBMaterial()
		Try
			Dim ds1 As DataSet
			ds1 = productometodo.CargarCMBmaterial()
			CmbMaterial.DataSource = ds1.Tables(0)
			CmbMaterial.DisplayMember = "nombre"
			CmbMaterial.ValueMember = "id"
			CmbMaterial.SelectedValue = 0

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return CmbMaterial.SelectedValue
	End Function

	Public Function LlenarCMBproveedor()
		Try
			Dim ds1 As DataSet
			ds1 = helpersLN.CargarCboTodosProveedores("False")
			cmbProveedor.DataSource = ds1.Tables(0)
			cmbProveedor.DisplayMember = "Nombre"
			cmbProveedor.ValueMember = "id"
			cmbProveedor.SelectedValue = 0

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return cmbProveedor.SelectedValue
	End Function

	Public Function LlenarCMBCategoria()
		Try
			Dim ds1 As DataSet
			ds1 = productometodo.LlenarCMBCategoria
			CmbCategoria.DataSource = ds1.Tables(0)
			CmbCategoria.DisplayMember = "nombre"
			CmbCategoria.ValueMember = "id"
			CmbCategoria.SelectedValue = 0


		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return CmbCategoria.SelectedValue
	End Function

	Public Function LlenarCMBUnidadDePeso()
		Try
			Dim ds1 As DataSet
			ds1 = helpersLN.LlenarUnidadDePeso()
			cmbUnidad.DataSource = ds1.Tables(0)
			cmbUnidad.DisplayMember = "nombre"
			cmbUnidad.ValueMember = "id"
			cmbUnidad.SelectedValue = 0


		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Function

	Public Sub cargarcodigo()
		productometodo.ConsultarCodigo()
		tbCodigo.Text = productometodo.QProducto


	End Sub


	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Dgvproductosset()
		'gbbusqueda.Visible = False
	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		'cargarcodigo()
		'Habilitarcampos()
		rdpropios.Enabled = True
		rdterceros.Enabled = True
		btnBuscar.Enabled = False
		btnmodificar.Enabled = False
		btnNuevo.Enabled = False

	End Sub

	Public Sub bloquearcampos()
		tbCodBarra.Enabled = False
		tbCodigo.Enabled = False
		TbColor.Enabled = False
		TbNombreProducto.Enabled = False
		TbPeso.Enabled = False
		TbPrecio.Enabled = False
		TbStockMax.Enabled = False
		TbStockmin.Enabled = False
		cmbUnidad.Enabled = False
		TbUtilidad.Enabled = False
		cmbProveedor.Enabled = False
		CmbTipoprodcuto.Enabled = False
		CmbCategoria.Enabled = False
		CmbMaterial.Enabled = False
		btncargarimagen.Enabled = False
		rdpropios.Enabled = False
		rdterceros.Enabled = False
		btnNuevaCategoria.Enabled = False
		btnNuevoMaterial.Enabled = False
		btnNuevoTipo.Enabled = False
		btnGuardar.Enabled = False
		Label19.Enabled = False
		Label20.Enabled = False
		Label21.Enabled = False
		Label22.Enabled = False
		Label23.Enabled = False
		Label24.Enabled = False
		Label25.Enabled = False
		Label26.Enabled = False
		Label27.Enabled = False
		Label28.Enabled = False
		Label29.Enabled = False
		Label30.Enabled = False
		Label33.Enabled = False
		Label32.Enabled = False


	End Sub

	Public Sub Habilitarcampos()
		tbCodBarra.Enabled = True
		TbColor.Enabled = True
		TbNombreProducto.Enabled = True
		TbPeso.Enabled = True
		TbPrecio.Enabled = True
		TbStockMax.Enabled = True
		TbStockmin.Enabled = True
		cmbUnidad.Enabled = True
		TbUtilidad.Enabled = True
		cmbProveedor.Enabled = True
		CmbTipoprodcuto.Enabled = True
		CmbCategoria.Enabled = True
		CmbMaterial.Enabled = True
		btncargarimagen.Enabled = True

		btnNuevaCategoria.Enabled = True
		btnNuevoMaterial.Enabled = True
		btnNuevoTipo.Enabled = True

		btnGuardar.Enabled = True
		Label19.Enabled = True
		Label20.Enabled = True
		Label21.Enabled = True
		Label22.Enabled = True
		Label23.Enabled = True
		Label24.Enabled = True
		Label25.Enabled = True
		Label26.Enabled = True
		Label27.Enabled = True
		Label28.Enabled = True
		Label29.Enabled = True
		Label30.Enabled = True
		Label33.Enabled = True
		Label32.Enabled = True


	End Sub

	Public Sub cereacampos()
		tbCodigo.Text = ""
		tbCodBarra.Text = ""
		TbColor.Text = ""
		TbNombreProducto.Text = ""
		TbPeso.Text = ""
		TbPrecio.Text = ""
		TbStockMax.Text = ""
		TbStockmin.Text = ""
		cmbUnidad.Text = ""
		TbUtilidad.Text = ""
		cmbProveedor.SelectedValue = 0
		CmbTipoprodcuto.SelectedValue = 0
		CmbCategoria.SelectedValue = 0
		CmbMaterial.SelectedValue = 0
		PBfoto.Image = Nothing
		rdpropios.Checked = Nothing
		rdterceros.Checked = Nothing

	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
		bloquearcampos()
		cereacampos()
		btnBuscar.Enabled = True
		btnmodificar.Enabled = False
		btnNuevo.Enabled = True
		btnguardarmodificacion.Visible = False
		btnGuardar.Visible = True

	End Sub

	Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
		If Dgvproductosset().Rows.Count = 0 Then
			MsgBox("La búsqueda no arrojo resultados", MsgBoxStyle.Critical, "Error")
		End If
		ConfigurarPaginado()
	End Sub

	Private Sub btnguardarmodificacion_Click(sender As Object, e As EventArgs) Handles btnguardarmodificacion.Click
		If ValidarDatos() = False Then
			Return
		End If

		'pro.EsServicio = proveedoresLN.ConsultaModificacion(cmbProveedor.SelectedValue).Tables(0).Rows(0)(22).ToString()

		'If rdpropios.Checked Then

		'	pro.Id = tbCodigo.Text
		'	Dim ms As New IO.MemoryStream()
		'	PBfoto.Image.Save(ms, PBfoto.Image.RawFormat)
		'	pro.nombreprducto = TbNombreProducto.Text
		'	pro.CodBarra = tbCodBarra.Text
		'	pro.foto = ms.GetBuffer
		'	pro.precio = TbPrecio.Text
		'	pro.utilidad = TbUtilidad.Text
		'	pro.materialid = CmbMaterial.SelectedValue
		'	pro.peso = 1
		'	pro.tamaño = TbTamaño.Text
		'	pro.color = TbColor.Text
		'	pro.proveedorId = cmbProveedor.SelectedValue
		'	pro.stockmin = TbStockmin.Text
		'	pro.stockmax = TbStockMax.Text
		'	pro.TipodeProductoId = CmbTipoprodcuto.SelectedValue
		'	pro.Unidad = cmbUnidad.SelectedValue
		'	pro.categoriaId = CmbCategoria.SelectedValue
		'	pro.StockODeTercero = 0
		productometodo.modificarproductos(pro)
		cereacampos()
		bloquearcampos()
		btnBuscar.Enabled = True
		btnmodificar.Enabled = True
		btnNuevo.Enabled = True
		'Else

		'	pro.Id = tbCodigo.Text
		'	Dim ms As New IO.MemoryStream()
		'	PBfoto.Image.Save(ms, PBfoto.Image.RawFormat)
		'	pro.nombreprducto = TbNombreProducto.Text
		'	pro.CodBarra = tbCodBarra.Text
		'	pro.foto = ms.GetBuffer
		'	pro.precio = TbPrecio.Text
		'	pro.utilidad = TbUtilidad.Text
		'	pro.materialid = CmbMaterial.SelectedValue
		'	pro.peso = 1
		'	pro.tamaño = TbTamaño.Text
		'	pro.color = TbColor.Text
		'	pro.proveedorId = cmbProveedor.SelectedValue
		'	pro.stockmin = TbStockmin.Text
		'	pro.stockmax = TbStockMax.Text
		'	pro.TipodeProductoId = CmbTipoprodcuto.SelectedValue
		'	pro.Unidad = cmbUnidad.SelectedValue
		'	pro.categoriaId = CmbCategoria.SelectedValue
		'	pro.StockODeTercero = 1

		btnGuardar.Visible = True
		btnguardarmodificacion.Visible = False
		btnmodificar.Enabled = False
		Dgvproductosset()
		modificado = True
		MsgBox("Producto Modificado", MsgBoxStyle.OkOnly, "Producto")
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevaCategoria.Click
		FrmGestionCategorías.ShowDialog()
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnNuevoTipo.Click
		FrmGestionTipoDeProducto.ShowDialog()
	End Sub

	Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles btnNuevoMaterial.Click
		FrmGestionMaterial.ShowDialog()
	End Sub

	Private Sub FrmGestionProducto_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
		If FrmGestionMaterial.modificado Then
			LlenarCMBMaterial()
			FrmGestionMaterial.modificado = False
		End If
		If FrmGestionTipoDeProducto.modificado Then
			LlenarCMBTipo()
			FrmGestionTipoDeProducto.modificado = False
		End If
		If FrmGestionCategorías.modificado Then
			LlenarCMBCategoria()
			FrmGestionCategorías.modificado = False
		End If
		If FrmGestionProveedores.modificado Then
			LlenarCMBproveedor()
			FrmGestionProveedores.modificado = False
		End If
	End Sub

	Private Sub rdpropios_CheckedChanged(sender As Object, e As EventArgs) Handles rdpropios.Click
		'PROPIOS
		Habilitarcampos()
		rdpropios.Enabled = False
		rdterceros.Enabled = False
	End Sub

	Private Sub rdterceros_CheckedChanged(sender As Object, e As EventArgs) Handles rdterceros.Click
		'TERCEROS
		CmbCategoria.Enabled = True
		CmbTipoprodcuto.Enabled = True
		CmbMaterial.Enabled = True
		cmbProveedor.Enabled = True
		rdpropios.Enabled = False
		rdterceros.Enabled = False
		TbPrecio.Enabled = True
		TbUtilidad.Enabled = True
		btnNuevaCategoria.Enabled = True
		btnNuevoMaterial.Enabled = True
		btnNuevoTipo.Enabled = True
		btnGuardar.Enabled = True
		TbNombreProducto.Enabled = True
		tbCodBarra.Enabled = True
		btncargarimagen.Enabled = True
		Label19.Enabled = True
		Label20.Enabled = True
		Label21.Enabled = True
		Label22.Enabled = True
		Label23.Enabled = True
		Label24.Enabled = True
		Label25.Enabled = True
		Label26.Enabled = True
		Label27.Enabled = True
		Label28.Enabled = True
		Label29.Enabled = True
		Label30.Enabled = True
		Label33.Enabled = True
		Label32.Enabled = True
	End Sub

	Private Sub BtnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
		FrmGestionProveedores.ShowDialog()

	End Sub

	Private Sub BtnModificarPrecios_Click(sender As Object, e As EventArgs) Handles btnModificarPrecios.Click
		FrmModificarPrecioProducto.ShowDialog()
	End Sub

	Private Sub gbbusqueda_Enter(sender As Object, e As EventArgs) Handles gbbusqueda.Enter

	End Sub
	Private Const CP_NOCLOSE_BUTTON As Integer = &H200
	Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
		Get
			Dim myCp As CreateParams = MyBase.CreateParams
			myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
			Return myCp
		End Get
	End Property

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
		paginaInicial -= 20
		ConfigurarPaginado()
		Dgvproductosset()
	End Sub

	Private Sub Button_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
		paginaInicial += 20
		ConfigurarPaginado()
		Dgvproductosset()
	End Sub
End Class