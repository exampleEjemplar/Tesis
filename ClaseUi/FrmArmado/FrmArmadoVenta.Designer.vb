<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArmadoVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArmadoVenta))
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblClienteDireccion = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblClienteDNI = New System.Windows.Forms.Label()
        Me.lblClienteTelefono = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstProdDispo = New System.Windows.Forms.ListView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnQuitarItem = New System.Windows.Forms.Button()
        Me.gboFiltros = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblPrioridad3 = New System.Windows.Forms.Label()
        Me.lblPrioridad1 = New System.Windows.Forms.Label()
        Me.lblPrioridad2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.lbldesde = New System.Windows.Forms.Label()
        Me.rbtEntreFechas = New System.Windows.Forms.CheckBox()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.rbtFechaExacta = New System.Windows.Forms.CheckBox()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaExacta = New System.Windows.Forms.Label()
        Me.txtBusNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboBusProveedor = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.gboTotales = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblInstrucciones = New System.Windows.Forms.Label()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboOrden = New System.Windows.Forms.ComboBox()
        Me.chbListaParaOrdenar = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gboFiltros.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.gboTotales.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCliente
        '
        Me.cboCliente.AccessibleDescription = ""
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Items.AddRange(New Object() {"Física", "Jurídica"})
        Me.cboCliente.Location = New System.Drawing.Point(67, 35)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(420, 21)
        Me.cboCliente.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(17, 38)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Generar comprobante de cobro"
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
        Me.GroupBox1.Location = New System.Drawing.Point(11, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(382, 121)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        Me.GroupBox1.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(9, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Teléfono"
        '
        'lblClienteDireccion
        '
        Me.lblClienteDireccion.AutoSize = True
        Me.lblClienteDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblClienteDireccion.Location = New System.Drawing.Point(122, 67)
        Me.lblClienteDireccion.Name = "lblClienteDireccion"
        Me.lblClienteDireccion.Size = New System.Drawing.Size(86, 16)
        Me.lblClienteDireccion.TabIndex = 30
        Me.lblClienteDireccion.Text = "*Direccion*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(9, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Domicilio"
        '
        'lblClienteDNI
        '
        Me.lblClienteDNI.AutoSize = True
        Me.lblClienteDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblClienteDNI.Location = New System.Drawing.Point(122, 45)
        Me.lblClienteDNI.Name = "lblClienteDNI"
        Me.lblClienteDNI.Size = New System.Drawing.Size(46, 16)
        Me.lblClienteDNI.TabIndex = 29
        Me.lblClienteDNI.Text = "*DNI*"
        '
        'lblClienteTelefono
        '
        Me.lblClienteTelefono.AutoSize = True
        Me.lblClienteTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblClienteTelefono.Location = New System.Drawing.Point(122, 89)
        Me.lblClienteTelefono.Name = "lblClienteTelefono"
        Me.lblClienteTelefono.Size = New System.Drawing.Size(0, 16)
        Me.lblClienteTelefono.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(9, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Identifación"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblNombre.Location = New System.Drawing.Point(113, 14)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(95, 18)
        Me.lblNombre.TabIndex = 26
        Me.lblNombre.Text = "*NOMBRE*"
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
        Me.GroupBox2.Location = New System.Drawing.Point(397, 77)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(239, 122)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Local"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(5, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 16)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Teléfono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(101, 46)
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
        Me.Label3.Location = New System.Drawing.Point(101, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "23-34989201-4"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(5, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Identifación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(101, 90)
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstProdDispo)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 356)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(362, 248)
        Me.GroupBox3.TabIndex = 31
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
        Me.lstProdDispo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstProdDispo.Name = "lstProdDispo"
        Me.lstProdDispo.Size = New System.Drawing.Size(358, 231)
        Me.lstProdDispo.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstProdDispo.TabIndex = 0
        Me.lstProdDispo.TileSize = New System.Drawing.Size(120, 25)
        Me.lstProdDispo.UseCompatibleStateImageBehavior = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ListView1)
        Me.GroupBox4.Location = New System.Drawing.Point(375, 356)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(108, 248)
        Me.GroupBox4.TabIndex = 32
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
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(104, 231)
        Me.ListView1.TabIndex = 1
        Me.ListView1.TileSize = New System.Drawing.Size(120, 25)
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(1, 140)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(69, 85)
        Me.btnNuevo.TabIndex = 35
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
        Me.btnSalir.Location = New System.Drawing.Point(76, 140)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(69, 85)
        Me.btnSalir.TabIndex = 34
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Control
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(77, 50)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(69, 84)
        Me.btnLimpiar.TabIndex = 36
        Me.btnLimpiar.Text = "Limpiar todo"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnQuitarItem
        '
        Me.btnQuitarItem.BackColor = System.Drawing.SystemColors.Control
        Me.btnQuitarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarItem.FlatAppearance.BorderSize = 0
        Me.btnQuitarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarItem.Image = CType(resources.GetObject("btnQuitarItem.Image"), System.Drawing.Image)
        Me.btnQuitarItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnQuitarItem.Location = New System.Drawing.Point(0, 40)
        Me.btnQuitarItem.Name = "btnQuitarItem"
        Me.btnQuitarItem.Size = New System.Drawing.Size(69, 85)
        Me.btnQuitarItem.TabIndex = 37
        Me.btnQuitarItem.Text = "Quitar item"
        Me.btnQuitarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnQuitarItem.UseVisualStyleBackColor = False
        '
        'gboFiltros
        '
        Me.gboFiltros.Controls.Add(Me.btnLimpiarFiltros)
        Me.gboFiltros.Controls.Add(Me.GroupBox8)
        Me.gboFiltros.Controls.Add(Me.btnBuscar)
        Me.gboFiltros.Controls.Add(Me.btnAgregarProducto)
        Me.gboFiltros.Controls.Add(Me.lbldesde)
        Me.gboFiltros.Controls.Add(Me.rbtEntreFechas)
        Me.gboFiltros.Controls.Add(Me.lblHasta)
        Me.gboFiltros.Controls.Add(Me.rbtFechaExacta)
        Me.gboFiltros.Controls.Add(Me.dtpFechaHasta)
        Me.gboFiltros.Controls.Add(Me.dtpFechaDesde)
        Me.gboFiltros.Controls.Add(Me.lblFechaExacta)
        Me.gboFiltros.Controls.Add(Me.txtBusNombreProducto)
        Me.gboFiltros.Controls.Add(Me.Label8)
        Me.gboFiltros.Controls.Add(Me.cboBusProveedor)
        Me.gboFiltros.Controls.Add(Me.Label7)
        Me.gboFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboFiltros.Location = New System.Drawing.Point(11, 203)
        Me.gboFiltros.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gboFiltros.Name = "gboFiltros"
        Me.gboFiltros.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gboFiltros.Size = New System.Drawing.Size(625, 145)
        Me.gboFiltros.TabIndex = 31
        Me.gboFiltros.TabStop = False
        Me.gboFiltros.Text = "Búsqueda"
        '
        'btnLimpiarFiltros
        '
        Me.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Control
        Me.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiarFiltros.FlatAppearance.BorderSize = 0
        Me.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarFiltros.Image = CType(resources.GetObject("btnLimpiarFiltros.Image"), System.Drawing.Image)
        Me.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpiarFiltros.Location = New System.Drawing.Point(570, 75)
        Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
        Me.btnLimpiarFiltros.Size = New System.Drawing.Size(50, 53)
        Me.btnLimpiarFiltros.TabIndex = 38
        Me.btnLimpiarFiltros.Text = "Limpiar"
        Me.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiarFiltros.UseVisualStyleBackColor = False
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
        Me.GroupBox8.Location = New System.Drawing.Point(449, 7)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox8.Size = New System.Drawing.Size(116, 134)
        Me.GroupBox8.TabIndex = 46
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Prioridad"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 89)
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
        Me.Label20.Location = New System.Drawing.Point(5, 53)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 13)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Prioridad 2"
        '
        'lblPrioridad3
        '
        Me.lblPrioridad3.AutoSize = True
        Me.lblPrioridad3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioridad3.Location = New System.Drawing.Point(6, 107)
        Me.lblPrioridad3.Name = "lblPrioridad3"
        Me.lblPrioridad3.Size = New System.Drawing.Size(57, 13)
        Me.lblPrioridad3.TabIndex = 22
        Me.lblPrioridad3.Text = "Prioridad 3"
        '
        'lblPrioridad1
        '
        Me.lblPrioridad1.AutoSize = True
        Me.lblPrioridad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioridad1.Location = New System.Drawing.Point(6, 34)
        Me.lblPrioridad1.Name = "lblPrioridad1"
        Me.lblPrioridad1.Size = New System.Drawing.Size(57, 13)
        Me.lblPrioridad1.TabIndex = 20
        Me.lblPrioridad1.Text = "Prioridad 1"
        '
        'lblPrioridad2
        '
        Me.lblPrioridad2.AutoSize = True
        Me.lblPrioridad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioridad2.Location = New System.Drawing.Point(6, 70)
        Me.lblPrioridad2.Name = "lblPrioridad2"
        Me.lblPrioridad2.Size = New System.Drawing.Size(57, 13)
        Me.lblPrioridad2.TabIndex = 21
        Me.lblPrioridad2.Text = "Prioridad 2"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(570, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 53)
        Me.btnBuscar.TabIndex = 38
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.BackColor = System.Drawing.SystemColors.Control
        Me.btnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarProducto.FlatAppearance.BorderSize = 0
        Me.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.Image = CType(resources.GetObject("btnAgregarProducto.Image"), System.Drawing.Image)
        Me.btnAgregarProducto.Location = New System.Drawing.Point(264, 42)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregarProducto.TabIndex = 38
        Me.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarProducto.UseVisualStyleBackColor = False
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesde.Location = New System.Drawing.Point(6, 95)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(43, 13)
        Me.lbldesde.TabIndex = 52
        Me.lbldesde.Text = "Desde"
        '
        'rbtEntreFechas
        '
        Me.rbtEntreFechas.AutoSize = True
        Me.rbtEntreFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtEntreFechas.Location = New System.Drawing.Point(134, 75)
        Me.rbtEntreFechas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtEntreFechas.Name = "rbtEntreFechas"
        Me.rbtEntreFechas.Size = New System.Drawing.Size(86, 17)
        Me.rbtEntreFechas.TabIndex = 49
        Me.rbtEntreFechas.Text = "Entre fechas"
        Me.rbtEntreFechas.UseVisualStyleBackColor = True
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(131, 95)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(40, 13)
        Me.lblHasta.TabIndex = 51
        Me.lblHasta.Text = "Hasta"
        '
        'rbtFechaExacta
        '
        Me.rbtFechaExacta.AutoSize = True
        Me.rbtFechaExacta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtFechaExacta.Location = New System.Drawing.Point(9, 75)
        Me.rbtFechaExacta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbtFechaExacta.Name = "rbtFechaExacta"
        Me.rbtFechaExacta.Size = New System.Drawing.Size(121, 17)
        Me.rbtFechaExacta.TabIndex = 50
        Me.rbtFechaExacta.Text = "Fecha exacta carga"
        Me.rbtFechaExacta.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaHasta.Location = New System.Drawing.Point(134, 113)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(83, 20)
        Me.dtpFechaHasta.TabIndex = 48
        Me.dtpFechaHasta.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaDesde.Location = New System.Drawing.Point(9, 113)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(83, 20)
        Me.dtpFechaDesde.TabIndex = 47
        Me.dtpFechaDesde.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
        '
        'lblFechaExacta
        '
        Me.lblFechaExacta.AutoSize = True
        Me.lblFechaExacta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaExacta.Location = New System.Drawing.Point(6, 95)
        Me.lblFechaExacta.Name = "lblFechaExacta"
        Me.lblFechaExacta.Size = New System.Drawing.Size(119, 13)
        Me.lblFechaExacta.TabIndex = 46
        Me.lblFechaExacta.Text = "Fecha comprobante"
        '
        'txtBusNombreProducto
        '
        Me.txtBusNombreProducto.Location = New System.Drawing.Point(113, 48)
        Me.txtBusNombreProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBusNombreProducto.Name = "txtBusNombreProducto"
        Me.txtBusNombreProducto.Size = New System.Drawing.Size(147, 20)
        Me.txtBusNombreProducto.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Nombre producto"
        '
        'cboBusProveedor
        '
        Me.cboBusProveedor.AccessibleDescription = ""
        Me.cboBusProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBusProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBusProveedor.FormattingEnabled = True
        Me.cboBusProveedor.Items.AddRange(New Object() {"Física", "Jurídica"})
        Me.cboBusProveedor.Location = New System.Drawing.Point(77, 22)
        Me.cboBusProveedor.Name = "cboBusProveedor"
        Me.cboBusProveedor.Size = New System.Drawing.Size(183, 21)
        Me.cboBusProveedor.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Proveedor"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnQuitarItem)
        Me.GroupBox5.Controls.Add(Me.btnLimpiar)
        Me.GroupBox5.Controls.Add(Me.btnSalir)
        Me.GroupBox5.Controls.Add(Me.btnNuevo)
        Me.GroupBox5.Location = New System.Drawing.Point(487, 356)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(151, 248)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        '
        'gboTotales
        '
        Me.gboTotales.Controls.Add(Me.Label11)
        Me.gboTotales.Controls.Add(Me.lblTotal)
        Me.gboTotales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gboTotales.Location = New System.Drawing.Point(0, 599)
        Me.gboTotales.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gboTotales.Name = "gboTotales"
        Me.gboTotales.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gboTotales.Size = New System.Drawing.Size(647, 44)
        Me.gboTotales.TabIndex = 32
        Me.gboTotales.TabStop = False
        Me.gboTotales.Text = "Totales"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(94, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 18)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Total de la venta"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(403, 15)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 18)
        Me.lblTotal.TabIndex = 26
        Me.lblTotal.Text = "0.00"
        '
        'lblInstrucciones
        '
        Me.lblInstrucciones.AutoSize = True
        Me.lblInstrucciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.lblInstrucciones.Location = New System.Drawing.Point(15, 59)
        Me.lblInstrucciones.Name = "lblInstrucciones"
        Me.lblInstrucciones.Size = New System.Drawing.Size(327, 17)
        Me.lblInstrucciones.TabIndex = 36
        Me.lblInstrucciones.Text = "*Debe seleccionar un cliente para continuar"
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.BackColor = System.Drawing.SystemColors.Control
        Me.btnAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarCliente.FlatAppearance.BorderSize = 0
        Me.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCliente.Image = CType(resources.GetObject("btnAgregarCliente.Image"), System.Drawing.Image)
        Me.btnAgregarCliente.Location = New System.Drawing.Point(490, 30)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregarCliente.TabIndex = 39
        Me.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarCliente.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.cboOrden)
        Me.GroupBox7.Controls.Add(Me.chbListaParaOrdenar)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.Location = New System.Drawing.Point(310, 202)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox7.Size = New System.Drawing.Size(146, 145)
        Me.GroupBox7.TabIndex = 53
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Ordenar por"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Orden"
        '
        'cboOrden
        '
        Me.cboOrden.AccessibleDescription = ""
        Me.cboOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrden.FormattingEnabled = True
        Me.cboOrden.Items.AddRange(New Object() {"Física", "Jurídica"})
        Me.cboOrden.Location = New System.Drawing.Point(53, 107)
        Me.cboOrden.Name = "cboOrden"
        Me.cboOrden.Size = New System.Drawing.Size(50, 21)
        Me.cboOrden.TabIndex = 74
        '
        'chbListaParaOrdenar
        '
        Me.chbListaParaOrdenar.FormattingEnabled = True
        Me.chbListaParaOrdenar.Location = New System.Drawing.Point(4, 17)
        Me.chbListaParaOrdenar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbListaParaOrdenar.Name = "chbListaParaOrdenar"
        Me.chbListaParaOrdenar.Size = New System.Drawing.Size(138, 68)
        Me.chbListaParaOrdenar.TabIndex = 0
        '
        'FrmArmadoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 643)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lblInstrucciones)
        Me.Controls.Add(Me.gboTotales)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.gboFiltros)
        Me.Controls.Add(Me.cboCliente)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmArmadoVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Generar comprobante de cobro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.gboFiltros.ResumeLayout(False)
        Me.gboFiltros.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.gboTotales.ResumeLayout(False)
        Me.gboTotales.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCliente As Windows.Forms.ComboBox
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
	Friend WithEvents lblClienteDireccion As Windows.Forms.Label
	Friend WithEvents lblClienteDNI As Windows.Forms.Label
	Friend WithEvents lblClienteTelefono As Windows.Forms.Label
	Friend WithEvents lblNombre As Windows.Forms.Label
	Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents Label4 As Windows.Forms.Label
	Friend WithEvents Label5 As Windows.Forms.Label
	Friend WithEvents Label6 As Windows.Forms.Label
	Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
	Friend WithEvents lstProdDispo As Windows.Forms.ListView
	Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents ListView1 As Windows.Forms.ListView
    Friend WithEvents PrintDialog1 As Windows.Forms.PrintDialog
	Friend WithEvents btnLimpiar As Windows.Forms.Button
	Friend WithEvents btnQuitarItem As Windows.Forms.Button
	Friend WithEvents gboFiltros As Windows.Forms.GroupBox
	Friend WithEvents txtBusNombreProducto As Windows.Forms.TextBox
	Friend WithEvents Label8 As Windows.Forms.Label
	Friend WithEvents cboBusProveedor As Windows.Forms.ComboBox
	Friend WithEvents Label7 As Windows.Forms.Label
	Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
	Friend WithEvents gboTotales As Windows.Forms.GroupBox
	Friend WithEvents Label11 As Windows.Forms.Label
	Friend WithEvents lblTotal As Windows.Forms.Label
	Friend WithEvents lbldesde As Windows.Forms.Label
	Friend WithEvents lblHasta As Windows.Forms.Label
	Friend WithEvents rbtFechaExacta As Windows.Forms.CheckBox
	Friend WithEvents rbtEntreFechas As Windows.Forms.CheckBox
	Friend WithEvents dtpFechaHasta As Windows.Forms.DateTimePicker
	Friend WithEvents dtpFechaDesde As Windows.Forms.DateTimePicker
	Friend WithEvents lblFechaExacta As Windows.Forms.Label
	Friend WithEvents btnBuscar As Windows.Forms.Button
	Friend WithEvents btnLimpiarFiltros As Windows.Forms.Button
	Friend WithEvents lblInstrucciones As Windows.Forms.Label
	Friend WithEvents Label10 As Windows.Forms.Label
	Friend WithEvents Label9 As Windows.Forms.Label
	Friend WithEvents Label12 As Windows.Forms.Label
	Friend WithEvents Label13 As Windows.Forms.Label
	Friend WithEvents Label14 As Windows.Forms.Label
	Friend WithEvents btnAgregarProducto As Windows.Forms.Button
	Friend WithEvents btnAgregarCliente As Windows.Forms.Button
	Friend WithEvents GroupBox7 As Windows.Forms.GroupBox
	Friend WithEvents GroupBox8 As Windows.Forms.GroupBox
	Friend WithEvents Label18 As Windows.Forms.Label
	Friend WithEvents Label19 As Windows.Forms.Label
	Friend WithEvents Label20 As Windows.Forms.Label
	Friend WithEvents lblPrioridad3 As Windows.Forms.Label
	Friend WithEvents lblPrioridad1 As Windows.Forms.Label
	Friend WithEvents lblPrioridad2 As Windows.Forms.Label
	Friend WithEvents chbListaParaOrdenar As Windows.Forms.CheckedListBox
	Friend WithEvents Label15 As Windows.Forms.Label
	Friend WithEvents cboOrden As Windows.Forms.ComboBox
End Class
