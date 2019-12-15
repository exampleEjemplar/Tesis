Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe

Public Class FrmConfirmacionPedidoDeReposicion
	Private PedidoDeReposicionLN As New PedidoDeReposicionLN
	Private helpersLN As New HelpersLN
	Private helpersUI As New HelpersUI
	Private comprasLN As New ComprasLN
	Public idpedido As Integer
	Dim ds As DataTable

	Public Function LlenarCboProveedores()
		Try
			Dim ds1 As DataSet
			ds1 = helpersLN.CargarCboTodosProveedores("False")
			cboProveedor.DataSource = ds1.Tables(0)
			cboProveedor.DisplayMember = "Nombre"
			cboProveedor.ValueMember = "id"
			cboProveedor.SelectedValue = 0

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return cboProveedor.SelectedValue
		MessageBox.Show(cboProveedor.SelectedValue)
	End Function

	Private Sub FrmGestionPedidoDeReposicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Cargar()
	End Sub

	Public Sub Buscar()
		ds = PedidoDeReposicionLN.CargarPedido(idpedido).Tables(0)
		dgvProveedores.DataSource = PedidoDeReposicionLN.CargarPedido(idpedido).Tables(0)
		lblIdRepo.Text = ds.Rows(0)(0)
		Dim precio As Decimal = ds.Rows(0)(2)
		lblTotal.Text = precio.ToString("C2")
		dgvProveedores.CurrentCell = Nothing
		For i = 0 To 10
			dgvProveedores.Columns(i).Visible = False
		Next
		dgvProveedores.Columns("Nombre Proveedor").DisplayIndex = 1
		dgvProveedores.Columns("Nombre Producto").DisplayIndex = 2
		dgvProveedores.Columns("Cantidad").DisplayIndex = 3
		dgvProveedores.Columns("precio1").DisplayIndex = 4
		dgvProveedores.Columns("Subtotal").DisplayIndex = 5

		dgvProveedores.ColumnHeadersHeight = 60
		dgvProveedores.Columns("precio1").HeaderText = "Precio unitario"
		dgvProveedores.Columns("Subtotal").HeaderText = "Total"
		dgvProveedores.Columns("Subtotal").DefaultCellStyle.Format = "c2"
		dgvProveedores.Columns("precio1").DefaultCellStyle.Format = "c2"
		dgvProveedores.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
		dgvProveedores.Columns("Nombre Producto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

		dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
	End Sub

	Public Sub Cargar()
		LlenarCboProveedores()
		Buscar()
	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		If MsgBox("¿Está seguro que desea confirmar la recepción del pedido?, Se realizarán compras de mercadería por un total de " + lblTotal.Text, MsgBoxStyle.YesNo, "Confirmar") = MsgBoxResult.No Then
			Return
		End If
		Dim compras = 0
		Try
			Dim lista = ds.AsEnumerable.GroupBy(Function(x) x(6))

			For i = 0 To lista.Count - 1
				Dim listaDeCompras = New List(Of TipoDeComprasNE)
				For Each datarow As DataRow In lista(i)
					listaDeCompras.Add(New TipoDeComprasNE With {
				.Cantidad = datarow(11),
				.ProductoId = datarow(10),
				.Precio = datarow(12),
				.ProveedorId = datarow(6)
				})
				Next
				Dim nroComprobante = ""
				Dim ultimaCompra = comprasLN.ObtenerUltimaCompra.Tables(0)
				If ultimaCompra.Rows.Count = 0 Then
					nroComprobante = helpersUI.AgregarNumerosComprobante(1)
				Else
					nroComprobante = helpersUI.AgregarNumerosComprobante(ultimaCompra.Rows(0).Item(0) + 1)
				End If
				comprasLN.Registrar(listaDeCompras, listaDeCompras.FirstOrDefault().ProveedorId, nroComprobante)
				compras += 1
			Next
			PedidoDeReposicionLN.CambiarEstado(idpedido, 2)
		Catch ex As Exception
			MessageBox.Show(ex.Message)
			MsgBox("Ha ocurrido un error. Por favor intentelo mas tarde", MsgBoxStyle.Critical, "Stock")
			FrmGestionStock.recargar = True
			Dispose()
			Close()
			Return
		End Try
		MsgBox("Se han realizado " + compras.ToString() + " compra/s (Una por proveedor). En caso de dudas revisar la gestión de compras!", MsgBoxStyle.OkOnly, "Stock")
		FrmGestionPedidoDeReposicion.recargar = True
		Dispose()
		Close()
	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Close()
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim listaVisualizar = New Dictionary(Of Integer, Integer)
		For Each datagridviewrow As DataGridViewRow In dgvProveedores.Rows
			dgvProveedores.CurrentCell = Nothing
			If Not datagridviewrow.Cells(15).Value.ToLower().Contains(txtBusNombreProducto.Text.ToLower()) Then
				listaVisualizar.Add(datagridviewrow.Index, 0)
				'dgvProveedores.Rows(datagridviewrow.Index).Visible = False
			Else
				listaVisualizar.Add(datagridviewrow.Index, 1)
				'dgvProveedores.Rows(datagridviewrow.Index).Visible = True
			End If
		Next
		If Not cboProveedor.SelectedValue = 0 Then
			For Each datagridviewrow As DataGridViewRow In dgvProveedores.Rows
				dgvProveedores.CurrentCell = Nothing
				If Not datagridviewrow.Cells(6).Value = cboProveedor.SelectedValue Then
					If listaVisualizar.Single(Function(x) x.Key = datagridviewrow.Index).Value = 1 Then
						listaVisualizar.Remove(datagridviewrow.Index)
						listaVisualizar.Add(datagridviewrow.Index, 0)
					End If
				End If
			Next
		End If
		For Each item As KeyValuePair(Of Integer, Integer) In listaVisualizar
			dgvProveedores.Rows(item.Key).Visible = If(item.Value = 0, False, True)
		Next
	End Sub

	Public Sub Limpiar()
		For Each datagridviewrow As DataGridViewRow In dgvProveedores.Rows
			dgvProveedores.Rows(datagridviewrow.Index).Visible = True
		Next
	End Sub

	Private Sub btnLimpiarFiltros_Click(sender As Object, e As EventArgs) Handles btnLimpiarFiltros.Click
		Limpiar()
		txtBusNombreProducto.Text = ""
		cboProveedor.SelectedValue = 0
	End Sub

End Class