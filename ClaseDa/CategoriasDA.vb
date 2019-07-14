Imports System.Data.SqlClient
Public Class CategoriasDA
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

	Public Function CargarGrillaCategorías() As DataSet
		helpersDA.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "Select * from categorias"
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

	Public Sub Modificar(nombre As String, descripcion As String, id As Integer)
		helpersDA.ChequearConexion(db)
		Try
			Dim insert As New SqlCommand("UPDATE categorias set Nombre = '" & nombre & "',Descripcion = " & If(descripcion <> "", "'" + descripcion + "'", "NULL") & " where id = " & id, db)
			insert.CommandType = CommandType.Text
			insert.ExecuteNonQuery()
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
	End Sub

	Public Function ConsultaModificacion(ByVal id As Integer) As DataSet
		helpersDA.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "Select * from categorias where id =" & id
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
	Public Sub GuardarNuevo(ByVal nombre As String, ByVal descripcion As String)
		helpersDA.ChequearConexion(db)
		Try
			Dim insert As New SqlCommand("insert into categorias VALUES ('" & nombre & "'," & If(descripcion <> "", "'" + descripcion + "'", "NULL") & ")", db)
			insert.CommandType = CommandType.Text
			insert.ExecuteNonQuery()
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
	End Sub
End Class
