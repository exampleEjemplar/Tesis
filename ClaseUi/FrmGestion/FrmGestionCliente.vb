﻿Imports System.Drawing
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
	Public modificado As Boolean = False
	Public primerOrder As Boolean = True
	Public OrderBy As New List(Of Tuple(Of Integer, String, Integer)) 'Index, nombrevista, nombre base, prioridad


#Region "Eventos"

	Private Sub FrmGestionCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		LlenarCboOrden()
		InicializarOrderBy()
		cmbProvincias.SelectedValue = 0
		cbtipodni.SelectedValue = 0
		IdProvincia = LlenarCMBProvincias("general")
		Block()
		DgvclientesSet(New Dictionary(Of String, String))
		If Not Modificando Then
			tbmail.Text = "ejemplo@ejemplo.com"
		End If

		AddHandler tbmail.GotFocus, AddressOf GotfocusTexto
		AddHandler tbmail.LostFocus, AddressOf LostfocusTexto
		modificado = False


	End Sub

	Public Sub LlenarCboOrden()
		cboOrden.DataSource = {"asc", "desc"}
		cboOrden.SelectedItem = "desc"
	End Sub

	Public Sub InicializarOrderBy()
		chbListaParaOrdenar.Items.Clear()
		OrderBy = New List(Of Tuple(Of Integer, String, Integer))
		OrderBy.Add(New Tuple(Of Integer, String, Integer)(1, "'Fecha de Alta'", 1))
		OrderBy.Add(New Tuple(Of Integer, String, Integer)(2, "", 2))
		OrderBy.Add(New Tuple(Of Integer, String, Integer)(3, "", 3))
		lblPrioridad1.Text = OrderBy.FirstOrDefault(Function(x) x.Item1 = 1).Item2.Replace("'", "")
		lblPrioridad2.Visible = False
		lblPrioridad3.Visible = False
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
		modificado = True
		Modificando = False
		DgvclientesSet(New Dictionary(Of String, String))

	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		primerOrder = True
		Me.Close()
	End Sub

	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgvclientes.CellMouseDoubleClick
		Unblock()
		Dim selectedRow As DataGridViewRow = Nothing
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
					lblNombre.Visible = True
					lblApellido.Visible = True
					lblFechaNac.Visible = True
					dtpfechanac.MinDate = DateTime.Now.AddYears(-100)
					dtpfechanac.MaxDate = DateTime.Now.AddYears(-18)
				Else
					cboTipoPersona.SelectedItem = "Jurídica"
					lblFechaNac.Visible = False
					lblNombre.Visible = False
					lblApellido.Visible = False
					lblInicioAct.Visible = True
					lblNombreFanta.Visible = True
					lblRazonSoc.Visible = True
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

	Private Sub CboTipoPersona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPersona.SelectedIndexChanged
		If cboTipoPersona.SelectedItem = "Física" Then
			LlenarCMBDoc("F", "nuevo")
			cbtipodni.Enabled = True
		Else
			LlenarCMBDoc("J", "nuevo")
			lblNombreFanta.Visible = True
			lblRazonSoc.Visible = True
			cbtipodni.Enabled = True

		End If

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
			cli.Calle = helpersUI.NormalizarTexto(tbcalle.Text)
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
			MsgBox("Debe Cargar una Localidad", MsgBoxStyle.Critical, "Error")
			Return False
		Else
			cli.CiudadId = cmbLocalidades.SelectedValue
		End If
		If String.IsNullOrEmpty(dtpfechanac.Value.ToString()) Then
			cli.FechaNacimiento = ""
		Else
			cli.FechaNacimiento = dtpfechanac.Value
		End If
		If String.IsNullOrEmpty(tbApellido.Text) Then
			MsgBox("Debe Cargar un Apellido/Razon Social", MsgBoxStyle.Critical, "Error")
			Return False
		Else
			cli.Apellido = helpersUI.NormalizarTexto(tbApellido.Text)
		End If
		If String.IsNullOrEmpty(tbNombre.Text) Then
			MsgBox("Debe Cargar un Nombre/Nombre Fantasía", MsgBoxStyle.Critical, "Error")
			Return False
		Else
			cli.Nombre = helpersUI.NormalizarTexto(tbNombre.Text)
		End If
		If String.IsNullOrEmpty(txtLote.Text) Then
			cli.Lote = ""
		Else
			cli.Lote = helpersUI.NormalizarTexto(txtLote.Text)
		End If
		If String.IsNullOrEmpty(txtBarrio.Text) Then
			cli.Barrio = ""
		Else
			cli.Barrio = helpersUI.NormalizarTexto(txtBarrio.Text)
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
		tbmail.Text = "ejemplo@ejemplo.com"
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
		dsa1 = clientemetodo.CargaGrillaclientes(parametros, OrderBy, cboOrden.SelectedItem) 'Si parametros esta vacio, busca todos los clientes en la bd
		If dsa1.Tables(0).Rows.Count() <> 0 Then
			ClienteID = dsa1.Tables(0).Rows(0)(13)
		End If
		If primerOrder Then
			primerOrder = False
			For i = 0 To dsa1.Tables(0).Columns.Count - 1
				If dsa1.Tables(0).Columns(i).ColumnName = "id" Then
					Continue For
				End If
				If dsa1.Tables(0).Columns(i).ColumnName = "Fecha de Alta" Then
					chbListaParaOrdenar.Items.Add(dsa1.Tables(0).Columns(i).ColumnName, CheckState.Checked)
					Continue For
				End If
				chbListaParaOrdenar.Items.Add(dsa1.Tables(0).Columns(i).ColumnName)
			Next
			chbListaParaOrdenar.SetItemChecked(6, True)
		End If
		Dgvclientes.DataSource = dsa1.Tables(0)
        Dgvclientes.Columns("Id").Visible = False
        Dgvclientes.Columns(5).DefaultCellStyle.Format = "dd/MM/yyyy"
        Dgvclientes.Columns(6).DefaultCellStyle.Format = "dd/MM/yyyy"
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

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		ListadodeClientes.ShowDialog()
	End Sub

	Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
		Dim resp = MsgBox("Está seguro que desea limpiar los campos?", MsgBoxStyle.YesNo, "Limpiar")
		If resp = MsgBoxResult.No Then
			Return
		End If
		Limpiar()
		Block()
	End Sub

	Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
		FrmEstadisticacliente.ShowDialog()
	End Sub

	Private Sub chbListaParaOrdenar_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chbListaParaOrdenar.ItemCheck
		If Not String.IsNullOrEmpty(chbListaParaOrdenar.SelectedItem) Then

			Dim count = OrderBy.Where(Function(x) Not x.Item2 = "").Count()
			Dim suma = False
			Dim resta = False
			If e.NewValue = CheckState.Checked Then
				count += 1
				suma = True
			ElseIf e.NewValue = CheckState.Unchecked Then
				resta = True
			End If
			If OrderBy.FirstOrDefault(Function(x) x.Item2.Replace("'", "") = chbListaParaOrdenar.SelectedItem) IsNot Nothing Then
				suma = False
				count -= 1
			End If
			If count > 3 Then
				MsgBox("Se puede ordenar hasta por 3 campos máximo", MsgBoxStyle.OkOnly, "Ordenar")
				e.NewValue = CheckState.Unchecked
				Return
			End If

			Dim number = 0
			Dim prueba = OrderBy.LastOrDefault(Function(x) Not x.Item2 = "")
			If prueba IsNot Nothing Then
				number = prueba.Item1
			End If
			If suma Then
				OrderBy.RemoveAll(Function(x) x.Item1 = number + 1)
				OrderBy.Add(New Tuple(Of Integer, String, Integer)(number + 1, "'" + chbListaParaOrdenar.SelectedItem.ToString + "'", number + 1))
			End If
			If resta Then
				OrderBy.RemoveAll(Function(x) x.Item2 = "'" + chbListaParaOrdenar.SelectedItem.ToString + "'")
				OrderBy.Add(New Tuple(Of Integer, String, Integer)(number, "", number))
			End If
			OrderBy = OrderBy.OrderBy(Function(x) x.Item1).ToList()
			ImpactarOrderBy()
		End If
	End Sub

	Public Sub ImpactarOrderBy()
		Dim count = OrderBy.Where(Function(x) Not x.Item2 = "").Count()

		If count >= 1 Then
			lblPrioridad1.Visible = True
			lblPrioridad1.Text = OrderBy(0).Item2.Replace("'", "")
		Else
			lblPrioridad1.Visible = False
		End If
		If count >= 2 Then
			lblPrioridad2.Visible = True
			lblPrioridad2.Text = OrderBy(1).Item2.Replace("'", "")
		Else
			lblPrioridad2.Visible = False
		End If
		If count >= 3 Then
			lblPrioridad3.Visible = True
			lblPrioridad3.Text = OrderBy(2).Item2.Replace("'", "")
		Else
			lblPrioridad3.Visible = False
		End If
	End Sub

#End Region

	Private Const CP_NOCLOSE_BUTTON As Integer = &H200
	Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
		Get
			Dim myCp As CreateParams = MyBase.CreateParams
			myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
			Return myCp
		End Get
	End Property


End Class