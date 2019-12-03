Imports ClaseDa
Imports ClaseNe

Public Class MovimientoStockLN

    Private movimientostockDA As MovimientoStockDA
    Public contador As Integer

    Public Sub New()

        movimientostockDA = New MovimientoStockDA

    End Sub

    Public Function GeneraGraficoMas(ByVal fechadesde As String, fechahasta As String) As DataSet
        Return movimientostockDA.GeneraGraficomas(fechadesde, fechahasta)
    End Function
    Public Function GeneragraficoMENOS(ByVal fechadesde As String, fechahasta As String) As DataSet
        Return movimientostockDA.GeneraGraficomenos(fechadesde, fechahasta)
    End Function

    Public Sub Controlfecha(ByVal fechadesde As String, ByVal fechahasta As String)
        movimientostockDA.Controlfecha(fechadesde, fechahasta)
        contador = movimientostockDA.contador
    End Sub
End Class
