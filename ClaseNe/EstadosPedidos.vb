Imports System.ComponentModel

Public Enum EstadosPedidos

	Anulado = 0
	<Description("Para entregar al proveedor")>
	ParaEntregarAlProveedor = 1
	<Description("En el proveedor")>
	EnElProveedor = 2
	<Description("Devuelto por el proveedor")>
	DevueltoPorElProveedor = 3
	<Description("Entregado al cliente")>
	EntregadoAlCliente = 4

End Enum