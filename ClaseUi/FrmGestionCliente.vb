Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe


Public Class FrmGestionCliente

    Private clientemetodo As New ClientesLN
    Private cli As New ClientesNE
    Private helpersLN As New HelpersLN
    Private helpersUI As New HelpersUI
    Public IdProvincia As Integer
    Private fisicaOJuridica As String


    Private Sub FrmGestionCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        helpersUI.TextValidator("a", "a")
        cmbProvincias.SelectedValue = 0
        cbtipodni.SelectedValue = 0
        IdProvincia = LlenarCMBProvincias()
        LlenarCMBLocalidades()
        dtpfechanac.MinDate = Date.Today.AddYears(-18)
        Block()
        DgvclientesSet(New Dictionary(Of String, String))

    End Sub

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

    Public Sub DgvclientesSet(ByVal parametros As Dictionary(Of String, String))
        Dim dsa1 As DataSet
        dsa1 = clientemetodo.CargaGrillaclientes(parametros)
        dgvclientes.DataSource = dsa1.Tables(0)
    End Sub

    Public Function LlenarCMBProvincias()
        Try
            Dim ds1 As DataSet
            ds1 = helpersLN.CargarCMBProvincias()
            cmbProvincias.DataSource = ds1.Tables(0)
            cmbProvincias.DisplayMember = "nombre"
            cmbProvincias.ValueMember = "id"
            cmbProvincias.SelectedValue = 1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return cmbProvincias.SelectedValue
    End Function

    Public Sub LlenarCMBLocalidades()
        Try
            Dim ds1 As DataSet
            ds1 = helpersLN.CargarCMBLocalidades(IdProvincia)
            cmbLocalidades.DataSource = ds1.Tables(0)
            cmbLocalidades.DisplayMember = "nombre"
            cmbLocalidades.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

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

    Private Sub CmbProvincias_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbProvincias.SelectionChangeCommitted
        IdProvincia = cmbProvincias.SelectedValue
        LlenarCMBLocalidades()
    End Sub

    Public Function ValidarDatos()

        If helpersUI.Validar_Mail(tbmail.Text) = False Then
            MsgBox("Debe ingresar correctamente el campo email", MsgBoxStyle.Critical, "Error")
            Return False
        End If


        'Agrego todos los txt y cbo a un diccionario para validarlos despues genericamente y no uno por uno
        Dim dictionaryOfTexts As Dictionary(Of String, String) = New Dictionary(Of String, String) From
        {{"Numero de calle", tbNro.Text}, {"Email", tbmail.Text}, {"Calle", tbcalle.Text},
        {"Localidad", cmbLocalidades.SelectedValue},
        {"Provincia", cmbProvincias.SelectedValue}}

        If fisicaOJuridica = "F" Then
            dictionaryOfTexts.Add("Nombre", tbNombre.Text)
            dictionaryOfTexts.Add("Apellido", tbApellido.Text)
        Else
            dictionaryOfTexts.Add("Nombre de Fantasía", tbNombre.Text)
            dictionaryOfTexts.Add("Razon Social", tbApellido.Text)
        End If

        For Each texts As KeyValuePair(Of String, String) In dictionaryOfTexts
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

        cli.FisicaOJuridica = fisicaOJuridica
        cli.TipoDocumentoId = cbtipodni.SelectedValue
        cli.NumeroDocumento = Convert.ToInt32(tbNroDoc.Text)
        cli.Email = tbmail.Text
        cli.Nombre = tbNombre.Text
        cli.Apellido = tbApellido.Text
        cli.FechaNacimiento = dtpfechanac.Value
        cli.Calle = tbcalle.Text
        cli.NumeroCalle = Convert.ToInt32(tbNro.Text)
        Dim value As Integer
        If Integer.TryParse(txtPiso.Text, value) = True Then
            cli.Piso = value
        Else
            cli.Piso = Nothing
        End If
        cli.Departamento = tbDpto.Text
        If Integer.TryParse(txtManzana.Text, value) = True Then
            cli.Manzana = value
        Else
            cli.Manzana = Nothing
        End If
        cli.CiudadId = cmbLocalidades.SelectedValue
        If Integer.TryParse(txtLote.Text, value) = True Then
            cli.Lote = value
        Else
            cli.Lote = Nothing
        End If
        cli.Barrio = txtBarrio.Text
        If Integer.TryParse(tbcodtel.Text, value) = True Then
            cli.Car_Telefono = value
        Else
            cli.Car_Telefono = Nothing
        End If
        If Integer.TryParse(tbtelefono.Text, value) = True Then
            cli.NumeroTelefono = value
        Else
            cli.NumeroTelefono = Nothing
        End If
        If Integer.TryParse(tbcodcel.Text, value) = True Then
            cli.Car_Celular = value
        Else
            cli.Car_Celular = Nothing
        End If
        If Integer.TryParse(tbcel.Text, value) = True Then
            cli.NumeroCelular = value
        Else
            cli.NumeroCelular = Nothing
        End If
        If Integer.TryParse(helpersLN.EnSesion, value) = True Then
            cli.UsuarioId = value
        Else
            cli.UsuarioId = Nothing
        End If
        Return True
    End Function

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidarDatos() = False Then
            Return
        End If
        clientemetodo.GrabarClientes(cli)
        MsgBox("Cliente agregado con exito!", MsgBoxStyle.OkOnly, "Exito")
        'DgvclientesSet()
        Limpiar()
        Block()
        DgvclientesSet(New Dictionary(Of String, String))

    End Sub

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        MDIPrincipal.Show()
    End Sub

    Private Sub Dgvcliente_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvclientes.DoubleClick

        Dim ds As DataSet = clientemetodo.ConsultaModificacion((dgvclientes.Item(2, dgvclientes.CurrentRow.Index).Value))
        'idcliente = (dgvclientes.Item(0, dgvclientes.CurrentRow.Index).Value)
        cboTipoPersona.SelectedItem = (dgvclientes.Item(0, dgvclientes.CurrentRow.Index).Value)
        cbtipodni.SelectedValue = (dgvclientes.Item(1, dgvclientes.CurrentRow.Index).Value)
        tbNroDoc.Text = (dgvclientes.Item(2, dgvclientes.CurrentRow.Index).Value)
        tbNombre.Text = (dgvclientes.Item(3, dgvclientes.CurrentRow.Index).Value)
        tbApellido.Text = (dgvclientes.Item(4, dgvclientes.CurrentRow.Index).Value)
        dtpfechanac.Value = (dgvclientes.Item(5, dgvclientes.CurrentRow.Index).Value)
        tbcalle.Text = (dgvclientes.Item(7, dgvclientes.CurrentRow.Index).Value)
        tbNro.Text = (dgvclientes.Item(8, dgvclientes.CurrentRow.Index).Value)
        tbDpto.Text = (dgvclientes.Item(9, dgvclientes.CurrentRow.Index).Value)
        cmbLocalidades.SelectedValue = (dgvclientes.Item(10, dgvclientes.CurrentRow.Index).Value)
        cmbProvincias.SelectedValue = (dgvclientes.Item(1, dgvclientes.CurrentRow.Index).Value)
        IdProvincia = Convert.ToString((dgvclientes.Item(10, dgvclientes.CurrentRow.Index).Value))
        LlenarCMBLocalidades()
        tbcodtel.Text = (dgvclientes.Item(14, dgvclientes.CurrentRow.Index).Value)
        tbtelefono.Text = (dgvclientes.Item(12, dgvclientes.CurrentRow.Index).Value)
        tbcel.Text = (dgvclientes.Item(11, dgvclientes.CurrentRow.Index).Value)
        tbcodcel.Text = (dgvclientes.Item(13, dgvclientes.CurrentRow.Index).Value)
        tbmail.Text = (dgvclientes.Item(16, dgvclientes.CurrentRow.Index).Value)

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
End Class