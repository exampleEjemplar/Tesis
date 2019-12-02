Imports System.Windows.Forms
Imports ClaseLn
Public Class FrmConsultaCotizaciones

	Dim materialesLN As New MaterialesLN

	Private Sub FrmConsultaCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As DataSet = materialesLN.ConsultaHistoricaCotizaciones(FrmGestionMaterial.materialId)
        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("La búsqueda no arrojó resultados", MsgBoxStyle.Critical, "Error")
            Close()
            Return
        End If
        dgvCotizaciones.DataSource = ds.Tables(0)
        dgvCotizaciones.Columns("id").Visible = False
        dgvCotizaciones.Columns("Cotizacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvCotizaciones.Columns("Cotizacion").DefaultCellStyle.Format = "c2"
        dgvCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCotizaciones.AutoResizeColumns()
		txtMaterial.Text = ds.Tables(0).Rows(0)(1).ToString()
		txtMaterial.Enabled = False
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

		Close()

	End Sub
End Class