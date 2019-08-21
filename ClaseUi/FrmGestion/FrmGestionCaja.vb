Imports System.Globalization
Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe

Public Class FrmGestionCaja

	Private cajaLN As New CajaLN
	Private helpersln As New HelpersLN
	Public movCajaId As Tuple(Of Integer, String)

	Public Sub CargarGrilla(parametros As Dictionary(Of String, String))
		dgvGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

		Dim ds As DataSet = cajaLN.CargarGrillaMovimientos(parametros)

		Dim totalEgresos = 0F
		Dim totalIngresos = 0F
		Dim cantidadMovimientos = 0
		Dim usuarios As List(Of String) = New List(Of String)


		Dim cajas = New List(Of CajaNE)
		For i = 0 To ds.Tables.Count - 1
			Dim tabla = ds.Tables(i)
			For y = 0 To tabla.Rows.Count - 1
				Dim fila = tabla.Rows(y)
				Dim tipo = ""
				If i = 0 Then
					tipo = "Venta"
					totalIngresos += fila(2)
				Else
					tipo = "Compra"
					totalEgresos += fila(2)
				End If
				Dim usuario = fila(3).ToString()
				cajas.Add(New CajaNE With {
							.Id = fila(0).ToString(),
							.Tipo = tipo,
							.Fecha = fila(1),
							.Movimiento = If(tipo = "Venta", fila(2).ToString, (fila(2) * -1).ToString()),
							.Usuario = usuario
				})
				If Not usuarios.Contains(usuario) Then
					usuarios.Add(usuario)
				End If
				cantidadMovimientos += 1
			Next
		Next

		dgvGrilla.DataSource = cajas
		dgvGrilla.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
		dgvGrilla.Columns("Id").Visible = False
		dgvGrilla.Columns("UsuarioId").Visible = False
		dgvGrilla.Columns("Movimiento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

		txtCantidadMov.Text = cantidadMovimientos.ToString()
		txtEgresos.Text = totalEgresos.ToString("0.00")
		txtIngresos.Text = totalIngresos.ToString("0.00")
		If (totalIngresos - totalEgresos) > 0 Then
			txtMontoFinal.BackColor = Drawing.Color.GreenYellow
		Else
			txtMontoFinal.BackColor = Drawing.Color.Red
		End If
		txtMontoFinal.Text = (totalIngresos - totalEgresos).ToString()
		txtUsuario.Text = String.Join(" // ", usuarios)

		If ds.Tables(0).Rows.Count = 0 Then
			MsgBox("No se obtuvieron movimientos de caja para la busqueda", MsgBoxStyle.OkOnly, "Movimiento caja")
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
		movCajaId = New Tuple(Of Integer, String)(selectedRow.Cells("id").Value, selectedRow.Cells("Tipo").Value)
		FrmConsultaMovimientoCaja.ShowDialog()
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