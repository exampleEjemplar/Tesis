Imports ClaseDa
Imports ClaseNe

Public Class MovimientoStockLN

    Private movimientostockDA As MovimientoStockDA

    Public Sub New()

        movimientostockDA = New MovimientoStockDA

    End Sub

    Public Function GeneraGraficoMas() As DataSet
        Return movimientostockDA.GeneraGraficomas()
    End Function
    Public Function GeneragraficoMENOS() As DataSet
        Return movimientostockDA.GeneraGraficomenos()
    End Function

End Class
