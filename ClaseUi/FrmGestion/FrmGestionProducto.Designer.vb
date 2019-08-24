<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionProducto
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
        Me.gbbusqueda = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtBusNombreProd = New System.Windows.Forms.TextBox()
        Me.lblBusApellido = New System.Windows.Forms.Label()
        Me.txtBusCodigo = New System.Windows.Forms.TextBox()
        Me.lblBusNombre = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnProveedor = New System.Windows.Forms.Button()
        Me.btnNuevaCategoria = New System.Windows.Forms.Button()
        Me.btnNuevoTipo = New System.Windows.Forms.Button()
        Me.btnNuevoMaterial = New System.Windows.Forms.Button()
        Me.rdterceros = New System.Windows.Forms.RadioButton()
        Me.rdpropios = New System.Windows.Forms.RadioButton()
        Me.lblprod = New System.Windows.Forms.Label()
        Me.tbCodigo = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btncargarimagen = New System.Windows.Forms.Button()
        Me.TbUtilidad = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TbPrecio = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TbStockMax = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TbStockmin = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
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
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TbTamaño = New System.Windows.Forms.TextBox()
        Me.tbCodBarra = New System.Windows.Forms.TextBox()
        Me.TbNombreProducto = New System.Windows.Forms.TextBox()
        Me.PBfoto = New System.Windows.Forms.PictureBox()
        Me.btnModificarPrecios = New System.Windows.Forms.Button()
        Me.btnguardarmodificacion = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.gbbusqueda.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PBfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbbusqueda
        '
        Me.gbbusqueda.Controls.Add(Me.Button7)
        Me.gbbusqueda.Controls.Add(Me.Button4)
        Me.gbbusqueda.Controls.Add(Me.txtBusNombreProd)
        Me.gbbusqueda.Controls.Add(Me.lblBusApellido)
        Me.gbbusqueda.Controls.Add(Me.txtBusCodigo)
        Me.gbbusqueda.Controls.Add(Me.lblBusNombre)
        Me.gbbusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbbusqueda.Location = New System.Drawing.Point(126, 443)
        Me.gbbusqueda.Name = "gbbusqueda"
        Me.gbbusqueda.Size = New System.Drawing.Size(682, 119)
        Me.gbbusqueda.TabIndex = 8
        Me.gbbusqueda.TabStop = False
        Me.gbbusqueda.Text = "Búsqueda"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Control
        Me.Button7.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_checkmark_62
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(356, 8)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(86, 92)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Aceptar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_delete_62
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(466, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 92)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "Cancelar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtBusNombreProd
        '
        Me.txtBusNombreProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusNombreProd.Location = New System.Drawing.Point(72, 65)
        Me.txtBusNombreProd.Name = "txtBusNombreProd"
        Me.txtBusNombreProd.Size = New System.Drawing.Size(257, 20)
        Me.txtBusNombreProd.TabIndex = 2
        '
        'lblBusApellido
        '
        Me.lblBusApellido.AutoSize = True
        Me.lblBusApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusApellido.Location = New System.Drawing.Point(8, 65)
        Me.lblBusApellido.Name = "lblBusApellido"
        Me.lblBusApellido.Size = New System.Drawing.Size(58, 13)
        Me.lblBusApellido.TabIndex = 27
        Me.lblBusApellido.Text = "Producto"
        '
        'txtBusCodigo
        '
        Me.txtBusCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusCodigo.Location = New System.Drawing.Point(72, 26)
        Me.txtBusCodigo.Name = "txtBusCodigo"
        Me.txtBusCodigo.Size = New System.Drawing.Size(141, 20)
        Me.txtBusCodigo.TabIndex = 1
        '
        'lblBusNombre
        '
        Me.lblBusNombre.AutoSize = True
        Me.lblBusNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusNombre.Location = New System.Drawing.Point(8, 26)
        Me.lblBusNombre.Name = "lblBusNombre"
        Me.lblBusNombre.Size = New System.Drawing.Size(46, 13)
        Me.lblBusNombre.TabIndex = 25
        Me.lblBusNombre.Text = "Codigo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(23, 549)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 56
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1007, 169)
        Me.DataGridView1.TabIndex = 37
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnProveedor)
        Me.GroupBox2.Controls.Add(Me.btnNuevaCategoria)
        Me.GroupBox2.Controls.Add(Me.btnNuevoTipo)
        Me.GroupBox2.Controls.Add(Me.btnNuevoMaterial)
        Me.GroupBox2.Controls.Add(Me.rdterceros)
        Me.GroupBox2.Controls.Add(Me.rdpropios)
        Me.GroupBox2.Controls.Add(Me.lblprod)
        Me.GroupBox2.Controls.Add(Me.tbCodigo)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.btncargarimagen)
        Me.GroupBox2.Controls.Add(Me.TbUtilidad)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.TbPrecio)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.TbStockMax)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.cmbProveedor)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.TbStockmin)
        Me.GroupBox2.Controls.Add(Me.Label22)
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
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.TbTamaño)
        Me.GroupBox2.Controls.Add(Me.tbCodBarra)
        Me.GroupBox2.Controls.Add(Me.TbNombreProducto)
        Me.GroupBox2.Controls.Add(Me.PBfoto)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1017, 315)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestion de producto"
        '
        'btnProveedor
        '
        Me.btnProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.btnProveedor.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_add_354
        Me.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnProveedor.FlatAppearance.BorderSize = 0
        Me.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedor.Location = New System.Drawing.Point(750, 93)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(35, 35)
        Me.btnProveedor.TabIndex = 53
        Me.btnProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProveedor.UseVisualStyleBackColor = False
        '
        'btnNuevaCategoria
        '
        Me.btnNuevaCategoria.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevaCategoria.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_add_35
        Me.btnNuevaCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevaCategoria.FlatAppearance.BorderSize = 0
        Me.btnNuevaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaCategoria.Location = New System.Drawing.Point(341, 129)
        Me.btnNuevaCategoria.Name = "btnNuevaCategoria"
        Me.btnNuevaCategoria.Size = New System.Drawing.Size(35, 35)
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
        Me.btnNuevoTipo.Location = New System.Drawing.Point(750, 129)
        Me.btnNuevoTipo.Name = "btnNuevoTipo"
        Me.btnNuevoTipo.Size = New System.Drawing.Size(35, 35)
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
        Me.btnNuevoMaterial.Location = New System.Drawing.Point(341, 167)
        Me.btnNuevoMaterial.Name = "btnNuevoMaterial"
        Me.btnNuevoMaterial.Size = New System.Drawing.Size(35, 35)
        Me.btnNuevoMaterial.TabIndex = 49
        Me.btnNuevoMaterial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevoMaterial.UseVisualStyleBackColor = False
        '
        'rdterceros
        '
        Me.rdterceros.AutoSize = True
        Me.rdterceros.Location = New System.Drawing.Point(569, 16)
        Me.rdterceros.Name = "rdterceros"
        Me.rdterceros.Size = New System.Drawing.Size(75, 17)
        Me.rdterceros.TabIndex = 47
        Me.rdterceros.TabStop = True
        Me.rdterceros.Text = "Terceros"
        Me.rdterceros.UseVisualStyleBackColor = True
        '
        'rdpropios
        '
        Me.rdpropios.AutoSize = True
        Me.rdpropios.Location = New System.Drawing.Point(398, 15)
        Me.rdpropios.Name = "rdpropios"
        Me.rdpropios.Size = New System.Drawing.Size(67, 17)
        Me.rdpropios.TabIndex = 46
        Me.rdpropios.TabStop = True
        Me.rdpropios.Text = "Propios"
        Me.rdpropios.UseVisualStyleBackColor = True
        '
        'lblprod
        '
        Me.lblprod.AutoSize = True
        Me.lblprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprod.Location = New System.Drawing.Point(215, 16)
        Me.lblprod.Name = "lblprod"
        Me.lblprod.Size = New System.Drawing.Size(150, 13)
        Me.lblprod.TabIndex = 45
        Me.lblprod.Text = "Procedencia de producto"
        '
        'tbCodigo
        '
        Me.tbCodigo.Location = New System.Drawing.Point(75, 64)
        Me.tbCodigo.Name = "tbCodigo"
        Me.tbCodigo.Size = New System.Drawing.Size(197, 20)
        Me.tbCodigo.TabIndex = 43
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(23, 69)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(46, 13)
        Me.Label29.TabIndex = 42
        Me.Label29.Text = "Código"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(706, 276)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 13)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Cargar Imagen"
        '
        'btncargarimagen
        '
        Me.btncargarimagen.BackColor = System.Drawing.SystemColors.Control
        Me.btncargarimagen.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_add_image_48
        Me.btncargarimagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncargarimagen.FlatAppearance.BorderSize = 0
        Me.btncargarimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncargarimagen.Location = New System.Drawing.Point(709, 224)
        Me.btncargarimagen.Name = "btncargarimagen"
        Me.btncargarimagen.Size = New System.Drawing.Size(84, 48)
        Me.btncargarimagen.TabIndex = 40
        Me.btncargarimagen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncargarimagen.UseVisualStyleBackColor = False
        '
        'TbUtilidad
        '
        Me.TbUtilidad.Location = New System.Drawing.Point(612, 279)
        Me.TbUtilidad.Name = "TbUtilidad"
        Me.TbUtilidad.Size = New System.Drawing.Size(49, 20)
        Me.TbUtilidad.TabIndex = 39
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(543, 283)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 13)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "Utilidad %"
        '
        'TbPrecio
        '
        Me.TbPrecio.Location = New System.Drawing.Point(457, 278)
        Me.TbPrecio.Name = "TbPrecio"
        Me.TbPrecio.Size = New System.Drawing.Size(79, 20)
        Me.TbPrecio.TabIndex = 37
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(384, 281)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 13)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Precio  $"
        '
        'TbStockMax
        '
        Me.TbStockMax.Location = New System.Drawing.Point(310, 280)
        Me.TbStockMax.Name = "TbStockMax"
        Me.TbStockMax.Size = New System.Drawing.Size(37, 20)
        Me.TbStockMax.TabIndex = 35
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(220, 284)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 13)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "Stock Maximo"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(532, 101)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(211, 21)
        Me.cmbProveedor.TabIndex = 16
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(418, 110)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 13)
        Me.Label26.TabIndex = 15
        Me.Label26.Text = "Proveedor"
        '
        'TbStockmin
        '
        Me.TbStockmin.Location = New System.Drawing.Point(164, 279)
        Me.TbStockmin.Name = "TbStockmin"
        Me.TbStockmin.Size = New System.Drawing.Size(36, 20)
        Me.TbStockmin.TabIndex = 33
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(80, 282)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 13)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Stock Minimo"
        '
        'TbPeso
        '
        Me.TbPeso.Location = New System.Drawing.Point(612, 227)
        Me.TbPeso.Name = "TbPeso"
        Me.TbPeso.Size = New System.Drawing.Size(49, 20)
        Me.TbPeso.TabIndex = 31
        '
        'cmbUnidad
        '
        Me.cmbUnidad.FormattingEnabled = True
        Me.cmbUnidad.Location = New System.Drawing.Point(533, 178)
        Me.cmbUnidad.Name = "cmbUnidad"
        Me.cmbUnidad.Size = New System.Drawing.Size(212, 21)
        Me.cmbUnidad.TabIndex = 30
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(422, 184)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(109, 13)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "Unidad/ Magnitud"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(570, 228)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(35, 13)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "Peso"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(307, 231)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 13)
        Me.Label25.TabIndex = 24
        Me.Label25.Text = "Color"
        '
        'TbColor
        '
        Me.TbColor.Location = New System.Drawing.Point(344, 227)
        Me.TbColor.Name = "TbColor"
        Me.TbColor.Size = New System.Drawing.Size(95, 20)
        Me.TbColor.TabIndex = 23
        '
        'CmbCategoria
        '
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Location = New System.Drawing.Point(101, 136)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(234, 21)
        Me.CmbCategoria.TabIndex = 18
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(26, 140)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(61, 13)
        Me.Label28.TabIndex = 17
        Me.Label28.Text = "Categoria"
        '
        'CmbMaterial
        '
        Me.CmbMaterial.FormattingEnabled = True
        Me.CmbMaterial.Location = New System.Drawing.Point(101, 181)
        Me.CmbMaterial.Name = "CmbMaterial"
        Me.CmbMaterial.Size = New System.Drawing.Size(234, 21)
        Me.CmbMaterial.TabIndex = 14
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(31, 181)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 13)
        Me.Label30.TabIndex = 13
        Me.Label30.Text = " Material"
        '
        'CmbTipoprodcuto
        '
        Me.CmbTipoprodcuto.FormattingEnabled = True
        Me.CmbTipoprodcuto.Location = New System.Drawing.Point(533, 137)
        Me.CmbTipoprodcuto.Name = "CmbTipoprodcuto"
        Me.CmbTipoprodcuto.Size = New System.Drawing.Size(211, 21)
        Me.CmbTipoprodcuto.TabIndex = 12
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(80, 227)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(52, 13)
        Me.Label31.TabIndex = 11
        Me.Label31.Text = "Tamaño"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(278, 67)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(126, 13)
        Me.Label32.TabIndex = 10
        Me.Label32.Text = "Nombre del Producto"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(418, 139)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(105, 13)
        Me.Label33.TabIndex = 9
        Me.Label33.Text = "Tipo de Producto"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(23, 103)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(104, 13)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "Codigo de Barras"
        '
        'TbTamaño
        '
        Me.TbTamaño.Location = New System.Drawing.Point(132, 224)
        Me.TbTamaño.Name = "TbTamaño"
        Me.TbTamaño.Size = New System.Drawing.Size(49, 20)
        Me.TbTamaño.TabIndex = 6
        '
        'tbCodBarra
        '
        Me.tbCodBarra.Location = New System.Drawing.Point(133, 103)
        Me.tbCodBarra.Name = "tbCodBarra"
        Me.tbCodBarra.Size = New System.Drawing.Size(243, 20)
        Me.tbCodBarra.TabIndex = 1
        '
        'TbNombreProducto
        '
        Me.TbNombreProducto.Location = New System.Drawing.Point(410, 65)
        Me.TbNombreProducto.Name = "TbNombreProducto"
        Me.TbNombreProducto.Size = New System.Drawing.Size(333, 20)
        Me.TbNombreProducto.TabIndex = 5
        '
        'PBfoto
        '
        Me.PBfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBfoto.ImageLocation = ""
        Me.PBfoto.Location = New System.Drawing.Point(801, 61)
        Me.PBfoto.Name = "PBfoto"
        Me.PBfoto.Size = New System.Drawing.Size(194, 235)
        Me.PBfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBfoto.TabIndex = 0
        Me.PBfoto.TabStop = False
        '
        'btnModificarPrecios
        '
        Me.btnModificarPrecios.BackColor = System.Drawing.SystemColors.Control
        Me.btnModificarPrecios.BackgroundImage = Global.ClaseUi.My.Resources.Resources.iconfinder_money_2_322464
        Me.btnModificarPrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnModificarPrecios.FlatAppearance.BorderSize = 0
        Me.btnModificarPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarPrecios.Location = New System.Drawing.Point(23, 334)
        Me.btnModificarPrecios.Name = "btnModificarPrecios"
        Me.btnModificarPrecios.Size = New System.Drawing.Size(81, 102)
        Me.btnModificarPrecios.TabIndex = 38
        Me.btnModificarPrecios.Text = "Modificar precios"
        Me.btnModificarPrecios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificarPrecios.UseVisualStyleBackColor = False
        '
        'btnguardarmodificacion
        '
        Me.btnguardarmodificacion.BackColor = System.Drawing.SystemColors.Control
        Me.btnguardarmodificacion.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_save_62
        Me.btnguardarmodificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnguardarmodificacion.FlatAppearance.BorderSize = 0
        Me.btnguardarmodificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardarmodificacion.Location = New System.Drawing.Point(658, 341)
        Me.btnguardarmodificacion.Name = "btnguardarmodificacion"
        Me.btnguardarmodificacion.Size = New System.Drawing.Size(86, 104)
        Me.btnguardarmodificacion.TabIndex = 5
        Me.btnguardarmodificacion.Text = "Guardar"
        Me.btnguardarmodificacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardarmodificacion.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btncancelar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_delete_62
        Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncancelar.FlatAppearance.BorderSize = 0
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Location = New System.Drawing.Point(566, 333)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(86, 104)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.SystemColors.Control
        Me.btnmodificar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_downloading_updates_64
        Me.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnmodificar.FlatAppearance.BorderSize = 0
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Location = New System.Drawing.Point(480, 334)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(72, 106)
        Me.btnmodificar.TabIndex = 3
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.loupe_78956__1_
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(282, 333)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(81, 104)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Location = New System.Drawing.Point(381, 333)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(87, 104)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(886, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 89)
        Me.Button2.TabIndex = 31
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
        Me.btnGuardar.Location = New System.Drawing.Point(651, 333)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(86, 104)
        Me.btnGuardar.TabIndex = 32
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'FrmGestionProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 640)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnModificarPrecios)
        Me.Controls.Add(Me.btnguardarmodificacion)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.gbbusqueda)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnGuardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmGestionProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Producto"
        Me.gbbusqueda.ResumeLayout(False)
        Me.gbbusqueda.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PBfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents btnGuardar As Windows.Forms.Button
	Friend WithEvents gbbusqueda As Windows.Forms.GroupBox
	Friend WithEvents txtBusNombreProd As Windows.Forms.TextBox
	Friend WithEvents lblBusApellido As Windows.Forms.Label
	Friend WithEvents txtBusCodigo As Windows.Forms.TextBox
	Friend WithEvents lblBusNombre As Windows.Forms.Label
	Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
	Friend WithEvents Button2 As Windows.Forms.Button
	Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
	Friend WithEvents btnBuscar As Windows.Forms.Button
	Friend WithEvents btnmodificar As Windows.Forms.Button
	Friend WithEvents btncancelar As Windows.Forms.Button
	Friend WithEvents Button4 As Windows.Forms.Button
	Friend WithEvents Button7 As Windows.Forms.Button
	Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
	Friend WithEvents rdterceros As Windows.Forms.RadioButton
	Friend WithEvents rdpropios As Windows.Forms.RadioButton
	Friend WithEvents lblprod As Windows.Forms.Label
	Friend WithEvents tbCodigo As Windows.Forms.TextBox
	Friend WithEvents Label29 As Windows.Forms.Label
	Friend WithEvents Label18 As Windows.Forms.Label
	Friend WithEvents btncargarimagen As Windows.Forms.Button
	Friend WithEvents TbUtilidad As Windows.Forms.TextBox
	Friend WithEvents Label19 As Windows.Forms.Label
	Friend WithEvents TbPrecio As Windows.Forms.TextBox
	Friend WithEvents Label20 As Windows.Forms.Label
	Friend WithEvents TbStockMax As Windows.Forms.TextBox
	Friend WithEvents Label21 As Windows.Forms.Label
	Friend WithEvents cmbProveedor As Windows.Forms.ComboBox
	Friend WithEvents Label26 As Windows.Forms.Label
	Friend WithEvents TbStockmin As Windows.Forms.TextBox
	Friend WithEvents Label22 As Windows.Forms.Label
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
	Friend WithEvents Label31 As Windows.Forms.Label
	Friend WithEvents Label32 As Windows.Forms.Label
	Friend WithEvents Label33 As Windows.Forms.Label
	Friend WithEvents Label27 As Windows.Forms.Label
	Friend WithEvents TbTamaño As Windows.Forms.TextBox
	Friend WithEvents tbCodBarra As Windows.Forms.TextBox
	Friend WithEvents TbNombreProducto As Windows.Forms.TextBox
	Friend WithEvents PBfoto As Windows.Forms.PictureBox
	Friend WithEvents btnguardarmodificacion As Windows.Forms.Button
	Friend WithEvents btnNuevaCategoria As Windows.Forms.Button
	Friend WithEvents btnNuevoTipo As Windows.Forms.Button
	Friend WithEvents btnNuevoMaterial As Windows.Forms.Button
	Friend WithEvents btnProveedor As Windows.Forms.Button
	Friend WithEvents btnModificarPrecios As Windows.Forms.Button
End Class
