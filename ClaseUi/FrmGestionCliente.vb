Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe


Public Class FrmGestionCliente

    Private clientemetodo As New ClientesLN
    Private cli As New ClientesNE
    Private helpersLN As New HelpersLN
    Private helpersUI As New HelpersUI
    Public IdProvincia As Integer
    Public IdLocalidad As Integer
    Private fisicaOJuridica As String
    Private ClienteID As Integer

#Region "Eventos"

    Private Sub FrmGestionCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbProvincias.SelectedValue = 0
        cbtipodni.SelectedValue = 0
        cboTipoPersona.DataSource = New List(Of String) From {"Física", "Jurídica"}
        IdProvincia = LlenarCMBProvincias("general")
        LlenarCMBLocalidades("general")
        dtpfechanac.MinDate = Date.Today.AddYears(-100)
        Block()
        DgvclientesSet(New Dictionary(Of String, String))

    End Sub

    Private Sub CmbProvincias_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbProvincias.SelectionChangeCommitted
        IdProvincia = cmbProvincias.SelectedValue
        LlenarCMBLocalidades("general")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidarDatos() = False Then
            Return
        End If
        If ClienteID = 0 Then
            clientemetodo.GrabarClientes(cli)
            MsgBox("Cliente agregado con exito!", MsgBoxStyle.OkOnly, "Exito")
        Else
            cli.Id = ClienteID
            clientemetodo.ActualizarClientes(cli)
            MsgBox("Cliente actualizado con exito!", MsgBoxStyle.OkOnly, "Exito")
        End If
        'DgvclientesSet()
        Limpiar()
        Block()
        DgvclientesSet(New Dictionary(Of String, String))

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        MDIPrincipal.Show()
    End Sub

    Private Sub Dgvcliente_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvclientes.DoubleClick

        Dim ds As DataSet = clientemetodo.ConsultaModificacion((dgvclientes.Item(2, dgvclientes.CurrentRow.Index).Value))
        'idcliente = (dgvclientes.Item(0, dgvclientes.CurrentRow.Index).Value)
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            'cboTipoPersona.DataSource = New List(Of String) From {"Física", "Jurídica"}
            If ds.Tables(0).Rows(i)(0).ToString() = "F" Then
                cboTipoPersona.SelectionStart = 0
                lblInicioAct.Visible = False
                lblNombreFanta.Visible = False
                lblRazonSoc.Visible = False
            Else
                cboTipoPersona.SelectionStart = 1
                lblFechaNac.Visible = False
                lblNombre.Visible = False
                lblApellido.Visible = False
            End If
            LlenarCMBDoc(ds.Tables(0).Rows(i)(0).ToString(), "nuevo")
            tbNroDoc.Text = ds.Tables(0).Rows(i)(2).ToString()
            tbNombre.Text = ds.Tables(0).Rows(i)(3).ToString()
            tbApellido.Text = ds.Tables(0).Rows(i)(4).ToString()
            dtpfechanac.Value = ds.Tables(0).Rows(i)(5).ToString()
            tbcalle.Text = ds.Tables(0).Rows(i)(6).ToString()
            tbNro.Text = ds.Tables(0).Rows(i)(7).ToString()
            IdProvincia = ds.Tables(0).Rows(i)(20).ToString()
            IdLocalidad = ds.Tables(0).Rows(i)(8).ToString()
            LlenarCMBLocalidades("unico")
            LlenarCMBProvincias("unico")

            If ds.Tables(0).Rows(i)(9).ToString() <> "NULL" Then
                tbcodcel.Text = ds.Tables(0).Rows(i)(9).ToString()
            Else
                tbcodcel.Text = ""
            End If

            If ds.Tables(0).Rows(i)(10).ToString() <> "NULL" Then
                tbcel.Text = ds.Tables(0).Rows(i)(10).ToString()
            Else
                tbcel.Text = ""
            End If

            If ds.Tables(0).Rows(i)(11).ToString() <> "NULL" Then
                tbcodtel.Text = ds.Tables(0).Rows(i)(11).ToString()
            Else
                tbcodtel.Text = ""
            End If

            If ds.Tables(0).Rows(i)(12).ToString() <> "NULL" Then
                tbtelefono.Text = ds.Tables(0).Rows(i)(12).ToString()
            Else
                tbtelefono.Text = ""
            End If

            If ds.Tables(0).Rows(i)(13).ToString() <> "NULL" Then
                tbmail.Text = ds.Tables(0).Rows(i)(13).ToString()
            Else
                tbmail.Text = ""
            End If

            If ds.Tables(0).Rows(i)(14).ToString() <> "NULL" Then
                txtPiso.Text = ds.Tables(0).Rows(i)(14).ToString()
            Else
                txtPiso.Text = ""
            End If

            If ds.Tables(0).Rows(i)(15).ToString() <> "NULL" Then
                tbDpto.Text = ds.Tables(0).Rows(i)(15).ToString()
            Else
                tbDpto.Text = ""
            End If

            If ds.Tables(0).Rows(i)(16).ToString() <> "NULL" Then
                txtManzana.Text = ds.Tables(0).Rows(i)(16).ToString()
            Else
                txtManzana.Text = ""
            End If

            If ds.Tables(0).Rows(i)(17).ToString() <> "NULL" Then
                txtLote.Text = ds.Tables(0).Rows(i)(17).ToString()
            Else
                txtLote.Text = ""
            End If

            If ds.Tables(0).Rows(i)(18).ToString() <> "NULL" Then
                txtBarrio.Text = ds.Tables(0).Rows(i)(18).ToString()
            Else
                txtBarrio.Text = ""
            End If

            ClienteID = ds.Tables(0).Rows(i)(19).ToString()

            Unblock()
            GroupBox6.Visible = True
        Next
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
            If cboTipoPersona.SelectedItem = "Física" Then
                lblRazonSoc.Visible = False
                lblNombreFanta.Visible = False
                lblInicioAct.Visible = False
                fisicaOJuridica = "F"
            Else
                lblNombre.Visible = False
                lblApellido.Visible = False
                lblFechaNac.Visible = False
                fisicaOJuridica = "J"
            End If
        Else
            MsgBox("La identificación ingresada ya existe en la base de datos", MsgBoxStyle.Critical, "Ya existente")
        End If
    End Sub

    Private Sub CboTipoPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPersona.SelectedIndexChanged
        If cboTipoPersona.SelectedItem = "Física" Then
            LlenarCMBDoc("F", "nuevo")
        Else
            LlenarCMBDoc("J", "nuevo")
        End If
        cbtipodni.Enabled = True
    End Sub

    Private Sub cboBusTipoPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBusTipoPersona.SelectedIndexChanged
        If cboBusTipoPersona.SelectedItem = "Física" Then
            LlenarCMBDoc("F", "busqueda")
        Else
            LlenarCMBDoc("J", "busqueda")
        End If
        cboBusTipoDNI.Enabled = True
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim parametros As New Dictionary(Of String, String)
        If String.IsNullOrWhiteSpace(cboBusTipoDNI.SelectedValue) = False Then
            parametros.Add("TipoDocumentoId", cboBusTipoDNI.SelectedValue)
        End If
        If String.IsNullOrWhiteSpace(txtBusDocNro.Text) = False Then
            parametros.Add("NumeroDocumento", txtBusDocNro.Text)
        End If
        If String.IsNullOrWhiteSpace(txtBusNombre.Text) = False Then
            parametros.Add("Nombre", txtBusNombre.Text)
        End If
        If String.IsNullOrWhiteSpace(txtBusApellido.Text) = False Then
            parametros.Add("Apellido", txtBusApellido.Text)
        End If
        DgvclientesSet(parametros)
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        GroupBox6.Visible = True
        btnNuevo.Enabled = False
    End Sub

#End Region

#Region "Validadores"

    'Valida datos antes de insertarlos en la BD
    Public Function ValidarDatos()

        If helpersUI.Validar_Mail(tbmail.Text) = False Then
            MsgBox("Debe ingresar correctamente el campo email", MsgBoxStyle.Critical, "Error")
            Return False
        End If


        'Agrego todos los txt y cbo a un diccionario para validarlos despues genericamente y no uno por uno
        Dim dictionaryOfMandatoriesTexts As Dictionary(Of String, String) = New Dictionary(Of String, String) From
        {{"Numero de calle", tbNro.Text}, {"Email", tbmail.Text}, {"Calle", tbcalle.Text},
        {"Localidad", cmbLocalidades.SelectedValue},
        {"Provincia", cmbProvincias.SelectedValue}}

        If fisicaOJuridica = "F" Then
            dictionaryOfMandatoriesTexts.Add("Nombre", tbNombre.Text)
            dictionaryOfMandatoriesTexts.Add("Apellido", tbApellido.Text)
        Else
            dictionaryOfMandatoriesTexts.Add("Nombre de Fantasía", tbNombre.Text)
            dictionaryOfMandatoriesTexts.Add("Razon Social", tbApellido.Text)
        End If

        For Each texts As KeyValuePair(Of String, String) In dictionaryOfMandatoriesTexts
            If helpersUI.TextValidator(texts.Key, texts.Value) = False Then
                Return False
            End If
        Next


        If String.IsNullOrWhiteSpace(tbcodcel.Text) = False And String.IsNullOrWhiteSpace(tbcel.Text) = True Then
            MsgBox("Ingrese el número de celular correspondiente", MsgBoxStyle.Critical, "Celular")
            Return False
        End If
        If String.IsNullOrWhiteSpace(tbcodcel.Text) = True And String.IsNullOrWhiteSpace(tbcel.Text) = False Then
            MsgBox("Ingrese la característica de celular correspondiente", MsgBoxStyle.Critical, "Celular")
            Return False
        End If
        If String.IsNullOrWhiteSpace(tbcodtel.Text) = False And String.IsNullOrWhiteSpace(tbtelefono.Text) = True Then
            MsgBox("Ingrese el número de teléfono correspondiente", MsgBoxStyle.Critical, "Teléfono")
            Return False
        End If
        If String.IsNullOrWhiteSpace(tbcodtel.Text) = True And String.IsNullOrWhiteSpace(tbtelefono.Text) = False Then
            MsgBox("Ingrese la característica de teléfono correspondiente", MsgBoxStyle.Critical, "Teléfono")
            Return False
        End If

        Dim value As Integer
        If Integer.TryParse(helpersLN.EnSesion, value) = True Then
            cli.UsuarioId = value
        Else
            cli.UsuarioId = Nothing
        End If
        cli.FisicaOJuridica = fisicaOJuridica
        cli.TipoDocumentoId = cbtipodni.SelectedValue
        cli.NumeroDocumento = tbNroDoc.Text
        cli.Email = tbmail.Text
        cli.Nombre = tbNombre.Text
        cli.Apellido = tbApellido.Text
        cli.FechaNacimiento = dtpfechanac.Value
        cli.CiudadId = cmbLocalidades.SelectedValue


        If String.IsNullOrEmpty(txtLote.Text) Then
            cli.Lote = "NULL"
        Else
            cli.Lote = txtLote.Text
        End If
        If String.IsNullOrEmpty(txtBarrio.Text) Then
            cli.Barrio = "NULL"
        Else
            cli.Barrio = txtBarrio.Text
        End If
        If String.IsNullOrEmpty(tbcodtel.Text) Then
            cli.Car_Telefono = "NULL"
        Else
            cli.Car_Telefono = tbcodtel.Text
        End If
        If String.IsNullOrEmpty(tbtelefono.Text) Then
            cli.NumeroTelefono = "NULL"
        Else
            cli.NumeroTelefono = tbtelefono.Text
        End If
        If String.IsNullOrEmpty(tbcodcel.Text) Then
            cli.Car_Celular = "NULL"
        Else
            cli.Car_Celular = tbcodcel.Text
        End If
        If String.IsNullOrEmpty(tbcel.Text) Then
            cli.NumeroCelular = "NULL"
        Else
            cli.NumeroCelular = tbcel.Text
        End If
        If String.IsNullOrEmpty(tbcalle.Text) Then
            cli.Calle = "NULL"
        Else
            cli.Calle = tbcalle.Text
        End If
        If String.IsNullOrEmpty(tbNro.Text) Then
            cli.NumeroCalle = "NULL"
        Else
            cli.NumeroCalle = tbNro.Text
        End If
        If String.IsNullOrEmpty(tbDpto.Text) Then
            cli.Departamento = "NULL"
        Else
            cli.Departamento = tbDpto.Text
        End If
        If String.IsNullOrEmpty(txtManzana.Text) Then
            cli.Manzana = "NULL"
        Else
            cli.Manzana = txtManzana.Text
        End If
        If String.IsNullOrEmpty(txtPiso.Text) Then
            cli.Piso = "NULL"
        Else
            cli.Piso = txtPiso.Text
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
        tbNroDoc.ReadOnly = False
        btnValidarDNI.Enabled = True
        cboBusTipoPersona.Enabled = True
        cboBusTipoDNI.Enabled = False
        btnNuevo.Enabled = True
    End Sub

    'Habilita los buttons,tb,etc necesarios
    Public Sub Unblock()
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
    Private Sub Limpiar()
        tbNombre.Text = ""
        tbApellido.Text = ""
        cbtipodni.SelectedItem = Nothing
        tbNroDoc.Text = ""
        dtpfechanac.Value.ToString("dd-MM-yyyy HH:mm:ss")
        tbmail.Text = ""
        tbcalle.Text = ""
        txtLote.Text = ""
        txtManzana.Text = ""
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
    Public Sub DgvclientesSet(ByVal parametros As Dictionary(Of String, String))
        Dim dsa1 As DataSet
        dsa1 = clientemetodo.CargaGrillaclientes(parametros) 'Si parametros esta vacio, busca todos los clientes en la bd
        dgvclientes.DataSource = dsa1.Tables(0)
    End Sub


#End Region
End Class