﻿Imports System.Windows.Forms
Imports System.Net
Imports System.IO


Public Class MDIPrincipal

	Private helpersUi As New HelpersUI


    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewWindowToolStripMenuItem.Click
		' Cree una nueva instancia del formulario secundario.
		Dim ChildForm As New System.Windows.Forms.Form
		' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
		ChildForm.MdiParent = Me

		m_ChildFormNumber += 1
		ChildForm.Text = "Ventana " & m_ChildFormNumber

		ChildForm.Show()
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



	Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
		Me.LayoutMdi(MdiLayout.Cascade)
	End Sub

	Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
		Me.LayoutMdi(MdiLayout.TileVertical)
	End Sub

	Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
		Me.LayoutMdi(MdiLayout.TileHorizontal)
	End Sub

	Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
		Me.LayoutMdi(MdiLayout.ArrangeIcons)
	End Sub

	Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
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


            Dim fecha As String = MIHTML.Remove(0, MIHTML.IndexOf("currency-updated-on-datetime") + 30)
            fecha = fecha.Substring(0, fecha.IndexOf("<"))

            Label1.Text = "La cotización del DOLAR, HOY " + fecha + " es de " + COTIZACION + " Pesos Argentinos.-"
            PAGINA.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()

	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		FrmGestionCliente.Show()
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		FrmGestionProveedores.Show()
	End Sub

	Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
		FrmGestionProducto.Show()

	End Sub

	Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
		FrmEstadisticacliente.Show()


	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		FrmCatalogo.Show()

	End Sub

	Private Sub GestionDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionDeUsuariosToolStripMenuItem.Click
		FrmGestionUsuario.Show()
	End Sub

	Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
		If helpersUi.ValidarOperacion(NameOf(FrmGestionVentas)) Then
			FrmGestionVentas.Show()
		Else
			MsgBox("Usted no tiene el rol para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
		End If

	End Sub

	Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
		If helpersUi.ValidarOperacion(NameOf(FrmGestionCompras)) Then
			FrmGestionCompras.Show()
		Else
			MsgBox("Usted no tiene el rol para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
		End If
	End Sub


	Private Sub btnCaja_Click(sender As Object, e As EventArgs) Handles btnCaja.Click
		FrmGestionCaja.Show()
	End Sub

	Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
		FrmGestionStock.Show()
	End Sub

	Private Sub btnPedidos_Click(sender As Object, e As EventArgs) Handles btnPedidos.Click
		FrmGestionPedidos.ShowDialog()
	End Sub


End Class
