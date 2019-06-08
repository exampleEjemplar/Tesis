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


	Public Function CargarGrillaVentas(ByVal parametros As Dictionary(Of String, String)) As DataSet
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "select v.Id, v.Fecha,c.Nombre +' '+ c.Apellido as Nombre ,v.Total from ventas as v inner join Clientes as c on c.Id = v.ClienteId"

		If parametros.Count > 0 Then
			Dim extraText As String = String.Empty
			Dim count As Integer = 0
			For Each parametro As KeyValuePair(Of String, String) In parametros
				If count <> 0 Then
					extraText = extraText & " and "
				Else
					extraText = " where "
				End If
				extraText = extraText & " v." & parametro.Key & " like '%" & parametro.Value & "%'" 'TODO mejorar busqueda para integers
				count = count + 1
			Next
			sqlStr = sqlStr & extraText
		End If

		Try
			da = New SqlDataAdapter(sqlStr, db)
			da.Fill(ds1)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
		End Try
		Return ds1
		db.Close()
	End Function

End Class
