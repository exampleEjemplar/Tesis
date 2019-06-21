﻿Imports System.Data.SqlClient
Public Class MaterialesDA
	Private db As New SqlConnection
	Private com As New SqlCommand
	Private da As SqlDataAdapter
	Private ds1 As DataSet

	Public Sub New()
		Dim objcon As New ConexionDA
		db = objcon.Abrir
		com.Connection = db
	End Sub

	Public Function CargarGrillaMateriales() As DataSet
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "Select * from Materiales"
		Try
			da = New SqlDataAdapter(sqlStr, db)
			da.Fill(ds1)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return ds1
	End Function

	Public Function ConsultaModificacion(ByVal id As Integer) As DataSet
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "Select * from materiales where id =" & id
		Try
			da = New SqlDataAdapter(sqlStr, db)
			da.Fill(ds1)
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
		Return ds1
	End Function

End Class
