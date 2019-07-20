Imports System.Data.SqlClient

Public Class HelpersDA

	Private db As New SqlConnection
	Private com As New SqlCommand
	Private ds As DataSet
	Public respuesta As SqlDataReader

	Public Sub New()
		Dim objcon As New ConexionDA
		db = objcon.Abrir
		com.Connection = db
	End Sub

	Public Function ChequearConexion(ByVal db As SqlConnection)
		If (db.State = ConnectionState.Closed) Then
			db.Open()
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
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return ds

	End Function


	Public Function CargarCMBProvincias()
		ChequearConexion(db)

		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select * from Provincias Order By Nombre "
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

	Public Function CargarCMBLocalidadesUnico(ByVal idLoc As Integer)
		ChequearConexion(db)

		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select Id, Nombre, ProvinciaId from Ciudades where Id= " & idLoc
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

	Public Function CargarCMBLocalidades(ByVal idprov As Integer)
		ChequearConexion(db)

		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select Id, Nombre, ProvinciaId from Ciudades where ProvinciaId= " & idprov & " order by nombre"
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

	Public Function CargarCMBDoc(ByVal FoJ As String) As DataSet
		ChequearConexion(db)

		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "SELECT * FROM TipoDocumentos where FisicaOJuridica = '" & FoJ & "'Order by Descripcion"
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

	Public Function ValidarSiExisteDni(ByVal numero As Double, ByVal entidad As String) As Boolean
		ChequearConexion(db)

		Dim sqlStr As String
		Dim dt = New DataTable
		sqlStr = "SELECT * FROM " & entidad & " where NumeroDocumento =" & numero
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(dt)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
			Return True
		End Try
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
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
			Return True
		End Try
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
			db.Close()
		End Try
		db.Close()
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
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return ds

	End Function

	Public Function CargarCboTodosProveedores()

		ChequearConexion(db)
		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select Id,Nombre +' '+ Apellido as Nombre from Proveedores Order By Nombre  "
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

	Public Function CargarCboTodosUsuarios()

		ChequearConexion(db)
		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "select Id,Username as Nombre from Usuarios Order By username  "
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

	Public Function CargarTodosProductos(ByVal parametros As Dictionary(Of String, String))

		ChequearConexion(db)
		Dim sqlStr As String
		ds = New DataSet
		sqlStr = "set dateformat dmy select p.Id,p.Nombre,p.Foto,p.Precio,prov.Nombre as Proveedor from Productos as p inner join proveedores as prov on prov.id = p.ProveedorId "

		If parametros.Count <> 0 Then
			Dim count = parametros.Count
			Dim text = " where "
			For Each item As KeyValuePair(Of String, String) In parametros
				If item.Key = "ProveedorId" Then
					count = count - 1
					text = text & "prov.id" & " = " & item.Value & " " & If(count <> 0, " and ", "")
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
			Next
			sqlStr = sqlStr + text + " order By ProveedorId "
		End If


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
End Class
