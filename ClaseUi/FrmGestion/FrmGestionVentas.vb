Imports System.Windows.Forms
Imports ClaseLn

Public Class FrmGestionVentas

	Private helpersLN As New HelpersLN
	Private ventasLN As New VentasLN
	Public idVenta As Integer

#Region "Eventos"
	Private Sub FrmGestionVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LlenarCboClientes()
		Busqueda("load")
		dtpFechaHasta.Visible = False
		dtpFechaDesde.Visible = False
		lblFechaExacta.Visible = False
		lblHasta.Visible = False
		lbldesde.Visible = False
	End Sub

	Private Sub FrmGestionArmado_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
		If FrmArmadoVenta.modificado Then
			Busqueda()
			FrmArmadoVenta.modificado = False
		End If
	End Sub

	Private Sub Busqueda(Optional ByVal type As String = "")
		Dim parametros As Dictionary(Of String, String) = New Dictionary(Of String, String)
		If String.IsNullOrWhiteSpace(cboCliente.SelectedValue) = False Then
			parametros.Add("ClienteId", cboCliente.SelectedValue)
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
		LlenarDgv(parametros, type)
	End Sub

	Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()
	End Sub

	Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		FrmArmadoVenta.ShowDialog()
	End Sub

	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvProveedores.CellMouseDoubleClick
		Dim selectedRow As DataGridViewRow
		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			selectedRow = dgvProveedores.Rows(e.RowIndex)
		End If
		Try
			idVenta = selectedRow.Cells("id").Value
			FrmComprobanteVenta.ShowDialog()
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try

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

	Public Function LlenarDgv(ByVal parametros As Dictionary(Of String, String), Optional type As String = "") As DataSet
		Dim dsa1 As DataSet
		dsa1 = ventasLN.CargarGrillaVentas(parametros) 'Si parametros esta vacio, busca todos las ventas en la bd
		dgvProveedores.DataSource = dsa1.Tables(0)
		dgvProveedores.Columns("Id").Visible = False
		dgvProveedores.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
		dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		If dsa1.Tables(0).Rows.Count() = 0 And type = "" Then
			MsgBox("La busqueda no arrojo resultados", MsgBoxStyle.OkOnly, "Ventas")
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

	Private Sub Button1_Click(sender As Object, e As EventArgs)
		FrmArmadoPedido.ShowDialog()
	End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Frmlistadodeventas.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmEstadisticaVentas.Show()
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
End Class