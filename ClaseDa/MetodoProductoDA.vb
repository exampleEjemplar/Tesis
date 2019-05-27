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
    Private com As New SqlCommand
    Private da As SqlDataAdapter
    Dim Rs As SqlDataReader
    Private ds As DataSet
    Private dt As DataTable
    Public Sub New()
        Dim objcon As New ConexionDA
        db = objcon.Abrir
        com.Connection = db
    End Sub

    Public Function CargarCMBtIpo()

        Dim sqlStr As String
        ds = New DataSet
        sqlStr = "select * from TipoProductos Order By Descripcion "
        Try
            Dim da As New SqlDataAdapter(sqlStr, db)
            da.Fill(ds)
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds

    End Function

    Public Function CargarCMBmaterial()

        Dim sqlStr As String
        ds = New DataSet
        sqlStr = "select * from materiales Order By nombre "
        Try
            Dim da As New SqlDataAdapter(sqlStr, db)
            da.Fill(ds)
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds

    End Function

    Public Function CargarCMBproveerdor()

        Dim sqlStr As String
        ds = New DataSet
        sqlStr = "select * from PROVEEDORES Order By NOMBRE "
        Try
            Dim da As New SqlDataAdapter(sqlStr, db)
            da.Fill(ds)
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds

    End Function

    Public Function LlenarCMBdescripcion()

        Dim sqlStr As String
        ds = New DataSet
        sqlStr = "select * from categorias Order By Nombre "
        Try
            Dim da As New SqlDataAdapter(sqlStr, db)
            da.Fill(ds)
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds

    End Function


    Public Function CargarCMBcategoria1(ByVal idcat As Integer)

        Dim sqlStr As String
        ds = New DataSet
        sqlStr = "select * from SubCategorias1 where Id= " & idcat
        Try
            Dim da As New SqlDataAdapter(sqlStr, db)
            da.Fill(ds)
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds

    End Function

    Public Function CargarCMBcategoria2(ByVal idcat1 As Integer)

        Dim sqlStr As String
        ds = New DataSet
        sqlStr = "select * from SubCategorias2 where Id= " & idcat1
        Try
            Dim da As New SqlDataAdapter(sqlStr, db)
            da.Fill(ds)
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds

    End Function


    Public Sub Grabarproductos(ByVal pro As ProductosNE)
        '    Try
        '        Dim insert As New SqlCommand("insert into productos values (" & pro.CodBarra & ",'" & pro.nombreprducto & "'," & pro.foto & "," &
        '        pro.precio & "," & pro.utilidad & "," & pro.materialid & "," & pro.peso & "," & pro.tamaño & ",'" &
        '        pro.color & "'," & pro.proveedorId & "," & pro.stockmin & "," & pro.stockmax & "," & pro.TipodeProductoId & ",'" & pro.Unidad &
        '        "'," & pro.categoriaId & ")", db)
        '        insert.CommandType = CommandType.Text
        '        db.Open()
        '        insert.ExecuteNonQuery()
        '        db.Close()
        '    Catch ex As Exception
        '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        '    End Try
        Try
            db.Open()
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
                .AddWithValue("@TipoProductoId", pro.TipodeProductoId)
                .AddWithValue("@UnidadDePeso", 1)
                .AddWithValue("@CategoriaId", pro.categoriaId)
            End With

            com.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            db.Close()
        End Try
    End Sub



    Public Function CargaGrillaproductos(ByVal parametros As Dictionary(Of String, String)) As DataTable
        '        Dim sqlStr As String
        '        ds = New DataSet
        '        sqlStr = "select p.id, p.Cod_barra, p.nombre, p.foto, p.precio, m.nombre, p.peso, p.tamaño, p.color, pro.nombre, pro.apellido, p.stockmin," &
        '"p.stockmax, t.descripcion, cat.nombre  from productos as p " &
        '"inner join Materiales m On p.MaterialId=m.id " &
        '"inner join Proveedores pro on p.ProveedorId=pro.Id " &
        '"inner Join Categorias cat on p.CategoriaID=cat.id " &
        '"inner join TipoProductos t on p.TipoProductoId=t.id"


        '        If parametros.Count > 0 Then
        '            Dim extraText As String = String.Empty
        '            Dim count As Integer = 0
        '            For Each parametro As KeyValuePair(Of String, String) In parametros
        '                If count <> 0 Then
        '                    extraText = extraText & " And "
        '                Else
        '                    extraText = " where "
        '                End If
        '                extraText = extraText & " p." & parametro.Key & " like '%" & parametro.Value & "%'"
        '                count = count + 1
        '            Next
        '            sqlStr = sqlStr & extraText
        '        End If

        '        Try
        '            da = New SqlDataAdapter(sqlStr, db)
        '            da.Fill(ds)
        '            db.Close()
        '        Catch ex As Exception
        '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        '        End Try
        '        Return ds
        '        db.Close()

        Try
            db.Open()
            com = New SqlCommand("SP_MostrarProducto", db)
            com.CommandType = CommandType.StoredProcedure

            If com.ExecuteNonQuery() Then
                Dim da As New SqlDataAdapter(com)
                CargaGrillaproductos = New DataTable
                da.Fill(CargaGrillaproductos)

                Return CargaGrillaproductos
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



    'Public Function ConsultaModificacion(ByVal nroDoc As Integer) As DataSet
    '    Dim sqlStr As String
    '    ds1 = New DataSet
    '    sqlStr = "select c.FisicaOJuridica , t.Descripcion, c.NumeroDocumento,         c.Nombre, c.Apellido,         c.FechaNacimiento, c.Calle, c.NumeroCalle, ciu.iD,        c.Car_celular, c.NumeroCelular, c.Car_telefono,c.NumeroTelefono,        c.Email ,c.piso , c.Departamento, c.manzana,c.lote,c.barrio,c.Id  ,ciu.ProvinciaId,ciu.Nombre      from Clientes as c        inner join TipoDocumentos t on t.Id = c.TipoDocumentoId        inner join Ciudades ciu on c.CiudadId = Ciu.Id  where c.NumeroDocumento = " & nroDoc
    '    Try
    '        da = New SqlDataAdapter(sqlStr, db)
    '        da.Fill(ds1)
    '        db.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    '    Return ds1
    '    db.Close()
    'End Function


    'Public Function consultarimagen() As Byte()

    '    Dim resultado As String = ""
    '    Dim x As Integer = 0
    '    Dim arreglo As Byte() = Nothing
    '    Dim arregloTexto()


    '    Try
    '        enunciado = New SqlCommand("select foto from productos where Id=1", db)
    '        respuesta = enunciado.ExecuteReader()

    '        While respuesta.Read
    '            resultado = respuesta.Item("foto")
    '        End While

    '        'Llena un arreglo de Texto con los datos de la consulta separados por coma"'
    '        arregloTexto = resultado.Split(",")

    '        'Redimenciona el tamaño del arreglo de bytes'
    '        ReDim arreglo(arregloTexto.Length - 1)

    '        'Recorre el arreglo para llenar el arreglo de Bytes con el arreglo de la consulta'

    '        For x = 0 To arregloTexto.Length - 1
    '            If arregloTexto(x).Equals("") = False Then
    '                arreglo(x) = arregloTexto(x)
    '            End If
    '        Next

    '        respuesta.Close()
    '    Catch ex As Exception

    '    End Try

    '    Return arreglo

    'End Function

    Public Function consultarimagen() As Byte()
        Dim arreglo As Byte() = Nothing

        Try
            Dim id As New SqlCommand("select foto from productos where Id=1", db)
            id.CommandType = CommandType.Text
            db.Open()
            Rs = id.ExecuteReader()
            Rs.Read()
            arreglo = Rs(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return arreglo
    End Function


End Class
