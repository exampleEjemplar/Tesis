﻿Imports ClaseLn



Public Class InformeCierredeCaja
    Private loginLN As New LoginLN


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetReportes.SP_CierredeCaja1' Puede moverla o quitarla según sea necesario.
        Me.SP_CierredeCaja1TableAdapter.Fill(Me.DataSetReportes.SP_CierredeCaja1, loginLN.ChequearEnSesion().ToString())
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class