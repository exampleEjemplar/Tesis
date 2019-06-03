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

    Public qidproductos As Integer


    Public Sub New()
        Dim objcon As New ConexionDA
        db = objcon.Abrir
        com.Connection = db
    End Sub

    Public Function CargarCMBtIpo()

        Dim sqlStr As String
        ds = New DataSet
        sqlStr = "select * from categorias2 Order By nombre "
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

    Public Function LlenarCMBCategoria()

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
        '   
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
                .AddWithValue("@categoria2id", pro.TipodeProductoId)
                .AddWithValue("@UnidadDePeso", 1)
                .AddWithValue("@CategoriaId", pro.categoriaId)
                .AddWithValue("@StockODeTercero", 1)
            End With

            com.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            db.Close()
        End Try
    End Sub



    Public Function CargaGrillaproductosconbusqueda(ByVal codigo As String, ByVal nombre As String) As DataTable


        Try
            db.Open()
            com = New SqlCommand("SP_MostrarProductoconbusqueda", db)
            com.CommandType = CommandType.StoredProcedure
            With com.Parameters
                .AddWithValue("@codigo", codigo)
                .AddWithValue("@Nombre", nombre)

            End With

            com.ExecuteNonQuery()
            If com.ExecuteNonQuery() Then
                Dim da As New SqlDataAdapter(com)
                CargaGrillaproductosconbusqueda = New DataTable
                da.Fill(CargaGrillaproductosconbusqueda)

                Return CargaGrillaproductosconbusqueda
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



    Public Function CargaGrillaproductossinbusqueda(ByVal codigo As String, ByVal nombre As String) As DataTable


        Try
            db.Open()
            com = New SqlCommand("SP_MostrarProductosinbusqueda", db)
            com.CommandType = CommandType.StoredProcedure
            With com.Parameters
                .AddWithValue("@codigo", codigo)
                .AddWithValue("@Nombre", nombre)

            End With

            com.ExecuteNonQuery()
            If com.ExecuteNonQuery() Then
                Dim da As New SqlDataAdapter(com)
                CargaGrillaproductossinbusqueda = New DataTable
                da.Fill(CargaGrillaproductossinbusqueda)

                Return CargaGrillaproductossinbusqueda
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


    Public Function ConsultarCodigo()
        Try
            Dim control As New SqlCommand("select max(id) from productos", db)
            control.CommandType = CommandType.Text
            db.Open()
            Rs = control.ExecuteReader()
            Rs.Read()
            qidproductos = Rs(0)
            db.Close()
        Catch ex As Exception
            '  MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return qidproductos

    End Function


    'Public Function consultarimagen() As Byte()
    '    Dim arreglo As Byte() = Nothing

    '    Try
    '        Dim id As New SqlCommand("select foto from productos where Id=1", db)
    '        id.CommandType = CommandType.Text
    '        db.Open()
    '        Rs = id.ExecuteReader()
    '        Rs.Read()
    '        arreglo = Rs(0)

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    '    Return arreglo
    'End Function


End Class
