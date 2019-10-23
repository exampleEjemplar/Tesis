Imports ClaseDa

Public Class HelpersLN

    Private helpersDA As New HelpersDA
    Public Sub New()
        helpersDA = New HelpersDA
    End Sub

    Public Function CargarCMBProvincias()
        Return helpersDA.CargarCMBProvincias()
    End Function

	Public Function LlenarUnidadDePeso()
		Return helpersDA.LlenarUnidadDePeso()
	End Function

	Public Function CargarCMBLocalidades(ByVal idprov As Integer)
        Return helpersDA.CargarCMBLocalidades(idprov)
    End Function

    Public Function CargarCMBLocalidadesUnico(ByVal idLoc As Integer)
        Return helpersDA.CargarCMBLocalidadesUnico(idLoc)
    End Function

    Public Function CargarCMBDoc(ByVal FoJ As String)
        Return helpersDA.CargarCMBDoc(FoJ)
    End Function

    Public Function ValidarSiExisteDni(ByVal numero As Double, ByVal entidad As String)
        Return helpersDA.ValidarSiExisteDni(numero, entidad)
    End Function

	Public Function ValidarSiExisteUserName(ByVal userName As String)
		Return helpersDA.ValidarSiExisteUserName(userName)
	End Function

	Public Function CargarCboTodosClientes()
		Return helpersDA.CargarCboTodosClientes()
	End Function

	Public Function CargarCboTodosProveedores(ByVal proveeServicios As String)
		Return helpersDA.CargarCboTodosProveedores(proveeServicios)
	End Function

	Public Function CargarCboTodosUsuarios()
		Return helpersDA.CargarCboTodosUsuarios()
	End Function

	Public Function CargarTodosProductos(ByVal parametros As Dictionary(Of String, String))
		Return helpersDA.CargarTodosProductos(parametros)
	End Function


	Public Function EnSesion() As Integer
        Return helpersDA.EnSesion()
    End Function

End Class
