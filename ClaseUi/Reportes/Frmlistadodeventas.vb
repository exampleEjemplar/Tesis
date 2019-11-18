Public Class Frmlistadodeventas
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If CheckBox1.Checked Then


            Me.SP_ListadodeVentasPorfechaTableAdapter.Fill(Me.DataSetReportes.SP_ListadodeVentasPorfecha, "11/11/1900", Today)
            Me.ReportViewer1.RefreshReport()

        Else

            If DateTimePicker2.Value <= DateTimePicker1.Value Then
                MsgBox("La fecha desde no puede ser mayor que la fecha hasta", MsgBoxStyle.OkOnly, "Error")
                Return
            Else
                Me.SP_ListadodeVentasPorfechaTableAdapter.Fill(Me.DataSetReportes.SP_ListadodeVentasPorfecha, DateTimePicker1.Value.Date.ToString("dd/MM/yyyy HH:mm:ss"), DateTimePicker2.Value.Date.ToString("dd/MM/yyyy HH:mm:ss"))
                Me.ReportViewer1.RefreshReport()


            End If
        End If

    End Sub

    Private Sub Frmlistadodeventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class