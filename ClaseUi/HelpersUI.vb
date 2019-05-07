Imports System.Text.RegularExpressions

Public Class HelpersUI
    Public Function TextValidator(ByVal type As String, ByVal text As String)

        If String.IsNullOrEmpty(text) Then
            MsgBox("Debe ingresar correctamente el campo " & type, MsgBoxStyle.Critical, "Error")
            Return False
            Exit Function
        End If
        Return True

    End Function
    Public Function Validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail,
                "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function
End Class
