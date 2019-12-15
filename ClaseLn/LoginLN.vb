Imports ClaseDa
Imports ClaseNe

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


	Function usuarioRegistrado(ByVal nombreUsuario As String) As DataSet
		Return objloginAD.UsuarioRegistrado(nombreUsuario)
	End Function

    Function contrasena(ByVal nombreUsuario As String, contraIngresada As String) As Boolean
        Return objloginAD.Contrasena(nombreUsuario, contraIngresada)
    End Function

    Function ConsultarRolUsuario(ByVal nombreUsuario As String, Optional ByVal userId As Integer = 0) As Integer
		Return objloginAD.ConsultarRolUsuario(nombreUsuario, userId)
	End Function

	Function ConsultarIDUsuario(ByVal nombreUsuario As String) As Integer
        Return objloginAD.ConsultarIDUsuario(nombreUsuario)
    End Function

	Sub EnSesion(ByVal usrId As Integer)
		objloginAD.EnSesion(usrId)
	End Sub

	Function ChequearEnSesion()
		Return objloginAD.ChequearEnSesion()
	End Function
End Class
