
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
    Dim parametros As New Dictionary(Of String, String)
    Public TBCODIGO = ""
    Public TBCODIGOBARRA = ""
    Public PBFOTO As Drawing.Image = Nothing
    Public TBNOMBREPROD = ""
    Public TBPRECIO = ""
	Public primerOrder As Boolean = True
	Public OrderBy As New List(Of Tuple(Of Integer, String, Integer)) 'Index, nombrevista, nombre base, prioridad

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

	Public Function DgvclientesSet(ByVal parametros As Dictionary(Of String, String)) As DataSet
        Dim dsa1 As DataSet
		dsa1 = productometodo.CargaGrillaProductos(parametros, OrderBy) 'Si parametros esta vacio, busca todos los clientes en la bd


		If primerOrder Then
			primerOrder = False
			For i = 0 To dsa1.Tables(0).Columns.Count - 1
				If dsa1.Tables(0).Columns(i).ColumnName = "id" Or dsa1.Tables(0).Columns(i).ColumnName = "nombre1" Or dsa1.Tables(0).Columns(i).ColumnName = "Nombre2" Or dsa1.Tables(0).Columns(i).ColumnName = "Nombre3" Or dsa1.Tables(0).Columns(i).ColumnName = "foto" Or dsa1.Tables(0).Columns(i).ColumnName = "TipoProductoID" Or dsa1.Tables(0).Columns(i).ColumnName = "problema" Or dsa1.Tables(0).Columns(i).ColumnName = "UnidadDePeso" Then
					Continue For
				End If
				If dsa1.Tables(0).Columns(i).ColumnName = "Fecha de Alta" Then
					chbListaParaOrdenar.Items.Add(dsa1.Tables(0).Columns(i).ColumnName, CheckState.Checked)
					Continue For
				End If
				chbListaParaOrdenar.Items.Add(dsa1.Tables(0).Columns(i).ColumnName)
			Next
			chbListaParaOrdenar.SetItemChecked(6, True)
		End If

		DataGridView1.DataSource = dsa1.Tables(0)
        Dim btncolumnaimagen = New DataGridViewButtonColumn
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

        Return dsa1
    End Function







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
		InicializarOrderBy()
		DataGridView1.Columns.Clear()
        btnBuscar.Enabled = False
        DataGridView1.RowTemplate.Height = 50
        busqprod = ""
        busqcod = ""

		LlenarCMBCategoria()
		parametros.Add("EsParaReparacion", "N")
		DgvclientesSet(parametros)

        tbBuscod.Enabled = False
        tbBusnombre.Enabled = False
        CmbCategoria.Enabled = False



    End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		primerOrder = True
		Me.Dispose()

	End Sub

	Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        DataGridView1.Columns.Clear()

        Dim parametros As New Dictionary(Of String, String)
        If String.IsNullOrWhiteSpace(CmbCategoria.SelectedValue) = False Then
            parametros.Add("CategoriaID", CmbCategoria.SelectedValue)
        End If
        If String.IsNullOrWhiteSpace(tbBuscod.Text) = False Then
            parametros.Add("id", tbBuscod.Text)
        End If
        If String.IsNullOrWhiteSpace(tbBusnombre.Text) = False Then
            parametros.Add("Nombre", tbBusnombre.Text)
        End If

        If DgvclientesSet(parametros).Tables(0).Rows.Count = 0 Then
            MsgBox("La búsqueda no arrojo resultados", MsgBoxStyle.Critical, "Error")
        End If


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btnBuscar.Enabled = False
        DataGridView1.Columns.Clear()
        busqprod = ""
        busqcod = ""
        LlenarCMBCategoria()
        DgvclientesSet(parametros)
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

        FrmDetalleProductoCatalogo.Show()
        FrmDetalleProductoCatalogo.TBCODIGO.Text = (DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value)
        FrmDetalleProductoCatalogo.TBCODIGOBARRA.Text = (DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value)

        Dim ms As MemoryStream = New MemoryStream()
        Dim img As Byte() = CType((DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value), Byte())
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
            Dim img As Byte() = CType((DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value), Byte())
            If img Is Nothing Then
                MessageBox.Show("Imagen no encontrada en la base de datos")
            End If
            ms.Write(img, 0, img.GetUpperBound(0) + 1)
            Dim imgImagen As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
            ImagenAmpliada.pbImagen.Image = imgImagen
            ImagenAmpliada.Show()
        End If

    End Sub




    Private Sub CH1_CheckedChanged(sender As Object, e As EventArgs) Handles CH1.CheckedChanged
        btnBuscar.Enabled = True
        CmbCategoria.SelectedValue = 0
        CmbCategoria.Enabled = True
        CH2.Enabled = False
        CH3.Enabled = False
        If CH1.Checked = False Then
            btnBuscar.Enabled = False
            CmbCategoria.Enabled = False
            tbBuscod.Enabled = False
            tbBusnombre.Enabled = False
            CH2.Enabled = Enabled
            CH3.Enabled = Enabled

        End If
    End Sub
    Private Sub CH2_CheckedChanged(sender As Object, e As EventArgs) Handles CH2.CheckedChanged
        btnBuscar.Enabled = True
        tbBuscod.Text = ""
        tbBuscod.Enabled = True
        CH1.Enabled = False
        CH3.Enabled = False
        If CH2.Checked = False Then
            btnBuscar.Enabled = False
            tbBuscod.Enabled = False
            CmbCategoria.Enabled = False
            tbBusnombre.Enabled = False
            CH1.Enabled = True
            CH3.Enabled = True

        End If
    End Sub


    Private Sub CH3_CheckedChanged(sender As Object, e As EventArgs) Handles CH3.CheckedChanged
        btnBuscar.Enabled = True
        tbBusnombre.Text = ""
        tbBusnombre.Enabled = True
        CH1.Enabled = False
        CH2.Enabled = False
        If CH3.Checked = False Then
            btnBuscar.Enabled = False
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
		Dim parametros = New Dictionary(Of String, String)
		parametros.Add("Nombre", busqprod)
		DgvclientesSet(parametros)
	End Sub


	Private Const CP_NOCLOSE_BUTTON As Integer = &H200
	Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
		Get
			Dim myCp As CreateParams = MyBase.CreateParams
			myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
			Return myCp
		End Get
	End Property
End Class
