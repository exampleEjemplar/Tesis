Imports ClaseLn

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetReportes.SP_ListadodeClientesPorfecha' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cli As New ClientesLN



        Me.SP_ListadodeClientesPorfechaTableAdapter.Fill(Me.DataSetReportes.SP_ListadodeClientesPorfecha, TextBox1.Text, TextBox2.Text)

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class