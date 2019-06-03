Imports ClaseDA
Imports ClaseNe
Public Class ProductoLN

    Private objproductosAD As MetodoProductoDA

    Public idProv As Integer
    Public QPacientes As Integer
    Public QPacientesMod As Integer
    Public IdPaciente1 As Integer

    Public Sub New()
        objproductosAD = New MetodoProductoDA
    End Sub

    Public Function CargarCMBTipo()

        Return objproductosAD.CargarCMBtIpo
    End Function

    Public Function CargarCMBmaterial()

        Return objproductosAD.CargarCMBmaterial
    End Function

    Public Function CargarCMBproveerdor()


        Return objproductosAD.CargarCMBproveerdor()

    End Function
    Public Function ConsultarCodigo()


        Return objproductosAD.ConsultarCodigo()

    End Function


    Public Function LlenarCMBCategoria()


        Return objproductosAD.LlenarCMBCategoria()

    End Function

    Public Function CargarCMBcategoria1(ByVal idcat As Integer)

        Return objproductosAD.CargarCMBcategoria1(idcat)

    End Function

    Public Function CargarCMBcategoria2(ByVal idcat1 As Integer)

        Return objproductosAD.CargarCMBcategoria2(idcat1)

    End Function
    Public Sub Grabarproductos(ByVal pro As ProductosNE)
        objproductosAD.Grabarproductos(pro)
    End Sub

    Public Function CargaGrillaproductossinbusqueda(ByVal codigo As String, ByVal nombre As String) As DataTable

        Return objproductosAD.CargaGrillaproductossinbusqueda(codigo, nombre)
    End Function


    Public Function CargaGrillaproductosconbusqueda(ByVal codigo As String, ByVal nombre As String) As DataTable

        Return objproductosAD.CargaGrillaproductosconbusqueda(codigo, nombre)
    End Function

    'Public Function consultarimagen() As Byte()
    '    Return objproductosAD.consultarimagen()
    'End Function
    ''
    'Public Function ConsultaModificacion(ByVal nroDoc As Integer)

    '    Return objclientesAD.ConsultaModificacion(nroDoc)

    'End Function





    'Public Sub ActualizarClientes(ByVal cli As ClientesNE)
    '    objclientesAD.ActualizarClientes(cli)
    'End Sub

End Class

