
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports ClaseLn
Imports ClaseNe
Imports ClaseUi.FrmTrazabilidad

Public Class FrmTrazapromedio
	Private helperui As New HelpersUI
	Private MovimientoEstadoPedidoLN As New MovimientoEstadoPedidoLN
	Private pedidosln As New PedidosLN
	Dim Series1 As Series


	Public Sub datosregistros()

		Dim ds = MovimientoEstadoPedidoLN.CargarMovimientosAgrupadoPorProveedor()
		Dim registros = New List(Of MovimientoEstadoPedidoEstadistica)


		For i = 0 To ds.Tables(0).Rows.Count - 1
			registros.Add(New MovimientoEstadoPedidoEstadistica With {
				.PedidoId = ds.Tables(0).Rows(i)(3).ToString(),
				.Estado = helperui.GetEnumDescription(DirectCast(ds.Tables(0).Rows(i)(1), EstadosPedidos)),
				.Fecha = ds.Tables(0).Rows(i)(2).ToString(),
				.ProveedorNombre = ds.Tables(0).Rows(i)(0).ToString(),
				.Activo = ds.Tables(0).Rows(i)(4)
			 })
		Next

		Dim ordenadoPorFecha = registros.OrderBy(Function(x) x.Fecha)
		Dim enElProveedor = ordenadoPorFecha.Where(Function(x) x.Estado = "En el proveedor")

		For Each estePedido As MovimientoEstadoPedidoEstadistica In enElProveedor
			If estePedido.Activo = 1 Then
				estePedido.HorasActivo = (Date.Now - estePedido.Fecha).TotalHours
			Else
				Dim siguiente As MovimientoEstadoPedidoEstadistica = Nothing
				siguiente = ordenadoPorFecha.FirstOrDefault(Function(x) x.Estado = "Devuelto por el proveedor")
				If siguiente IsNot Nothing Then
					estePedido.HorasActivo = (siguiente.Fecha - estePedido.Fecha).TotalHours
				Else
					siguiente = ordenadoPorFecha.FirstOrDefault(Function(x) x.Fecha > estePedido.Fecha)
					estePedido.HorasActivo = (siguiente.Fecha - estePedido.Fecha).TotalHours
				End If
			End If
		Next
		Dim agrupadoPorProveedor = enElProveedor.GroupBy(Function(x) x.ProveedorNombre)

		Dim data = New List(Of Tuple(Of String, Decimal))

		For i = 0 To agrupadoPorProveedor.Count - 1
			data.Add(New Tuple(Of String, Decimal)(agrupadoPorProveedor(i).Key, agrupadoPorProveedor(i).Average(Function(x) x.HorasActivo)))
		Next


		Try
			Chart5.Visible = True
			Chart5.DataSource = data
			Series1 = Chart5.Series("Series2")

			Series1.Name = "Ventas"
            Chart5.Series(Series1.Name).XValueMember = "item1"
            Chart5.Series(Series1.Name).YValueMembers = "Item2"
			Chart5.Series(Series1.Name).LabelFormat = " {0} "
			Chart5.Size = New System.Drawing.Size(668, 372)

		Catch ex As Exception
			'  MessageBox.Show(ex.Message)
		End Try
	End Sub

	Private Sub FrmTrazabilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Chart5.Visible = False
		datosregistros()
	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()

	End Sub

    Private Sub Chart5_Click(sender As Object, e As EventArgs) Handles Chart5.Click

    End Sub
End Class