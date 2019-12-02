Imports System.Data.SqlClient
Imports ClaseNe

Public Class MovimientoStockDA
	Private db As New SqlConnection
	Private helpersDa As New HelpersDA
	Private com As New SqlCommand
	Private da As SqlDataAdapter
    Private ds1 As DataSet


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

    Public Function GeneraGraficomas() As DataSet
        helpersDa.ChequearConexion(db)

        Dim sqlStr As String
        ds1 = New DataSet
        sqlStr = " SELECT top(5) p.Nombre,sum(cantidad) as contador FROM MovimientosStock m inner join Productos p on m.ProductoId=p.id group by p.Nombre order by contador desc"

        Try
            da = New SqlDataAdapter(sqlStr, db)
            da.Fill(ds1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            helpersDa.ChequearConexion(db, "close")
        End Try
        helpersDa.ChequearConexion(db, "close")
        Return ds1
    End Function

    Public Function GeneraGraficomenos() As DataSet
        helpersDa.ChequearConexion(db)

        Dim sqlStr As String
        ds1 = New DataSet
        'sqlStr = " SELECT top(5) p.Nombre,COUNT(m.fecha) as contador FROM MovimientosStock m inner join Productos p on m.ProductoId=p.id group by p.Nombre order by contador asc"
        sqlStr = " SELECT top(5) p.Nombre,sum(cantidad) as contador FROM MovimientosStock m inner join Productos p on m.ProductoId=p.id group by p.Nombre order by contador asc"


        Try
            da = New SqlDataAdapter(sqlStr, db)
            da.Fill(ds1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            helpersDa.ChequearConexion(db, "close")
        End Try
        helpersDa.ChequearConexion(db, "close")
        Return ds1
    End Function

End Class
