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


End Class
