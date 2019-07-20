Imports System.Data.SqlClient
Imports ClaseNE

Public Class ConexionDA

	Public Shared scon As New SqlConnection
	Public Function Abrir() As SqlConnection
		Dim con As String
		' con = "Data Source=EQUIPO007608\SQLEXPRESS;Initial Catalog=JoyeriaCrisol;Integrated Security=True"
		'con = "Data Source= DESKTOP-J1N9KFO\SQLEXPRESS;Initial Catalog=JoyeriaCrisol;Integrated Security=True"
		con = "Data Source= DESKTOP-PDNSPVO\LOCAL;Initial Catalog=JoyeriaCrisol1;Integrated Security=True"
		' con = "Data Source= I73770-PEDRO\LOCALDB;Initial Catalog=JoyeriaCrisol;Integrated Security=True"

		scon = New SqlConnection(con)
		scon.Open()
		Return scon
	End Function



End Class
