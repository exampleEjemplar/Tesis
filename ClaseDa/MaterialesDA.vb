Imports System.Data.SqlClient
Public Class MaterialesDA
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

	Public Function CargarGrillaMateriales() As DataSet
		helpersDA.ChequearConexion(db)

		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "SELECT m.Id,m.Nombre,c.Cotizacion, Max(c.Fecha) AS fecha From Materiales As m inner Join cotizaciones As c On m.Id = c.MaterialId Group By m.id, m.Nombre, c.Cotizacion"
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
		helpersDA.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "Select TOP 1 m.Nombre, c.Cotizacion, c.Fecha, m.Id from materiales As m inner Join Cotizaciones As c On c.MaterialId = m.Id where m.id = " & id & " order by c.fecha desc"
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

	Public Sub GuardarNuevo(ByVal nombre As String, ByVal coti As String)
		helpersDA.ChequearConexion(db)
		Try
			'Inserto nuevo registro de material
			Dim insert As New SqlCommand("insert into materiales VALUES ('" & nombre & "')", db)
			insert.CommandType = CommandType.Text
			insert.ExecuteNonQuery()
			'Inserto nuevo registro de cotizacion de ese material
			Dim insert2 As New SqlCommand("declare @MaterialId int SELECT @MaterialId = MAX(Id) FROM Materiales insert into cotizaciones VALUES (" & coti.Replace(",", ".") & ",@MaterialId,GETDATE())", db)
			insert2.CommandType = CommandType.Text
			insert2.ExecuteNonQuery()
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
	End Sub

	Public Sub NuevaCotizacion(ByVal id As Integer, ByVal coti As String)
		helpersDA.ChequearConexion(db)
		Try
			Dim insert2 As New SqlCommand("insert into cotizaciones VALUES (" & coti.Replace(",", ".") & "," & id & ",GETDATE())", db)
			insert2.CommandType = CommandType.Text
			insert2.ExecuteNonQuery()
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
	End Sub

	Public Function ConsultaHistoricaCotizaciones(ByVal id As Integer) As DataSet
		helpersDA.ChequearConexion(db)
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "Select m.id, m.Nombre, c.Cotizacion, c.Fecha from materiales as m inner Join Cotizaciones as c on c.MaterialId = m.Id where m.id = " & id & " order by c.fecha desc"
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
