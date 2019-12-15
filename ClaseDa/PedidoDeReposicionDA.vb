Imports System.Data.SqlClient
Imports ClaseNe

Public Class PedidoDeReposicionDA
	Private db As New SqlConnection
	Private helpersDA As New HelpersDA
	Private com As New SqlCommand
	Private da As SqlDataAdapter
	Private ds1 As DataSet

	Public Sub New()
		Dim objcon As New ConexionDA
		db = objcon.Abrir
		db = objcon.Cerrar
		com.Connection = db
	End Sub
	Public Sub CambiarEstado(idpedido As Integer, nuevoEstado As Integer)
		helpersDA.ChequearConexion(db)
		Try
			Dim insertPrincipal As New SqlCommand("update PedidosReposicion set estado = " + nuevoEstado.ToString() + " where id = " + idpedido.ToString(), db)
			insertPrincipal.ExecuteNonQuery()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDA.ChequearConexion(db, "close")
		End Try
		helpersDA.ChequearConexion(db, "close")
	End Sub


	Function CargarPedido(id As Integer)
		helpersDA.ChequearConexion(db)
		Dim sqlstr = "select pr.*, dprp.*, dprprod.*, p.Apellido + ', ' + p.Nombre as 'Nombre Proveedor', prod.nombre as 'Nombre Producto' FROM PedidosReposicion pr " +
							" inner join DetallePedidosReposicionProveedor dprp on pr.id = dprp.PedidoReposicionId " +
							" inner join DetallePedidosReposicionProductos dprprod on dprp.id = dprprod.DetallePedidosReposicionProveedorId" +
							" inner join proveedores p on p.id = dprp.proveedorId inner join productos prod on prod.id = dprprod.productoId where pr.id = " + id.ToString() + " order by dprp.proveedorId"
		ds1 = New DataSet
		Try
			da = New SqlDataAdapter(sqlstr, db)
			da.Fill(ds1)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDA.ChequearConexion(db, "close")
		End Try
		helpersDA.ChequearConexion(db, "close")
		Return ds1
	End Function


	Function CargarPedidos(fecha1 As Date?, fecha2 As Date?)
		helpersDA.ChequearConexion(db)
		Dim sqlstr = "set dateformat dmy select pr.id,pr.fecha Fecha,pr.total Total, CASE WHEN pr.estado = 1" +
							"THEN 'Activo' WHEN pr.estado = 0 THEN 'Anulado' ELSE 'Finalizado' END AS Estado FROM PedidosReposicion pr " +
							" inner join DetallePedidosReposicionProveedor dprp on pr.id = dprp.PedidoReposicionId " +
							" inner join DetallePedidosReposicionProductos dprprod on dprp.id = dprprod.DetallePedidosReposicionProveedorId where pr.estado != 0"
		If fecha1.HasValue And fecha2.HasValue Then
			sqlstr += " and pr.fecha between '" + fecha1.Value.ToShortDateString() + " 00:00:00' and '" + fecha2.Value.ToShortDateString() + " 23:59:59'"
		ElseIf fecha1.HasValue And Not fecha2.HasValue Then
			sqlstr += " and pr.fecha between '" + fecha1.Value.ToShortDateString() + " 00:00:00' and '" + fecha1.Value.ToShortDateString() + " 23:59:59'"
		End If
		sqlstr += " group by pr.id,pr.fecha,pr.total,pr.estado"
		ds1 = New DataSet
		Try
			da = New SqlDataAdapter(sqlstr, db)
			da.Fill(ds1)
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDA.ChequearConexion(db, "close")
		End Try
		helpersDA.ChequearConexion(db, "close")
		Return ds1
	End Function

	Public Sub RegistrarConjuntoPedidoDeReposición(listaDeListas As List(Of List(Of TipoDeComprasNE)))
		helpersDA.ChequearConexion(db)
		Dim total As Decimal = 0
		For Each listaProveedor As List(Of TipoDeComprasNE) In listaDeListas
			total += listaProveedor.Sum(Function(x) x.Cantidad * x.Precio)
		Next
		Try
			Dim insertPrincipal As New SqlCommand("insert into PedidosReposicion VALUES(GETDATE()," + Decimal.Round(total, 2).ToString().Replace(",", ".") + ",1)", db)
			insertPrincipal.ExecuteNonQuery()

			For Each listaProveedor As List(Of TipoDeComprasNE) In listaDeListas

				Dim totalProveedor As Decimal = listaProveedor.Sum(Function(x) x.Cantidad * x.Precio)
				Dim insertPorProveedor As New SqlCommand("Declare @pedrepID int SELECT @pedrepID = MAX(Id) FROM PedidosReposicion  insert into DetallePedidosReposicionProveedor VALUES(@pedrepID," + listaProveedor.FirstOrDefault().ProveedorId.ToString() + "," + Decimal.Round(totalProveedor, 2).ToString().Replace(",", ".") + ")", db)
				insertPorProveedor.ExecuteNonQuery()

				For Each producto As TipoDeComprasNE In listaProveedor

					Dim totalProducto As Decimal = producto.Cantidad * producto.Precio
					Dim insertPorProducto As New SqlCommand("Declare @pedrepprovID int SELECT @pedrepprovID = MAX(Id) FROM DetallePedidosReposicionProveedor  insert into DetallePedidosReposicionProductos VALUES(@pedrepprovID," + producto.ProductoId.ToString() + "," + producto.Cantidad.ToString() + "," + producto.Precio.ToString().Replace(",", ".") + "," + totalProducto.ToString().Replace(",", ".") + ")", db)
					insertPorProducto.ExecuteNonQuery()

				Next

			Next

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
			helpersDA.ChequearConexion(db, "close")
		End Try
		helpersDA.ChequearConexion(db, "close")
	End Sub

End Class
