Imports System.Drawing

Imports ClaseLn
Imports ClaseNe
Imports System.IO
Imports System.Windows.Forms
Imports System.Globalization

Public Class FrmGestionProductoAReparar

	Private productometodo As New ProductoLN
	Private conversionmetodo As New ConversionLN
	Private proveedoresLN As New ProveedoresLN
	Private pro As New ProductosNE
	Dim helpersLN As New HelpersLN
	Dim helpersUi As New HelpersUI
	Public modificado As Boolean = False
	Public idProductoNuevo As Integer = 0
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
#Region "Precio"
			If Not String.IsNullOrEmpty(tbPrecio.Text) Then
				Dim value As Decimal
				Dim newText = tbPrecio.Text.Replace(",", ".")
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
			pro.proveedorId = 1
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


#Region "unidad de peso"
			If Not String.IsNullOrEmpty(cmbUnidad.SelectedValue) Then
				pro.Unidad = cmbUnidad.SelectedValue
			Else
				MsgBox("Debe agregar una unidad de peso", MsgBoxStyle.Critical, "Producto")
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
				Dim value As Decimal
				Dim newText = TbTamaño.Text.Replace(",", ".")
				If Not Decimal.TryParse(newText, value) Then
					MsgBox("Ingrese el tamaño en un formato correcto (123.00)", MsgBoxStyle.Critical, "Producto")
					Return
				End If
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
#Region "problema"
            If Not String.IsNullOrEmpty(tbProblema.Text) Then
                pro.Problema = helpersUi.NormalizarTexto(tbProblema.Text)
            Else
                MsgBox("Debe cargar un problema", MsgBoxStyle.Critical, "Producto")
                Return
            End If
#End Region
            pro.EsReparacion = "S"
			pro.EsServicio = "N"
			pro.CodBarra = "-"
			productometodo.Grabarproductos(pro)
			idProductoNuevo = productometodo.CargarUnProducto(0, pro.nombreprducto)
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error: Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Exit Sub
		End Try
	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles Button2.Click
		modificado = True
		Me.Close()
	End Sub

	Private Sub FrmGestionProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		DataGridView1.RowTemplate.Height = 30
		busqcod = ""
		busqprod = ""
		Habilitarcampos()
		LlenarCMBTipo()
		LlenarCMBMaterial()
		LlenarCMBUnidadDePeso()
		LlenarCMBCategoria()
		Dgvproductosset()
		modificado = False


	End Sub

	Public Sub Dgvproductosset()
		Try


			Dim dsa1 As DataTable
			dsa1 = productometodo.CargaGrillaproductossinbusqueda(busqcod, busqprod, "S") 'Si parametros esta vacio, busca todos los clientes en la bd
			DataGridView1.DataSource = dsa1
			DataGridView1.Columns(0).HeaderText = "Código"
			DataGridView1.Columns(1).HeaderText = "Código Barras"
			DataGridView1.Columns(2).HeaderText = "Nombre de Producto"
			DataGridView1.Columns(3).HeaderText = "Categoría de Producto"
			DataGridView1.Columns(4).HeaderText = "Tipo de Produco"
			DataGridView1.Columns(5).HeaderText = "Material de Producto"
			DataGridView1.Columns(6).HeaderText = "Precio al Público"
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
			DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
			DataGridView1.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridView1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
			DataGridView1.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridView1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
			DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
			DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
			DataGridView1.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
			DataGridView1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
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

		Dim ms As MemoryStream = New MemoryStream()

		Dim img As Byte() = CType((DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value), Byte())


		If img Is Nothing Then
			MessageBox.Show("Imagen no encontrada en la base de datos")
		End If

		ms.Write(img, 0, img.GetUpperBound(0) + 1)
		Dim imgImagen As System.Drawing.Image = System.Drawing.Image.FromStream(ms)

		PBfoto.Image = imgImagen
		TbNombreProducto.Text = (DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value)
		tbPrecio.Text = (DataGridView1.Item(10, DataGridView1.CurrentRow.Index).Value)
		CmbMaterial.SelectedValue = (DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value)
		TbPeso.Text = (DataGridView1.Item(12, DataGridView1.CurrentRow.Index).Value)
		TbTamaño.Text = (DataGridView1.Item(13, DataGridView1.CurrentRow.Index).Value)
		TbColor.Text = (DataGridView1.Item(14, DataGridView1.CurrentRow.Index).Value)
		CmbTipoprodcuto.SelectedValue = (DataGridView1.Item(8, DataGridView1.CurrentRow.Index).Value)
		cmbUnidad.Text = (DataGridView1.Item(19, DataGridView1.CurrentRow.Index).Value)
		CmbCategoria.SelectedValue = (DataGridView1.Item(20, DataGridView1.CurrentRow.Index).Value)
		btnGuardar.Visible = False
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

	Public Sub LlenarCMBUnidadDePeso()
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
	End Sub


	Public Sub bloquearcampos()
		TbColor.Enabled = False
		TbNombreProducto.Enabled = False
		TbPeso.Enabled = False
		tbPrecio.Enabled = False
		TbTamaño.Enabled = False
		cmbUnidad.Enabled = False
		CmbTipoprodcuto.Enabled = False
		CmbCategoria.Enabled = False
		CmbMaterial.Enabled = False
		btncargarimagen.Enabled = False
		btnNuevaCategoria.Enabled = False
		btnNuevoMaterial.Enabled = False
		btnNuevoTipo.Enabled = False
		btnGuardar.Enabled = False

	End Sub

	Public Sub Habilitarcampos()
		TbColor.Enabled = True
		TbNombreProducto.Enabled = True
		TbPeso.Enabled = True
		tbPrecio.Enabled = True
		TbTamaño.Enabled = True
		cmbUnidad.Enabled = True
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
		TbColor.Text = ""
		TbNombreProducto.Text = ""
		TbPeso.Text = ""
		tbPrecio.Text = ""
		TbTamaño.Text = ""
		cmbUnidad.Text = ""
		CmbTipoprodcuto.SelectedValue = 0
		CmbCategoria.SelectedValue = 0
		CmbMaterial.SelectedValue = 0
		PBfoto.Image = Nothing

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
	End Sub
End Class