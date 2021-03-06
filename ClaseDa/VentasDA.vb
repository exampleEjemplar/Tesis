﻿Imports System.Data.SqlClient
Imports ClaseNe
Imports System.Net
Imports System.IO

Public Class VentasDA
	Private db As New SqlConnection
	Private helpersDa As New HelpersDA
	Private com As New SqlCommand
	Private da As SqlDataAdapter
	Private ds1 As DataSet
	Private movimientoStockDA As New MovimientoStockDA
	Private metodoProductoDA As New MetodoProductoDA
	Private LoginDa As New MetodoLoginDA
	Dim Rs As SqlDataReader
	Public contador As Integer

	Public Sub New()
		Dim objcon As New ConexionDA
		db = objcon.Abrir
		db = objcon.Cerrar
		com.Connection = db
	End Sub

	Public Sub RegistrarDesdePedido(listaDeProductosId As List(Of TipoDeVentasNE), clienteId As Integer)
		helpersDa.ChequearConexion(db)
		Try
			Dim insertVentas As New SqlCommand("insert into ventas Values (GETDATE()," + clienteId.ToString() + "," + listaDeProductosId.Sum(Function(x) x.SubTotal).ToString("0.00").Replace(",", ".") & ", " & LoginDa.ChequearEnSesion().ToString() & ",1)", db)
			insertVentas.ExecuteNonQuery()
			Dim update As New SqlCommand("Declare @ventaId int SELECT @ventaId = ventaId FROM Pedidos where id =" + listaDeProductosId(0).Id.ToString() + " update ventas set  estado = 2 where id = @ventaId", db)
			update.ExecuteNonQuery()
			For i = 0 To listaDeProductosId.Count - 1
				Dim insert2 As New SqlCommand("insert into detallepedidos Values (" + listaDeProductosId(i).Id.ToString() + "," & listaDeProductosId(i).ProductoId.ToString() & ", " & listaDeProductosId(i).Cantidad.ToString() & "," + listaDeProductosId(i).Precio.ToString().Replace(",", ".") + "," + listaDeProductosId(i).SubTotal.ToString().Replace(",", ".") + ",NULL)", db)
				insert2.ExecuteNonQuery()


				Dim insertdetalleventas As New SqlCommand("Declare @ventaID int SELECT @ventaID = MAX(Id) FROM ventas  insert into detalleventas Values (@ventaId," & listaDeProductosId(i).ProductoId.ToString() & ", " & listaDeProductosId(i).Cantidad.ToString() & "," + listaDeProductosId(i).Precio.ToString().Replace(",", ".") + "," + listaDeProductosId(i).SubTotal.ToString().Replace(",", ".") + ",NULL)", db)
				insertdetalleventas.ExecuteNonQuery()
			Next
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
		helpersDa.ChequearConexion(db, "close")
	End Sub

    Public Sub Anular(id As Integer)
        helpersDa.ChequearConexion(db)

        Try
            Dim updateVentas As New SqlCommand("update ventas set estado = 2 where id = " + id.ToString(), db)
            updateVentas.ExecuteNonQuery()

            Dim ds As DataSet = Nothing
            da = New SqlDataAdapter("SELECT * FROM detalleVentas WHERE ventaId = " + id.ToString(), db)
            da.Fill(ds)

            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim insertMovimientoStock As New SqlCommand("insert into MovimientosStock VALUES(" + (ds.Tables(0).Rows(i)(2) * -1).ToString() + "," + ds.Tables(0).Rows(i)(1).ToString() + ",GETDATE())", db)
                insertMovimientoStock.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            helpersDa.ChequearConexion(db, "close")
        End Try
        helpersDa.ChequearConexion(db, "close")
    End Sub

    Public Function ObtenerUnaVenta(id As Integer)
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		sqlStr = "SELECT * FROM ventas WHERE Id = " + id.ToString()
		ds1 = New DataSet
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


	Public Function CargarGrillaVentas(ByVal parametros As Dictionary(Of String, String), orderby As List(Of Tuple(Of Integer, String, Integer)), ascOrDesc As String) As DataSet
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "set dateformat dmy select v.Id, v.Fecha,c.Nombre +' '+ c.Apellido as Nombre ,v.Total, v.estado from ventas as v inner join Clientes as c on c.Id = v.ClienteId"

		If parametros.Count <> 0 Then
			Dim count = parametros.Count
			Dim text = " where "
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
				If item.Key = "Estado" Then
					count = count - 1
					text = text & "v.estado" & " != " & item.Value & " " & If(count <> 0, " and ", "")
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
			sqlStr += orderText + " " + ascOrDesc
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

	Public Sub Registrar(listaDeProductosId As List(Of TipoDeVentasNE), clienteId As Integer)
		Dim total As Double
		For Each ventaDetalle As TipoDeVentasNE In listaDeProductosId
			total += (ventaDetalle.Precio * ventaDetalle.Cantidad)
		Next
		total = Math.Round(total, 2)

		helpersDa.ChequearConexion(db)

		Try
			Dim totalizado = total.ToString().Replace(",", ".")
			Dim insert As New SqlCommand("insert into ventas Values (GETDATE()," & clienteId & ", " & totalizado & "," + LoginDa.ChequearEnSesion() + ",1)", db)
			insert.CommandType = CommandType.Text
			insert.ExecuteNonQuery()
			For Each ventaDetalle As TipoDeVentasNE In listaDeProductosId
				Dim parcial = (ventaDetalle.Precio * ventaDetalle.Cantidad).ToString().Replace(",", ".")

				Dim insert2 As New SqlCommand("Declare @ventaID int SELECT @ventaID = MAX(Id) FROM ventas insert into DetalleVentas VALUES(@ventaID," & ventaDetalle.ProductoId & "," & ventaDetalle.Cantidad & "," & parcial & "," & parcial & ",NULL)", db)
				insert2.ExecuteNonQuery()

				movimientoStockDA.Registrar(ventaDetalle.ProductoId, ventaDetalle.Cantidad * -1)
			Next
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
		helpersDa.ChequearConexion(db, "close")
	End Sub

	Public Function ObtenerUltimaVenta()
		helpersDa.ChequearConexion(db)
		Dim da As New SqlDataAdapter("SELECT Top(1) id from ventas order by fecha desc", db)
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
		Dim da As New SqlDataAdapter("Select  dv.id, Max(p.Nombre) as [Producto], Max(dv.subtotal / dv.cantidad) [PrecioU],
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


	Public Function GeneraGraficoCantVentasFecha(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
		helpersDa.ChequearConexion(db)

		Dim sqlStr As String
		ds1 = New DataSet
        sqlStr = "Select count(*) As cantidad, MONTH(fecha) As mes, estado from ventas " &
                    "where Fecha BETWEEN '" & fechadesde & "' and '" & fechahasta & "' and Estado=0  " &
                    "group by MONTH(fecha), estado"

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

	Public Function GeneraGraficoCantidadportipo(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
		helpersDa.ChequearConexion(db)

		Dim sqlStr As String
		ds1 = New DataSet
        sqlStr = "Select sum(cantidad) As Cantidad, t.Nombre As Nombre, v.estado from Detalleventas dv inner Join ventas v on dv.ventaid=v.id inner Join Productos p on dv.ProductoId=p.id inner Join TipoProductos t on p.TipoProductoID=t.id " &
            "where v.Fecha BETWEEN '" & fechadesde & "' and '" & fechahasta & "' and v.Estado=0 " &
            "group by t.Nombre, v.estado"


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

	Public Function GeneraGraficoTotalportipo(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
		helpersDa.ChequearConexion(db)

		Dim sqlStr As String
		ds1 = New DataSet
        sqlStr = "Select sum(v.Total) As total, t.Nombre As Nombre, v.estado from Detalleventas dv inner Join ventas v on dv.ventaid=v.id inner Join Productos p on dv.ProductoId=p.id inner Join TipoProductos t on p.TipoProductoID=t.id " &
            "where v.Fecha BETWEEN '" & fechadesde & "' and '" & fechahasta & "'and v.Estado=0  " &
            "group by t.Nombre, v.estado"


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




	Public Function GeneraGraficoFacturacionPorMes(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
		helpersDa.ChequearConexion(db)

		Dim sqlStr As String
		ds1 = New DataSet
        sqlStr = "select sum(total) AS Facturacion, MONTH(fecha) as Mes, estado from ventas " &
"where Fecha BETWEEN '" & fechadesde & "' and '" & fechahasta & "' and Estado=0 " &
"group by MONTH(Fecha), estado"


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

	Public Function GeneraGraficoCantidadVendedor(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
		helpersDa.ChequearConexion(db)

		Dim sqlStr As String
		ds1 = New DataSet
        sqlStr = "select cast (round ( count(v.total) * 100.00/ sum(count(v.total)) over(),2) as numeric(10,2)) as cantidad , u.UserName, v.estado from Detalleventas dv inner join ventas v on dv.VentaId=v.id inner join Productos p on dv.ProductoId=p.id inner join Usuarios u on v.UsuarioId=u.id " &
"where v.Fecha BETWEEN '" & fechadesde & "' and '" & fechahasta & "' and v.Estado=0 " &
"group by u.UserName , v.estado"


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





	Public Sub Controlfecha(ByVal fechadesde As String, ByVal fechahasta As String)
		Try

			helpersDa.ChequearConexion(db)
			Dim control As New SqlCommand("set dateformat ymd select count(*) from ventas where Fecha BETWEEN '" & fechadesde & " 00:00:00' and '" & fechahasta & " 23:59:59' ", db)
			control.CommandType = CommandType.Text
			Rs = control.ExecuteReader()
			Rs.Read()
			contador = Rs(0)

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
		helpersDa.ChequearConexion(db, "close")
	End Sub

End Class
