Imports System.Data.SqlClient
Imports ClaseNe
Public Class VentasDA
	Private db As New SqlConnection
	Private com As New SqlCommand
	Private da As SqlDataAdapter
	Private ds1 As DataSet

	Public Sub New()
		Dim objcon As New ConexionDA
		db = objcon.Abrir
		com.Connection = db
	End Sub


End Class
