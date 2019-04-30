Imports System.Data
Imports System.Data.SqlClient
Imports ClaseNE

Public Class ProveedoresDA

    Private db As New SqlConnection
    Private com As New SqlCommand
    Private da As SqlDataAdapter
    Private ds1 As DataSet

    Public Sub New()
        Dim objcon As New ConexionDA
        db = objcon.Abrir
        com.Connection = db
    End Sub

    Public Function CargaGrillaproveedores(ByVal busqDNI As String, ByVal busqape As String) As DataSet

        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select  p.ID, t.Descripcion , p.NumeroDocumento,  rtrim(p.NOMBRE), rtrim(p.APELLIDO), " &
        "rtrim(p.FechaNacimiento), rtrim(p.FechaAlta), rtrim(p.Calle), rtrim(p.NumeroCalle), rtrim(p.Departamento), p.CiudadId," &
        " rtrim(p.Car_Celular), rtrim(p.NumeroCelular), rtrim(p.Car_Telefono), rtrim(p.NumeroTelefono),  pro.Nombre, " &
        "p.EMAIL " &
        "from Proveedores p " &
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

    Public Sub grabarProveedores(ByVal pro As ProveedoresNE)
        Try
            Dim usuarioId As Integer = 1 'TODO Cambiarlo, lo hice para que no rompa (son las 3:41 del 30/4)
            Dim insert As New SqlCommand("insert into Proveedores values (" & pro.TipoDocumentoId & "," & pro.NumeroDocumento & ",'" & pro.Nombre & "','" & pro.Apellido & "','" & pro.FechaNacimiento & "', getdate(), '" & pro.Calle & "', '" & pro.NumeroCalle & "', '" & pro.Departamento & "','" & pro.Barrio & "'," & pro.Piso & "," & pro.Manzana & "," & pro.Lote & "," & pro.CiudadId & " ," & pro.Car_Telefono & "," & pro.NumeroTelefono & "," & pro.Car_Celular & "," & pro.NumeroCelular & ", 'S'," & usuarioId & ",'" & pro.Email & "','" & pro.FisicaOJuridica & "')", db)
            insert.CommandType = CommandType.Text
            db.Open()
            insert.ExecuteNonQuery()
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
