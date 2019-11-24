Imports System.Data.SqlClient
Imports ClaseNe
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Text


Public Class MetodoProductoDA
	Public enunciado As SqlCommand
	Public respuesta As SqlDataReader
	Public adaptador As SqlDataAdapter
	Private db As New SqlConnection
	Private helpersDa As New HelpersDA
	Private com As New SqlCommand
	Private da As SqlDataAdapter


	Dim Rs As SqlDataReader
	Private ds As DataSet
	Public qidproductos As Integer


	Public Sub New()
		Dim objcon As New ConexionDA
		db = objcon.Abrir
		com.Connection = db
	End Sub


	Public Sub RegistrarServicio(pro As ProductosNE)
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		ds = New DataSet
		Dim valor As String = pro.precio.Replace(",", ".")
		sqlStr = "insert into productos (Nombre,ProveedorId,Precio,EsServicio,EsParaReparacion,FechaAlta) VALUES('" + pro.nombreprducto + "'," + pro.proveedorId.ToString() + ", " + valor + ",'S','N', getdate())"
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
	End Sub

	Public Function BuscaServicios(ByVal parametros As Dictionary(Of String, String))

		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		Dim ds1 = New DataSet
		Dim text = ""
		If parametros.Count <> 0 Then
			Dim count = parametros.Count
			text = " where "
			For Each item As KeyValuePair(Of String, String) In parametros
				If item.Key = "ProveedorId" Then
					count = count - 1
					text = text & "pro.id" & " = " & item.Value & " " & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "Nombre" Then
					count = count - 1
					text = text & "p.Nombre" & " = " & item.Value & " " & If(count <> 0, " and ", "")
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
		Else
			text = " where "
		End If
		sqlStr = "select p.Nombre, pro.Nombre as 'Proveedor', p.precio as 'Costo' from productos as p inner join proveedores as pro on pro.id = p.proveedorId " + text + " p.EsServicio = 'S'"

		'sqlStr = "select p.Fecha, p.Total, pro.Nombre as 'Proveedor', u.username as 'Usuario'from pagos as p inner join proveedores as pro on pro.id = p.proveedorId inner join usuarios as u on u.id = p.usuarioid"
		Try
			da = New SqlDataAdapter(sqlStr, db)
			da.Fill(ds1)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
		End Try
		Return ds1



		'helpersDa.ChequearConexion(db)
		'Dim sqlStr As String
		'ds = New DataSet
		'Dim text As String
		'If String.IsNullOrWhiteSpace(servicioNombre) Then
		'	text = "where"
		'Else
		'	text = "where p.nombre like '%" + servicioNombre + "%' and"
		'End If
		'sqlStr = "select p.Nombre, pro.Nombre, p.precio from productos as p inner join proveedores as pro on pro.id = p.proveedorId " + text + " p.EsServicio = 'S'"
		'Try
		'	Dim da As New SqlDataAdapter(sqlStr, db)
		'	da.Fill(ds)
		'	db.Close()
		'Catch ex As Exception
		'	MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
		'	db.Close()
		'End Try
		'Return ds
	End Function



	Public Function CargarTodosMovimientos(productoId As integer) As DataSet
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select m.id, m.Cantidad as Movimiento, p.Nombre, m.Fecha, pro.Nombre + ' ' + pro.Apellido as Proveedor from MovimientosStock as m inner join Productos as p on p.id = m.ProductoId inner join Proveedores as pro on pro.id = p.ProveedorId where ProductoId =  " + productoId.ToString() + " order by m.fecha desc"
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return ds
	End Function

	Public Function CargarGrillaStock(parametros As Dictionary(Of String, String)) As DataSet
		helpersDa.ChequearConexion(db)
		ds = New DataSet

		Dim text = ""
		If parametros.Count <> 0 Then
			text += " where "
			Dim count = parametros.Count
			For Each item As KeyValuePair(Of String, String) In parametros
				If item.Key = "ProveedorId" Then
					count = count - 1
					text = text & "p.proveedorid" & " = " & item.Value & " " & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "Nombre" Then
					count = count - 1
					text = text & "p.nombre" & " like '%" & item.Value & "%' " & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "FechaDesde" And Not parametros.Keys.Contains("FechaHasta") Then
					count = count - 1
					text = text & "m.fecha" & " between '" & item.Value & " 00:00:00' and '" & item.Value & " 23:59:59'" & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "FechaDesde" And parametros.Keys.Contains("FechaHasta") Then
					count = count - 1
					text = text & "m.fecha" & " between '" & item.Value & " 00:00:00' and "
					Continue For
				End If
				If item.Key = "FechaHasta" Then
					count = count - 1
					text = text & "'" & item.Value & " 23:59:59' " & If(count <> 0, " and ", "")
					Continue For
				End If
			Next
		End If

		Dim sqlStr = "set dateformat dmy SELECT p.id, p.Nombre, SUM(m.cantidad) as 'Stock Actual', p.StockMax as 'Stock Maximo',p.StockMin as 'Stock Minimo' FROM Productos as p inner join MovimientosStock as m on m.ProductoId = p.Id  " + text + "  GROUP BY p.Nombre, p.Id, p.StockMax, p.StockMin"

		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return ds
	End Function

	Public Function CargarCMBtIpo()
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select * from TipoProductos Order By Descripcion "
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return ds

	End Function

	Public Function CargarCMBmaterial()
		helpersDa.ChequearConexion(db)

		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select * from materiales Order By nombre "
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return ds

	End Function

	Public Function CargarCMBproveerdor()
		helpersDa.ChequearConexion(db)

		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select * from PROVEEDORES Order By NOMBRE "
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return ds

	End Function

	Public Function LlenarCMBCategoria()
		helpersDa.ChequearConexion(db)

		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select * from categorias Order By Nombre "
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return ds

	End Function

	Public Function Cargargrilladobleclick()
		helpersDa.ChequearConexion(db)

		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select * from productos"
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return ds

	End Function

	Public Sub ModificarPrecios(listOfProductos As IEnumerable(Of Tuple(Of Integer, Boolean, ProductosNE)), precio As String, tipo As String)
		Try
			helpersDa.ChequearConexion(db)
			'Itero todos los ids a modificar
			Dim ids = ""
			For i = 0 To listOfProductos.Count - 1
				If listOfProductos(i).Item2 = True Then
					ids += listOfProductos(i).Item3.Id.ToString()
				End If
				If Not i = listOfProductos.Count - 1 Then
					ids += ","
				End If
			Next

			'Segun el tipo de modificacion que sea es el cambio que realizo
			Dim type = ""
			If tipo = "porcentaje" Then 'Si es por porcentaje lo multiplico segun lo recibido
				type = "round(precio *" + precio + ",2)"
			ElseIf tipo = "monto" Then 'Si es precio exacto, lo igualo a lo solicitado
				type = "round(" + precio.Replace(",", ".") + ",2)"
			Else 'Si es adicion lo agrego
				type = "round(precio +" + precio.Replace(",", ".") + ",2)"
			End If

			Dim control As New SqlCommand("update Productos set precio = " + type + " where id in(" + ids + ")", db)
			control.CommandType = CommandType.Text
			control.ExecuteNonQuery()
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
	End Sub

	Friend Sub MovimientoStock(productoId As Integer, v As Double)
		Throw New NotImplementedException()
	End Sub

	Public Function CargarCMBcategoria2(ByVal idcat1 As Integer)
		helpersDa.ChequearConexion(db)

		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select * from SubCategorias2 where Id= " & idcat1
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return ds

	End Function

	Public Sub Grabarproductos(ByVal pro As ProductosNE)
		helpersDa.ChequearConexion(db)
		Try
			com = New SqlCommand("SP_RegistrarProducto", db)
			com.CommandType = CommandType.StoredProcedure

			With com.Parameters
				.AddWithValue("@Cod_Barra", pro.CodBarra)
				.AddWithValue("@Nombre", pro.nombreprducto)
				.AddWithValue("@Foto", pro.foto)
				.AddWithValue("@Precio", pro.precio)
				.AddWithValue("@Utilidad", pro.utilidad)
				.AddWithValue("@MaterialId", pro.materialid)
				.AddWithValue("@Peso", pro.peso)
				.AddWithValue("@Tamaño", pro.tamaño)
				.AddWithValue("@Color", pro.color)
				.AddWithValue("@ProveedorId", pro.proveedorId)
				.AddWithValue("@StockMin", pro.stockmin)
				.AddWithValue("@StockMax", pro.stockmax)
				.AddWithValue("@tipoProductoId", pro.TipodeProductoId)
				.AddWithValue("@UnidadDePeso", pro.Unidad)
				.AddWithValue("@CategoriaId", pro.categoriaId)
				.AddWithValue("@StockODeTercero", pro.StockODeTercero)
				.AddWithValue("@FechaAlta", Date.Now)
				.AddWithValue("@EsServicio", If(Not String.IsNullOrWhiteSpace(pro.EsServicio), pro.EsServicio, "N"))
				.AddWithValue("@EsReparacion", If(Not String.IsNullOrWhiteSpace(pro.EsReparacion), pro.EsReparacion, "N"))
				.AddWithValue("@Problema", pro.Problema)
			End With

			com.ExecuteNonQuery()

		Catch ex As Exception
			MsgBox(ex.Message)
		Finally
			db.Close()
		End Try
	End Sub

    Public Function CargaGrillaproductosconbusqueda(ByVal parametros As Dictionary(Of String, String)) As DataSet

        helpersDa.ChequearConexion(db)
        Dim sqlStr As String
        ds = New DataSet
        sqlStr = "SELECT p.id, p.Cod_Barra, p.nombre, ca.nombre,  m.Nombre,(( P.precio * P.utilidad)/100+(P.precio)) as 'Precio de Venta', p.MaterialId, p.foto, " &
                 "p.precio, p.utilidad, p.peso, p.tamaño, p.color, p.ProveedorId, p.StockMin, p.StockMax, p.UnidadDePeso,  " &
                 "p.CategoriaID, p.StockODeTercero FROM productos as p " &
                 "inner join Materiales m On p.MaterialId=m.id " &
                 "inner join categorias ca on p.CategoriaID= ca.Id"

        If parametros.Count > 0 Then
            Dim extraText As String = String.Empty
            Dim count As Integer = 0
            For Each parametro As KeyValuePair(Of String, String) In parametros
                If count <> 0 Then
                    extraText = extraText & " and "
                Else
                    extraText = " where "
                End If
                Dim value As Integer
                If Integer.TryParse(parametro.Value, value) Then
                    extraText = extraText & " p." & parametro.Key & " = " & parametro.Value 'TODO mejorar busqueda para integers
                Else
                    extraText = extraText & " p." & parametro.Key & " like '%" & parametro.Value & "%'" 'TODO mejorar busqueda para integers
                End If
                count = count + 1
            Next
            sqlStr = sqlStr & extraText
        End If

        Try
            da = New SqlDataAdapter(sqlStr, db)
            da.Fill(ds)
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            db.Close()
        End Try
        Return ds

    End Function

    Public Function CargaGrillaproductossinbusqueda(ByVal codigo As String, ByVal nombre As String, Optional esReparacion As String = "") As DataTable
		'Try
		'	helpersDa.ChequearConexion(db)
		'	Dim ds = New DataSet
		'	'com = New SqlCommand("SP_MostrarProductosinbusqueda", db)
		'	'com.CommandType = CommandType.StoredProcedure
		'	'With com.Parameters
		'	'	.AddWithValue("@codigo", codigo)
		'	'	.AddWithValue("@Nombre", nombre)
		'	'	.AddWithValue("@EsServicio", "N")

		'	'End With

		'	''com.ExecuteNonQuery()
		'	'If com.ExecuteNonQuery() Then
		'	'	Dim da As New SqlDataAdapter(com)
		'	'	CargaGrillaproductossinbusqueda = New DataTable
		'	'	da.Fill(CargaGrillaproductossinbusqueda)

		'	'	Return CargaGrillaproductossinbusqueda
		'	'Else
		'	'	Return Nothing
		'	'End If


		'Catch ex As Exception
		'	MsgBox(ex.Message)
		'	Return Nothing
		'Finally
		'	db.Close()
		'End Try
		Dim sqlstr = "SELECT p.id, p.Cod_Barra, p.nombre, ca.nombre, t.Nombre, m.Nombre,(( P.precio * P.utilidad)/100+(P.precio)) as 'Precio de Venta', p.TipoProductoID , p.MaterialId, p.foto, p.precio, p.utilidad, p.peso, p.tamaño, p.color, p.ProveedorId, p.StockMin, p.StockMax, p.TipoProductoID, p.UnidadDePeso, p.CategoriaID, p.StockODeTercero FROM productos as p inner join TipoProductos t on p.TipoProductoID=t.id inner join Materiales m On p.MaterialId=m.id inner join categorias ca on p.CategoriaID= ca.Id where p.esservicio = 'N' "
		sqlstr = If(String.IsNullOrWhiteSpace(esReparacion), sqlstr, sqlstr + " and esParaReparacion = 'S'")
		Dim dt As New DataTable
		Try
			Dim da As New SqlDataAdapter(sqlstr, db)
			da.Fill(dt)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return dt

	End Function

	Public Function CargaGrillaproductosCONbusquedaCAT(ByVal codigo As String, ByVal nombre As String, ByVal categoria As Integer) As DataTable

		'     Try
		'         helpersDa.ChequearConexion(db)
		'         com = New SqlCommand("SP_MostrarProductoconbusquedaCAT", db)
		'         com.CommandType = CommandType.StoredProcedure
		'         With com.Parameters
		'             .AddWithValue("@codigo", codigo)
		'             .AddWithValue("@Nombre", nombre)
		'             .AddWithValue("@Categoria", categoria)
		'         End With

		''com.ExecuteNonQuery()
		'If com.ExecuteNonQuery() Then
		'             Dim da As New SqlDataAdapter(com)
		'             CargaGrillaproductosCONbusquedaCAT = New DataTable
		'             da.Fill(CargaGrillaproductosCONbusquedaCAT)

		'             Return CargaGrillaproductosCONbusquedaCAT
		'         Else
		'             Return Nothing
		'         End If

		'     Catch ex As Exception
		'         MsgBox(ex.Message)
		'         Return Nothing
		'     Finally
		'         db.Close()
		'     End Try
		Dim dt As New DataTable
		Dim sqlstr = "SELECT p.id, p.Cod_Barra, p.nombre, ca.nombre, t.Nombre, m.Nombre,(( P.precio * P.utilidad)/100+(P.precio)) as 'Precio de Venta', p.TipoProductoID , p.MaterialId, p.foto,  p.precio, p.utilidad, p.peso, p.tamaño, p.color, p.ProveedorId, p.StockMin, p.StockMax, p.TipoProductoID, p.UnidadDePeso,  p.CategoriaID, p.StockODeTercero FROM productos as p inner join TipoProductos t on p.TipoProductoID=t.id inner join Materiales m On p.MaterialId=m.id inner join categorias ca on p.CategoriaID= ca.Id where" + If(String.IsNullOrWhiteSpace(codigo.ToString()), "", " p.id = " + codigo.ToString()) + If(String.IsNullOrWhiteSpace(nombre.ToString()), "", " p.nombre Like  '%" + nombre.ToString() + "%'") + If(Not String.IsNullOrWhiteSpace(categoria.ToString()) And Not categoria = 0, " p.CategoriaID = " + categoria.ToString(), "")
		Try
			Dim da As New SqlDataAdapter(sqlstr, db)
			da.Fill(dt)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return dt

	End Function

    Public Function CargaGrillaproductosCONbusquedaproducto(ByVal codigo As String, ByVal nombre As String, ByVal categoria As Integer) As DataTable

        Try
            helpersDa.ChequearConexion(db)
            com = New SqlCommand("SP_MostrarProductoconbusquedaPRODUCTO", db)
            com.CommandType = CommandType.StoredProcedure
            With com.Parameters

                .AddWithValue("@Nombre", nombre)

            End With

            com.ExecuteNonQuery()
            If com.ExecuteNonQuery() Then
                Dim da As New SqlDataAdapter(com)
                CargaGrillaproductosCONbusquedaproducto = New DataTable
                da.Fill(CargaGrillaproductosCONbusquedaproducto)

                Return CargaGrillaproductosCONbusquedaproducto
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            db.Close()
        End Try

    End Function

    Public Function CargaGrillaProductos(ByVal parametros As Dictionary(Of String, String)) As DataSet
        helpersDa.ChequearConexion(db)
        Dim sqlStr As String
        ds = New DataSet
        sqlStr = "SELECT p.id, p.Cod_Barra, p.nombre, ca.nombre,  m.Nombre,(( P.precio * P.utilidad)/100+(P.precio)) as 'Precio de Venta', p.MaterialId, p.foto, " &
                 "p.precio, p.utilidad, p.peso, p.tamaño, p.color, p.ProveedorId, p.StockMin, p.StockMax, p.UnidadDePeso,  " &
                 "p.CategoriaID, p.StockODeTercero FROM productos as p " &
                 "inner join Materiales m On p.MaterialId=m.id " &
                 "inner join categorias ca on p.CategoriaID= ca.Id"

        If parametros.Count > 0 Then
            Dim extraText As String = String.Empty
            Dim count As Integer = 0
            For Each parametro As KeyValuePair(Of String, String) In parametros
                If count <> 0 Then
                    extraText = extraText & " and "
                Else
                    extraText = " where "
                End If
                Dim value As Integer
                If Integer.TryParse(parametro.Value, value) Then
                    extraText = extraText & " p." & parametro.Key & " = " & parametro.Value 'TODO mejorar busqueda para integers
                Else
                    extraText = extraText & " p." & parametro.Key & " like '%" & parametro.Value & "%'" 'TODO mejorar busqueda para integers
                End If
                count = count + 1
            Next
            sqlStr = sqlStr & extraText
        End If

        Try
            da = New SqlDataAdapter(sqlStr, db)
            da.Fill(ds)
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            db.Close()
        End Try
        Return ds
    End Function



    Public Sub Modificarproductos(ByVal pro As ProductosNE)
		Try
			helpersDa.ChequearConexion(db)

			com = New SqlCommand("SP_ModificarProductos", db)
			com.CommandType = CommandType.StoredProcedure

			With com.Parameters
				.AddWithValue("@id", pro.Id)
				.AddWithValue("@Cod_Barra", pro.CodBarra)
				.AddWithValue("@Nombre", pro.nombreprducto)
				.AddWithValue("@Foto", pro.foto)
				.AddWithValue("@Precio", pro.precio)
				.AddWithValue("@Utilidad", pro.utilidad)
				.AddWithValue("@MaterialId", pro.materialid)
				.AddWithValue("@Peso", pro.peso)
				.AddWithValue("@Tamaño", pro.tamaño)
				.AddWithValue("@Color", pro.color)
				.AddWithValue("@ProveedorId", pro.proveedorId)
				.AddWithValue("@StockMin", pro.stockmin)
                .AddWithValue("@StockMax", pro.stockmax)
                .AddWithValue("@TipoProductoId", pro.TipodeProductoId)
                .AddWithValue("@UnidadDePeso", 1)
                .AddWithValue("@CategoriaId", pro.categoriaId)
				.AddWithValue("@StockODeTercero", pro.StockODeTercero)
			End With

			com.ExecuteNonQuery()

		Catch ex As Exception
			MsgBox(ex.Message)
		Finally
			db.Close()
		End Try
	End Sub

	Public Sub ControlID()
		Try
			helpersDa.ChequearConexion(db)

			Dim control As New SqlCommand("select max(id) +1 from productos", db)
			control.CommandType = CommandType.Text
			Rs = control.ExecuteReader()
			Rs.Read()
			qidproductos = Rs(0)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try

	End Sub

	Public Function CargarUnProducto(id As Integer, nombre As String)
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String = ""
		Dim ds1 = New DataSet
		If Not String.IsNullOrWhiteSpace(id) And Not id = 0 Then
			sqlStr = "select * from productos where id =" & id.ToString()
		ElseIf Not String.IsNullOrWhiteSpace(nombre) Then
			sqlStr = "select * from productos where nombre ='" & nombre & "'"
		End If
		Try
			da = New SqlDataAdapter(sqlStr, db)
			da.Fill(ds1)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return ds1
	End Function

End Class
