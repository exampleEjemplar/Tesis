Imports ClaseNE
Imports ClaseDa

Public Class UsuariosLN
    Private usuarioDA As UsuariosDA

    Public Sub New()
        usuarioDA = New UsuariosDA
    End Sub

    Public Function AgregarUsuarios(usu As UsuariosNE)
        Dim dt As New DataTable
        dt = usuarioDA.AgregarUsuarios(usu)
        Return dt
    End Function

End Class
