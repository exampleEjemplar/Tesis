﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestionCliente))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cboOrden = New System.Windows.Forms.ComboBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblPrioridad3 = New System.Windows.Forms.Label()
        Me.lblPrioridad1 = New System.Windows.Forms.Label()
        Me.lblPrioridad2 = New System.Windows.Forms.Label()
        Me.chbListaParaOrdenar = New System.Windows.Forms.CheckedListBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboBusTipoPersona = New System.Windows.Forms.ComboBox()
        Me.txtBusApellido = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblBusApellido = New System.Windows.Forms.Label()
        Me.txtBusNombre = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblBusNombre = New System.Windows.Forms.Label()
        Me.txtBusDocNro = New System.Windows.Forms.TextBox()
        Me.cboBusTipoDNI = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Dgvclientes = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgvclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox7)
        Me.GroupBox5.Controls.Add(Me.GroupBox8)
        Me.GroupBox5.Controls.Add(Me.btnBuscar)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.cboBusTipoPersona)
        Me.GroupBox5.Controls.Add(Me.txtBusApellido)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.lblBusApellido)
        Me.GroupBox5.Controls.Add(Me.txtBusNombre)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.lblBusNombre)
        Me.GroupBox5.Controls.Add(Me.txtBusDocNro)
        Me.GroupBox5.Controls.Add(Me.cboBusTipoDNI)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(709, 238)
        Me.GroupBox5.TabIndex = 39
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Búsqueda"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cboOrden)
        Me.GroupBox7.Controls.Add(Me.chbListaParaOrdenar)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.Location = New System.Drawing.Point(394, 11)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(180, 136)
        Me.GroupBox7.TabIndex = 45
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Ordenar por"
        '
        'cboOrden
        '
        Me.cboOrden.AccessibleDescription = ""
        Me.cboOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrden.FormattingEnabled = True
        Me.cboOrden.Items.AddRange(New Object() {"Física", "Jurídica"})
        Me.cboOrden.Location = New System.Drawing.Point(52, 106)
        Me.cboOrden.Name = "cboOrden"
        Me.cboOrden.Size = New System.Drawing.Size(58, 21)
        Me.cboOrden.TabIndex = 84
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label18)
        Me.GroupBox8.Controls.Add(Me.Label19)
        Me.GroupBox8.Controls.Add(Me.Label20)
        Me.GroupBox8.Controls.Add(Me.lblPrioridad3)
        Me.GroupBox8.Controls.Add(Me.lblPrioridad1)
        Me.GroupBox8.Controls.Add(Me.lblPrioridad2)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox8.Location = New System.Drawing.Point(578, 11)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Size = New System.Drawing.Size(119, 136)
        Me.GroupBox8.TabIndex = 46
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Prioridad"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Prioridad 3"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 13)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Prioridad 1"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(5, 57)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Prioridad 2"
        '
        'lblPrioridad3
        '
        Me.lblPrioridad3.AutoSize = True
        Me.lblPrioridad3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioridad3.Location = New System.Drawing.Point(15, 113)
        Me.lblPrioridad3.Name = "lblPrioridad3"
        Me.lblPrioridad3.Size = New System.Drawing.Size(57, 13)
        Me.lblPrioridad3.TabIndex = 22
        Me.lblPrioridad3.Text = "Prioridad 3"
        '
        'lblPrioridad1
        '
        Me.lblPrioridad1.AutoSize = True
        Me.lblPrioridad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioridad1.Location = New System.Drawing.Point(15, 35)
        Me.lblPrioridad1.Name = "lblPrioridad1"
        Me.lblPrioridad1.Size = New System.Drawing.Size(57, 13)
        Me.lblPrioridad1.TabIndex = 20
        Me.lblPrioridad1.Text = "Prioridad 1"
        '
        'lblPrioridad2
        '
        Me.lblPrioridad2.AutoSize = True
        Me.lblPrioridad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioridad2.Location = New System.Drawing.Point(15, 75)
        Me.lblPrioridad2.Name = "lblPrioridad2"
        Me.lblPrioridad2.Size = New System.Drawing.Size(57, 13)
        Me.lblPrioridad2.TabIndex = 21
        Me.lblPrioridad2.Text = "Prioridad 2"
        '
        'chbListaParaOrdenar
        '
        Me.chbListaParaOrdenar.FormattingEnabled = True
        Me.chbListaParaOrdenar.Location = New System.Drawing.Point(4, 17)
        Me.chbListaParaOrdenar.Margin = New System.Windows.Forms.Padding(2)
        Me.chbListaParaOrdenar.Name = "chbListaParaOrdenar"
        Me.chbListaParaOrdenar.Size = New System.Drawing.Size(171, 84)
        Me.chbListaParaOrdenar.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(5, 109)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 13)
        Me.Label21.TabIndex = 83
        Me.Label21.Text = "Orden"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(456, 152)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(69, 80)
        Me.btnBuscar.TabIndex = 33
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(531, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 80)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Listar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cboBusTipoPersona
        '
        Me.cboBusTipoPersona.AccessibleDescription = ""
        Me.cboBusTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBusTipoPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBusTipoPersona.FormattingEnabled = True
        Me.cboBusTipoPersona.Items.AddRange(New Object() {"Física", "Jurídica"})
        Me.cboBusTipoPersona.Location = New System.Drawing.Point(167, 15)
        Me.cboBusTipoPersona.Name = "cboBusTipoPersona"
        Me.cboBusTipoPersona.Size = New System.Drawing.Size(209, 21)
        Me.cboBusTipoPersona.TabIndex = 28
        '
        'txtBusApellido
        '
        Me.txtBusApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusApellido.Location = New System.Drawing.Point(167, 123)
        Me.txtBusApellido.MaxLength = 30
        Me.txtBusApellido.Name = "txtBusApellido"
        Me.txtBusApellido.Size = New System.Drawing.Size(209, 20)
        Me.txtBusApellido.TabIndex = 32
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Tipo de persona"
        '
        'lblBusApellido
        '
        Me.lblBusApellido.AutoSize = True
        Me.lblBusApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusApellido.Location = New System.Drawing.Point(8, 126)
        Me.lblBusApellido.Name = "lblBusApellido"
        Me.lblBusApellido.Size = New System.Drawing.Size(139, 13)
        Me.lblBusApellido.TabIndex = 27
        Me.lblBusApellido.Text = "Apellido - Razon Social"
        '
        'txtBusNombre
        '
        Me.txtBusNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusNombre.Location = New System.Drawing.Point(167, 97)
        Me.txtBusNombre.MaxLength = 30
        Me.txtBusNombre.Name = "txtBusNombre"
        Me.txtBusNombre.Size = New System.Drawing.Size(209, 20)
        Me.txtBusNombre.TabIndex = 31
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(611, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 80)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Estadísticas"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblBusNombre
        '
        Me.lblBusNombre.AutoSize = True
        Me.lblBusNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusNombre.Location = New System.Drawing.Point(8, 100)
        Me.lblBusNombre.Name = "lblBusNombre"
        Me.lblBusNombre.Size = New System.Drawing.Size(153, 13)
        Me.lblBusNombre.TabIndex = 25
        Me.lblBusNombre.Text = "Nombre - Nombre de fant."
        '
        'txtBusDocNro
        '
        Me.txtBusDocNro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusDocNro.Location = New System.Drawing.Point(167, 71)
        Me.txtBusDocNro.MaxLength = 12
        Me.txtBusDocNro.Name = "txtBusDocNro"
        Me.txtBusDocNro.Size = New System.Drawing.Size(209, 20)
        Me.txtBusDocNro.TabIndex = 30
        '
        'cboBusTipoDNI
        '
        Me.cboBusTipoDNI.AccessibleDescription = ""
        Me.cboBusTipoDNI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBusTipoDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBusTipoDNI.FormattingEnabled = True
        Me.cboBusTipoDNI.Location = New System.Drawing.Point(167, 43)
        Me.cboBusTipoDNI.Name = "cboBusTipoDNI"
        Me.cboBusTipoDNI.Size = New System.Drawing.Size(209, 21)
        Me.cboBusTipoDNI.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "Numero Identificacion"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Tipo Identificación"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 370)
        Me.GroupBox1.TabIndex = 38
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
        Me.GroupBox6.Location = New System.Drawing.Point(9, 15)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(634, 68)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        '
        'btnValidarDNI1
        '
        Me.btnValidarDNI1.BackColor = System.Drawing.SystemColors.Control
        Me.btnValidarDNI1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnValidarDNI1.FlatAppearance.BorderSize = 0
        Me.btnValidarDNI1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidarDNI1.Image = CType(resources.GetObject("btnValidarDNI1.Image"), System.Drawing.Image)
        Me.btnValidarDNI1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnValidarDNI1.Location = New System.Drawing.Point(522, 20)
        Me.btnValidarDNI1.Name = "btnValidarDNI1"
        Me.btnValidarDNI1.Size = New System.Drawing.Size(103, 37)
        Me.btnValidarDNI1.TabIndex = 4
        Me.btnValidarDNI1.Text = "Verificar "
        Me.btnValidarDNI1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnValidarDNI1.UseVisualStyleBackColor = False
        '
        'lblTipoIdentificacion
        '
        Me.lblTipoIdentificacion.AutoSize = True
        Me.lblTipoIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoIdentificacion.Location = New System.Drawing.Point(9, 42)
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
        Me.cboTipoPersona.Location = New System.Drawing.Point(132, 11)
        Me.cboTipoPersona.Name = "cboTipoPersona"
        Me.cboTipoPersona.Size = New System.Drawing.Size(99, 21)
        Me.cboTipoPersona.TabIndex = 1
        '
        'cbtipodni
        '
        Me.cbtipodni.AccessibleDescription = ""
        Me.cbtipodni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtipodni.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbtipodni.FormattingEnabled = True
        Me.cbtipodni.Location = New System.Drawing.Point(132, 38)
        Me.cbtipodni.Name = "cbtipodni"
        Me.cbtipodni.Size = New System.Drawing.Size(99, 21)
        Me.cbtipodni.TabIndex = 2
        '
        'lblTipoDePersona
        '
        Me.lblTipoDePersona.AutoSize = True
        Me.lblTipoDePersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoDePersona.Location = New System.Drawing.Point(9, 14)
        Me.lblTipoDePersona.Name = "lblTipoDePersona"
        Me.lblTipoDePersona.Size = New System.Drawing.Size(108, 13)
        Me.lblTipoDePersona.TabIndex = 19
        Me.lblTipoDePersona.Text = "Tipo de persona *"
        '
        'lblNumIdent
        '
        Me.lblNumIdent.AutoSize = True
        Me.lblNumIdent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumIdent.Location = New System.Drawing.Point(234, 42)
        Me.lblNumIdent.Name = "lblNumIdent"
        Me.lblNumIdent.Size = New System.Drawing.Size(140, 13)
        Me.lblNumIdent.TabIndex = 15
        Me.lblNumIdent.Text = "Numero Identificacion *"
        '
        'tbNroDoc
        '
        Me.tbNroDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNroDoc.Location = New System.Drawing.Point(380, 39)
        Me.tbNroDoc.MaxLength = 12
        Me.tbNroDoc.Name = "tbNroDoc"
        Me.tbNroDoc.Size = New System.Drawing.Size(136, 20)
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
        Me.GroupBox4.Location = New System.Drawing.Point(9, 98)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(634, 75)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos"
        '
        'lblInicioAct
        '
        Me.lblInicioAct.AutoSize = True
        Me.lblInicioAct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicioAct.Location = New System.Drawing.Point(342, 22)
        Me.lblInicioAct.Name = "lblInicioAct"
        Me.lblInicioAct.Size = New System.Drawing.Size(112, 13)
        Me.lblInicioAct.TabIndex = 23
        Me.lblInicioAct.Text = "Inicio Actividades "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(18, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "E-Mail "
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(312, 48)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(61, 13)
        Me.lblApellido.TabIndex = 22
        Me.lblApellido.Text = "Apellido *"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(18, 48)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(63, 13)
        Me.lblNombre.TabIndex = 21
        Me.lblNombre.Text = "Nombre  *"
        '
        'lblNombreFanta
        '
        Me.lblNombreFanta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreFanta.Location = New System.Drawing.Point(18, 42)
        Me.lblNombreFanta.Name = "lblNombreFanta"
        Me.lblNombreFanta.Size = New System.Drawing.Size(74, 27)
        Me.lblNombreFanta.TabIndex = 0
        Me.lblNombreFanta.Text = "Nombre de Fantasía *"
        '
        'tbmail
        '
        Me.tbmail.Location = New System.Drawing.Point(98, 19)
        Me.tbmail.MaxLength = 40
        Me.tbmail.Name = "tbmail"
        Me.tbmail.Size = New System.Drawing.Size(238, 20)
        Me.tbmail.TabIndex = 5
        '
        'dtpfechanac
        '
        Me.dtpfechanac.CustomFormat = "dd/MM/yyyy"
        Me.dtpfechanac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfechanac.Location = New System.Drawing.Point(457, 19)
        Me.dtpfechanac.Name = "dtpfechanac"
        Me.dtpfechanac.Size = New System.Drawing.Size(120, 20)
        Me.dtpfechanac.TabIndex = 7
        Me.dtpfechanac.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(98, 45)
        Me.tbNombre.MaxLength = 30
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(194, 20)
        Me.tbNombre.TabIndex = 6
        '
        'lblFechaNac
        '
        Me.lblFechaNac.AutoSize = True
        Me.lblFechaNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNac.Location = New System.Drawing.Point(345, 22)
        Me.lblFechaNac.Name = "lblFechaNac"
        Me.lblFechaNac.Size = New System.Drawing.Size(109, 13)
        Me.lblFechaNac.TabIndex = 17
        Me.lblFechaNac.Text = "Fecha Nacimiento"
        '
        'tbApellido
        '
        Me.tbApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellido.Location = New System.Drawing.Point(402, 45)
        Me.tbApellido.MaxLength = 30
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(175, 20)
        Me.tbApellido.TabIndex = 8
        '
        'lblRazonSoc
        '
        Me.lblRazonSoc.AutoSize = True
        Me.lblRazonSoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRazonSoc.Location = New System.Drawing.Point(298, 48)
        Me.lblRazonSoc.Name = "lblRazonSoc"
        Me.lblRazonSoc.Size = New System.Drawing.Size(95, 13)
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
        Me.GroupBox3.Location = New System.Drawing.Point(9, 312)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(634, 41)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contacto"
        '
        'tbtelefono
        '
        Me.tbtelefono.Location = New System.Drawing.Point(476, 15)
        Me.tbtelefono.MaxLength = 12
        Me.tbtelefono.Name = "tbtelefono"
        Me.tbtelefono.Size = New System.Drawing.Size(149, 20)
        Me.tbtelefono.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(459, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(43, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Celular "
        '
        'tbcodcel
        '
        Me.tbcodcel.Location = New System.Drawing.Point(99, 15)
        Me.tbcodcel.MaxLength = 4
        Me.tbcodcel.Name = "tbcodcel"
        Me.tbcodcel.Size = New System.Drawing.Size(42, 20)
        Me.tbcodcel.TabIndex = 21
        '
        'tbcel
        '
        Me.tbcel.Location = New System.Drawing.Point(164, 15)
        Me.tbcel.MaxLength = 12
        Me.tbcel.Name = "tbcel"
        Me.tbcel.Size = New System.Drawing.Size(149, 20)
        Me.tbcel.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(147, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(348, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Telefono"
        '
        'tbcodtel
        '
        Me.tbcodtel.Location = New System.Drawing.Point(411, 15)
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
        Me.GroupBox2.Location = New System.Drawing.Point(9, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(634, 117)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Domicilio"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(307, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Barrio"
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(363, 50)
        Me.txtBarrio.MaxLength = 50
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(262, 20)
        Me.txtBarrio.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Piso"
        '
        'txtPiso
        '
        Me.txtPiso.Location = New System.Drawing.Point(462, 19)
        Me.txtPiso.MaxLength = 2
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New System.Drawing.Size(60, 20)
        Me.txtPiso.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Manzana"
        '
        'txtManzana
        '
        Me.txtManzana.Location = New System.Drawing.Point(237, 51)
        Me.txtManzana.MaxLength = 5
        Me.txtManzana.Name = "txtManzana"
        Me.txtManzana.Size = New System.Drawing.Size(64, 20)
        Me.txtManzana.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(528, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Lote"
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(565, 19)
        Me.txtLote.MaxLength = 3
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(60, 20)
        Me.txtLote.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(321, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Localidad *"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Provincia *"
        '
        'cmbLocalidades
        '
        Me.cmbLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocalidades.FormattingEnabled = True
        Me.cmbLocalidades.ItemHeight = 13
        Me.cmbLocalidades.Location = New System.Drawing.Point(395, 81)
        Me.cmbLocalidades.Name = "cmbLocalidades"
        Me.cmbLocalidades.Size = New System.Drawing.Size(230, 21)
        Me.cmbLocalidades.TabIndex = 7
        '
        'cmbProvincias
        '
        Me.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvincias.FormattingEnabled = True
        Me.cmbProvincias.ItemHeight = 13
        Me.cmbProvincias.Location = New System.Drawing.Point(85, 81)
        Me.cmbProvincias.Name = "cmbProvincias"
        Me.cmbProvincias.Size = New System.Drawing.Size(230, 21)
        Me.cmbProvincias.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Departamento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(303, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Numero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Calle "
        '
        'tbcalle
        '
        Me.tbcalle.Location = New System.Drawing.Point(60, 19)
        Me.tbcalle.MaxLength = 30
        Me.tbcalle.Name = "tbcalle"
        Me.tbcalle.Size = New System.Drawing.Size(237, 20)
        Me.tbcalle.TabIndex = 9
        '
        'tbNro
        '
        Me.tbNro.Location = New System.Drawing.Point(359, 19)
        Me.tbNro.MaxLength = 5
        Me.tbNro.Name = "tbNro"
        Me.tbNro.Size = New System.Drawing.Size(60, 20)
        Me.tbNro.TabIndex = 10
        '
        'tbDpto
        '
        Me.tbDpto.Location = New System.Drawing.Point(103, 51)
        Me.tbDpto.MaxLength = 5
        Me.tbDpto.Name = "tbDpto"
        Me.tbDpto.Size = New System.Drawing.Size(64, 20)
        Me.tbDpto.TabIndex = 12
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Control
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Image = Global.ClaseUi.My.Resources.Resources.icons8_cancel_62
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(433, 376)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(69, 85)
        Me.btnLimpiar.TabIndex = 45
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(358, 376)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(69, 85)
        Me.btnNuevo.TabIndex = 42
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(508, 376)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 85)
        Me.btnGuardar.TabIndex = 41
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(583, 376)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(69, 85)
        Me.btnSalir.TabIndex = 43
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Dgvclientes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 244)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(709, 282)
        Me.Panel1.TabIndex = 47
        '
        'Dgvclientes
        '
        Me.Dgvclientes.AllowUserToAddRows = False
        Me.Dgvclientes.AllowUserToDeleteRows = False
        Me.Dgvclientes.AllowUserToResizeColumns = False
        Me.Dgvclientes.AllowUserToResizeRows = False
        Me.Dgvclientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.Dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgvclientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgvclientes.Location = New System.Drawing.Point(0, 0)
        Me.Dgvclientes.MultiSelect = False
        Me.Dgvclientes.Name = "Dgvclientes"
        Me.Dgvclientes.ReadOnly = True
        Me.Dgvclientes.RowHeadersVisible = False
        Me.Dgvclientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Dgvclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgvclientes.Size = New System.Drawing.Size(709, 282)
        Me.Dgvclientes.TabIndex = 40
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(669, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(709, 526)
        Me.Panel2.TabIndex = 48
        '
        'FrmGestionCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 526)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGestionCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion de Cliente"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Dgvclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents btnLimpiar As Windows.Forms.Button
    Friend WithEvents Button1 As Windows.Forms.Button
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
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents btnGuardar As Windows.Forms.Button
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
	Friend WithEvents GroupBox6 As Windows.Forms.GroupBox
	Friend WithEvents btnValidarDNI1 As Windows.Forms.Button
	Friend WithEvents lblTipoIdentificacion As Windows.Forms.Label
	Friend WithEvents cboTipoPersona As Windows.Forms.ComboBox
	Friend WithEvents cbtipodni As Windows.Forms.ComboBox
	Friend WithEvents lblTipoDePersona As Windows.Forms.Label
	Friend WithEvents lblNumIdent As Windows.Forms.Label
	Friend WithEvents tbNroDoc As Windows.Forms.TextBox
	Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
	Friend WithEvents lblInicioAct As Windows.Forms.Label
	Friend WithEvents Label11 As Windows.Forms.Label
	Friend WithEvents lblApellido As Windows.Forms.Label
	Friend WithEvents lblNombre As Windows.Forms.Label
	Friend WithEvents lblNombreFanta As Windows.Forms.Label
	Friend WithEvents tbmail As Windows.Forms.TextBox
	Friend WithEvents dtpfechanac As Windows.Forms.DateTimePicker
	Friend WithEvents tbNombre As Windows.Forms.TextBox
	Friend WithEvents lblFechaNac As Windows.Forms.Label
	Friend WithEvents tbApellido As Windows.Forms.TextBox
	Friend WithEvents lblRazonSoc As Windows.Forms.Label
	Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
	Friend WithEvents tbtelefono As Windows.Forms.TextBox
	Friend WithEvents Label9 As Windows.Forms.Label
	Friend WithEvents Label10 As Windows.Forms.Label
	Friend WithEvents tbcodcel As Windows.Forms.TextBox
	Friend WithEvents tbcel As Windows.Forms.TextBox
	Friend WithEvents Label14 As Windows.Forms.Label
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
	Friend WithEvents GroupBox7 As Windows.Forms.GroupBox
	Friend WithEvents Panel1 As Windows.Forms.Panel
	Friend WithEvents Dgvclientes As Windows.Forms.DataGridView
    Friend WithEvents chbListaParaOrdenar As Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox8 As Windows.Forms.GroupBox
    Friend WithEvents lblPrioridad3 As Windows.Forms.Label
    Friend WithEvents lblPrioridad1 As Windows.Forms.Label
    Friend WithEvents lblPrioridad2 As Windows.Forms.Label
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents Label19 As Windows.Forms.Label
    Friend WithEvents Label20 As Windows.Forms.Label
    Friend WithEvents Label21 As Windows.Forms.Label
    Friend WithEvents cboOrden As Windows.Forms.ComboBox
    Friend WithEvents Panel2 As Windows.Forms.Panel
End Class
