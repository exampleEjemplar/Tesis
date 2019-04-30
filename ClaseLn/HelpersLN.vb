Imports ClaseDa

Public Class HelpersLN
    Public idprov As Integer

    Private helpersDA As New HelpersDA
    Public Sub New()
        helpersDA = New HelpersDA
    End Sub

    Public Function CargarCMBProvincias()
        Return helpersDA.CargarCMBProvincias()
    End Function

    Public Function CargarCMBLocalidades()
        Return helpersDA.CargarCMBLocalidades(idprov)
    End Function

    Public Function CargarCMBDoc()
        Return helpersDA.CargarCMBDoc()
    End Function

End Class
