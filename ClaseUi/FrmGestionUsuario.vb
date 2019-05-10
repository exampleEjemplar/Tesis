Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe


Public Class FrmGestionUsuario

    Private UsuariosMetodo As New UsuariosLN
    Private usu As New UsuariosNE
    Private helpersLN As New HelpersLN
    Private helpersUI As New HelpersUI
    Public IdProvincia As Integer
    Public IdLocalidad As Integer
    Private fisicaOJuridica As String
    Private UsuarioId As Integer

#Region "Eventos"

    Private Sub FrmGestionProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Block()
        DgvUSuariosSet(New Dictionary(Of String, String))

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        MDIPrincipal.Show()
    End Sub

    Private Sub DgvProveedores_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvProveedores.DoubleClick

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnValidarDNI.Click
        If helpersUI.TextValidator("Tipo de persona", cboTipoPersona.SelectedItem) = False Or
    helpersUI.TextValidator("Tipo de identificacion", cbtipodni.Text) = False Or
    helpersUI.TextValidator("Numero de identificacion", tbNroDoc.Text) = False Then
            Return
        End If
        If helpersLN.ValidarSiExisteDni(Convert.ToInt64(tbNroDoc.Text), "Clientes") = False Then
            MsgBox("La identificación puede ser utilizada!", MsgBoxStyle.OkOnly, "Ok")
            Unblock()

            If String.IsNullOrWhiteSpace(txtBusApellido.Text) = False Then
                parametros.Add("Apellido", txtBusApellido.Text)
            End If
            DgvUSuariosSet(parametros)
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        GroupBox6.Visible = True
        btnNuevo.Enabled = False
    End Sub
#End Region
#Region "Validadores"

    'Valida datos antes de insertarlos en la BD
    Public Function ValidarDatos()

        'Agrego todos los txt y cbo a un diccionario para validarlos despues genericamente y no uno por uno
        Dim dictionaryOfMandatoriesTexts As Dictionary(Of String, String) = New Dictionary(Of String, String) From
        {{"Numero de calle", tbNro.Text}, {"Email", tbmail.Text}, {"Calle", tbcalle.Text},
        {"Localidad", cmbLocalidades.SelectedValue}}

        If fisicaOJuridica = "F" Then
            dictionaryOfMandatoriesTexts.Add("Nombre", tbNombre.Text)
            dictionaryOfMandatoriesTexts.Add("Apellido", tbApellido.Text)

            Next



            If String.IsNullOrWhiteSpace(tbcodcel.Text) = False And String.IsNullOrWhiteSpace(tbcel.Text) = True Then
                MsgBox("Ingrese el número de celular correspondiente", MsgBoxStyle.Critical, "Celular")
                Return False
            End If
            If String.IsNullOrWhiteSpace(tbcodcel.Text) = True And String.IsNullOrWhiteSpace(tbcel.Text) = False Then
                MsgBox("Ingrese la característica de celular correspondiente", MsgBoxStyle.Critical, "Celular")
                Return False

                MsgBox("Ingrese el número de teléfono correspondiente", MsgBoxStyle.Critical, "Teléfono")
                Return False
            End If
            If String.IsNullOrWhiteSpace(tbcodtel.Text) = True And String.IsNullOrWhiteSpace(tbtelefono.Text) = False Then
                MsgBox("Ingrese la característica de teléfono correspondiente", MsgBoxStyle.Critical, "Teléfono")
                Return False
            End If

            Dim value As Integer
            If Integer.TryParse(helpersLN.EnSesion, value) = True Then
                usu.UsuarioId = value
            Else
                usu.UsuarioId = Nothing
            End If
            usu.FisicaOJuridica = fisicaOJuridica
            usu.TipoDocumentoId = cbtipodni.SelectedValue
            usu.NumeroDocumento = tbNroDoc.Text
            usu.Email = tbmail.Text
            usu.Nombre = tbNombre.Text
            usu.Apellido = tbApellido.Text
            usu.FechaNacimiento = dtpfechanac.Value
            usu.CiudadId = cmbLocalidades.SelectedValue


            If String.IsNullOrEmpty(txtLote.Text) Then
                usu.Lote = "NULL"
            Else
                usu.Lote = txtLote.Text
            End If
            If String.IsNullOrEmpty(txtBarrio.Text) Then
                usu.Barrio = "NULL"
            Else
                usu.Barrio = txtBarrio.Text
            End If
            If String.IsNullOrEmpty(tbcodtel.Text) Then
                usu.Car_Telefono = "NULL"
            Else
                usu.Car_Telefono = tbcodtel.Text
            End If
            If String.IsNullOrEmpty(tbtelefono.Text) Then
                usu.NumeroTelefono = "NULL"
            Else
                usu.NumeroTelefono = tbtelefono.Text
            End If
            If String.IsNullOrEmpty(tbcodcel.Text) Then
                usu.Car_Celular = "NULL"
            Else
                usu.Car_Celular = tbcodcel.Text
            End If
            If String.IsNullOrEmpty(tbcel.Text) Then
                usu.NumeroCelular = "NULL"
            Else
                usu.NumeroCelular = tbcel.Text
            End If
            If String.IsNullOrEmpty(tbcalle.Text) Then
                usu.Calle = "NULL"
            Else
                usu.Calle = tbcalle.Text
            End If
            If String.IsNullOrEmpty(tbNro.Text) Then
                usu.NumeroCalle = "NULL"
            Else
                usu.NumeroCalle = tbNro.Text
            End If
            If String.IsNullOrEmpty(tbDpto.Text) Then
                usu.Departamento = "NULL"
            Else
                usu.Departamento = tbDpto.Text
            End If
            If String.IsNullOrEmpty(txtManzana.Text) Then
                usu.Manzana = "NULL"
            Else
                usu.Manzana = txtManzana.Text
            End If
            If String.IsNullOrEmpty(txtPiso.Text) Then
                usu.Piso = "NULL"
            Else
                usu.Piso = txtPiso.Text
            End If
            Return True
    End Function

    'Valida que el texto sea solo numeros
    Private Sub TxbTelNumero_KeyPress(sender As System.Object, e As KeyPressEventArgs) Handles tbcodcel.KeyPress, tbcodtel.KeyPress, tbcel.KeyPress, tbNroDoc.KeyPress, tbNro.KeyPress, txtPiso.KeyPress, txtManzana.KeyPress, txtLote.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Valida que el texto sea solo letras
    Private Sub TbNombre_KeyPress(sender As System.Object, e As KeyPressEventArgs) Handles tbNombre.KeyPress, tbApellido.KeyPress, txtBarrio.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

#End Region

#Region "Acciones"

    'Deshabilita los buttons,tb,etc necesarios
    Public Sub Block()
        GroupBox4.Visible = False
        GroupBox6.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        btnGuardar.Enabled = False
        cboTipoPersona.Enabled = True
        cbtipodni.Enabled = False

        btnNuevo.Enabled = False
        GroupBox4.Visible = True
        GroupBox2.Visible = True
        GroupBox3.Visible = True
        btnGuardar.Enabled = True
        cboTipoPersona.Enabled = False
        cbtipodni.Enabled = False
        tbNroDoc.ReadOnly = True
        btnValidarDNI.Enabled = False
    End Sub

    'Limpia los campos para una nueva inserción

    tbNro.Text = ""
        tbtelefono.Text = ""
        tbcodtel.Text = ""
        tbcel.Text = ""
        tbcodtel.Text = ""
        txtPiso.Text = ""
        tbDpto.Text = ""
        txtBarrio.Text = ""
        cmbProvincias.SelectedItem = Nothing
        cmbLocalidades.SelectedItem = Nothing
    End Sub
#End Region

#Region "Rellenado"

    Public Function LlenarCMBProvincias(ByVal type As String)
        Try
            Dim ds1 As DataSet
            ds1 = helpersLN.CargarCMBProvincias()
            cmbProvincias.DataSource = ds1.Tables(0)
            cmbProvincias.DisplayMember = "nombre"
            cmbProvincias.ValueMember = "id"
            cmbProvincias.SelectedValue = 1
            If type = "unico" Then
                cmbProvincias.SelectionStart = IdProvincia
                cmbProvincias.SelectedValue = IdProvincia
            Else
            End If
            Return cmbProvincias.SelectedValue
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    'Carga el combo Localidades
    Public Sub LlenarCMBLocalidades(ByVal type As String)
        Try
            Dim ds1 As DataSet
            ds1 = helpersLN.CargarCMBLocalidades(IdProvincia)
            cmbLocalidades.DataSource = ds1.Tables(0)
            cmbLocalidades.DisplayMember = "nombre"
            cmbLocalidades.ValueMember = "id"
            'Type unico, le setea el valor del Idlocalidad que fue encontrado en la bd
            If type = "unico" Then
                cmbLocalidades.SelectedValue = IdLocalidad
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Carga el combo tipo de documento
    Public Sub LlenarCMBDoc(ByVal FoJ As String, ByVal type As String)
        If type = "busqueda" Then
            Try
                Dim ds1 As DataSet
                ds1 = helpersLN.CargarCMBDoc(FoJ)
                cboBusTipoDNI.DataSource = ds1.Tables(0)
                cboBusTipoDNI.DisplayMember = "descripcion"
                cboBusTipoDNI.ValueMember = "id"
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Dim ds1 As DataSet
                ds1 = helpersLN.CargarCMBDoc(FoJ)
                cbtipodni.DataSource = ds1.Tables(0)
                cbtipodni.DisplayMember = "descripcion"
                cbtipodni.ValueMember = "id"
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    'Carga DataGridView con datos
    Public Sub DgvUSuariosSet(ByVal parametros As Dictionary(Of String, String))
        Dim dsa1 As DataSet
        dsa1 = UsuariosMetodo.CargaGrillaProveedores(parametros) 'Si parametros esta vacio, busca todos los proveedores en la bd
        dgvProveedores.DataSource = dsa1.Tables(0)
    End Sub


#End Region
End Class