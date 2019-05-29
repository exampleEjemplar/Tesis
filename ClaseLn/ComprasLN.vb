Imports ClaseDa
Imports ClaseNe
Public Class ComprasLN
	Private comprasDA As ComprasDA


	Public Sub New()
		comprasDA = New ComprasDA
	End Sub
	Public Function CargarGrillaCompras(ByVal parametros As Dictionary(Of String, String))
		Return comprasDA.CargarGrillaCompras(parametros)
	End Function

End Class
