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

	Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
		Try

#Region "imagen"
			Dim ms As New IO.MemoryStream()
			If PBfoto.Image IsNot Nothing Then
				PBfoto.Image.Save(ms, PBfoto.Image.RawFormat)
				pro.foto = ms.GetBuffer
			Else
				MsgBox("Debe agregar una foto", MsgBoxStyle.Critical, "Producto")
				Return
			End If
#End Region
#Region "nombre"
			If Not String.IsNullOrEmpty(TbNombreProducto.Text) Then
				pro.nombreprducto = helpersUi.NormalizarTexto(TbNombreProducto.Text)
			Else
				MsgBox("Debe agregar un Nombre", MsgBoxStyle.Critical, "Producto")
				Return
			End If
#End Region
#Region "codigo de barra"
			If Not String.IsNullOrEmpty(tbCodBarra.Text) Then
				pro.CodBarra = tbCodBarra.Text
			Else
				MsgBox("Debe agregar una codigo de barra", MsgBoxStyle.Critical, "Producto")
				Return
			End If
#End Region
#Region "Precio"
			If Not String.IsNullOrEmpty(TbPrecio.Text) Then
				Dim value As Decimal
				Dim newText = TbPrecio.Text.Replace(",", ".")
				If Not Decimal.TryParse(newText, value) Then
					MsgBox("Ingrese el precio en un formato correcto (123.00)", MsgBoxStyle.Critical, "Producto")
					Return
				End If
				pro.precio = newText.ToString()
			Else
				MsgBox("Debe agregar un precio", MsgBoxStyle.Critical, "Producto")
				Return
			End If
#End Region
#Region "material"
			If Not String.IsNullOrEmpty(CmbMaterial.SelectedValue) Then
				pro.materialid = CmbMaterial.SelectedValue
			Else
				MsgBox("Debe seleccionar un Material", MsgBoxStyle.Critical, "Producto")
				Return
			End If
#End Region
#Region "proveedor"
			If Not String.IsNullOrEmpty(cmbProveedor.SelectedValue) Then
				pro.proveedorId = cmbProveedor.SelectedValue
			Else
				MsgBox("Debe seleccionar un proveedor", MsgBoxStyle.Critical, "Producto")
				Return
			End If
#End Region
#Region "Tipo producto"
			If Not String.IsNullOrEmpty(CmbTipoprodcuto.SelectedValue) Then
				pro.TipodeProductoId = CmbTipoprodcuto.SelectedValue
			Else
				MsgBox("Debe cargar un tipo de producto", MsgBoxStyle.Critical, "Producto")
				Return
			End If
#End Region
#Region "categoria"
			If Not String.IsNullOrEmpty(CmbCategoria.SelectedValue) Then
				pro.categoriaId = CmbCategoria.SelectedValue
			Else
				MsgBox("Debe cargar una categoria", MsgBoxStyle.Critical, "Producto")
				Return
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
					Return
				End If
#End Region
#Region "Utilidad"
				If Not String.IsNullOrEmpty(TbUtilidad.Text) Then
					pro.utilidad = TbUtilidad.Text
				Else
					MsgBox("Debe agregar una utilidad", MsgBoxStyle.Critical, "Producto")
					Return
				End If
#End Region
#Region "Peso"
				If Not String.IsNullOrEmpty(TbPeso.Text) Then
					pro.peso = TbPeso.Text
				Else
					MsgBox("Debe cargar un peso", MsgBoxStyle.Critical, "Producto")
					Return
				End If
#End Region
#Region "tamaño"
				If Not String.IsNullOrEmpty(TbTamaño.Text) Then
					pro.tamaño = TbTamaño.Text
				Else
					MsgBox("Debe seleccionar un tamaño", MsgBoxStyle.Critical, "Producto")
					Return
				End If
#End Region
#Region "color"
				If Not String.IsNullOrEmpty(TbColor.Text) Then
					pro.color = helpersUi.NormalizarTexto(TbColor.Text)
				Else
					MsgBox("Debe cargar un color", MsgBoxStyle.Critical, "Producto")
					Return
				End If
#End Region
#Region "stockmin"
				If Not String.IsNullOrEmpty(TbStockmin.Text) Then
					pro.stockmin = TbStockmin.Text
				Else
					MsgBox("Debe cargar un stock minimo", MsgBoxStyle.Critical, "Producto")
					Return
				End If
#End Region
#Region "stockmax"
				If Not String.IsNullOrEmpty(TbStockMax.Text) Then
					pro.stockmax = TbStockMax.Text
				Else
					MsgBox("Debe cargar un stock maximo", MsgBoxStyle.Critical, "Producto")
					Return
				End If
#End Region

				' O de terceros
			Else
				pro.Unidad = 4
				pro.StockODeTercero = 1
				pro.utilidad = 0
				pro.peso = 1
				pro.tamaño = 0
				pro.color = ""
				pro.stockmin = 0
				pro.stockmax = 0

				'If Not String.IsNullOrEmpty(TbUtilidad.Text) Then
				'	pro.utilidad = TbUtilidad.Text
				'Else
				'End If

				'If Not String.IsNullOrEmpty(TbPeso.Text) Then
				'	pro.peso = TbPeso.Text
				'Else
				'End If

				'If Not String.IsNullOrEmpty(TbTamaño.Text) Then
				'	pro.tamaño = TbTamaño.Text
				'Else
				'End If
				'If Not String.IsNullOrEmpty(TbColor.Text) Then
				'	pro.color = TbColor.Text
				'Else
				'End If

				'If Not String.IsNullOrEmpty(TbStockmin.Text) Then
				'	pro.stockmin = TbStockmin.Text
				'Else
				'End If
				'If Not String.IsNullOrEmpty(TbStockMax.Text) Then
				'	pro.stockmax = TbStockMax.Text
				'Else
				'End If

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

	Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
		Habilitarcampos()

		btnguardarmodificacion.Visible = True
		btncargarimagen.Enabled = True
	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles Button2.Click
		modificado = True
		Me.Close()
	End Sub

	Private Sub FrmGestionProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		DataGridView1.RowTemplate.Height = 30
		busqcod = ""
		busqprod = ""
		btnguardarmodificacion.Visible = False
		gbbusqueda.Visible = False
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

	Public Sub Dgvproductosset()
		Try


			Dim dsa1 As DataTable
			dsa1 = productometodo.CargaGrillaproductossinbusqueda(busqcod, busqprod) 'Si parametros esta vacio, busca todos los clientes en la bd
			DataGridView1.DataSource = dsa1
			DataGridView1.Columns(0).HeaderText = "Código"
			DataGridView1.Columns(1).HeaderText = "Código Barras"
			DataGridView1.Columns(2).HeaderText = "Nombre de Producto"
			DataGridView1.Columns(3).HeaderText = "Categoría de Producto"
			DataGridView1.Columns(4).HeaderText = "Tipo de Produco"
			DataGridView1.Columns(5).HeaderText = "Material de Producto"
            DataGridView1.Columns(6).HeaderText = "Precio Público"
            DataGridView1.Columns(7).Visible = False
			DataGridView1.Columns(8).Visible = False
			DataGridView1.Columns(9).Visible = False
			DataGridView1.Columns(10).Visible = False
			DataGridView1.Columns(11).Visible = False
			DataGridView1.Columns(12).Visible = False
			DataGridView1.Columns(13).Visible = False
			DataGridView1.Columns(14).Visible = False
			DataGridView1.Columns(15).Visible = False
			DataGridView1.Columns(16).Visible = False
			DataGridView1.Columns(17).Visible = False
			DataGridView1.Columns(18).Visible = False
			DataGridView1.Columns(19).Visible = False
			DataGridView1.Columns(20).Visible = False
			DataGridView1.Columns(21).Visible = False
			DataGridView1.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DataGridView1.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridView1.Sort(DataGridView1.Columns(2), System.ComponentModel.ListSortDirection.Ascending)

			DataGridView1.AllowUserToAddRows = False
			DataGridView1.AllowUserToDeleteRows = False
			For X = 0 To DataGridView1.Rows.Count - 1
				If DataGridView1.Rows(X).Cells(1).Value = Nothing Then
					DataGridView1.Rows.Remove(DataGridView1.Rows(X))
				End If
			Next

		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error: Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Exit Sub
		End Try
	End Sub

	Public Sub DgvproductosBusq()
		Try
			Dim dsa1 As DataTable
			dsa1 = productometodo.CargaGrillaproductosconbusqueda(busqcod, busqprod) 'Si parametros esta vacio, busca todos los clientes en la bd
			DataGridView1.DataSource = dsa1
			DataGridView1.AllowUserToAddRows = False
			DataGridView1.AllowUserToDeleteRows = False
			For X = 0 To DataGridView1.Rows.Count - 1
				If DataGridView1.Rows(X).Cells(1).Value = Nothing Then
					DataGridView1.Rows.Remove(DataGridView1.Rows(X))
				End If
			Next

		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error: Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Exit Sub
		End Try


	End Sub

	Private Sub DataGridView1_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridView1.DoubleClick
		productometodo.Cargargrilladobleclick()
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
		TbTamaño.Text = (DataGridView1.Item(13, DataGridView1.CurrentRow.Index).Value)
		TbColor.Text = (DataGridView1.Item(14, DataGridView1.CurrentRow.Index).Value)
		cmbProveedor.SelectedValue = (DataGridView1.Item(15, DataGridView1.CurrentRow.Index).Value)
		TbStockmin.Text = (DataGridView1.Item(16, DataGridView1.CurrentRow.Index).Value)
		TbStockMax.Text = (DataGridView1.Item(17, DataGridView1.CurrentRow.Index).Value)
		CmbTipoprodcuto.SelectedValue = (DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value)
		cmbUnidad.Text = (DataGridView1.Item(19, DataGridView1.CurrentRow.Index).Value)
		CmbCategoria.SelectedValue = (DataGridView1.Item(20, DataGridView1.CurrentRow.Index).Value)
		If (DataGridView1.Item(21, DataGridView1.CurrentRow.Index).Value) = 0 Then
			rdpropios.Checked = True
		Else
			rdterceros.Checked = True
		End If
		btnBuscar.Enabled = False
		btnNuevo.Enabled = False
		btnGuardar.Visible = False
		btnguardarmodificacion.Visible = False
		btnmodificar.Enabled = True
		bloquearcampos()
		btncargarimagen.Enabled = False


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

	Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

	End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		busqprod = txtBusNombreProd.Text.Trim
		busqcod = txtBusCodigo.Text.Trim
		DgvproductosBusq()

	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Dgvproductosset()
		gbbusqueda.Visible = False
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
		TbTamaño.Enabled = False
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

	End Sub

	Public Sub Habilitarcampos()
		tbCodBarra.Enabled = True
		TbColor.Enabled = True
		TbNombreProducto.Enabled = True
		TbPeso.Enabled = True
		TbPrecio.Enabled = True
		TbStockMax.Enabled = True
		TbStockmin.Enabled = True
		TbTamaño.Enabled = True
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

	End Sub

	Public Sub cereacampos()
		tbCodBarra.Text = ""
		TbColor.Text = ""
		TbNombreProducto.Text = ""
		TbPeso.Text = ""
		TbPrecio.Text = ""
		TbStockMax.Text = ""
		TbStockmin.Text = ""
		TbTamaño.Text = ""
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
		gbbusqueda.Visible = True

	End Sub

	Private Sub btnguardarmodificacion_Click(sender As Object, e As EventArgs) Handles btnguardarmodificacion.Click

		pro.EsServicio = proveedoresLN.ConsultaModificacion(cmbProveedor.SelectedValue).Tables(0).Rows(0)(22).ToString()

		If rdpropios.Checked Then

			pro.Id = tbCodigo.Text
			Dim ms As New IO.MemoryStream()
			PBfoto.Image.Save(ms, PBfoto.Image.RawFormat)
			pro.nombreprducto = TbNombreProducto.Text
			pro.CodBarra = tbCodBarra.Text
			pro.foto = ms.GetBuffer
			pro.precio = TbPrecio.Text
			pro.utilidad = TbUtilidad.Text
			pro.materialid = CmbMaterial.SelectedValue
			pro.peso = 1
			pro.tamaño = TbTamaño.Text
			pro.color = TbColor.Text
			pro.proveedorId = cmbProveedor.SelectedValue
			pro.stockmin = TbStockmin.Text
			pro.stockmax = TbStockMax.Text
			pro.TipodeProductoId = CmbTipoprodcuto.SelectedValue
			pro.Unidad = cmbUnidad.SelectedValue
			pro.categoriaId = CmbCategoria.SelectedValue
			pro.StockODeTercero = 0
			productometodo.modificarproductos(pro)
			cereacampos()
			bloquearcampos()
			btnBuscar.Enabled = True
			btnmodificar.Enabled = True
			btnNuevo.Enabled = True
		Else

			pro.Id = tbCodigo.Text
			Dim ms As New IO.MemoryStream()
			PBfoto.Image.Save(ms, PBfoto.Image.RawFormat)
			pro.nombreprducto = TbNombreProducto.Text
			pro.CodBarra = tbCodBarra.Text
			pro.foto = ms.GetBuffer
			pro.precio = TbPrecio.Text
			pro.utilidad = TbUtilidad.Text
			pro.materialid = CmbMaterial.SelectedValue
			pro.peso = 1
			pro.tamaño = TbTamaño.Text
			pro.color = TbColor.Text
			pro.proveedorId = cmbProveedor.SelectedValue
			pro.stockmin = TbStockmin.Text
			pro.stockmax = TbStockMax.Text
			pro.TipodeProductoId = CmbTipoprodcuto.SelectedValue
			pro.Unidad = cmbUnidad.SelectedValue
			pro.categoriaId = CmbCategoria.SelectedValue
			pro.StockODeTercero = 1
			productometodo.modificarproductos(pro)
			cereacampos()
			bloquearcampos()
			btnBuscar.Enabled = True
			btnmodificar.Enabled = True

		End If
		btnGuardar.Visible = True
		btnguardarmodificacion.Visible = False
		btnmodificar.Enabled = False
		Dgvproductosset()
		modificado = True
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
		btnNuevaCategoria.Enabled = True
		btnNuevoMaterial.Enabled = True
		btnNuevoTipo.Enabled = True
		btnGuardar.Enabled = True
		TbNombreProducto.Enabled = True
		tbCodBarra.Enabled = True
		btncargarimagen.Enabled = True
	End Sub

	Private Sub BtnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
		FrmGestionProveedores.ShowDialog()

	End Sub

	Private Sub BtnModificarPrecios_Click(sender As Object, e As EventArgs) Handles btnModificarPrecios.Click
		FrmModificarPrecioProducto.ShowDialog()
	End Sub
End Class