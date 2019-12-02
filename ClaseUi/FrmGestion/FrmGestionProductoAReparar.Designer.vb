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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PBfoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.dgvProducto.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvProducto.EnableHeadersVisualStyles = False
        Me.dgvProducto.Location = New System.Drawing.Point(0, 0)
        Me.dgvProducto.MultiSelect = False
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.ReadOnly = True
        Me.dgvProducto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProducto.RowHeadersVisible = False
        Me.dgvProducto.RowHeadersWidth = 56
        Me.dgvProducto.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducto.Size = New System.Drawing.Size(505, 242)
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
        Me.GroupBox2.Location = New System.Drawing.Point(16, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(586, 299)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        '
        'txtUtilidad
        '
        Me.txtUtilidad.Location = New System.Drawing.Point(266, 270)
        Me.txtUtilidad.Name = "txtUtilidad"
        Me.txtUtilidad.Size = New System.Drawing.Size(75, 20)
        Me.txtUtilidad.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(263, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Utilidad"
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(266, 231)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(106, 20)
        Me.tbPrecio.TabIndex = 58
        Me.tbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(263, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Costo de la reparación"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Problema a reparar"
        '
        'tbProblema
        '
        Me.tbProblema.Location = New System.Drawing.Point(13, 231)
        Me.tbProblema.Multiline = True
        Me.tbProblema.Name = "tbProblema"
        Me.tbProblema.Size = New System.Drawing.Size(236, 59)
        Me.tbProblema.TabIndex = 55
        '
        'btncargarimagen
        '
        Me.btncargarimagen.BackColor = System.Drawing.SystemColors.Control
        Me.btncargarimagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btncargarimagen.FlatAppearance.BorderSize = 0
        Me.btncargarimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncargarimagen.Image = CType(resources.GetObject("btncargarimagen.Image"), System.Drawing.Image)
        Me.btncargarimagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncargarimagen.Location = New System.Drawing.Point(430, 174)
        Me.btncargarimagen.Name = "btncargarimagen"
        Me.btncargarimagen.Size = New System.Drawing.Size(149, 54)
        Me.btncargarimagen.TabIndex = 53
        Me.btncargarimagen.Text = "Cargar Imagen"
        Me.btncargarimagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncargarimagen.UseVisualStyleBackColor = False
        '
        'PBfoto
        '
        Me.PBfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PBfoto.ImageLocation = ""
        Me.PBfoto.Location = New System.Drawing.Point(430, 18)
        Me.PBfoto.Name = "PBfoto"
        Me.PBfoto.Size = New System.Drawing.Size(150, 150)
        Me.PBfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBfoto.TabIndex = 52
        Me.PBfoto.TabStop = False
        '
        'btnNuevaCategoria
        '
        Me.btnNuevaCategoria.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevaCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevaCategoria.FlatAppearance.BorderSize = 0
        Me.btnNuevaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaCategoria.Image = CType(resources.GetObject("btnNuevaCategoria.Image"), System.Drawing.Image)
        Me.btnNuevaCategoria.Location = New System.Drawing.Point(359, 113)
        Me.btnNuevaCategoria.Name = "btnNuevaCategoria"
        Me.btnNuevaCategoria.Size = New System.Drawing.Size(28, 28)
        Me.btnNuevaCategoria.TabIndex = 51
        Me.btnNuevaCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevaCategoria.UseVisualStyleBackColor = False
        '
        'btnNuevoTipo
        '
        Me.btnNuevoTipo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevoTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevoTipo.FlatAppearance.BorderSize = 0
        Me.btnNuevoTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoTipo.Image = CType(resources.GetObject("btnNuevoTipo.Image"), System.Drawing.Image)
        Me.btnNuevoTipo.Location = New System.Drawing.Point(359, 79)
        Me.btnNuevoTipo.Name = "btnNuevoTipo"
        Me.btnNuevoTipo.Size = New System.Drawing.Size(28, 28)
        Me.btnNuevoTipo.TabIndex = 50
        Me.btnNuevoTipo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevoTipo.UseVisualStyleBackColor = False
        '
        'btnNuevoMaterial
        '
        Me.btnNuevoMaterial.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevoMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevoMaterial.FlatAppearance.BorderSize = 0
        Me.btnNuevoMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoMaterial.Image = CType(resources.GetObject("btnNuevoMaterial.Image"), System.Drawing.Image)
        Me.btnNuevoMaterial.Location = New System.Drawing.Point(359, 45)
        Me.btnNuevoMaterial.Name = "btnNuevoMaterial"
        Me.btnNuevoMaterial.Size = New System.Drawing.Size(28, 28)
        Me.btnNuevoMaterial.TabIndex = 49
        Me.btnNuevoMaterial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevoMaterial.UseVisualStyleBackColor = False
        '
        'TbPeso
        '
        Me.TbPeso.Location = New System.Drawing.Point(202, 183)
        Me.TbPeso.Name = "TbPeso"
        Me.TbPeso.Size = New System.Drawing.Size(84, 20)
        Me.TbPeso.TabIndex = 31
        '
        'cmbUnidad
        '
        Me.cmbUnidad.FormattingEnabled = True
        Me.cmbUnidad.Location = New System.Drawing.Point(142, 149)
        Me.cmbUnidad.Name = "cmbUnidad"
        Me.cmbUnidad.Size = New System.Drawing.Size(211, 21)
        Me.cmbUnidad.TabIndex = 30
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(10, 152)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(109, 13)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "Unidad/ Magnitud"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(139, 186)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(57, 13)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "Cantidad"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(10, 186)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 13)
        Me.Label25.TabIndex = 24
        Me.Label25.Text = "Color"
        '
        'TbColor
        '
        Me.TbColor.Location = New System.Drawing.Point(52, 183)
        Me.TbColor.Name = "TbColor"
        Me.TbColor.Size = New System.Drawing.Size(81, 20)
        Me.TbColor.TabIndex = 23
        '
        'CmbCategoria
        '
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Location = New System.Drawing.Point(142, 116)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(211, 21)
        Me.CmbCategoria.TabIndex = 18
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(10, 119)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(61, 13)
        Me.Label28.TabIndex = 17
        Me.Label28.Text = "Categoria"
        '
        'CmbMaterial
        '
        Me.CmbMaterial.FormattingEnabled = True
        Me.CmbMaterial.Location = New System.Drawing.Point(142, 52)
        Me.CmbMaterial.Name = "CmbMaterial"
        Me.CmbMaterial.Size = New System.Drawing.Size(211, 21)
        Me.CmbMaterial.TabIndex = 14
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(10, 55)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(52, 13)
        Me.Label30.TabIndex = 13
        Me.Label30.Text = "Material"
        '
        'CmbTipoprodcuto
        '
        Me.CmbTipoprodcuto.FormattingEnabled = True
        Me.CmbTipoprodcuto.Location = New System.Drawing.Point(142, 86)
        Me.CmbTipoprodcuto.Name = "CmbTipoprodcuto"
        Me.CmbTipoprodcuto.Size = New System.Drawing.Size(211, 21)
        Me.CmbTipoprodcuto.TabIndex = 12
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(10, 22)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(126, 13)
        Me.Label32.TabIndex = 10
        Me.Label32.Text = "Nombre del Producto"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(10, 89)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(105, 13)
        Me.Label33.TabIndex = 9
        Me.Label33.Text = "Tipo de Producto"
        '
        'TbNombreProducto
        '
        Me.TbNombreProducto.Location = New System.Drawing.Point(142, 19)
        Me.TbNombreProducto.Name = "TbNombreProducto"
        Me.TbNombreProducto.Size = New System.Drawing.Size(245, 20)
        Me.TbNombreProducto.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(510, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 81)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(511, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 81)
        Me.btnGuardar.TabIndex = 46
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'chkReUtilizar
        '
        Me.chkReUtilizar.AutoSize = True
        Me.chkReUtilizar.Location = New System.Drawing.Point(230, 337)
        Me.chkReUtilizar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkReUtilizar.Name = "chkReUtilizar"
        Me.chkReUtilizar.Size = New System.Drawing.Size(291, 17)
        Me.chkReUtilizar.TabIndex = 49
        Me.chkReUtilizar.Text = "Re utilizar modelo de productos reparados anteriormente"
        Me.chkReUtilizar.UseVisualStyleBackColor = True
        '
        'lblDobleclick
        '
        Me.lblDobleclick.AutoSize = True
        Me.lblDobleclick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDobleclick.Location = New System.Drawing.Point(13, 337)
        Me.lblDobleclick.Name = "lblDobleclick"
        Me.lblDobleclick.Size = New System.Drawing.Size(187, 13)
        Me.lblDobleclick.TabIndex = 59
        Me.lblDobleclick.Text = "Haga doble click en el deseado"
        Me.lblDobleclick.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 20)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Gestion de producto a reparar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvProducto)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(16, 359)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 242)
        Me.Panel1.TabIndex = 63
        '
        'FrmGestionProductoAReparar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 613)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDobleclick)
        Me.Controls.Add(Me.chkReUtilizar)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGestionProductoAReparar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion de producto a reparar"
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PBfoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents btncargarimagen As Windows.Forms.Button
    Friend WithEvents PBfoto As Windows.Forms.PictureBox
    Friend WithEvents chkReUtilizar As Windows.Forms.CheckBox
    Friend WithEvents lblDobleclick As Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents txtUtilidad As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
End Class
