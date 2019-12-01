<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestionProductoAReparar
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestionProductoAReparar))
		Me.dgvProducto = New System.Windows.Forms.DataGridView()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.txtUtilidad = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.tbPrecio = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.tbProblema = New System.Windows.Forms.TextBox()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.btncargarimagen = New System.Windows.Forms.Button()
		Me.PBfoto = New System.Windows.Forms.PictureBox()
		Me.btnNuevaCategoria = New System.Windows.Forms.Button()
		Me.btnNuevoTipo = New System.Windows.Forms.Button()
		Me.btnNuevoMaterial = New System.Windows.Forms.Button()
		Me.TbPeso = New System.Windows.Forms.TextBox()
		Me.cmbUnidad = New System.Windows.Forms.ComboBox()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.TbColor = New System.Windows.Forms.TextBox()
		Me.CmbCategoria = New System.Windows.Forms.ComboBox()
		Me.Label28 = New System.Windows.Forms.Label()
		Me.CmbMaterial = New System.Windows.Forms.ComboBox()
		Me.Label30 = New System.Windows.Forms.Label()
		Me.CmbTipoprodcuto = New System.Windows.Forms.ComboBox()
		Me.Label32 = New System.Windows.Forms.Label()
		Me.Label33 = New System.Windows.Forms.Label()
		Me.TbNombreProducto = New System.Windows.Forms.TextBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.chkReUtilizar = New System.Windows.Forms.CheckBox()
		Me.lblDobleclick = New System.Windows.Forms.Label()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		CType(Me.PBfoto, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvProducto
		'
		Me.dgvProducto.AllowDrop = True
		Me.dgvProducto.AllowUserToAddRows = False
		Me.dgvProducto.AllowUserToDeleteRows = False
		Me.dgvProducto.AllowUserToResizeColumns = False
		Me.dgvProducto.AllowUserToResizeRows = False
		Me.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.dgvProducto.EnableHeadersVisualStyles = False
		Me.dgvProducto.Location = New System.Drawing.Point(13, 573)
		Me.dgvProducto.Margin = New System.Windows.Forms.Padding(4)
		Me.dgvProducto.MultiSelect = False
		Me.dgvProducto.Name = "dgvProducto"
		Me.dgvProducto.ReadOnly = True
		Me.dgvProducto.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.dgvProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.dgvProducto.RowHeadersVisible = False
		Me.dgvProducto.RowHeadersWidth = 56
		Me.dgvProducto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvProducto.Size = New System.Drawing.Size(1087, 233)
		Me.dgvProducto.TabIndex = 48
		Me.dgvProducto.Visible = False
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.txtUtilidad)
		Me.GroupBox2.Controls.Add(Me.Label3)
		Me.GroupBox2.Controls.Add(Me.tbPrecio)
		Me.GroupBox2.Controls.Add(Me.Label2)
		Me.GroupBox2.Controls.Add(Me.Label1)
		Me.GroupBox2.Controls.Add(Me.tbProblema)
		Me.GroupBox2.Controls.Add(Me.Label18)
		Me.GroupBox2.Controls.Add(Me.btncargarimagen)
		Me.GroupBox2.Controls.Add(Me.PBfoto)
		Me.GroupBox2.Controls.Add(Me.btnNuevaCategoria)
		Me.GroupBox2.Controls.Add(Me.btnNuevoTipo)
		Me.GroupBox2.Controls.Add(Me.btnNuevoMaterial)
		Me.GroupBox2.Controls.Add(Me.TbPeso)
		Me.GroupBox2.Controls.Add(Me.cmbUnidad)
		Me.GroupBox2.Controls.Add(Me.Label23)
		Me.GroupBox2.Controls.Add(Me.Label24)
		Me.GroupBox2.Controls.Add(Me.Label25)
		Me.GroupBox2.Controls.Add(Me.TbColor)
		Me.GroupBox2.Controls.Add(Me.CmbCategoria)
		Me.GroupBox2.Controls.Add(Me.Label28)
		Me.GroupBox2.Controls.Add(Me.CmbMaterial)
		Me.GroupBox2.Controls.Add(Me.Label30)
		Me.GroupBox2.Controls.Add(Me.CmbTipoprodcuto)
		Me.GroupBox2.Controls.Add(Me.Label32)
		Me.GroupBox2.Controls.Add(Me.Label33)
		Me.GroupBox2.Controls.Add(Me.TbNombreProducto)
		Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox2.Location = New System.Drawing.Point(13, 13)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox2.Size = New System.Drawing.Size(1087, 433)
		Me.GroupBox2.TabIndex = 47
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Gestion de producto a reparar"
		'
		'txtUtilidad
		'
		Me.txtUtilidad.Location = New System.Drawing.Point(551, 368)
		Me.txtUtilidad.Margin = New System.Windows.Forms.Padding(4)
		Me.txtUtilidad.Name = "txtUtilidad"
		Me.txtUtilidad.Size = New System.Drawing.Size(84, 23)
		Me.txtUtilidad.TabIndex = 60
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(480, 371)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(63, 17)
		Me.Label3.TabIndex = 59
		Me.Label3.Text = "Utilidad"
		'
		'tbPrecio
		'
		Me.tbPrecio.Location = New System.Drawing.Point(224, 365)
		Me.tbPrecio.Margin = New System.Windows.Forms.Padding(4)
		Me.tbPrecio.Name = "tbPrecio"
		Me.tbPrecio.Size = New System.Drawing.Size(140, 23)
		Me.tbPrecio.TabIndex = 58
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(16, 368)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(173, 17)
		Me.Label2.TabIndex = 57
		Me.Label2.Text = "Costo de la reparación"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(16, 246)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(149, 17)
		Me.Label1.TabIndex = 56
		Me.Label1.Text = "Problema a reparar"
		'
		'tbProblema
		'
		Me.tbProblema.Location = New System.Drawing.Point(285, 246)
		Me.tbProblema.Margin = New System.Windows.Forms.Padding(4)
		Me.tbProblema.Multiline = True
		Me.tbProblema.Name = "tbProblema"
		Me.tbProblema.Size = New System.Drawing.Size(350, 93)
		Me.tbProblema.TabIndex = 55
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.Location = New System.Drawing.Point(708, 396)
		Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(114, 17)
		Me.Label18.TabIndex = 54
		Me.Label18.Text = "Cargar Imagen"
		'
		'btncargarimagen
		'
		Me.btncargarimagen.BackColor = System.Drawing.SystemColors.Control
		Me.btncargarimagen.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_add_image_48
		Me.btncargarimagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btncargarimagen.FlatAppearance.BorderSize = 0
		Me.btncargarimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btncargarimagen.Location = New System.Drawing.Point(711, 326)
		Me.btncargarimagen.Margin = New System.Windows.Forms.Padding(4)
		Me.btncargarimagen.Name = "btncargarimagen"
		Me.btncargarimagen.Size = New System.Drawing.Size(112, 59)
		Me.btncargarimagen.TabIndex = 53
		Me.btncargarimagen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btncargarimagen.UseVisualStyleBackColor = False
		'
		'PBfoto
		'
		Me.PBfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.PBfoto.ImageLocation = ""
		Me.PBfoto.Location = New System.Drawing.Point(847, 234)
		Me.PBfoto.Margin = New System.Windows.Forms.Padding(4)
		Me.PBfoto.Name = "PBfoto"
		Me.PBfoto.Size = New System.Drawing.Size(223, 179)
		Me.PBfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PBfoto.TabIndex = 52
		Me.PBfoto.TabStop = False
		'
		'btnNuevaCategoria
		'
		Me.btnNuevaCategoria.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevaCategoria.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_add_35
		Me.btnNuevaCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevaCategoria.FlatAppearance.BorderSize = 0
		Me.btnNuevaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevaCategoria.Location = New System.Drawing.Point(431, 75)
		Me.btnNuevaCategoria.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevaCategoria.Name = "btnNuevaCategoria"
		Me.btnNuevaCategoria.Size = New System.Drawing.Size(47, 43)
		Me.btnNuevaCategoria.TabIndex = 51
		Me.btnNuevaCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevaCategoria.UseVisualStyleBackColor = False
		'
		'btnNuevoTipo
		'
		Me.btnNuevoTipo.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevoTipo.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_add_352
		Me.btnNuevoTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevoTipo.FlatAppearance.BorderSize = 0
		Me.btnNuevoTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevoTipo.Location = New System.Drawing.Point(985, 80)
		Me.btnNuevoTipo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevoTipo.Name = "btnNuevoTipo"
		Me.btnNuevoTipo.Size = New System.Drawing.Size(47, 43)
		Me.btnNuevoTipo.TabIndex = 50
		Me.btnNuevoTipo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevoTipo.UseVisualStyleBackColor = False
		'
		'btnNuevoMaterial
		'
		Me.btnNuevoMaterial.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevoMaterial.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_add_351
		Me.btnNuevoMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevoMaterial.FlatAppearance.BorderSize = 0
		Me.btnNuevoMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevoMaterial.Location = New System.Drawing.Point(431, 122)
		Me.btnNuevoMaterial.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevoMaterial.Name = "btnNuevoMaterial"
		Me.btnNuevoMaterial.Size = New System.Drawing.Size(47, 43)
		Me.btnNuevoMaterial.TabIndex = 49
		Me.btnNuevoMaterial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevoMaterial.UseVisualStyleBackColor = False
		'
		'TbPeso
		'
		Me.TbPeso.Location = New System.Drawing.Point(696, 187)
		Me.TbPeso.Margin = New System.Windows.Forms.Padding(4)
		Me.TbPeso.Name = "TbPeso"
		Me.TbPeso.Size = New System.Drawing.Size(64, 23)
		Me.TbPeso.TabIndex = 31
		'
		'cmbUnidad
		'
		Me.cmbUnidad.FormattingEnabled = True
		Me.cmbUnidad.Location = New System.Drawing.Point(696, 140)
		Me.cmbUnidad.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbUnidad.Name = "cmbUnidad"
		Me.cmbUnidad.Size = New System.Drawing.Size(281, 25)
		Me.cmbUnidad.TabIndex = 30
		'
		'Label23
		'
		Me.Label23.AutoSize = True
		Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label23.Location = New System.Drawing.Point(542, 147)
		Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(135, 17)
		Me.Label23.TabIndex = 29
		Me.Label23.Text = "Unidad/ Magnitud"
		'
		'Label24
		'
		Me.Label24.AutoSize = True
		Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label24.Location = New System.Drawing.Point(544, 187)
		Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(72, 17)
		Me.Label24.TabIndex = 28
		Me.Label24.Text = "Cantidad"
		'
		'Label25
		'
		Me.Label25.AutoSize = True
		Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label25.Location = New System.Drawing.Point(11, 186)
		Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(46, 17)
		Me.Label25.TabIndex = 24
		Me.Label25.Text = "Color"
		'
		'TbColor
		'
		Me.TbColor.Location = New System.Drawing.Point(111, 184)
		Me.TbColor.Margin = New System.Windows.Forms.Padding(4)
		Me.TbColor.Name = "TbColor"
		Me.TbColor.Size = New System.Drawing.Size(125, 23)
		Me.TbColor.TabIndex = 23
		'
		'CmbCategoria
		'
		Me.CmbCategoria.FormattingEnabled = True
		Me.CmbCategoria.Location = New System.Drawing.Point(111, 83)
		Me.CmbCategoria.Margin = New System.Windows.Forms.Padding(4)
		Me.CmbCategoria.Name = "CmbCategoria"
		Me.CmbCategoria.Size = New System.Drawing.Size(311, 25)
		Me.CmbCategoria.TabIndex = 18
		'
		'Label28
		'
		Me.Label28.AutoSize = True
		Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label28.Location = New System.Drawing.Point(11, 88)
		Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(78, 17)
		Me.Label28.TabIndex = 17
		Me.Label28.Text = "Categoria"
		'
		'CmbMaterial
		'
		Me.CmbMaterial.FormattingEnabled = True
		Me.CmbMaterial.Location = New System.Drawing.Point(111, 139)
		Me.CmbMaterial.Margin = New System.Windows.Forms.Padding(4)
		Me.CmbMaterial.Name = "CmbMaterial"
		Me.CmbMaterial.Size = New System.Drawing.Size(311, 25)
		Me.CmbMaterial.TabIndex = 14
		'
		'Label30
		'
		Me.Label30.AutoSize = True
		Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label30.Location = New System.Drawing.Point(11, 143)
		Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label30.Name = "Label30"
		Me.Label30.Size = New System.Drawing.Size(71, 17)
		Me.Label30.TabIndex = 13
		Me.Label30.Text = " Material"
		'
		'CmbTipoprodcuto
		'
		Me.CmbTipoprodcuto.FormattingEnabled = True
		Me.CmbTipoprodcuto.Location = New System.Drawing.Point(696, 90)
		Me.CmbTipoprodcuto.Margin = New System.Windows.Forms.Padding(4)
		Me.CmbTipoprodcuto.Name = "CmbTipoprodcuto"
		Me.CmbTipoprodcuto.Size = New System.Drawing.Size(280, 25)
		Me.CmbTipoprodcuto.TabIndex = 12
		'
		'Label32
		'
		Me.Label32.AutoSize = True
		Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label32.Location = New System.Drawing.Point(16, 41)
		Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label32.Name = "Label32"
		Me.Label32.Size = New System.Drawing.Size(161, 17)
		Me.Label32.TabIndex = 10
		Me.Label32.Text = "Nombre del Producto"
		'
		'Label33
		'
		Me.Label33.AutoSize = True
		Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label33.Location = New System.Drawing.Point(542, 92)
		Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label33.Name = "Label33"
		Me.Label33.Size = New System.Drawing.Size(133, 17)
		Me.Label33.TabIndex = 9
		Me.Label33.Text = "Tipo de Producto"
		'
		'TbNombreProducto
		'
		Me.TbNombreProducto.Location = New System.Drawing.Point(192, 39)
		Me.TbNombreProducto.Margin = New System.Windows.Forms.Padding(4)
		Me.TbNombreProducto.Name = "TbNombreProducto"
		Me.TbNombreProducto.Size = New System.Drawing.Size(443, 23)
		Me.TbNombreProducto.TabIndex = 5
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.SystemColors.Control
		Me.Button2.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Location = New System.Drawing.Point(980, 455)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(120, 110)
		Me.Button2.TabIndex = 45
		Me.Button2.Text = "Salir"
		Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button2.UseVisualStyleBackColor = False
		'
		'btnGuardar
		'
		Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
		Me.btnGuardar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_save_62
		Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnGuardar.FlatAppearance.BorderSize = 0
		Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardar.Location = New System.Drawing.Point(857, 454)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(115, 106)
		Me.btnGuardar.TabIndex = 46
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'chkReUtilizar
		'
		Me.chkReUtilizar.AutoSize = True
		Me.chkReUtilizar.Location = New System.Drawing.Point(13, 485)
		Me.chkReUtilizar.Name = "chkReUtilizar"
		Me.chkReUtilizar.Size = New System.Drawing.Size(391, 21)
		Me.chkReUtilizar.TabIndex = 49
		Me.chkReUtilizar.Text = "Re utilizar modelo de productos reparados anteriormente"
		Me.chkReUtilizar.UseVisualStyleBackColor = True
		'
		'lblDobleclick
		'
		Me.lblDobleclick.AutoSize = True
		Me.lblDobleclick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDobleclick.Location = New System.Drawing.Point(13, 538)
		Me.lblDobleclick.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblDobleclick.Name = "lblDobleclick"
		Me.lblDobleclick.Size = New System.Drawing.Size(236, 17)
		Me.lblDobleclick.TabIndex = 59
		Me.lblDobleclick.Text = "Haga doble click en el deseado"
		Me.lblDobleclick.Visible = False
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'FrmGestionProductoAReparar
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1129, 1026)
		Me.Controls.Add(Me.lblDobleclick)
		Me.Controls.Add(Me.chkReUtilizar)
		Me.Controls.Add(Me.dgvProducto)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.btnGuardar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FrmGestionProductoAReparar"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Gestion de producto a reparar"
		CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		CType(Me.PBfoto, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgvProducto As Windows.Forms.DataGridView
	Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
	Friend WithEvents btnNuevaCategoria As Windows.Forms.Button
	Friend WithEvents btnNuevoTipo As Windows.Forms.Button
	Friend WithEvents btnNuevoMaterial As Windows.Forms.Button
	Friend WithEvents TbPeso As Windows.Forms.TextBox
	Friend WithEvents cmbUnidad As Windows.Forms.ComboBox
	Friend WithEvents Label23 As Windows.Forms.Label
	Friend WithEvents Label24 As Windows.Forms.Label
	Friend WithEvents Label25 As Windows.Forms.Label
	Friend WithEvents TbColor As Windows.Forms.TextBox
	Friend WithEvents CmbCategoria As Windows.Forms.ComboBox
	Friend WithEvents Label28 As Windows.Forms.Label
	Friend WithEvents CmbMaterial As Windows.Forms.ComboBox
	Friend WithEvents Label30 As Windows.Forms.Label
	Friend WithEvents CmbTipoprodcuto As Windows.Forms.ComboBox
	Friend WithEvents Label32 As Windows.Forms.Label
	Friend WithEvents Label33 As Windows.Forms.Label
	Friend WithEvents TbNombreProducto As Windows.Forms.TextBox
	Friend WithEvents Button2 As Windows.Forms.Button
	Friend WithEvents btnGuardar As Windows.Forms.Button
	Friend WithEvents tbPrecio As Windows.Forms.TextBox
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents tbProblema As Windows.Forms.TextBox
	Friend WithEvents Label18 As Windows.Forms.Label
	Friend WithEvents btncargarimagen As Windows.Forms.Button
	Friend WithEvents PBfoto As Windows.Forms.PictureBox
	Friend WithEvents chkReUtilizar As Windows.Forms.CheckBox
	Friend WithEvents lblDobleclick As Windows.Forms.Label
	Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
	Friend WithEvents txtUtilidad As Windows.Forms.TextBox
	Friend WithEvents Label3 As Windows.Forms.Label
End Class
