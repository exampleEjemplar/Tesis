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
		Me.cboCliente = New System.Windows.Forms.ComboBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.lblClienteDireccion = New System.Windows.Forms.Label()
		Me.lblClienteDNI = New System.Windows.Forms.Label()
		Me.lblClienteTelefono = New System.Windows.Forms.Label()
		Me.lblNombre = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
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
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.cboBusUsuarios = New System.Windows.Forms.ComboBox()
		Me.Label9 = New System.Windows.Forms.Label()
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
		Me.Label15 = New System.Windows.Forms.Label()
		Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.gboFiltros.SuspendLayout()
		Me.GroupBox5.SuspendLayout()
		Me.gboTotales.SuspendLayout()
		Me.SuspendLayout()
		'
		'cboCliente
		'
		Me.cboCliente.AccessibleDescription = ""
		Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCliente.FormattingEnabled = True
		Me.cboCliente.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboCliente.Location = New System.Drawing.Point(101, 53)
		Me.cboCliente.Margin = New System.Windows.Forms.Padding(4)
		Me.cboCliente.Name = "cboCliente"
		Me.cboCliente.Size = New System.Drawing.Size(367, 25)
		Me.cboCliente.TabIndex = 24
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(20, 57)
		Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(58, 17)
		Me.Label17.TabIndex = 25
		Me.Label17.Text = "Cliente"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(13, 9)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(366, 25)
		Me.Label1.TabIndex = 26
		Me.Label1.Text = "Armado de comprobante de venta"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lblClienteDireccion)
		Me.GroupBox1.Controls.Add(Me.lblClienteDNI)
		Me.GroupBox1.Controls.Add(Me.lblClienteTelefono)
		Me.GroupBox1.Controls.Add(Me.lblNombre)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 95)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox1.Size = New System.Drawing.Size(555, 175)
		Me.GroupBox1.TabIndex = 27
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Cliente"
		'
		'lblClienteDireccion
		'
		Me.lblClienteDireccion.AutoSize = True
		Me.lblClienteDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.lblClienteDireccion.Location = New System.Drawing.Point(25, 57)
		Me.lblClienteDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblClienteDireccion.Name = "lblClienteDireccion"
		Me.lblClienteDireccion.Size = New System.Drawing.Size(98, 20)
		Me.lblClienteDireccion.TabIndex = 30
		Me.lblClienteDireccion.Text = "*Direccion*"
		'
		'lblClienteDNI
		'
		Me.lblClienteDNI.AutoSize = True
		Me.lblClienteDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.lblClienteDNI.Location = New System.Drawing.Point(25, 102)
		Me.lblClienteDNI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblClienteDNI.Name = "lblClienteDNI"
		Me.lblClienteDNI.Size = New System.Drawing.Size(54, 20)
		Me.lblClienteDNI.TabIndex = 29
		Me.lblClienteDNI.Text = "*DNI*"
		'
		'lblClienteTelefono
		'
		Me.lblClienteTelefono.AutoSize = True
		Me.lblClienteTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.lblClienteTelefono.Location = New System.Drawing.Point(25, 139)
		Me.lblClienteTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblClienteTelefono.Name = "lblClienteTelefono"
		Me.lblClienteTelefono.Size = New System.Drawing.Size(93, 20)
		Me.lblClienteTelefono.TabIndex = 27
		Me.lblClienteTelefono.Text = "*Telefono*"
		'
		'lblNombre
		'
		Me.lblNombre.AutoSize = True
		Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lblNombre.Location = New System.Drawing.Point(252, 15)
		Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblNombre.Name = "lblNombre"
		Me.lblNombre.Size = New System.Drawing.Size(115, 24)
		Me.lblNombre.TabIndex = 26
		Me.lblNombre.Text = "*NOMBRE*"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label2)
		Me.GroupBox2.Controls.Add(Me.Label3)
		Me.GroupBox2.Controls.Add(Me.Label4)
		Me.GroupBox2.Controls.Add(Me.Label5)
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Location = New System.Drawing.Point(583, 95)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox2.Size = New System.Drawing.Size(512, 175)
		Me.GroupBox2.TabIndex = 31
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Local"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(23, 42)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(155, 20)
		Me.Label2.TabIndex = 30
		Me.Label2.Text = "Velez Sarsfield 68"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label3.Location = New System.Drawing.Point(187, 81)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(119, 20)
		Me.Label3.TabIndex = 29
		Me.Label3.Text = "23349892014"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label4.Location = New System.Drawing.Point(23, 82)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(50, 20)
		Me.Label4.TabIndex = 28
		Me.Label4.Text = "CUIT"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label5.Location = New System.Drawing.Point(23, 124)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(114, 20)
		Me.Label5.TabIndex = 27
		Me.Label5.Text = "351 4255463"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.Label6.Location = New System.Drawing.Point(187, 18)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(175, 24)
		Me.Label6.TabIndex = 26
		Me.Label6.Text = "JOYERIA CRIZOL"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.lstProdDispo)
		Me.GroupBox3.Location = New System.Drawing.Point(18, 458)
		Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox3.Size = New System.Drawing.Size(859, 481)
		Me.GroupBox3.TabIndex = 31
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Productos disponibles"
		'
		'lstProdDispo
		'
		Me.lstProdDispo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstProdDispo.GridLines = True
		Me.lstProdDispo.Location = New System.Drawing.Point(10, 18)
		Me.lstProdDispo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.lstProdDispo.Name = "lstProdDispo"
		Me.lstProdDispo.Size = New System.Drawing.Size(841, 459)
		Me.lstProdDispo.Sorting = System.Windows.Forms.SortOrder.Ascending
		Me.lstProdDispo.TabIndex = 0
		Me.lstProdDispo.TileSize = New System.Drawing.Size(120, 25)
		Me.lstProdDispo.UseCompatibleStateImageBehavior = False
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.ListView1)
		Me.GroupBox4.Location = New System.Drawing.Point(6, 184)
		Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox4.Size = New System.Drawing.Size(339, 553)
		Me.GroupBox4.TabIndex = 32
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Productos en la venta"
		'
		'ListView1
		'
		Me.ListView1.AllowDrop = True
		Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
		Me.ListView1.Location = New System.Drawing.Point(11, 26)
		Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Size = New System.Drawing.Size(322, 451)
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
		Me.btnNuevo.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
		Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevo.FlatAppearance.BorderSize = 0
		Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevo.Location = New System.Drawing.Point(996, -1)
		Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevo.Name = "btnNuevo"
		Me.btnNuevo.Size = New System.Drawing.Size(123, 98)
		Me.btnNuevo.TabIndex = 35
		Me.btnNuevo.Text = "Finalizar"
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
		Me.btnSalir.Location = New System.Drawing.Point(1130, -1)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(107, 100)
		Me.btnSalir.TabIndex = 34
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Control
		Me.btnLimpiar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_clear_filters_40
		Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnLimpiar.FlatAppearance.BorderSize = 0
		Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLimpiar.Location = New System.Drawing.Point(213, 34)
		Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(126, 103)
		Me.btnLimpiar.TabIndex = 36
		Me.btnLimpiar.Text = "Limpiar todo"
		Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnLimpiar.UseVisualStyleBackColor = False
		'
		'btnQuitarItem
		'
		Me.btnQuitarItem.BackColor = System.Drawing.SystemColors.Control
		Me.btnQuitarItem.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_cancel_62
		Me.btnQuitarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnQuitarItem.FlatAppearance.BorderSize = 0
		Me.btnQuitarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnQuitarItem.Location = New System.Drawing.Point(17, 34)
		Me.btnQuitarItem.Margin = New System.Windows.Forms.Padding(4)
		Me.btnQuitarItem.Name = "btnQuitarItem"
		Me.btnQuitarItem.Size = New System.Drawing.Size(134, 103)
		Me.btnQuitarItem.TabIndex = 37
		Me.btnQuitarItem.Text = "Quitar item"
		Me.btnQuitarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnQuitarItem.UseVisualStyleBackColor = False
		'
		'gboFiltros
		'
		Me.gboFiltros.Controls.Add(Me.btnLimpiarFiltros)
		Me.gboFiltros.Controls.Add(Me.btnBuscar)
		Me.gboFiltros.Controls.Add(Me.cboBusUsuarios)
		Me.gboFiltros.Controls.Add(Me.Label9)
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
		Me.gboFiltros.Location = New System.Drawing.Point(12, 274)
		Me.gboFiltros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboFiltros.Name = "gboFiltros"
		Me.gboFiltros.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboFiltros.Size = New System.Drawing.Size(865, 180)
		Me.gboFiltros.TabIndex = 31
		Me.gboFiltros.TabStop = False
		Me.gboFiltros.Text = "Filtros"
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
		Me.btnBuscar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_search_48
		Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnBuscar.FlatAppearance.BorderSize = 0
		Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscar.Location = New System.Drawing.Point(775, 10)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(89, 73)
		Me.btnBuscar.TabIndex = 38
		Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'cboBusUsuarios
		'
		Me.cboBusUsuarios.AccessibleDescription = ""
		Me.cboBusUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboBusUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboBusUsuarios.FormattingEnabled = True
		Me.cboBusUsuarios.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboBusUsuarios.Location = New System.Drawing.Point(535, 21)
		Me.cboBusUsuarios.Margin = New System.Windows.Forms.Padding(4)
		Me.cboBusUsuarios.Name = "cboBusUsuarios"
		Me.cboBusUsuarios.Size = New System.Drawing.Size(201, 25)
		Me.cboBusUsuarios.TabIndex = 53
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
		Me.Label9.Location = New System.Drawing.Point(420, 25)
		Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(107, 16)
		Me.Label9.TabIndex = 54
		Me.Label9.Text = "Cargado por..."
		'
		'lbldesde
		'
		Me.lbldesde.AutoSize = True
		Me.lbldesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
		Me.lbldesde.Location = New System.Drawing.Point(105, 141)
		Me.lbldesde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lbldesde.Name = "lbldesde"
		Me.lbldesde.Size = New System.Drawing.Size(54, 16)
		Me.lbldesde.TabIndex = 52
		Me.lbldesde.Text = "Desde"
		'
		'rbtEntreFechas
		'
		Me.rbtEntreFechas.AutoSize = True
		Me.rbtEntreFechas.Location = New System.Drawing.Point(205, 103)
		Me.rbtEntreFechas.Name = "rbtEntreFechas"
		Me.rbtEntreFechas.Size = New System.Drawing.Size(177, 21)
		Me.rbtEntreFechas.TabIndex = 49
		Me.rbtEntreFechas.Text = "Busqueda entre fechas"
		Me.rbtEntreFechas.UseVisualStyleBackColor = True
		'
		'lblHasta
		'
		Me.lblHasta.AutoSize = True
		Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
		Me.lblHasta.Location = New System.Drawing.Point(326, 141)
		Me.lblHasta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblHasta.Name = "lblHasta"
		Me.lblHasta.Size = New System.Drawing.Size(49, 16)
		Me.lblHasta.TabIndex = 51
		Me.lblHasta.Text = "Hasta"
		'
		'rbtFechaExacta
		'
		Me.rbtFechaExacta.AutoSize = True
		Me.rbtFechaExacta.Location = New System.Drawing.Point(11, 103)
		Me.rbtFechaExacta.Name = "rbtFechaExacta"
		Me.rbtFechaExacta.Size = New System.Drawing.Size(178, 21)
		Me.rbtFechaExacta.TabIndex = 50
		Me.rbtFechaExacta.Text = "Busqueda fecha exacta"
		Me.rbtFechaExacta.UseVisualStyleBackColor = True
		'
		'dtpFechaHasta
		'
		Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpFechaHasta.Location = New System.Drawing.Point(384, 137)
		Me.dtpFechaHasta.Margin = New System.Windows.Forms.Padding(4)
		Me.dtpFechaHasta.Name = "dtpFechaHasta"
		Me.dtpFechaHasta.Size = New System.Drawing.Size(151, 22)
		Me.dtpFechaHasta.TabIndex = 48
		Me.dtpFechaHasta.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
		'
		'dtpFechaDesde
		'
		Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpFechaDesde.Location = New System.Drawing.Point(167, 137)
		Me.dtpFechaDesde.Margin = New System.Windows.Forms.Padding(4)
		Me.dtpFechaDesde.Name = "dtpFechaDesde"
		Me.dtpFechaDesde.Size = New System.Drawing.Size(151, 22)
		Me.dtpFechaDesde.TabIndex = 47
		Me.dtpFechaDesde.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
		'
		'lblFechaExacta
		'
		Me.lblFechaExacta.AutoSize = True
		Me.lblFechaExacta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
		Me.lblFechaExacta.Location = New System.Drawing.Point(8, 141)
		Me.lblFechaExacta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblFechaExacta.Name = "lblFechaExacta"
		Me.lblFechaExacta.Size = New System.Drawing.Size(146, 16)
		Me.lblFechaExacta.TabIndex = 46
		Me.lblFechaExacta.Text = "Fecha comprobante"
		'
		'txtBusNombreProducto
		'
		Me.txtBusNombreProducto.Location = New System.Drawing.Point(171, 61)
		Me.txtBusNombreProducto.Name = "txtBusNombreProducto"
		Me.txtBusNombreProducto.Size = New System.Drawing.Size(201, 22)
		Me.txtBusNombreProducto.TabIndex = 41
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
		Me.Label8.Location = New System.Drawing.Point(7, 66)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(128, 16)
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
		Me.cboBusProveedor.Location = New System.Drawing.Point(171, 21)
		Me.cboBusProveedor.Margin = New System.Windows.Forms.Padding(4)
		Me.cboBusProveedor.Name = "cboBusProveedor"
		Me.cboBusProveedor.Size = New System.Drawing.Size(201, 25)
		Me.cboBusProveedor.TabIndex = 38
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
		Me.Label7.Location = New System.Drawing.Point(8, 25)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(81, 16)
		Me.Label7.TabIndex = 39
		Me.Label7.Text = "Proveedor"
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.btnQuitarItem)
		Me.GroupBox5.Controls.Add(Me.GroupBox4)
		Me.GroupBox5.Controls.Add(Me.btnLimpiar)
		Me.GroupBox5.Location = New System.Drawing.Point(883, 274)
		Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox5.Size = New System.Drawing.Size(351, 665)
		Me.GroupBox5.TabIndex = 31
		Me.GroupBox5.TabStop = False
		'
		'gboTotales
		'
		Me.gboTotales.Controls.Add(Me.Label11)
		Me.gboTotales.Controls.Add(Me.Label15)
		Me.gboTotales.Location = New System.Drawing.Point(1101, 103)
		Me.gboTotales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboTotales.Name = "gboTotales"
		Me.gboTotales.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboTotales.Size = New System.Drawing.Size(133, 136)
		Me.gboTotales.TabIndex = 32
		Me.gboTotales.TabStop = False
		Me.gboTotales.Text = "Totales"
		'
		'Label11
		'
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label11.Location = New System.Drawing.Point(9, 21)
		Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(118, 62)
		Me.Label11.TabIndex = 30
		Me.Label11.Text = "Total de la venta"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.Label15.Location = New System.Drawing.Point(41, 94)
		Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(49, 24)
		Me.Label15.TabIndex = 26
		Me.Label15.Text = "0.00"
		'
		'btnLimpiarFiltros
		'
		Me.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Control
		Me.btnLimpiarFiltros.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_clear_filters_40
		Me.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnLimpiarFiltros.FlatAppearance.BorderSize = 0
		Me.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLimpiarFiltros.Location = New System.Drawing.Point(774, 98)
		Me.btnLimpiarFiltros.Margin = New System.Windows.Forms.Padding(4)
		Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
		Me.btnLimpiarFiltros.Size = New System.Drawing.Size(90, 76)
		Me.btnLimpiarFiltros.TabIndex = 38
		Me.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnLimpiarFiltros.UseVisualStyleBackColor = False
		'
		'FrmArmadoVenta
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1247, 950)
		Me.Controls.Add(Me.gboTotales)
		Me.Controls.Add(Me.GroupBox5)
		Me.Controls.Add(Me.gboFiltros)
		Me.Controls.Add(Me.btnNuevo)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.cboCliente)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.Name = "FrmArmadoVenta"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FrmArmadoVenta"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox4.ResumeLayout(False)
		Me.gboFiltros.ResumeLayout(False)
		Me.gboFiltros.PerformLayout()
		Me.GroupBox5.ResumeLayout(False)
		Me.gboTotales.ResumeLayout(False)
		Me.gboTotales.PerformLayout()
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
	Friend WithEvents Label15 As Windows.Forms.Label
	Friend WithEvents lbldesde As Windows.Forms.Label
	Friend WithEvents lblHasta As Windows.Forms.Label
	Friend WithEvents rbtFechaExacta As Windows.Forms.CheckBox
	Friend WithEvents rbtEntreFechas As Windows.Forms.CheckBox
	Friend WithEvents dtpFechaHasta As Windows.Forms.DateTimePicker
	Friend WithEvents dtpFechaDesde As Windows.Forms.DateTimePicker
	Friend WithEvents lblFechaExacta As Windows.Forms.Label
	Friend WithEvents cboBusUsuarios As Windows.Forms.ComboBox
	Friend WithEvents Label9 As Windows.Forms.Label
	Friend WithEvents btnBuscar As Windows.Forms.Button
	Friend WithEvents btnLimpiarFiltros As Windows.Forms.Button
End Class
