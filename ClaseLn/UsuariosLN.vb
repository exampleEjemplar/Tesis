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

    Public Function ConsultaModificacion(ByVal nroDoc As Integer)
        Return usuariosDA.ConsultaModificacion(nroDoc)
    End Function

    Public Function CargarGrillaUsuarios(ByVal parametros As Dictionary(Of String, String)) As DataSet
        Return usuariosDA.CargaGrillaUsuarios(parametros)
    End Function

    Public Sub GrabarUsuarios(ByVal usu As UsuariosNE)
        usuariosDA.grabarUsuarios(usu)
    End Sub

    Public Sub ActualizarUsuarios(ByVal usu As UsuariosNE)
        usuariosDA.ActualizarUsuarios(usu)
    End Sub

End Class

