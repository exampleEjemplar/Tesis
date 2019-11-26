﻿Imports System.Data.SqlClient
Imports ClaseNe

Public Class MovimientoStockDA
	Private db As New SqlConnection
	Private helpersDa As New HelpersDA
	Private com As New SqlCommand
	Private da As SqlDataAdapter

	Public Sub New()
        Dim objcon As New ConexionDA
        db = objcon.Abrir
		db = objcon.Cerrar
		com.Connection = db
	End Sub

	Public Sub Registrar(productoId As Integer, movimiento As Integer)
		helpersDa.ChequearConexion(db)

		Try
			Dim insert As New SqlCommand("insert into MovimientosStock (Cantidad,ProductoId,Fecha) VALUES (" & movimiento & ", " & productoId & ",GETDATE())", db)
			insert.CommandType = CommandType.Text
			insert.ExecuteNonQuery()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDa.ChequearConexion(db, "close")
		End Try
	End Sub

End Class
