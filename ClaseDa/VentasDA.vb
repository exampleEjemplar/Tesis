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
		sqlStr = "set dateformat dmy select v.Id, v.Fecha,c.Nombre +' '+ c.Apellido as Nombre ,v.Total from ventas as v inner join Clientes as c on c.Id = v.ClienteId"

		If parametros.Count <> 0 Then
			Dim count = parametros.Count
			Dim text = " where "
			For Each item As KeyValuePair(Of String, String) In parametros
				If item.Key = "ClienteId" Then
					count = count - 1
					text = text & "c.id" & " = " & item.Value & " " & If(count <> 0, " and ", "")
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
			sqlStr = sqlStr + text
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

	Public Sub Registrar(listaDeProductosId As List(Of TipoDeVentasNE), clienteId As Integer)
		Dim total As Integer
		For Each ventaDetalle As TipoDeVentasNE In listaDeProductosId
			total = total + (ventaDetalle.Precio * ventaDetalle.Cantidad)
		Next

		Try
			Dim insert As New SqlCommand("insert into ventas Values (GETDATE()," & clienteId & ", " & Math.Round(total, 2) & ",1)", db)
			insert.CommandType = CommandType.Text
			insert.ExecuteNonQuery()
			For Each ventaDetalle As TipoDeVentasNE In listaDeProductosId
				Dim insert2 As New SqlCommand("Declare @ventaID int SELECT @ventaID = MAX(Id) FROM ventas insert into DetalleVentas VALUES(@ventaID," & ventaDetalle.ProductoId & "," & ventaDetalle.Cantidad & "," & ventaDetalle.Precio * ventaDetalle.Cantidad & "," & ventaDetalle.Precio * ventaDetalle.Cantidad & ",NULL)", db)
				insert2.ExecuteNonQuery()
			Next
			db.Close()
      Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
	End Sub

End Class
