Imports ClaseDa
Public Class TipoDeProductosLN
	Private categoriasDA As TipoDeProductosDA

	Public Sub New()
		categoriasDA = New TipoDeProductosDA
	End Sub

	Public Function CargarGrillaTipoDeProductos() As DataSet
		Return categoriasDA.CargarGrillaTipoDeProductos()
	End Function

	Public Function ConsultaModificacion(ByVal id As Integer) As DataSet
		Return categoriasDA.ConsultaModificacion(id)
	End Function


End Class
