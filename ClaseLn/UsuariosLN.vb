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

    Public Function GrabarUsuarios(ByVal usu As UsuariosNE)
        Return usuariosDA.GrabarUsuarios(usu)
    End Function

    Public Function ActualizarUsuarios(ByVal usu As UsuariosNE) As Boolean
        Return usuariosDA.ActualizarUsuarios(usu)
    End Function

    Public Function CargarRoles() As DataSet
        Return usuariosDA.CargarRoles()
    End Function

End Class

