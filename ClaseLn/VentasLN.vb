Imports ClaseDa
Imports ClaseNe
Public Class VentasLN
	Private ventasDA As VentasDA


	Public Sub New()
		ventasDA = New VentasDA
	End Sub

	Public Function CargarGrillaVentas(ByVal parametros As Dictionary(Of String, String))
		Return ventasDA.CargarGrillaVentas(parametros)
	End Function
End Class
