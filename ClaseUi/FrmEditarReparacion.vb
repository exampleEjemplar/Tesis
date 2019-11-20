Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe

Public Class FrmEditarReparacion
	Private pedidosLN As New PedidosLN
	Private helpersUI As New HelpersUI
	Private idReparacion As Integer
	Public modificado As Boolean = False
	Private listadoEstados As New List(Of Tuple(Of Integer, String))


	Private Sub FrmEditarReparaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		idReparacion = FrmGestionReparaciones.idReparacion
		Dim pedido = pedidosLN.ObtenerUnPedido(idReparacion).Tables(0).Rows(0)
		LlenarCboEstado(pedido)
		lblCliente.Text = pedido(9).ToString()
		Dim fecha = CType(pedido(1), Date).Date
		lblFechaPedido.Text = fecha.ToString()
		lblFechaPactada.Text = fecha.AddDays(pedido(8))
		lblCosto.Text = Convert.ToDecimal(pedido(4)).ToString("#.##")

	End Sub

	Private Function LlenarCboEstado(pedido As DataRow)
		Try
			Dim listaDeEstados = New List(Of Tuple(Of Integer, String))
			Dim dataSource = New List(Of String)
			Dim count = 0
			Dim sI = ""
			For Each enumItem As EstadosPedidos In [Enum].GetValues(GetType(EstadosPedidos))
				Dim description = helpersUI.GetEnumDescription(enumItem)
				listaDeEstados.Add(New Tuple(Of Integer, String)(count, description))
				dataSource.Add(description)
				If pedido(7) = count Then
					sI = description
				End If
				count = count + 1
			Next
			cboEstado.DataSource = dataSource
			cboEstado.SelectedItem = sI
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
		pedidosLN.Actualizar(New VentasNE With {
			.Id = idReparacion,
			.Estado = listadoEstados.FirstOrDefault(Function(x) x.Item2 = cboEstado.SelectedItem).Item1.ToString()
		})
		MsgBox("Reparación modificada", MsgBoxStyle.OkOnly, "Reparacion")
		modificado = True
	End Sub

End Class