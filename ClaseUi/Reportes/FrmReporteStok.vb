Public Class FrmReporteStok
    Private Sub FrmReporteStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetReportes.SP_MostrarStockProductos' Puede moverla o quitarla según sea necesario.
        Me.SP_MostrarStockProductosTableAdapter.Fill(Me.DataSetReportes.SP_MostrarStockProductos)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class