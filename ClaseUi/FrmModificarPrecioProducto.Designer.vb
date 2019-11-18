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
		Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtPorcentaje = New System.Windows.Forms.TextBox()
		Me.txtMonto = New System.Windows.Forms.TextBox()
		Me.gboFiltros = New System.Windows.Forms.GroupBox()
		Me.cboCategorias = New System.Windows.Forms.ComboBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.cboProveedor = New System.Windows.Forms.ComboBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.lbldesde = New System.Windows.Forms.Label()
		Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
		Me.rbtEntreFechas = New System.Windows.Forms.CheckBox()
		Me.lblHasta = New System.Windows.Forms.Label()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.rbtFechaExacta = New System.Windows.Forms.CheckBox()
		Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
		Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
		Me.lblFechaExacta = New System.Windows.Forms.Label()
		Me.txtBusNombreProducto = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtAdicionar = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.btnNuevo = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.ttpInfoGral = New System.Windows.Forms.RichTextBox()
		Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.gboFiltros.SuspendLayout()
		Me.SuspendLayout()
		'
		'CheckedListBox1
		'
		Me.CheckedListBox1.FormattingEnabled = True
		Me.CheckedListBox1.Location = New System.Drawing.Point(12, 296)
		Me.CheckedListBox1.Name = "CheckedListBox1"
		Me.CheckedListBox1.Size = New System.Drawing.Size(535, 276)
		Me.CheckedListBox1.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(555, 346)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(109, 41)
		Me.Label1.TabIndex = 39
		Me.Label1.Text = "Porcentaje a modificar"
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(555, 425)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(112, 41)
		Me.Label2.TabIndex = 41
		Me.Label2.Text = "Monto exacto nuevo"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label3.Location = New System.Drawing.Point(7, 9)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(392, 25)
		Me.Label3.TabIndex = 44
		Me.Label3.Text = "Actualizador de precios de producto"
		'
		'txtPorcentaje
		'
		Me.txtPorcentaje.Location = New System.Drawing.Point(558, 390)
		Me.txtPorcentaje.Name = "txtPorcentaje"
		Me.txtPorcentaje.Size = New System.Drawing.Size(100, 22)
		Me.txtPorcentaje.TabIndex = 45
		'
		'txtMonto
		'
		Me.txtMonto.Location = New System.Drawing.Point(558, 469)
		Me.txtMonto.Name = "txtMonto"
		Me.txtMonto.Size = New System.Drawing.Size(100, 22)
		Me.txtMonto.TabIndex = 46
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
		Me.gboFiltros.Location = New System.Drawing.Point(12, 36)
		Me.gboFiltros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboFiltros.Name = "gboFiltros"
		Me.gboFiltros.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboFiltros.Size = New System.Drawing.Size(772, 189)
		Me.gboFiltros.TabIndex = 47
		Me.gboFiltros.TabStop = False
		Me.gboFiltros.Text = "Filtros para chequear"
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
		Me.Button1.Location = New System.Drawing.Point(695, 93)
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
		Me.cboProveedor.Size = New System.Drawing.Size(254, 25)
		Me.cboProveedor.TabIndex = 53
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
		Me.btnLimpiarFiltros.Location = New System.Drawing.Point(623, 93)
		Me.btnLimpiarFiltros.Margin = New System.Windows.Forms.Padding(4)
		Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
		Me.btnLimpiarFiltros.Size = New System.Drawing.Size(64, 67)
		Me.btnLimpiarFiltros.TabIndex = 38
		Me.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnLimpiarFiltros.UseVisualStyleBackColor = False
		'
		'rbtEntreFechas
		'
		Me.rbtEntreFechas.AutoSize = True
		Me.rbtEntreFechas.Location = New System.Drawing.Point(334, 92)
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
		Me.btnBuscar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_checkmark_62
		Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnBuscar.FlatAppearance.BorderSize = 0
		Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscar.Location = New System.Drawing.Point(542, 93)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(73, 63)
		Me.btnBuscar.TabIndex = 38
		Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'rbtFechaExacta
		'
		Me.rbtFechaExacta.AutoSize = True
		Me.rbtFechaExacta.Location = New System.Drawing.Point(10, 92)
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
		Me.dtpFechaDesde.Location = New System.Drawing.Point(166, 126)
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
		Me.txtBusNombreProducto.Location = New System.Drawing.Point(6, 59)
		Me.txtBusNombreProducto.Name = "txtBusNombreProducto"
		Me.txtBusNombreProducto.Size = New System.Drawing.Size(201, 22)
		Me.txtBusNombreProducto.TabIndex = 41
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
		'txtAdicionar
		'
		Me.txtAdicionar.Location = New System.Drawing.Point(558, 546)
		Me.txtAdicionar.Name = "txtAdicionar"
		Me.txtAdicionar.Size = New System.Drawing.Size(100, 22)
		Me.txtAdicionar.TabIndex = 49
		'
		'Label4
		'
		Me.Label4.Location = New System.Drawing.Point(555, 502)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(112, 41)
		Me.Label4.TabIndex = 48
		Me.Label4.Text = "Monto a adicionar"
		'
		'Label11
		'
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label11.Location = New System.Drawing.Point(554, 256)
		Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(115, 82)
		Me.Label11.TabIndex = 50
		Me.Label11.Text = "Complete un campo a actualizar"
		'
		'Button5
		'
		Me.Button5.BackColor = System.Drawing.SystemColors.Control
		Me.Button5.BackgroundImage = Global.ClaseUi.My.Resources.Resources.PNGIX_com_ask_icon_png_3810269__2_
		Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button5.FlatAppearance.BorderSize = 0
		Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button5.Location = New System.Drawing.Point(667, 502)
		Me.Button5.Margin = New System.Windows.Forms.Padding(4)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(39, 41)
		Me.Button5.TabIndex = 54
		Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button5.UseVisualStyleBackColor = False
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.SystemColors.Control
		Me.Button4.BackgroundImage = Global.ClaseUi.My.Resources.Resources.PNGIX_com_ask_icon_png_3810269__2_
		Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button4.FlatAppearance.BorderSize = 0
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Location = New System.Drawing.Point(667, 425)
		Me.Button4.Margin = New System.Windows.Forms.Padding(4)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(39, 41)
		Me.Button4.TabIndex = 53
		Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button4.UseVisualStyleBackColor = False
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.SystemColors.Control
		Me.Button3.BackgroundImage = Global.ClaseUi.My.Resources.Resources.PNGIX_com_ask_icon_png_3810269__2_
		Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button3.FlatAppearance.BorderSize = 0
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Location = New System.Drawing.Point(667, 346)
		Me.Button3.Margin = New System.Windows.Forms.Padding(4)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(39, 41)
		Me.Button3.TabIndex = 52
		Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button3.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.SystemColors.Control
		Me.Button2.BackgroundImage = Global.ClaseUi.My.Resources.Resources.PNGIX_com_ask_icon_png_3810269__2_
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Button2.Location = New System.Drawing.Point(670, 256)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(29, 27)
		Me.Button2.TabIndex = 51
		Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button2.UseVisualStyleBackColor = False
		'
		'btnNuevo
		'
		Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevo.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
		Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevo.FlatAppearance.BorderSize = 0
		Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevo.Location = New System.Drawing.Point(707, 368)
		Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevo.Name = "btnNuevo"
		Me.btnNuevo.Size = New System.Drawing.Size(107, 98)
		Me.btnNuevo.TabIndex = 37
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
		Me.btnSalir.Location = New System.Drawing.Point(704, 474)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(107, 100)
		Me.btnSalir.TabIndex = 36
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'ttpInfoGral
		'
		Me.ttpInfoGral.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ttpInfoGral.Location = New System.Drawing.Point(395, 215)
		Me.ttpInfoGral.Name = "ttpInfoGral"
		Me.ttpInfoGral.Size = New System.Drawing.Size(419, 38)
		Me.ttpInfoGral.TabIndex = 55
		Me.ttpInfoGral.Text = "Puede modificar el precio de uno o varios productos rellenando cualquiera de los " &
	 "campos de abajo"
		Me.ttpInfoGral.Visible = False
		'
		'RichTextBox1
		'
		Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RichTextBox1.Location = New System.Drawing.Point(308, 296)
		Me.RichTextBox1.Name = "RichTextBox1"
		Me.RichTextBox1.Size = New System.Drawing.Size(506, 55)
		Me.RichTextBox1.TabIndex = 56
		Me.RichTextBox1.Text = "Escribiendo en este cuadro puede incrementar o decrecer el precio de uno o varios" &
	 " productos introduciendo el porcentaje deseado. Ej: 15 aumentará 15 por ciento. " &
	 "-2 bajará 2 por ciento"
		Me.RichTextBox1.Visible = False
		'
		'FrmModificarPrecioProducto
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(819, 586)
		Me.Controls.Add(Me.RichTextBox1)
		Me.Controls.Add(Me.ttpInfoGral)
		Me.Controls.Add(Me.Button5)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.txtAdicionar)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.gboFiltros)
		Me.Controls.Add(Me.txtMonto)
		Me.Controls.Add(Me.txtPorcentaje)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnNuevo)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.CheckedListBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "FrmModificarPrecioProducto"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Modificar precios productos"
		Me.gboFiltros.ResumeLayout(False)
		Me.gboFiltros.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents CheckedListBox1 As Windows.Forms.CheckedListBox
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents txtPorcentaje As Windows.Forms.TextBox
	Friend WithEvents txtMonto As Windows.Forms.TextBox
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
	Friend WithEvents Button1 As Windows.Forms.Button
	Friend WithEvents cboProveedor As Windows.Forms.ComboBox
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents txtAdicionar As Windows.Forms.TextBox
	Friend WithEvents Label4 As Windows.Forms.Label
	Friend WithEvents Label11 As Windows.Forms.Label
	Friend WithEvents cboCategorias As Windows.Forms.ComboBox
	Friend WithEvents Label5 As Windows.Forms.Label
	Friend WithEvents Button2 As Windows.Forms.Button
	Friend WithEvents Button3 As Windows.Forms.Button
	Friend WithEvents Button4 As Windows.Forms.Button
	Friend WithEvents Button5 As Windows.Forms.Button
	Friend WithEvents ttpInfoGral As Windows.Forms.RichTextBox
	Friend WithEvents RichTextBox1 As Windows.Forms.RichTextBox
End Class
