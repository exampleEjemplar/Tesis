Imports System.Globalization
Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe

Public Class FrmGestionCaja

	Private cajaLN As New CajaLN
	Private helpersln As New HelpersLN
	Public productoId As String

	Public Sub CargarGrilla(parametros As Dictionary(Of String, String))
		dgvGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

		Dim ds As DataSet = cajaLN.CargarGrillaMovimientos(parametros)

		Dim total = 0
		Dim totalEgresos = 0
		Dim totalIngresos = 0


		Dim cajas = New List(Of CajaNE)
		For i = 0 To ds.Tables.Count
			Dim tabla = ds.Tables(i)
			For y = 0 To tabla.Rows.Count
				Dim fila = tabla.Rows(y)
				Dim tipo = ""
				If i = 0 Then
					tipo = "ventas"
				Else
					tipo = "compras"
				End If
				cajas.Add(New CajaNE With {
							.Id = fila(0).ToString(),
							.Tipo = If(i = 0, "ventas", "compras"),
							.Fecha = fila(1),
							.Movimiento = If(i = 0, fila(2).ToString, (fila(2) * -1).ToString()),
							.UsuarioId = fila(3).ToString()
				})
			Next
		Next

		dgvGrilla.DataSource = cajas
		dgvGrilla.Columns("Id").Visible = False

		If ds.Tables(0).Rows.Count = 0 Then
			MsgBox("No se obtuvieron movimientos de stock para la busqueda", MsgBoxStyle.OkOnly, "Movimiento Stock")
		End If
	End Sub

	Private Sub FrmGestionStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Cargar()
		CargarGrilla(New Dictionary(Of String, String))
	End Sub

	'Validas los radio buton de fecha de cargado de producto
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

	'Agrega los parametros de busqueda al diccionario y llama al metodo que carga el LVI
	Public Sub Search()
		Dim parametros As Dictionary(Of String, String) = New Dictionary(Of String, String)
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
		If String.IsNullOrWhiteSpace(cboUsuarios.SelectedValue) = False Then
			parametros.Add("UsuarioId", cboUsuarios.SelectedValue)
		End If
		CargarGrilla(parametros)
	End Sub

	Private Sub btnSalirr_Click(sender As Object, e As EventArgs) Handles btnSalirr.Click
		Close()
	End Sub

	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvGrilla.CellMouseDoubleClick
		Dim selectedRow As DataGridViewRow
		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			selectedRow = dgvGrilla.Rows(e.RowIndex)
		End If
		productoId = selectedRow.Cells("id").Value
		FrmConsultaMovimientoStock.ShowDialog()
	End Sub

	'Llena el combobox proveedores
	Public Function LlenarCboUsuarios()
		Try
			Dim ds1 As DataSet
			ds1 = helpersln.CargarCboTodosUsuarios()
			cboUsuarios.DataSource = ds1.Tables(0)
			cboUsuarios.DisplayMember = "Nombre"
			cboUsuarios.ValueMember = "id"
			cboUsuarios.SelectedValue = 0
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return cboUsuarios.SelectedValue
	End Function

	Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
		Search()
	End Sub

	Private Sub Cargar()
		dtpFechaDesde.Value = Date.Now
		dtpFechaHasta.Value = Date.Now
		dtpFechaHasta.Visible = False
		dtpFechaDesde.Visible = False
		lblFechaExacta.Visible = False
		lblHasta.Visible = False
		lbldesde.Visible = False
		rbtEntreFechas.Checked = False
		rbtFechaExacta.Checked = False
		LlenarCboUsuarios()
	End Sub

	Private Sub btnLimpiarFiltros_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltros.Click
		If MsgBox("Desea quitar todos los filtros", MsgBoxStyle.YesNo, "Filtros") = MsgBoxResult.Yes Then
			Cargar()
			Search()
		End If
	End Sub
End Class