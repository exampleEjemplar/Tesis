
Imports System.Data.SqlClient
Imports ClaseNE

Public Class MetodoLoginDA
    Private con As New SqlConnection
    Private com As New SqlCommand

    Public Sub New()
        Dim objcon As New ConexionDA
        con = objcon.Abrir
        com.Connection = con
    End Sub

    Public usr As String
    Public nivelusr As Integer
    Public usr_id As Integer
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    Function UsuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Dim resultado As Boolean = False
        Try
            enunciado = New SqlCommand("Select * from Usuarios where UserName='" & nombreUsuario & "'", con)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
        con.Close()
    End Function

    Function Contrasena(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select rtrim(Contrasena) as Contrasena from Usuarios where UserName='" & nombreUsuario & "'", con)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = respuesta.Item("Contrasena")
                usr = nombreUsuario
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
        con.Close()
    End Function

    Function ConsultarRolUsuario(ByVal nombreUsuario As String) As Integer
        Dim resultado As Integer
        Dim resultado2 As Integer

        Try
            enunciado = New SqlCommand("Select RolId, Id from Usuarios where UserName='" & nombreUsuario & "'", con)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = CInt(respuesta.Item("RolId"))
                resultado2 = CInt(respuesta.Item("Id"))
                nivelusr = resultado
                usr_id = resultado2
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return resultado2
        con.Close()
    End Function

    Function ConsultarIDUsuario(ByVal nombreUsuario As String) As Integer
        Dim resultado As Integer
        Dim resultado2 As Integer

        Try
            enunciado = New SqlCommand("Select RolId, Id from Usuarios where UserName='" & nombreUsuario & "'", con)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = CInt(respuesta.Item("RolId"))
                resultado2 = CInt(respuesta.Item("Id"))
                nivelusr = resultado
                usr_id = resultado2
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return resultado2
        con.Close()
    End Function
    Public Sub EnSesion(ByVal usrId As Integer)
        Try
            Dim insert As New SqlCommand("Update EnSesion set UsuarioId = " & usrId, con)
            insert.CommandType = CommandType.Text
            insert.ExecuteNonQuery()
            Dim respuesta = insert.ExecuteReader
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class
