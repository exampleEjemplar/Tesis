Imports ClaseDA
Imports ClaseNE
Public Class ClientesLN

    Private objclientesAD As MetodoClientesDA

    Public idProv As Integer
    Public QPacientes As Integer
    Public QPacientesMod As Integer
    Public IdPaciente1 As Integer

    Public Sub New()
        objclientesAD = New MetodoClientesDA
    End Sub


    Public Function CargaGrillaclientes(ByVal busqdni As String, ByVal busqape As String) As DataSet
        Return objclientesAD.CargaGrillaclientes(busqdni, busqape)
    End Function

    Public Sub GrabarClientes(ByVal cli As ClientesNE)
        objclientesAD.grabarClientes(cli)
    End Sub

End Class

