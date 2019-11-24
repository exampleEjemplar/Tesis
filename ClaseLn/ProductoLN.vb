Imports ClaseDA
Imports ClaseNe
Public Class ProductoLN

	Private objproductosAD As MetodoProductoDA

	Public idProv As Integer
	Public QProducto As Integer
	Public QPacientesMod As Integer
	Public IdPaciente1 As Integer

	Public Sub New()
		objproductosAD = New MetodoProductoDA

	End Sub

	Public Function BuscaServicios(ByVal parametros As Dictionary(Of String, String))
		Return objproductosAD.BuscaServicios(parametros)
	End Function

	Public Sub RegistrarServicio(pro As ProductosNE)
		objproductosAD.RegistrarServicio(pro)
	End Sub

	Public Function CargarGrillaStock(parametros As Dictionary(Of String, String)) As DataSet
		Return objproductosAD.CargarGrillaStock(parametros)
	End Function

	Public Function CargarTodosMovimientos(productoId As Integer) As DataSet
		Return objproductosAD.CargarTodosMovimientos(productoId)
	End Function


	Public Function CargarCMBTipo()

		Return objproductosAD.CargarCMBtIpo
	End Function

	Public Function CargarCMBmaterial()

		Return objproductosAD.CargarCMBmaterial
	End Function

	Public Function CargarCMBproveerdor()


		Return objproductosAD.CargarCMBproveerdor()

	End Function
	Public Sub ConsultarCodigo()

		objproductosAD.ControlID()
		QProducto = objproductosAD.qidproductos
	End Sub


	Public Function LlenarCMBCategoria()


		Return objproductosAD.LlenarCMBCategoria()

	End Function

	Public Function Cargargrilladobleclick()

		Return objproductosAD.Cargargrilladobleclick()

	End Function

	Public Function CargarCMBcategoria2(ByVal idcat1 As Integer)

		Return objproductosAD.CargarCMBcategoria2(idcat1)

	End Function
	Public Sub Grabarproductos(ByVal pro As ProductosNE)
		objproductosAD.Grabarproductos(pro)
	End Sub

	Public Sub modificarproductos(ByVal pro As ProductosNE)
		objproductosAD.modificarproductos(pro)
	End Sub

	Public Function CargaGrillaproductossinbusqueda(ByVal codigo As String, ByVal nombre As String, Optional esReparacion As String = "") As DataTable

		Return objproductosAD.CargaGrillaproductossinbusqueda(codigo, nombre, esReparacion)
	End Function

    Public Function CargaGrillaproductosconbusqueda(ByVal parametros As Dictionary(Of String, String)) As DataSet

        Return objproductosAD.CargaGrillaproductosconbusqueda(parametros)
    End Function

    Public Function CargaGrillaproductosCONbusquedaCAT(ByVal codigo As String, ByVal nombre As String, ByVal categoria As Integer) As DataTable

		Return objproductosAD.CargaGrillaproductosCONbusquedaCAT(codigo, nombre, categoria)
	End Function

	Public Function CargaGrillaproductosCONbusquedaproducto(ByVal codigo As String, ByVal nombre As String, ByVal categoria As Integer) As DataTable

		Return objproductosAD.CargaGrillaproductosCONbusquedaproducto(codigo, nombre, categoria)
	End Function


	Public Function CargaGrillaProductos(ByVal parametros As Dictionary(Of String, String)) As DataSet
		Return objproductosAD.CargaGrillaProductos(parametros)
	End Function


	Public Function CargarUnProducto(id As Integer, nombre As String)
		Return objproductosAD.CargarUnProducto(id, nombre)
	End Function

	Public Sub ModificarPrecios(listOfProductos As IEnumerable(Of Tuple(Of Integer, Boolean, ProductosNE)), precio As String, tipo As String)
		objproductosAD.ModificarPrecios(listOfProductos, precio, tipo)
	End Sub


End Class

