

Imports ClaseLn
Imports System.Drawing


Public Class PRUEBA

    Private conversionmetodo As New ConversionLN
    Private productometodo As New ProductoLN
    Private Sub PRUEBA_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim myImagenConsulta As Image

        Try
            PictureBox1.Image = myImagenConsulta
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub



End Class