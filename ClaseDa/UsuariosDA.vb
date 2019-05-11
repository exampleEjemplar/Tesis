Imports System.Data.SqlClient
Imports ClaseNe

Public Class UsuariosDA

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

    Public Function ConsultaModificacion(ByVal username As String) As DataSet
        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select UserName,Contrasena,RolId,ActivoSN from usuarios where username = '" & username & "'"
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


    Public Function CargarGrillaUsuario(ByVal parametros As Dictionary(Of String, String)) As DataSet
        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select u.UserName, r.Descripcion, u.ActivoSN from usuarios as u inner join roles as r on r.id = u.RolId"

        If parametros.Count > 0 Then
            Dim extraText As String = String.Empty
            Dim count As Integer = 0
            For Each parametro As KeyValuePair(Of String, String) In parametros
                If count <> 0 Then
                    extraText = extraText & " and "
                Else
                    extraText = " where "
                End If
                extraText = extraText & " u." & parametro.Key & " like '%" & parametro.Value & "%'"
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

    Public Sub GrabarUsuarios(ByVal usu As UsuariosNE)
        Try
            Dim insert As New SqlCommand("insert into usuarios values ('" & usu.UserName & "','" & usu.Contrasena & "'," & usu.RolId & ",'" & usu.ActivoSN & "')", db)
            insert.CommandType = CommandType.Text
            db.Open()
            insert.ExecuteNonQuery()
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub ActualizarUsuarios(ByVal usu As UsuariosNE)
        Try
            Dim insert As New SqlCommand("update usuarios set contrasena = '" & usu.Contrasena & "',rolid = " & usu.RolId & ", activosn = '" & usu.ActivoSN & "' where id = " & usu.Id, db)
            insert.CommandType = CommandType.Text
            db.Open()
            insert.ExecuteNonQuery()
            db.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Function CargarRoles() As DataSet
        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select Id,Descripcion from roles"

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

End Class
