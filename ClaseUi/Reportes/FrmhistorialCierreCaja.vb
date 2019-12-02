Imports ClaseLn



Public Class FrmhistorialCierreCaja

    Private helpersLN As New HelpersLN

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If CheckBox1.Checked Then


            Me.SP_HistorioCierredeCajaTableAdapter.Fill(Me.DataSetReportes.SP_HistorioCierredeCaja, "11/11/1900", Date.Now, cbocliente.SelectedValue)
            Me.ReportViewer1.RefreshReport()

        Else

            If dtpHasta.Value <= dtpDesde.Value Then
                MsgBox("La fecha desde no puede ser mayor que la fecha hasta", MsgBoxStyle.OkOnly, "Error")
                Return
            Else

                Me.SP_HistorioCierredeCajaTableAdapter.Fill(Me.DataSetReportes.SP_HistorioCierredeCaja, "11/11/1900", Date.Now, cbocliente.SelectedValue)
                Me.ReportViewer1.RefreshReport()


            End If



        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            lblDesde.Enabled = False
            lblHasta.Enabled = False
            dtpDesde.Enabled = False
            dtpHasta.Enabled = False
            cbocliente.Enabled = True
        Else
            lblDesde.Enabled = True
            lblHasta.Enabled = True
            dtpDesde.Enabled = True
            dtpHasta.Enabled = True
            cbocliente.Enabled = False
        End If
    End Sub

    Private Sub FrmhistorialCierreCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetReportes.SP_HistorioCierredeCaja' Puede moverla o quitarla según sea necesario.
        LlenarCbovendedor()
        cbocliente.Enabled = False
        btnBuscar.Enabled = False

    End Sub

    Public Function LlenarCbovendedor()
        Try
            Dim ds1 As DataSet
            ds1 = helpersLN.CargarCboTodosUsuarios()
            cbocliente.DataSource = ds1.Tables(0)
            cboCliente.DisplayMember = "Nombre"
            cboCliente.ValueMember = "id"
            cboCliente.SelectedValue = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return cboCliente.SelectedValue
        MsgBox(cbocliente.SelectedValue)
    End Function

    Private Sub dtpDesde_ValueChanged(sender As Object, e As EventArgs) Handles dtpDesde.ValueChanged
        cbocliente.Enabled = True
        CheckBox1.Enabled = False



    End Sub

    Private Sub cbocliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocliente.SelectedIndexChanged
        btnBuscar.Enabled = True

    End Sub



    Private Sub Limpiar()
        lblDesde.Enabled = True
        lblHasta.Enabled = True
        dtpDesde.Enabled = True
        dtpHasta.Enabled = True
        CheckBox1.Enabled = True
        ReportViewer1.Clear()
        CheckBox1.Checked = False
        cbocliente.SelectedValue = 0


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub
End Class