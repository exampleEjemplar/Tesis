Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports System.Windows.Forms.ListView
Imports ClaseLn

Public Class FrmArmadoVenta

	Private helpersLN As New HelpersLN
	Private ventasLN As New VentasLN
	Private clientesLN As New ClientesLN
	Dim moveItem As Boolean
	Private listita As List(Of ListViewItem) = New List(Of ListViewItem)
	Public listaDeProductosId As List(Of String) = New List(Of String)


#Region "Eventos"
	Private Sub FrmGestionVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LlenarCboClientes()
		GroupBox1.Visible = False
	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()
		FrmGestionVentas.Show()
	End Sub

#End Region
#Region "Metodos"
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

	Private Sub cboCliente_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboCliente.SelectionChangeCommitted
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
		'Productos

		Dim ds2 As DataSet = helpersLN.CargarTodosProductos()
		lstProdDispo.Scrollable = True


		For i As Integer = 0 To ds2.Tables(0).Rows.Count - 1

#Region "Img stuff"
			Dim ms As MemoryStream = New MemoryStream()
			Dim img As Byte() = CType(ds2.Tables(0).Rows(i).Item(2), Byte())
			If img IsNot Nothing Then
				ms.Write(img, 0, img.GetUpperBound(0) + 1)
				Dim imgImagen As Image = Image.FromStream(ms)
				Dim imagen As ImageList = New ImageList
				Dim ImageList = New ImageList()
				ImageList.Images.Add(ds2.Tables(0).Rows(i).Item(0).ToString(), imgImagen)
				ImageList.ImageSize = New Size(90, 90)
				lstProdDispo.LargeImageList = ImageList
#End Region

				Dim ListViewItem As ListViewItem = New ListViewItem
				ListViewItem.Text = ds2.Tables(0).Rows(i).Item(1).ToString()
				ListViewItem.Tag = ds2.Tables(0).Rows(i)
				ListViewItem.ImageKey = ds2.Tables(0).Rows(i).Item(0).ToString()
				lstProdDispo.Items.Add(ListViewItem)
				listita.Add(ListViewItem)
				'ListViewItem. = ds2.Tables(0).Rows(i).Item(0).ToString()
			End If
		Next
	End Sub

	Private Sub lstProdDispo_MouseDown(sender As Object, e As MouseEventArgs) Handles lstProdDispo.MouseDown
		moveItem = True
	End Sub

	Private Sub lstProdDispo_MouseMove(sender As Object, e As MouseEventArgs) Handles lstProdDispo.MouseMove
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
			Dim cloneOfItem = ItemSelected.Clone()
			ListView1.Items.Add(cloneOfItem)
		End If

	End Sub

	Private Sub ListView1_DragEnter(sender As Object, e As DragEventArgs) Handles ListView1.DragEnter
		If e.Data.GetDataPresent(DataFormats.Text) Then
			e.Effect = DragDropEffects.Copy
		Else
			e.Effect = DragDropEffects.None
		End If
	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		For Each item As ListViewItem In ListView1.Items
			listaDeProductosId.Add(item.Tag.item(0).ToString())
		Next
	End Sub

#End Region

End Class