
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

        Dim usuario = usuarioLn.CargarUnUsuario(loginLN.ChequearEnSesion())
        lblUsuario.Text = usuario.Tables(0).Rows(0)(0).ToString()
        Dim fecha As String = Today + " - " + TimeOfDay
        lblFechacierre.Text = fecha
        Search()



    End Sub

    Private Sub btnSalirr_Click(sender As Object, e As EventArgs) Handles btnSalirr.Click
        Me.Close()

    End Sub


    Public Sub Search()
        Dim parametros As Dictionary(Of String, String) = New Dictionary(Of String, String)

        parametros.Add("FechaDesde", Today)
        parametros.Add("FechaHasta", Today)

        parametros.Add("UsuarioId", loginLN.ChequearEnSesion())

        CargarGrilla(parametros)
    End Sub


    Public Sub CargarGrilla(parametros As Dictionary(Of String, String))
        dgvGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim ds As DataSet = cajaLN.CargarGrillaMovimientosEstado(parametros)

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
                            .tipo = tipo,
                            .Fecha = fila(1),
                            .Movimiento = If(tipo = "Venta", fila(2).ToString, (fila(2) * -1).ToString()),
                            .usuario = usuario
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
        txtMontoFinal = (totalIngresos - totalEgresos)

        If cantidadMovimientos = 0 Then
            MsgBox("No se registraron movimientos de caja para este Usuario", MsgBoxStyle.OkOnly, "Movimiento caja")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("¿Desea Realizar Cierre de Caja?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then



            cajaLN.grabarCierredeCaja(loginLN.ChequearEnSesion(), txtMontoFinal)
            cajaLN.updateCierre(loginLN.ChequearEnSesion())



        Else



            Return



        End If


        Search()

    End Sub
End Class