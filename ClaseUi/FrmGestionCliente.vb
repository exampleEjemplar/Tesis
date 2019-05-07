Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe


Public Class FrmGestionCliente

    Private clientemetodo As New ClientesLN
    Private cli As New ClientesNE
    Private helpersLN As New HelpersLN
    Private helpersUI As New HelpersUI
    Private busqdni As String
    Private busqape As String
    Public usuarioid As Integer
    Public IdProvincia As Integer
    Private fisicaOJuridica As Char

    Private Sub FrmGestionCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbProvincias.SelectedValue = 0
        cbtipodni.SelectedValue = 0
        IdProvincia = LlenarCMBProvincias()
        LlenarCMBLocalidades()
        dtpfechanac.MinDate = Date.Today.AddYears(-18)
        Block()
        'TODO : Descomentar cuando se busque
        'DgvclientesSet()

    End Sub

    Public Sub Block()
        GroupBox4.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnNuevo.Enabled = False
        cboTipoPersona.Enabled = True
        cbtipodni.Enabled = True
        tbNroDoc.ReadOnly = False
        btnValidarDNI.Enabled = True
    End Sub

    Public Sub Unblock()
        GroupBox4.Visible = True
        GroupBox2.Visible = True
        GroupBox3.Visible = True
        btnGuardar.Enabled = True
        btnModificar.Enabled = True
        cboTipoPersona.Enabled = False
        cbtipodni.Enabled = False
        tbNroDoc.ReadOnly = True
        btnValidarDNI.Enabled = False
    End Sub

    Public Sub DgvclientesSet()
        Dim dsa1 As DataSet
        dsa1 = clientemetodo.CargaGrillaclientes(busqdni, busqape)
        dgvclientes.DataSource = dsa1.Tables(0)
        dgvclientes.Columns(0).Visible = False
        dgvclientes.Columns(1).Visible = False
        dgvclientes.Columns(5).Visible = False
        dgvclientes.Columns(6).Visible = False
        dgvclientes.Columns(7).Visible = False
        dgvclientes.Columns(8).Visible = False
        dgvclientes.Columns(9).Visible = False
        dgvclientes.Columns(10).Visible = False
        dgvclientes.Columns(11).Visible = False
        dgvclientes.Columns(12).Visible = False
        dgvclientes.Columns(13).Visible = False
        dgvclientes.Columns(14).Visible = False
        dgvclientes.Columns(15).Visible = False
        ' dgvclientes.Columns(16).Visible = False
        ' dgvclientes.Columns(17).Visible = False
        dgvclientes.Columns(2).HeaderText = "Nro. Doc."
        dgvclientes.Columns(4).HeaderText = "Apellido"
        dgvclientes.Columns(3).HeaderText = "Nombre"
        dgvclientes.Columns(3).HeaderText = "Nombre"
        dgvclientes.Columns(16).HeaderText = "E-Mail"
        dgvclientes.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvclientes.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvclientes.Columns(16).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvclientes.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvclientes.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvclientes.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvclientes.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvclientes.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvclientes.Sort(dgvclientes.Columns(4), System.ComponentModel.ListSortDirection.Ascending)

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

    Public Sub LlenarCMBDoc(ByVal FoJ As Char)
        Try
            Dim ds1 As DataSet
            ds1 = helpersLN.CargarCMBDoc(FoJ)
            cbtipodni.DataSource = ds1.Tables(0)
            cbtipodni.DisplayMember = "descripcion"
            cbtipodni.ValueMember = "id"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

        cli = New ClientesNE With {
            .FisicaOJuridica = fisicaOJuridica,
            .TipoDocumentoId = cbtipodni.SelectedValue,
            .NumeroDocumento = tbNroDoc.Text,
            .Email = tbmail.Text,
            .Nombre = tbNombre.Text,
            .Apellido = tbApellido.Text,
            .FechaNacimiento = dtpfechanac.Value,
            .UsuarioId = usuarioid,
            .Calle = tbcalle.Text,
            .NumeroCalle = tbNro.Text,
            .Piso = txtPiso.Text,
            .Departamento = tbDpto.Text,
            .Manzana = txtManzana.Text,
            .CiudadId = cmbLocalidades.SelectedValue,
            .Lote = txtLote.Text,
            .Barrio = txtBarrio.Text,
            .Car_Telefono = tbcodtel.Text,
            .NumeroTelefono = tbtelefono.Text,
            .Car_Celular = tbcodcel.Text,
            .NumeroCelular = tbcel.Text
        }
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

    'Private Sub txbBusquedaNombre_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txbBusquedaNombre.KeyPress
    '    If Char.IsLetter(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If ValidarDatos() = False Then
            Return
        End If
        clientemetodo.GrabarClientes(cli)
        MsgBox("Cliente agregado con exito!", MsgBoxStyle.OkOnly, "Exito")
        DgvclientesSet()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        MDIPrincipal.Show()
    End Sub

    Private Sub Dgvcliente_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvclientes.DoubleClick

        'idcliente = (dgvclientes.Item(0, dgvclientes.CurrentRow.Index).Value)
        cbtipodni.SelectedValue = (dgvclientes.Item(1, dgvclientes.CurrentRow.Index).Value)
        tbNroDoc.Text = (dgvclientes.Item(2, dgvclientes.CurrentRow.Index).Value)
        dtpfechanac.Value = (dgvclientes.Item(5, dgvclientes.CurrentRow.Index).Value)
        tbNombre.Text = (dgvclientes.Item(3, dgvclientes.CurrentRow.Index).Value)
        tbApellido.Text = (dgvclientes.Item(4, dgvclientes.CurrentRow.Index).Value)
        tbcalle.Text = (dgvclientes.Item(7, dgvclientes.CurrentRow.Index).Value)
        tbNro.Text = (dgvclientes.Item(8, dgvclientes.CurrentRow.Index).Value)
        tbDpto.Text = (dgvclientes.Item(9, dgvclientes.CurrentRow.Index).Value)
        ' cmbLocalidades.SelectedValue = (dgvclientes.Item(10, dgvclientes.CurrentRow.Index).Value)
        'cmbProvincias.SelectedValue = (dgvclientes.Item(1, dgvclientes.CurrentRow.Index).Value)
        IdProvincia = Convert.ToString((dgvclientes.Item(10, dgvclientes.CurrentRow.Index).Value))
        'helpersLN.idprov = IdProvincia 'TODO Aca esto se puede evitar pasando como parametro el int directamente 
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
        If cboTipoPersona.SelectedText = "Física" Then
            LlenarCMBDoc("F")
        Else
            LlenarCMBDoc("J")
        End If
    End Sub
End Class