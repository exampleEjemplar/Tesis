<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArmadoPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArmadoPedido))
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.btnQuitarItem = New System.Windows.Forms.Button()
        Me.gboFiltros = New System.Windows.Forms.GroupBox()
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
        Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gboTotales = New System.Windows.Forms.GroupBox()
        Me.chkSeñaManual = New System.Windows.Forms.CheckBox()
        Me.txtSeña = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblRestaCobrar = New System.Windows.Forms.Label()
        Me.cboPorcentaje = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblSeña = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblClienteDireccion = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblClienteDNI = New System.Windows.Forms.Label()
        Me.lblClienteTelefono = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstProdDispo = New System.Windows.Forms.ListView()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gboFiltros.SuspendLayout()
        Me.gboTotales.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.BackColor = System.Drawing.SystemColors.Control
        Me.btnAgregarProducto.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_add_354
        Me.btnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAgregarProducto.FlatAppearance.BorderSize = 0
        Me.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProducto.Location = New System.Drawing.Point(498, 10)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(130, 42)
        Me.btnAgregarProducto.TabIndex = 52
        Me.btnAgregarProducto.Text = "Agregar producto"
        Me.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarProducto.UseVisualStyleBackColor = False
        '
        'btnQuitarItem
        '
        Me.btnQuitarItem.BackColor = System.Drawing.SystemColors.Control
        Me.btnQuitarItem.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_cancel_62
        Me.btnQuitarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnQuitarItem.FlatAppearance.BorderSize = 0
        Me.btnQuitarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarItem.Location = New System.Drawing.Point(489, 341)
        Me.btnQuitarItem.Name = "btnQuitarItem"
        Me.btnQuitarItem.Size = New System.Drawing.Size(70, 97)
        Me.btnQuitarItem.TabIndex = 37
        Me.btnQuitarItem.Text = "Quitar item"
        Me.btnQuitarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnQuitarItem.UseVisualStyleBackColor = False
        '
        'gboFiltros
        '
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
        Me.gboFiltros.Controls.Add(Me.btnLimpiarFiltros)
        Me.gboFiltros.Controls.Add(Me.btnBuscar)
        Me.gboFiltros.Controls.Add(Me.btnAgregarProducto)
        Me.gboFiltros.Location = New System.Drawing.Point(9, 225)
        Me.gboFiltros.Margin = New System.Windows.Forms.Padding(2)
        Me.gboFiltros.Name = "gboFiltros"
        Me.gboFiltros.Padding = New System.Windows.Forms.Padding(2)
        Me.gboFiltros.Size = New System.Drawing.Size(633, 111)
        Me.gboFiltros.TabIndex = 44
        Me.gboFiltros.TabStop = False
        Me.gboFiltros.Text = "Búsqueda"
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.lbldesde.Location = New System.Drawing.Point(79, 81)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(43, 13)
        Me.lbldesde.TabIndex = 52
        Me.lbldesde.Text = "Desde"
        '
        'rbtEntreFechas
        '
        Me.rbtEntreFechas.AutoSize = True
        Me.rbtEntreFechas.Location = New System.Drawing.Point(251, 50)
        Me.rbtEntreFechas.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtEntreFechas.Name = "rbtEntreFechas"
        Me.rbtEntreFechas.Size = New System.Drawing.Size(136, 17)
        Me.rbtEntreFechas.TabIndex = 49
        Me.rbtEntreFechas.Text = "Busqueda entre fechas"
        Me.rbtEntreFechas.UseVisualStyleBackColor = True
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.lblHasta.Location = New System.Drawing.Point(244, 81)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(39, 13)
        Me.lblHasta.TabIndex = 51
        Me.lblHasta.Text = "Hasta"
        '
        'rbtFechaExacta
        '
        Me.rbtFechaExacta.AutoSize = True
        Me.rbtFechaExacta.Location = New System.Drawing.Point(8, 50)
        Me.rbtFechaExacta.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtFechaExacta.Name = "rbtFechaExacta"
        Me.rbtFechaExacta.Size = New System.Drawing.Size(244, 17)
        Me.rbtFechaExacta.TabIndex = 50
        Me.rbtFechaExacta.Text = "Busqueda fecha exacta de carga de producto"
        Me.rbtFechaExacta.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(288, 78)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(114, 20)
        Me.dtpFechaHasta.TabIndex = 48
        Me.dtpFechaHasta.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(125, 78)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(114, 20)
        Me.dtpFechaDesde.TabIndex = 47
        Me.dtpFechaDesde.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
        '
        'lblFechaExacta
        '
        Me.lblFechaExacta.AutoSize = True
        Me.lblFechaExacta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.lblFechaExacta.Location = New System.Drawing.Point(6, 81)
        Me.lblFechaExacta.Name = "lblFechaExacta"
        Me.lblFechaExacta.Size = New System.Drawing.Size(117, 13)
        Me.lblFechaExacta.TabIndex = 46
        Me.lblFechaExacta.Text = "Fecha comprobante"
        '
        'txtBusNombreProducto
        '
        Me.txtBusNombreProducto.Location = New System.Drawing.Point(331, 18)
        Me.txtBusNombreProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBusNombreProducto.Name = "txtBusNombreProducto"
        Me.txtBusNombreProducto.Size = New System.Drawing.Size(152, 20)
        Me.txtBusNombreProducto.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(230, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
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
        Me.cboBusProveedor.Location = New System.Drawing.Point(73, 17)
        Me.cboBusProveedor.Name = "cboBusProveedor"
        Me.cboBusProveedor.Size = New System.Drawing.Size(152, 21)
        Me.cboBusProveedor.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(6, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Proveedor"
        '
        'btnLimpiarFiltros
        '
        Me.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Control
        Me.btnLimpiarFiltros.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_clear_filters_40
        Me.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiarFiltros.FlatAppearance.BorderSize = 0
        Me.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarFiltros.Location = New System.Drawing.Point(496, 50)
        Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
        Me.btnLimpiarFiltros.Size = New System.Drawing.Size(62, 55)
        Me.btnLimpiarFiltros.TabIndex = 38
        Me.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiarFiltros.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_search_48
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(570, 50)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(56, 54)
        Me.btnBuscar.TabIndex = 38
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'gboTotales
        '
        Me.gboTotales.Controls.Add(Me.chkSeñaManual)
        Me.gboTotales.Controls.Add(Me.txtSeña)
        Me.gboTotales.Controls.Add(Me.Label18)
        Me.gboTotales.Controls.Add(Me.lblRestaCobrar)
        Me.gboTotales.Controls.Add(Me.cboPorcentaje)
        Me.gboTotales.Controls.Add(Me.Label16)
        Me.gboTotales.Controls.Add(Me.Label15)
        Me.gboTotales.Controls.Add(Me.lblSeña)
        Me.gboTotales.Controls.Add(Me.Label11)
        Me.gboTotales.Controls.Add(Me.lblTotal)
        Me.gboTotales.Location = New System.Drawing.Point(9, 588)
        Me.gboTotales.Margin = New System.Windows.Forms.Padding(2)
        Me.gboTotales.Name = "gboTotales"
        Me.gboTotales.Padding = New System.Windows.Forms.Padding(2)
        Me.gboTotales.Size = New System.Drawing.Size(623, 74)
        Me.gboTotales.TabIndex = 48
        Me.gboTotales.TabStop = False
        Me.gboTotales.Text = "Totales"
        '
        'chkSeñaManual
        '
        Me.chkSeñaManual.AutoSize = True
        Me.chkSeñaManual.Location = New System.Drawing.Point(242, 18)
        Me.chkSeñaManual.Margin = New System.Windows.Forms.Padding(2)
        Me.chkSeñaManual.Name = "chkSeñaManual"
        Me.chkSeñaManual.Size = New System.Drawing.Size(160, 17)
        Me.chkSeñaManual.TabIndex = 57
        Me.chkSeñaManual.Text = "Cargar manualmente la seña"
        Me.chkSeñaManual.UseVisualStyleBackColor = True
        '
        'txtSeña
        '
        Me.txtSeña.Location = New System.Drawing.Point(90, 17)
        Me.txtSeña.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSeña.MaxLength = 10
        Me.txtSeña.Name = "txtSeña"
        Me.txtSeña.Size = New System.Drawing.Size(134, 20)
        Me.txtSeña.TabIndex = 53
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(406, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 26)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Resta cobrar"
        '
        'lblRestaCobrar
        '
        Me.lblRestaCobrar.AutoSize = True
        Me.lblRestaCobrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestaCobrar.Location = New System.Drawing.Point(518, 45)
        Me.lblRestaCobrar.Name = "lblRestaCobrar"
        Me.lblRestaCobrar.Size = New System.Drawing.Size(32, 13)
        Me.lblRestaCobrar.TabIndex = 55
        Me.lblRestaCobrar.Text = "0.00"
        '
        'cboPorcentaje
        '
        Me.cboPorcentaje.AccessibleDescription = ""
        Me.cboPorcentaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPorcentaje.FormattingEnabled = True
        Me.cboPorcentaje.Items.AddRange(New Object() {"50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.cboPorcentaje.Location = New System.Drawing.Point(148, 46)
        Me.cboPorcentaje.Name = "cboPorcentaje"
        Me.cboPorcentaje.Size = New System.Drawing.Size(77, 21)
        Me.cboPorcentaje.TabIndex = 54
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 20)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Porcentaje del total"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 20)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Seña"
        '
        'lblSeña
        '
        Me.lblSeña.AutoSize = True
        Me.lblSeña.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeña.Location = New System.Drawing.Point(93, 20)
        Me.lblSeña.Name = "lblSeña"
        Me.lblSeña.Size = New System.Drawing.Size(32, 13)
        Me.lblSeña.TabIndex = 31
        Me.lblSeña.Text = "0.00"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(406, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 24)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Total del pedido"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(518, 17)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(32, 13)
        Me.lblTotal.TabIndex = 26
        Me.lblTotal.Text = "0.00"
        '
        'ListView1
        '
        Me.ListView1.AllowDrop = True
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(374, 340)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(110, 246)
        Me.ListView1.TabIndex = 1
        Me.ListView1.TileSize = New System.Drawing.Size(120, 25)
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.BackColor = System.Drawing.SystemColors.Control
        Me.btnAgregarCliente.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_add_354
        Me.btnAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAgregarCliente.FlatAppearance.BorderSize = 0
        Me.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCliente.Location = New System.Drawing.Point(600, 43)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(34, 34)
        Me.btnAgregarCliente.TabIndex = 53
        Me.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarCliente.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Location = New System.Drawing.Point(570, 341)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(67, 97)
        Me.btnNuevo.TabIndex = 50
        Me.btnNuevo.Text = "Finalizar"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'cboCliente
        '
        Me.cboCliente.AccessibleDescription = ""
        Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.FormattingEnabled = True
        Me.cboCliente.Location = New System.Drawing.Point(70, 48)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(504, 21)
        Me.cboCliente.TabIndex = 40
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(10, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 17)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Cliente"
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
        Me.GroupBox1.Location = New System.Drawing.Point(9, 90)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(361, 132)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(8, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Teléfono"
        '
        'lblClienteDireccion
        '
        Me.lblClienteDireccion.AutoSize = True
        Me.lblClienteDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblClienteDireccion.Location = New System.Drawing.Point(136, 46)
        Me.lblClienteDireccion.Name = "lblClienteDireccion"
        Me.lblClienteDireccion.Size = New System.Drawing.Size(86, 16)
        Me.lblClienteDireccion.TabIndex = 30
        Me.lblClienteDireccion.Text = "*Direccion*"
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
        'lblClienteDNI
        '
        Me.lblClienteDNI.AutoSize = True
        Me.lblClienteDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblClienteDNI.Location = New System.Drawing.Point(136, 73)
        Me.lblClienteDNI.Name = "lblClienteDNI"
        Me.lblClienteDNI.Size = New System.Drawing.Size(46, 16)
        Me.lblClienteDNI.TabIndex = 29
        Me.lblClienteDNI.Text = "*DNI*"
        '
        'lblClienteTelefono
        '
        Me.lblClienteTelefono.AutoSize = True
        Me.lblClienteTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.lblClienteTelefono.Location = New System.Drawing.Point(136, 102)
        Me.lblClienteTelefono.Name = "lblClienteTelefono"
        Me.lblClienteTelefono.Size = New System.Drawing.Size(82, 16)
        Me.lblClienteTelefono.TabIndex = 27
        Me.lblClienteTelefono.Text = "*Telefono*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Identifación"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblNombre.Location = New System.Drawing.Point(64, 14)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(95, 18)
        Me.lblNombre.TabIndex = 26
        Me.lblNombre.Text = "*NOMBRE*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 20)
        Me.Label1.TabIndex = 42
		Me.Label1.Text = "Generar comprobante de pedido"
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
        Me.GroupBox2.Location = New System.Drawing.Point(374, 90)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(268, 132)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Local"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(5, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 16)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Teléfono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(124, 47)
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
        Me.Label3.Location = New System.Drawing.Point(124, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "23349892014"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(5, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Identifación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(124, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "351 4255463"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(62, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 18)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "JOYERIA CRIZOL"
        '
        'lstProdDispo
        '
        Me.lstProdDispo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProdDispo.GridLines = True
        Me.lstProdDispo.HideSelection = False
        Me.lstProdDispo.Location = New System.Drawing.Point(9, 340)
        Me.lstProdDispo.Margin = New System.Windows.Forms.Padding(2)
        Me.lstProdDispo.Name = "lstProdDispo"
        Me.lstProdDispo.Size = New System.Drawing.Size(362, 246)
        Me.lstProdDispo.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstProdDispo.TabIndex = 0
        Me.lstProdDispo.TileSize = New System.Drawing.Size(120, 25)
        Me.lstProdDispo.UseCompatibleStateImageBehavior = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Control
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpiar.Location = New System.Drawing.Point(491, 453)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(69, 87)
        Me.btnLimpiar.TabIndex = 54
        Me.btnLimpiar.Text = "Limpiar Compra"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(570, 453)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(69, 87)
        Me.btnSalir.TabIndex = 55
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'FrmArmadoPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 668)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.gboFiltros)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lstProdDispo)
        Me.Controls.Add(Me.gboTotales)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.cboCliente)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnQuitarItem)
        Me.Controls.Add(Me.btnNuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmArmadoPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Generar pedido"
		Me.gboFiltros.ResumeLayout(False)
        Me.gboFiltros.PerformLayout()
        Me.gboTotales.ResumeLayout(False)
        Me.gboTotales.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregarProducto As Windows.Forms.Button
	Friend WithEvents btnQuitarItem As Windows.Forms.Button
    Friend WithEvents gboFiltros As Windows.Forms.GroupBox
    Friend WithEvents btnLimpiarFiltros As Windows.Forms.Button
    Friend WithEvents btnBuscar As Windows.Forms.Button
    Friend WithEvents lbldesde As Windows.Forms.Label
    Friend WithEvents rbtEntreFechas As Windows.Forms.CheckBox
    Friend WithEvents lblHasta As Windows.Forms.Label
    Friend WithEvents rbtFechaExacta As Windows.Forms.CheckBox
    Friend WithEvents dtpFechaHasta As Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaDesde As Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaExacta As Windows.Forms.Label
    Friend WithEvents txtBusNombreProducto As Windows.Forms.TextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents cboBusProveedor As Windows.Forms.ComboBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents gboTotales As Windows.Forms.GroupBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents lblTotal As Windows.Forms.Label
    Friend WithEvents ListView1 As Windows.Forms.ListView
    Friend WithEvents btnAgregarCliente As Windows.Forms.Button
    Friend WithEvents btnNuevo As Windows.Forms.Button
    Friend WithEvents PrintDialog1 As Windows.Forms.PrintDialog
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents cboCliente As Windows.Forms.ComboBox
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents lblClienteDireccion As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents lblClienteDNI As Windows.Forms.Label
    Friend WithEvents lblClienteTelefono As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents lblNombre As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label13 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label14 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents lstProdDispo As Windows.Forms.ListView
    Friend WithEvents cboPorcentaje As Windows.Forms.ComboBox
    Friend WithEvents Label16 As Windows.Forms.Label
    Friend WithEvents Label15 As Windows.Forms.Label
    Friend WithEvents lblSeña As Windows.Forms.Label
    Friend WithEvents Label18 As Windows.Forms.Label
    Friend WithEvents lblRestaCobrar As Windows.Forms.Label
    Friend WithEvents chkSeñaManual As Windows.Forms.CheckBox
    Friend WithEvents txtSeña As Windows.Forms.TextBox
    Friend WithEvents btnLimpiar As Windows.Forms.Button
End Class
