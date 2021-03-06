﻿Imports System.Data.SqlClient
Imports ClaseNe

Public Class UsuariosDA

    Private db As New SqlConnection
    Private helpersDA As New HelpersDA
    Private com As New SqlCommand
    Private da As SqlDataAdapter
    Private ds1 As DataSet
    Private ds As DataSet

    Public Sub New()
        Dim objcon As New ConexionDA
        db = objcon.Abrir
        db = objcon.Cerrar
        com.Connection = db
    End Sub


    Public Function CargarUnUsuario(ByVal id As Integer) As DataSet
        helpersDA.ChequearConexion(db)
        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select UserName,Contrasena,RolId,ActivoSN,Id from usuarios where id = " & id
        Try
            da = New SqlDataAdapter(sqlStr, db)
            da.Fill(ds1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            helpersDA.ChequearConexion(db, "close")
        End Try
        helpersDA.ChequearConexion(db, "close")
        Return ds1
    End Function

    Public Function ConsultaModificacion(ByVal username As String) As DataSet
        helpersDA.ChequearConexion(db)
        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select UserName,Contrasena,RolId,ActivoSN,Id from usuarios where username = '" & username & "'"
        Try
            da = New SqlDataAdapter(sqlStr, db)
            da.Fill(ds1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            helpersDA.ChequearConexion(db, "close")
        End Try
        helpersDA.ChequearConexion(db, "close")
        Return ds1
    End Function

    Public Function CargarGrillaUsuario(ByVal parametros As Dictionary(Of String, String)) As DataSet
        helpersDA.ChequearConexion(db)
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
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            helpersDA.ChequearConexion(db, "close")
        End Try
        helpersDA.ChequearConexion(db, "close")
        Return ds1
    End Function

    Public Function GrabarUsuarios(ByVal usu As UsuariosNE)
        helpersDA.ChequearConexion(db)
        Try
            Dim strPwd = ""
            For i = 0 To usu.Contrasena.Count() - 1
                ds1 = New DataSet
                da = New SqlDataAdapter("Select * from PwdHash where Char = '" + usu.Contrasena(i) + "'", db)
                da.Fill(ds1)
                If ds1.Tables(0).Rows.Count = 0 Then
                    MsgBox("Caracter no válido", MsgBoxStyle.Critical, "Error")
                    Return False
                End If
                For index = 0 To ds1.Tables(0).Rows.Count - 1
                    If usu.Contrasena(i).ToString() = ds1.Tables(0).Rows(index)(1) Then
                        strPwd += ds1.Tables(0).Rows(index)(2)
                    End If
                Next
            Next

            Dim insert As New SqlCommand("insert into usuarios values ('" & usu.UserName & "','" & strPwd & "'," & usu.RolId & ",'" & usu.ActivoSN & "',GETDATE())", db)
            insert.CommandType = CommandType.Text
            insert.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            helpersDA.ChequearConexion(db, "close")
        End Try
        helpersDA.ChequearConexion(db, "close")
        Return True
    End Function
    Public Function ActualizarUsuarios(ByVal usu As UsuariosNE) As Boolean
        helpersDA.ChequearConexion(db)
        Try
            Dim strPwd = ""
            For i = 0 To usu.Contrasena.Count() - 1
                ds1 = New DataSet
                da = New SqlDataAdapter("Select * from PwdHash where Char = '" + usu.Contrasena(i) + "'", db)
                da.Fill(ds1)
                If ds1.Tables(0).Rows.Count = 0 Then
                    MsgBox("Caracter no válido", MsgBoxStyle.Critical, "Error")
                    Return False
                End If
                For index = 0 To ds1.Tables(0).Rows.Count - 1
                    If usu.Contrasena(i).ToString() = ds1.Tables(0).Rows(index)(1) Then
                        strPwd += ds1.Tables(0).Rows(index)(2)
                    End If
                Next
            Next
            Dim insert As New SqlCommand("update usuarios set contrasena = '" & strPwd & "',rolid = " & usu.RolId & ", activosn = '" & usu.ActivoSN & "' where id = " & usu.Id, db)
            insert.CommandType = CommandType.Text
            insert.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            helpersDA.ChequearConexion(db, "close")
        End Try
        helpersDA.ChequearConexion(db, "close")
        Return True
    End Function

    Public Function CargarRoles() As DataSet
        helpersDA.ChequearConexion(db)
        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "select Id,Descripcion from roles"

        Try
            da = New SqlDataAdapter(sqlStr, db)
            da.Fill(ds1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            helpersDA.ChequearConexion(db, "close")
        End Try
        helpersDA.ChequearConexion(db, "close")
        Return ds1
    End Function

End Class
