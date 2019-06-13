Imports ClaseDa
Public Class CategoriasLN
	Private categoriasDA As CategoriasDA

	Public Sub New()
		categoriasDA = New CategoriasDA
	End Sub

	Public Function CargarGrillaCategorías() As DataSet
		Return categoriasDA.CargarGrillaCategorías()
	End Function

	Public Function ConsultaModificacion(ByVal id As Integer) As DataSet
		Return categoriasDA.ConsultaModificacion(id)
	End Function


End Class
