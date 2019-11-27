Imports ClaseDa
Imports ClaseNe
Public Class ProveedoresLN

    Private objProveedoresAD As ProveedoresDA

    Public idProv As Integer
    Public QPacientes As Integer
    Public QPacientesMod As Integer
    Public contador As Integer

    Public Sub New()
        objProveedoresAD = New ProveedoresDA
    End Sub

    Public Function ConsultaModificacion(ByVal Id As Integer)
        Return objProveedoresAD.ConsultaModificacion(Id)
    End Function

    Public Function CargaGrillaProveedores(ByVal parametros As Dictionary(Of String, String)) As DataSet
        Return objProveedoresAD.CargaGrillaProveedores(parametros)
    End Function

    Public Sub GrabarProveedores(ByVal pro As ProveedoresNE)
        objProveedoresAD.GrabarProveedores(pro)
    End Sub

    Public Sub ActualizarProveedores(ByVal pro As ProveedoresNE)
        objProveedoresAD.ActualizarProveedores(pro)
    End Sub
    Public Function CargaGrillaProveedoreslistado(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return objProveedoresAD.CargaGrillaProveedoreslistado(fechadesde, fechahasta)
    End Function

    Public Function GeneraGraficoProveedorPorCantidadProducto(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return objProveedoresAD.GeneraGraficoProveedorPorCantidadProducto(fechadesde, fechahasta)
    End Function

    Public Function GeneraGraficopersoneria(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return objProveedoresAD.GeneraGraficopersoneria(fechadesde, fechahasta)
    End Function

    Public Function GeneraGraficoPorPago(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return objProveedoresAD.GeneraGraficoPorPago(fechadesde, fechahasta)
    End Function

    Public Sub Controlfecha(ByVal fechadesde As String, ByVal fechahasta As String)
        objProveedoresAD.Controlfecha(fechadesde, fechahasta)
        contador = objProveedoresAD.contador
    End Sub

    Public Function GeneraGrafico(ByVal fechadesde As String, ByVal fechahasta As String) As DataSet
        Return objProveedoresAD.GeneraGrafico(fechadesde, fechahasta)
    End Function

End Class

