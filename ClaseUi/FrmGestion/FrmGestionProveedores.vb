Imports System.Drawing
Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe


Public Class FrmGestionProveedores

	Private proveedorMetodo As New ProveedoresLN
	Private pro As New ProveedoresNE
	Private helpersLN As New HelpersLN
	Private helpersUI As New HelpersUI
	Public IdProvincia As Integer
	Public IdLocalidad As Integer
	Private fisicaOJuridica As String
	Private ProveedorId As Integer
	Private Modificando As Boolean
	Public modificado As Boolean
	Dim cadena As String

#Region "Eventos"

	Private Sub FrmGestionProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		cmbProvincias.SelectedValue = 0
		cbtipodni.SelectedValue = 0
		'cboTipoPersona.DataSource = New List(Of String) From {"Física", "Jurídica"}
		IdProvincia = LlenarCMBProvincias("general")
		'LlenarCMBLocalidades("general")
		Block()
		DgvProveedoresSet(New Dictionary(Of String, String))
		If Not Modificando Then
			tbmail.Text = "ejemplo@ejemplo.com"
		End If
		modificado = False

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
		'Si es un nuevo proveedor lo agrega
		If Not Modificando Then
			proveedorMetodo.GrabarProveedores(pro)
			MsgBox("Proveedor agregado con exito!", MsgBoxStyle.OkOnly, "Exito")
		Else
			'Si es uno ya creado lo actualiza
			pro.Id = ProveedorId
			proveedorMetodo.ActualizarProveedores(pro)
			MsgBox("Proveedor actualizado con exito!", MsgBoxStyle.OkOnly, "Exito")
		End If
		Limpiar()
		Block()
		Modificando = False
		DgvProveedoresSet(New Dictionary(Of String, String))
		modificado = True

	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
		Me.Close()

    End Sub

	Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Dgvproveedores.CellMouseDoubleClick
		Unblock()
		Dim selectedRow As DataGridViewRow
		If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
			selectedRow = Dgvproveedores.Rows(e.RowIndex)
		End If
		Try
			Dim ds As DataSet = proveedorMetodo.ConsultaModificacion(selectedRow.Cells("id").Value)
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
				ProveedorId = ds.Tables(0).Rows(i)(19).ToString()
				If ds.Tables(0).Rows(i)(22).ToString() = "S" Then
					chkProveeServicios.Checked = True
				Else
					chkProveeServicios.Checked = False
				End If
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
		If DgvProveedoresSet(parametros).Tables(0).Rows.Count = 0 Then
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
			pro.UsuarioId = value
		Else
			pro.UsuarioId = Nothing
		End If

		pro.FisicaOJuridica = fisicaOJuridica
		pro.TipoDocumentoId = cbtipodni.SelectedValue
		pro.NumeroDocumento = tbNroDoc.Text
		pro.ProveeServicios = If(chkProveeServicios.Checked, "S", "N")

		If Not String.IsNullOrEmpty(tbmail.Text) Then
			If helpersUI.IsEmail(tbmail.Text) = False Then
				MsgBox("Debe ingresar correctamente el campo email", MsgBoxStyle.Critical, "Error")
				Return False
			End If
			pro.Email = tbmail.Text
		Else
			pro.Email = ""
		End If

		If Not String.IsNullOrEmpty(tbcalle.Text) Then
			If Not helpersUI.HasStrangerCaracters(tbcalle.Text) Then
				MsgBox("Caracter invalido en el campo calle", MsgBoxStyle.Critical, "Error")
				Return False
			End If
			pro.Calle = helpersUI.NormalizarTexto(tbcalle.Text)
		Else
			pro.Calle = ""
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
			pro.CiudadId = cmbLocalidades.SelectedValue
		End If
		If String.IsNullOrEmpty(dtpfechanac.Value.ToString()) Then
			pro.FechaNacimiento = ""
		Else
			pro.FechaNacimiento = dtpfechanac.Value
		End If
		If String.IsNullOrEmpty(tbApellido.Text) Then
			MsgBox("Debe Cargar un Apellido/Razon Social", MsgBoxStyle.Critical, "Error")
			Return False
		Else
			pro.Apellido = helpersUI.NormalizarTexto(tbApellido.Text)
		End If
		If String.IsNullOrEmpty(tbNombre.Text) Then
			MsgBox("Debe Cargar un Nombre/Nombre Fantasía", MsgBoxStyle.Critical, "Error")
			Return False
		Else
			pro.Nombre = helpersUI.NormalizarTexto(tbNombre.Text)
		End If
		If String.IsNullOrEmpty(txtLote.Text) Then
			pro.Lote = ""
		Else
			pro.Lote = txtLote.Text
		End If
		If String.IsNullOrEmpty(txtBarrio.Text) Then
			pro.Barrio = ""
		Else
			pro.Barrio = helpersUI.NormalizarTexto(txtBarrio.Text)
		End If
		If String.IsNullOrEmpty(tbcodtel.Text) Then
			pro.Car_Telefono = ""
		Else
			pro.Car_Telefono = tbcodtel.Text
		End If
		If String.IsNullOrEmpty(tbtelefono.Text) Then
			pro.NumeroTelefono = ""
		Else
			pro.NumeroTelefono = tbtelefono.Text
		End If
		If String.IsNullOrEmpty(tbcodcel.Text) Then
			pro.Car_Celular = ""
		Else
			pro.Car_Celular = tbcodcel.Text
		End If
		If String.IsNullOrEmpty(tbcel.Text) Then
			pro.NumeroCelular = ""
		Else
			pro.NumeroCelular = tbcel.Text
		End If
		If String.IsNullOrEmpty(tbNro.Text) Then
			pro.NumeroCalle = ""
		Else
			pro.NumeroCalle = tbNro.Text
		End If
		If String.IsNullOrEmpty(tbDpto.Text) Then
			pro.Departamento = ""
		Else
			pro.Departamento = tbDpto.Text
		End If
		If String.IsNullOrEmpty(txtManzana.Text) Then
			pro.Manzana = ""
		Else
			pro.Manzana = txtManzana.Text
		End If
		If String.IsNullOrEmpty(txtPiso.Text) Then
			pro.Piso = ""
		Else
			pro.Piso = txtPiso.Text
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
	Public Function DgvProveedoresSet(ByVal parametros As Dictionary(Of String, String)) As DataSet
		Dim dsa1 As DataSet
		dsa1 = proveedorMetodo.CargaGrillaProveedores(parametros) 'Si parametros esta vacio, busca todos los proveedores en la bd
		If dsa1.Tables(0).Rows.Count() <> 0 Then
			ProveedorId = dsa1.Tables(0).Rows(0)(13)
		End If
		Dgvproveedores.DataSource = dsa1.Tables(0)
		Dgvproveedores.Columns("Id").Visible = False
		Dgvproveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
		Dgvproveedores.AutoResizeColumns()
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
		If helpersLN.ValidarSiExisteDni(Convert.ToInt64(tbNroDoc.Text), "Proveedores") = False Then

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
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

	End Sub

	Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
		Dim resp = MsgBox("Está seguro que desea limpiar los campos?", MsgBoxStyle.YesNo, "Limpiar")
		If resp = MsgBoxResult.No Then
			Return
		End If
		Limpiar()
		Block()
	End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

#End Region




End Class