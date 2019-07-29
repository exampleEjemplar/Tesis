Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe

Public Class FrmModificarPrecioProducto
	Private productometodo As New ProductoLN
	Private helpersLN As New HelpersLN
	Private listOfProducts As New List(Of ProductosNE)

	Private Sub FrmModificarPrecioProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Dim productos = helpersLN.CargarTodosProductos(New Dictionary(Of String, String)).Tables(0)
		For i As Integer = 0 To productos.Rows.Count - 1
			CheckedListBox1.Items.Add(productos.Rows(i)(1) + "                      $" + productos.Rows(i)(3).ToString(), CheckState.Unchecked)
			Dim producto = New ProductosNE With {
				.nombreprducto = productos.Rows(i)(1),
				.proveedorId = productos.Rows(i)(5),
				.precio = productos.Rows(i)(3)
			}
			listOfProducts.Add(producto)
		Next

	End Sub

	Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
		Dim asd = e
		'If e.NewValue = CheckState.Unchecked Then
		'End If
	End Sub

End Class