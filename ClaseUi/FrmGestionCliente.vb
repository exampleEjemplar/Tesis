Imports System.Drawing
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
	Private Modificando As Boolean
	Dim cadena As String

#Region "Eventos"

	Private Sub FrmGestionCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		cmbProvincias.SelectedValue = 0
		cbtipodni.SelectedValue = 0
		'cboTipoPersona.DataSource = New List(Of String) From {"Física", "Jurídica"}
		IdProvincia = LlenarCMBProvincias("general")
		'LlenarCMBLocalidades("general")
		Block()
		DgvclientesSet(New Dictionary(Of String, String))
		If Not Modificando Then
			tbmail.Text = "ejemplo@ejemplo.com"
		End If

		'tbmail.ForeColor = Color.LightGray

		AddHandler tbmail.GotFocus, AddressOf GotfocusTexto
		AddHandler tbmail.LostFocus, AddressOf LostfocusTexto


	End Sub

	Private Sub CmbProvincias_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles cmbProvincias.SelectionChangeCommitted
		IdProvincia = cmbProvincias.SelectedValue
		LlenarCMBLocalidades("general")
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

		'Los MsgBox de error ya estan dentro del metodo
		If ValidarDatos() = False Then
			Return
		End If
		'Si es un nuevo cliente lo agrega
		If Not Modificando Then
			clientemetodo.GrabarClientes(cli)
			MsgBox("Cliente agregado con exito!", MsgBoxStyle.OkOnly, "Exito")
		Else
			'Si es uno ya creado lo actualiza
			cli.Id = ClienteID
			clientemetodo.ActualizarClientes(cli)
			MsgBox("Cliente actualizado con exito!", MsgBoxStyle.OkOnly, "Exito")
		End If
		Limpiar()
		Block()
		Modificando = False
		DgvclientesSet(New Dictionary(Of String, String))

	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()
		MDIPrincipal.Show()
	End Sub

	'Private Sub Dgvcliente_DoubleClick(sender As Object, e As System.EventArgs) Handles Dgvclientes.DoubleClick
	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgvclientes.CellMouseDoubleClick
		Unblock()
		Dim selectedRow As DataGridViewRow
		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			selectedRow = Dgvclientes.Rows(e.RowIndex)
		End If
		Try
			Dim ds As DataSet = clientemetodo.ConsultaModificacion(selectedRow.Cells("id").Value)
		For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
				If ds.Tables(0).Rows(i)(0).ToString() = "F" Then
					cboTipoPersona.SelectedItem = "Física"
					cboTipoPersona.DataSource = New List(Of String) From {"Física", "Jurídica"}
					lblInicioAct.Visible = False
					lblNombreFanta.Visible = False
					lblRazonSoc.Visible = False
					dtpfechanac.MinDate = DateTime.Now.AddYears(-100)
					dtpfechanac.MaxDate = DateTime.Now.AddYears(-18)
				Else
					cboTipoPersona.SelectedItem = "Jurídica"
					lblFechaNac.Visible = False
					lblNombre.Visible = False
					lblApellido.Visible = False
					dtpfechanac.MinDate = DateTime.Now.AddYears(-100)
					dtpfechanac.MaxDate = DateTime.Now
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

				tbcodcel.Text = ds.Tables(0).Rows(i)(9).ToString()
				tbcel.Text = ds.Tables(0).Rows(i)(10).ToString()
				tbcodtel.Text = ds.Tables(0).Rows(i)(11).ToString()
				tbtelefono.Text = ds.Tables(0).Rows(i)(12).ToString()
				tbmail.Text = ds.Tables(0).Rows(i)(13).ToString()
				txtPiso.Text = ds.Tables(0).Rows(i)(14).ToString()
				tbDpto.Text = ds.Tables(0).Rows(i)(15).ToString()
				txtManzana.Text = ds.Tables(0).Rows(i)(16).ToString()
				txtLote.Text = ds.Tables(0).Rows(i)(17).ToString()
				txtBarrio.Text = ds.Tables(0).Rows(i)(18).ToString()
				ClienteID = ds.Tables(0).Rows(i)(19).ToString()
				Unblock()
				GroupBox6.Visible = True
				Modificando = True
                btnLimpiar.Enabled = False
            Next
            cbtipodni.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CboTipoPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPersona.SelectedIndexChanged
        If cboTipoPersona.SelectedItem = "Física" Then
            LlenarCMBDoc("F", "nuevo")
        Else
            LlenarCMBDoc("J", "nuevo")
            lblNombreFanta.Visible = True
            lblRazonSoc.Visible = True

        End If
        cbtipodni.Enabled = True
    End Sub

    Private Sub CboBusTipoPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBusTipoPersona.SelectedIndexChanged
        If cboBusTipoPersona.SelectedItem = "Física" Then
            LlenarCMBDoc("F", "busqueda")
        Else
            LlenarCMBDoc("J", "busqueda")
        End If
        cboBusTipoDNI.Enabled = True
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
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
        If DgvclientesSet(parametros).Tables(0).Rows.Count = 0 Then
            MsgBox("La búsqueda no arrojo resultados", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        GroupBox6.Visible = True
        btnNuevo.Enabled = False
        cboTipoPersona.DataSource = New List(Of String) From {"Física", "Jurídica"}
    End Sub

#End Region

#Region "Validadores"

    'Valida datos antes de insertarlos en la BD
    Public Function ValidarDatos()

        'Seccion modificada a partir de pedido de la profe, la dejo comentada a proposito. 6/6/2019

        ''Agrego todos los txt y cbo a un diccionario para validarlos despues genericamente y no uno por uno
        'Dim dictionaryOfMandatoriesTexts As Dictionary(Of String, String) = New Dictionary(Of String, String) From
        '{{"Numero de calle", tbNro.Text}, {"Email", tbmail.Text}, {"Calle", tbcalle.Text},
        '{"Localidad", cmbLocalidades.SelectedValue},
        '{"Provincia", cmbProvincias.SelectedValue}}

        'If fisicaOJuridica = "F" Then
        '	dictionaryOfMandatoriesTexts.Add("Nombre", tbNombre.Text)
        '	dictionaryOfMandatoriesTexts.Add("Apellido", tbApellido.Text)
        'Else
        '	dictionaryOfMandatoriesTexts.Add("Nombre de Fantasía", tbNombre.Text)
        '	dictionaryOfMandatoriesTexts.Add("Razon Social", tbApellido.Text)
        'End If

        'For Each texts As KeyValuePair(Of String, String) In dictionaryOfMandatoriesTexts
        '	If helpersUI.TextValidator(texts.Key, texts.Value) = False Then
        '		Return False
        '	End If
        'Next

        'Dim listOfMandatoriesInteger As List(Of Tuple(Of String, Integer, Integer, String)) = New List(Of Tuple(Of String, Integer, Integer, String)) From
        '	  {New Tuple(Of String, Integer, Integer, String)(tbNombre.Text, 3, 0, "Nombre"),
        '	  New Tuple(Of String, Integer, Integer, String)(tbApellido.Text, 2, 0, "Apellido"),
        '	  New Tuple(Of String, Integer, Integer, String)(tbcalle.Text, 5, 0, "Calle"),
        '	  New Tuple(Of String, Integer, Integer, String)(tbcodcel.Text, 2, 0, "Característica celular"),
        '	  New Tuple(Of String, Integer, Integer, String)(tbcel.Text, 6, 0, "Número celular")}

        'For Each items As Tuple(Of String, Integer, Integer, String) In listOfMandatoriesInteger
        '	If helpersUI.ValidarTamaño(items.Item1, items.Item2, items.Item3) = False Then
        '		MsgBox("El campo " + items.Item4 + " no puede ser menor a " + items.Item2.ToString() + " caracteres", MsgBoxStyle.Critical, "Cantidad de caracteres")
        '		Return False
        '	End If
        'Next

        'If String.IsNullOrWhiteSpace(tbcodcel.Text) = False And String.IsNullOrWhiteSpace(tbcel.Text) = True Then
        '	MsgBox("Ingrese el número de celular correspondiente", MsgBoxStyle.Critical, "Celular")
        '	Return False
        'End If
        'If String.IsNullOrWhiteSpace(tbcodcel.Text) = True And String.IsNullOrWhiteSpace(tbcel.Text) = False Then
        '	MsgBox("Ingrese la característica de celular correspondiente", MsgBoxStyle.Critical, "Celular")
        '	Return False
        'End If
        'If String.IsNullOrWhiteSpace(tbcodtel.Text) = False And String.IsNullOrWhiteSpace(tbtelefono.Text) = True Then
        '	MsgBox("Ingrese el número de teléfono correspondiente", MsgBoxStyle.Critical, "Teléfono")
        '	Return False
        'End If
        'If String.IsNullOrWhiteSpace(tbcodtel.Text) = True And String.IsNullOrWhiteSpace(tbtelefono.Text) = False Then
        '	MsgBox("Ingrese la característica de teléfono correspondiente", MsgBoxStyle.Critical, "Teléfono")
        '	Return False
        'End If

        'Dim value As Integer
        'If Integer.TryParse(helpersLN.EnSesion, value) = True Then
        '	cli.UsuarioId = value
        'Else
        '	cli.UsuarioId = Nothing
        'End If
        'cli.FisicaOJuridica = fisicaOJuridica
        'cli.TipoDocumentoId = cbtipodni.SelectedValue
        'cli.NumeroDocumento = tbNroDoc.Text
        'cli.Email = tbmail.Text
        'cli.Nombre = tbNombre.Text
        'cli.Apellido = tbApellido.Text
        'cli.FechaNacimiento = dtpfechanac.Value
        'cli.CiudadId = cmbLocalidades.SelectedValue
        'cli.Car_Celular = tbcodcel.Text
        'cli.NumeroCelular = tbcel.Text

        'If String.IsNullOrEmpty(txtLote.Text) Then
        '	cli.Lote = ""
        'Else
        '	cli.Lote = txtLote.Text
        'End If
        'If String.IsNullOrEmpty(txtBarrio.Text) Then
        '	cli.Barrio = ""
        'Else
        '	cli.Barrio = txtBarrio.Text
        'End If
        'If String.IsNullOrEmpty(tbcodtel.Text) Then
        '	cli.Car_Telefono = ""
        'Else
        '	cli.Car_Telefono = tbcodtel.Text
        'End If
        'If String.IsNullOrEmpty(tbtelefono.Text) Then
        '	cli.NumeroTelefono = ""
        'Else
        '	cli.NumeroTelefono = tbtelefono.Text
        'End If

        'If String.IsNullOrEmpty(tbcalle.Text) Then
        '	cli.Calle = ""
        'Else
        '	cli.Calle = tbcalle.Text
        'End If
        'If String.IsNullOrEmpty(tbNro.Text) Then
        '	cli.NumeroCalle = ""
        'Else
        '	cli.NumeroCalle = tbNro.Text
        'End If
        'If String.IsNullOrEmpty(tbDpto.Text) Then
        '	cli.Departamento = ""
        'Else
        '	cli.Departamento = tbDpto.Text
        'End If
        'If String.IsNullOrEmpty(txtManzana.Text) Then
        '	cli.Manzana = ""
        'Else
        '	cli.Manzana = txtManzana.Text
        'End If
        'If String.IsNullOrEmpty(txtPiso.Text) Then
        '	cli.Piso = ""
        'Else
        '	cli.Piso = txtPiso.Text
        'End If
        'Return True

        'Seccion modificada a partir de pedido de la profe 6/6/2019

        Dim value As Integer
        If Integer.TryParse(helpersLN.EnSesion, value) = True Then
            cli.UsuarioId = value
        Else
            cli.UsuarioId = Nothing
        End If

        cli.FisicaOJuridica = fisicaOJuridica
        cli.TipoDocumentoId = cbtipodni.SelectedValue
        cli.NumeroDocumento = tbNroDoc.Text

        If Not String.IsNullOrEmpty(tbmail.Text) Then
            If helpersUI.IsEmail(tbmail.Text) = False Then
                MsgBox("Debe ingresar correctamente el campo email", MsgBoxStyle.Critical, "Error")
                Return False
            End If
            cli.Email = tbmail.Text
        Else
            cli.Email = ""
        End If

        If Not String.IsNullOrEmpty(tbcalle.Text) Then
            If Not helpersUI.HasStrangerCaracters(tbcalle.Text) Then
                MsgBox("Caracter invalido en el campo calle", MsgBoxStyle.Critical, "Error")
                Return False
            End If
            cli.Calle = tbcalle.Text
        Else
            cli.Calle = ""
        End If

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

        If String.IsNullOrEmpty(cmbLocalidades.SelectedValue) Then
            cli.CiudadId = ""
        Else
            cli.CiudadId = cmbLocalidades.SelectedValue
        End If
        If String.IsNullOrEmpty(dtpfechanac.Value.ToString()) Then
            cli.FechaNacimiento = ""
        Else
            cli.FechaNacimiento = dtpfechanac.Value
        End If
        If String.IsNullOrEmpty(tbApellido.Text) Then
            cli.Apellido = ""
        Else
            cli.Apellido = tbApellido.Text
        End If
        If String.IsNullOrEmpty(tbNombre.Text) Then
            cli.Nombre = ""
        Else
            cli.Nombre = tbNombre.Text
        End If
        If String.IsNullOrEmpty(txtLote.Text) Then
            cli.Lote = ""
        Else
            cli.Lote = txtLote.Text
        End If
        If String.IsNullOrEmpty(txtBarrio.Text) Then
            cli.Barrio = ""
        Else
            cli.Barrio = txtBarrio.Text
        End If
        If String.IsNullOrEmpty(tbcodtel.Text) Then
            cli.Car_Telefono = ""
        Else
            cli.Car_Telefono = tbcodtel.Text
        End If
        If String.IsNullOrEmpty(tbtelefono.Text) Then
            cli.NumeroTelefono = ""
        Else
            cli.NumeroTelefono = tbtelefono.Text
        End If
        If String.IsNullOrEmpty(tbcodcel.Text) Then
            cli.Car_Celular = ""
        Else
            cli.Car_Celular = tbcodcel.Text
        End If
        If String.IsNullOrEmpty(tbcel.Text) Then
            cli.NumeroCelular = ""
        Else
            cli.NumeroCelular = tbcel.Text
        End If
        If String.IsNullOrEmpty(tbNro.Text) Then
            cli.NumeroCalle = ""
        Else
            cli.NumeroCalle = tbNro.Text
        End If
        If String.IsNullOrEmpty(tbDpto.Text) Then
            cli.Departamento = ""
        Else
            cli.Departamento = tbDpto.Text
        End If
        If String.IsNullOrEmpty(txtManzana.Text) Then
            cli.Manzana = ""
        Else
            cli.Manzana = txtManzana.Text
        End If
        If String.IsNullOrEmpty(txtPiso.Text) Then
            cli.Piso = ""
        Else
            cli.Piso = txtPiso.Text
        End If
        Return True

    End Function

    'Valida que el texto sea solo numeros
    Private Sub TxbTelNumero_KeyPress(sender As System.Object, e As KeyPressEventArgs) Handles txtPiso.KeyPress, txtManzana.KeyPress, txtLote.KeyPress, tbNroDoc.KeyPress, tbNro.KeyPress, tbcodtel.KeyPress, tbcodcel.KeyPress, tbcel.KeyPress, tbtelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.Handled = True Then
            MsgBox("Caracter invalido", MsgBoxStyle.Critical, "Caracter invalido")
        End If
    End Sub

    'Valida que el texto sea solo letras
    Private Sub TbNombre_KeyPress(sender As System.Object, e As KeyPressEventArgs) Handles tbNombre.KeyPress, tbApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.Handled = True Then
            MsgBox("Caracter invalido", MsgBoxStyle.Critical, "Caracter invalido")
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
        'cbtipodni.Enabled = False
        tbNroDoc.ReadOnly = False
        btnValidarDNI1.Enabled = True
        cboBusTipoPersona.Enabled = True
        cboBusTipoDNI.Enabled = False
        btnNuevo.Enabled = True
        btnLimpiar.Enabled = False
    End Sub

    'Habilita los buttons,tb,etc necesarios
    Public Sub Unblock()
        btnNuevo.Enabled = False
        GroupBox4.Visible = True
        GroupBox2.Visible = True
        GroupBox3.Visible = True
        btnGuardar.Enabled = True
        cboTipoPersona.Enabled = False
        'cbtipodni.Enabled = False
        tbNroDoc.ReadOnly = True
        btnValidarDNI1.Enabled = False
        btnLimpiar.Enabled = True
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

    'Private Sub deshabilitar()
    '	tbNombre.Enabled = False
    '	tbApellido.Enabled = False
    '	cbtipodni.SelectedItem = False
    '	tbNroDoc.Enabled = False
    '	dtpfechanac.Enabled = False
    '	tbmail.Enabled = False
    '	tbcalle.Enabled = False
    '	txtLote.Enabled = False
    '	txtManzana.Enabled = False
    '	tbNro.Enabled = False
    '	tbtelefono.Enabled = False
    '	tbcodtel.Enabled = False
    '	tbcel.Enabled = False
    '	tbcodtel.Enabled = False
    '	txtPiso.Enabled = False
    '	tbDpto.Enabled = False
    '	txtBarrio.Enabled = False
    '	cmbProvincias.SelectedItem = False
    '	cmbLocalidades.SelectedItem = False
    '	tbcodcel.Enabled = False

    'End Sub

    'Private Sub habilitar()
    '	tbNombre.Enabled = True
    '	tbApellido.Enabled = True
    '	cbtipodni.SelectedItem = True
    '	tbNroDoc.Enabled = True
    '	dtpfechanac.Value.ToString("dd-MM-yyyy HH:mm:ss")
    '	tbmail.Enabled = True
    '	tbcalle.Enabled = True
    '	txtLote.Enabled = True
    '	txtManzana.Enabled = True
    '	tbNro.Enabled = True
    '	tbtelefono.Enabled = True
    '	tbcodtel.Enabled = True
    '	tbcel.Enabled = True
    '	tbcodtel.Enabled = True
    '	txtPiso.Enabled = True
    '	tbDpto.Enabled = True
    '	txtBarrio.Enabled = True
    '	cmbProvincias.SelectedItem = True
    '	cmbLocalidades.SelectedItem = True
    '	tbcodcel.Enabled = True
    '	dtpfechanac.Enabled = True
    'End Sub
#End Region

#Region "Rellenado"

    Public Function LlenarCMBProvincias(ByVal type As String)
        Try
            Dim ds1 As DataSet
            ds1 = helpersLN.CargarCMBProvincias()
            cmbProvincias.DataSource = ds1.Tables(0)
            cmbProvincias.DisplayMember = "nombre"
            cmbProvincias.ValueMember = "id"
            cmbProvincias.SelectedValue = 0

            If type = "unico" Then
                cmbProvincias.SelectionStart = IdProvincia
                cmbProvincias.SelectedValue = IdProvincia
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return cmbProvincias.SelectedValue
        MessageBox.Show(cmbProvincias.SelectedValue)
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
    Public Function DgvclientesSet(ByVal parametros As Dictionary(Of String, String)) As DataSet
        Dim dsa1 As DataSet
        dsa1 = clientemetodo.CargaGrillaclientes(parametros) 'Si parametros esta vacio, busca todos los clientes en la bd
        If dsa1.Tables(0).Rows.Count() <> 0 Then
            ClienteID = dsa1.Tables(0).Rows(0)(13)
        End If
        Dgvclientes.DataSource = dsa1.Tables(0)
        Dgvclientes.Columns("Id").Visible = False
        Dgvclientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dgvclientes.AutoResizeColumns()
        Return dsa1
    End Function

    Private Sub btnValidarDNI1_Click(sender As Object, e As EventArgs) Handles btnValidarDNI1.Click

        If helpersUI.TextValidator("Tipo de persona", cboTipoPersona.SelectedItem) = False Or
helpersUI.TextValidator("Tipo de identificacion", cbtipodni.Text) = False Or
helpersUI.TextValidator("Numero de identificacion", tbNroDoc.Text) = False Then
            Return
        End If
        Select Case cbtipodni.SelectedValue
            Case 1 To 3
                If tbNroDoc.Text.Length > 9 Or tbNroDoc.Text.Length < 8 Then
                    MsgBox("El tamaño del campo número de identificación no tiene la cantidad de caracteres correctos", MsgBoxStyle.Critical, "Cantidad de caracteres")
                    Return
                End If
            Case 4 To 5
                If tbNroDoc.Text.Length < 11 Or tbNroDoc.Text.Length > 12 Then
                    MsgBox("El tamaño del campo número de identificación no tiene la cantidad de caracteres correctos", MsgBoxStyle.Critical, "Cantidad de caracteres")
                    Return
                End If
            Case Else
                Return
        End Select
        If helpersLN.ValidarSiExisteDni(Convert.ToInt64(tbNroDoc.Text), "Clientes") = False Then

            Unblock()
            cbtipodni.Enabled = False
            If cboTipoPersona.SelectedItem = "Física" Then
                lblRazonSoc.Visible = False
                lblNombreFanta.Visible = False
                lblInicioAct.Visible = False
                fisicaOJuridica = "F"
                dtpfechanac.MinDate = DateTime.Now.AddYears(-100)
                dtpfechanac.MaxDate = DateTime.Now.AddYears(-18)
            Else
                lblNombre.Visible = False
                lblApellido.Visible = False
                lblFechaNac.Visible = False
                fisicaOJuridica = "J"
                dtpfechanac.MinDate = DateTime.Now.AddYears(-100)
                dtpfechanac.MaxDate = DateTime.Now
            End If
        Else
            MsgBox("La identificación ingresada ya existe en la base de datos", MsgBoxStyle.Critical, "Ya existente")
        End If

    End Sub

    Private Sub GotfocusTexto(ByVal sender As Object, ByVal e As System.EventArgs)
        If Modificando Then
            Return
        End If
        'capturamos el texto que tenia
        cadena = sender.Text
        'borramos el texto del textbox
        sender.Text = ""
        'ponemos el color de la letra en negro
        sender.ForeColor = Color.Black
    End Sub

    Private Sub LostfocusTexto(ByVal sender As Object, ByVal e As System.EventArgs)
        If Modificando Then
            Return
        End If
        If sender.Text = "" Then 'si salio del textbox sin poner nada
            sender.Text = cadena  'volverle a poner el texto que tenia
            sender.ForeColor = Color.Black 'y poner la letra en gris
        End If

    End Sub

    'Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
    '	Limpiar()

    '	Block()

    'End Sub

    'Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
    '	habilitar()

    'End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub cbtipodni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtipodni.SelectedIndexChanged
        tbNroDoc.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmListadoClientes.Show()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim resp = MsgBox("Está seguro que desea limpiar los campos?", MsgBoxStyle.YesNo, "Limpiar")
        If resp = MsgBoxResult.No Then
            Return
        End If
        Limpiar()
        Block()
    End Sub



#End Region




End Class