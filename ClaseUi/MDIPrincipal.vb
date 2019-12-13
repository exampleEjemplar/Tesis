Imports System.Windows.Forms
Imports System.Net
Imports System.IO
Imports ClaseLn
Imports System.Drawing

Public Class MDIPrincipal

    Private helpersUi As New HelpersUI
    Private loginLN As New LoginLN
    Private usuarioLn As New UsuariosLN
    Private cajaln As New CajaLN



    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.ShowDialog()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub



    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Dim CLIENTE As New WebClient
            'Dim PAGINA As Stream = CLIENTE.OpenRead("https://www.precio-dolar.com.ar/")
            'Dim LECTOR As New StreamReader(PAGINA)
            'Dim MIHTML As String = LECTOR.ReadToEnd
            'Dim COTIZACION As String = MIHTML.Remove(0, MIHTML.IndexOf("Venta:") + 25)
            'COTIZACION = COTIZACION.Substring(0, COTIZACION.IndexOf("<"))

            Me.WindowState = FormWindowState.Maximized
            Dim usuario = usuarioLn.CargarUnUsuario(loginLN.ChequearEnSesion())
            lblUsuario.Text = "Hola " + usuario.Tables(0).Rows(0)(0).ToString() + "!"
            Panel1.Visible = False
            Panel2.Visible = False

        Catch

        End Try

    End Sub




    Private Sub Button5_Click(sender As Object, e As EventArgs)
        MDIEstadisticas.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If helpersUi.ValidarOperacion(NameOf(FrmGestionCliente)) Then
            FrmGestionCliente.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If helpersUi.ValidarOperacion(NameOf(FrmGestionProveedores)) Then
            FrmGestionProveedores.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If


    End Sub

    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        If helpersUi.ValidarOperacion(NameOf(FrmGestionProducto)) Then
            FrmGestionProducto.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If


    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If helpersUi.ValidarOperacion(NameOf(FrmEstadisticacliente)) Then
            FrmEstadisticacliente.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If helpersUi.ValidarOperacion(NameOf(FrmCatalogo)) Then
            FrmCatalogo.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If



    End Sub

    Private Sub GestionDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If helpersUi.ValidarOperacion(NameOf(FrmGestionUsuario)) Then
            FrmGestionUsuario.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If




    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        If helpersUi.ValidarOperacion(NameOf(FrmGestionVentas)) Then
            FrmGestionVentas.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If

    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        If helpersUi.ValidarOperacion(NameOf(FrmGestionCompras)) Then
            FrmGestionCompras.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If
    End Sub

    Private Sub btnCaja_Click(sender As Object, e As EventArgs)
        If helpersUi.ValidarOperacion(NameOf(FrmGestionCaja)) Then
            FrmGestionCaja.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If


    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If helpersUi.ValidarOperacion(NameOf(FrmGestionStock)) Then
            FrmGestionStock.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If



    End Sub

    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        If helpersUi.ValidarOperacion(NameOf(FrmGestionPedidos)) Then
            FrmGestionPedidos.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		'If helpersUi.ValidarOperacion(NameOf(FrmDoc)) Then
		'    FrmDoc.ShowDialog()

		'Else
		'    MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
		'End If





	End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles btnReparaciones.Click
        If helpersUi.ValidarOperacion(NameOf(FrmGestionReparaciones)) Then
            FrmGestionReparaciones.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If




    End Sub

    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property


    Private Sub btnServicios_Click(sender As Object, e As EventArgs) Handles btnServicios.Click
        If helpersUi.ValidarOperacion(NameOf(FrmGestionPagos)) Then
            FrmGestionPagos.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If helpersUi.ValidarOperacion(NameOf(FrmGestionUsuario)) Then
            FrmGestionUsuario.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If helpersUi.ValidarOperacion(NameOf(FrmGestionStock)) Then
            FrmGestionStock.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If



    End Sub


    Private Sub Button8_MouseHover(sender As Object, e As EventArgs) Handles Button8.MouseHover
        Panel1.Visible = True
    End Sub

    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave
        Panel1.Visible = False
    End Sub

    Private Sub MenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip1.MouseHover
        Panel1.Visible = True
    End Sub

    Private Sub MenuStrip1_MouseLeave(sender As Object, e As EventArgs) Handles MenuStrip1.MouseLeave
        Panel1.Visible = False
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        If helpersUi.ValidarOperacion(NameOf(FrmEstadisticacliente)) Then
            FrmEstadisticacliente.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If



    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        If helpersUi.ValidarOperacion(NameOf(FrmEstadisticaProveedor)) Then
            FrmEstadisticaProveedor.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If


    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiciosToolStripMenuItem.Click
        If helpersUi.ValidarOperacion(NameOf(FrmEstadisticaProveedorServicio)) Then
            FrmEstadisticaProveedorServicio.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If


    End Sub

    Private Sub EstadisticasDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticasDeComprasToolStripMenuItem.Click
        If helpersUi.ValidarOperacion(NameOf(FrmEstadisticaCompras)) Then
            FrmEstadisticaCompras.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If


    End Sub

    Private Sub EstadisticasDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadisticasDeVentasToolStripMenuItem.Click
        If helpersUi.ValidarOperacion(NameOf(FrmEstadisticaVentas)) Then
            FrmEstadisticaVentas.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If

    End Sub

    Private Sub EstadísitcasDeStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadísitcasDeStockToolStripMenuItem.Click
        If helpersUi.ValidarOperacion(NameOf(FrmEstadisticaStock)) Then
            FrmEstadisticaStock.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If


    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        If helpersUi.ValidarOperacion(NameOf(FrmCierreDeCaja)) Then
            FrmCierreDeCaja.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If


    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If helpersUi.ValidarOperacion(NameOf(FrmhistorialCierreCaja)) Then
            FrmhistorialCierreCaja.ShowDialog()
        Else
            MsgBox("Usted no tiene autorización para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
        End If





    End Sub

    Private Sub MenuStrip2_MouseHover(sender As Object, e As EventArgs) Handles MenuStrip2.MouseHover
        Panel2.Visible = True
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Panel2.Visible = True
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Panel2.Visible = False
    End Sub
    Private Sub MenuStrip2_MouseLeave(sender As Object, e As EventArgs) Handles MenuStrip2.MouseLeave
        Panel2.Visible = False
    End Sub

    Private Sub FlowLayoutPanel1_MouseLeave(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.MouseLeave
        Panel1.Visible = False
        Panel2.Visible = False

    End Sub

    Private Sub Panel3_MouseHover(sender As Object, e As EventArgs) Handles Panel3.MouseHover
        Panel1.Visible = False
        Panel2.Visible = False
    End Sub

    Private Sub Panel4_MouseHover(sender As Object, e As EventArgs) Handles Panel4.MouseHover
        Panel1.Visible = False
        Panel2.Visible = False
    End Sub

    Private Sub Panel5_MouseHover(sender As Object, e As EventArgs) Handles Panel5.MouseHover
        Panel1.Visible = False
        Panel2.Visible = False
    End Sub

    Private Sub btnManualDeUsuario_Click(sender As Object, e As EventArgs) Handles btnManualDeUsuario.Click
		'FrmAyuda.ShowDialog()
	End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim cierre = cajaln.ControlCierreCaja.Tables(0)
        If cierre.Rows.Count > 0 Then
            MsgBox("Para salir del sistema, debe realizar Cierre de Caja", MsgBoxStyle.OkOnly, "Cierre de Caja")
        Else

            Me.Close()

        End If

    End Sub
End Class
