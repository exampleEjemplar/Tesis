Imports System.Data.SqlClient
Imports ClaseNe
Public Class CajaDA
	Private db As New SqlConnection
	Private helpersDA As New HelpersDA
	Private com As New SqlCommand
	Private da As SqlDataAdapter
	Private ds1 As DataSet

	Public Sub New()
		Dim objcon As New ConexionDA
		db = objcon.Abrir
		com.Connection = db
	End Sub

	Public Function CargarGrillaMovimientos(parametros As Dictionary(Of String, String)) As DataSet
		helpersDA.ChequearConexion(db)
		Dim ds = New DataSet

		Dim text = ""
		If parametros.Count <> 0 Then
			text += " where "
			Dim count = parametros.Count
			For Each item As KeyValuePair(Of String, String) In parametros
				If item.Key = "UsuarioId" Then
					count = count - 1
					text = text & "v.UsuarioId" & " = " & item.Value & " " & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "FechaDesde" And Not parametros.Keys.Contains("FechaHasta") Then
					count = count - 1
					text = text & "v.fecha" & " between '" & item.Value & " 00:00:00' and '" & item.Value & " 23:59:59'" & If(count <> 0, " and ", "")
					Continue For
				End If
				If item.Key = "FechaDesde" And parametros.Keys.Contains("FechaHasta") Then
					count = count - 1
					text = text & "v.fecha" & " between '" & item.Value & " 00:00:00' and "
					Continue For
				End If
				If item.Key = "FechaHasta" Then
					count = count - 1
					text = text & "'" & item.Value & " 23:59:59' " & If(count <> 0, " and ", "")
					Continue For
				End If
			Next
		End If
		'SE LLAMA TEXT EL PARAMETRO
		Dim sqlStr = "set dateformat dmy Select v.id,v.fecha,v.Total,u.Username from ventas as v inner join usuarios as u on u.id = v.usuarioId " + text + " set dateformat dmy Select v.id,v.fecha,v.Total,u.Username from compras as v inner join usuarios as u on u.id = v.usuarioId " + text

		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return ds
	End Function

	Public Function CargarUnMovimiento(movimientoId As Tuple(Of Integer, String)) As DataSet
		helpersDA.ChequearConexion(db)
		Dim ds = New DataSet
		Dim text = ""
		If movimientoId.Item2 = "Compra" Then
			text = ", cov.NroComprobante "
		End If
		Dim sqlStr = "Select cov.id,cov.fecha,cov.Total,u.username " + text + " from " + movimientoId.Item2 + "s as cov inner join usuarios as u on u.id = cov.usuarioID where cov.id = " + movimientoId.Item1.ToString()

		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return ds
	End Function







End Class
