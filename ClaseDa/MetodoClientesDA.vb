


Imports System.Data.SqlClient
Imports ClaseNe

Public Class MetodoClientesDA

    Private db As New SqlConnection
    Private com As New SqlCommand
    Private da As SqlDataAdapter
    Private ds1 As DataSet
    Dim Rs As SqlDataReader
    Public contador As Integer



    Public Sub New()
        Dim objcon As New ConexionDA
        db = objcon.Abrir
        com.Connection = db
    End Sub

    Public Function ConsultaModificacion(ByVal Id As Integer) As DataSet
        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select c.FisicaOJuridica , t.Descripcion, c.NumeroDocumento,         c.Nombre, c.Apellido,         c.FechaNacimiento, c.Calle, c.NumeroCalle, ciu.iD,        c.Car_celular, c.NumeroCelular, c.Car_telefono,c.NumeroTelefono,        c.Email ,c.piso , c.Departamento, c.manzana,c.lote,c.barrio,c.Id  ,ciu.ProvinciaId,ciu.Nombre      from Clientes as c        inner join TipoDocumentos t on t.Id = c.TipoDocumentoId        inner join Ciudades ciu on c.CiudadId = Ciu.Id  where c.Id = " & Id
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


    Public Function CargaGrillaclientes(ByVal parametros As Dictionary(Of String, String)) As DataSet
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
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds1
        db.Close()
    End Function

    Public Sub GrabarClientes(ByVal cli As ClientesNE)
		Try
			Dim insert As New SqlCommand("set dateformat dmy insert into Clientes values (" & cli.TipoDocumentoId & "," & cli.NumeroDocumento & ",'" & cli.Nombre & "'," &
			"'" & cli.Apellido & "','" & cli.FechaNacimiento & "', getdate(), '" & cli.Calle & "', '" & cli.NumeroCalle & "'," & If(cli.Departamento <> "", "'" + cli.Departamento + "'", "NULL") & "," &
			If(cli.Barrio <> "", "'" + cli.Barrio + "'", "NULL") & "," & If(cli.Piso <> "", "'" + cli.Piso + "'", "NULL") & "," & If(cli.Manzana <> "", "'" + cli.Manzana + "'", "NULL") & "," & If(cli.Lote <> "", "'" + cli.Lote + "'", "NULL") & ",'" & cli.CiudadId & "' ," & If(cli.Car_Telefono <> "", "'" + cli.Car_Telefono + "'", "NULL") &
			"," & If(cli.NumeroTelefono <> "", "'" + cli.NumeroTelefono + "'", "NULL") & ",'" & cli.Car_Celular & "','" & cli.NumeroCelular & "', 'S','" & cli.UsuarioId & "','" & cli.Email &
			"','" & cli.FisicaOJuridica & "')", db)
			insert.CommandType = CommandType.Text
			db.Open()
			insert.ExecuteNonQuery()
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub ActualizarClientes(ByVal cli As ClientesNE)
        Try
            Dim insert As New SqlCommand("set dateformat dmy Update Clientes set  TipoDocumentoId = " & cli.TipoDocumentoId & ",NumeroDocumento = " & cli.NumeroDocumento & ",Nombre = '" & cli.Nombre & "',Apellido = '" & cli.Apellido & "',FechaNacimiento = '" & cli.FechaNacimiento & "',calle =  '" & cli.Calle & "',NumeroCalle = '" & cli.NumeroCalle & "',Departamento =  '" & cli.Departamento & "',Barrio = '" & cli.Barrio & "',Piso = " & cli.Piso & ",Manzana = " & cli.Manzana & ",Lote = " & cli.Lote & ",CiudadId = " & cli.CiudadId & " ,Car_Telefono = " & cli.Car_Telefono & ",NumeroTelefono = " & cli.NumeroTelefono & ",Car_Celular = " & cli.Car_Celular & ",NumeroCelular = " & cli.NumeroCelular & ",Email = '" & cli.Email & "' where Id = " & cli.Id, db)
            insert.CommandType = CommandType.Text
            db.Open()
            insert.ExecuteNonQuery()
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub



    Public Function GeneraGrafico(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet

        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select p.nombre as nombre, count(c.NumeroDocumento) as Cantidad from Clientes c " &
                  "inner join Ciudades ciu on c.CiudadId = Ciu.Id " &
                  "inner Join Provincias p on ciu.ProvinciaID = p.Id " &
                  "where FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "'" &
                  "group by p.nombre"

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




    Public Function GeneraGraficopersoneria(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet

        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select count(id) as Cantidad, FisicaOJuridica from Clientes " &
"where FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "' " &
"group by FisicaOJuridica"

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



    Public Function GeneraGraficousuario(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet

        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = " Select  COUNT(*) As contador, u.UserName as nombre FROM clientes c " &
                  "inner join Usuarios u on c.UsuarioId=u.id " &
                  "where FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "' " &
                  "GROUP BY u.UserName"

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

    Public Sub controlfecha(ByVal fechadesde As String, ByVal fechahasta As String)


        Try
            db.Open()

            Dim control As New SqlCommand("select count(*) from clientes where FechaAlta BETWEEN '" & fechadesde & "' and '" & fechahasta & "' ", db)
            control.CommandType = CommandType.Text
            Rs = control.ExecuteReader()
            Rs.Read()
            contador = Rs(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        db.Close()

    End Sub



End Class





