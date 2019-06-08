Imports System.IO
Imports System.Drawing


Public Class ConversionDA


    'Funcion que convierte de Image a Byte()
    Public Function ImagenToBytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        Dim arreglo As Byte() = Nothing
        Try
            If Not Imagen Is Nothing Then
                'variable de datos binarios en stream(flujo)
                Dim Bin As New MemoryStream
                'convertir a bytes
                Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
                'retorna binario
                arreglo = Bin.GetBuffer
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("No convirtio a bytes por: " + ex.ToString)
        End Try
        Return arreglo
    End Function

    'Funcion que convierte de Byte() a Image
    Public Function BytesToImagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Function bytesToString(ByVal arreglo As Byte()) As String
        Dim salida As String = ""
        Dim x As Integer = 0
        'MsgBox("Tamaño del arreglo: " + arreglo.Length.ToString)
        Try
            For x = 0 To arreglo.Length - 1
                salida += arreglo(x).ToString + ","
            Next
        Catch ex As Exception
            MsgBox("No lo convertio a String por: " + ex.ToString)
        End Try

        Return salida
    End Function





End Class

