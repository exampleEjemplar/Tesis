<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArmadoPago
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArmadoPago))
		Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
		Me.btnNuevoServicio = New System.Windows.Forms.Button()
		Me.btnQuitarItem = New System.Windows.Forms.Button()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.gboFiltros = New System.Windows.Forms.GroupBox()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblPrioridad3 = New System.Windows.Forms.Label()
		Me.lblPrioridad1 = New System.Windows.Forms.Label()
		Me.lblPrioridad2 = New System.Windows.Forms.Label()
		Me.chbListaParaOrdenar = New System.Windows.Forms.CheckedListBox()
		Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.lblDesde = New System.Windows.Forms.Label()
		Me.rbtEntreFechas = New System.Windows.Forms.CheckBox()
		Me.lblHasta = New System.Windows.Forms.Label()
		Me.rbtFechaExacta = New System.Windows.Forms.CheckBox()
		Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
		Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtBusNombreProducto = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.GroupBox6 = New System.Windows.Forms.GroupBox()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.btnNuevo = New System.Windows.Forms.Button()
		Me.lblInstrucciones = New System.Windows.Forms.Label()
		Me.btnNuevoProveedor = New System.Windows.Forms.Button()
		Me.GroupBox7 = New System.Windows.Forms.GroupBox()
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.cboProveedor = New System.Windows.Forms.ComboBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.GroupBox8 = New System.Windows.Forms.GroupBox()
		Me.lstProdDispo = New System.Windows.Forms.ListView()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.lblClienteDireccion = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.lblClienteDNI = New System.Windows.Forms.Label()
		Me.lblClienteTelefono = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.lblNombre = New System.Windows.Forms.Label()
		Me.GroupBox9 = New System.Windows.Forms.GroupBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.Label22 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.PrintDialog2 = New System.Windows.Forms.PrintDialog()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.cboOrden = New System.Windows.Forms.ComboBox()
		Me.gboFiltros.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox6.SuspendLayout()
		Me.GroupBox7.SuspendLayout()
		Me.GroupBox8.SuspendLayout()
		Me.GroupBox9.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'PrintDialog1
		'
		Me.PrintDialog1.UseEXDialog = True
		'
		'btnNuevoServicio
		'
		Me.btnNuevoServicio.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevoServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevoServicio.FlatAppearance.BorderSize = 0
		Me.btnNuevoServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevoServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnNuevoServicio.Image = CType(resources.GetObject("btnNuevoServicio.Image"), System.Drawing.Image)
		Me.btnNuevoServicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnNuevoServicio.Location = New System.Drawing.Point(328, 10)
		Me.btnNuevoServicio.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevoServicio.Name = "btnNuevoServicio"
		Me.btnNuevoServicio.Size = New System.Drawing.Size(44, 45)
		Me.btnNuevoServicio.TabIndex = 81
		Me.btnNuevoServicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevoServicio.UseVisualStyleBackColor = False
		'
		'btnQuitarItem
		'
		Me.btnQuitarItem.BackColor = System.Drawing.SystemColors.Control
		Me.btnQuitarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnQuitarItem.FlatAppearance.BorderSize = 0
		Me.btnQuitarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnQuitarItem.Image = CType(resources.GetObject("btnQuitarItem.Image"), System.Drawing.Image)
		Me.btnQuitarItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnQuitarItem.Location = New System.Drawing.Point(101, 60)
		Me.btnQuitarItem.Margin = New System.Windows.Forms.Padding(4)
		Me.btnQuitarItem.Name = "btnQuitarItem"
		Me.btnQuitarItem.Size = New System.Drawing.Size(92, 105)
		Me.btnQuitarItem.TabIndex = 37
		Me.btnQuitarItem.Text = "Quitar item"
		Me.btnQuitarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnQuitarItem.UseVisualStyleBackColor = False
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Control
		Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnLimpiar.FlatAppearance.BorderSize = 0
		Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
		Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnLimpiar.Location = New System.Drawing.Point(1, 74)
		Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(92, 91)
		Me.btnLimpiar.TabIndex = 36
		Me.btnLimpiar.Text = "Limpiar todo"
		Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnLimpiar.UseVisualStyleBackColor = False
		'
		'gboFiltros
		'
		Me.gboFiltros.Controls.Add(Me.GroupBox3)
		Me.gboFiltros.Controls.Add(Me.btnNuevoServicio)
		Me.gboFiltros.Controls.Add(Me.btnLimpiarFiltros)
		Me.gboFiltros.Controls.Add(Me.btnBuscar)
		Me.gboFiltros.Controls.Add(Me.lblDesde)
		Me.gboFiltros.Controls.Add(Me.rbtEntreFechas)
		Me.gboFiltros.Controls.Add(Me.lblHasta)
		Me.gboFiltros.Controls.Add(Me.rbtFechaExacta)
		Me.gboFiltros.Controls.Add(Me.dtpFechaHasta)
		Me.gboFiltros.Controls.Add(Me.dtpFechaDesde)
		Me.gboFiltros.Controls.Add(Me.Label4)
		Me.gboFiltros.Controls.Add(Me.txtBusNombreProducto)
		Me.gboFiltros.Controls.Add(Me.Label5)
		Me.gboFiltros.Location = New System.Drawing.Point(12, 246)
		Me.gboFiltros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboFiltros.Name = "gboFiltros"
		Me.gboFiltros.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboFiltros.Size = New System.Drawing.Size(832, 178)
		Me.gboFiltros.TabIndex = 74
		Me.gboFiltros.TabStop = False
		Me.gboFiltros.Text = "Búsqueda"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.Label7)
		Me.GroupBox3.Controls.Add(Me.cboOrden)
		Me.GroupBox3.Controls.Add(Me.GroupBox4)
		Me.GroupBox3.Controls.Add(Me.chbListaParaOrdenar)
		Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
		Me.GroupBox3.Location = New System.Drawing.Point(397, 10)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(298, 168)
		Me.GroupBox3.TabIndex = 82
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Ordenar por"
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.Label1)
		Me.GroupBox4.Controls.Add(Me.Label2)
		Me.GroupBox4.Controls.Add(Me.Label3)
		Me.GroupBox4.Controls.Add(Me.lblPrioridad3)
		Me.GroupBox4.Controls.Add(Me.lblPrioridad1)
		Me.GroupBox4.Controls.Add(Me.lblPrioridad2)
		Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
		Me.GroupBox4.Location = New System.Drawing.Point(183, 0)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(110, 153)
		Me.GroupBox4.TabIndex = 46
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Prioridad"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(7, 108)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(88, 17)
		Me.Label1.TabIndex = 25
		Me.Label1.Text = "Prioridad 3"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(7, 21)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(88, 17)
		Me.Label2.TabIndex = 23
		Me.Label2.Text = "Prioridad 1"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(7, 63)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(88, 17)
		Me.Label3.TabIndex = 24
		Me.Label3.Text = "Prioridad 2"
		'
		'lblPrioridad3
		'
		Me.lblPrioridad3.AutoSize = True
		Me.lblPrioridad3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrioridad3.Location = New System.Drawing.Point(7, 130)
		Me.lblPrioridad3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblPrioridad3.Name = "lblPrioridad3"
		Me.lblPrioridad3.Size = New System.Drawing.Size(88, 17)
		Me.lblPrioridad3.TabIndex = 22
		Me.lblPrioridad3.Text = "Prioridad 3"
		'
		'lblPrioridad1
		'
		Me.lblPrioridad1.AutoSize = True
		Me.lblPrioridad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrioridad1.Location = New System.Drawing.Point(7, 42)
		Me.lblPrioridad1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblPrioridad1.Name = "lblPrioridad1"
		Me.lblPrioridad1.Size = New System.Drawing.Size(88, 17)
		Me.lblPrioridad1.TabIndex = 20
		Me.lblPrioridad1.Text = "Prioridad 1"
		'
		'lblPrioridad2
		'
		Me.lblPrioridad2.AutoSize = True
		Me.lblPrioridad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrioridad2.Location = New System.Drawing.Point(7, 86)
		Me.lblPrioridad2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblPrioridad2.Name = "lblPrioridad2"
		Me.lblPrioridad2.Size = New System.Drawing.Size(88, 17)
		Me.lblPrioridad2.TabIndex = 21
		Me.lblPrioridad2.Text = "Prioridad 2"
		'
		'chbListaParaOrdenar
		'
		Me.chbListaParaOrdenar.FormattingEnabled = True
		Me.chbListaParaOrdenar.Location = New System.Drawing.Point(6, 21)
		Me.chbListaParaOrdenar.Name = "chbListaParaOrdenar"
		Me.chbListaParaOrdenar.Size = New System.Drawing.Size(171, 118)
		Me.chbListaParaOrdenar.TabIndex = 0
		'
		'btnLimpiarFiltros
		'
		Me.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Control
		Me.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnLimpiarFiltros.FlatAppearance.BorderSize = 0
		Me.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLimpiarFiltros.Image = CType(resources.GetObject("btnLimpiarFiltros.Image"), System.Drawing.Image)
		Me.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnLimpiarFiltros.Location = New System.Drawing.Point(702, 71)
		Me.btnLimpiarFiltros.Margin = New System.Windows.Forms.Padding(4)
		Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
		Me.btnLimpiarFiltros.Size = New System.Drawing.Size(123, 42)
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
		Me.btnBuscar.Location = New System.Drawing.Point(702, 25)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(123, 42)
		Me.btnBuscar.TabIndex = 38
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'lblDesde
		'
		Me.lblDesde.AutoSize = True
		Me.lblDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDesde.Location = New System.Drawing.Point(8, 110)
		Me.lblDesde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblDesde.Name = "lblDesde"
		Me.lblDesde.Size = New System.Drawing.Size(54, 17)
		Me.lblDesde.TabIndex = 52
		Me.lblDesde.Text = "Desde"
		'
		'rbtEntreFechas
		'
		Me.rbtEntreFechas.AutoSize = True
		Me.rbtEntreFechas.Location = New System.Drawing.Point(151, 78)
		Me.rbtEntreFechas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.rbtEntreFechas.Name = "rbtEntreFechas"
		Me.rbtEntreFechas.Size = New System.Drawing.Size(110, 21)
		Me.rbtEntreFechas.TabIndex = 49
		Me.rbtEntreFechas.Text = "Entre fechas"
		Me.rbtEntreFechas.UseVisualStyleBackColor = True
		'
		'lblHasta
		'
		Me.lblHasta.AutoSize = True
		Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHasta.Location = New System.Drawing.Point(206, 109)
		Me.lblHasta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblHasta.Name = "lblHasta"
		Me.lblHasta.Size = New System.Drawing.Size(50, 17)
		Me.lblHasta.TabIndex = 51
		Me.lblHasta.Text = "Hasta"
		'
		'rbtFechaExacta
		'
		Me.rbtFechaExacta.AutoSize = True
		Me.rbtFechaExacta.Location = New System.Drawing.Point(12, 78)
		Me.rbtFechaExacta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.rbtFechaExacta.Name = "rbtFechaExacta"
		Me.rbtFechaExacta.Size = New System.Drawing.Size(114, 21)
		Me.rbtFechaExacta.TabIndex = 50
		Me.rbtFechaExacta.Text = "Fecha exacta"
		Me.rbtFechaExacta.UseVisualStyleBackColor = True
		'
		'dtpFechaHasta
		'
		Me.dtpFechaHasta.CustomFormat = "dd/MM/yyyy"
		Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpFechaHasta.Location = New System.Drawing.Point(264, 105)
		Me.dtpFechaHasta.Margin = New System.Windows.Forms.Padding(4)
		Me.dtpFechaHasta.Name = "dtpFechaHasta"
		Me.dtpFechaHasta.Size = New System.Drawing.Size(111, 22)
		Me.dtpFechaHasta.TabIndex = 48
		Me.dtpFechaHasta.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
		'
		'dtpFechaDesde
		'
		Me.dtpFechaDesde.CustomFormat = "dd/MM/yyyy"
		Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpFechaDesde.Location = New System.Drawing.Point(73, 105)
		Me.dtpFechaDesde.Margin = New System.Windows.Forms.Padding(4)
		Me.dtpFechaDesde.Name = "dtpFechaDesde"
		Me.dtpFechaDesde.Size = New System.Drawing.Size(113, 22)
		Me.dtpFechaDesde.TabIndex = 47
		Me.dtpFechaDesde.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(8, 50)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(216, 20)
		Me.Label4.TabIndex = 46
		Me.Label4.Text = "Fecha carga del servicio"
		'
		'txtBusNombreProducto
		'
		Me.txtBusNombreProducto.Location = New System.Drawing.Point(151, 20)
		Me.txtBusNombreProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.txtBusNombreProducto.Name = "txtBusNombreProducto"
		Me.txtBusNombreProducto.Size = New System.Drawing.Size(173, 22)
		Me.txtBusNombreProducto.TabIndex = 41
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(8, 25)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(125, 17)
		Me.Label5.TabIndex = 40
		Me.Label5.Text = "Nombre servicio"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Label6)
		Me.GroupBox2.Controls.Add(Me.lblTotal)
		Me.GroupBox2.Location = New System.Drawing.Point(12, 742)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox2.Size = New System.Drawing.Size(627, 78)
		Me.GroupBox2.TabIndex = 78
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Totales"
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label6.Location = New System.Drawing.Point(219, 39)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(148, 41)
		Me.Label6.TabIndex = 30
		Me.Label6.Text = "Total del pago"
		'
		'lblTotal
		'
		Me.lblTotal.AutoSize = True
		Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lblTotal.Location = New System.Drawing.Point(403, 38)
		Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(49, 24)
		Me.lblTotal.TabIndex = 26
		Me.lblTotal.Text = "0.00"
		'
		'GroupBox6
		'
		Me.GroupBox6.Controls.Add(Me.btnQuitarItem)
		Me.GroupBox6.Controls.Add(Me.btnLimpiar)
		Me.GroupBox6.Controls.Add(Me.btnSalir)
		Me.GroupBox6.Controls.Add(Me.btnNuevo)
		Me.GroupBox6.Location = New System.Drawing.Point(645, 434)
		Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox6.Name = "GroupBox6"
		Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox6.Size = New System.Drawing.Size(201, 305)
		Me.GroupBox6.TabIndex = 75
		Me.GroupBox6.TabStop = False
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
		Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnSalir.Location = New System.Drawing.Point(101, 172)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(92, 105)
		Me.btnSalir.TabIndex = 34
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'btnNuevo
		'
		Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevo.FlatAppearance.BorderSize = 0
		Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
		Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnNuevo.Location = New System.Drawing.Point(1, 172)
		Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevo.Name = "btnNuevo"
		Me.btnNuevo.Size = New System.Drawing.Size(92, 105)
		Me.btnNuevo.TabIndex = 35
		Me.btnNuevo.Text = "Finalizar"
		Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevo.UseVisualStyleBackColor = False
		'
		'lblInstrucciones
		'
		Me.lblInstrucciones.AutoSize = True
		Me.lblInstrucciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
		Me.lblInstrucciones.Location = New System.Drawing.Point(17, 69)
		Me.lblInstrucciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblInstrucciones.Name = "lblInstrucciones"
		Me.lblInstrucciones.Size = New System.Drawing.Size(432, 22)
		Me.lblInstrucciones.TabIndex = 80
		Me.lblInstrucciones.Text = "*Debe seleccionar un proveedor para continuar"
		'
		'btnNuevoProveedor
		'
		Me.btnNuevoProveedor.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevoProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevoProveedor.FlatAppearance.BorderSize = 0
		Me.btnNuevoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevoProveedor.Image = CType(resources.GetObject("btnNuevoProveedor.Image"), System.Drawing.Image)
		Me.btnNuevoProveedor.Location = New System.Drawing.Point(681, 28)
		Me.btnNuevoProveedor.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevoProveedor.Name = "btnNuevoProveedor"
		Me.btnNuevoProveedor.Size = New System.Drawing.Size(53, 49)
		Me.btnNuevoProveedor.TabIndex = 82
		Me.btnNuevoProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevoProveedor.UseVisualStyleBackColor = False
		'
		'GroupBox7
		'
		Me.GroupBox7.Controls.Add(Me.ListView1)
		Me.GroupBox7.Location = New System.Drawing.Point(497, 434)
		Me.GroupBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox7.Name = "GroupBox7"
		Me.GroupBox7.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox7.Size = New System.Drawing.Size(144, 305)
		Me.GroupBox7.TabIndex = 79
		Me.GroupBox7.TabStop = False
		Me.GroupBox7.Text = "Servicios"
		'
		'ListView1
		'
		Me.ListView1.AllowDrop = True
		Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
		Me.ListView1.HideSelection = False
		Me.ListView1.Location = New System.Drawing.Point(3, 17)
		Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Size = New System.Drawing.Size(138, 286)
		Me.ListView1.TabIndex = 1
		Me.ListView1.TileSize = New System.Drawing.Size(120, 25)
		Me.ListView1.UseCompatibleStateImageBehavior = False
		Me.ListView1.View = System.Windows.Forms.View.List
		'
		'cboProveedor
		'
		Me.cboProveedor.AccessibleDescription = ""
		Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboProveedor.FormattingEnabled = True
		Me.cboProveedor.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboProveedor.Location = New System.Drawing.Point(111, 39)
		Me.cboProveedor.Margin = New System.Windows.Forms.Padding(4)
		Me.cboProveedor.Name = "cboProveedor"
		Me.cboProveedor.Size = New System.Drawing.Size(559, 25)
		Me.cboProveedor.TabIndex = 70
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(20, 43)
		Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(83, 17)
		Me.Label10.TabIndex = 71
		Me.Label10.Text = "Proveedor"
		'
		'GroupBox8
		'
		Me.GroupBox8.Controls.Add(Me.lstProdDispo)
		Me.GroupBox8.Location = New System.Drawing.Point(12, 434)
		Me.GroupBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox8.Name = "GroupBox8"
		Me.GroupBox8.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox8.Size = New System.Drawing.Size(483, 305)
		Me.GroupBox8.TabIndex = 76
		Me.GroupBox8.TabStop = False
		Me.GroupBox8.Text = "Servicios Disponibles"
		'
		'lstProdDispo
		'
		Me.lstProdDispo.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lstProdDispo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstProdDispo.GridLines = True
		Me.lstProdDispo.HideSelection = False
		Me.lstProdDispo.Location = New System.Drawing.Point(3, 17)
		Me.lstProdDispo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.lstProdDispo.Name = "lstProdDispo"
		Me.lstProdDispo.Size = New System.Drawing.Size(477, 286)
		Me.lstProdDispo.Sorting = System.Windows.Forms.SortOrder.Ascending
		Me.lstProdDispo.TabIndex = 0
		Me.lstProdDispo.TileSize = New System.Drawing.Size(120, 25)
		Me.lstProdDispo.UseCompatibleStateImageBehavior = False
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label12.Location = New System.Drawing.Point(12, 110)
		Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(79, 20)
		Me.Label12.TabIndex = 32
		Me.Label12.Text = "Teléfono"
		'
		'lblClienteDireccion
		'
		Me.lblClienteDireccion.AutoSize = True
		Me.lblClienteDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.lblClienteDireccion.Location = New System.Drawing.Point(163, 82)
		Me.lblClienteDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblClienteDireccion.Name = "lblClienteDireccion"
		Me.lblClienteDireccion.Size = New System.Drawing.Size(98, 20)
		Me.lblClienteDireccion.TabIndex = 30
		Me.lblClienteDireccion.Text = "*Direccion*"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label13.Location = New System.Drawing.Point(12, 82)
		Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(81, 20)
		Me.Label13.TabIndex = 31
		Me.Label13.Text = "Domicilio"
		'
		'lblClienteDNI
		'
		Me.lblClienteDNI.AutoSize = True
		Me.lblClienteDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.lblClienteDNI.Location = New System.Drawing.Point(163, 55)
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
		Me.lblClienteTelefono.Location = New System.Drawing.Point(163, 110)
		Me.lblClienteTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblClienteTelefono.Name = "lblClienteTelefono"
		Me.lblClienteTelefono.Size = New System.Drawing.Size(93, 20)
		Me.lblClienteTelefono.TabIndex = 27
		Me.lblClienteTelefono.Text = "*Telefono*"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label14.Location = New System.Drawing.Point(12, 55)
		Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(104, 20)
		Me.Label14.TabIndex = 28
		Me.Label14.Text = "Identifación"
		'
		'lblNombre
		'
		Me.lblNombre.AutoSize = True
		Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lblNombre.Location = New System.Drawing.Point(151, 17)
		Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblNombre.Name = "lblNombre"
		Me.lblNombre.Size = New System.Drawing.Size(115, 24)
		Me.lblNombre.TabIndex = 26
		Me.lblNombre.Text = "*NOMBRE*"
		'
		'GroupBox9
		'
		Me.GroupBox9.Controls.Add(Me.Label15)
		Me.GroupBox9.Controls.Add(Me.Label16)
		Me.GroupBox9.Controls.Add(Me.Label18)
		Me.GroupBox9.Controls.Add(Me.Label19)
		Me.GroupBox9.Controls.Add(Me.Label20)
		Me.GroupBox9.Controls.Add(Me.Label21)
		Me.GroupBox9.Controls.Add(Me.Label22)
		Me.GroupBox9.Location = New System.Drawing.Point(525, 91)
		Me.GroupBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox9.Name = "GroupBox9"
		Me.GroupBox9.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox9.Size = New System.Drawing.Size(319, 150)
		Me.GroupBox9.TabIndex = 77
		Me.GroupBox9.TabStop = False
		Me.GroupBox9.Text = "Local"
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label15.Location = New System.Drawing.Point(7, 111)
		Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(79, 20)
		Me.Label15.TabIndex = 35
		Me.Label15.Text = "Teléfono"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label16.Location = New System.Drawing.Point(135, 57)
		Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(155, 20)
		Me.Label16.TabIndex = 30
		Me.Label16.Text = "Velez Sarsfield 68"
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label18.Location = New System.Drawing.Point(7, 57)
		Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(84, 20)
		Me.Label18.TabIndex = 34
		Me.Label18.Text = "Dirección"
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label19.Location = New System.Drawing.Point(135, 84)
		Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(131, 20)
		Me.Label19.TabIndex = 29
		Me.Label19.Text = "23-34989201-4"
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label20.Location = New System.Drawing.Point(7, 84)
		Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(104, 20)
		Me.Label20.TabIndex = 33
		Me.Label20.Text = "Identifación"
		'
		'Label21
		'
		Me.Label21.AutoSize = True
		Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label21.Location = New System.Drawing.Point(135, 111)
		Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(115, 20)
		Me.Label21.TabIndex = 27
		Me.Label21.Text = "351-4255463"
		'
		'Label22
		'
		Me.Label22.AutoSize = True
		Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.Label22.Location = New System.Drawing.Point(67, 20)
		Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(175, 24)
		Me.Label22.TabIndex = 26
		Me.Label22.Text = "JOYERIA CRIZOL"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.Label12)
		Me.GroupBox1.Controls.Add(Me.lblClienteDireccion)
		Me.GroupBox1.Controls.Add(Me.Label13)
		Me.GroupBox1.Controls.Add(Me.lblClienteDNI)
		Me.GroupBox1.Controls.Add(Me.lblClienteTelefono)
		Me.GroupBox1.Controls.Add(Me.Label14)
		Me.GroupBox1.Controls.Add(Me.lblNombre)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 92)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox1.Size = New System.Drawing.Size(509, 149)
		Me.GroupBox1.TabIndex = 73
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Cliente"
		Me.GroupBox1.Visible = False
		'
		'Label23
		'
		Me.Label23.AutoSize = True
		Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label23.Location = New System.Drawing.Point(13, 7)
		Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(290, 25)
		Me.Label23.TabIndex = 72
		Me.Label23.Text = "Generar pago de servicios"
		'
		'PrintDialog2
		'
		Me.PrintDialog2.UseEXDialog = True
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(4, 145)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(53, 17)
		Me.Label7.TabIndex = 77
		Me.Label7.Text = "Orden"
		'
		'cboOrden
		'
		Me.cboOrden.AccessibleDescription = ""
		Me.cboOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboOrden.FormattingEnabled = True
		Me.cboOrden.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboOrden.Location = New System.Drawing.Point(65, 141)
		Me.cboOrden.Margin = New System.Windows.Forms.Padding(4)
		Me.cboOrden.Name = "cboOrden"
		Me.cboOrden.Size = New System.Drawing.Size(65, 25)
		Me.cboOrden.TabIndex = 78
		'
		'FrmArmadoPago
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(868, 863)
		Me.Controls.Add(Me.gboFiltros)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox6)
		Me.Controls.Add(Me.lblInstrucciones)
		Me.Controls.Add(Me.btnNuevoProveedor)
		Me.Controls.Add(Me.GroupBox7)
		Me.Controls.Add(Me.cboProveedor)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.GroupBox8)
		Me.Controls.Add(Me.GroupBox9)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label23)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FrmArmadoPago"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Generador de pago"
		Me.gboFiltros.ResumeLayout(False)
		Me.gboFiltros.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox4.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox6.ResumeLayout(False)
		Me.GroupBox7.ResumeLayout(False)
		Me.GroupBox8.ResumeLayout(False)
		Me.GroupBox9.ResumeLayout(False)
		Me.GroupBox9.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents PrintDialog1 As Windows.Forms.PrintDialog
	Friend WithEvents btnNuevoServicio As Windows.Forms.Button
	Friend WithEvents btnQuitarItem As Windows.Forms.Button
	Friend WithEvents btnLimpiar As Windows.Forms.Button
	Friend WithEvents gboFiltros As Windows.Forms.GroupBox
	Friend WithEvents btnLimpiarFiltros As Windows.Forms.Button
	Friend WithEvents btnBuscar As Windows.Forms.Button
	Friend WithEvents lblDesde As Windows.Forms.Label
	Friend WithEvents rbtEntreFechas As Windows.Forms.CheckBox
	Friend WithEvents lblHasta As Windows.Forms.Label
	Friend WithEvents rbtFechaExacta As Windows.Forms.CheckBox
	Friend WithEvents dtpFechaHasta As Windows.Forms.DateTimePicker
	Friend WithEvents dtpFechaDesde As Windows.Forms.DateTimePicker
	Friend WithEvents Label4 As Windows.Forms.Label
	Friend WithEvents txtBusNombreProducto As Windows.Forms.TextBox
	Friend WithEvents Label5 As Windows.Forms.Label
	Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
	Friend WithEvents Label6 As Windows.Forms.Label
	Friend WithEvents lblTotal As Windows.Forms.Label
	Friend WithEvents GroupBox6 As Windows.Forms.GroupBox
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents lblInstrucciones As Windows.Forms.Label
	Friend WithEvents btnNuevoProveedor As Windows.Forms.Button
	Friend WithEvents GroupBox7 As Windows.Forms.GroupBox
	Friend WithEvents ListView1 As Windows.Forms.ListView
	Friend WithEvents cboProveedor As Windows.Forms.ComboBox
	Friend WithEvents Label10 As Windows.Forms.Label
	Friend WithEvents GroupBox8 As Windows.Forms.GroupBox
	Friend WithEvents lstProdDispo As Windows.Forms.ListView
	Friend WithEvents Label12 As Windows.Forms.Label
	Friend WithEvents lblClienteDireccion As Windows.Forms.Label
	Friend WithEvents Label13 As Windows.Forms.Label
	Friend WithEvents lblClienteDNI As Windows.Forms.Label
	Friend WithEvents lblClienteTelefono As Windows.Forms.Label
	Friend WithEvents Label14 As Windows.Forms.Label
	Friend WithEvents lblNombre As Windows.Forms.Label
	Friend WithEvents GroupBox9 As Windows.Forms.GroupBox
	Friend WithEvents Label15 As Windows.Forms.Label
	Friend WithEvents Label16 As Windows.Forms.Label
	Friend WithEvents Label18 As Windows.Forms.Label
	Friend WithEvents Label19 As Windows.Forms.Label
	Friend WithEvents Label20 As Windows.Forms.Label
	Friend WithEvents Label21 As Windows.Forms.Label
	Friend WithEvents Label22 As Windows.Forms.Label
	Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
	Friend WithEvents Label23 As Windows.Forms.Label
	Friend WithEvents PrintDialog2 As Windows.Forms.PrintDialog
	Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
	Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents lblPrioridad3 As Windows.Forms.Label
	Friend WithEvents lblPrioridad1 As Windows.Forms.Label
	Friend WithEvents lblPrioridad2 As Windows.Forms.Label
	Friend WithEvents chbListaParaOrdenar As Windows.Forms.CheckedListBox
	Friend WithEvents Label7 As Windows.Forms.Label
	Friend WithEvents cboOrden As Windows.Forms.ComboBox
End Class
