Imports System.Data.SqlClient
Imports ClaseNe
Public Class ComprasDA
	Private db As New SqlConnection
	Private helpersDa As New HelpersDA
	Private com As New SqlCommand
	Private da As SqlDataAdapter
	Private ds1 As DataSet
	Private movimientoStockDA As New MovimientoStockDA


	Public Sub New()
		Dim objcon As New ConexionDA
		db = objcon.Abrir
		com.Connection = db
	End Sub

	Public Function ObtenerUnaCompra(id As Integer)
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		sqlStr = "SELECT * FROM Compras WHERE Id = " + id
		ds1 = New DataSet
		Try
			da = New SqlDataAdapter(sqlStr, db)
			da.Fill(ds1)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
		End Try
		Return ds1
	End Function


	Public Function CargarGrillaCompras(ByVal parametros As Dictionary(Of String, String)) As DataSet
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "set dateformat dmy select c.Id, c.Fecha,p.Nombre +' '+ p.Apellido as Nombre ,c.Total from compras as c inner join Proveedores as p on p.Id = c.ProveedorId"

		If parametros.Count <> 0 Then
			Dim count = parametros.Count
			Dim text = " where "
			For Each item As KeyValuePair(Of String, String) In parametros
				If item.Key = "ProveedorId" Then
					count = count - 1
					text = text & "c.id" & " = " & item.Value & " " & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "FechaDesde" And Not parametros.Keys.Contains("FechaHasta") Then
					count = count - 1
					text = text & "c.fecha" & " between '" & item.Value & " 00:00:00' and '" & item.Value & " 23:59:59'" & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "FechaDesde" And parametros.Keys.Contains("FechaHasta") Then
					count = count - 1
					text = text & "c.fecha" & " between '" & item.Value & " 00:00:00' and "
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

	Public Sub Registrar(listaDeProductosId As List(Of TipoDeComprasNE), proveedorId As Integer, nroComprobante As String)
		Dim total As Double
		For Each compraDetalle As TipoDeComprasNE In listaDeProductosId
			total += (compraDetalle.Precio * compraDetalle.Cantidad)
		Next
		total = Math.Round(total, 2)

		helpersDa.ChequearConexion(db)


		Try
			Dim totalizado = total.ToString().Replace(",", ".")
			Dim insert As New SqlCommand("insert into compras Values (GETDATE()," & proveedorId & ", " & totalizado & ",1)", db)
			insert.CommandType = CommandType.Text
			insert.ExecuteNonQuery()
			For Each compraDetalle As TipoDeComprasNE In listaDeProductosId
				Dim parcial = (compraDetalle.Precio * compraDetalle.Cantidad).ToString().Replace(",", ".")

				Dim insert2 As New SqlCommand("Declare @compraID int SELECT @compraID = MAX(Id) FROM compras insert into DetalleCompras VALUES(@compraID," & compraDetalle.ProductoId & "," & compraDetalle.Cantidad & "," & parcial & "," & parcial & ",NULL)", db)
				insert2.ExecuteNonQuery()

				movimientoStockDA.Registrar(compraDetalle.ProductoId, compraDetalle.Cantidad)
			Next
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
	End Sub

	Public Function ObtenerUltimaCompra()
		helpersDa.ChequearConexion(db)
		Dim da As New SqlDataAdapter("Select Max(id) as [Id] from compras", db)
		Dim ds As New DataSet
		Try
			da.Fill(ds)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
		End Try

		Return ds

	End Function

	Public Function ObtenerDatosCliente(ByVal idcompra As String)
		helpersDa.ChequearConexion(db)
		Dim da As New SqlDataAdapter("Select c.Nombre + ', ' + c.Apellido as [NombreCliente],
                                      td.Descripcion as [TipoDoc], c.NumeroDocumento as [NroDoc],
                                      c.Calle + ', ' + Convert(varchar(10),c.NumeroCalle) as [Domicilio], v.Total as [Total] From Compras as v
                                      INNER JOIN proveedores as c on c.Id = v.ProveedorId
                                      INNER JOIN TipoDocumentos as td on td.Id = c.TipoDocumentoId
                                      Where v.Id = " & idcompra & " ", db)
		Dim ds As New DataSet
		Try
			da.Fill(ds)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
		End Try

		Return ds
	End Function

	Public Function ObtenerDatosProducto(ByVal idcompra As String)
		helpersDa.ChequearConexion(db)
		Dim da As New SqlDataAdapter("Select  dv.id, Max(p.Nombre) as [Producto], Max(p.Precio) [PrecioU],
		                                Max(u.Nombre) as [UnidadMedida],
		                                Max(dv.cantidad) as [Cantidad], Max(dv.Subtotal) as [Subtotal] from compras as v 
                                        INNER JOIN DetalleCompras as dv on dv.CompraId = v.Id 
                                        INNER JOIN Productos as p on p.id = dv.ProductoId
                                        INNER JOIN UnidadesDePeso as u on u.id = p.UnidadDePeso Where v.Id = " & idcompra & " Group by dv.id", db)
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

