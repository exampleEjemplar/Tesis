Imports ClaseDa
Imports ClaseNe

Public Class PedidoDeReposicionLN
	Private PedidoDeReposicionDA As PedidoDeReposicionDA

	Public Sub New()
		PedidoDeReposicionDA = New PedidoDeReposicionDA
	End Sub

	Public Sub RegistrarConjuntoPedidoDeReposición(listaDeProductosId As List(Of List(Of TipoDeComprasNE)))
		PedidoDeReposicionDA.RegistrarConjuntoPedidoDeReposición(listaDeProductosId)
	End Sub

	Function CargarPedidos(fecha1 As Date?, fecha2 As Date?)
		Return PedidoDeReposicionDA.CargarPedidos(fecha1, fecha2)
	End Function

	Function CargarPedido(id As Integer)
		Return PedidoDeReposicionDA.CargarPedido(id)
	End Function

	Public Sub CambiarEstado(idpedido As Integer, nuevoEstado As Integer)
		PedidoDeReposicionDA.CambiarEstado(idpedido, nuevoEstado)
	End Sub

End Class
