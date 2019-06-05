Imports System.Drawing

Imports ClaseLn
Imports ClaseNe
Imports System.IO
Imports System.Windows.Forms

Public Class FrmGestionProducto

    Private productometodo As New ProductoLN
    Private conversionmetodo As New ConversionLN
    Private pro As New ProductosNE
    Public idcategoria As Integer
    Public idcategoria1 As Integer

    Dim IMAGEN As String
    Dim busqcod As String
    Dim busqprod As String
    Dim qidproductos As Integer


    'Metodo que selecciona una imagen y la carga en un PictureBox'
    Sub cargarImagen()
        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then

                IMAGEN = OpenFileDialog1.FileName
                Dim largo As Integer = IMAGEN.Length
                Dim imagen2 As String
                imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN), largo - 2, largo))
                If imagen2 <> "gif" And imagen2 <> "bmp" And imagen2 <> "jpg" And imagen2 <> "jpeg" And imagen2 <> "GIF" And imagen2 <> "BMP" And imagen2 <> "JPG" And imagen2 <> "JPEG" Then
                    imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN), largo - 3, largo))
                    If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then
                        MsgBox("Formato no valido") : Exit Sub
                        If imagen2 <> "log1" Then Exit Sub
                    End If
                    PBfoto.Load(IMAGEN)
                End If
            End If
        Catch ex As Exception

        End Try
        PBfoto.Load(IMAGEN)
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        cargarImagen()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If rdpropios.Checked Then


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
            pro.Unidad = TbUnidad.SelectedValue
            pro.categoriaId = CmbCategoria.SelectedValue
            pro.StockODeTercero = 0
            productometodo.Grabarproductos(pro)
            DgvproductosSet()
            cereacampos()
            bloquearcampos()
            btnBuscar.Enabled = True
            btnmodificar.Enabled = True
        Else

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
            pro.Unidad = TbUnidad.SelectedValue
            pro.categoriaId = CmbCategoria.SelectedValue
            pro.StockODeTercero = 1
            productometodo.Grabarproductos(pro)
            DgvproductosSet()
            cereacampos()
            bloquearcampos()
            btnBuscar.Enabled = True
            btnmodificar.Enabled = True

        End If



    End Sub




    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FrmGestionProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.RowTemplate.Height = 45
        busqcod = ""
        busqprod = ""
        gbbusqueda.Visible = False
        bloquearcampos()
        LlenarCMBTipo()
        LlenarCMBMaterial()
        LlenarCMBproveerdor()
        LlenarCMBCategoria()
        DgvproductosSet()

    End Sub

    Public Sub DgvproductosSet()
        Try
            Dim dsa1 As DataTable
            dsa1 = productometodo.CargaGrillaproductossinbusqueda(busqcod, busqprod) 'Si parametros esta vacio, busca todos los clientes en la bd
            DataGridView1.DataSource = dsa1
           
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(5).Visible = False
        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(9).Visible = False
        DataGridView1.Columns(10).Visible = False
        DataGridView1.Columns(11).Visible = False
        DataGridView1.Columns(12).Visible = False
        DataGridView1.Columns(13).Visible = False
        DataGridView1.Columns(14).Visible = False
         DataGridView1.Columns(0).HeaderText = "Nro. Doc."
        DataGridView1.Columns(1).HeaderText = "Nro. Doc."
        DataGridView1.Columns(3).HeaderText = "Apellido"
        DataGridView1.Columns(4).HeaderText = "Nombre"
        DataGridView1.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView1.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
			'DataGridView1.Sort(dvgListadoPacientes.Columns(3), System.ComponentModel.ListSortDirection.Ascending)

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

                
                
                



    Public Function LlenarCMBTipo()
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
        Return CmbTipoprodcuto.SelectedValue
    End Function


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

    Public Function LlenarCMBproveerdor()
        Try
            Dim ds1 As DataSet
            ds1 = productometodo.CargarCMBproveerdor()
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
        DgvproductosSet()
        gbbusqueda.Visible = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        cargarcodigo()
        Habilitarcampos()
        btnBuscar.Enabled = False
        btnmodificar.Enabled = False

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
        TbUnidad.Enabled = False
        TbUtilidad.Enabled = False
        cmbProveedor.Enabled = False
        CmbTipoprodcuto.Enabled = False
        CmbCategoria.Enabled = False
        CmbMaterial.Enabled = False
        Button3.Enabled = False
        rdpropios.Enabled = False
        rdterceros.Enabled = False

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
        TbUnidad.Enabled = True
        TbUtilidad.Enabled = True
        cmbProveedor.Enabled = True
        CmbTipoprodcuto.Enabled = True
        CmbCategoria.Enabled = True
        CmbMaterial.Enabled = True
        Button3.Enabled = True
        rdpropios.Enabled = True
        rdterceros.Enabled = True


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
        TbUnidad.Text = ""
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
        btnmodificar.Enabled = True
        btnNuevo.Enabled = True


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        gbbusqueda.Visible = True

    End Sub
End Class
