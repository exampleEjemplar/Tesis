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

    Public Function ConsultaModificacion(ByVal Id As Integer)
        Return objclientesAD.ConsultaModificacion(Id)
    End Function

    Public Function CargaGrillaclientes(ByVal parametros As Dictionary(Of String, String)) As DataSet
        Return objclientesAD.CargaGrillaclientes(parametros)
    End Function

    Public Sub GrabarClientes(ByVal cli As ClientesNE)
        objclientesAD.GrabarClientes(cli)
    End Sub

    Public Sub ActualizarClientes(ByVal cli As ClientesNE)
        objclientesAD.ActualizarClientes(cli)
    End Sub
    Public Function GeneraGrafico(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return objclientesAD.GeneraGrafico(fechadesde, fechahasta)
    End Function

End Class

