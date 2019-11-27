Imports ClaseDA
Imports ClaseNE
Public Class ClientesLN

    Private objclientesAD As MetodoClientesDA

    Public idProv As Integer
    Public QPacientes As Integer
    Public QPacientesMod As Integer
    Public contador As Integer

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

    Public Function GeneraGraficopersoneria(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return objclientesAD.GeneraGraficopersoneria(fechadesde, fechahasta)
    End Function

    Public Function GeneraGraficousuario(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return objclientesAD.GeneraGraficousuario(fechadesde, fechahasta)
    End Function

    Public Function GeneraGraficoCantidadClientesPorFecha(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return objclientesAD.GeneraGraficoCantidadClientesPorFecha(fechadesde, fechahasta)
    End Function

    Public Function CargaGrillaclienteslistado(ByVal fechadesde As String, ByVal fechahasta As String) As DataTable
        Return objclientesAD.CargaGrillaclienteslistado(fechadesde, fechahasta)
    End Function

    Public Sub Controlfecha(ByVal fechadesde As String, ByVal fechahasta As String)
        objclientesAD.Controlfecha(fechadesde, fechahasta)
        contador = objclientesAD.contador
    End Sub

    Public Function GeneraGraficoRangodeEdad(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return objclientesAD.GeneraGraficoRangodeEdad(fechadesde, fechahasta)
    End Function



End Class

