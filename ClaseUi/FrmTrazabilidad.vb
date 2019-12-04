
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports ClaseLn
Imports ClaseNe

Public Class FrmTrazabilidad

    Private helperui As New HelpersUI
    Private MovimientoEstadoPedidoLN As New MovimientoEstadoPedidoLN
    Private pedidosln As New PedidosLN
    Public idpedido As Integer
    Dim Series1 As Series


    Public Sub datosregistros()

		Dim ds = MovimientoEstadoPedidoLN.CargarMovimientosEstado(idpedido)
		Dim pedidoInfo = pedidosln.ObtenerUnPedido(idpedido).Tables(0).Rows
		Dim listaProductos = New List(Of String)
		Dim totalCosto As Decimal = 0
		For i = 0 To pedidoInfo.Count - 1
			listaProductos.Add(pedidoInfo(i)(11))
			totalCosto += pedidoInfo(i)(13)
		Next
		lblCliente.Text = pedidoInfo(0)(8)
		lblPrecio.Text = totalCosto.ToString("C2")
		lblPrecioVenta.Text = Convert.ToDecimal(pedidoInfo(0)(4)).ToString("C2")
		lblProveedor.Text = pedidoInfo(0)(33)
		cboProductos.DataSource = listaProductos

		Dim registros = New List(Of MovimientoEstadoPedidoEstadistica)
		For i = 0 To ds.Tables(0).Rows.Count - 1
			registros.Add(New MovimientoEstadoPedidoEstadistica With {
				  .Id = ds.Tables(0).Rows(i)(0).ToString(),
				  .PedidoId = ds.Tables(0).Rows(i)(1).ToString(),
				  .Estado = helperui.GetEnumDescription(DirectCast(ds.Tables(0).Rows(i)(2), EstadosPedidos)),
				  .Fecha = ds.Tables(0).Rows(i)(3).ToString(),
				  .Activo = ds.Tables(0).Rows(i)(4).ToString()
			 })
		Next

		Dim agrupadosPorPedidoId = registros.GroupBy(Function(x) x.PedidoId).ToList()
		For index = 0 To agrupadosPorPedidoId.Count - 1
			Dim PedidoId = agrupadosPorPedidoId(index).Key

			For Each MovEstPedido As MovimientoEstadoPedidoEstadistica In agrupadosPorPedidoId(index)
				Dim esteMovimiento = registros.FirstOrDefault(Function(x) x.Id = MovEstPedido.Id)
				If MovEstPedido.Activo = "1" Then
					esteMovimiento.HorasActivo = (Date.Now - MovEstPedido.Fecha).TotalHours
					Continue For
				Else
					Dim fechaDelSiguiente = agrupadosPorPedidoId(index).Where(Function(x) Not x.Id = MovEstPedido.Id And x.Fecha > esteMovimiento.Fecha).OrderBy(Function(x) x.Fecha).FirstOrDefault().Fecha
					esteMovimiento.HorasActivo = (fechaDelSiguiente - MovEstPedido.Fecha).TotalHours
				End If
			Next
		Next

		Try
			Chart5.Visible = True
			Dim textTiempo = ""
			If registros.Where(Function(X) Not X.Estado = "Entregado al cliente").Any(Function(x) x.HorasActivo < 1) Then
				For Each registro As MovimientoEstadoPedidoEstadistica In registros
					registro.HorasActivo = (Convert.ToDecimal(registro.HorasActivo) * 60).ToString()
				Next
				textTiempo = "Minutos"
			Else
				textTiempo = "Horas"
			End If
			Dim orderedRegistros = registros.OrderByDescending(Function(x) x.Fecha)
			Dim tiempoTotal As Decimal = 0
			tiempoTotal = (orderedRegistros.FirstOrDefault().Fecha - orderedRegistros.LastOrDefault().Fecha).TotalHours
			If tiempoTotal < 1 Then
				lblTiempoTotal.Text = (tiempoTotal * 60).ToString("0.00") + " minutos."
			ElseIf tiempoTotal > 24 Then
				lblTiempoTotal.Text = (tiempoTotal / 24).ToString("0.00") + " días."
			Else
				lblTiempoTotal.Text = tiempoTotal.ToString("0.00") + " horas."
			End If

			Chart5.DataSource = registros.Where(Function(X) Not X.Estado = "Entregado al cliente")
			Series1 = Chart5.Series("Series2")

			Series1.Name = "Ventas"
			Chart5.Series(Series1.Name).XValueMember = "estado"
			Chart5.Series(Series1.Name).YValueMembers = "horasactivo"
			Chart5.Series(Series1.Name).LabelFormat = " {0} " + textTiempo
			Chart5.Size = New System.Drawing.Size(668, 372)

		Catch ex As Exception
			'  MessageBox.Show(ex.Message)
		End Try




	End Sub


	Public Class MovimientoEstadoPedidoEstadistica
		Private _Id As String

		Public Property Id As String
			Get
				Return _Id
			End Get
			Set(ByVal value As String)
				_Id = CStr(value)
			End Set
		End Property
		Private _PedidoId As String

		Public Property PedidoId As String
			Get
				Return _PedidoId
			End Get
			Set(ByVal value As String)
				_PedidoId = CStr(value)
			End Set
		End Property
		Private _Fecha As Date

		Public Property Fecha As Date
			Get
				Return _Fecha
			End Get
			Set(ByVal value As Date)
				_Fecha = CStr(value)
			End Set
		End Property
		Private _Estado As String

		Public Property Estado As String
			Get
				Return _Estado
			End Get
			Set(ByVal value As String)
				_Estado = CStr(value)
			End Set
		End Property
		Private _Activo As String

		Public Property Activo As String
			Get
				Return _Activo
			End Get
			Set(ByVal value As String)
				_Activo = CStr(value)
			End Set
		End Property

		Private _HorasActivo As Double

		Public Property HorasActivo As Double
			Get
				Return _HorasActivo
			End Get
			Set(ByVal value As Double)
				_HorasActivo = CStr(value)
			End Set
		End Property
	End Class

	Private Sub FrmTrazabilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Chart5.Visible = False
		datosregistros()



	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()

	End Sub
End Class