Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe

Public Class FrmEditarPedido
	Private pedidosLN As New PedidosLN
	Private helpersUI As New HelpersUI
	Private ventasLN As New VentasLN
	Private idPedido As Integer
	Public modificado As Boolean = False
	Private listadoEstados As New List(Of Tuple(Of Integer, String))
	Public idProducto As Integer
	Public idCliente As Integer
	Dim estado As Tuple(Of Integer, String)


	Private Sub FrmEditarPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Cargar()
	End Sub

	Private Function LlenarCboEstado(pedido As DataRow)
		Try
			Dim listaDeEstados = New List(Of Tuple(Of Integer, String))
			Dim dataSource = New List(Of String)
			Dim count = 0

			For Each enumItem As EstadosPedidos In [Enum].GetValues(GetType(EstadosPedidos))
				Dim description = helpersUI.GetEnumDescription(enumItem)
				listaDeEstados.Add(New Tuple(Of Integer, String)(count, description))
				dataSource.Add(description)
				If pedido(7) = count Then
					estado = New Tuple(Of Integer, String)(count, description)
				End If
				count = count + 1
			Next
			cboEstado.DataSource = dataSource
			cboEstado.SelectedItem = estado.Item2
			listadoEstados = listaDeEstados
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
		Return cboEstado.SelectedValue
	End Function

	Private Sub btnSalir_Click(sender As Object, e As EventArgs)
		Close()
	End Sub

	Private Sub btnguardarmodificacion_Click(sender As Object, e As EventArgs) Handles btnguardarmodificacion.Click
		Dim finalizar = False
		Dim idEstado = listadoEstados.FirstOrDefault(Function(x) x.Item2 = cboEstado.SelectedValue).Item1
		If idEstado = 4 Then
			If MsgBox("Desea cerrar el pedido? Se convertirá en una venta y el registro no podrá ser modificado", MsgBoxStyle.YesNo, "Pedido") = MsgBoxResult.No Then
				Return
			Else
				finalizar = True
			End If
		End If
		If idEstado = 0 Then
			If MsgBox("Desea cerrar el pedido? Se anulará y el registro no podrá ser modificado", MsgBoxStyle.YesNo, "Pedido") = MsgBoxResult.No Then
				Return
			End If
		End If
		pedidosLN.ActualizarPedido(New VentasNE With {
						.Id = idPedido,
						.Estado = listadoEstados.FirstOrDefault(Function(x) x.Item2 = cboEstado.SelectedItem).Item1.ToString()
					})
		If finalizar Then
			Dim costo = Convert.ToDouble(lblCosto.Text)
			Dim listaDeVentas = New List(Of TipoDeVentasNE)
			listaDeVentas.Add(New TipoDeVentasNE With {
					.Id = idPedido,
					.Cantidad = 1,
					.Precio = costo,
					.ProductoId = idProducto,
					.SubTotal = costo
				})

			ventasLN.Registrar(listaDeVentas, idCliente)
			MsgBox("Pedido modificado" + If(finalizar, ". Su pedido se ha transformado en una venta", ""), MsgBoxStyle.OkOnly, "Pedido")
			FrmComprobanteVenta.ShowDialog()
		Else
			MsgBox("Pedido modificado", MsgBoxStyle.OkOnly, "Pedido")
		End If
		modificado = True
		Cargar()
	End Sub

	Sub Cargar()
		idPedido = FrmGestionPedidos.idPedido
		Dim pedido = pedidosLN.ObtenerUnPedido(idPedido).Tables(0).Rows(0)
		LlenarCboEstado(pedido)
		lblCliente.Text = pedido(9).ToString()
		Dim fecha = CType(pedido(1), Date)
		lblFechaPedido.Text = fecha.ToString()
		lblFechaPactada.Text = fecha.AddDays(pedido(8))
		lblCosto.Text = Convert.ToDecimal(pedido(4)).ToString("#.##")
		lblProducto.Text = pedido(12).ToString()
		idProducto = pedido(10)
		idCliente = pedido(31)
		If estado.Item1 = 4 Or estado.Item1 = 0 Then
			cboEstado.Enabled = False
			btnguardarmodificacion.Enabled = False
		Else
			cboEstado.Enabled = True
			btnguardarmodificacion.Enabled = True
		End If
	End Sub

	Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
		Close()
	End Sub
End Class