﻿Imports System.Drawing
Imports System.Windows.Forms
Imports ClaseLn

Public Class FrmGestionCompras

	Private helpersLN As New HelpersLN
	Private comprasLN As New ComprasLN
	Public idCompra As Integer
	Public filaSeleccionada As Integer

#Region "Eventos"
	Private Sub FrmGestionCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
	End Sub

	Private Sub FrmGestionArmado_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
		If FrmArmadoCompra.modificado Then
			Busqueda()
			FrmArmadoCompra.modificado = False
		End If
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
		End If
		Try
			idCompra = selectedRow.Cells("id").Value
			If Not comprasLN.ObtenerUnaCompra(idCompra).Tables(0).Rows(0)(6) = 2 Then
				FrmComprobanteCompra.ShowDialog()
			End If
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

	Public Function LlenarDgv(ByVal parametros As Dictionary(Of String, String), Optional type As String = "") As DataSet
		Dim dsa1 As DataSet
		dsa1 = comprasLN.CargarGrillaCompras(parametros) 'Si parametros esta vacio, busca todos las compras en la bd
		dgvProveedores.DataSource = dsa1.Tables(0)
		dgvProveedores.Columns("Id").Visible = False
		dgvProveedores.Columns("estado").Visible = False
		dgvProveedores.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
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
		FrmListadoCompra.Show()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		FrmEstadisticaCompras.Show()


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