Imports System.Data.SqlClient
Imports ClaseNe
Public Class CajaDA
	Private db As New SqlConnection
	Private helpersDA As New HelpersDA
	Private com As New SqlCommand
	Private da As SqlDataAdapter
	Private ds1 As DataSet
    Dim Rs As SqlDataReader
    Public contador As Integer
    Public enunciado As SqlCommand

    Public Sub New()
		Dim objcon As New ConexionDA
		db = objcon.Abrir
		db = objcon.Cerrar
		com.Connection = db
	End Sub


    Public Function CargarGrillaMovimientosEstado(parametros As Dictionary(Of String, String)) As DataSet
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
				If item.Key = "FechaUnica" And Not parametros.Keys.Contains("FechaHasta") Then
					count = count - 1
					text = text & "v.fecha" & " between '" & item.Value & " 00:00:00' and '" & item.Value & " 23:59:59'" & If(count <> 0, " and ", "")
					Continue For
				ElseIf item.Key = "FechaHasta" And Not parametros.Keys.Contains("FechaDesde") Then
					count = count - 1
					text = text & "v.fecha" & " < '" & item.Value & " 23:59:59'" & If(count <> 0, " and ", "")
					Continue For
				ElseIf item.Key = "FechaDesde" And Not parametros.Keys.Contains("FechaHasta") Then
					count = count - 1
					text = text & "v.fecha" & " > '" & item.Value & " 00:00:00'" & If(count <> 0, " and ", "")
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
        Dim sqlStr = "set dateformat dmy Select v.id,v.fecha,v.Total,u.Username from ventas as v inner join usuarios as u on u.id = v.usuarioId " + text + "and v.estado=1 set dateformat dmy Select v.id,v.fecha,v.Total,u.Username from compras as v inner join usuarios as u on u.id = v.usuarioId " + text + "and v.estado=1"

        Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDA.ChequearConexion(db,"close")
		End Try
		Return ds
    End Function
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
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDA.ChequearConexion(db,"close")
		End Try
		helpersDA.ChequearConexion(db,"close")
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
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDA.ChequearConexion(db,"close")
		End Try
		helpersDA.ChequearConexion(db,"close")
		Return ds
	End Function


    Public Sub grabarCierredeCaja(ByVal idusuario As Integer, ByVal txtmontofinal As Double)
		helpersDA.ChequearConexion(db)
		Try
			Dim totalizado = txtmontofinal.ToString().Replace(",", ".")
			Dim insert As New SqlCommand("insert INTO CierreCajas (usr_id, fecha, importe, estado) values (" & idusuario & ", getdate()," & totalizado & ",1)", db)
			insert.CommandType = CommandType.Text
			insert.ExecuteNonQuery()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDA.ChequearConexion(db,"close")
		End Try
		helpersDA.ChequearConexion(db,"close")
	End Sub

    Public Function updateCierre(ByVal idusuario As Integer) As DataSet
		helpersDA.ChequearConexion(db)
		Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = "update compras set estado = 0 where usuarioID = " & idusuario & "update ventas set estado = 0 where usuarioID = " & idusuario

        Try

            da = New SqlDataAdapter(sqlStr, db)
			da.Fill(ds1)
		Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDA.ChequearConexion(db,"close")
		End Try
		helpersDA.ChequearConexion(db,"close")
		Return ds1
	End Function



	Public Function ControlCierreCaja() As DataSet
		helpersDA.ChequearConexion(db)
		enunciado = New SqlCommand("select * from COMPRAs c WHERE c.estado=1 union all select fecha, '','',total,'','','' from ventas v WHERE v.estado=1 ", db)
		Dim ds As New DataSet
		Try
			Dim da = New SqlDataAdapter(enunciado)
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.ToString)
			helpersDA.ChequearConexion(db,"close")
		End Try
		helpersDA.ChequearConexion(db,"close")
		Return ds
	End Function

End Class
