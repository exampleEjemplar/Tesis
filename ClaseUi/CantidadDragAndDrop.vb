Imports ClaseLn

Public Class CantidadDragAndDrop

	Public ProductoLN As New ProductoLN
	Public cantidad As Integer
	Public idProducto As Integer
	Public isVenta = False

	Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		cantidad = 0
		isVenta = False
		Me.Close()
	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		cantidad = cboCantidad.SelectedItem
		isVenta = False
		Me.Close()
	End Sub

	Private Sub CantidadDragAndDrop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		cboCantidad.Visible = True
		lblSinStock.Visible = False
		btnNuevo.Enabled = True
		Dim numberList As New List(Of Integer)
		If isVenta Then
			Dim parametros As New Dictionary(Of String, String)
			parametros.Add("ProductoId", idProducto)
			Dim ds = ProductoLN.CargarGrillaStock(parametros, New List(Of Tuple(Of Integer, String, Integer)), "desc").Tables(0).Rows(0)
			If IsDBNull(ds(2)) Then
				cboCantidad.Visible = False
				lblSinStock.Visible = True
				btnNuevo.Enabled = False
				Return
			End If
			If ds(2) = 0 Then
				cboCantidad.Visible = False
				lblSinStock.Visible = True
				btnNuevo.Enabled = False
				Return
			End If
			For index = 1 To ds(2)
				numberList.Add(index)
			Next
		Else
			For index = 1 To 9
				numberList.Add(index)
			Next
		End If

		cboCantidad.DataSource = numberList

		cboCantidad.SelectedText = 1
		cboCantidad.SelectedItem = 1
	End Sub
End Class