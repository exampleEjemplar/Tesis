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


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click, Button3.Click
        cargarImagen()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

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
        productometodo.Grabarproductos(pro)
        DgvproductosSet()



    End Sub




    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FrmGestionProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.RowTemplate.Height = 45
        busqcod = ""
        busqprod = ""
        tbCodigo.Enabled = False
        qidproductos = productometodo.ConsultarCodigo()
        tbCodigo.Text = qidproductos


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

        'PictureBox1.Image = DG2.Rows(DG2.CurrentRow.Index).Cells(2).FormattedValue  PARA CUANDO HACEMOS DOBLE CLICK Y CARGAMOS LA IMAGEN 
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





    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        busqprod = txtBusNombreProd.Text.Trim
        busqcod = txtBusCodigo.Text.Trim


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub




    'Public Function CargarCMBcategoria1()
    '    Try
    '        Dim ds1 As DataSet
    '        ds1 = productometodo.CargarCMBcategoria1(idcategoria)
    '        CmbCategoria1.DataSource = ds1.Tables(0)
    '        CmbCategoria1.DisplayMember = "nombre"
    '        CmbCategoria1.ValueMember = "id"
    '        CmbCategoria1.SelectedValue = 0
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)

    '    End Try
    '    Return CmbCategoria1.SelectedValue
    'End Function

    'Public Function CargarCMBcategoria2()
    '    Try
    '        Dim ds1 As DataSet
    '        ds1 = productometodo.CargarCMBcategoria2(idcategoria1)
    '        CmbCategoria2.DataSource = ds1.Tables(0)
    '        CmbCategoria2.DisplayMember = "nombre"
    '        CmbCategoria2.ValueMember = "id"
    '        CmbCategoria2.SelectedValue = 0
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)

    '    End Try
    '    Return CmbCategoria2.SelectedValue
    'End Function


    '    Private Sub CmbCategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbCategoria.SelectionChangeCommitted

    '        idcategoria = CmbCategoria.SelectedValue.ToString
    '        CargarCMBcategoria1()
    '    End Sub

    '    Private Sub CmbCategoria1_SelectionChangeCommitted(sender As Object, e As EventArgs)

    '        idcategoria1 = CmbCategoria1.SelectedValue.ToString
    '        CargarCMBcategoria2()
    '    End Sub



End Class