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
    Public Function CargarGrillaMovimientosEstado(parametros As Dictionary(Of String, String)) As DataSet
        Return cajaDA.CargarGrillaMovimientosEstado(parametros)
    End Function

    Public Function CargarUnMovimiento(movimientoId As Tuple(Of Integer, String)) As DataSet
		Return cajaDA.CargarUnMovimiento(movimientoId)
	End Function

    Public Sub grabarCierredeCaja(ByVal idusuario As Integer, ByVal txtmontofinal As Double)
        cajaDA.grabarCierredeCaja(idusuario, txtmontofinal)

    End Sub

    Public Function ControlCierreCaja(ByVal usuarioid As Integer) As DataSet
        Return cajaDA.ControlCierreCaja(usuarioid)

    End Function


    Public Function updateCierre(ByVal idusuario As Integer) As DataSet
        Return cajaDA.updateCierre(idusuario)

    End Function

End Class
