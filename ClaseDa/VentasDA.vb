﻿Imports System.Data.SqlClient
Imports ClaseNe
Public Class VentasDA
	Private db As New SqlConnection
	Private helpersDa As New HelpersDA
	Private com As New SqlCommand
	Private da As SqlDataAdapter
	Private ds1 As DataSet

	Public Sub New()
		Dim objcon As New ConexionDA
		db = objcon.Abrir
		com.Connection = db
	End Sub


	Public Function CargarGrillaVentas(ByVal parametros As Dictionary(Of String, String)) As DataSet
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "set dateformat dmy select v.Id, v.Fecha,c.Nombre +' '+ c.Apellido as Nombre ,v.Total from ventas as v inner join Clientes as c on c.Id = v.ClienteId"

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
			Next
			sqlStr = sqlStr + text
		End If

		Try
			da = New SqlDataAdapter(sqlStr, db)
			da.Fill(ds1)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
		End Try
		Return ds1
		db.Close()
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
			Dim insert As New SqlCommand("insert into ventas Values (GETDATE()," & clienteId & ", " & totalizado & ",1)", db)
			insert.CommandType = CommandType.Text
			insert.ExecuteNonQuery()
			For Each ventaDetalle As TipoDeVentasNE In listaDeProductosId
				Dim parcial = (ventaDetalle.Precio * ventaDetalle.Cantidad).ToString().Replace(",", ".")

				Dim insert2 As New SqlCommand("Declare @ventaID int SELECT @ventaID = MAX(Id) FROM ventas insert into DetalleVentas VALUES(@ventaID," & ventaDetalle.ProductoId & "," & ventaDetalle.Cantidad & "," & parcial & "," & parcial & ",NULL)", db)
				insert2.ExecuteNonQuery()
			Next
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
	End Sub

	Public Function ObtenerUltimaVenta()
		helpersDa.ChequearConexion(db)
		Dim da As New SqlDataAdapter("Select Max(id) as [Id] from ventas", db)
		Dim ds As New DataSet
		Try
			da.Fill(ds)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
		End Try

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
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
		End Try

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
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
		End Try

		Return ds
	End Function

End Class
