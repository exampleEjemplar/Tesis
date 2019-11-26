Imports System.Windows.Forms
Imports ClaseLn
Imports ClaseNe


Public Class FrmGestionUsuario

	Private UsuariosMetodo As New UsuariosLN
	Private usu As New UsuariosNE
	Private helpersLN As New HelpersLN
	Private helpersUI As New HelpersUI
	Private fisicaOJuridica As String
	Private UsuarioId As Integer
	Private Cambiando As Boolean = False

#Region "Eventos"

	Private Sub FrmGestionProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim list = New List(Of String) From {"Si", "No"}
		cboActivoSN.DataSource = list
		cboBusActivoSN.DataSource = list
		cboActivoSN.SelectedItem = "Si"
		cboBusActivoSN.SelectedItem = "Si"
		cboRol.SelectedValue = 0
		cboBusRol.SelectedValue = 0
		Block()
		LlenarCboRoles("comun")
		LlenarCboRoles("bus")
		DgvUSuariosSet(New Dictionary(Of String, String))
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
		If ValidarDatos() = False Then
			Return
		End If
		'Si es un nuevo cliente lo agrega
		If UsuarioId = 0 Then
			UsuariosMetodo.GrabarUsuarios(usu)
			MsgBox("Usuario agregado con exito!", MsgBoxStyle.OkOnly, "Exito")
		Else
			'Si es uno ya creado lo actualiza
			usu.Id = UsuarioId
			UsuariosMetodo.ActualizarUsuarios(usu)
			MsgBox("Usuario actualizado con exito!", MsgBoxStyle.OkOnly, "Exito")
		End If
		Limpiar()
		Block()
		DgvUSuariosSet(New Dictionary(Of String, String))
		Cambiando = False
	End Sub

	Public Sub Limpiar()
		txtUserName.Text = ""
		txtContrasena.Text = ""
		txtRepetirContrasena.Text = ""
		cboActivoSN.SelectedItem = Nothing
		cboRol.SelectedItem = Nothing
	End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub DgvProveedores_DoubleClick(sender As Object, e As System.EventArgs) Handles dgvUsuarios.DoubleClick
		If Cambiando Then
			Return
		End If
		Dim ds As DataSet = UsuariosMetodo.ConsultaModificacion((dgvUsuarios.Item(0, dgvUsuarios.CurrentRow.Index).Value))
		For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
			txtUserName.Text = ds.Tables(0).Rows(i)(0).ToString()
			txtContrasena.Text = (ds.Tables(0).Rows(i)(1).ToString())
			txtRepetirContrasena.Text = (ds.Tables(0).Rows(i)(1).ToString())
			LlenarCboRoles(ds.Tables(0).Rows(i)(2).ToString())
			If (ds.Tables(0).Rows(i)(3).ToString()) = "S" Then
				cboActivoSN.SelectionStart = 0
				cboActivoSN.SelectedItem = "Si"
			Else
				cboActivoSN.SelectionStart = 1
				cboActivoSN.SelectedItem = "No"
			End If
			UsuarioId = (ds.Tables(0).Rows(i)(4).ToString())
			Unblock()
		Next

	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnValidarUserName.Click
		If Not helpersUI.ValidarTamaño(txtUserName.Text, 3, 20) Then
			MsgBox("El nombre de usuario es demasiado corto/largo", MsgBoxStyle.OkOnly, "Ok")
			Return
		End If
		If helpersLN.ValidarSiExisteUserName(txtUserName.Text) = False Then
			MsgBox("El nombre de usuario puede ser utilizado!", MsgBoxStyle.OkOnly, "Ok")
			Unblock()
		Else
			MsgBox("El nombre de usuario ingresado ya existe en la base de datos", MsgBoxStyle.Critical, "Ya existente")
			Return
		End If
	End Sub

	Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
		btnValidarUserName.Enabled = False
		txtUserName.ReadOnly = True
		btnNuevo.Enabled = False
		dgvUsuarios.ReadOnly = True
		GroupBox6.Visible = True
		txtUserName.ReadOnly = False
		btnValidarUserName.Enabled = True
		Cambiando = True
	End Sub
#End Region
#Region "Validadores"

	'Valida datos antes de insertarlos en la BD
	Public Function ValidarDatos()

		'Agrego todos los txt y cbo a un diccionario para validarlos despues genericamente y no uno por uno
		Dim dictionaryOfMandatoriesTexts As Dictionary(Of String, String) = New Dictionary(Of String, String) From
		{{"Contraseña", txtContrasena.Text}, {"Repetir contraseña", txtRepetirContrasena.Text},
		{"Activo?", cboActivoSN.SelectedValue},
		{"Rol", cboRol.SelectedValue}}

		For Each texts As KeyValuePair(Of String, String) In dictionaryOfMandatoriesTexts
			If helpersUI.TextValidator(texts.Key, texts.Value) = False Then
				Return False
			End If
		Next

		If txtContrasena.Text <> txtRepetirContrasena.Text Then
			MsgBox("Las contraseñas no coinciden", MsgBoxStyle.Critical, "Error")
			Return False
		End If

		If Not helpersUI.ValidatePassword(txtContrasena.Text) Then
			MsgBox("Las contraseña no contiene los parámetros requeridos (1 letra mayúscula, 1 número, 1 letra minúscula, 8 caracteres)", MsgBoxStyle.Critical, "Error")
			Return False
		End If

		usu.UserName = txtUserName.Text
		usu.Contrasena = txtContrasena.Text
		usu.RolId = cboRol.SelectedValue
		If cboActivoSN.SelectedItem = "Si" Then
			usu.ActivoSN = "S"
		Else
			usu.ActivoSN = "N"
		End If
		Return True
	End Function

	'Valida que el texto sea solo numeros
	Private Sub TxbTelNumero_KeyPress(sender As System.Object, e As KeyPressEventArgs)
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
	Private Sub TbNombre_KeyPress(sender As System.Object, e As KeyPressEventArgs)
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

	Public Sub Unblock()
		GroupBox2.Visible = True
		GroupBox6.Visible = True
		btnGuardar.Enabled = True
		btnNuevo.Enabled = False
	End Sub

	'Deshabilita los buttons,tb,etc necesarios
	Public Sub Block()
		GroupBox6.Visible = False
		btnValidarUserName.Enabled = False
		txtUserName.ReadOnly = True
		GroupBox2.Visible = False
		btnGuardar.Enabled = False
		btnNuevo.Enabled = True
		btnValidarUserName.Enabled = True
		txtUserName.ReadOnly = True
		dgvUsuarios.ReadOnly = True
	End Sub
#End Region

#Region "Rellenado"

	'Carga el combo tipo de documento
	Public Sub LlenarCboRoles(ByVal type As String)
		Dim ds1 As DataSet
		ds1 = UsuariosMetodo.CargarRoles()
		If type <> "bus" Then
			cboRol.DataSource = ds1.Tables(0)
			cboRol.DisplayMember = "descripcion"
			cboRol.ValueMember = "id"
			cboRol.SelectionStart = (ds1.Tables(0).Rows(0)("id"))
		Else
			cboBusRol.DataSource = ds1.Tables(0)
			cboBusRol.DisplayMember = "descripcion"
			cboBusRol.ValueMember = "id"
			cboBusRol.SelectionStart = (ds1.Tables(0).Rows(0)("id"))
		End If
	End Sub

	'Carga DataGridView con datos
	Public Function DgvUSuariosSet(ByVal parametros As Dictionary(Of String, String)) As DataSet
		Dim dsa1 As DataSet
		dsa1 = UsuariosMetodo.CargarGrillaUsuarios(parametros) 'Si parametros esta vacio, busca todos los proveedores en la bd
        dgvUsuarios.DataSource = dsa1.Tables(0)
        dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Return dsa1
	End Function

	Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
		Dim parametros As New Dictionary(Of String, String)
		If String.IsNullOrWhiteSpace(cboActivoSN.SelectedItem) = False Then
			Dim activosn As String
			If cboActivoSN.SelectedValue = "Si" Then
				activosn = "S"
				cboActivoSN.SelectionStart = 0
			Else
				activosn = "N"
				cboActivoSN.SelectionStart = 1
			End If
			parametros.Add("ActivoSN", activosn)
		End If
		If String.IsNullOrWhiteSpace(txtBusUserName.Text) = False Then
			parametros.Add("username", txtBusUserName.Text)
		End If
		If String.IsNullOrWhiteSpace(cboBusRol.SelectedValue) = False Then
			parametros.Add("RolId", cboBusRol.SelectedValue)
		End If
		If DgvUSuariosSet(parametros).Tables(0).Rows.Count = 0 Then
			MsgBox("La búsqueda no arrojo resultados", MsgBoxStyle.Critical, "Error")
		End If
	End Sub

#End Region

End Class