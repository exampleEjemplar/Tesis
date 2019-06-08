﻿Imports System.Windows.Forms
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

#Region "Eventos"

    Private Sub FrmGestionProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbProvincias.SelectedValue = 0
        cbtipodni.SelectedValue = 0
        cboTipoPersona.DataSource = New List(Of String) From {"Física", "Jurídica"}
        IdProvincia = LlenarCMBProvincias("general")
        LlenarCMBLocalidades("general")
        Block()
        DgvProveedoresSet(New Dictionary(Of String, String))

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

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        MDIPrincipal.Show()
    End Sub

    Private Sub DgvProveedores_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvProveedores.DoubleClick
        Try
            Dim ds As DataSet = proveedorMetodo.ConsultaModificacion(ProveedorId)
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If ds.Tables(0).Rows(i)(0).ToString() = "F" Then
                    cboTipoPersona.SelectionStart = 0
                    lblInicioAct.Visible = False
                    lblNombreFanta.Visible = False
                    lblRazonSoc.Visible = False
                    dtpfechanac.MinDate = DateTime.Now.AddYears(-100)
                    dtpfechanac.MaxDate = DateTime.Now.AddYears(-18)
                Else
                    cboTipoPersona.SelectionStart = 1
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

                'Si detecta que el texto es null lo transforma en ""

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

                tbmail.Text = ds.Tables(0).Rows(i)(13).ToString()

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

                ProveedorId = ds.Tables(0).Rows(i)(19).ToString()

                Unblock()
                GroupBox6.Visible = True
                Modificando = True
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        If helpersUI.TextValidator("Tipo de persona", cboTipoPersona.SelectedItem) = False Or
            helpersUI.TextValidator("Tipo de identificacion", cbtipodni.Text) = False Or
            helpersUI.TextValidator("Numero de identificacion", tbNroDoc.Text) = False Then
            Return
        End If
        If helpersLN.ValidarSiExisteDni(Convert.ToInt64(tbNroDoc.Text), "Proveedores") = False Then
            MsgBox("La identificación puede ser utilizada!", MsgBoxStyle.OkOnly, "Ok")
            Unblock()
            If cboTipoPersona.SelectedItem = "Física" Then
                lblRazonSoc.Visible = False
                lblNombreFanta.Visible = False
                lblInicioAct.Visible = False
                lblNombre.Visible = True
                lblApellido.Visible = True
                lblFechaNac.Visible = True
                fisicaOJuridica = "F"
            Else
                lblRazonSoc.Visible = True
                lblNombreFanta.Visible = True
                lblInicioAct.Visible = True
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
    End Sub

#End Region

#Region "Validadores"

    'Valida datos antes de insertarlos en la BD
    Public Function ValidarDatos()

		If tbmail.Text.Contains("ñ") Or helpersUI.IsEmail(tbmail.Text) = False Then
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

        Dim listOfMandatoriesInteger As List(Of Tuple(Of String, Integer, Integer, String)) = New List(Of Tuple(Of String, Integer, Integer, String)) From
            {New Tuple(Of String, Integer, Integer, String)(tbNombre.Text, 3, 0, "Nombre"),
            New Tuple(Of String, Integer, Integer, String)(tbApellido.Text, 2, 0, "Apellido"),
            New Tuple(Of String, Integer, Integer, String)(tbcalle.Text, 5, 0, "Calle"),
            New Tuple(Of String, Integer, Integer, String)(tbcodcel.Text, 2, 0, "Característica celular"),
            New Tuple(Of String, Integer, Integer, String)(tbcel.Text, 6, 0, "Número celular")}

        For Each items As Tuple(Of String, Integer, Integer, String) In listOfMandatoriesInteger
            If helpersUI.ValidarTamaño(items.Item1, items.Item2, items.Item3) = False Then
                MsgBox("El campo " + items.Item4 + " no puede ser menor a " + items.Item2.ToString() + " caracteres", MsgBoxStyle.Critical, "Cantidad de caracteres")
                Return False
            End If
        Next

        'If String.IsNullOrWhiteSpace(tbcodcel.Text) = False And String.IsNullOrWhiteSpace(tbcel.Text) = True Then
        '    MsgBox("Ingrese el número de celular correspondiente", MsgBoxStyle.Critical, "Celular")
        '    Return False
        'End If
        'If String.IsNullOrWhiteSpace(tbcodcel.Text) = True And String.IsNullOrWhiteSpace(tbcel.Text) = False Then
        '    MsgBox("Ingrese la característica de celular correspondiente", MsgBoxStyle.Critical, "Celular")
        '    Return False
        'End If
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
            pro.UsuarioId = value
        Else
            pro.UsuarioId = Nothing
        End If
        pro.FisicaOJuridica = fisicaOJuridica
        pro.TipoDocumentoId = cbtipodni.SelectedValue
        pro.NumeroDocumento = tbNroDoc.Text
        pro.Email = tbmail.Text
        pro.Nombre = tbNombre.Text
        pro.Apellido = tbApellido.Text
        pro.FechaNacimiento = dtpfechanac.Value
        pro.CiudadId = cmbLocalidades.SelectedValue
        pro.Car_Celular = tbcodcel.Text
        pro.NumeroCelular = tbcel.Text

        If String.IsNullOrEmpty(txtLote.Text) Then
			pro.Lote = ""
		Else
            pro.Lote = txtLote.Text
        End If
        If String.IsNullOrEmpty(txtBarrio.Text) Then
			pro.Barrio = ""
		Else
            pro.Barrio = txtBarrio.Text
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

        If String.IsNullOrEmpty(tbcalle.Text) Then
			pro.Calle = ""
		Else
            pro.Calle = tbcalle.Text
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
        If e.Handled = True Then
            MsgBox("Caracter invalido", MsgBoxStyle.Critical, "Caracter invalido")
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
        cbtipodni.Enabled = False
        tbNroDoc.ReadOnly = False
        btnValidarDNI1.Enabled = True
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
        btnValidarDNI1.Enabled = False
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
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return cmbProvincias.SelectedValue

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
        If dsa1.Tables(0).Rows.Count > 0 Then
            ProveedorId = dsa1.Tables(0).Rows(0)(13)
        End If
        dgvProveedores.DataSource = dsa1.Tables(0)
        dgvProveedores.Columns("Id").Visible = False
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
                If tbNroDoc.Text.Length <> 9 And tbNroDoc.Text.Length <> 8 Then
                    MsgBox("El tamaño del campo número de identificación no tiene la cantidad de caracteres correctos", MsgBoxStyle.Critical, "Cantidad de caracteres")
                    Return
                End If
            Case 4 To 5
                If tbNroDoc.Text.Length <> 12 Then
                    MsgBox("El tamaño del campo número de identificación no tiene la cantidad de caracteres correctos", MsgBoxStyle.Critical, "Cantidad de caracteres")
                    Return
                End If
            Case Else
                Return
        End Select
        If helpersLN.ValidarSiExisteDni(Convert.ToInt64(tbNroDoc.Text), "Proveedores") = False Then

            Unblock()
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


#End Region
End Class