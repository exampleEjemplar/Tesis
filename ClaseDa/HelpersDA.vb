Imports System.Data.SqlClient

Public Class HelpersDA

	Private db As New SqlConnection
	Private dbList As New List(Of SqlConnection)
	Private com As New SqlCommand
	Private ds As DataSet
	Public respuesta As SqlDataReader

	Public Sub New()
		Dim objcon As New ConexionDA
		db = objcon.Abrir
		db = objcon.Cerrar
		com.Connection = db
	End Sub

	Public Function ChequearConexion(ByVal db As SqlConnection, Optional force As String = "")
		If force = "close" Then
			If Not db.State = ConnectionState.Closed Then
				db.Close()
			End If
		Else
			If Not db.State = ConnectionState.Open Then
				db.Open()
			End If
		End If
		Return db
	End Function

	Public Function LlenarUnidadDePeso()
		ChequearConexion(db)
		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select * from UnidadesDePeso Order By Nombre "
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			ChequearConexion(db, "close")
		End Try
		ChequearConexion(db, "close")
		Return ds

	End Function

	Public Function ContarFilas(tabla As String)
		ChequearConexion(db)
		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select count(*) from " + tabla
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			ChequearConexion(db, "close")
		End Try
		ChequearConexion(db, "close")
		Return ds
		'
	End Function


	Public Function CargarCMBProvincias()
		ChequearConexion(db)

		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select * from Provincias Order By Nombre "
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
			ChequearConexion(db, "close")
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			ChequearConexion(db, "close")
		End Try
		Return ds

	End Function

	Public Function CargarCMBLocalidadesUnico(ByVal idLoc As Integer)
		ChequearConexion(db)

		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select Id, Nombre, ProvinciaId from Ciudades where Id= " & idLoc
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			ChequearConexion(db, "close")
		End Try
		ChequearConexion(db, "close")
		Return ds

	End Function

	Public Function CargarCMBLocalidades(ByVal idprov As Integer)
		ChequearConexion(db)
		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select Id, Nombre, ProvinciaId from Ciudades where ProvinciaId= " & idprov & " order by nombre"
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			ChequearConexion(db, "close")
		End Try
		ChequearConexion(db, "close")
		Return ds
	End Function

	Public Function CargarCMBDoc(ByVal FoJ As String) As DataSet
		ChequearConexion(db)
		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "SELECT * FROM TipoDocumentos where FisicaOJuridica = '" & FoJ & "'Order by Descripcion"
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			ChequearConexion(db)
		End Try
		ChequearConexion(db)
		Return ds
	End Function

	Public Function ValidarSiExisteDni(ByVal numero As Double, ByVal entidad As String) As Boolean
		ChequearConexion(db)
		Dim sqlStr As String
		Dim dt = New DataTable
		sqlStr = "SELECT * FROM " & entidad & " where NumeroDocumento =" & numero
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(dt)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			ChequearConexion(db, "close")
			Return True
		End Try
		ChequearConexion(db, "close")
		If dt.Rows.Count = 0 Then
			Return False
		Else
			Return True
		End If
		Return False
	End Function

	Public Function ValidarSiExisteUserName(ByVal usrName As String) As Boolean
		ChequearConexion(db)

		Dim sqlStr As String
		Dim dt = New DataTable
		sqlStr = "SELECT * FROM usuarios where username = '" & usrName & "'"
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(dt)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			ChequearConexion(db, "close")
			Return True
		End Try
		ChequearConexion(db, "close")
		If dt.Rows.Count = 0 Then
			Return False
		Else
			Return True
		End If
		Return False
	End Function

	Public Function EnSesion() As Integer
		ChequearConexion(db)
		Dim resultado As Integer
		Try
			Dim sqlStr As New SqlCommand("Select * from Ensesion", db)
			sqlStr.CommandType = CommandType.Text
			sqlStr.ExecuteNonQuery()
			respuesta = sqlStr.ExecuteReader

			If respuesta.Read Then
				resultado = CInt(respuesta.Item("UsuarioId"))
			End If
			respuesta.Close()

		Catch ex As Exception
			MsgBox(ex.ToString)
			ChequearConexion(db, "close")
		End Try
		ChequearConexion(db, "close")
		Return resultado
	End Function

	Public Function CargarCboTodosClientes()

		ChequearConexion(db)
		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select Id,Nombre +' '+ Apellido as Nombre from Clientes Order By Nombre  "
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
			ChequearConexion(db, "close")
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			ChequearConexion(db, "close")
		End Try
		Return ds

	End Function

	Public Function CargarCboTodosProveedores(ByVal proveeServicios As String)

		ChequearConexion(db)
		Dim sqlStr As String
		Dim text As String
		ds = New DataSet
		If proveeServicios = "True" Then
			text = "where proveeservicios = 'S'"
		ElseIf proveeServicios = "False" Then
			text = "where proveeservicios = 'N'"
		Else
			text = ""
		End If
		sqlStr = "select Id,Nombre +' '+ Apellido as Nombre from Proveedores " + text + " Order By Nombre"
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			ChequearConexion(db, "close")
		End Try
		ChequearConexion(db, "close")
		Return ds

	End Function

	Public Function CargarCboTodosUsuarios()

		ChequearConexion(db)
		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select Id,Username as Nombre from Usuarios Order By username  "
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			ChequearConexion(db, "close")
		End Try
		ChequearConexion(db, "close")
		Return ds

	End Function

	Public Function CargarTodosProductos(ByVal parametros As Dictionary(Of String, String), orderby As List(Of Tuple(Of Integer, String, Integer)), ascOrDesc As String, esServicio As String)

		ChequearConexion(db)
		Dim sqlStr As String
		Dim innerJoin As String = ""
		If parametros.FirstOrDefault(Function(x) x.Key = "ClienteId").Key IsNot Nothing Then
			innerJoin = "inner join DetallePedidos dp on dp.ProductoId = p.id inner join pedidos ped on dp.PedidoId = ped.Id "
		End If
		ds = New DataSet
		sqlStr = "set dateformat dmy select p.Id,p.Nombre,p.Foto,cast((( P.precio * P.utilidad)/100+(P.precio)) as decimal(10,2)) as 'Precio de Venta',prov.Nombre as Proveedor, prov.id, p.FechaAlta as 'Fecha de Alta', p.CategoriaId, P.precio as 'Precio de Costo' from Productos as p inner join proveedores as prov on prov.id = p.ProveedorId " + innerJoin

		If parametros.Count <> 0 Then
			Dim count = parametros.Count
			Dim text = " where "
			If Not String.IsNullOrWhiteSpace(esServicio) Then
				text += " p.esServicio='S' and "
			Else
				text += " p.esServicio='N' and "
			End If
			For Each item As KeyValuePair(Of String, String) In parametros
				If item.Key = "ProveedorId" Then
					count = count - 1
					text = text & "prov.id" & " = " & item.Value & " " & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "ClienteId" Then
					count = count - 1
					text = text & "ped.ClienteId" & " = " & item.Value & " " & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "Nombre" Then
					count = count - 1
					text = text & "p.Nombre" & " like '%" & item.Value & "%' " & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "FechaDesde" And Not parametros.Keys.Contains("FechaHasta") Then
					count = count - 1
					text = text & "p.fechaAlta" & " between '" & item.Value & " 00:00:00' and '" & item.Value & " 23:59:59'" & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "FechaDesde" And parametros.Keys.Contains("FechaHasta") Then
					count = count - 1
					text = text & "p.fechaAlta" & " between '" & item.Value & " 00:00:00' and "
					Continue For
				End If
				If item.Key = "FechaHasta" Then
					count = count - 1
					text = text & "'" & item.Value & " 23:59:59' " & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "EsReparacion" Then
					count = count - 1
					text = text & "p.EsParaReparacion" & " = '" & item.Value & "' " & If(count <> 0, " and ", "")
					Continue For
				End If
			Next
			sqlStr = sqlStr + text
		Else
			If Not String.IsNullOrWhiteSpace(esServicio) Then
				sqlStr += " where p.esServicio='S' "
			Else
				sqlStr += "where p.esServicio='N' "
			End If
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
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			ChequearConexion(db, "close")
		End Try
		ChequearConexion(db, "close")
		Return ds
	End Function
End Class
