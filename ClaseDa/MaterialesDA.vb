Imports System.Data.SqlClient
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
		sqlStr = "Select TOP 1 m.Nombre, c.Cotizacion, c.Fecha, m.Id from materiales as m inner Join Cotizaciones as c on c.MaterialId = m.Id where m.id = " & id & " order by c.fecha desc"
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

	Public Sub GuardarNuevo(ByVal nombre As String, ByVal coti As Double)
		Try
			'Inserto nuevo registro de material
			Dim insert As New SqlCommand("insert into materiales VALUES ('" & nombre & "')")
			insert.CommandType = CommandType.Text
			insert.ExecuteNonQuery()
			'Inserto nuevo registro de cotizacion de ese material
			Dim insert2 As New SqlCommand("@MaterialId int SELECT @MaterialId = MAX(Id) FROM Materiales insert into cotizaciones VALUES (" & coti & ",@MaterialId,GETDATE())")
			insert2.CommandType = CommandType.Text
			insert2.ExecuteNonQuery()
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
	End Sub

	Public Sub NuevaCotizacion(ByVal id As Integer, ByVal coti As Double)
		Try
			Dim insert2 As New SqlCommand("insert into cotizaciones VALUES (" & coti & "," & id & ",GETDATE())")
			insert2.CommandType = CommandType.Text
			insert2.ExecuteNonQuery()
			db.Close()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			db.Close()
		End Try
	End Sub

	Public Function ConsultaHistoricaCotizaciones(ByVal id As Integer) As DataSet
		Dim sqlStr As String
		ds1 = New DataSet
		sqlStr = "Select m.Nombre, c.Cotizacion, c.Fecha from materiales as m inner Join Cotizaciones as c on c.MaterialId = m.Id where m.id = " & id & " order by c.fecha desc"
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
