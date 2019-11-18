Imports System.Windows.Forms
Imports System.Net
Imports System.IO
Imports System.Drawing

Public Class MDIPrincipal

    Private helpersUi As New HelpersUI


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
			Dim CLIENTE As New WebClient
			Dim PAGINA As Stream = CLIENTE.OpenRead("https://www.precio-dolar.com.ar/")
			Dim LECTOR As New StreamReader(PAGINA)
			Dim MIHTML As String = LECTOR.ReadToEnd
			Dim COTIZACION As String = MIHTML.Remove(0, MIHTML.IndexOf("Venta:") + 25)
			COTIZACION = COTIZACION.Substring(0, COTIZACION.IndexOf("<"))

			Me.WindowState = FormWindowState.Maximized
		Catch

		End Try

    End Sub




	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        MDIEstadisticas.Show()


    End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		FrmGestionCliente.ShowDialog()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		FrmGestionProveedores.ShowDialog()
	End Sub

	Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
		FrmGestionProducto.ShowDialog()

	End Sub

	Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
		FrmEstadisticacliente.ShowDialog()


	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		FrmCatalogo.ShowDialog()

	End Sub

	Private Sub GestionDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
		FrmGestionUsuario.ShowDialog()
	End Sub

	Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
		If helpersUi.ValidarOperacion(NameOf(FrmGestionVentas)) Then
			FrmGestionVentas.ShowDialog()
		Else
			MsgBox("Usted no tiene el rol para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
		End If

	End Sub

	Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
		If helpersUi.ValidarOperacion(NameOf(FrmGestionCompras)) Then
			FrmGestionCompras.ShowDialog()
		Else
			MsgBox("Usted no tiene el rol para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
		End If
	End Sub

	Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
		FrmGestionCaja.ShowDialog()
	End Sub

	Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs)
		FrmGestionStock.ShowDialog()
	End Sub

    Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
        FrmGestionPedidos.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub btnSalir_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub
End Class
