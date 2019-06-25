Imports ClaseDa
Public Class MaterialesLN
	Private materialesDA As MaterialesDA

	Public Sub New()
		materialesDA = New MaterialesDA
	End Sub

	Public Function CargarGrillaMateriales() As DataSet
		Return materialesDA.CargarGrillaMateriales()
	End Function

	Public Function ConsultaModificacion(ByVal id As Integer) As DataSet
		Return materialesDA.ConsultaModificacion(id)
	End Function

	Public Sub GuardarNuevo(ByVal nombre As String, ByVal coti As String)
		materialesDA.GuardarNuevo(nombre, coti)
	End Sub

	Public Sub NuevaCotizacion(ByVal id As Integer, ByVal coti As String)
		materialesDA.NuevaCotizacion(id, coti)
	End Sub

	Public Function ConsultaHistoricaCotizaciones(ByVal id As Integer) As DataSet
		Return materialesDA.ConsultaHistoricaCotizaciones(id)
	End Function

End Class
