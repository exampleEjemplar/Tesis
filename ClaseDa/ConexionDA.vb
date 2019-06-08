Imports System.Data.SqlClient
Imports ClaseNE

Public Class ConexionDA

	Public Shared scon As New SqlConnection
	Public Function Abrir() As SqlConnection
		Dim con As String
		'con = "Data Source= DESKTOP-J1N9KFO\SQLEXPRESS;Initial Catalog=JoyeriaCrisol11;Integrated Security=True"
		con = "Data Source= DESKTOP-PDNSPVO\LOCAL;Initial Catalog=JoyeriaCrisol2;Integrated Security=True"
		scon = New SqlConnection(con)
		scon.Open()  '---------------------------------- DESHABILITE EL OPEN DE LA BASE AUTOMATICO
		Return scon
	End Function

	'Public Shared Function Cerrar() As Boolean
	'    Try
	'        If scon.State = ConnectionState.Open Then
	'            scon.Close()
	'            Return True
	'        Else
	'            Return False
	'        End If
	'    Catch ex As Exception
	'        MsgBox(ex.Message)
	'        Return False
	'    End Try
	'End Function


End Class
