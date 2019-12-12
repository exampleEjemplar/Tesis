Imports System.Drawing
Imports System.Windows.Forms
Imports ClaseLn

Public Class FrmGestionCompras

	Private helpersLN As New HelpersLN
	Private comprasLN As New ComprasLN
	Public idCompra As Integer
	Public recargar As Boolean
	Public filaSeleccionada As Integer
	Public primerOrder As Boolean = True
	Public OrderBy As New List(Of Tuple(Of Integer, String, Integer)) 'Index, nombrevista, nombre base, prioridad
#Region "Eventos"
	Private Sub FrmGestionCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LlenarCboOrden()
		InicializarOrderBy()
		LlenarCboProveedores()
		Busqueda("load")
		dtpFechaHasta.Visible = False
		dtpFechaDesde.Visible = False
		dtpFechaHasta.Value = Date.Now
		dtpFechaDesde.Value = Date.Now
		lblFechaExacta.Visible = False
		lblHasta.Visible = False
		lbldesde.Visible = False
	End Sub

	Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()
		primerOrder = True
	End Sub

	Private Sub FrmGestionArmado_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
		If recargar Then
			Busqueda()
			recargar = False
		End If
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
		OrderBy.Add(New Tuple(Of Integer, String, Integer)(1, "'Fecha'", 1))
		OrderBy.Add(New Tuple(Of Integer, String, Integer)(2, "", 2))
		OrderBy.Add(New Tuple(Of Integer, String, Integer)(3, "", 3))
		lblPrioridad1.Text = OrderBy.FirstOrDefault(Function(x) x.Item1 = 1).Item2.Replace("'", "")
		lblPrioridad2.Visible = False
		lblPrioridad3.Visible = False
	End Sub

	Private Sub Busqueda(Optional ByVal type As String = "")
		Dim parametros As Dictionary(Of String, String) = New Dictionary(Of String, String)
		If String.IsNullOrWhiteSpace(cboProveedor.SelectedValue) = False Then
			parametros.Add("ProveedorId", cboProveedor.SelectedValue)
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
		parametros.Add("Estado", "2")
		LlenarDgv(parametros, type)
	End Sub

	Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		FrmArmadoCompra.ShowDialog()
	End Sub

	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvProveedores.CellMouseDoubleClick
		Dim selectedRow As DataGridViewRow = Nothing
		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			selectedRow = dgvProveedores.Rows(e.RowIndex)
			idCompra = selectedRow.Cells("id").Value
			If Not comprasLN.ObtenerUnaCompra(idCompra).Tables(0).Rows(0)(6) = 2 Then
				FrmComprobanteCompra.ShowDialog()
			End If
		End If
		Try
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try

	End Sub
#End Region

#Region "Metodos"
	Public Function LlenarCboProveedores()
		Try
			Dim ds1 As DataSet
			ds1 = helpersLN.CargarCboTodosProveedores("False")
			cboProveedor.DataSource = ds1.Tables(0)
			cboProveedor.DisplayMember = "Nombre"
			cboProveedor.ValueMember = "id"
			cboProveedor.SelectedValue = 0

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return cboProveedor.SelectedValue
		MessageBox.Show(cboProveedor.SelectedValue)
	End Function

	Public Sub LlenarCboOrden()
		cboOrden.DataSource = {"asc", "desc"}
		cboOrden.SelectedItem = "desc"
	End Sub

	Public Function LlenarDgv(ByVal parametros As Dictionary(Of String, String), Optional type As String = "") As DataSet
		Dim dsa1 As DataSet
		dsa1 = comprasLN.CargarGrillaCompras(parametros, OrderBy, cboOrden.SelectedItem) 'Si parametros esta vacio, busca todos las compras en la bd
		dgvProveedores.DataSource = dsa1.Tables(0)
		If primerOrder Then
			primerOrder = False
			For i = 0 To dsa1.Tables(0).Columns.Count - 1
				If dsa1.Tables(0).Columns(i).ColumnName = "Id" Or dsa1.Tables(0).Columns(i).ColumnName = "estado" Then
					Continue For
				End If
				If dsa1.Tables(0).Columns(i).ColumnName = "Fecha" Then
					chbListaParaOrdenar.Items.Add(dsa1.Tables(0).Columns(i).ColumnName, CheckState.Checked)
					Continue For
				End If
				chbListaParaOrdenar.Items.Add(dsa1.Tables(0).Columns(i).ColumnName)
			Next
			chbListaParaOrdenar.SetItemChecked(0, True)
		End If
		dgvProveedores.Columns("Id").Visible = False
        dgvProveedores.Columns("estado").Visible = False
        dgvProveedores.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvProveedores.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvProveedores.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvProveedores.Columns("Total").DefaultCellStyle.Format = "c2"
        dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		If dsa1.Tables(0).Rows.Count() = 0 And type = "" Then
			MsgBox("La busqueda no arrojo resultados", MsgBoxStyle.OkOnly, "Compras")
		End If
		Return dsa1
	End Function

	Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
		Busqueda()
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

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmListadoCompra.ShowDialog()
    End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmEstadisticaCompras.ShowDialog()


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

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
		Dim confirmado = False
		If filaSeleccionada >= 0 Then
			If MsgBox("Está seguro que desea anular la compra y todos sus registros", MsgBoxStyle.YesNo, "Compras") = MsgBoxResult.Yes Then
				Dim compra = comprasLN.ObtenerUnaCompra(dgvProveedores.Item("Id", filaSeleccionada).Value).Tables(0).Rows(0)
				If compra(6) = 0 Then
					If MsgBox("La compra ya fue registrada en el cierre de caja, desea anularla de todas maneras? El cierre no se verá afectado.", MsgBoxStyle.YesNo, "Compras") = MsgBoxResult.Yes Then
						confirmado = True
					Else
						confirmado = False
						Return
					End If
				ElseIf compra(6) = 2 Then
					MsgBox("La compra ya se encuentra anulada", MsgBoxStyle.OkOnly, "Compras")
					confirmado = False
				Else
					confirmado = True
				End If
			Else
				confirmado = False
			End If
			If confirmado Then
				comprasLN.Anular(dgvProveedores.Item("Id", filaSeleccionada).Value)
				MsgBox("La compra fue anulada", MsgBoxStyle.OkOnly, "Compras")
				Busqueda()
			End If
		Else
			MsgBox("Debe seleccionar una compra", MsgBoxStyle.OkOnly, "Compras")
		End If
	End Sub
	Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedores.CellClick
		filaSeleccionada = dgvProveedores.CurrentRow.Index
	End Sub
End Class