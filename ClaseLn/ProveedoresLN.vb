Imports ClaseNE
Imports ClaseDa

Public Class ProveedoresLN
    Private ProveedoresDA As ProveedoresDA
    Public Sub New()
        ProveedoresDA = New ProveedoresDA
    End Sub

    Public Function CargaGrillaproveedores(ByVal busqdni As String, ByVal busqape As String) As DataSet
        Return ProveedoresDA.CargaGrillaproveedores(busqdni, busqape)
    End Function

    Public Sub Grabarproveedores(ByVal pro As ProveedoresNE)
        ProveedoresDA.grabarProveedores(pro)
    End Sub

End Class
