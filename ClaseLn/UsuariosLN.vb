Imports ClaseDa
Imports ClaseNe
Public Class UsuariosLN

    Private usuariosDA As UsuariosDA

    Public idProv As Integer
    Public QPacientes As Integer
    Public QPacientesMod As Integer
    Public IdPaciente1 As Integer

    Public Sub New()
        usuariosDA = New UsuariosDA
    End Sub
	Public Function CargarUnUsuario(ByVal id As Integer) As DataSet
		Return usuariosDA.CargarUnUsuario(id)
	End Function


	Public Function ConsultaModificacion(ByVal username As String)
        Return usuariosDA.ConsultaModificacion(username)
    End Function

    Public Function CargarGrillaUsuarios(ByVal parametros As Dictionary(Of String, String)) As DataSet
        Return usuariosDA.CargarGrillaUsuario(parametros)
    End Function

    Public Sub GrabarUsuarios(ByVal usu As UsuariosNE)
        usuariosDA.grabarUsuarios(usu)
    End Sub

    Public Sub ActualizarUsuarios(ByVal usu As UsuariosNE)
        usuariosDA.ActualizarUsuarios(usu)
    End Sub

    Public Function CargarRoles() As DataSet
        Return usuariosDA.CargarRoles()
    End Function

End Class

