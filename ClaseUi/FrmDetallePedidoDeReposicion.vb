﻿Imports System.Windows.Forms

Public Class FrmDetallePedidoDeReposicion
	Public agrupado As IGrouping(Of String, ProductosConStock)
	Public base As String
	Public index As Integer

	Private Sub FrmDetallePedidoDeReposicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		GroupBox1.Visible = False
		Dim listaDeProductos = agrupado.ToList()
		For Each producto As ProductosConStock In listaDeProductos
			producto.AComprar = CalcularSegunBase(producto.StockMinimo, producto.StockMaximo, producto.StockActual)
		Next
		dgvProductos.DataSource = listaDeProductos
		lblBase.Text = base
	End Sub

	Public Function CalcularSegunBase(stockMin As Integer, stockMax As Integer, stockActual As Integer) As Integer
		Dim operacion As Integer = 0
		Select Case base
			Case "Stock Máximo"
				operacion = stockMax - stockActual
			Case "Stock Mínimo"
				operacion = stockMin - stockActual
			Case "Promedio"
				operacion = ((stockMax + stockMin) / 2) - stockActual
			Case Else
				operacion = 0
		End Select
		Return If(operacion >= 0, operacion, 0)
	End Function

	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvProductos.CellMouseDoubleClick
		Dim selectedRow As DataGridViewRow = Nothing
		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			selectedRow = dgvProductos.Rows(e.RowIndex)
		End If
		lblProveedor.Text = selectedRow.Cells("ProveedorNombre").Value
		lblProducto.Text = selectedRow.Cells("Nombre").Value
		lblAComprar.Text = selectedRow.Cells("AComprar").Value
		lblMaximo.Text = selectedRow.Cells("StockMaximo").Value
		lblStockMinimo.Text = selectedRow.Cells("StockMinimo").Value
		txtForzado.Text = selectedRow.Cells("AComprar").Value
		Index = selectedRow.Cells("id").RowIndex
		GroupBox1.Visible = True
	End Sub

	Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
		GroupBox1.Visible = False
	End Sub

	Private Sub btnguardarmodificacion_Click(sender As Object, e As EventArgs) Handles btnguardarmodificacion.Click
		If Not String.IsNullOrEmpty(txtForzado.Text) Then
			Dim value As Integer
			If Not Integer.TryParse(txtForzado.Text, value) Then
				MsgBox("La cantidad a comprar debe ser un número", MsgBoxStyle.Critical, "Producto")
				Return
			End If
			If value = 0 Then
				MsgBox("La cantidad a comprar debe ser un número distinto a 0", MsgBoxStyle.Critical, "Producto")
				Return
			End If
		Else
			MsgBox("Debe agregar una cantidad a comprar", MsgBoxStyle.Critical, "Producto")
			Return
		End If
		dgvProductos.Rows(index).Cells("AComprar").Value = txtForzado.Text
		GroupBox1.Visible = False
	End Sub

	Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()
	End Sub

End Class