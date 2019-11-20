Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe
Public Class FrmGestionReparaciones

	Private helpersLN As New HelpersLN
	Private pedidosLN As New PedidosLN

	Public Sub New()

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().

	End Sub

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

	Private Sub Busqueda(Optional ByVal type As String = "")
		Dim parametros As Dictionary(Of String, String) = New Dictionary(Of String, String)
		parametros.Add("EsReparacion", "S")
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
		FrmArmadoReparacion.ShowDialog()
	End Sub

	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvProveedores.CellMouseDoubleClick
		'Dim selectedRow As DataGridViewRow
		'If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
		'	selectedRow = dgvProveedores.Rows(e.RowIndex)
		'End If
		'Try
		'	idVenta = selectedRow.Cells("id").Value
		'	FrmComprobanteVenta.ShowDialog()
		'Catch ex As Exception
		'	MessageBox.Show(ex.Message)
		'End Try

	End Sub

	Private Sub FrmGestionArmado_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
		If FrmArmadoReparacion.modificado Then
			Busqueda()
			FrmArmadoReparacion.modificado = False
		End If
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
		dsa1 = pedidosLN.CargarGrillaPedidos(parametros) 'Si parametros esta vacio, busca todos los pedidos en la bd

		Dim listaDePedidos = New List(Of VentasNE)
		For i As Integer = 0 To dsa1.Tables(0).Rows.Count - 1
			Dim fecha = CType(dsa1.Tables(0).Rows(i)(1), Date).Date
			Dim fechaVencimientoSeña = fecha.AddDays(dsa1.Tables(0).Rows(i)(6)).Date

			Dim estado = GetEnumDescription(DirectCast(dsa1.Tables(0).Rows(i)(5), EstadosPedidos))

			listaDePedidos.Add(New VentasNE With {
				.Cliente = dsa1.Tables(0).Rows(i)(2).ToString(),
				.Id = dsa1.Tables(0).Rows(i)(0).ToString(),
				.Fecha = fecha,
				.Total = Convert.ToDouble(dsa1.Tables(0).Rows(i)(3)).ToString("0.00"),
				.FechaVencimientoSeña = fechaVencimientoSeña,
				.Estado = estado
			})
		Next
		dgvProveedores.DataSource = listaDePedidos
		dgvProveedores.Columns("Id").Visible = False
		dgvProveedores.Columns("ClienteId").Visible = False
		dgvProveedores.Columns("Seña").Visible = False
		'dgvProveedores.Columns("FechaVencimientoSeña").Visible = False
		dgvProveedores.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
		dgvProveedores.Columns("EstaVencido").Visible = False
		dgvProveedores.Columns("estado").HeaderText = "Estado"
		dgvProveedores.Columns("FechaVencimientoSeña").HeaderText = "Fecha de entrega artículo"
		dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
		dgvProveedores.ReadOnly = True
		If dsa1.Tables(0).Rows.Count() = 0 And type = "" Then
			MsgBox("La busqueda no arrojo resultados", MsgBoxStyle.OkOnly, "Pedidos")
		End If
		Return dsa1
	End Function

	Public Shared Function GetEnumDescription(ByVal EnumConstant As [Enum]) As String
		Dim fi As FieldInfo = EnumConstant.GetType().GetField(EnumConstant.ToString())
		Dim attr() As DescriptionAttribute =
						DirectCast(fi.GetCustomAttributes(GetType(DescriptionAttribute),
						False), DescriptionAttribute())

		If attr.Length > 0 Then
			Return attr(0).Description
		Else
			Return EnumConstant.ToString()
		End If
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


#End Region

End Class