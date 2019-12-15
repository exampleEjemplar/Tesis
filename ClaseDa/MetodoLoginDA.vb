
Imports System.Data.SqlClient
Imports ClaseNe

Public Class MetodoLoginDA
    Private db As New SqlConnection
    Private helpersDA As New HelpersDA
    Private com As New SqlCommand

    Public Sub New()
        Dim objcon As New ConexionDA
        db = objcon.Abrir
        db = objcon.Cerrar
        com.Connection = db
    End Sub

    Public usr As String
    Public nivelusr As Integer
    Public usr_id As Integer
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader

    Function UsuarioRegistrado(ByVal nombreUsuario As String)
        helpersDA.ChequearConexion(db)
        enunciado = New SqlCommand("Select * from Usuarios where UserName='" & nombreUsuario & "'", db)
        Dim ds As New DataSet
        Try
            Dim da = New SqlDataAdapter(enunciado)
            da.Fill(ds)
            helpersDA.ChequearConexion(db, "close")
            Return ds

        Catch ex As Exception
            MsgBox(ex.ToString)
            helpersDA.ChequearConexion(db, "close")
            Return ds
        End Try

    End Function

    Function Contrasena(ByVal nombreUsuario As String, contraIngresada As String) As Boolean
        helpersDA.ChequearConexion(db)
        Dim resultado As String = ""
        Try

            Dim strPwdIngresado = ""
            For i = 0 To contraIngresada.Count() - 1
                Dim ds1 = New DataSet
                Dim da = New SqlDataAdapter("Select * from PwdHash where Char = '" + contraIngresada(i) + "'", db)
                da.Fill(ds1)
                For index = 0 To ds1.Tables(0).Rows.Count - 1
                    If contraIngresada(i).ToString() = ds1.Tables(0).Rows(index)(1) Then
                        strPwdIngresado += ds1.Tables(0).Rows(index)(2)
                    End If
                Next
            Next

            'For i = 0 To resultado.Count() - 1
            '    Dim stringasChar = resultado(i).ToString()
            '    Dim ds3 = New DataSet
            '    Dim da3 = New SqlDataAdapter("Select * from PwdHash where Char = '" + resultado(i).ToString() + "'", db)
            '    da3.Fill(ds3)
            '    For index = 0 To ds3.Tables(0).Rows.Count - 1
            '        If resultado(i).ToString() = ds3.Tables(0).Rows(index)(1) Then
            '            strPwdBD += ds3.Tables(0).Rows(index)(2)
            '        End If
            '    Next
            'Next

            Dim strPwdBD = ""
            Dim ds2 = New DataSet
            Dim da1 = New SqlDataAdapter("Select rtrim(Contrasena) as Contrasena from Usuarios where UserName='" & nombreUsuario & "'", db)
            da1.Fill(ds2)

            resultado = ds2.Tables(0).Rows(0)(0)


            'Dim resultadoDividido = New List(Of String)
            'Dim listOfMultiples = New List(Of Integer) From {3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59, 63, 67, 71}
            'Dim strParaDividido = ""
            'For i = 0 To resultado.Count() - 1
            '    strParaDividido += resultado(i)
            '    If listOfMultiples.Contains(i) Then
            '        resultadoDividido.Add(strParaDividido)
            '        strParaDividido = ""
            '    End If
            'Next

            usr = nombreUsuario
            If resultado = strPwdIngresado Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            helpersDA.ChequearConexion(db, "close")
        End Try
        helpersDA.ChequearConexion(db, "close")
        Return resultado
    End Function

    Function ConsultarRolUsuario(ByVal nombreUsuario As String, Optional ByVal usuarioId As Integer = 0) As Integer
        helpersDA.ChequearConexion(db)
        Dim resultado As Integer
        Dim resultado2 As Integer

        Try
            If usuarioId <> 0 Then
                enunciado = New SqlCommand("Select RolId, Id from Usuarios where Id=" & usuarioId, db)
            Else
                enunciado = New SqlCommand("Select RolId, Id from Usuarios where UserName='" & nombreUsuario & "'", db)
            End If
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
            helpersDA.ChequearConexion(db, "close")
        End Try
        helpersDA.ChequearConexion(db, "close")
        Return resultado
    End Function

    Function ConsultarIDUsuario(ByVal nombreUsuario As String) As Integer
        helpersDA.ChequearConexion(db)
        Dim resultado As Integer
        Dim resultado2 As Integer

        Try
            enunciado = New SqlCommand("Select RolId, Id from Usuarios where UserName='" & nombreUsuario & "'", db)
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
            helpersDA.ChequearConexion(db, "close")
        End Try
        helpersDA.ChequearConexion(db, "close")
        Return resultado2
    End Function

    Public Sub EnSesion(ByVal usrId As Integer)
        helpersDA.ChequearConexion(db)
        Try
            Dim insert As New SqlCommand("Update EnSesion set UsuarioId = " & usrId, db)
            insert.CommandType = CommandType.Text
            insert.ExecuteNonQuery()
            Dim respuesta = insert.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            helpersDA.ChequearConexion(db, "close")
        End Try
        helpersDA.ChequearConexion(db, "close")
    End Sub

    Public Function ChequearEnSesion()
        helpersDA.ChequearConexion(db)
        enunciado = New SqlCommand("Select Top(1) UsuarioId from EnSesion", db)
        Dim ds As New DataSet
        Try
            Dim da = New SqlDataAdapter(enunciado)
            da.Fill(ds)
            Return ds.Tables(0).Rows(0)(0).ToString()

        Catch ex As Exception
            MsgBox(ex.ToString)
            helpersDA.ChequearConexion(db, "close")
            Return 0
        End Try
        helpersDA.ChequearConexion(db, "close")
    End Function

End Class
