<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionProveedores
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
        Me.tbcel = New System.Windows.Forms.TextBox()
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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Dgvproveedores = New System.Windows.Forms.DataGridView()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblInicioAct = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblNombreFanta = New System.Windows.Forms.Label()
        Me.tbmail = New System.Windows.Forms.TextBox()
        Me.dtpfechanac = New System.Windows.Forms.DateTimePicker()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.lblFechaNac = New System.Windows.Forms.Label()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.lblRazonSoc = New System.Windows.Forms.Label()
        Me.tbNroDoc = New System.Windows.Forms.TextBox()
        Me.cbtipodni = New System.Windows.Forms.ComboBox()
        Me.lblTipoDePersona = New System.Windows.Forms.Label()
        Me.btnValidarDNI1 = New System.Windows.Forms.Button()
        Me.lblTipoIdentificacion = New System.Windows.Forms.Label()
        Me.cboTipoPersona = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblNumIdent = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbtelefono = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbcodcel = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Dgvproveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcel
        '
        Me.tbcel.Location = New System.Drawing.Point(233, 14)
        Me.tbcel.MaxLength = 12
        Me.tbcel.Name = "tbcel"
        Me.tbcel.Size = New System.Drawing.Size(180, 20)
        Me.tbcel.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(537, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Telefono"
        '
        'tbcodtel
        '
        Me.tbcodtel.Location = New System.Drawing.Point(597, 11)
        Me.tbcodtel.MaxLength = 4
        Me.tbcodtel.Name = "tbcodtel"
        Me.tbcodtel.Size = New System.Drawing.Size(42, 20)
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
        Me.GroupBox2.Location = New System.Drawing.Point(9, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(924, 86)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Domicilio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(720, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Barrio"
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(766, 51)
        Me.txtBarrio.MaxLength = 50
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(128, 20)
        Me.txtBarrio.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(489, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Piso"
        '
        'txtPiso
        '
        Me.txtPiso.Location = New System.Drawing.Point(523, 22)
        Me.txtPiso.MaxLength = 2
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New System.Drawing.Size(26, 20)
        Me.txtPiso.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(602, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Manzana"
        '
        'txtManzana
        '
        Me.txtManzana.Location = New System.Drawing.Point(666, 51)
        Me.txtManzana.MaxLength = 5
        Me.txtManzana.Name = "txtManzana"
        Me.txtManzana.Size = New System.Drawing.Size(44, 20)
        Me.txtManzana.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(713, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Lote"
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(749, 25)
        Me.txtLote.MaxLength = 3
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(44, 20)
        Me.txtLote.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(348, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Localidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Provincia "
        '
        'cmbLocalidades
        '
        Me.cmbLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocalidades.FormattingEnabled = True
        Me.cmbLocalidades.ItemHeight = 13
        Me.cmbLocalidades.Location = New System.Drawing.Point(413, 50)
        Me.cmbLocalidades.Name = "cmbLocalidades"
        Me.cmbLocalidades.Size = New System.Drawing.Size(161, 21)
        Me.cmbLocalidades.TabIndex = 7
        '
        'cmbProvincias
        '
        Me.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvincias.FormattingEnabled = True
        Me.cmbProvincias.ItemHeight = 13
        Me.cmbProvincias.Location = New System.Drawing.Point(162, 50)
        Me.cmbProvincias.Name = "cmbProvincias"
        Me.cmbProvincias.Size = New System.Drawing.Size(175, 21)
        Me.cmbProvincias.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(568, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Departamento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(379, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Numero "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Calle "
        '
        'tbcalle
        '
        Me.tbcalle.Location = New System.Drawing.Point(137, 23)
        Me.tbcalle.MaxLength = 30
        Me.tbcalle.Name = "tbcalle"
        Me.tbcalle.Size = New System.Drawing.Size(237, 20)
        Me.tbcalle.TabIndex = 9
        '
        'tbNro
        '
        Me.tbNro.Location = New System.Drawing.Point(441, 20)
        Me.tbNro.MaxLength = 5
        Me.tbNro.Name = "tbNro"
        Me.tbNro.Size = New System.Drawing.Size(44, 20)
        Me.tbNro.TabIndex = 10
        '
        'tbDpto
        '
        Me.tbDpto.Location = New System.Drawing.Point(656, 23)
        Me.tbDpto.MaxLength = 5
        Me.tbDpto.Name = "tbDpto"
        Me.tbDpto.Size = New System.Drawing.Size(39, 20)
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
        Me.GroupBox5.Location = New System.Drawing.Point(10, 309)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(456, 148)
        Me.GroupBox5.TabIndex = 31
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
        Me.btnBuscar.Location = New System.Drawing.Point(345, 31)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(103, 89)
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
        Me.cboBusTipoPersona.Location = New System.Drawing.Point(192, 17)
        Me.cboBusTipoPersona.Name = "cboBusTipoPersona"
        Me.cboBusTipoPersona.Size = New System.Drawing.Size(141, 21)
        Me.cboBusTipoPersona.TabIndex = 28
        '
        'txtBusApellido
        '
        Me.txtBusApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusApellido.Location = New System.Drawing.Point(193, 123)
        Me.txtBusApellido.MaxLength = 30
        Me.txtBusApellido.Name = "txtBusApellido"
        Me.txtBusApellido.Size = New System.Drawing.Size(141, 20)
        Me.txtBusApellido.TabIndex = 32
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Tipo de persona"
        '
        'lblBusApellido
        '
        Me.lblBusApellido.AutoSize = True
        Me.lblBusApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusApellido.Location = New System.Drawing.Point(8, 123)
        Me.lblBusApellido.Name = "lblBusApellido"
        Me.lblBusApellido.Size = New System.Drawing.Size(139, 13)
        Me.lblBusApellido.TabIndex = 27
        Me.lblBusApellido.Text = "Apellido - Razon Social"
        '
        'txtBusNombre
        '
        Me.txtBusNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusNombre.Location = New System.Drawing.Point(192, 98)
        Me.txtBusNombre.MaxLength = 30
        Me.txtBusNombre.Name = "txtBusNombre"
        Me.txtBusNombre.Size = New System.Drawing.Size(141, 20)
        Me.txtBusNombre.TabIndex = 31
        '
        'lblBusNombre
        '
        Me.lblBusNombre.AutoSize = True
        Me.lblBusNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusNombre.Location = New System.Drawing.Point(8, 98)
        Me.lblBusNombre.Name = "lblBusNombre"
        Me.lblBusNombre.Size = New System.Drawing.Size(174, 13)
        Me.lblBusNombre.TabIndex = 25
        Me.lblBusNombre.Text = "Nombre - Nombre de fantasía"
        '
        'txtBusDocNro
        '
        Me.txtBusDocNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusDocNro.Location = New System.Drawing.Point(193, 71)
        Me.txtBusDocNro.MaxLength = 12
        Me.txtBusDocNro.Name = "txtBusDocNro"
        Me.txtBusDocNro.Size = New System.Drawing.Size(140, 20)
        Me.txtBusDocNro.TabIndex = 30
        '
        'cboBusTipoDNI
        '
        Me.cboBusTipoDNI.AccessibleDescription = ""
        Me.cboBusTipoDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBusTipoDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBusTipoDNI.FormattingEnabled = True
        Me.cboBusTipoDNI.Location = New System.Drawing.Point(193, 44)
        Me.cboBusTipoDNI.Name = "cboBusTipoDNI"
        Me.cboBusTipoDNI.Size = New System.Drawing.Size(140, 21)
        Me.cboBusTipoDNI.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 70)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Numero Identificacion"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Tipo Identificación"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_save_62
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(699, 341)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 89)
        Me.btnGuardar.TabIndex = 33
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(215, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "-"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Control
        Me.btnLimpiar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_cancel_62
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(589, 341)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(86, 89)
        Me.btnLimpiar.TabIndex = 37
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
        Me.Button1.Location = New System.Drawing.Point(890, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 89)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Listar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Dgvproveedores
        '
        Me.Dgvproveedores.AllowUserToAddRows = False
        Me.Dgvproveedores.AllowUserToDeleteRows = False
        Me.Dgvproveedores.AllowUserToResizeColumns = False
        Me.Dgvproveedores.AllowUserToResizeRows = False
        Me.Dgvproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvproveedores.Location = New System.Drawing.Point(16, 462)
        Me.Dgvproveedores.MultiSelect = False
        Me.Dgvproveedores.Name = "Dgvproveedores"
        Me.Dgvproveedores.ReadOnly = True
        Me.Dgvproveedores.RowHeadersVisible = False
        Me.Dgvproveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dgvproveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgvproveedores.Size = New System.Drawing.Size(868, 204)
        Me.Dgvproveedores.TabIndex = 32
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Location = New System.Drawing.Point(464, 340)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(103, 91)
        Me.btnNuevo.TabIndex = 34
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(890, 578)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 89)
        Me.btnSalir.TabIndex = 35
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblInicioAct
        '
        Me.lblInicioAct.AutoSize = True
        Me.lblInicioAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicioAct.Location = New System.Drawing.Point(519, 23)
        Me.lblInicioAct.Name = "lblInicioAct"
        Me.lblInicioAct.Size = New System.Drawing.Size(112, 13)
        Me.lblInicioAct.TabIndex = 23
        Me.lblInicioAct.Text = "Inicio Actividades "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(100, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "E-Mail "
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(100, 48)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(54, 13)
        Me.lblNombre.TabIndex = 21
        Me.lblNombre.Text = "Nombre "
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
        Me.GroupBox4.Location = New System.Drawing.Point(6, 81)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(927, 75)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(493, 49)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(56, 13)
        Me.lblApellido.TabIndex = 22
        Me.lblApellido.Text = "Apellido "
        '
        'lblNombreFanta
        '
        Me.lblNombreFanta.AutoSize = True
        Me.lblNombreFanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreFanta.Location = New System.Drawing.Point(96, 48)
        Me.lblNombreFanta.Name = "lblNombreFanta"
        Me.lblNombreFanta.Size = New System.Drawing.Size(122, 13)
        Me.lblNombreFanta.TabIndex = 0
        Me.lblNombreFanta.Text = "Nombre de Fantasía"
        '
        'tbmail
        '
        Me.tbmail.Location = New System.Drawing.Point(218, 17)
        Me.tbmail.MaxLength = 40
        Me.tbmail.Name = "tbmail"
        Me.tbmail.Size = New System.Drawing.Size(205, 20)
        Me.tbmail.TabIndex = 5
        '
        'dtpfechanac
        '
        Me.dtpfechanac.CustomFormat = "dd/MM/yyy"
        Me.dtpfechanac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfechanac.Location = New System.Drawing.Point(648, 18)
        Me.dtpfechanac.Name = "dtpfechanac"
        Me.dtpfechanac.Size = New System.Drawing.Size(162, 20)
        Me.dtpfechanac.TabIndex = 7
        Me.dtpfechanac.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(228, 46)
        Me.tbNombre.MaxLength = 30
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(232, 20)
        Me.tbNombre.TabIndex = 6
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.Location = New System.Drawing.Point(519, 22)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(109, 13)
        Me.lblFechaNac.TabIndex = 17
        Me.lblFechaNac.Text = "Fecha Nacimiento"
        '
        'tbApellido
        '
        Me.tbApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellido.Location = New System.Drawing.Point(568, 42)
        Me.tbApellido.MaxLength = 30
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(242, 20)
        Me.tbApellido.TabIndex = 8
        '
        'lblRazonSoc
        '
        Me.lblRazonSoc.AutoSize = True
        Me.lblRazonSoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSoc.Location = New System.Drawing.Point(471, 48)
        Me.lblRazonSoc.Name = "lblRazonSoc"
        Me.lblRazonSoc.Size = New System.Drawing.Size(86, 13)
        Me.lblRazonSoc.TabIndex = 11
        Me.lblRazonSoc.Text = "Razón Social "
        '
        'tbNroDoc
        '
        Me.tbNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNroDoc.Location = New System.Drawing.Point(527, 38)
        Me.tbNroDoc.MaxLength = 12
        Me.tbNroDoc.Name = "tbNroDoc"
        Me.tbNroDoc.Size = New System.Drawing.Size(133, 20)
        Me.tbNroDoc.TabIndex = 3
        '
        'cbtipodni
        '
        Me.cbtipodni.AccessibleDescription = ""
        Me.cbtipodni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtipodni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbtipodni.FormattingEnabled = True
        Me.cbtipodni.Location = New System.Drawing.Point(215, 38)
        Me.cbtipodni.Name = "cbtipodni"
        Me.cbtipodni.Size = New System.Drawing.Size(149, 21)
        Me.cbtipodni.TabIndex = 2
        '
        'lblTipoDePersona
        '
        Me.lblTipoDePersona.AutoSize = True
        Me.lblTipoDePersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDePersona.Location = New System.Drawing.Point(92, 14)
        Me.lblTipoDePersona.Name = "lblTipoDePersona"
        Me.lblTipoDePersona.Size = New System.Drawing.Size(108, 13)
        Me.lblTipoDePersona.TabIndex = 19
        Me.lblTipoDePersona.Text = "Tipo de persona *"
        '
        'btnValidarDNI1
        '
        Me.btnValidarDNI1.BackColor = System.Drawing.SystemColors.Control
        Me.btnValidarDNI1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_approval_48
        Me.btnValidarDNI1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnValidarDNI1.FlatAppearance.BorderSize = 0
        Me.btnValidarDNI1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidarDNI1.Location = New System.Drawing.Point(666, 11)
        Me.btnValidarDNI1.Name = "btnValidarDNI1"
        Me.btnValidarDNI1.Size = New System.Drawing.Size(163, 49)
        Me.btnValidarDNI1.TabIndex = 4
        Me.btnValidarDNI1.Text = "Verificar "
        Me.btnValidarDNI1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnValidarDNI1.UseVisualStyleBackColor = False
        '
        'lblTipoIdentificacion
        '
        Me.lblTipoIdentificacion.AutoSize = True
        Me.lblTipoIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoIdentificacion.Location = New System.Drawing.Point(92, 41)
        Me.lblTipoIdentificacion.Name = "lblTipoIdentificacion"
        Me.lblTipoIdentificacion.Size = New System.Drawing.Size(122, 13)
        Me.lblTipoIdentificacion.TabIndex = 9
        Me.lblTipoIdentificacion.Text = "Tipo Identificación *"
        '
        'cboTipoPersona
        '
        Me.cboTipoPersona.AccessibleDescription = ""
        Me.cboTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPersona.FormattingEnabled = True
        Me.cboTipoPersona.Location = New System.Drawing.Point(215, 14)
        Me.cboTipoPersona.Name = "cboTipoPersona"
        Me.cboTipoPersona.Size = New System.Drawing.Size(76, 21)
        Me.cboTipoPersona.TabIndex = 1
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
        Me.GroupBox6.Location = New System.Drawing.Point(9, 15)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(924, 68)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        '
        'lblNumIdent
        '
        Me.lblNumIdent.AutoSize = True
        Me.lblNumIdent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumIdent.Location = New System.Drawing.Point(381, 41)
        Me.lblNumIdent.Name = "lblNumIdent"
        Me.lblNumIdent.Size = New System.Drawing.Size(140, 13)
        Me.lblNumIdent.TabIndex = 15
        Me.lblNumIdent.Text = "Numero Identificacion *"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(954, 292)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = ""
        Me.GroupBox1.Text = "Gestión de Proveedor"
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
        Me.GroupBox3.Location = New System.Drawing.Point(6, 247)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(927, 41)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contacto"
        '
        'tbtelefono
        '
        Me.tbtelefono.Location = New System.Drawing.Point(658, 11)
        Me.tbtelefono.MaxLength = 12
        Me.tbtelefono.Name = "tbtelefono"
        Me.tbtelefono.Size = New System.Drawing.Size(180, 20)
        Me.tbtelefono.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(644, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(98, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Celular "
        '
        'tbcodcel
        '
        Me.tbcodcel.Location = New System.Drawing.Point(161, 14)
        Me.tbcodcel.MaxLength = 4
        Me.tbcodcel.Name = "tbcodcel"
        Me.tbcodcel.Size = New System.Drawing.Size(50, 20)
        Me.tbcodcel.TabIndex = 21
        '
        'FrmGestionProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 680)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Dgvproveedores)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmGestionProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmGestionProveedores"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Dgvproveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcel As Windows.Forms.TextBox
	Friend WithEvents Label13 As Windows.Forms.Label
	Friend WithEvents tbcodtel As Windows.Forms.TextBox
	Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
	Friend WithEvents Label12 As Windows.Forms.Label
	Friend WithEvents txtBarrio As Windows.Forms.TextBox
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents txtPiso As Windows.Forms.TextBox
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents txtManzana As Windows.Forms.TextBox
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents txtLote As Windows.Forms.TextBox
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
	Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
	Friend WithEvents btnBuscar As Windows.Forms.Button
	Friend WithEvents cboBusTipoPersona As Windows.Forms.ComboBox
	Friend WithEvents txtBusApellido As Windows.Forms.TextBox
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents lblBusApellido As Windows.Forms.Label
	Friend WithEvents txtBusNombre As Windows.Forms.TextBox
	Friend WithEvents lblBusNombre As Windows.Forms.Label
	Friend WithEvents txtBusDocNro As Windows.Forms.TextBox
	Friend WithEvents cboBusTipoDNI As Windows.Forms.ComboBox
	Friend WithEvents Label15 As Windows.Forms.Label
	Friend WithEvents Label16 As Windows.Forms.Label
	Friend WithEvents btnGuardar As Windows.Forms.Button
	Friend WithEvents Label14 As Windows.Forms.Label
	Friend WithEvents btnLimpiar As Windows.Forms.Button
	Friend WithEvents Button1 As Windows.Forms.Button
	Friend WithEvents Dgvproveedores As Windows.Forms.DataGridView
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents lblInicioAct As Windows.Forms.Label
	Friend WithEvents Label11 As Windows.Forms.Label
	Friend WithEvents lblNombre As Windows.Forms.Label
	Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
	Friend WithEvents lblApellido As Windows.Forms.Label
	Friend WithEvents lblNombreFanta As Windows.Forms.Label
	Friend WithEvents tbmail As Windows.Forms.TextBox
	Friend WithEvents dtpfechanac As Windows.Forms.DateTimePicker
	Friend WithEvents tbNombre As Windows.Forms.TextBox
	Friend WithEvents lblFechaNac As Windows.Forms.Label
	Friend WithEvents tbApellido As Windows.Forms.TextBox
	Friend WithEvents lblRazonSoc As Windows.Forms.Label
	Friend WithEvents tbNroDoc As Windows.Forms.TextBox
	Friend WithEvents cbtipodni As Windows.Forms.ComboBox
	Friend WithEvents lblTipoDePersona As Windows.Forms.Label
	Friend WithEvents btnValidarDNI1 As Windows.Forms.Button
	Friend WithEvents lblTipoIdentificacion As Windows.Forms.Label
	Friend WithEvents cboTipoPersona As Windows.Forms.ComboBox
	Friend WithEvents GroupBox6 As Windows.Forms.GroupBox
	Friend WithEvents lblNumIdent As Windows.Forms.Label
	Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
	Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
	Friend WithEvents tbtelefono As Windows.Forms.TextBox
	Friend WithEvents Label9 As Windows.Forms.Label
	Friend WithEvents Label10 As Windows.Forms.Label
	Friend WithEvents tbcodcel As Windows.Forms.TextBox
End Class
