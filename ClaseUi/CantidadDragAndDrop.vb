Public Class CantidadDragAndDrop

	Public cantidad As Integer

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		cantidad = 0
		Me.Close()
	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		cantidad = cboCantidad.SelectedItem
		Me.Close()
	End Sub
End Class