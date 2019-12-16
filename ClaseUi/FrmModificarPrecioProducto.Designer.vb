<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModificarPrecioProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarPrecioProducto))
        Me.ttpAdicionar = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ttpExacto = New System.Windows.Forms.RichTextBox()
        Me.rbtFechaExacta = New System.Windows.Forms.CheckBox()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaExacta = New System.Windows.Forms.Label()
        Me.txtBusNombreProducto = New System.Windows.Forms.TextBox()
        Me.ttpPorcentaje = New System.Windows.Forms.RichTextBox()
        Me.ttpInfoGral = New System.Windows.Forms.RichTextBox()
        Me.rbtEntreFechas = New System.Windows.Forms.CheckBox()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnTtpAdicion = New System.Windows.Forms.Button()
        Me.btnTtpExacto = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAdicionar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gboFiltros = New System.Windows.Forms.GroupBox()
        Me.cboCategorias = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbldesde = New System.Windows.Forms.Label()
        Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.btnTtpPorcentaje = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnTtpGral = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gboFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'ttpAdicionar
        '
        Me.ttpAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttpAdicionar.Location = New System.Drawing.Point(230, 361)
        Me.ttpAdicionar.Margin = New System.Windows.Forms.Padding(2)
        Me.ttpAdicionar.Name = "ttpAdicionar"
        Me.ttpAdicionar.Size = New System.Drawing.Size(380, 58)
        Me.ttpAdicionar.TabIndex = 98
        Me.ttpAdicionar.Text = resources.GetString("ttpAdicionar.Text")
        Me.ttpAdicionar.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(2, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Nombre producto"
        '
        'ttpExacto
        '
        Me.ttpExacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttpExacto.Location = New System.Drawing.Point(228, 300)
        Me.ttpExacto.Margin = New System.Windows.Forms.Padding(2)
        Me.ttpExacto.Name = "ttpExacto"
        Me.ttpExacto.Size = New System.Drawing.Size(380, 45)
        Me.ttpExacto.TabIndex = 97
        Me.ttpExacto.Text = "En este campo, el numero que ingrese será el nuevo precio de los productos selecc" &
    "ionados. Ej. 150 hará que el nuevo precio de todos los productos seleccionados s" &
    "ea de $105"
        Me.ttpExacto.Visible = False
        '
        'rbtFechaExacta
        '
        Me.rbtFechaExacta.AutoSize = True
        Me.rbtFechaExacta.Location = New System.Drawing.Point(8, 75)
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
        Me.dtpFechaHasta.Location = New System.Drawing.Point(287, 102)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(114, 20)
        Me.dtpFechaHasta.TabIndex = 48
        Me.dtpFechaHasta.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(124, 102)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(114, 20)
        Me.dtpFechaDesde.TabIndex = 47
        Me.dtpFechaDesde.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
        '
        'lblFechaExacta
        '
        Me.lblFechaExacta.AutoSize = True
        Me.lblFechaExacta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.lblFechaExacta.Location = New System.Drawing.Point(5, 106)
        Me.lblFechaExacta.Name = "lblFechaExacta"
        Me.lblFechaExacta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaExacta.TabIndex = 46
        Me.lblFechaExacta.Text = "Fecha carga"
        '
        'txtBusNombreProducto
        '
        Me.txtBusNombreProducto.Location = New System.Drawing.Point(4, 48)
        Me.txtBusNombreProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBusNombreProducto.Name = "txtBusNombreProducto"
        Me.txtBusNombreProducto.Size = New System.Drawing.Size(152, 20)
        Me.txtBusNombreProducto.TabIndex = 41
        '
        'ttpPorcentaje
        '
        Me.ttpPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttpPorcentaje.Location = New System.Drawing.Point(228, 232)
        Me.ttpPorcentaje.Margin = New System.Windows.Forms.Padding(2)
        Me.ttpPorcentaje.Name = "ttpPorcentaje"
        Me.ttpPorcentaje.Size = New System.Drawing.Size(380, 45)
        Me.ttpPorcentaje.TabIndex = 96
        Me.ttpPorcentaje.Text = "En este campo, introduciendo el porcentaje deseado. Ej: 15 aumentará 15 por cient" &
    "o. -2 bajará 2 por ciento"
        Me.ttpPorcentaje.Visible = False
        '
        'ttpInfoGral
        '
        Me.ttpInfoGral.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttpInfoGral.Location = New System.Drawing.Point(291, 176)
        Me.ttpInfoGral.Margin = New System.Windows.Forms.Padding(2)
        Me.ttpInfoGral.Name = "ttpInfoGral"
        Me.ttpInfoGral.Size = New System.Drawing.Size(315, 32)
        Me.ttpInfoGral.TabIndex = 95
        Me.ttpInfoGral.Text = "Puede incrementar o decrecer el precio de uno o varios productos "
        Me.ttpInfoGral.Visible = False
        '
        'rbtEntreFechas
        '
        Me.rbtEntreFechas.AutoSize = True
        Me.rbtEntreFechas.Location = New System.Drawing.Point(250, 75)
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
        Me.lblHasta.Location = New System.Drawing.Point(244, 106)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(39, 13)
        Me.lblHasta.TabIndex = 51
        Me.lblHasta.Text = "Hasta"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(416, 75)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(45, 55)
        Me.btnBuscar.TabIndex = 38
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnTtpAdicion
        '
        Me.btnTtpAdicion.BackColor = System.Drawing.SystemColors.Control
        Me.btnTtpAdicion.BackgroundImage = Global.ClaseUi.My.Resources.Resources.PNGIX_com_ask_icon_png_3810269__2_
        Me.btnTtpAdicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTtpAdicion.FlatAppearance.BorderSize = 0
        Me.btnTtpAdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTtpAdicion.Location = New System.Drawing.Point(499, 409)
        Me.btnTtpAdicion.Name = "btnTtpAdicion"
        Me.btnTtpAdicion.Size = New System.Drawing.Size(29, 33)
        Me.btnTtpAdicion.TabIndex = 94
        Me.btnTtpAdicion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTtpAdicion.UseVisualStyleBackColor = False
        '
        'btnTtpExacto
        '
        Me.btnTtpExacto.BackColor = System.Drawing.SystemColors.Control
        Me.btnTtpExacto.BackgroundImage = Global.ClaseUi.My.Resources.Resources.PNGIX_com_ask_icon_png_3810269__2_
        Me.btnTtpExacto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTtpExacto.FlatAppearance.BorderSize = 0
        Me.btnTtpExacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTtpExacto.Location = New System.Drawing.Point(499, 347)
        Me.btnTtpExacto.Name = "btnTtpExacto"
        Me.btnTtpExacto.Size = New System.Drawing.Size(29, 33)
        Me.btnTtpExacto.TabIndex = 93
        Me.btnTtpExacto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTtpExacto.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(415, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 67)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Complete un campo a actualizar"
        '
        'txtAdicionar
        '
        Me.txtAdicionar.Location = New System.Drawing.Point(417, 445)
        Me.txtAdicionar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAdicionar.Name = "txtAdicionar"
        Me.txtAdicionar.Size = New System.Drawing.Size(76, 20)
        Me.txtAdicionar.TabIndex = 89
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(415, 409)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 33)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Utilidad a adicionar"
        '
        'gboFiltros
        '
        Me.gboFiltros.Controls.Add(Me.cboCategorias)
        Me.gboFiltros.Controls.Add(Me.Label5)
        Me.gboFiltros.Controls.Add(Me.Button1)
        Me.gboFiltros.Controls.Add(Me.cboProveedor)
        Me.gboFiltros.Controls.Add(Me.Label17)
        Me.gboFiltros.Controls.Add(Me.lbldesde)
        Me.gboFiltros.Controls.Add(Me.btnLimpiarFiltros)
        Me.gboFiltros.Controls.Add(Me.rbtEntreFechas)
        Me.gboFiltros.Controls.Add(Me.lblHasta)
        Me.gboFiltros.Controls.Add(Me.btnBuscar)
        Me.gboFiltros.Controls.Add(Me.rbtFechaExacta)
        Me.gboFiltros.Controls.Add(Me.dtpFechaHasta)
        Me.gboFiltros.Controls.Add(Me.dtpFechaDesde)
        Me.gboFiltros.Controls.Add(Me.lblFechaExacta)
        Me.gboFiltros.Controls.Add(Me.txtBusNombreProducto)
        Me.gboFiltros.Controls.Add(Me.Label8)
        Me.gboFiltros.Location = New System.Drawing.Point(8, 31)
        Me.gboFiltros.Margin = New System.Windows.Forms.Padding(2)
        Me.gboFiltros.Name = "gboFiltros"
        Me.gboFiltros.Padding = New System.Windows.Forms.Padding(2)
        Me.gboFiltros.Size = New System.Drawing.Size(579, 154)
        Me.gboFiltros.TabIndex = 87
        Me.gboFiltros.TabStop = False
        Me.gboFiltros.Text = "Búsqueda para chequear"
        '
        'cboCategorias
        '
        Me.cboCategorias.AccessibleDescription = ""
        Me.cboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategorias.FormattingEnabled = True
        Me.cboCategorias.Location = New System.Drawing.Point(395, 48)
        Me.cboCategorias.Name = "cboCategorias"
        Me.cboCategorias.Size = New System.Drawing.Size(172, 21)
        Me.cboCategorias.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(393, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Categoria de producto"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.check_all_icon_54_32x32
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(526, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 51)
        Me.Button1.TabIndex = 55
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cboProveedor
        '
        Me.cboProveedor.AccessibleDescription = ""
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Location = New System.Drawing.Point(180, 47)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(192, 21)
        Me.cboProveedor.TabIndex = 53
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(178, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Proveedor"
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.lbldesde.Location = New System.Drawing.Point(78, 106)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(43, 13)
        Me.lbldesde.TabIndex = 52
        Me.lbldesde.Text = "Desde"
        '
        'btnLimpiarFiltros
        '
        Me.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Control
        Me.btnLimpiarFiltros.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_clear_filters_40
        Me.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiarFiltros.FlatAppearance.BorderSize = 0
        Me.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarFiltros.Location = New System.Drawing.Point(467, 76)
        Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
        Me.btnLimpiarFiltros.Size = New System.Drawing.Size(48, 54)
        Me.btnLimpiarFiltros.TabIndex = 38
        Me.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiarFiltros.UseVisualStyleBackColor = False
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(417, 383)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(76, 20)
        Me.txtMonto.TabIndex = 86
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Location = New System.Drawing.Point(417, 318)
        Me.txtPorcentaje.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(76, 20)
        Me.txtPorcentaje.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(4, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(303, 20)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Actualizador de precio de producto"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(415, 347)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 33)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Precio exacto nuevo"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(8, 241)
        Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(402, 199)
        Me.CheckedListBox1.TabIndex = 79
        '
        'btnTtpPorcentaje
        '
        Me.btnTtpPorcentaje.BackColor = System.Drawing.SystemColors.Control
        Me.btnTtpPorcentaje.BackgroundImage = Global.ClaseUi.My.Resources.Resources.PNGIX_com_ask_icon_png_3810269__2_
        Me.btnTtpPorcentaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTtpPorcentaje.FlatAppearance.BorderSize = 0
        Me.btnTtpPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTtpPorcentaje.Location = New System.Drawing.Point(499, 283)
        Me.btnTtpPorcentaje.Name = "btnTtpPorcentaje"
        Me.btnTtpPorcentaje.Size = New System.Drawing.Size(29, 33)
        Me.btnTtpPorcentaje.TabIndex = 92
        Me.btnTtpPorcentaje.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTtpPorcentaje.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(527, 387)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(80, 81)
        Me.btnSalir.TabIndex = 80
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnTtpGral
        '
        Me.btnTtpGral.BackColor = System.Drawing.SystemColors.Control
        Me.btnTtpGral.BackgroundImage = Global.ClaseUi.My.Resources.Resources.PNGIX_com_ask_icon_png_3810269__2_
        Me.btnTtpGral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnTtpGral.FlatAppearance.BorderSize = 0
        Me.btnTtpGral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTtpGral.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTtpGral.Location = New System.Drawing.Point(501, 210)
        Me.btnTtpGral.Name = "btnTtpGral"
        Me.btnTtpGral.Size = New System.Drawing.Size(22, 22)
        Me.btnTtpGral.TabIndex = 91
        Me.btnTtpGral.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTtpGral.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Location = New System.Drawing.Point(529, 301)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(80, 80)
        Me.btnNuevo.TabIndex = 81
        Me.btnNuevo.Text = "Finalizar"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(415, 283)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 33)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Porcentaje a modificar"
        '
        'FrmModificarPrecioProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 476)
        Me.Controls.Add(Me.ttpAdicionar)
        Me.Controls.Add(Me.ttpExacto)
        Me.Controls.Add(Me.ttpPorcentaje)
        Me.Controls.Add(Me.ttpInfoGral)
        Me.Controls.Add(Me.btnTtpAdicion)
        Me.Controls.Add(Me.btnTtpExacto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtAdicionar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gboFiltros)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.txtPorcentaje)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.btnTtpPorcentaje)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnTtpGral)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmModificarPrecioProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar precios productos"
        Me.gboFiltros.ResumeLayout(False)
        Me.gboFiltros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ttpAdicionar As Windows.Forms.RichTextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents ttpExacto As Windows.Forms.RichTextBox
    Friend WithEvents rbtFechaExacta As Windows.Forms.CheckBox
    Friend WithEvents dtpFechaHasta As Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaDesde As Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaExacta As Windows.Forms.Label
    Friend WithEvents txtBusNombreProducto As Windows.Forms.TextBox
    Friend WithEvents ttpPorcentaje As Windows.Forms.RichTextBox
    Friend WithEvents ttpInfoGral As Windows.Forms.RichTextBox
    Friend WithEvents rbtEntreFechas As Windows.Forms.CheckBox
    Friend WithEvents lblHasta As Windows.Forms.Label
    Friend WithEvents btnBuscar As Windows.Forms.Button
    Friend WithEvents btnTtpAdicion As Windows.Forms.Button
    Friend WithEvents btnTtpExacto As Windows.Forms.Button
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txtAdicionar As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents gboFiltros As Windows.Forms.GroupBox
    Friend WithEvents cboCategorias As Windows.Forms.ComboBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents cboProveedor As Windows.Forms.ComboBox
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents lbldesde As Windows.Forms.Label
    Friend WithEvents btnLimpiarFiltros As Windows.Forms.Button
    Friend WithEvents txtMonto As Windows.Forms.TextBox
    Friend WithEvents txtPorcentaje As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents CheckedListBox1 As Windows.Forms.CheckedListBox
    Friend WithEvents btnTtpPorcentaje As Windows.Forms.Button
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents btnTtpGral As Windows.Forms.Button
    Friend WithEvents btnNuevo As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
