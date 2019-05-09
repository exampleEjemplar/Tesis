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

    Public Function CargarCMBProvincias()

        Dim sqlStr As String
        ds = New DataSet
        sqlStr = "select * from Provincias Order By Nombre "
        Try
            Dim da As New SqlDataAdapter(sqlStr, db)
            da.Fill(ds)
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds

    End Function

    Public Function CargarCMBLocalidadesUnico(ByVal idLoc As Integer)

        Dim sqlStr As String
        ds = New DataSet
        sqlStr = "select Id, Nombre, ProvinciaId from Ciudades where Id= " & idLoc
        Try
            Dim da As New SqlDataAdapter(sqlStr, db)
            da.Fill(ds)
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds

    End Function

    Public Function CargarCMBLocalidades(ByVal idprov As Integer)

        Dim sqlStr As String
        ds = New DataSet
        sqlStr = "select Id, Nombre, ProvinciaId from Ciudades where ProvinciaId= " & idprov
        Try
            Dim da As New SqlDataAdapter(sqlStr, db)
            da.Fill(ds)
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds

    End Function

    Public Function CargarCMBDoc(ByVal FoJ As String) As DataSet

        Dim sqlStr As String
        ds = New DataSet
        sqlStr = "SELECT * FROM TipoDocumentos where FisicaOJuridica = '" & FoJ & "'Order by Descripcion"
        Try
            Dim da As New SqlDataAdapter(sqlStr, db)
            da.Fill(ds)
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function

    Public Function ValidarSiExisteDni(ByVal numero As Double, ByVal entidad As String) As Boolean

        Dim sqlStr As String
        Dim dt = New DataTable
        sqlStr = "SELECT * FROM " & entidad & " where NumeroDocumento =" & numero
        Try
            Dim da As New SqlDataAdapter(sqlStr, db)
            da.Fill(dt)
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
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
        Dim resultado As Integer
        Try
            Dim sqlStr As New SqlCommand("Select * from Ensesion", db)
            db.Open()
            sqlStr.CommandType = CommandType.Text
            sqlStr.ExecuteNonQuery()
            respuesta = sqlStr.ExecuteReader

            If respuesta.Read Then
                resultado = CInt(respuesta.Item("UsuarioId"))
            End If
            respuesta.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        db.Close()
        Return resultado
    End Function

End Class
