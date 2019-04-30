Imports ClaseDa
Imports ClaseNE

Public Class LoginLN

    Dim objloginAD As MetodoLoginDA
    Public usr As String
    Public rolUsuario As Integer
    Public usr_id As Integer

    Public Sub New()
        objloginAD = New MetodoLoginDA
        usr = objloginAD.usr
        rolUsuario = objloginAD.nivelusr
        usr_id = objloginAD.usr_id
    End Sub

    Sub abrir()
        objloginAD.Abrir()

    End Sub


    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean
        Return objloginAD.UsuarioRegistrado(nombreUsuario)
    End Function

    Function contrasena(ByVal nombreUsuario As String) As String
        Return objloginAD.Contrasena(nombreUsuario)
    End Function

    Function ConsultarRolUsuario(ByVal nombreUsuario As String) As Integer
        Return objloginAD.ConsultarRolUsuario(nombreUsuario)
    End Function

    Function ConsultarIDUsuario(ByVal nombreUsuario As String) As Integer
        Return objloginAD.ConsultarIDUsuario(nombreUsuario)
    End Function


End Class
