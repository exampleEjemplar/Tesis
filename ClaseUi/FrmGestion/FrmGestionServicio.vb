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
		DataGridView1.DataSource = productometodo.BuscaServicios(txtBusNombreProd.Text).Tables(0)
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

	Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
		txtBusNombreProd.Text = ""
		gbousqueda.Enabled = True
		btnBuscar.Enabled = True
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		gbousqueda.Enabled = False
		txtBusNombreProd.Text = ""
	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		gboServicio.Enabled = True
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

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		Dgvproductosset()
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
		cmbProveedor.SelectedValue = 0
		TbPrecio.Text = ""
		TbNombreServicio.Text = ""
		Dgvproductosset()
		LlenarCboProveedores()
		gboServicio.Enabled = False
		gbousqueda.Enabled = False
		btnguardarmodificacion.Enabled = False
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
			Dim newText = TbPrecio.Text.Replace(".", ",")
			If Decimal.TryParse(newText, value) Then
				pro.precio = value.ToString("0.00")
			Else
				MsgBox("Debe colocar un precio valido (123.23)")
				Return False
			End If
		End If
		Return True
	End Function
End Class