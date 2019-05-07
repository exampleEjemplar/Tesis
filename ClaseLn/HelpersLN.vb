Imports ClaseDa

Public Class HelpersLN

    Private helpersDA As New HelpersDA
    Public Sub New()
        helpersDA = New HelpersDA
    End Sub

    Public Function CargarCMBProvincias()
        Return helpersDA.CargarCMBProvincias()
    End Function

    Public Function CargarCMBLocalidades(ByVal idprov As Integer)
        Return helpersDA.CargarCMBLocalidades(idprov)
    End Function

    Public Function CargarCMBDoc(ByVal FoJ As Char)
        Return helpersDA.CargarCMBDoc(FoJ)
    End Function

    Public Function ValidarSiExisteDni(ByVal numero As Double, ByVal entidad As String)
        Return helpersDA.ValidarSiExisteDni(numero, entidad)
    End Function

End Class
