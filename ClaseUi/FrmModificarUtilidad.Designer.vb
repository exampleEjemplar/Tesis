﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarUtilidad
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarUtilidad))
		Me.btnTtpAdicion = New System.Windows.Forms.Button()
		Me.btnTtpExacto = New System.Windows.Forms.Button()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtAdicionar = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.cboCategorias = New System.Windows.Forms.ComboBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.cboProveedor = New System.Windows.Forms.ComboBox()
		Me.btnTtpGral = New System.Windows.Forms.Button()
		Me.btnNuevo = New System.Windows.Forms.Button()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.lbldesde = New System.Windows.Forms.Label()
		Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
		Me.rbtEntreFechas = New System.Windows.Forms.CheckBox()
		Me.lblHasta = New System.Windows.Forms.Label()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.ttpAdicionar = New System.Windows.Forms.RichTextBox()
		Me.ttpPorcentaje = New System.Windows.Forms.RichTextBox()
		Me.ttpInfoGral = New System.Windows.Forms.RichTextBox()
		Me.btnTtpPorcentaje = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.rbtFechaExacta = New System.Windows.Forms.CheckBox()
		Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
		Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
		Me.lblFechaExacta = New System.Windows.Forms.Label()
		Me.txtBusNombreProducto = New System.Windows.Forms.TextBox()
		Me.ttpExacto = New System.Windows.Forms.RichTextBox()
		Me.gboFiltros = New System.Windows.Forms.GroupBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtMonto = New System.Windows.Forms.TextBox()
		Me.txtPorcentaje = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
		Me.gboFiltros.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnTtpAdicion
		'
		Me.btnTtpAdicion.BackColor = System.Drawing.SystemColors.Control
		Me.btnTtpAdicion.BackgroundImage = Global.ClaseUi.My.Resources.Resources.PNGIX_com_ask_icon_png_3810269__2_
		Me.btnTtpAdicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnTtpAdicion.FlatAppearance.BorderSize = 0
		Me.btnTtpAdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnTtpAdicion.Location = New System.Drawing.Point(667, 499)
		Me.btnTtpAdicion.Margin = New System.Windows.Forms.Padding(4)
		Me.btnTtpAdicion.Name = "btnTtpAdicion"
		Me.btnTtpAdicion.Size = New System.Drawing.Size(39, 41)
		Me.btnTtpAdicion.TabIndex = 74
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
		Me.btnTtpExacto.Location = New System.Drawing.Point(667, 422)
		Me.btnTtpExacto.Margin = New System.Windows.Forms.Padding(4)
		Me.btnTtpExacto.Name = "btnTtpExacto"
		Me.btnTtpExacto.Size = New System.Drawing.Size(39, 41)
		Me.btnTtpExacto.TabIndex = 73
		Me.btnTtpExacto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnTtpExacto.UseVisualStyleBackColor = False
		'
		'Label11
		'
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label11.Location = New System.Drawing.Point(555, 253)
		Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(115, 82)
		Me.Label11.TabIndex = 70
		Me.Label11.Text = "Complete un campo a actualizar"
		'
		'txtAdicionar
		'
		Me.txtAdicionar.Location = New System.Drawing.Point(557, 543)
		Me.txtAdicionar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.txtAdicionar.Name = "txtAdicionar"
		Me.txtAdicionar.Size = New System.Drawing.Size(100, 22)
		Me.txtAdicionar.TabIndex = 69
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(555, 499)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(112, 41)
		Me.Label4.TabIndex = 68
		Me.Label4.Text = "Utilidad a adicionar"
		'
		'cboCategorias
		'
		Me.cboCategorias.AccessibleDescription = ""
		Me.cboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCategorias.FormattingEnabled = True
		Me.cboCategorias.Location = New System.Drawing.Point(527, 59)
		Me.cboCategorias.Margin = New System.Windows.Forms.Padding(4)
		Me.cboCategorias.Name = "cboCategorias"
		Me.cboCategorias.Size = New System.Drawing.Size(228, 25)
		Me.cboCategorias.TabIndex = 56
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(524, 26)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(170, 17)
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
		Me.Button1.Location = New System.Drawing.Point(701, 97)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(64, 63)
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
		Me.cboProveedor.Location = New System.Drawing.Point(240, 58)
		Me.cboProveedor.Margin = New System.Windows.Forms.Padding(4)
		Me.cboProveedor.Name = "cboProveedor"
		Me.cboProveedor.Size = New System.Drawing.Size(255, 25)
		Me.cboProveedor.TabIndex = 53
		'
		'btnTtpGral
		'
		Me.btnTtpGral.BackColor = System.Drawing.SystemColors.Control
		Me.btnTtpGral.BackgroundImage = Global.ClaseUi.My.Resources.Resources.PNGIX_com_ask_icon_png_3810269__2_
		Me.btnTtpGral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnTtpGral.FlatAppearance.BorderSize = 0
		Me.btnTtpGral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnTtpGral.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnTtpGral.Location = New System.Drawing.Point(669, 253)
		Me.btnTtpGral.Margin = New System.Windows.Forms.Padding(4)
		Me.btnTtpGral.Name = "btnTtpGral"
		Me.btnTtpGral.Size = New System.Drawing.Size(29, 27)
		Me.btnTtpGral.TabIndex = 71
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
		Me.btnNuevo.Location = New System.Drawing.Point(707, 365)
		Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevo.Name = "btnNuevo"
		Me.btnNuevo.Size = New System.Drawing.Size(107, 98)
		Me.btnNuevo.TabIndex = 61
		Me.btnNuevo.Text = "Finalizar"
		Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevo.UseVisualStyleBackColor = False
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(237, 26)
		Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(83, 17)
		Me.Label17.TabIndex = 54
		Me.Label17.Text = "Proveedor"
		'
		'lbldesde
		'
		Me.lbldesde.AutoSize = True
		Me.lbldesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
		Me.lbldesde.Location = New System.Drawing.Point(104, 130)
		Me.lbldesde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lbldesde.Name = "lbldesde"
		Me.lbldesde.Size = New System.Drawing.Size(54, 16)
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
		Me.btnLimpiarFiltros.Location = New System.Drawing.Point(623, 94)
		Me.btnLimpiarFiltros.Margin = New System.Windows.Forms.Padding(4)
		Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
		Me.btnLimpiarFiltros.Size = New System.Drawing.Size(64, 66)
		Me.btnLimpiarFiltros.TabIndex = 38
		Me.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnLimpiarFiltros.UseVisualStyleBackColor = False
		'
		'rbtEntreFechas
		'
		Me.rbtEntreFechas.AutoSize = True
		Me.rbtEntreFechas.Location = New System.Drawing.Point(333, 92)
		Me.rbtEntreFechas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
		Me.lblHasta.Location = New System.Drawing.Point(325, 130)
		Me.lblHasta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblHasta.Name = "lblHasta"
		Me.lblHasta.Size = New System.Drawing.Size(49, 16)
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
		Me.btnBuscar.Location = New System.Drawing.Point(555, 92)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(60, 68)
		Me.btnBuscar.TabIndex = 38
		Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'ttpAdicionar
		'
		Me.ttpAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ttpAdicionar.Location = New System.Drawing.Point(308, 439)
		Me.ttpAdicionar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.ttpAdicionar.Name = "ttpAdicionar"
		Me.ttpAdicionar.Size = New System.Drawing.Size(505, 70)
		Me.ttpAdicionar.TabIndex = 78
		Me.ttpAdicionar.Text = resources.GetString("ttpAdicionar.Text")
		Me.ttpAdicionar.Visible = False
		'
		'ttpPorcentaje
		'
		Me.ttpPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ttpPorcentaje.Location = New System.Drawing.Point(305, 280)
		Me.ttpPorcentaje.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.ttpPorcentaje.Name = "ttpPorcentaje"
		Me.ttpPorcentaje.Size = New System.Drawing.Size(505, 54)
		Me.ttpPorcentaje.TabIndex = 76
		Me.ttpPorcentaje.Text = "En este campo, introduciendo el porcentaje deseado. Ej: 15 aumentará 15 por cient" &
	 "o. -2 bajará 2 por ciento"
		Me.ttpPorcentaje.Visible = False
		'
		'ttpInfoGral
		'
		Me.ttpInfoGral.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ttpInfoGral.Location = New System.Drawing.Point(389, 212)
		Me.ttpInfoGral.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.ttpInfoGral.Name = "ttpInfoGral"
		Me.ttpInfoGral.Size = New System.Drawing.Size(419, 38)
		Me.ttpInfoGral.TabIndex = 75
		Me.ttpInfoGral.Text = "Puede incrementar o decrecer la utilidad de uno o varios productos "
		Me.ttpInfoGral.Visible = False
		'
		'btnTtpPorcentaje
		'
		Me.btnTtpPorcentaje.BackColor = System.Drawing.SystemColors.Control
		Me.btnTtpPorcentaje.BackgroundImage = Global.ClaseUi.My.Resources.Resources.PNGIX_com_ask_icon_png_3810269__2_
		Me.btnTtpPorcentaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnTtpPorcentaje.FlatAppearance.BorderSize = 0
		Me.btnTtpPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnTtpPorcentaje.Location = New System.Drawing.Point(667, 343)
		Me.btnTtpPorcentaje.Margin = New System.Windows.Forms.Padding(4)
		Me.btnTtpPorcentaje.Name = "btnTtpPorcentaje"
		Me.btnTtpPorcentaje.Size = New System.Drawing.Size(39, 41)
		Me.btnTtpPorcentaje.TabIndex = 72
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
		Me.btnSalir.Location = New System.Drawing.Point(704, 471)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(107, 100)
		Me.btnSalir.TabIndex = 60
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'rbtFechaExacta
		'
		Me.rbtFechaExacta.AutoSize = True
		Me.rbtFechaExacta.Location = New System.Drawing.Point(11, 92)
		Me.rbtFechaExacta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.rbtFechaExacta.Name = "rbtFechaExacta"
		Me.rbtFechaExacta.Size = New System.Drawing.Size(318, 21)
		Me.rbtFechaExacta.TabIndex = 50
		Me.rbtFechaExacta.Text = "Busqueda fecha exacta de carga de producto"
		Me.rbtFechaExacta.UseVisualStyleBackColor = True
		'
		'dtpFechaHasta
		'
		Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpFechaHasta.Location = New System.Drawing.Point(383, 126)
		Me.dtpFechaHasta.Margin = New System.Windows.Forms.Padding(4)
		Me.dtpFechaHasta.Name = "dtpFechaHasta"
		Me.dtpFechaHasta.Size = New System.Drawing.Size(151, 22)
		Me.dtpFechaHasta.TabIndex = 48
		Me.dtpFechaHasta.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
		'
		'dtpFechaDesde
		'
		Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpFechaDesde.Location = New System.Drawing.Point(165, 126)
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
		Me.lblFechaExacta.Location = New System.Drawing.Point(7, 130)
		Me.lblFechaExacta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblFechaExacta.Name = "lblFechaExacta"
		Me.lblFechaExacta.Size = New System.Drawing.Size(95, 16)
		Me.lblFechaExacta.TabIndex = 46
		Me.lblFechaExacta.Text = "Fecha carga"
		'
		'txtBusNombreProducto
		'
		Me.txtBusNombreProducto.Location = New System.Drawing.Point(5, 59)
		Me.txtBusNombreProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.txtBusNombreProducto.Name = "txtBusNombreProducto"
		Me.txtBusNombreProducto.Size = New System.Drawing.Size(201, 22)
		Me.txtBusNombreProducto.TabIndex = 41
		'
		'ttpExacto
		'
		Me.ttpExacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ttpExacto.Location = New System.Drawing.Point(305, 364)
		Me.ttpExacto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.ttpExacto.Name = "ttpExacto"
		Me.ttpExacto.Size = New System.Drawing.Size(505, 54)
		Me.ttpExacto.TabIndex = 77
		Me.ttpExacto.Text = "En este campo, el numero que ingrese será la nueva utilidad de los productos sele" &
	 "ccionados. Ej. 150 hará que la nueva utilidad de todos los productos seleccionad" &
	 "os sea de 150%"
		Me.ttpExacto.Visible = False
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
		Me.gboFiltros.Location = New System.Drawing.Point(12, 33)
		Me.gboFiltros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboFiltros.Name = "gboFiltros"
		Me.gboFiltros.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboFiltros.Size = New System.Drawing.Size(772, 190)
		Me.gboFiltros.TabIndex = 67
		Me.gboFiltros.TabStop = False
		Me.gboFiltros.Text = "Búsqueda para chequear"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
		Me.Label8.Location = New System.Drawing.Point(3, 26)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(128, 16)
		Me.Label8.TabIndex = 40
		Me.Label8.Text = "Nombre producto"
		'
		'txtMonto
		'
		Me.txtMonto.Location = New System.Drawing.Point(557, 466)
		Me.txtMonto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.txtMonto.Name = "txtMonto"
		Me.txtMonto.Size = New System.Drawing.Size(100, 22)
		Me.txtMonto.TabIndex = 66
		'
		'txtPorcentaje
		'
		Me.txtPorcentaje.Location = New System.Drawing.Point(557, 387)
		Me.txtPorcentaje.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.txtPorcentaje.Name = "txtPorcentaje"
		Me.txtPorcentaje.Size = New System.Drawing.Size(100, 22)
		Me.txtPorcentaje.TabIndex = 65
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label3.Location = New System.Drawing.Point(7, 6)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(392, 25)
		Me.Label3.TabIndex = 64
		Me.Label3.Text = "Actualizador de utilidad de producto"
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(555, 422)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(112, 41)
		Me.Label2.TabIndex = 63
		Me.Label2.Text = "Utilidad exacta nueva"
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(555, 343)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(109, 41)
		Me.Label1.TabIndex = 62
		Me.Label1.Text = "Porcentaje a modificar"
		'
		'CheckedListBox1
		'
		Me.CheckedListBox1.FormattingEnabled = True
		Me.CheckedListBox1.Location = New System.Drawing.Point(12, 292)
		Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.CheckedListBox1.Name = "CheckedListBox1"
		Me.CheckedListBox1.Size = New System.Drawing.Size(535, 259)
		Me.CheckedListBox1.TabIndex = 59
		'
		'FrmModificarUtilidad
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(824, 591)
		Me.Controls.Add(Me.ttpAdicionar)
		Me.Controls.Add(Me.ttpExacto)
		Me.Controls.Add(Me.ttpPorcentaje)
		Me.Controls.Add(Me.ttpInfoGral)
		Me.Controls.Add(Me.btnTtpAdicion)
		Me.Controls.Add(Me.btnTtpExacto)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.txtAdicionar)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.btnTtpGral)
		Me.Controls.Add(Me.btnNuevo)
		Me.Controls.Add(Me.btnTtpPorcentaje)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.gboFiltros)
		Me.Controls.Add(Me.txtMonto)
		Me.Controls.Add(Me.txtPorcentaje)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.CheckedListBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FrmModificarUtilidad"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Modificar Utilidad"
		Me.gboFiltros.ResumeLayout(False)
		Me.gboFiltros.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnTtpAdicion As Windows.Forms.Button
	Friend WithEvents btnTtpExacto As Windows.Forms.Button
	Friend WithEvents Label11 As Windows.Forms.Label
	Friend WithEvents txtAdicionar As Windows.Forms.TextBox
	Friend WithEvents Label4 As Windows.Forms.Label
	Friend WithEvents cboCategorias As Windows.Forms.ComboBox
	Friend WithEvents Label5 As Windows.Forms.Label
	Friend WithEvents Button1 As Windows.Forms.Button
	Friend WithEvents cboProveedor As Windows.Forms.ComboBox
	Friend WithEvents btnTtpGral As Windows.Forms.Button
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents lbldesde As Windows.Forms.Label
	Friend WithEvents btnLimpiarFiltros As Windows.Forms.Button
	Friend WithEvents rbtEntreFechas As Windows.Forms.CheckBox
	Friend WithEvents lblHasta As Windows.Forms.Label
	Friend WithEvents btnBuscar As Windows.Forms.Button
	Friend WithEvents ttpAdicionar As Windows.Forms.RichTextBox
	Friend WithEvents ttpPorcentaje As Windows.Forms.RichTextBox
	Friend WithEvents ttpInfoGral As Windows.Forms.RichTextBox
	Friend WithEvents btnTtpPorcentaje As Windows.Forms.Button
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents rbtFechaExacta As Windows.Forms.CheckBox
	Friend WithEvents dtpFechaHasta As Windows.Forms.DateTimePicker
	Friend WithEvents dtpFechaDesde As Windows.Forms.DateTimePicker
	Friend WithEvents lblFechaExacta As Windows.Forms.Label
	Friend WithEvents txtBusNombreProducto As Windows.Forms.TextBox
	Friend WithEvents ttpExacto As Windows.Forms.RichTextBox
	Friend WithEvents gboFiltros As Windows.Forms.GroupBox
	Friend WithEvents Label8 As Windows.Forms.Label
	Friend WithEvents txtMonto As Windows.Forms.TextBox
	Friend WithEvents txtPorcentaje As Windows.Forms.TextBox
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents CheckedListBox1 As Windows.Forms.CheckedListBox
End Class
