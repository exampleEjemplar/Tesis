﻿Public Class Frmlistadodeventas
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If CheckBox1.Checked Then


            Me.SP_ListadodeVentasPorfechaTableAdapter.Fill(Me.DataSetReportes.SP_ListadodeVentasPorfecha, "11/11/1900", Date.Now)
            Me.ReportViewer1.RefreshReport()

        Else

            If dtpHasta.Value <= dtpDesde.Value Then
                MsgBox("La fecha desde no puede ser mayor que la fecha hasta", MsgBoxStyle.OkOnly, "Error")
                Return
            Else
                Me.SP_ListadodeVentasPorfechaTableAdapter.Fill(Me.DataSetReportes.SP_ListadodeVentasPorfecha, dtpDesde.Value.ToString("dd/MM/yyyy HH:mm:ss"), dtpHasta.Value.AddHours(23).AddMinutes(59).AddSeconds(59).ToString("dd/MM/yyyy HH:mm:ss"))
                Me.ReportViewer1.RefreshReport()


            End If
        End If

    End Sub

    Private Sub Frmlistadodeventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            lblDesde.Enabled = False
            lblHasta.Enabled = False
            dtpDesde.Enabled = False
            dtpHasta.Enabled = False
        Else
            lblDesde.Enabled = True
            lblHasta.Enabled = True
            dtpDesde.Enabled = True
            dtpHasta.Enabled = True
        End If
    End Sub
End Class