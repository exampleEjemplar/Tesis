<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionCliente
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer

	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar usando el Diseñador de Windows Forms.  
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox6 = New System.Windows.Forms.GroupBox()
		Me.btnValidarDNI1 = New System.Windows.Forms.Button()
		Me.lblTipoIdentificacion = New System.Windows.Forms.Label()
		Me.cboTipoPersona = New System.Windows.Forms.ComboBox()
		Me.cbtipodni = New System.Windows.Forms.ComboBox()
		Me.lblTipoDePersona = New System.Windows.Forms.Label()
		Me.lblNumIdent = New System.Windows.Forms.Label()
		Me.tbNroDoc = New System.Windows.Forms.TextBox()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.lblInicioAct = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.lblApellido = New System.Windows.Forms.Label()
		Me.lblNombre = New System.Windows.Forms.Label()
		Me.lblNombreFanta = New System.Windows.Forms.Label()
		Me.tbmail = New System.Windows.Forms.TextBox()
		Me.dtpfechanac = New System.Windows.Forms.DateTimePicker()
		Me.tbNombre = New System.Windows.Forms.TextBox()
		Me.lblFechaNac = New System.Windows.Forms.Label()
		Me.tbApellido = New System.Windows.Forms.TextBox()
		Me.lblRazonSoc = New System.Windows.Forms.Label()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.tbtelefono = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.tbcodcel = New System.Windows.Forms.TextBox()
		Me.tbcel = New System.Windows.Forms.TextBox()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.tbcodtel = New System.Windows.Forms.TextBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtBarrio = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtPiso = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtManzana = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtLote = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.cmbLocalidades = New System.Windows.Forms.ComboBox()
		Me.cmbProvincias = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.tbcalle = New System.Windows.Forms.TextBox()
		Me.tbNro = New System.Windows.Forms.TextBox()
		Me.tbDpto = New System.Windows.Forms.TextBox()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.cboBusTipoPersona = New System.Windows.Forms.ComboBox()
		Me.txtBusApellido = New System.Windows.Forms.TextBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.lblBusApellido = New System.Windows.Forms.Label()
		Me.txtBusNombre = New System.Windows.Forms.TextBox()
		Me.lblBusNombre = New System.Windows.Forms.Label()
		Me.txtBusDocNro = New System.Windows.Forms.TextBox()
		Me.cboBusTipoDNI = New System.Windows.Forms.ComboBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Dgvclientes = New System.Windows.Forms.DataGridView()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.btnNuevo = New System.Windows.Forms.Button()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox6.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox5.SuspendLayout()
		CType(Me.Dgvclientes, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.GroupBox6)
		Me.GroupBox1.Controls.Add(Me.GroupBox4)
		Me.GroupBox1.Controls.Add(Me.GroupBox3)
		Me.GroupBox1.Controls.Add(Me.GroupBox2)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(65, 15)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox1.Size = New System.Drawing.Size(1272, 359)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Tag = ""
		Me.GroupBox1.Text = "Gestión de Cliente"
		'
		'GroupBox6
		'
		Me.GroupBox6.Controls.Add(Me.btnValidarDNI1)
		Me.GroupBox6.Controls.Add(Me.lblTipoIdentificacion)
		Me.GroupBox6.Controls.Add(Me.cboTipoPersona)
		Me.GroupBox6.Controls.Add(Me.cbtipodni)
		Me.GroupBox6.Controls.Add(Me.lblTipoDePersona)
		Me.GroupBox6.Controls.Add(Me.lblNumIdent)
		Me.GroupBox6.Controls.Add(Me.tbNroDoc)
		Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox6.ForeColor = System.Drawing.Color.Black
		Me.GroupBox6.Location = New System.Drawing.Point(12, 18)
		Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox6.Name = "GroupBox6"
		Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox6.Size = New System.Drawing.Size(1232, 84)
		Me.GroupBox6.TabIndex = 3
		Me.GroupBox6.TabStop = False
		'
		'btnValidarDNI1
		'
		Me.btnValidarDNI1.BackColor = System.Drawing.SystemColors.Control
		Me.btnValidarDNI1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_approval_48
		Me.btnValidarDNI1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnValidarDNI1.FlatAppearance.BorderSize = 0
		Me.btnValidarDNI1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnValidarDNI1.Location = New System.Drawing.Point(888, 14)
		Me.btnValidarDNI1.Margin = New System.Windows.Forms.Padding(4)
		Me.btnValidarDNI1.Name = "btnValidarDNI1"
		Me.btnValidarDNI1.Size = New System.Drawing.Size(217, 60)
		Me.btnValidarDNI1.TabIndex = 4
		Me.btnValidarDNI1.Text = "Verificar "
		Me.btnValidarDNI1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnValidarDNI1.UseVisualStyleBackColor = False
		'
		'lblTipoIdentificacion
		'
		Me.lblTipoIdentificacion.AutoSize = True
		Me.lblTipoIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTipoIdentificacion.Location = New System.Drawing.Point(123, 50)
		Me.lblTipoIdentificacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTipoIdentificacion.Name = "lblTipoIdentificacion"
		Me.lblTipoIdentificacion.Size = New System.Drawing.Size(152, 17)
		Me.lblTipoIdentificacion.TabIndex = 9
		Me.lblTipoIdentificacion.Text = "Tipo Identificación *"
		'
		'cboTipoPersona
		'
		Me.cboTipoPersona.AccessibleDescription = ""
		Me.cboTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboTipoPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboTipoPersona.FormattingEnabled = True
		Me.cboTipoPersona.Location = New System.Drawing.Point(287, 17)
		Me.cboTipoPersona.Margin = New System.Windows.Forms.Padding(4)
		Me.cboTipoPersona.Name = "cboTipoPersona"
		Me.cboTipoPersona.Size = New System.Drawing.Size(100, 25)
		Me.cboTipoPersona.TabIndex = 1
		'
		'cbtipodni
		'
		Me.cbtipodni.AccessibleDescription = ""
		Me.cbtipodni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbtipodni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cbtipodni.FormattingEnabled = True
		Me.cbtipodni.Location = New System.Drawing.Point(287, 47)
		Me.cbtipodni.Margin = New System.Windows.Forms.Padding(4)
		Me.cbtipodni.Name = "cbtipodni"
		Me.cbtipodni.Size = New System.Drawing.Size(197, 25)
		Me.cbtipodni.TabIndex = 2
		'
		'lblTipoDePersona
		'
		Me.lblTipoDePersona.AutoSize = True
		Me.lblTipoDePersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTipoDePersona.Location = New System.Drawing.Point(123, 17)
		Me.lblTipoDePersona.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTipoDePersona.Name = "lblTipoDePersona"
		Me.lblTipoDePersona.Size = New System.Drawing.Size(138, 17)
		Me.lblTipoDePersona.TabIndex = 19
		Me.lblTipoDePersona.Text = "Tipo de persona *"
		'
		'lblNumIdent
		'
		Me.lblNumIdent.AutoSize = True
		Me.lblNumIdent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNumIdent.Location = New System.Drawing.Point(508, 50)
		Me.lblNumIdent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblNumIdent.Name = "lblNumIdent"
		Me.lblNumIdent.Size = New System.Drawing.Size(176, 17)
		Me.lblNumIdent.TabIndex = 15
		Me.lblNumIdent.Text = "Numero Identificacion *"
		'
		'tbNroDoc
		'
		Me.tbNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbNroDoc.Location = New System.Drawing.Point(703, 47)
		Me.tbNroDoc.Margin = New System.Windows.Forms.Padding(4)
		Me.tbNroDoc.MaxLength = 12
		Me.tbNroDoc.Name = "tbNroDoc"
		Me.tbNroDoc.Size = New System.Drawing.Size(176, 23)
		Me.tbNroDoc.TabIndex = 3
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.lblInicioAct)
		Me.GroupBox4.Controls.Add(Me.Label11)
		Me.GroupBox4.Controls.Add(Me.lblApellido)
		Me.GroupBox4.Controls.Add(Me.lblNombre)
		Me.GroupBox4.Controls.Add(Me.lblNombreFanta)
		Me.GroupBox4.Controls.Add(Me.tbmail)
		Me.GroupBox4.Controls.Add(Me.dtpfechanac)
		Me.GroupBox4.Controls.Add(Me.tbNombre)
		Me.GroupBox4.Controls.Add(Me.lblFechaNac)
		Me.GroupBox4.Controls.Add(Me.tbApellido)
		Me.GroupBox4.Controls.Add(Me.lblRazonSoc)
		Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox4.ForeColor = System.Drawing.Color.Black
		Me.GroupBox4.Location = New System.Drawing.Point(8, 100)
		Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox4.Size = New System.Drawing.Size(1236, 92)
		Me.GroupBox4.TabIndex = 14
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Datos"
		'
		'lblInicioAct
		'
		Me.lblInicioAct.AutoSize = True
		Me.lblInicioAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblInicioAct.Location = New System.Drawing.Point(692, 28)
		Me.lblInicioAct.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblInicioAct.Name = "lblInicioAct"
		Me.lblInicioAct.Size = New System.Drawing.Size(139, 17)
		Me.lblInicioAct.TabIndex = 23
		Me.lblInicioAct.Text = "Inicio Actividades "
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
		Me.Label11.Location = New System.Drawing.Point(133, 27)
		Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(61, 18)
		Me.Label11.TabIndex = 20
		Me.Label11.Text = "E-Mail "
		'
		'lblApellido
		'
		Me.lblApellido.AutoSize = True
		Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblApellido.Location = New System.Drawing.Point(657, 60)
		Me.lblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblApellido.Name = "lblApellido"
		Me.lblApellido.Size = New System.Drawing.Size(77, 17)
		Me.lblApellido.TabIndex = 22
		Me.lblApellido.Text = "Apellido *"
		'
		'lblNombre
		'
		Me.lblNombre.AutoSize = True
		Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNombre.Location = New System.Drawing.Point(133, 59)
		Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblNombre.Name = "lblNombre"
		Me.lblNombre.Size = New System.Drawing.Size(80, 17)
		Me.lblNombre.TabIndex = 21
		Me.lblNombre.Text = "Nombre  *"
		'
		'lblNombreFanta
		'
		Me.lblNombreFanta.AutoSize = True
		Me.lblNombreFanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNombreFanta.Location = New System.Drawing.Point(128, 59)
		Me.lblNombreFanta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblNombreFanta.Name = "lblNombreFanta"
		Me.lblNombreFanta.Size = New System.Drawing.Size(165, 17)
		Me.lblNombreFanta.TabIndex = 0
		Me.lblNombreFanta.Text = "Nombre de Fantasía *"
		'
		'tbmail
		'
		Me.tbmail.Location = New System.Drawing.Point(291, 21)
		Me.tbmail.Margin = New System.Windows.Forms.Padding(4)
		Me.tbmail.MaxLength = 40
		Me.tbmail.Name = "tbmail"
		Me.tbmail.Size = New System.Drawing.Size(272, 23)
		Me.tbmail.TabIndex = 5
		'
		'dtpfechanac
		'
		Me.dtpfechanac.CustomFormat = "dd/MM/yyy"
		Me.dtpfechanac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpfechanac.Location = New System.Drawing.Point(864, 22)
		Me.dtpfechanac.Margin = New System.Windows.Forms.Padding(4)
		Me.dtpfechanac.Name = "dtpfechanac"
		Me.dtpfechanac.Size = New System.Drawing.Size(215, 23)
		Me.dtpfechanac.TabIndex = 7
		Me.dtpfechanac.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
		'
		'tbNombre
		'
		Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbNombre.Location = New System.Drawing.Point(304, 57)
		Me.tbNombre.Margin = New System.Windows.Forms.Padding(4)
		Me.tbNombre.MaxLength = 30
		Me.tbNombre.Name = "tbNombre"
		Me.tbNombre.Size = New System.Drawing.Size(308, 23)
		Me.tbNombre.TabIndex = 6
		'
		'lblFechaNac
		'
		Me.lblFechaNac.AutoSize = True
		Me.lblFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFechaNac.Location = New System.Drawing.Point(692, 27)
		Me.lblFechaNac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblFechaNac.Name = "lblFechaNac"
		Me.lblFechaNac.Size = New System.Drawing.Size(137, 17)
		Me.lblFechaNac.TabIndex = 17
		Me.lblFechaNac.Text = "Fecha Nacimiento"
		'
		'tbApellido
		'
		Me.tbApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbApellido.Location = New System.Drawing.Point(757, 52)
		Me.tbApellido.Margin = New System.Windows.Forms.Padding(4)
		Me.tbApellido.MaxLength = 30
		Me.tbApellido.Name = "tbApellido"
		Me.tbApellido.Size = New System.Drawing.Size(321, 23)
		Me.tbApellido.TabIndex = 8
		'
		'lblRazonSoc
		'
		Me.lblRazonSoc.AutoSize = True
		Me.lblRazonSoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRazonSoc.Location = New System.Drawing.Point(628, 59)
		Me.lblRazonSoc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblRazonSoc.Name = "lblRazonSoc"
		Me.lblRazonSoc.Size = New System.Drawing.Size(119, 17)
		Me.lblRazonSoc.TabIndex = 11
		Me.lblRazonSoc.Text = "Razón Social  *"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.tbtelefono)
		Me.GroupBox3.Controls.Add(Me.Label9)
		Me.GroupBox3.Controls.Add(Me.Label10)
		Me.GroupBox3.Controls.Add(Me.tbcodcel)
		Me.GroupBox3.Controls.Add(Me.tbcel)
		Me.GroupBox3.Controls.Add(Me.Label14)
		Me.GroupBox3.Controls.Add(Me.Label13)
		Me.GroupBox3.Controls.Add(Me.tbcodtel)
		Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox3.Location = New System.Drawing.Point(8, 304)
		Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox3.Size = New System.Drawing.Size(1236, 50)
		Me.GroupBox3.TabIndex = 14
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Contacto"
		'
		'tbtelefono
		'
		Me.tbtelefono.Location = New System.Drawing.Point(877, 14)
		Me.tbtelefono.Margin = New System.Windows.Forms.Padding(4)
		Me.tbtelefono.MaxLength = 12
		Me.tbtelefono.Name = "tbtelefono"
		Me.tbtelefono.Size = New System.Drawing.Size(239, 23)
		Me.tbtelefono.TabIndex = 24
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(859, 17)
		Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(14, 17)
		Me.Label9.TabIndex = 18
		Me.Label9.Text = "-"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(131, 21)
		Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(64, 17)
		Me.Label10.TabIndex = 17
		Me.Label10.Text = "Celular "
		'
		'tbcodcel
		'
		Me.tbcodcel.Location = New System.Drawing.Point(215, 17)
		Me.tbcodcel.Margin = New System.Windows.Forms.Padding(4)
		Me.tbcodcel.MaxLength = 4
		Me.tbcodcel.Name = "tbcodcel"
		Me.tbcodcel.Size = New System.Drawing.Size(65, 23)
		Me.tbcodcel.TabIndex = 21
		'
		'tbcel
		'
		Me.tbcel.Location = New System.Drawing.Point(311, 17)
		Me.tbcel.Margin = New System.Windows.Forms.Padding(4)
		Me.tbcel.MaxLength = 12
		Me.tbcel.Name = "tbcel"
		Me.tbcel.Size = New System.Drawing.Size(239, 23)
		Me.tbcel.TabIndex = 22
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(287, 20)
		Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(14, 17)
		Me.Label14.TabIndex = 14
		Me.Label14.Text = "-"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(716, 17)
		Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(72, 17)
		Me.Label13.TabIndex = 7
		Me.Label13.Text = "Telefono"
		'
		'tbcodtel
		'
		Me.tbcodtel.Location = New System.Drawing.Point(796, 14)
		Me.tbcodtel.Margin = New System.Windows.Forms.Padding(4)
		Me.tbcodtel.MaxLength = 4
		Me.tbcodtel.Name = "tbcodtel"
		Me.tbcodtel.Size = New System.Drawing.Size(55, 23)
		Me.tbcodtel.TabIndex = 23
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label12)
		Me.GroupBox2.Controls.Add(Me.txtBarrio)
		Me.GroupBox2.Controls.Add(Me.Label3)
		Me.GroupBox2.Controls.Add(Me.txtPiso)
		Me.GroupBox2.Controls.Add(Me.Label2)
		Me.GroupBox2.Controls.Add(Me.txtManzana)
		Me.GroupBox2.Controls.Add(Me.Label1)
		Me.GroupBox2.Controls.Add(Me.txtLote)
		Me.GroupBox2.Controls.Add(Me.Label8)
		Me.GroupBox2.Controls.Add(Me.Label7)
		Me.GroupBox2.Controls.Add(Me.cmbLocalidades)
		Me.GroupBox2.Controls.Add(Me.cmbProvincias)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Controls.Add(Me.tbcalle)
		Me.GroupBox2.Controls.Add(Me.tbNro)
		Me.GroupBox2.Controls.Add(Me.tbDpto)
		Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox2.ForeColor = System.Drawing.Color.Black
		Me.GroupBox2.Location = New System.Drawing.Point(12, 191)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox2.Size = New System.Drawing.Size(1232, 106)
		Me.GroupBox2.TabIndex = 12
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Domicilio"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(960, 65)
		Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(52, 17)
		Me.Label12.TabIndex = 21
		Me.Label12.Text = "Barrio"
		'
		'txtBarrio
		'
		Me.txtBarrio.Location = New System.Drawing.Point(1021, 63)
		Me.txtBarrio.Margin = New System.Windows.Forms.Padding(4)
		Me.txtBarrio.MaxLength = 50
		Me.txtBarrio.Name = "txtBarrio"
		Me.txtBarrio.Size = New System.Drawing.Size(169, 23)
		Me.txtBarrio.TabIndex = 20
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(652, 30)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(39, 17)
		Me.Label3.TabIndex = 19
		Me.Label3.Text = "Piso"
		'
		'txtPiso
		'
		Me.txtPiso.Location = New System.Drawing.Point(697, 27)
		Me.txtPiso.Margin = New System.Windows.Forms.Padding(4)
		Me.txtPiso.MaxLength = 2
		Me.txtPiso.Name = "txtPiso"
		Me.txtPiso.Size = New System.Drawing.Size(33, 23)
		Me.txtPiso.TabIndex = 11
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(803, 66)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(73, 17)
		Me.Label2.TabIndex = 17
		Me.Label2.Text = "Manzana"
		'
		'txtManzana
		'
		Me.txtManzana.Location = New System.Drawing.Point(888, 63)
		Me.txtManzana.Margin = New System.Windows.Forms.Padding(4)
		Me.txtManzana.MaxLength = 5
		Me.txtManzana.Name = "txtManzana"
		Me.txtManzana.Size = New System.Drawing.Size(57, 23)
		Me.txtManzana.TabIndex = 19
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(951, 34)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(40, 17)
		Me.Label1.TabIndex = 15
		Me.Label1.Text = "Lote"
		'
		'txtLote
		'
		Me.txtLote.Location = New System.Drawing.Point(999, 31)
		Me.txtLote.Margin = New System.Windows.Forms.Padding(4)
		Me.txtLote.MaxLength = 3
		Me.txtLote.Name = "txtLote"
		Me.txtLote.Size = New System.Drawing.Size(57, 23)
		Me.txtLote.TabIndex = 13
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(464, 64)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(78, 17)
		Me.Label8.TabIndex = 13
		Me.Label8.Text = "Localidad"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(123, 64)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(80, 17)
		Me.Label7.TabIndex = 12
		Me.Label7.Text = "Provincia "
		'
		'cmbLocalidades
		'
		Me.cmbLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbLocalidades.FormattingEnabled = True
		Me.cmbLocalidades.ItemHeight = 17
		Me.cmbLocalidades.Location = New System.Drawing.Point(551, 62)
		Me.cmbLocalidades.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbLocalidades.Name = "cmbLocalidades"
		Me.cmbLocalidades.Size = New System.Drawing.Size(213, 25)
		Me.cmbLocalidades.TabIndex = 7
		'
		'cmbProvincias
		'
		Me.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbProvincias.FormattingEnabled = True
		Me.cmbProvincias.ItemHeight = 17
		Me.cmbProvincias.Location = New System.Drawing.Point(216, 62)
		Me.cmbProvincias.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbProvincias.Name = "cmbProvincias"
		Me.cmbProvincias.Size = New System.Drawing.Size(232, 25)
		Me.cmbProvincias.TabIndex = 6
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(757, 31)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(110, 17)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "Departamento"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(505, 30)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(69, 17)
		Me.Label5.TabIndex = 8
		Me.Label5.Text = "Numero "
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(123, 31)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(49, 17)
		Me.Label4.TabIndex = 7
		Me.Label4.Text = "Calle "
		'
		'tbcalle
		'
		Me.tbcalle.Location = New System.Drawing.Point(183, 28)
		Me.tbcalle.Margin = New System.Windows.Forms.Padding(4)
		Me.tbcalle.MaxLength = 30
		Me.tbcalle.Name = "tbcalle"
		Me.tbcalle.Size = New System.Drawing.Size(315, 23)
		Me.tbcalle.TabIndex = 9
		'
		'tbNro
		'
		Me.tbNro.Location = New System.Drawing.Point(588, 25)
		Me.tbNro.Margin = New System.Windows.Forms.Padding(4)
		Me.tbNro.MaxLength = 5
		Me.tbNro.Name = "tbNro"
		Me.tbNro.Size = New System.Drawing.Size(57, 23)
		Me.tbNro.TabIndex = 10
		'
		'tbDpto
		'
		Me.tbDpto.Location = New System.Drawing.Point(875, 28)
		Me.tbDpto.Margin = New System.Windows.Forms.Padding(4)
		Me.tbDpto.MaxLength = 5
		Me.tbDpto.Name = "tbDpto"
		Me.tbDpto.Size = New System.Drawing.Size(51, 23)
		Me.tbDpto.TabIndex = 12
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.btnBuscar)
		Me.GroupBox5.Controls.Add(Me.cboBusTipoPersona)
		Me.GroupBox5.Controls.Add(Me.txtBusApellido)
		Me.GroupBox5.Controls.Add(Me.Label17)
		Me.GroupBox5.Controls.Add(Me.lblBusApellido)
		Me.GroupBox5.Controls.Add(Me.txtBusNombre)
		Me.GroupBox5.Controls.Add(Me.lblBusNombre)
		Me.GroupBox5.Controls.Add(Me.txtBusDocNro)
		Me.GroupBox5.Controls.Add(Me.cboBusTipoDNI)
		Me.GroupBox5.Controls.Add(Me.Label15)
		Me.GroupBox5.Controls.Add(Me.Label16)
		Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox5.Location = New System.Drawing.Point(65, 382)
		Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox5.Size = New System.Drawing.Size(608, 182)
		Me.GroupBox5.TabIndex = 22
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Búsqueda"
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
		Me.btnBuscar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.loupe_78956__1_
		Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnBuscar.FlatAppearance.BorderSize = 0
		Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscar.Location = New System.Drawing.Point(460, 38)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(137, 110)
		Me.btnBuscar.TabIndex = 33
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'cboBusTipoPersona
		'
		Me.cboBusTipoPersona.AccessibleDescription = ""
		Me.cboBusTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboBusTipoPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboBusTipoPersona.FormattingEnabled = True
		Me.cboBusTipoPersona.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboBusTipoPersona.Location = New System.Drawing.Point(256, 21)
		Me.cboBusTipoPersona.Margin = New System.Windows.Forms.Padding(4)
		Me.cboBusTipoPersona.Name = "cboBusTipoPersona"
		Me.cboBusTipoPersona.Size = New System.Drawing.Size(187, 25)
		Me.cboBusTipoPersona.TabIndex = 28
		'
		'txtBusApellido
		'
		Me.txtBusApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBusApellido.Location = New System.Drawing.Point(257, 151)
		Me.txtBusApellido.Margin = New System.Windows.Forms.Padding(4)
		Me.txtBusApellido.MaxLength = 30
		Me.txtBusApellido.Name = "txtBusApellido"
		Me.txtBusApellido.Size = New System.Drawing.Size(187, 23)
		Me.txtBusApellido.TabIndex = 32
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(11, 30)
		Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(127, 17)
		Me.Label17.TabIndex = 21
		Me.Label17.Text = "Tipo de persona"
		'
		'lblBusApellido
		'
		Me.lblBusApellido.AutoSize = True
		Me.lblBusApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBusApellido.Location = New System.Drawing.Point(11, 151)
		Me.lblBusApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblBusApellido.Name = "lblBusApellido"
		Me.lblBusApellido.Size = New System.Drawing.Size(177, 17)
		Me.lblBusApellido.TabIndex = 27
		Me.lblBusApellido.Text = "Apellido - Razon Social"
		'
		'txtBusNombre
		'
		Me.txtBusNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBusNombre.Location = New System.Drawing.Point(256, 121)
		Me.txtBusNombre.Margin = New System.Windows.Forms.Padding(4)
		Me.txtBusNombre.MaxLength = 30
		Me.txtBusNombre.Name = "txtBusNombre"
		Me.txtBusNombre.Size = New System.Drawing.Size(187, 23)
		Me.txtBusNombre.TabIndex = 31
		'
		'lblBusNombre
		'
		Me.lblBusNombre.AutoSize = True
		Me.lblBusNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBusNombre.Location = New System.Drawing.Point(11, 121)
		Me.lblBusNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblBusNombre.Name = "lblBusNombre"
		Me.lblBusNombre.Size = New System.Drawing.Size(222, 17)
		Me.lblBusNombre.TabIndex = 25
		Me.lblBusNombre.Text = "Nombre - Nombre de fantasía"
		'
		'txtBusDocNro
		'
		Me.txtBusDocNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBusDocNro.Location = New System.Drawing.Point(257, 87)
		Me.txtBusDocNro.Margin = New System.Windows.Forms.Padding(4)
		Me.txtBusDocNro.MaxLength = 12
		Me.txtBusDocNro.Name = "txtBusDocNro"
		Me.txtBusDocNro.Size = New System.Drawing.Size(185, 23)
		Me.txtBusDocNro.TabIndex = 30
		'
		'cboBusTipoDNI
		'
		Me.cboBusTipoDNI.AccessibleDescription = ""
		Me.cboBusTipoDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboBusTipoDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboBusTipoDNI.FormattingEnabled = True
		Me.cboBusTipoDNI.Location = New System.Drawing.Point(257, 54)
		Me.cboBusTipoDNI.Margin = New System.Windows.Forms.Padding(4)
		Me.cboBusTipoDNI.Name = "cboBusTipoDNI"
		Me.cboBusTipoDNI.Size = New System.Drawing.Size(185, 25)
		Me.cboBusTipoDNI.TabIndex = 29
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Location = New System.Drawing.Point(11, 86)
		Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(165, 17)
		Me.Label15.TabIndex = 23
		Me.Label15.Text = "Numero Identificacion"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Location = New System.Drawing.Point(11, 57)
		Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(141, 17)
		Me.Label16.TabIndex = 21
		Me.Label16.Text = "Tipo Identificación"
		'
		'Dgvclientes
		'
		Me.Dgvclientes.AllowUserToAddRows = False
		Me.Dgvclientes.AllowUserToDeleteRows = False
		Me.Dgvclientes.AllowUserToResizeColumns = False
		Me.Dgvclientes.AllowUserToResizeRows = False
		Me.Dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.Dgvclientes.Location = New System.Drawing.Point(51, 571)
		Me.Dgvclientes.Margin = New System.Windows.Forms.Padding(4)
		Me.Dgvclientes.MultiSelect = False
		Me.Dgvclientes.Name = "Dgvclientes"
		Me.Dgvclientes.ReadOnly = True
		Me.Dgvclientes.RowHeadersVisible = False
		Me.Dgvclientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
		Me.Dgvclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.Dgvclientes.Size = New System.Drawing.Size(1180, 251)
		Me.Dgvclientes.TabIndex = 23
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Control
		Me.btnLimpiar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_cancel_62
		Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnLimpiar.FlatAppearance.BorderSize = 0
		Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLimpiar.Location = New System.Drawing.Point(837, 422)
		Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(115, 110)
		Me.btnLimpiar.TabIndex = 29
		Me.btnLimpiar.Text = "Limpiar"
		Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnLimpiar.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.Control
		Me.Button1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_checklist_62
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(1239, 571)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(107, 110)
		Me.Button1.TabIndex = 28
		Me.Button1.Text = "Listar"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button1.UseVisualStyleBackColor = False
		'
		'btnNuevo
		'
		Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevo.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
		Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevo.FlatAppearance.BorderSize = 0
		Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevo.Location = New System.Drawing.Point(671, 420)
		Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevo.Name = "btnNuevo"
		Me.btnNuevo.Size = New System.Drawing.Size(137, 112)
		Me.btnNuevo.TabIndex = 26
		Me.btnNuevo.Text = "Nuevo"
		Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevo.UseVisualStyleBackColor = False
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
		Me.btnGuardar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_save_62
		Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnGuardar.FlatAppearance.BorderSize = 0
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Location = New System.Drawing.Point(984, 422)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(115, 110)
		Me.btnGuardar.TabIndex = 25
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Location = New System.Drawing.Point(1239, 713)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(107, 110)
		Me.btnSalir.TabIndex = 27
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'FrmGestionCliente
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1353, 837)
		Me.ControlBox = False
		Me.Controls.Add(Me.btnLimpiar)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Dgvclientes)
		Me.Controls.Add(Me.GroupBox5)
		Me.Controls.Add(Me.btnNuevo)
		Me.Controls.Add(Me.btnGuardar)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.Name = "FrmGestionCliente"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FrmGestionCliente"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox6.ResumeLayout(False)
		Me.GroupBox6.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		CType(Me.Dgvclientes, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents btnGuardar As Windows.Forms.Button
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
	Friend WithEvents dtpfechanac As Windows.Forms.DateTimePicker
	Friend WithEvents lblFechaNac As Windows.Forms.Label
	Friend WithEvents tbNroDoc As Windows.Forms.TextBox
	Friend WithEvents lblNumIdent As Windows.Forms.Label
	Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
	Friend WithEvents tbtelefono As Windows.Forms.TextBox
	Friend WithEvents Label11 As Windows.Forms.Label
	Friend WithEvents tbmail As Windows.Forms.TextBox
	Friend WithEvents Label9 As Windows.Forms.Label
	Friend WithEvents Label10 As Windows.Forms.Label
	Friend WithEvents tbcodcel As Windows.Forms.TextBox
	Friend WithEvents tbcel As Windows.Forms.TextBox
	Friend WithEvents Label14 As Windows.Forms.Label
	Friend WithEvents Label13 As Windows.Forms.Label
	Friend WithEvents tbcodtel As Windows.Forms.TextBox
	Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
	Friend WithEvents Label8 As Windows.Forms.Label
	Friend WithEvents Label7 As Windows.Forms.Label
	Friend WithEvents cmbLocalidades As Windows.Forms.ComboBox
	Friend WithEvents cmbProvincias As Windows.Forms.ComboBox
	Friend WithEvents Label6 As Windows.Forms.Label
	Friend WithEvents Label5 As Windows.Forms.Label
	Friend WithEvents Label4 As Windows.Forms.Label
	Friend WithEvents tbcalle As Windows.Forms.TextBox
	Friend WithEvents tbNro As Windows.Forms.TextBox
	Friend WithEvents tbDpto As Windows.Forms.TextBox
	Friend WithEvents lblRazonSoc As Windows.Forms.Label
	Friend WithEvents cbtipodni As Windows.Forms.ComboBox
	Friend WithEvents lblTipoIdentificacion As Windows.Forms.Label
	Friend WithEvents tbApellido As Windows.Forms.TextBox
	Friend WithEvents tbNombre As Windows.Forms.TextBox
	Friend WithEvents lblNombreFanta As Windows.Forms.Label
	Friend WithEvents cboTipoPersona As Windows.Forms.ComboBox
	Friend WithEvents lblTipoDePersona As Windows.Forms.Label
	Friend WithEvents lblNombre As Windows.Forms.Label
	Friend WithEvents lblApellido As Windows.Forms.Label
	Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
	Friend WithEvents lblInicioAct As Windows.Forms.Label
	Friend WithEvents Label12 As Windows.Forms.Label
	Friend WithEvents txtBarrio As Windows.Forms.TextBox
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents txtPiso As Windows.Forms.TextBox
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents txtManzana As Windows.Forms.TextBox
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents txtLote As Windows.Forms.TextBox
	Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
	Friend WithEvents txtBusApellido As Windows.Forms.TextBox
	Friend WithEvents lblBusApellido As Windows.Forms.Label
	Friend WithEvents txtBusNombre As Windows.Forms.TextBox
	Friend WithEvents lblBusNombre As Windows.Forms.Label
	Friend WithEvents txtBusDocNro As Windows.Forms.TextBox
	Friend WithEvents cboBusTipoDNI As Windows.Forms.ComboBox
	Friend WithEvents Label15 As Windows.Forms.Label
	Friend WithEvents Label16 As Windows.Forms.Label
	Friend WithEvents btnBuscar As Windows.Forms.Button
	Friend WithEvents cboBusTipoPersona As Windows.Forms.ComboBox
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents GroupBox6 As Windows.Forms.GroupBox
	Friend WithEvents Dgvclientes As Windows.Forms.DataGridView
	Friend WithEvents btnValidarDNI1 As Windows.Forms.Button
	Friend WithEvents Button1 As Windows.Forms.Button
	Friend WithEvents btnLimpiar As Windows.Forms.Button
End Class
