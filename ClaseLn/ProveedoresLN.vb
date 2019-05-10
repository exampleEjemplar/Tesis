Imports ClaseDa
Imports ClaseNe
Public Class ProveedoresLN

    Private objProveedoresAD As ProveedoresDA

    Public idProv As Integer
    Public QPacientes As Integer
    Public QPacientesMod As Integer
    Public IdPaciente1 As Integer

    Public Sub New()
        objProveedoresAD = New ProveedoresDA
    End Sub

    Public Function ConsultaModificacion(ByVal nroDoc As Integer)
        Return objProveedoresAD.ConsultaModificacion(nroDoc)
    End Function

    Public Function CargaGrillaProveedores(ByVal parametros As Dictionary(Of String, String)) As DataSet
        Return objProveedoresAD.CargaGrillaProveedores(parametros)
    End Function

    Public Sub GrabarProveedores(ByVal pro As ProveedoresNE)
        objProveedoresAD.grabarProveedores(pro)
    End Sub

    Public Sub ActualizarProveedores(ByVal pro As ProveedoresNE)
        objProveedoresAD.ActualizarProveedores(pro)
    End Sub

End Class

