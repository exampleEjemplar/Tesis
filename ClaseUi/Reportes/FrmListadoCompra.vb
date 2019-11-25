Public Class FrmListadoCompra
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If CheckBox1.Checked Then


            Me.SP_ListadodecomprasPorfechaTableAdapter.Fill(Me.DataSetReportes.SP_ListadodecomprasPorfecha, "11/11/1900", Date.Now)
            Me.ReportViewer1.RefreshReport()

        Else

            If DateTimePicker2.Value <= DateTimePicker1.Value Then
                MsgBox("La fecha desde no puede ser mayor que la fecha hasta", MsgBoxStyle.OkOnly, "Error")
                Return
            Else
                Me.SP_ListadodecomprasPorfechaTableAdapter.Fill(Me.DataSetReportes.SP_ListadodecomprasPorfecha, DateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm:ss"), DateTimePicker2.Value.AddHours(23).AddMinutes(59).AddSeconds(59).ToString("dd/MM/yyyy HH:mm:ss"))
                Me.ReportViewer1.RefreshReport()


            End If
        End If
    End Sub

    Private Sub FrmListadoCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class