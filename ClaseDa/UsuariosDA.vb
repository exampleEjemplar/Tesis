Imports System.Data
Imports System.Data.SqlClient
Imports ClaseNE

Public Class UsuariosDA

    Private con As New SqlConnection
    Private com As New SqlCommand
    Public Sub New()
        Dim objcon As New ConexionDA
        con = objcon.Abrir
        com.Connection = con
    End Sub


    Public Function AgregarUsuarios(usu As UsuariosNE)
        Try
            Dim sel As String

            sel = "insert into Usuarios values ('" & usu.UserName & "','" & usu.Contrasena & "'," & usu.RolId & ",'S')"
            com.CommandText = sel

            Using dt As New DataTable
                Using da As New SqlDataAdapter(com)
                    da.Fill(dt)
                    Return dt
                End Using
            End Using

            com.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
    End Function

    'Public Function ValidarUsrName(usuario As String)
    '    Try
    '        Dim sel As String

    '        sel = "SELECT * FROM USUARIOS WHERE usuario = '" & usuario & "'"
    '        com.CommandText = sel

    '        Using dt As New DataTable
    '            Using da As New SqlDataAdapter(com)
    '                da.Fill(dt)
    '                Return dt
    '            End Using
    '        End Using

    '        com.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '        Return Nothing
    '    End Try
    'End Function

    'Public Function cargarTipoDNI(ByVal usrOProv As String) As DataTable
    '    Try
    '        Dim cmdProv As New SqlCommand("Select ID ,TipoDNI from TiposDNI where USROPROV in ( '" & usrOProv & "')", con)
    '        Dim daDNI As New SqlDataAdapter(cmdProv)
    '        Dim dt As New DataTable()
    '        daDNI.Fill(dt)
    '        Return dt
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    '    Return Nothing
    'End Function

    'Public Function CargarRoles() As DataTable
    '    Try
    '        Dim cmdProv As New SqlCommand("Select ID,Descripcion from Roles", con)
    '        Dim daDNI As New SqlDataAdapter(cmdProv)
    '        Dim dt As New DataTable()
    '        daDNI.Fill(dt)
    '        Return dt
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    '    Return Nothing
    'End Function

    'Public Function ValidarUsuarioLogueado() As DataTable
    '    Try
    '        Dim cmdProv As New SqlCommand("Select ROLID from Usuarios where ESTAENSESION = 'S'", con)
    '        Dim daDNI As New SqlDataAdapter(cmdProv)
    '        Dim ds As New DataTable()
    '        daDNI.Fill(ds)
    '        Return ds
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    '    Return Nothing
    'End Function

End Class
