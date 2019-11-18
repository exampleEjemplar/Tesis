
Imports ClaseLn
Imports ClaseNe
Imports System.IO
Imports System.Windows.Forms


Public Class FrmCatalogo
    Private productometodo As New ProductoLN
    Dim busqprod As String
    Dim busqcod As String
    Dim categoria As Integer
    Dim qidproductos As Integer



    Public Sub Dgvproductos()
        Dim btncolumnaimagen = New DataGridViewButtonColumn
		Dim dsa1 As DataTable
		dsa1 = productometodo.CargaGrillaproductossinbusqueda(busqcod, busqprod) 'Si parametros esta vacio, busca todos los clientes en la bd
        DataGridView1.DataSource = dsa1
        DataGridView1.Columns(0).HeaderText = "Código"
        DataGridView1.Columns(1).Visible = False
        DataGridView1.Columns(2).HeaderText = "Nombre de Producto"
        '  DataGridView1.Columns(9).HeaderText = ""
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(4).Visible = False
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
        DataGridView1.Columns(0).Width = 80
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        For X = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(X).Cells(1).Value = Nothing Then
                DataGridView1.Rows.Remove(DataGridView1.Rows(X))
            End If
        Next
        DataGridView1.Columns.Add(btncolumnaimagen)
        btncolumnaimagen.Text = "Ver Imagen"
        btncolumnaimagen.FlatStyle = FlatStyle.Standard
        btncolumnaimagen.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        btncolumnaimagen.Width = 50
        btncolumnaimagen.HeaderText = "Imagen"
        btncolumnaimagen.UseColumnTextForButtonValue = True






    End Sub







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

    Public Sub Dgvproductosconbusqueda()
        Dim btncolumnaimagen = New DataGridViewButtonColumn
        Dim dsa1 As DataTable
        dsa1 = productometodo.CargaGrillaproductosCONbusquedaCAT(busqcod, busqprod, categoria) 'Si parametros esta vacio, busca todos los clientes en la bd
        DataGridView1.DataSource = dsa1
        DataGridView1.Columns(0).HeaderText = "Código"
        DataGridView1.Columns(1).Visible = False
		DataGridView1.Columns(2).HeaderText = "Nombre de Producto"
		DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(4).Visible = False
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
        DataGridView1.Columns(0).Width = 80
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        For X = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(X).Cells(1).Value = Nothing Then
                DataGridView1.Rows.Remove(DataGridView1.Rows(X))
            End If
        Next

        DataGridView1.Columns.Add(btncolumnaimagen)
        btncolumnaimagen.Text = "Ver Imagen"
        btncolumnaimagen.FlatStyle = FlatStyle.Standard
        btncolumnaimagen.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        btncolumnaimagen.Width = 50
        btncolumnaimagen.HeaderText = "Imagen"
        btncolumnaimagen.UseColumnTextForButtonValue = True

    End Sub

    Public Sub DgvproductosconbusquedaProducto()
        Dim btncolumnaimagen = New DataGridViewButtonColumn
        Dim dsa1 As DataTable
        dsa1 = productometodo.CargaGrillaproductosCONbusquedaproducto(busqcod, busqprod, categoria) 'Si parametros esta vacio, busca todos los clientes en la bd
        DataGridView1.DataSource = dsa1
        DataGridView1.Columns(0).HeaderText = "Código"
        DataGridView1.Columns(1).Visible = False
        DataGridView1.Columns(2).HeaderText = "Nombre de Producto"
        ' DataGridView1.Columns(9).HeaderText = ""
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(4).Visible = False
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
        DataGridView1.Columns(0).Width = 80
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        For X = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(X).Cells(1).Value = Nothing Then
                DataGridView1.Rows.Remove(DataGridView1.Rows(X))
            End If
        Next

        DataGridView1.Columns.Add(btncolumnaimagen)
        btncolumnaimagen.Text = "Ver Imagen"
        btncolumnaimagen.FlatStyle = FlatStyle.Standard
        btncolumnaimagen.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        btncolumnaimagen.Width = 50
        btncolumnaimagen.HeaderText = "Imagen"
        btncolumnaimagen.UseColumnTextForButtonValue = True

    End Sub
    Private Sub FrmCatalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBuscar.Enabled = True
        DataGridView1.RowTemplate.Height = 50
        busqprod = ""
        busqcod = ""
        LlenarCMBCategoria()
        Dgvproductos()
        tbBuscod.Enabled = False
        tbBusnombre.Enabled = False
        CmbCategoria.Enabled = False



    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click


        busqcod = tbBuscod.Text
        busqprod = tbBusnombre.Text
        categoria = CmbCategoria.SelectedValue
        DataGridView1.Columns.Clear()
        Dgvproductosconbusqueda()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Columns.Clear()
        busqprod = ""
        busqcod = ""
        LlenarCMBCategoria()
        Dgvproductos()
        btnBuscar.Enabled = True
        tbBuscod.Enabled = False
        tbBusnombre.Enabled = False
        CmbCategoria.Enabled = False
        CH1.Checked = False
        CH2.Checked = False
        CH3.Checked = False
        CH1.Enabled = True
        CH2.Enabled = True
        CH3.Enabled = True
    End Sub

    Private Sub CmbCategoria_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbCategoria.SelectionChangeCommitted
		'CmbCategoria.Enabled = False
		'btnBuscar.Enabled = True
		'tbBuscod.Enabled = True
		'tbBusnombre.Enabled = True
	End Sub


    Private Sub DataGridView1_DoubleClick(sender As Object, e As System.EventArgs) Handles DataGridView1.DoubleClick

        FrmDetalleProductoCatalogo.ShowDialog()
        FrmDetalleProductoCatalogo.TBCODIGO.Text = (DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value)
        FrmDetalleProductoCatalogo.TBCODIGOBARRA.Text = (DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)

        Dim ms As MemoryStream = New MemoryStream()
        Dim img As Byte() = CType((DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value), Byte())
        If img Is Nothing Then
            MessageBox.Show("Imagen no encontrada en la base de datos")
        End If
        ms.Write(img, 0, img.GetUpperBound(0) + 1)
        Dim imgImagen As System.Drawing.Image = System.Drawing.Image.FromStream(ms)

        FrmDetalleProductoCatalogo.PBFOTO.Image = imgImagen
        FrmDetalleProductoCatalogo.TBNOMBREPROD.Text = (DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value)
        FrmDetalleProductoCatalogo.TBPRECIO.Text = (DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value)


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If DataGridView1.Columns(e.ColumnIndex).HeaderText = "Imagen" Then

            Dim ms As MemoryStream = New MemoryStream()
            Dim img As Byte() = CType((DataGridView1.Item(9, DataGridView1.CurrentRow.Index).Value), Byte())
            If img Is Nothing Then
                MessageBox.Show("Imagen no encontrada en la base de datos")
            End If
            ms.Write(img, 0, img.GetUpperBound(0) + 1)
            Dim imgImagen As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
            ImagenAmpliada.pbImagen.Image = imgImagen
            ImagenAmpliada.ShowDialog()
        End If

    End Sub

    Private Sub CH1_CheckedChanged(sender As Object, e As EventArgs) Handles CH1.CheckedChanged
        CmbCategoria.SelectedValue = 0
        CmbCategoria.Enabled = True
        CH2.Enabled = False
        CH3.Enabled = False
        If CH1.Checked = False Then
            CmbCategoria.Enabled = False
            tbBuscod.Enabled = False
            tbBusnombre.Enabled = False
            CH2.Enabled = Enabled
            CH3.Enabled = Enabled

        End If
    End Sub
    Private Sub CH2_CheckedChanged(sender As Object, e As EventArgs) Handles CH2.CheckedChanged
        tbBuscod.Text = ""
        tbBuscod.Enabled = True
        CH1.Enabled = False
        CH3.Enabled = False
        If CH2.Checked = False Then
            tbBuscod.Enabled = False
            CmbCategoria.Enabled = False
            tbBusnombre.Enabled = False
            CH1.Enabled = True
            CH3.Enabled = True

        End If
    End Sub


    Private Sub CH3_CheckedChanged(sender As Object, e As EventArgs) Handles CH3.CheckedChanged
        tbBusnombre.Text = ""
        tbBusnombre.Enabled = True
        CH1.Enabled = False
        CH2.Enabled = False
        If CH3.Checked = False Then
            tbBuscod.Enabled = False
            CmbCategoria.Enabled = False
            tbBusnombre.Enabled = False
            CH1.Enabled = True
            CH2.Enabled = True

        End If
    End Sub

    Private Sub tbBusnombre_TextChanged(sender As Object, e As EventArgs) Handles tbBusnombre.TextChanged
		busqcod = tbBuscod.Text
		busqprod = tbBusnombre.Text
        categoria = CmbCategoria.SelectedValue
        DataGridView1.Columns.Clear()
        DgvproductosconbusquedaProducto()
    End Sub
End Class