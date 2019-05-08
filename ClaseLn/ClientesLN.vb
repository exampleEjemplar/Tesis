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

    Public Function ConsultaModificacion(ByVal nroDoc As Integer)
        Return objclientesAD.ConsultaModificacion(nroDoc)
    End Function

    Public Function CargaGrillaclientes(ByVal parametros As Dictionary(Of String, String)) As DataSet
        Return objclientesAD.CargaGrillaclientes(parametros)
    End Function

    Public Sub GrabarClientes(ByVal cli As ClientesNE)
        objclientesAD.grabarClientes(cli)
    End Sub

End Class

