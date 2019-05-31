Imports System.Windows.Forms
Imports ClaseLn

Public Class FrmArmadoVenta

	Private helpersLN As New HelpersLN
	Private ventasLN As New VentasLN
	Private clientesLN As New ClientesLN




#Region "Eventos"
	Private Sub FrmGestionVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LlenarCboClientes()
		GroupBox1.Visible = False
	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()
		FrmGestionVentas.Show()
	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

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
		For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
			lblNombre.Text = ds.Tables(0).Rows(i)(3).ToString() + " " + ds.Tables(0).Rows(i)(3).ToString()

			Dim piso As String = If(ds.Tables(0).Rows(i)(14).ToString() <> "" Or ds.Tables(0).Rows(i)(14).ToString() <> Nothing, "Piso " + ds.Tables(0).Rows(i)(14).ToString() + " ", "")
			Dim dpto As String = If(ds.Tables(0).Rows(i)(15).ToString() <> "" Or ds.Tables(0).Rows(i)(15).ToString() <> Nothing, "Dpto " + ds.Tables(0).Rows(i)(15).ToString() + " ", "")
			Dim mzan As String = If(ds.Tables(0).Rows(i)(16).ToString() <> "" Or ds.Tables(0).Rows(i)(16).ToString() <> Nothing, "Manzana " + ds.Tables(0).Rows(i)(16).ToString() + " ", "")
			Dim lote As String = If(ds.Tables(0).Rows(i)(17).ToString() <> "" Or ds.Tables(0).Rows(i)(17).ToString() <> Nothing, "Lote " + ds.Tables(0).Rows(i)(17).ToString() + " ", "")
			Dim barrio As String = If(ds.Tables(0).Rows(i)(18).ToString() <> "" Or ds.Tables(0).Rows(i)(18).ToString() <> Nothing, "B° " + ds.Tables(0).Rows(i)(18).ToString() + " ", "")

			'Obtengo la localidad y le seteo el valor
			Dim ds1 As DataSet = helpersLN.CargarCMBLocalidadesUnico(ds.Tables(0).Rows(i)(8).ToString())
			Dim localidad As String = ", " + ds1.Tables(0).Rows(0)(1).ToString()

			lblClienteDireccion.Text = ds.Tables(0).Rows(i)(6).ToString() + " " + ds.Tables(0).Rows(i)(7).ToString() + piso + dpto + mzan + lote + barrio + localidad
			lblClienteDNI.Text = ds.Tables(0).Rows(i)(1).ToString() + "  " + ds.Tables(0).Rows(i)(2).ToString()

			If ds.Tables(0).Rows(i)(9).ToString() <> "NULL" Or ds.Tables(0).Rows(i)(14).ToString() <> Nothing Then
				lblClienteTelefono.Text = ds.Tables(0).Rows(i)(9).ToString() + ds.Tables(0).Rows(i)(10).ToString()
			ElseIf ds.Tables(0).Rows(i)(11).ToString() <> "NULL" Or ds.Tables(0).Rows(i)(14).ToString() <> Nothing Then
				lblClienteTelefono.Text = ds.Tables(0).Rows(i)(11).ToString() + ds.Tables(0).Rows(i)(12).ToString()
			End If

		Next
	End Sub
#End Region

End Class