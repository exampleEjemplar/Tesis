Imports System.Data.SqlClient
Imports ClaseNe

Public Class MetodoClientesDA

	Private db As New SqlConnection
	Private helpersDa As New HelpersDA
	Private com As New SqlCommand
	Private da As SqlDataAdapter
	Private ds1 As DataSet
	Dim Rs As SqlDataReader
	Public contador As Integer


	Public Sub New()
		Dim objcon As New ConexionDA
		db = objcon.Abrir
		db = objcon.Cerrar
		com.Connection = db
	End Sub

	Public Function ConsultaModificacion(ByVal Id As Integer) As DataSet
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "select c.FisicaOJuridica , t.Descripcion, c.NumeroDocumento,         c.Nombre, c.Apellido,         c.FechaNacimiento, c.Calle, c.NumeroCalle, ciu.iD,        c.Car_celular, c.NumeroCelular, c.Car_telefono,c.NumeroTelefono,        c.Email ,c.piso , c.Departamento, c.manzana,c.lote,c.barrio,c.Id  ,ciu.ProvinciaId,ciu.Nombre      from Clientes as c        inner join TipoDocumentos t on t.Id = c.TipoDocumentoId        inner join Ciudades ciu on c.CiudadId = Ciu.Id  where c.Id = " & Id
		Try
			da = New SqlDataAdapter(sqlStr, db)
			da.Fill(ds1)
			helpersDa.ChequearConexion(db, "close")
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
		Return ds1
	End Function

	Public Function CargaGrillaclientes(ByVal parametros As Dictionary(Of String, String)) As DataSet
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "select p.FisicaOJuridica as 'Tipo de Persona', t.Descripcion as 'Tipo de Dni', p.NumeroDocumento as 'Numero de identificacion', " &
			 "p.Nombre as 'Nombre - Nombre de Fantasia', p.Apellido as 'Apellido - Razon Social', " &
			 "p.FechaNacimiento as 'Nacimiento', p.FechaAlta as 'Fecha de Alta', p.Calle, p.NumeroCalle as 'Numero de calle', ciu.Nombre As Ciudad," &
			 "p.Car_celular +' '+ p.NumeroCelular as Celular, p.Car_telefono+' '+ p.NumeroTelefono as Telefono," &
			 "p.Email , p.id " &
			 "from Clientes as p " &
			 "inner join TipoDocumentos t on t.Id = p.TipoDocumentoId " &
			 "inner join Ciudades ciu on p.CiudadId = Ciu.Id  "

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
			da.Fill(ds1)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
		helpersDa.ChequearConexion(db, "close")
		Return ds1
	End Function

	'Public Function CargaGrillaclienteslistado(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
	'	helpersDa.ChequearConexion(db,"close")
	'	Dim sqlStr As String
	'	ds1 = New DataSet
	'	sqlStr = "select p.FisicaOJuridica as 'Tipo de Persona', t.Descripcion as 'Tipo de Dni', p.NumeroDocumento as 'Numero de identificacion', " &
	'		 "p.Nombre as 'Nombre - Nombre de Fantasia', p.Apellido as 'Apellido - Razon Social', " &
	'		 "p.FechaNacimiento as 'Nacimiento', p.FechaAlta as 'Fecha de Alta', p.Calle, p.NumeroCalle as 'Numero de calle', ciu.Nombre As Ciudad," &
	'		 "p.Car_celular +' '+ p.NumeroCelular as Celular, p.Car_telefono+' '+ p.NumeroTelefono as Telefono," &
	'		 "p.Email , p.id " &
	'		 "from Clientes as p " &
	'		 "inner join TipoDocumentos t on t.Id = p.TipoDocumentoId " &
	'		 "inner join Ciudades ciu on p.CiudadId = Ciu.Id  " &
	'		 "where FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "'"


	'	Try
	'		da = New SqlDataAdapter(sqlStr, db)
	'		da.Fill(ds1)
	'	Catch ex As Exception
	'		MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
	'	End Try
	'	Return ds1
	'End Function

	Public Sub GrabarClientes(ByVal cli As ClientesNE)
		helpersDa.ChequearConexion(db)
		Try
			Dim insert As New SqlCommand("set dateformat dmy insert into Clientes values (" & cli.TipoDocumentoId & "," & cli.NumeroDocumento & "," & If(cli.Nombre <> "", "'" + cli.Nombre + "'", "NULL") & "," &
			If(cli.Apellido <> "", "'" + cli.Apellido + "'", "NULL") & "," & If(cli.FechaNacimiento.ToString("dd/MM/yyyy") <> "", "'" + cli.FechaNacimiento.ToString("dd/MM/yyyy") + "'", "NULL") & ", getdate(), " & If(cli.Calle <> "", "'" + cli.Calle + "'", "NULL") & ", " & If(cli.NumeroCalle <> "", "'" + cli.NumeroCalle + "'", "NULL") & "," & If(cli.Departamento <> "", "'" + cli.Departamento + "'", "NULL") & "," &
			If(cli.Barrio <> "", "'" + cli.Barrio + "'", "NULL") & "," & If(cli.Piso <> "", "'" + cli.Piso + "'", "NULL") & "," & If(cli.Manzana <> "", "'" + cli.Manzana + "'", "NULL") & "," & If(cli.Lote <> "", "'" + cli.Lote + "'", "NULL") & ",'" & cli.CiudadId & "' ," & If(cli.Car_Telefono <> "", "'" + cli.Car_Telefono + "'", "NULL") &
			"," & If(cli.NumeroTelefono <> "", "'" + cli.NumeroTelefono + "'", "NULL") & "," & If(cli.Car_Celular <> "", "'" + cli.Car_Celular + "'", "NULL") & "," & If(cli.NumeroCelular <> "", "'" + cli.NumeroCelular + "'", "NULL") & ", 'S','" & cli.UsuarioId & "'," & If(cli.Email <> "", "'" + cli.Email + "'", "NULL") &
			",'" & cli.FisicaOJuridica & "')", db)
			insert.CommandType = CommandType.Text
			insert.ExecuteNonQuery()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
		helpersDa.ChequearConexion(db, "close")
	End Sub

	Public Sub ActualizarClientes(ByVal cli As ClientesNE)
		Try
			helpersDa.ChequearConexion(db)

			Dim insert As New SqlCommand("set dateformat dmy Update Clientes set  TipoDocumentoId = " & cli.TipoDocumentoId & ",NumeroDocumento = " & cli.NumeroDocumento & ",Nombre = " & If(cli.Nombre <> "", "'" + cli.Nombre + "'", "NULL") & ",Apellido = " & If(cli.Apellido <> "", "'" + cli.Apellido + "'", "NULL") & ",FechaNacimiento = " & If(cli.FechaNacimiento.ToString() <> "", "'" + cli.FechaNacimiento.ToString("dd/MM/yyyy") + "'", "NULL") & ",calle =  " & If(cli.Calle <> "", "'" + cli.Calle + "'", "NULL") & ",NumeroCalle = " & If(cli.NumeroCalle.ToString() <> "", "'" + cli.NumeroCalle + "'", "NULL") & ",Departamento =  " & If(cli.Departamento <> "", "'" + cli.Departamento + "'", "NULL") & ",Barrio = " & If(cli.Barrio <> "", "'" + cli.Barrio + "'", "NULL") & ",Piso = " & If(cli.Piso.ToString() <> "", "'" + cli.Piso + "'", "NULL") & ",Manzana = " & If(cli.Manzana <> "", "'" + cli.Manzana + "'", "NULL") & ",Lote = " & If(cli.Lote <> "", "'" + cli.Lote + "'", "NULL") & ",CiudadId = " & If(cli.CiudadId.ToString() <> "", "'" + cli.CiudadId.ToString() + "'", "NULL") & " ,Car_Telefono = " & If(cli.Car_Telefono <> "", "'" + cli.Car_Telefono + "'", "NULL") & ",NumeroTelefono = " & If(cli.NumeroTelefono <> "", "'" + cli.NumeroTelefono + "'", "NULL") & ",Car_Celular = " & If(cli.Car_Celular <> "", "'" + cli.Car_Celular + "'", "NULL") & ",NumeroCelular = " & If(cli.NumeroCelular <> "", "'" + cli.NumeroCelular + "'", "NULL") & ",Email = " & If(cli.Email <> "", "'" + cli.Email + "'", "NULL ") & " where Id = " & cli.Id, db)
			insert.CommandType = CommandType.Text
			insert.ExecuteNonQuery()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
		helpersDa.ChequearConexion(db, "close")
	End Sub

	Public Function GeneraGrafico(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
		helpersDa.ChequearConexion(db)

		Dim sqlStr As String
		ds1 = New DataSet
        sqlStr = "select p.nombre as nombre, count(c.NumeroDocumento) as Cantidad from Clientes c " &
                        "inner join Ciudades ciu on c.CiudadId = Ciu.Id " &
                        "inner Join Provincias p on ciu.ProvinciaID = p.Id " &
                        "where C.FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "'" &
                        "group by p.nombre"

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

    Public Function GeneraGraficopersoneria(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        helpersDa.ChequearConexion(db)

        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select cast (round ( count(*) * 100.00/ sum(count(*)) over(),2) as numeric(10,2)) as cantidad , CASE FisicaOJuridica WHEN 'F' THEN 'Fisica' WHEN 'J'THEN 'Juridica'ELSE 'Unknown'end as FisicaOJuridica from Clientes " &
"where FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "' " &
"group by FisicaOJuridica"

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


    Public Function GeneraGraficoMontocomprapormaterial(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        helpersDa.ChequearConexion(db)

        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select sum(c.total) as Total, mat.nombre from detallecompras dc inner join compras c on dc.CompraId = c.Id inner join Productos p on dc.ProductoId=p.id inner join Materiales mat on p.MaterialId=mat.id " &
"where FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "' " &
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
    Public Function GeneraGraficousuario(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        helpersDa.ChequearConexion(db)

        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "Select  COUNT(*) As contador, u.UserName as nombre FROM clientes c " &
                 "inner join Usuarios u on c.UsuarioId=u.id " &
                 "where c.FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "' " &
                 "GROUP BY u.UserName"

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

    Public Function GeneraGraficoCantidadClientesPorFecha(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        helpersDa.ChequearConexion(db)

        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select count(*) AS contador, MONTH(c.fechaalta) as Mes from Clientes c " &
                 "where c.FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "' " &
                 "GROUP BY MONTH(c.fechaalta)"

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


    Public Function GeneraGraficoRangodeEdad(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        helpersDa.ChequearConexion(db)

        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "sELECT COUNT(*) AS clientes, ( " &
                 "Case WHEN DATEDIFF (year, clientes.FechaNacimiento, { fn NOW() }) < 25 THEN '16-24' " &
                 "WHEN DATEDIFF (year, clientes.FechaNacimiento, { fn NOW() } )< 45 THEN '25-44' " &
                 "Else '45-100' End ) As Edad From clientes " &
                 "where FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "' " &
                 "GROUP BY CASE WHEN DATEDIFF(year, clientes.FechaNacimiento, { fn NOW() }) < 25 THEN '16-24' WHEN DATEDIFF(year, Clientes.FechaNacimiento, { fn NOW() }) < 45 THEN '25-44' ELSE '45-100' END"

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
			Dim control As New SqlCommand("set dateformat ymd select count(*) from clientes where FechaAlta BETWEEN '" & fechadesde & " 00:00:00' and '" & fechahasta & " 23:59:59' ", db)
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

	Public Function CargaGrillaclienteslistado(ByVal fechadesde As String, ByVal fechahasta As String) As DataTable

		Try
			helpersDa.ChequearConexion(db)
			com = New SqlCommand("SP_MostrarProductoconbusquedaCAT", db)
			com.CommandType = CommandType.StoredProcedure
			With com.Parameters
				.AddWithValue("@fechadesde", fechadesde)
				.AddWithValue("@fechahasta", fechahasta)

			End With

			com.ExecuteNonQuery()
			If com.ExecuteNonQuery() Then
				Dim da As New SqlDataAdapter(com)
				CargaGrillaclienteslistado = New DataTable
				da.Fill(CargaGrillaclienteslistado)

				Return CargaGrillaclienteslistado
			Else
				Return Nothing
			End If

		Catch ex As Exception
			MsgBox(ex.Message)
			helpersDa.ChequearConexion(db, "close")
			Return Nothing
		End Try
		helpersDa.ChequearConexion(db, "close")
	End Function

End Class