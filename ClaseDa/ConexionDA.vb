Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data



Public Class ConexionDA

	Public Shared cn As SqlConnection

	Public Function Abrir() As SqlConnection
		cn = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
		Dim sqlStr As String
		Dim ds = New DataSet
		sqlStr = "insert into bdattempts Values(25,1)"
		Dim da As New SqlDataAdapter(sqlStr, cn)
		da.Fill(ds)
		If Not cn.State = ConnectionState.Open Then
			cn.Open()
		End If
		Return cn
	End Function

	Public Function Cerrar() As SqlConnection
		cn = New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
		Dim sqlStr As String
		Dim ds = New DataSet
		sqlStr = "insert into bdattempts Values(25,0)"
		Dim da As New SqlDataAdapter(sqlStr, cn)
		da.Fill(ds)
		If Not cn.State = ConnectionState.Closed Then
			cn.Close()
		End If
		Return cn
	End Function

End Class
