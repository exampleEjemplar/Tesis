Imports System.Windows.Forms

Public Class MDIPrincipal

	Private helpersUi As New HelpersUI


	Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
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

		Me.WindowState = FormWindowState.Normal

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

	Private Sub GestionDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
		FrmGestionUsuario.Show()
	End Sub

	Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
		If helpersUi.ValidarOperacion(NameOf(FrmGestionVentas)) Then
			FrmGestionVentas.Show()
		Else
			MsgBox("Usted no tiene el rol para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
		End If

	End Sub

	Private Sub VentaToolStripMenuItemClick(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
		If helpersUi.ValidarOperacion(NameOf(FrmArmadoVenta)) Then
			FrmArmadoVenta.Show()
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

	Private Sub CompraToolStripMenuItemClick(sender As Object, e As EventArgs) Handles CompraToolStripMenuItem.Click
		If helpersUi.ValidarOperacion(NameOf(FrmArmadoCompra)) Then
			FrmArmadoCompra.Show()
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

	Private Sub btnPagos_Click(sender As Object, e As EventArgs) Handles btnPagos.Click
		If helpersUi.ValidarOperacion(NameOf(FrmGestionPagos)) Then
			FrmGestionPagos.Show()
		Else
			MsgBox("Usted no tiene el rol para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
		End If
	End Sub

	Private Sub PagosToolStripMenuItemClick(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem.Click
		If helpersUi.ValidarOperacion(NameOf(FrmArmadoPago)) Then
			FrmArmadoPago.Show()
		Else
			MsgBox("Usted no tiene el rol para realizar esta operación", MsgBoxStyle.OkOnly, "Roles")
		End If
	End Sub

	Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
		With LogIn
		End With
		LogIn.Show()
		Me.Close()
	End Sub
End Class
