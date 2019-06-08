
Imports ClaseDa
Imports System.Drawing

Public Class ConversionLN

    Dim objconversion As ConversionDA

    Public usr As String
    Public rolUsuario As Integer
    Public usr_id As Integer

    Public Sub New()
        objconversion = New ConversionDA
    End Sub


    Function ImagenToBytes(ByVal Imagen As Image) As Byte()

        Return objconversion.ImagenToBytes(Imagen)
    End Function

    Function BytesToImagen(ByVal Imagen As Byte()) As Image

        Return objconversion.BytesToImagen(Imagen)
    End Function

    Function bytesToString(ByVal arreglo As Byte()) As String
        Return objconversion.bytesToString(arreglo)

    End Function
End Class
