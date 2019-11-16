Imports System.Windows.Forms
Imports ClaseLn
Public Class FrmConsultaCotizaciones

	Dim materialesLN As New MaterialesLN

	Private Sub FrmConsultaCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim ds As DataSet = materialesLN.ConsultaHistoricaCotizaciones(FrmGestionMaterial.materialId)
		dgvCotizaciones.DataSource = ds.Tables(0)
		dgvCotizaciones.Columns("Id").Visible = False
		dgvCotizaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
		dgvCotizaciones.AutoResizeColumns()
		txtMaterial.Text = ds.Tables(0).Rows(0)(1).ToString()
		txtMaterial.Enabled = False
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

		With FrmGestionMaterial
		End With
		FrmGestionMaterial.ShowDialog()
		Me.Close()

	End Sub
End Class