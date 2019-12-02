<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestionStock))
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBusNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lbldesde = New System.Windows.Forms.Label()
        Me.rbtEntreFechas = New System.Windows.Forms.CheckBox()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.rbtFechaExacta = New System.Windows.Forms.CheckBox()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaExacta = New System.Windows.Forms.Label()
        Me.btnSalirr = New System.Windows.Forms.Button()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboOrden = New System.Windows.Forms.ComboBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblPrioridad3 = New System.Windows.Forms.Label()
        Me.lblPrioridad1 = New System.Windows.Forms.Label()
        Me.lblPrioridad2 = New System.Windows.Forms.Label()
        Me.chbListaParaOrdenar = New System.Windows.Forms.CheckedListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboProveedor
        '
        Me.cboProveedor.AccessibleDescription = ""
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Items.AddRange(New Object() {"Física", "Jurídica"})
        Me.cboProveedor.Location = New System.Drawing.Point(83, 15)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(179, 21)
        Me.cboProveedor.TabIndex = 57
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Proveedor"
        '
        'txtBusNombreProducto
        '
        Me.txtBusNombreProducto.Location = New System.Drawing.Point(83, 41)
        Me.txtBusNombreProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBusNombreProducto.Name = "txtBusNombreProducto"
        Me.txtBusNombreProducto.Size = New System.Drawing.Size(179, 20)
        Me.txtBusNombreProducto.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 29)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Nombre producto"
        '
        'btnLimpiarFiltros
        '
        Me.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Control
        Me.btnLimpiarFiltros.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_clear_filters_40
        Me.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiarFiltros.FlatAppearance.BorderSize = 0
        Me.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarFiltros.Location = New System.Drawing.Point(537, 77)
        Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
        Me.btnLimpiarFiltros.Size = New System.Drawing.Size(54, 56)
        Me.btnLimpiarFiltros.TabIndex = 62
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
        Me.btnBuscar.Location = New System.Drawing.Point(535, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(56, 59)
        Me.btnBuscar.TabIndex = 63
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesde.Location = New System.Drawing.Point(10, 92)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(43, 13)
        Me.lbldesde.TabIndex = 70
        Me.lbldesde.Text = "Desde"
        '
        'rbtEntreFechas
        '
        Me.rbtEntreFechas.AutoSize = True
        Me.rbtEntreFechas.Location = New System.Drawing.Point(123, 70)
        Me.rbtEntreFechas.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtEntreFechas.Name = "rbtEntreFechas"
        Me.rbtEntreFechas.Size = New System.Drawing.Size(98, 17)
        Me.rbtEntreFechas.TabIndex = 67
        Me.rbtEntreFechas.Text = "Entre fechas"
        Me.rbtEntreFechas.UseVisualStyleBackColor = True
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(120, 92)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(40, 13)
        Me.lblHasta.TabIndex = 69
        Me.lblHasta.Text = "Hasta"
        '
        'rbtFechaExacta
        '
        Me.rbtFechaExacta.AutoSize = True
        Me.rbtFechaExacta.Location = New System.Drawing.Point(13, 70)
        Me.rbtFechaExacta.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtFechaExacta.Name = "rbtFechaExacta"
        Me.rbtFechaExacta.Size = New System.Drawing.Size(103, 17)
        Me.rbtFechaExacta.TabIndex = 68
        Me.rbtFechaExacta.Text = "Fecha exacta"
        Me.rbtFechaExacta.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaHasta.Location = New System.Drawing.Point(123, 108)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaHasta.TabIndex = 66
        Me.dtpFechaHasta.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaDesde.Location = New System.Drawing.Point(13, 108)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaDesde.TabIndex = 65
        Me.dtpFechaDesde.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
        '
        'lblFechaExacta
        '
        Me.lblFechaExacta.AutoSize = True
        Me.lblFechaExacta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.lblFechaExacta.Location = New System.Drawing.Point(205, 103)
        Me.lblFechaExacta.Name = "lblFechaExacta"
        Me.lblFechaExacta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaExacta.TabIndex = 64
        Me.lblFechaExacta.Text = "Fecha carga"
        '
        'btnSalirr
        '
        Me.btnSalirr.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalirr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalirr.FlatAppearance.BorderSize = 0
        Me.btnSalirr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalirr.Image = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.btnSalirr.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalirr.Location = New System.Drawing.Point(514, 339)
        Me.btnSalirr.Name = "btnSalirr"
        Me.btnSalirr.Size = New System.Drawing.Size(77, 81)
        Me.btnSalirr.TabIndex = 54
        Me.btnSalirr.Text = "Salir"
        Me.btnSalirr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalirr.UseVisualStyleBackColor = False
        '
        'dgvGrilla
        '
        Me.dgvGrilla.AllowDrop = True
        Me.dgvGrilla.AllowUserToAddRows = False
        Me.dgvGrilla.AllowUserToDeleteRows = False
        Me.dgvGrilla.AllowUserToResizeColumns = False
        Me.dgvGrilla.AllowUserToResizeRows = False
        Me.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGrilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvGrilla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvGrilla.Location = New System.Drawing.Point(0, 0)
        Me.dgvGrilla.MultiSelect = False
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.ReadOnly = True
        Me.dgvGrilla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvGrilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvGrilla.RowHeadersVisible = False
        Me.dgvGrilla.RowHeadersWidth = 56
        Me.dgvGrilla.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrilla.Size = New System.Drawing.Size(508, 423)
        Me.dgvGrilla.TabIndex = 56
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(509, 190)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 80)
        Me.Button3.TabIndex = 71
        Me.Button3.Text = "Estadísticas"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.Button2.Location = New System.Drawing.Point(514, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 80)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "Listar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.cboOrden)
        Me.GroupBox7.Controls.Add(Me.chbListaParaOrdenar)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox7.Location = New System.Drawing.Point(274, 12)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(140, 123)
        Me.GroupBox7.TabIndex = 73
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Ordenar por"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 92)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Orden"
        '
        'cboOrden
        '
        Me.cboOrden.AccessibleDescription = ""
        Me.cboOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrden.FormattingEnabled = True
        Me.cboOrden.Items.AddRange(New Object() {"Física", "Jurídica"})
        Me.cboOrden.Location = New System.Drawing.Point(52, 90)
        Me.cboOrden.Name = "cboOrden"
        Me.cboOrden.Size = New System.Drawing.Size(50, 21)
        Me.cboOrden.TabIndex = 78
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
        Me.GroupBox8.Location = New System.Drawing.Point(418, 12)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Size = New System.Drawing.Size(102, 123)
        Me.GroupBox8.TabIndex = 46
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Prioridad"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Prioridad 3"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, 19)
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
        Me.lblPrioridad3.Location = New System.Drawing.Point(16, 100)
        Me.lblPrioridad3.Name = "lblPrioridad3"
        Me.lblPrioridad3.Size = New System.Drawing.Size(57, 13)
        Me.lblPrioridad3.TabIndex = 22
        Me.lblPrioridad3.Text = "Prioridad 3"
        '
        'lblPrioridad1
        '
        Me.lblPrioridad1.AutoSize = True
        Me.lblPrioridad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioridad1.Location = New System.Drawing.Point(16, 35)
        Me.lblPrioridad1.Name = "lblPrioridad1"
        Me.lblPrioridad1.Size = New System.Drawing.Size(57, 13)
        Me.lblPrioridad1.TabIndex = 20
        Me.lblPrioridad1.Text = "Prioridad 1"
        '
        'lblPrioridad2
        '
        Me.lblPrioridad2.AutoSize = True
        Me.lblPrioridad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioridad2.Location = New System.Drawing.Point(16, 69)
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
        Me.chbListaParaOrdenar.Size = New System.Drawing.Size(128, 68)
        Me.chbListaParaOrdenar.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.ClaseUi.My.Resources.Resources.icons8_create_document_621
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(514, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(77, 95)
        Me.Button4.TabIndex = 74
        Me.Button4.Text = "Pedido de reposición"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvGrilla)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnSalirr)
        Me.Panel1.Location = New System.Drawing.Point(9, 178)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 423)
        Me.Panel1.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 20)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Gestión de Stock"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cboProveedor)
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtBusNombreProducto)
        Me.GroupBox1.Controls.Add(Me.btnLimpiarFiltros)
        Me.GroupBox1.Controls.Add(Me.lbldesde)
        Me.GroupBox1.Controls.Add(Me.rbtFechaExacta)
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.rbtEntreFechas)
        Me.GroupBox1.Controls.Add(Me.dtpFechaHasta)
        Me.GroupBox1.Controls.Add(Me.dtpFechaDesde)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(599, 140)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'FrmGestionStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 613)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblFechaExacta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGestionStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion Stock"
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboProveedor As Windows.Forms.ComboBox
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents txtBusNombreProducto As Windows.Forms.TextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents btnLimpiarFiltros As Windows.Forms.Button
    Friend WithEvents btnBuscar As Windows.Forms.Button
    Friend WithEvents lbldesde As Windows.Forms.Label
    Friend WithEvents rbtEntreFechas As Windows.Forms.CheckBox
    Friend WithEvents lblHasta As Windows.Forms.Label
    Friend WithEvents rbtFechaExacta As Windows.Forms.CheckBox
    Friend WithEvents dtpFechaHasta As Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaDesde As Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaExacta As Windows.Forms.Label
    Friend WithEvents btnSalirr As Windows.Forms.Button
    Friend WithEvents dgvGrilla As Windows.Forms.DataGridView
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
	Friend WithEvents GroupBox7 As Windows.Forms.GroupBox
	Friend WithEvents Label15 As Windows.Forms.Label
	Friend WithEvents cboOrden As Windows.Forms.ComboBox
	Friend WithEvents GroupBox8 As Windows.Forms.GroupBox
	Friend WithEvents Label18 As Windows.Forms.Label
	Friend WithEvents Label19 As Windows.Forms.Label
	Friend WithEvents Label20 As Windows.Forms.Label
	Friend WithEvents lblPrioridad3 As Windows.Forms.Label
	Friend WithEvents lblPrioridad1 As Windows.Forms.Label
	Friend WithEvents lblPrioridad2 As Windows.Forms.Label
	Friend WithEvents chbListaParaOrdenar As Windows.Forms.CheckedListBox
	Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
End Class
