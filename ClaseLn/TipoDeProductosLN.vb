Imports ClaseDa
Public Class TipoDeProductosLN
	Private tipoDeProductosDA As TipoDeProductosDA

	Public Sub New()
		tipoDeProductosDA = New TipoDeProductosDA
	End Sub

	Public Function CargarGrilla() As DataSet
		Return tipoDeProductosDA.CargarGrilla()
	End Function

	Public Function ConsultaModificacion(ByVal id As Integer) As DataSet
		Return tipoDeProductosDA.ConsultaModificacion(id)
	End Function

	Public Sub GuardarNuevo(ByVal nombre As String, ByVal descripcion As String)
		tipoDeProductosDA.GuardarNuevo(nombre, descripcion)
	End Sub

	Public Sub Modificar(nombre As String, descripcion As String, id As Integer)
		tipoDeProductosDA.Modificar(nombre, descripcion, id)
	End Sub
End Class
