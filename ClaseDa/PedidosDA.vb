Imports System.Data.SqlClient
Imports ClaseNe
Public Class PedidosDA
	Private db As New SqlConnection
	Private helpersDa As New HelpersDA
	Private com As New SqlCommand
	Private da As SqlDataAdapter
	Private ds1 As DataSet
    Private LoginDa As New MetodoLoginDA
    Private movimientoStockDA As New MovimientoStockDA
    Private metodoProductoDA As New MetodoProductoDA

	Public Sub New()
		Dim objcon As New ConexionDA
		db = objcon.Abrir
		db = objcon.Cerrar
		com.Connection = db
	End Sub

	Public Function CargarGrillaPedidos(ByVal parametros As Dictionary(Of String, String), orderby As List(Of Tuple(Of Integer, String, Integer))) As DataSet
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "set dateformat dmy select v.Id, v.Fecha,c.Nombre +' '+ c.Apellido as Nombre ,v.Total, v.Seña, mep.estadoId, v.dias from pedidos as v inner join Clientes as c on c.Id = v.ClienteId inner join MovimientoEstadosPedidos mep on mep.pedidoId = v.id"

		If parametros.Count <> 0 Then
			Dim count = parametros.Count
			Dim text = " where mep.activo = 1 and "
			For Each item As KeyValuePair(Of String, String) In parametros
				If item.Key = "ClienteId" Then
					count = count - 1
					text = text & "c.id" & " = " & item.Value & " " & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "FechaDesde" And Not parametros.Keys.Contains("FechaHasta") Then
					count = count - 1
					text = text & "v.fecha" & " between '" & item.Value & " 00:00:00' and '" & item.Value & " 23:59:59'" & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "FechaDesde" And parametros.Keys.Contains("FechaHasta") Then
					count = count - 1
					text = text & "v.fecha" & " between '" & item.Value & " 00:00:00' and "
					Continue For
				End If
				If item.Key = "FechaHasta" Then
					count = count - 1
					text = text & "'" & item.Value & " 23:59:59' " & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "EsReparacion" Then
					count = count - 1
					text = text & " v.EsReparacion = '" + item.Value + "'" & If(count <> 0, " and ", "")
					Continue For
				End If
			Next
			sqlStr = sqlStr + text
		End If

		Dim orderers = orderby.Where(Function(x) String.IsNullOrEmpty(x.Item2) = False)
		If orderers.Count() > 0 Then
			Dim orderText = " order by "
			Dim orderedList = orderers.OrderBy(Function(x) x.Item3)
			For i = 0 To orderedList.Count() - 1
				orderText += orderedList(i).Item2
				If Not i = orderedList.Count() - 1 Then
					orderText += ","
				End If
			Next
			sqlStr += orderText
		End If

		Try
			da = New SqlDataAdapter(sqlStr, db)
			da.Fill(ds1)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
		helpersDa.ChequearConexion(db, "close")
		Return ds1
	End Function

	Public Sub Registrar(listaDeProductosId As List(Of TipoDeVentasNE), clienteId As Integer, Optional seña As Double = 0.0)
		Dim total As Double
		For Each ventaDetalle As TipoDeVentasNE In listaDeProductosId
			total += (ventaDetalle.Precio * ventaDetalle.Cantidad)
		Next
		total = Math.Round(total, 2)

		helpersDa.ChequearConexion(db)
		Try
			Dim totalizado = total.ToString("0.00").Replace(",", ".")
			If Not seña = 0.0 Then
				Dim señalizado = seña.ToString("0.00").Replace(",", ".")
				Dim insert As New SqlCommand("insert into pedidos Values (GETDATE()," & clienteId & ", round(" & señalizado & ",2),round(" & totalizado & ",2)," + LoginDa.ChequearEnSesion() + ", 'N', " + If(totalizado = señalizado, "60", "30") + ")", db)
				insert.CommandType = CommandType.Text
				insert.ExecuteNonQuery()
			Else
				Dim insert As New SqlCommand("insert into pedidos Values (GETDATE()," & clienteId & ", 0 ,round(" & totalizado & ",2)," + LoginDa.ChequearEnSesion() + ", 'S', " + listaDeProductosId.FirstOrDefault().Dias.ToString() + ")", db)
				insert.CommandType = CommandType.Text
				insert.ExecuteNonQuery()
			End If
			Dim insertEstado As New SqlCommand("Declare @ventaID int SELECT @ventaID = MAX(Id) FROM pedidos insert into movimientoEstadosPedidos VALUES(@ventaID , 1 ,getdate(),1)", db)
			insertEstado.CommandType = CommandType.Text
			insertEstado.ExecuteNonQuery()
			For Each ventaDetalle As TipoDeVentasNE In listaDeProductosId
				Dim parcial = (ventaDetalle.Precio * ventaDetalle.Cantidad).ToString().Replace(",", ".")

				Dim insert2 As New SqlCommand("Declare @ventaID int SELECT @ventaID = MAX(Id) FROM pedidos insert into DetallePedidos VALUES(@ventaID," & ventaDetalle.ProductoId & "," & ventaDetalle.Cantidad & "," & parcial & "," & parcial & ",NULL)", db)
				insert2.ExecuteNonQuery()

				movimientoStockDA.Registrar(ventaDetalle.ProductoId, ventaDetalle.Cantidad * -1)
			Next
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
		helpersDa.ChequearConexion(db, "close")
	End Sub

	Public Function ObtenerUltimoPedido()
		helpersDa.ChequearConexion(db)
		Dim da As New SqlDataAdapter("Select Max(id) as [Id] from pedidos", db)
		Dim ds As New DataSet
		Try
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try

		helpersDa.ChequearConexion(db, "close")
		Return ds

	End Function

	Public Function ObtenerUnPedido(id As Integer)
		helpersDa.ChequearConexion(db)
		Dim da As New SqlDataAdapter("Select p.*, c.Nombre + ' ' + c.apellido as 'Nombre', prod.*, c.id, cast(p.total as decimal(10,2)), mep.estadoID from pedidos p inner join clientes c on c.id = p.clienteId inner join DetallePedidos dp on dp.PedidoId = p.Id inner join productos prod on prod.Id = dp.ProductoId inner join movimientoestadospedidos mep on mep.pedidoId = p.id where mep.activo = 1 and p.id =" + id.ToString(), db)
		Dim ds As New DataSet
		Try
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try

		helpersDa.ChequearConexion(db, "close")
		Return ds

	End Function

	Public Function ObtenerDatosCliente(ByVal idventa As String)
		helpersDa.ChequearConexion(db)
		Dim da As New SqlDataAdapter("Select c.Nombre + ', ' + c.Apellido as [NombreCliente],
                                      td.Descripcion as [TipoDoc], c.NumeroDocumento as [NroDoc],
                                      c.Calle + ', ' + Convert(varchar(10),c.NumeroCalle) as [Domicilio], v.Total as [Total] From Ventas as v
                                      INNER JOIN Clientes as c on c.Id = v.ClienteId
                                      INNER JOIN TipoDocumentos as td on td.Id = c.TipoDocumentoId
                                      Where v.Id = " & idventa & " ", db)
		Dim ds As New DataSet
		Try
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
		helpersDa.ChequearConexion(db, "close")

		Return ds
	End Function

	Public Function ObtenerDatosProducto(ByVal idventa As String)
		helpersDa.ChequearConexion(db)
		Dim da As New SqlDataAdapter("Select  dv.id, Max(p.Nombre) as [Producto], Max(p.Precio) [PrecioU],
		                                Max(u.Nombre) as [UnidadMedida],
		                                Max(dv.cantidad) as [Cantidad], Max(dv.Subtotal) as [Subtotal] from Ventas as v 
                                        INNER JOIN DetalleVentas as dv on dv.VentaId = v.Id 
                                        INNER JOIN Productos as p on p.id = dv.ProductoId
                                        INNER JOIN UnidadesDePeso as u on u.id = p.UnidadDePeso Where v.Id = " & idventa & " Group by dv.id", db)
		Dim ds As New DataSet

		Try
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
		helpersDa.ChequearConexion(db, "close")

		Return ds
	End Function

	Public Sub ActualizarPedido(ped As VentasNE)
		helpersDa.ChequearConexion(db)

		Dim da As New SqlDataAdapter("update movimientoEstadosPedidos set activo = 0 where pedidoId = " + ped.Id.ToString(), db)
		Dim ds As New DataSet
		Try
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
		'Dim update As New SqlCommand("update pedidos set estado = " + ped.Estado + " where id = " + ped.Id.ToString(), db)
		Dim update As New SqlCommand("insert into movimientoEstadosPedidos VALUES(" + ped.Id.ToString() + " , " + ped.Estado + ",getdate(),1)", db)
		update.CommandType = CommandType.Text
		Try
			update.ExecuteNonQuery()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
		helpersDa.ChequearConexion(db, "close")
	End Sub

End Class
