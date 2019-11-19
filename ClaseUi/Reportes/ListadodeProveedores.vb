Public Class ListadodeProveedores
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If CheckBox1.Checked Then
            'TODO: esta línea de código carga datos en la tabla 'DataSetReportes.SP_ListadodeProveedoresPorfecha' Puede moverla o quitarla según sea necesario.
            Me.SP_ListadodeProveedoresPorfechaTableAdapter.Fill(Me.DataSetReportes.SP_ListadodeProveedoresPorfecha, "11/11/1900", Today)
            Me.ReportViewer1.RefreshReport()

        Else
            If DateTimePicker2.Value <= DateTimePicker1.Value Then
                MsgBox("La fecha desde no puede ser mayor que la fecha hasta", MsgBoxStyle.OkOnly, "Error")
                Return
            Else
                'TODO: esta línea de código carga datos en la tabla 'DataSetReportes.SP_ListadodeProveedoresPorfecha' Puede moverla o quitarla según sea necesario.
                Me.SP_ListadodeProveedoresPorfechaTableAdapter.Fill(Me.DataSetReportes.SP_ListadodeProveedoresPorfecha,  DateTimePicker1.Value.Date.ToString("dd/MM/yyyy HH:mm:ss"), DateTimePicker2.Value.Date.ToString("dd/MM/yyyy HH:mm:ss"))
            Me.ReportViewer1.RefreshReport()

        End If


        End If

    End Sub

    Private Sub ListadodeProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub
End Class