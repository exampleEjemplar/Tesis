Imports System.Text.RegularExpressions
Imports ClaseLn

Public Class HelpersUI
	Private loginLN As New LoginLN


	Public Function TextValidator(ByVal type As String, ByVal text As String)

		If String.IsNullOrEmpty(text) Then
			MsgBox("Debe ingresar correctamente el campo " & type, MsgBoxStyle.Critical, "Error")
			Return False
			Exit Function
		End If
		Return True

	End Function

	Function IsEmail(ByVal email As String) As Boolean
		Static emailRegex As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

		Return emailRegex.IsMatch(email)
	End Function

	Public Function HasStrangerCaracters(ByVal cadena As String) As Boolean
		Static regex As New Regex("^[_a-zA-Z0-9-]+")
		Return regex.IsMatch(cadena)
	End Function

	Public Function ValidarOperacion(ByVal frm As String)
		Dim userId = loginLN.ChequearEnSesion()
		Dim rolUsuario = loginLN.ConsultarRolUsuario("", userId)
		If rolUsuario = 1 Then
			Return True
		End If
		Select Case frm
			Case "FrmGestionCompras"
				If rolUsuario = 2 Then
					Return True
				End If
			Case "FrmGestionVentas"
				If rolUsuario = 2 Then
					Return True
				End If
			Case "FrmGestionPagos"
				If rolUsuario = 2 Then
					Return True
				End If
			Case "FrmArmadoVenta"
				If rolUsuario = 2 Then
					Return True
				End If
			Case "FrmArmadoCompra"
				If rolUsuario = 2 Then
					Return True
				End If
			Case "FrmArmadoPago"
				If rolUsuario = 2 Then
					Return True
				End If
			Case Else
				Return False
		End Select
		Return False
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

	Function AgregarNumerosComprobante(ByVal numero As Integer) As String
		Dim amountOfZeros As Integer = 8 - numero.ToString().Length
		Dim text As String = String.Empty
		For i = 1 To amountOfZeros
			text = text + "0"
		Next
		Return text + numero.ToString()
	End Function

	Function NormalizarTexto(ByVal text As String)
		If text Is "" Then
			Return text
		End If
		Dim newText As String = text.ToLower()
		Return Char.ToUpper(newText(0)) + newText.Substring(1)
	End Function
End Class
