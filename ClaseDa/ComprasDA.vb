Imports System.Data.SqlClient
Imports ClaseNe
Public Class ComprasDA
	Private db As New SqlConnection
	Private helpersDa As New HelpersDA
	Private com As New SqlCommand
	Private da As SqlDataAdapter
	Private ds1 As DataSet
	Private movimientoStockDA As New MovimientoStockDA
	Private LoginDa As New MetodoLoginDA
	Dim Rs As SqlDataReader
	Public contador As Integer

	Public Sub New()
		Dim objcon As New ConexionDA
		db = objcon.Abrir
		db = objcon.Cerrar
		com.Connection = db
	End Sub

    Public Sub Anular(id As Integer)
        helpersDa.ChequearConexion(db)

        Try
            Dim updateVentas As New SqlCommand("update compras set estado = 2 where id = " + id.ToString(), db)
            updateVentas.ExecuteNonQuery()

            Dim ds As New DataSet
            Dim sqlstr = "SELECT * FROM detallecompras WHERE compraId = " + id.ToString()
            da = New SqlDataAdapter(sqlStr, db)
            da.Fill(ds)

            For i = 0 To ds.Tables(0).Rows.Count - 1
                Dim insertMovimientoStock As New SqlCommand("insert into MovimientosStock VALUES(" + (ds.Tables(0).Rows(i)(3) * -1).ToString() + "," + ds.Tables(0).Rows(i)(2).ToString() + ",GETDATE())", db)
                insertMovimientoStock.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            helpersDa.ChequearConexion(db, "close")
        End Try
        helpersDa.ChequearConexion(db, "close")
    End Sub

    Public Function ObtenerUnaCompra(id As Integer)
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		sqlStr = "SELECT * FROM Compras WHERE Id = " + id.ToString()
		ds1 = New DataSet
		Try
			da = New SqlDataAdapter(sqlStr, db)
			da.Fill(ds1)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db,"close")
		End Try
		helpersDa.ChequearConexion(db,"close")
		Return ds1
	End Function

	Function ChequearSiExisteNumeroComprobante(proveedorId As Integer, nroComprobante As String) As Boolean
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		sqlStr = "SELECT * FROM Compras WHERE nrocomprobante = '" + nroComprobante + "' and proveedorId = " + proveedorId.ToString()
		ds1 = New DataSet
		Try
			da = New SqlDataAdapter(sqlStr, db)
			da.Fill(ds1)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db,"close")
		End Try
		helpersDa.ChequearConexion(db,"close")
		If ds1.Tables(0).Rows.Count > 0 Then
			Return True
		Else
			Return False
		End If
	End Function


	Public Function CargarGrillaCompras(ByVal parametros As Dictionary(Of String, String), orderby As List(Of Tuple(Of Integer, String, Integer)), ascOrDesc as string) As DataSet
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "set dateformat dmy select c.Id, c.Fecha,p.Nombre +' '+ p.Apellido as Nombre ,c.Total, c.estado from compras as c inner join Proveedores as p on p.Id = c.ProveedorId"

		If parametros.Count <> 0 Then
			Dim count = parametros.Count
			Dim text = " where "
			For Each item As KeyValuePair(Of String, String) In parametros
				If item.Key = "ProveedorId" Then
					count = count - 1
					text = text & "c.Proveedorid" & " = " & item.Value & " " & If(count <> 0, " and ", "")
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
				If item.Key = "Estado" Then
					count = count - 1
					text = text & "c.estado" & " != " & item.Value & " " & If(count <> 0, " and ", "")
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

	Public Sub Registrar(listaDeProductosId As List(Of TipoDeComprasNE), proveedorId As Integer, nroComprobante As String)
		Dim total As Double
		For Each compraDetalle As TipoDeComprasNE In listaDeProductosId
			total += (compraDetalle.Precio * compraDetalle.Cantidad)
		Next
		total = Math.Round(total, 2)
		helpersDa.ChequearConexion(db)

		Try
			Dim totalizado = total.ToString().Replace(",", ".")
			Dim insert As New SqlCommand("insert into compras Values (GETDATE()," & proveedorId & ", " & totalizado & "," + LoginDa.ChequearEnSesion() + ",'" + nroComprobante + "', 1)", db)
			insert.CommandType = CommandType.Text
			insert.ExecuteNonQuery()
			For Each compraDetalle As TipoDeComprasNE In listaDeProductosId
				Dim parcial = (compraDetalle.Precio * compraDetalle.Cantidad).ToString().Replace(",", ".")

				Dim insert2 As New SqlCommand("Declare @compraID int SELECT @compraID = MAX(Id) FROM compras insert into DetalleCompras VALUES(@compraID," & compraDetalle.ProductoId & "," & compraDetalle.Cantidad & "," & parcial & "," & parcial & ",NULL)", db)
				insert2.ExecuteNonQuery()

				movimientoStockDA.Registrar(compraDetalle.ProductoId, compraDetalle.Cantidad)
			Next
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db,"close")
		End Try
		helpersDa.ChequearConexion(db,"close")
	End Sub

	Public Function ObtenerUltimaCompra()
		helpersDa.ChequearConexion(db)
		Dim da As New SqlDataAdapter("SELECT Top(1) id from compras order by fecha desc", db)
		Dim ds As New DataSet
		Try
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db,"close")
		End Try
		helpersDa.ChequearConexion(db,"close")
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
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db,"close")
		End Try
		helpersDa.ChequearConexion(db,"close")
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
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db,"close")
		End Try
		helpersDa.ChequearConexion(db,"close")
		Return ds
	End Function

	Public Function GeneraGraficoMontoComprasPorMes(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
        sqlStr = "select sum(total) AS 'Total', MONTH(fecha) as Mes from compras " &
                            "where Fecha BETWEEN '" & fechadesde & "' and '" & fechahasta & "' and Estado=0 " &
                            "group by MONTH(Fecha)"
        Try
			da = New SqlDataAdapter(sqlStr, db)
			da.Fill(ds1)
			helpersDa.ChequearConexion(db,"close")
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db,"close")
		End Try
		helpersDa.ChequearConexion(db,"close")
		Return ds1
	End Function

	Public Function GeneraGraficoCompracantportipo(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
		helpersDa.ChequearConexion(db)

		Dim sqlStr As String
		ds1 = New DataSet
        sqlStr = "select cast (round ( count(c.total) * 100.00/ sum(count(c.total)) over(),2) as numeric(10,2)) total, t.Nombre as nombre from compras c inner Join Detallecompras dc on c.id=dc.CompraId inner Join Productos p on dc.ProductoId=p.id  inner Join TipoProductos t on p.TipoProductoID=t.id " &
                 "where c.Fecha BETWEEN '" & fechadesde & "' and '" & fechahasta & "' and Estado=0  " &
                 "group by  t.Nombre"

        Try
			da = New SqlDataAdapter(sqlStr, db)
			da.Fill(ds1)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db,"close")
		End Try
		helpersDa.ChequearConexion(db,"close")
		Return ds1
	End Function

    Public Function GeneraGraficoMontocomprapormaterial(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        helpersDa.ChequearConexion(db)

        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select sum(c.total) as Total, mat.nombre from detallecompras dc inner join compras c on dc.CompraId = c.Id inner join Productos p on dc.ProductoId=p.id inner join Materiales mat on p.MaterialId=mat.id " &
"where FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "' and Estado=0  " &
"group by mat.nombre"

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

    Public Function GeneraGraficoCompraporproveedor(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
		helpersDa.ChequearConexion(db)

		Dim sqlStr As String
		ds1 = New DataSet
        sqlStr = " Select sum(c.Total) As Total, p.Nombre +' '+ p.apellido As Proveedor from compras c inner Join Proveedores p on c.ProveedorId=p.id  " &
                    "where Fecha BETWEEN '" & fechadesde & "' and '" & fechahasta & "' and Estado=0  " &
                    "group by p.Nombre +' '+ p.apellido"

        Try
			da = New SqlDataAdapter(sqlStr, db)
			da.Fill(ds1)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db,"close")
		End Try
		helpersDa.ChequearConexion(db,"close")
		Return ds1
	End Function


    Public Function GeneraGraficoMontocompraporusuario(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        helpersDa.ChequearConexion(db)

        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = " select sum(total) as total, u.UserName as nombre from compras c inner join usuarios u on c.usuarioid=u.id " &
                    "where c.Fecha BETWEEN '" & fechadesde & "' and '" & fechahasta & "' and Estado=0 " &
                    "group by u.username"

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
			Dim control As New SqlCommand("set dateformat ymd select count(*) from compras where Fecha BETWEEN '" & fechadesde & " 00:00:00' and '" & fechahasta & " 23:59:59' ", db)
			control.CommandType = CommandType.Text
			Rs = control.ExecuteReader()
			Rs.Read()
			contador = Rs(0)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db,"close")
		End Try
		helpersDa.ChequearConexion(db,"close")
	End Sub
End Class

