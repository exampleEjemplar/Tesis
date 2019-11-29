


Imports System.Data.SqlClient
Imports ClaseNe

Public Class ProveedoresDA

	Private db As New SqlConnection
	Private helpersDa As New HelpersDA
	Private com As New SqlCommand
	Private da As SqlDataAdapter
	Private ds1 As DataSet
	Public contador As Integer
	Dim Rs As SqlDataReader

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
		sqlStr = "select c.FisicaOJuridica , t.Descripcion, c.NumeroDocumento,         c.Nombre, c.Apellido,         c.FechaNacimiento, c.Calle, c.NumeroCalle, ciu.iD,        c.Car_celular, c.NumeroCelular, c.Car_telefono,c.NumeroTelefono,        c.Email ,c.piso , c.Departamento, c.manzana,c.lote,c.barrio,c.Id  ,ciu.ProvinciaId,ciu.Nombre ,c.proveeservicios     from Proveedores as c        inner join TipoDocumentos t on t.Id = c.TipoDocumentoId        inner join Ciudades ciu on c.CiudadId = Ciu.Id  where c.Id = " & Id
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

	Public Function CargaGrillaProveedores(ByVal parametros As Dictionary(Of String, String), orderby As List(Of Tuple(Of Integer, String, Integer)), ascOrDesc as string) As DataSet
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "select p.FisicaOJuridica as 'Tipo de Persona', t.Descripcion as 'Tipo de Dni', p.NumeroDocumento as 'Numero de identificacion', " &
			  "p.Nombre as 'Nombre - Nombre de Fantasia', p.Apellido as 'Apellido - Razon Social', " &
			  "p.FechaNacimiento as 'Nacimiento', p.FechaAlta as 'Fecha de Alta', p.Calle, p.NumeroCalle as 'Numero de calle', ciu.Nombre As Ciudad," &
			  "CONCAT(p.Car_Celular, '-', cast(p.NumeroCelular as int)) as Celular, CONCAT(p.Car_telefono, '-', cast(p.NumeroTelefono as int)) as Telefono," &
			  "p.Email , p.id " &
			  "from Proveedores as p " &
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
				Dim value As Decimal
				If Decimal.TryParse(parametro.Value, value) Then
					extraText = extraText & " p." & parametro.Key & " = " & parametro.Value 'TODO mejorar busqueda para integers
				Else
					extraText = extraText & " p." & parametro.Key & " like '%" & parametro.Value & "%'" 'TODO mejorar busqueda para integers
				End If
				count = count + 1
			Next
			sqlStr = sqlStr & extraText
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

	Public Function CargaGrillaProveedoreslistado(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "select p.FisicaOJuridica as 'Tipo de Persona', t.Descripcion as 'Tipo de Dni', p.NumeroDocumento as 'Numero de identificacion', " &
			 "p.Nombre as 'Nombre - Nombre de Fantasia', p.Apellido as 'Apellido - Razon Social', " &
			 "p.FechaNacimiento as 'Nacimiento', p.FechaAlta as 'Fecha de Alta', p.Calle, p.NumeroCalle as 'Numero de calle', ciu.Nombre As Ciudad," &
			 "p.Car_celular +' '+ p.NumeroCelular as Celular, p.Car_telefono+' '+ p.NumeroTelefono as Telefono," &
			 "p.Email , p.id " &
			 "from Proveedores as p " &
			 "inner join TipoDocumentos t on t.Id = p.TipoDocumentoId " &
			 "inner join Ciudades ciu on p.CiudadId = Ciu.Id  " &
			 "where FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "'"


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

	Public Sub GrabarProveedores(ByVal cli As ProveedoresNE)
		helpersDa.ChequearConexion(db)
		Try
			Dim insert As New SqlCommand("set dateformat dmy insert into Proveedores values (" & cli.TipoDocumentoId & "," & cli.NumeroDocumento & "," & If(cli.Nombre <> "", "'" + cli.Nombre + "'", "NULL") & "," &
			If(cli.Apellido <> "", "'" + cli.Apellido + "'", "NULL") & "," & If(cli.FechaNacimiento.ToString("dd/MM/yyyy") <> "", "'" + cli.FechaNacimiento.ToString("dd/MM/yyyy") + "'", "NULL") & ", getdate(), " & If(cli.Calle <> "", "'" + cli.Calle + "'", "NULL") & ", " & If(cli.NumeroCalle <> "", "'" + cli.NumeroCalle + "'", "NULL") & "," & If(cli.Departamento <> "", "'" + cli.Departamento + "'", "NULL") & "," &
			If(cli.Barrio <> "", "'" + cli.Barrio + "'", "NULL") & "," & If(cli.Piso <> "", "'" + cli.Piso + "'", "NULL") & "," & If(cli.Manzana <> "", "'" + cli.Manzana + "'", "NULL") & "," & If(cli.Lote <> "", "'" + cli.Lote + "'", "NULL") & ",'" & cli.CiudadId & "' ," & If(cli.Car_Telefono <> "", "'" + cli.Car_Telefono + "'", "NULL") &
			"," & If(cli.NumeroTelefono <> "", "'" + cli.NumeroTelefono + "'", "NULL") & "," & If(cli.Car_Celular <> "", "'" + cli.Car_Celular + "'", "NULL") & "," & If(cli.NumeroCelular <> "", "'" + cli.NumeroCelular + "'", "NULL") & ", 'S','" & cli.UsuarioId & "'," & If(cli.Email <> "", "'" + cli.Email + "'", "NULL") &
			",'" & cli.FisicaOJuridica & "','" & cli.ProveeServicios & "')", db)
			insert.CommandType = CommandType.Text
			insert.ExecuteNonQuery()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
		helpersDa.ChequearConexion(db, "close")
	End Sub

	Public Sub ActualizarProveedores(ByVal cli As ProveedoresNE)
		Try
			helpersDa.ChequearConexion(db)
			Dim insert As New SqlCommand("set dateformat dmy Update Proveedores set  TipoDocumentoId = " & cli.TipoDocumentoId & ",NumeroDocumento = " & cli.NumeroDocumento & ",Nombre = " & If(cli.Nombre <> "", "'" + cli.Nombre + "'", "NULL") & ",Apellido = " & If(cli.Apellido <> "", "'" + cli.Apellido + "'", "NULL") & ",FechaNacimiento = " & If(cli.FechaNacimiento.ToString() <> "", "'" + cli.FechaNacimiento.ToString("dd/MM/yyyy") + "'", "NULL") & ",calle =  " & If(cli.Calle <> "", "'" + cli.Calle + "'", "NULL") & ",NumeroCalle = " & If(cli.NumeroCalle.ToString() <> "", "'" + cli.NumeroCalle + "'", "NULL") & ",Departamento =  " & If(cli.Departamento <> "", "'" + cli.Departamento + "'", "NULL") & ",Barrio = " & If(cli.Barrio <> "", "'" + cli.Barrio + "'", "NULL") & ",Piso = " & If(cli.Piso.ToString() <> "", "'" + cli.Piso + "'", "NULL") & ",Manzana = " & If(cli.Manzana <> "", "'" + cli.Manzana + "'", "NULL") & ",Lote = " & If(cli.Lote <> "", "'" + cli.Lote + "'", "NULL") & ",CiudadId = " & If(cli.CiudadId.ToString() <> "", "'" + cli.CiudadId.ToString() + "'", "NULL") & " ,Car_Telefono = " & If(cli.Car_Telefono <> "", "'" + cli.Car_Telefono + "'", "NULL") & ",NumeroTelefono = " & If(cli.NumeroTelefono <> "", "'" + cli.NumeroTelefono + "'", "NULL") & ",Car_Celular = " & If(cli.Car_Celular <> "", "'" + cli.Car_Celular + "'", "NULL") & ",NumeroCelular = " & If(cli.NumeroCelular <> "", "'" + cli.NumeroCelular + "'", "NULL") & ",Email = " & If(cli.Email <> "", "'" + cli.Email + "'", "NULL ") & " where Id = " & cli.Id, db)
			insert.CommandType = CommandType.Text
			insert.ExecuteNonQuery()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
		helpersDa.ChequearConexion(db, "close")
	End Sub

	'	Public Function GeneraGrafico(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet

	'		Dim sqlStr As String
	'		ds1 = New DataSet
	'		sqlStr = "select p.nombre as nombre, count(c.NumeroDocumento) as Cantidad from Clientes c " &
	'						"inner join Ciudades ciu on c.CiudadId = Ciu.Id " &
	'						"inner Join Provincias p on ciu.ProvinciaID = p.Id " &
	'						"where FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "'" &
	'						"group by p.nombre"

	'		Try
	'			da = New SqlDataAdapter(sqlStr, db)
	'			da.Fill(ds1)
	'		Catch ex As Exception
	'			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
	'		End Try
	'		Return ds1
	'	End Function

	Public Function GeneraGraficopersoneria(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet

		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
        sqlStr = "select cast (round ( count(*) * 100.00/ sum(count(*)) over(),2) as numeric(10,2)) as cantidad , CASE FisicaOJuridica WHEN 'F' THEN 'Fisica' WHEN 'J'THEN 'Juridica'ELSE 'Unknown'end as FisicaOJuridica from Proveedores " &
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



	Public Function GeneraGraficoProveedorPorCantidadProducto(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
		helpersDa.ChequearConexion(db)

		Dim sqlStr As String
		ds1 = New DataSet
        sqlStr = "Select  COUNT(*) As contador,p.Nombre+' '+p.Apellido as nombre FROM Productos a " &
                    " inner Join Proveedores p On a.ProveedorId=p.id " &
                     "where a.FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "' and proveeservicios='N' " &
                    "Group By p.Nombre+' '+p.Apellido"


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

	Public Function GeneraGraficoPorPago(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet

		helpersDa.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "Select sum(total) As Total, p.Nombre+' '+p.Apellido as nombre FROM Pagos a " &
					"  inner Join Proveedores p on a.ProveedorId=p.id " &
					 "where a.Fecha BETWEEN '" & fechadesde & "' and '" & fechahasta & "' " &
					"Group By p.Nombre+' '+p.Apellido"



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
			Dim control As New SqlCommand("set dateformat ymd select count(*) from  Proveedores where FechaAlta BETWEEN '" & fechadesde & " 00:00:00' and '" & fechahasta & " 23:59:59' ", db)
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

    Public Function GeneraGrafico(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        helpersDa.ChequearConexion(db)

        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select p.nombre as nombre, count(c.NumeroDocumento) as Cantidad from Proveedores c " &
                        "inner join Ciudades ciu on c.CiudadId = Ciu.Id " &
                        "inner Join Provincias p on ciu.ProvinciaID = p.Id " &
                        "where FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "'" &
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

End Class





