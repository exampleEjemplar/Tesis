Imports ClaseLn

Public Class ListadodeClientes
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetReportes.SP_ListadodeClientesPorfecha' Puede moverla o quitarla según sea necesario.

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cli As New ClientesLN

        If CheckBox1.Checked Then


            Me.SP_ListadodeClientesPorfechaTableAdapter.Fill(Me.DataSetReportes.SP_ListadodeClientesPorfecha, "11/11/1900", Date.Now)
            Me.ReportViewer1.RefreshReport()

        Else

            If DateTimePicker2.Value <= DateTimePicker1.Value Then
                MsgBox("La fecha desde no puede ser mayor que la fecha hasta", MsgBoxStyle.OkOnly, "Error")
                Return
            Else
                Me.SP_ListadodeClientesPorfechaTableAdapter.Fill(Me.DataSetReportes.SP_ListadodeClientesPorfecha, DateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm:ss"), DateTimePicker2.Value.AddHours(23).AddMinutes(59).AddSeconds(59).ToString("dd/MM/yyyy HH:mm:ss"))
                Me.ReportViewer1.RefreshReport()


            End If



        End If



    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class