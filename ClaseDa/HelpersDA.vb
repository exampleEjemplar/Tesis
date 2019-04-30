Imports System.Data.SqlClient

Public Class HelpersDA

    Private db As New SqlConnection
    Private com As New SqlCommand
    Private ds As DataSet

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

    Public Function CargarCMBDoc() As DataSet

        Dim sqlStr As String
        ds = New DataSet
        sqlStr = "SELECT * FROM TipoDocumentos Order by Descripcion"
        Try
            Dim da As New SqlDataAdapter(sqlStr, db)
            da.Fill(ds)
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return ds
    End Function

End Class
