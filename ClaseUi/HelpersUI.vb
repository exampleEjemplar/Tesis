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
    Public Function ValidarTamaño(ByVal text As String, ByVal minLength As Integer, ByVal maxLength As Integer) As Boolean
        'Pasar en 0 el parametro que no se quiera validar
        If minLength <> 0 Then
            If text.Length < minLength Then
                Return False
            End If
        End If
        If maxLength <> 0 Then
            If text.Length > maxLength Then
                Return False
            End If
        End If
        Return True
    End Function

    Function ValidatePassword(ByVal pwd As String,
    Optional ByVal minLength As Integer = 8,
    Optional ByVal numUpper As Integer = 1,
    Optional ByVal numLower As Integer = 1,
    Optional ByVal numNumbers As Integer = 1,
    Optional ByVal numSpecial As Integer = 0) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function

    'Sub TestValidatePassword()
    '    Dim password As String = "Password"
    '    ' Demonstrate that "Password" is not complex.
    '    MsgBox(password & " is complex: " & ValidatePassword(password))

    '    password = "Z9f%a>2kQ"
    '    ' Demonstrate that "Z9f%a>2kQ" is not complex.
    '    MsgBox(password & " is complex: " & ValidatePassword(password))
    'End Sub
End Class
