Public Class FrmAyuda
	Private Sub FrmAyuda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		AxAcroPDF1.src = "C:\Users\cabri\source\repos\Tesis\ClaseUi\Resources\Manual.pdf"
	End Sub

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()
	End Sub
End Class