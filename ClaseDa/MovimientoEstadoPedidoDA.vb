Imports System.Data.SqlClient
Imports ClaseNe
Public Class MovimientoEstadoPedidoDA
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

	Public Function CargarMovimientosEstado(ByVal idpedido As Integer) As DataSet
		helpersDA.ChequearConexion(db)
		Dim ds = New DataSet
		Dim sqlStr = "select * from movimientoEstadospedidos where pedidoid=" & idpedido
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDA.ChequearConexion(db, "close")
		End Try
		helpersDA.ChequearConexion(db, "close")
		Return ds
	End Function

	Public Function CargarMovimientosAgrupadoPorProveedor() As DataSet
		helpersDA.ChequearConexion(db)
		Dim ds = New DataSet
		Dim sqlStr = "select prov.id, mep.EstadoId, mep.Fecha,p.id,mep.activo from MovimientoEstadosPedidos mep inner join pedidos p on p.id = mep.PedidoId inner join DetallePedidos dp on dp.PedidoId = p.id inner join Productos prod on prod.id = dp.ProductoId inner join Proveedores prov on prov.id = prod.ProveedorId where mep.EstadoId in (2,3) and p.EsReparacion = 'N' and prod.EsServicio = 'N' group by prov.id, mep.EstadoId, mep.Fecha,p.id,mep.activo "
		Try
			Dim da As New SqlDataAdapter(sqlStr, db)
			da.Fill(ds)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDA.ChequearConexion(db, "close")
		End Try
		helpersDA.ChequearConexion(db, "close")
		Return ds
	End Function

End Class
