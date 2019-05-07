Imports System.Data.SqlClient
Imports ClaseNE

Public Class MetodoClientesDA

    Private db As New SqlConnection
    Private com As New SqlCommand
    Private da As SqlDataAdapter
    Private ds1 As DataSet
    Private ds As DataSet

    Public Sub New()
        Dim objcon As New ConexionDA
        db = objcon.Abrir
        com.Connection = db
    End Sub

    Public Function CargaGrillaclientes(ByVal busqDNI As String, ByVal busqape As String) As DataSet
        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select  p.ID, t.Descripcion , p.NumeroDocumento,  rtrim(p.NOMBRE), rtrim(p.APELLIDO), " &
        "rtrim(p.FechaNacimiento), rtrim(p.FechaAlta), rtrim(p.Calle), rtrim(p.NumeroCalle), rtrim(p.Departamento), p.CiudadId," &
        " rtrim(p.Car_Celular), rtrim(p.NumeroCelular), rtrim(p.Car_Telefono), rtrim(p.NumeroTelefono),  pro.Nombre, " &
        "p.EMAIL " &
        "from Clientes p " &
        "inner join TipoDocumentos t on t.Id = p.TipoDocumentoId " &
        "inner join Ciudades ciu on p.CiudadId = Ciu.Id " &
        "inner join Provincias Pro on p.Id = Ciu.ProvinciaId " &
        "where p.NumeroDocumento like '%" & busqDNI & "%' and rtrim(p.apellido) like '%" & busqape & "%'"
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

    Public Sub grabarClientes(ByVal cli As ClientesNE)
        Try
            Dim insert As New SqlCommand("insert into Clientes values (" & cli.TipoDocumentoId & "," & cli.NumeroDocumento & ",'" & cli.Nombre & "','" & cli.Apellido & "','" & cli.FechaNacimiento & "', getdate(), '" & cli.Calle & "', '" & cli.NumeroCalle & "', '" & cli.Departamento & "','" & cli.Barrio & "'," & cli.Piso & "," & cli.Manzana & "," & cli.Lote & "," & cli.CiudadId & " ," & cli.Car_Telefono & "," & cli.NumeroTelefono & "," & cli.Car_Celular & "," & cli.NumeroCelular & ", 'S'," & cli.UsuarioId & ",'" & cli.Email & "','" & cli.FisicaOJuridica & "')", db)
            insert.CommandType = CommandType.Text
            db.Open()
            insert.ExecuteNonQuery()
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class
