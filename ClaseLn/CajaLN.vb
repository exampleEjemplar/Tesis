Imports ClaseDa
Imports ClaseNe
Public Class CajaLN
	Private cajaDA As CajaDA


	Public Sub New()
		cajaDA = New CajaDA
	End Sub

	Public Function CargarGrillaMovimientos(parametros As Dictionary(Of String, String)) As DataSet
		Return cajaDA.CargarGrillaMovimientos(parametros)
	End Function

	Public Function CargarUnMovimiento(movimientoId As Tuple(Of Integer, String)) As DataSet
		Return cajaDA.CargarUnMovimiento(movimientoId)
	End Function



End Class
