Public Class FrmDoc
	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()

	End Sub

	Private Sub FrmDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		AxAcroPDF1.src = "C:\Users\cabri\source\repos\Tesis\ClaseUi\Resources\Administracion.pdf"


	End Sub
End Class