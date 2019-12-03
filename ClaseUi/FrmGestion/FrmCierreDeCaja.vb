
Imports System.Windows.Forms
Imports System.Net
Imports System.IO
Imports ClaseLn
Imports System.Drawing
Imports ClaseNe

Public Class FrmCierreDeCaja




	Private cajaLN As New CajaLN
	Private helpersln As New HelpersLN
	Public movCajaId As Tuple(Of Integer, String)
	Private helpersUi As New HelpersUI
	Private loginLN As New LoginLN
	Private usuarioLn As New UsuariosLN
	Public txtMontoFinal As Double




	Private Sub FrmCierreDeCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaDesde.Visible = False
        btnBuscar.Visible = False
        chkFechaDesde.Visible = False
        Label5.Visible = False
        dtpFechaDesde.Value = Today
        Dim usuario = usuarioLn.CargarUnUsuario(loginLN.ChequearEnSesion())
		lblUsuario.Text = usuario.Tables(0).Rows(0)(0).ToString()
		Dim fecha As String = Today + " - " + TimeOfDay
		lblFechacierre.Text = fecha
		Search("Load")



	End Sub

	Private Sub btnSalirr_Click(sender As Object, e As EventArgs) Handles btnSalirr.Click
		Me.Close()

	End Sub

	Private Sub ChkChanged(sender As Object, e As EventArgs) Handles chkFechaDesde.CheckedChanged
		If dtpFechaDesde.Enabled Then
			dtpFechaDesde.Enabled = False
		Else
			dtpFechaDesde.Enabled = True
		End If
	End Sub


	Public Sub Search(Optional type As String = "")
		Dim parametros As Dictionary(Of String, String) = New Dictionary(Of String, String)

		If dtpFechaDesde.Enabled And chkFechaDesde.Checked Then
			parametros.Add("FechaDesde", dtpFechaDesde.Value.ToString("dd/MM/yyyy"))
		Else
			parametros.Add("FechaDesde", Today)
		End If

		parametros.Add("FechaHasta", Today)

		parametros.Add("UsuarioId", loginLN.ChequearEnSesion())

		CargarGrilla(parametros, type)
	End Sub


	Public Sub CargarGrilla(parametros As Dictionary(Of String, String), Optional type As String = "")


        Dim ds As DataSet = cajaLN.CargarGrillaMovimientosEstado(parametros)

        Dim totalEgresos As Double
        Dim totalIngresos As Double

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
                                .Movimiento = If(tipo = "Venta", fila(2), (fila(2) * -1)),
                                .Usuario = usuario
                })
                If Not usuarios.Contains(usuario) Then
                    usuarios.Add(usuario)
                End If
                cantidadMovimientos += 1
            Next
        Next
        If cantidadMovimientos = 0 And String.IsNullOrWhiteSpace(type) Then
            MsgBox("No se registraron movimientos de caja para este Usuario", MsgBoxStyle.OkOnly, "Movimiento caja")
            Me.Close()
        Else


            dgvGrilla.DataSource = cajas
            dgvGrilla.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
		dgvGrilla.Columns("Id").Visible = False
            dgvGrilla.Columns("UsuarioId").Visible = False
            dgvGrilla.Columns(2).DefaultCellStyle.Format = "C2"
            dgvGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvGrilla.Columns("Movimiento").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            txtMontoFinal = (totalIngresos - totalEgresos)


        End If

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cierre = cajaLN.ControlCierreCaja.Tables(0)
        If cierre.Rows.Count > 0 Then

            If MessageBox.Show("¿Desea Realizar Cierre de Caja?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cajaLN.grabarCierredeCaja(loginLN.ChequearEnSesion(), txtMontoFinal)
                InformeCierredeCaja.ShowDialog()
                cajaLN.updateCierre(loginLN.ChequearEnSesion())
                Me.Close()

            Else

                Return



            End If
        Else
            MsgBox("No se registran movimientos de Caja por cerrar", MsgBoxStyle.OkOnly, "Cierre de Caja")
        End If









    End Sub

	Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
		Search()
	End Sub
	Private Const CP_NOCLOSE_BUTTON As Integer = &H200
	Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
		Get
			Dim myCp As CreateParams = MyBase.CreateParams
			myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
			Return myCp
		End Get
	End Property

End Class