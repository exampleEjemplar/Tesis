﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArmadoReparacion
	Inherits System.Windows.Forms.Form

	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArmadoReparacion))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblInstrucciones = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstProdDispo = New System.Windows.Forms.ListView()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClienteDireccion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gboTotales = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblClienteDNI = New System.Windows.Forms.Label()
        Me.btnQuitarItem = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.gboFiltros = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBusNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblClienteTelefono = New System.Windows.Forms.Label()
        Me.txtDevolucion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkSoloCliente = New System.Windows.Forms.CheckBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gboTotales.SuspendLayout()
        Me.gboFiltros.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(6, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Teléfono"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(6, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Domicilio"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(491, 494)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(69, 85)
        Me.btnNuevo.TabIndex = 67
        Me.btnNuevo.Text = "Finalizar"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(566, 494)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(69, 85)
        Me.btnSalir.TabIndex = 66
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblInstrucciones
        '
        Me.lblInstrucciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblInstrucciones.Location = New System.Drawing.Point(13, 64)
        Me.lblInstrucciones.Name = "lblInstrucciones"
        Me.lblInstrucciones.Size = New System.Drawing.Size(304, 16)
        Me.lblInstrucciones.TabIndex = 68
        Me.lblInstrucciones.Text = "*Debe seleccionar un proveedor para continuar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstProdDispo)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 335)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(362, 248)
        Me.GroupBox3.TabIndex = 64
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Productos Disponibles"
        '
        'lstProdDispo
        '
        Me.lstProdDispo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstProdDispo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProdDispo.GridLines = True
        Me.lstProdDispo.HideSelection = False
        Me.lstProdDispo.Location = New System.Drawing.Point(2, 15)
        Me.lstProdDispo.Margin = New System.Windows.Forms.Padding(2)
        Me.lstProdDispo.Name = "lstProdDispo"
        Me.lstProdDispo.Size = New System.Drawing.Size(358, 231)
        Me.lstProdDispo.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstProdDispo.TabIndex = 0
        Me.lstProdDispo.TileSize = New System.Drawing.Size(120, 25)
        Me.lstProdDispo.UseCompatibleStateImageBehavior = False
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.BackColor = System.Drawing.SystemColors.Control
        Me.btnAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarCliente.FlatAppearance.BorderSize = 0
        Me.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCliente.Image = Global.ClaseUi.My.Resources.Resources.icons8_add_354
        Me.btnAgregarCliente.Location = New System.Drawing.Point(499, 26)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(40, 40)
        Me.btnAgregarCliente.TabIndex = 70
        Me.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarCliente.UseVisualStyleBackColor = False
        '
        'cboCliente
        '
        Me.cboCliente.AccessibleDescription = ""
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Items.AddRange(New Object() {"Física", "Jurídica"})
        Me.cboCliente.Location = New System.Drawing.Point(84, 37)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(409, 21)
        Me.cboCliente.TabIndex = 59
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 40)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Cliente"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(388, 81)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(248, 121)
        Me.GroupBox2.TabIndex = 65
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Local"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(5, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 16)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Teléfono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(111, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Velez Sarsfield 68"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(5, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 16)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(111, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "23-34989201-4"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(5, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 16)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Identificación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(111, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "351-4255463"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(50, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "JOYERIA CRIZOL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 20)
        Me.Label1.TabIndex = 61
		Me.Label1.Text = "Generar comprobante de compra"
		'
		'lblClienteDireccion
		'
		Me.lblClienteDireccion.AutoSize = True
        Me.lblClienteDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblClienteDireccion.Location = New System.Drawing.Point(112, 46)
        Me.lblClienteDireccion.Name = "lblClienteDireccion"
        Me.lblClienteDireccion.Size = New System.Drawing.Size(86, 16)
        Me.lblClienteDireccion.TabIndex = 30
        Me.lblClienteDireccion.Text = "*Direccion*"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtDevolucion)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.gboTotales)
        Me.Panel1.Location = New System.Drawing.Point(11, 584)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 70)
        Me.Panel1.TabIndex = 71
        '
        'gboTotales
        '
        Me.gboTotales.Controls.Add(Me.Label11)
        Me.gboTotales.Controls.Add(Me.lblTotal)
        Me.gboTotales.Location = New System.Drawing.Point(220, 3)
        Me.gboTotales.Margin = New System.Windows.Forms.Padding(2)
        Me.gboTotales.Name = "gboTotales"
        Me.gboTotales.Padding = New System.Windows.Forms.Padding(2)
        Me.gboTotales.Size = New System.Drawing.Size(250, 65)
        Me.gboTotales.TabIndex = 48
        Me.gboTotales.TabStop = False
        Me.gboTotales.Text = "Totales"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 37)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Total de la reparación"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(125, 20)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 18)
        Me.lblTotal.TabIndex = 26
        Me.lblTotal.Text = "0.00"
        '
        'lblClienteDNI
        '
        Me.lblClienteDNI.AutoSize = True
        Me.lblClienteDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblClienteDNI.Location = New System.Drawing.Point(112, 71)
        Me.lblClienteDNI.Name = "lblClienteDNI"
        Me.lblClienteDNI.Size = New System.Drawing.Size(46, 16)
        Me.lblClienteDNI.TabIndex = 29
        Me.lblClienteDNI.Text = "*DNI*"
        '
        'btnQuitarItem
        '
        Me.btnQuitarItem.BackColor = System.Drawing.SystemColors.Control
        Me.btnQuitarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarItem.FlatAppearance.BorderSize = 0
        Me.btnQuitarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarItem.Image = CType(resources.GetObject("btnQuitarItem.Image"), System.Drawing.Image)
        Me.btnQuitarItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnQuitarItem.Location = New System.Drawing.Point(567, 407)
        Me.btnQuitarItem.Name = "btnQuitarItem"
        Me.btnQuitarItem.Size = New System.Drawing.Size(69, 81)
        Me.btnQuitarItem.TabIndex = 58
        Me.btnQuitarItem.Text = "Quitar item"
        Me.btnQuitarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnQuitarItem.UseVisualStyleBackColor = False
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.BackColor = System.Drawing.SystemColors.Control
        Me.btnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarProducto.FlatAppearance.BorderSize = 0
        Me.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProducto.Image = Global.ClaseUi.My.Resources.Resources.icons8_add_354
        Me.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregarProducto.Location = New System.Drawing.Point(494, 266)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(60, 65)
        Me.btnAgregarProducto.TabIndex = 69
        Me.btnAgregarProducto.Text = "Agregar producto"
        Me.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarProducto.UseVisualStyleBackColor = False
        '
        'gboFiltros
        '
        Me.gboFiltros.Controls.Add(Me.chkSoloCliente)
        Me.gboFiltros.Controls.Add(Me.btnLimpiarFiltros)
        Me.gboFiltros.Controls.Add(Me.btnBuscar)
        Me.gboFiltros.Controls.Add(Me.txtBusNombreProducto)
        Me.gboFiltros.Controls.Add(Me.Label8)
        Me.gboFiltros.Location = New System.Drawing.Point(13, 206)
        Me.gboFiltros.Margin = New System.Windows.Forms.Padding(2)
        Me.gboFiltros.Name = "gboFiltros"
        Me.gboFiltros.Padding = New System.Windows.Forms.Padding(2)
        Me.gboFiltros.Size = New System.Drawing.Size(468, 125)
        Me.gboFiltros.TabIndex = 63
        Me.gboFiltros.TabStop = False
        Me.gboFiltros.Text = "Búsqueda"
        '
        'btnLimpiarFiltros
        '
        Me.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Control
        Me.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiarFiltros.FlatAppearance.BorderSize = 0
        Me.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarFiltros.Image = CType(resources.GetObject("btnLimpiarFiltros.Image"), System.Drawing.Image)
        Me.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiarFiltros.Location = New System.Drawing.Point(362, 61)
        Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
        Me.btnLimpiarFiltros.Size = New System.Drawing.Size(92, 34)
        Me.btnLimpiarFiltros.TabIndex = 38
        Me.btnLimpiarFiltros.Text = "Limpiar"
        Me.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiarFiltros.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(362, 17)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(92, 34)
        Me.btnBuscar.TabIndex = 38
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBusNombreProducto
        '
        Me.txtBusNombreProducto.Location = New System.Drawing.Point(9, 32)
        Me.txtBusNombreProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBusNombreProducto.Name = "txtBusNombreProducto"
        Me.txtBusNombreProducto.Size = New System.Drawing.Size(299, 20)
        Me.txtBusNombreProducto.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Nombre producto"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Control
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(491, 414)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(69, 74)
        Me.btnLimpiar.TabIndex = 57
        Me.btnLimpiar.Text = "Limpiar Compra"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ListView1)
        Me.GroupBox4.Location = New System.Drawing.Point(375, 335)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(108, 246)
        Me.GroupBox4.TabIndex = 56
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Productos"
        '
        'ListView1
        '
        Me.ListView1.AllowDrop = True
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(2, 15)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(104, 229)
        Me.ListView1.TabIndex = 1
        Me.ListView1.TileSize = New System.Drawing.Size(120, 25)
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Identifación"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblNombre.Location = New System.Drawing.Point(133, 16)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(95, 18)
        Me.lblNombre.TabIndex = 26
        Me.lblNombre.Text = "*NOMBRE*"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblClienteDireccion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblClienteDNI)
        Me.GroupBox1.Controls.Add(Me.lblClienteTelefono)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 81)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(371, 121)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'lblClienteTelefono
        '
        Me.lblClienteTelefono.AutoSize = True
        Me.lblClienteTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblClienteTelefono.Location = New System.Drawing.Point(112, 95)
        Me.lblClienteTelefono.Name = "lblClienteTelefono"
        Me.lblClienteTelefono.Size = New System.Drawing.Size(82, 16)
        Me.lblClienteTelefono.TabIndex = 27
        Me.lblClienteTelefono.Text = "*Telefono*"
        '
        'txtDevolucion
        '
        Me.txtDevolucion.Location = New System.Drawing.Point(138, 25)
        Me.txtDevolucion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDevolucion.Name = "txtDevolucion"
        Me.txtDevolucion.Size = New System.Drawing.Size(42, 20)
        Me.txtDevolucion.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Dias para la entrega"
        '
        'chkSoloCliente
        '
        Me.chkSoloCliente.AutoSize = True
        Me.chkSoloCliente.Location = New System.Drawing.Point(9, 71)
        Me.chkSoloCliente.Name = "chkSoloCliente"
        Me.chkSoloCliente.Size = New System.Drawing.Size(221, 17)
        Me.chkSoloCliente.TabIndex = 42
        Me.chkSoloCliente.Text = "Mostrar productos cargados por el cliente"
        Me.chkSoloCliente.UseVisualStyleBackColor = True
        '
        'FrmArmadoReparacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 668)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblInstrucciones)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.cboCliente)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnQuitarItem)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.gboFiltros)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmArmadoReparacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Generar pedido de reparación"
		Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gboTotales.ResumeLayout(False)
        Me.gboTotales.PerformLayout()
        Me.gboFiltros.ResumeLayout(False)
        Me.gboFiltros.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents btnNuevo As Windows.Forms.Button
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents lblInstrucciones As Windows.Forms.Label
    Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
    Friend WithEvents lstProdDispo As Windows.Forms.ListView
    Friend WithEvents btnAgregarCliente As Windows.Forms.Button
    Friend WithEvents cboCliente As Windows.Forms.ComboBox
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents PrintDialog1 As Windows.Forms.PrintDialog
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lblClienteDireccion As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents gboTotales As Windows.Forms.GroupBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents lblTotal As Windows.Forms.Label
    Friend WithEvents lblClienteDNI As Windows.Forms.Label
    Friend WithEvents btnQuitarItem As Windows.Forms.Button
    Friend WithEvents btnAgregarProducto As Windows.Forms.Button
    Friend WithEvents gboFiltros As Windows.Forms.GroupBox
    Friend WithEvents btnLimpiarFiltros As Windows.Forms.Button
    Friend WithEvents btnBuscar As Windows.Forms.Button
    Friend WithEvents txtBusNombreProducto As Windows.Forms.TextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents btnLimpiar As Windows.Forms.Button
    Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
    Friend WithEvents ListView1 As Windows.Forms.ListView
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents lblNombre As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents lblClienteTelefono As Windows.Forms.Label
    Friend WithEvents txtDevolucion As Windows.Forms.TextBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents chkSoloCliente As Windows.Forms.CheckBox
End Class
