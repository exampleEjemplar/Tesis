Imports ClaseLn
Imports ClaseNe
Imports System.IO
Imports System.Windows.Forms
Public Class FrmGestionServicio
	Dim busqcod As String
	Dim busqprod As String
	Dim productometodo As New ProductoLN
	Dim pro As New ProductosNE
	Dim helpersLN As New HelpersLN
	Public modificado As Boolean

	Public Sub Dgvproductosset()
		Dim parametros As New Dictionary(Of String, String)
		DataGridView1.DataSource = productometodo.BuscaServicios(parametros).Tables(0)
		'DataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
		DataGridView1.Columns("Costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
		DataGridView1.Columns("Proveedor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
		DataGridView1.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
	End Sub

	Private Sub FrmGestionServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Cargar()
	End Sub

	Public Function LlenarCboProveedores()
		Try
			Dim ds1 As DataSet
			ds1 = helpersLN.CargarCboTodosProveedores("True")
			cmbProveedor.DataSource = ds1.Tables(0)
			cmbProveedor.DisplayMember = "Nombre"
			cmbProveedor.ValueMember = "id"
			cmbProveedor.SelectedValue = 0

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return cmbProveedor.SelectedValue
	End Function

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		modificado = True
		Close()
	End Sub

	Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
		Search()
	End Sub

	Sub Search()
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
		Dgvproductosset()
	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		gboServicio.Enabled = True
		btnNuevo.Enabled = False
		btnguardarmodificacion.Enabled = True
	End Sub

	Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
		FrmGestionProveedores.ShowDialog()
	End Sub

	Private Sub FrmGestionArmado_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
		If FrmGestionProveedores.modificado Then
			LlenarCboProveedores()
			FrmArmadoCompra.modificado = False
		End If
	End Sub

	Private Sub btnguardarmodificacion_Click(sender As Object, e As EventArgs) Handles btnguardarmodificacion.Click
		If Not ValidarDatos() Then
			Return
		End If

		productometodo.RegistrarServicio(pro)
		MsgBox("Servicio agregado con éxito!")
		Cargar()

	End Sub

	Private Sub Cargar()
		rbtEntreFechas.Checked = False
		rbtFechaExacta.Checked = False
		dtpFechaDesde.Visible = False
		dtpFechaHasta.Visible = False
		lbldesde.Visible = False
		lblFechaExacta.Visible = False
		lblHasta.Visible = False
		cmbProveedor.SelectedValue = 0
		TbPrecio.Text = ""
		TbNombreServicio.Text = ""
		Dgvproductosset()
		LlenarCboProveedores()
		gboServicio.Enabled = False
		btnguardarmodificacion.Enabled = False
		btnNuevo.Enabled = True

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


	Private Function ValidarDatos()

		If String.IsNullOrWhiteSpace(TbNombreServicio.Text) Then
			MsgBox("Debe colocar un nombre al servicio")
			Return False
		Else
			pro.nombreprducto = TbNombreServicio.Text
		End If

		If cmbProveedor.SelectedValue = 0 Then
			MsgBox("Debe seleccionar un proveedor")
			Return False
		Else
			pro.proveedorId = cmbProveedor.SelectedValue
		End If

		If String.IsNullOrWhiteSpace(TbPrecio.Text) Then
			MsgBox("Debe colocar un precio al servicio")
			Return False
		Else
			Dim value As Decimal
            Dim newText = TbPrecio.Text.Replace(",", ".")
            If Decimal.TryParse(newText, value) Then
				pro.precio = value.ToString("0.00")
			Else
				MsgBox("Debe colocar un precio valido (123.23)")
				Return False
			End If
		End If
		Return True
	End Function

	Private Const CP_NOCLOSE_BUTTON As Integer = &H200
	Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
		Get
			Dim myCp As CreateParams = MyBase.CreateParams
			myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
			Return myCp
		End Get
	End Property
End Class