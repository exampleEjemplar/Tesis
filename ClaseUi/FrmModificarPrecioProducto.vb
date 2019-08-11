Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe

Public Class FrmModificarPrecioProducto
	Private productometodo As New ProductoLN
	Private helpersLN As New HelpersLN
	Private listOfProducts As New Dictionary(Of Integer, Boolean)

	Private Sub FrmModificarPrecioProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Dim productos = helpersLN.CargarTodosProductos(New Dictionary(Of String, String)).Tables(0)
		For i As Integer = 0 To productos.Rows.Count - 1
			CheckedListBox1.Items.Add(productos.Rows(i)(1) + "                      $" + productos.Rows(i)(3).ToString(), CheckState.Unchecked)
			',
			'.nombreprducto = productos.Rows(i)(1),
			'.proveedorId = productos.Rows(i)(5),
			'.precio = productos.Rows(i)(3)
			listOfProducts.Add(CheckedListBox1.Items.Count - 1, False)
		Next

	End Sub

	Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
		If e.NewValue = CheckState.Unchecked Then
			listOfProducts.Remove(e.Index)
			listOfProducts.Add(e.Index, False)
		Else
			listOfProducts.Remove(e.Index)
			listOfProducts.Add(e.Index, True)
		End If

	End Sub

	Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		If Not listOfProducts.Any(Function(s) s.Value = False) Then
			MsgBox("Debe seleccionar un producto", MsgBoxStyle.Critical, "Producto")
		End If

		If String.IsNullOrEmpty() Then

		End If

	End Sub


End Class