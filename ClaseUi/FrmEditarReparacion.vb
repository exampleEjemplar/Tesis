Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe

Public Class FrmEditarReparacion
	Private pedidosLN As New PedidosLN
	Private helpersUI As New HelpersUI
	Private ventasLN As New VentasLN
	Private idReparacion As Integer
	Public modificado As Boolean = False
	Private listadoEstados As New List(Of Tuple(Of Integer, String))
	Public idProducto As Integer
	Public idCliente As Integer
	Dim estado As Tuple(Of Integer, String)


	Private Sub FrmEditarReparaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
				If pedido(32) = count Then
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

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Close()
	End Sub

	Private Sub btnguardarmodificacion_Click(sender As Object, e As EventArgs) Handles btnguardarmodificacion.Click
		Dim finalizar = False
		Dim idEstado = listadoEstados.FirstOrDefault(Function(x) x.Item2 = cboEstado.SelectedValue).Item1
		If idEstado = 4 Then
			If MsgBox("Desea cerrar la reparación? Se convertirá en una venta y el registro no podrá ser modificado", MsgBoxStyle.YesNo, "Reparacion") = MsgBoxResult.No Then
				Return
			Else
				finalizar = True
			End If
		End If
		If idEstado = 0 Then
			If MsgBox("Desea cerrar la reparación? Se anulará y el registro no podrá ser modificado", MsgBoxStyle.YesNo, "Reparacion") = MsgBoxResult.No Then
				Return
			End If
		End If
		pedidosLN.ActualizarPedido(New VentasNE With {
						.Id = idReparacion,
						.Estado = listadoEstados.FirstOrDefault(Function(x) x.Item2 = cboEstado.SelectedItem).Item1.ToString()
					})
		If finalizar Then
			Dim costo = Convert.ToDouble(lblCosto.Text)
			Dim listaDeVentas = New List(Of TipoDeVentasNE)
			listaDeVentas.Add(New TipoDeVentasNE With {
					.Id = idReparacion,
					.Cantidad = 1,
					.Precio = costo,
					.ProductoId = idProducto,
					.SubTotal = costo
				})

			ventasLN.Registrar(listaDeVentas, idCliente)
			MsgBox("Reparación modificada" + If(finalizar, ". Su reparación se ha transformado en una venta", ""), MsgBoxStyle.OkOnly, "Reparacion")
			FrmComprobanteVenta.ShowDialog()
		Else
			MsgBox("Reparación modificada", MsgBoxStyle.OkOnly, "Reparacion")
		End If
		modificado = True
		Cargar()
	End Sub

	Sub Cargar()
		idReparacion = FrmGestionReparaciones.idReparacion
		Dim pedido = pedidosLN.ObtenerUnPedido(idReparacion).Tables(0).Rows(0)
		LlenarCboEstado(pedido)
		lblCliente.Text = pedido(8).ToString()
		Dim fecha = CType(pedido(1), Date)
		lblFechaPedido.Text = fecha.ToString()
		lblFechaPactada.Text = fecha.AddDays(pedido(7))
		lblCosto.Text = Convert.ToDecimal(pedido(4)).ToString("0.00")
		lblProducto.Text = pedido(11).ToString()
		idProducto = pedido(9)
		idCliente = pedido(30)
		If estado.Item1 = 4 Or estado.Item1 = 0 Then
			cboEstado.Enabled = False
			btnguardarmodificacion.Enabled = False
		Else
			cboEstado.Enabled = True
			btnguardarmodificacion.Enabled = True
		End If
	End Sub

	Private Sub btnSalir_Click_1(sender As Object, e As EventArgs)
		Close()
	End Sub


	Private Const CP_NOCLOSE_BUTTON As Integer = &H200
	Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
		Get
			Dim myCp As CreateParams = MyBase.CreateParams
			myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
			Return myCp
		End Get
	End Property

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEstadistica.Click
		FrmTrazabilidad.idpedido = idReparacion
		FrmTrazabilidad.ShowDialog()
	End Sub
End Class