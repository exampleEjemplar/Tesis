﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestionProducto))
		Me.gbbusqueda = New System.Windows.Forms.GroupBox()
		Me.GroupBox7 = New System.Windows.Forms.GroupBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.cboOrden = New System.Windows.Forms.ComboBox()
		Me.chbListaParaOrdenar = New System.Windows.Forms.CheckedListBox()
		Me.txtBusNombreProd = New System.Windows.Forms.TextBox()
		Me.lblBusApellido = New System.Windows.Forms.Label()
		Me.GroupBox8 = New System.Windows.Forms.GroupBox()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lblPrioridad3 = New System.Windows.Forms.Label()
		Me.lblPrioridad1 = New System.Windows.Forms.Label()
		Me.lblPrioridad2 = New System.Windows.Forms.Label()
		Me.txtBusCodigo = New System.Windows.Forms.TextBox()
		Me.lblBusNombre = New System.Windows.Forms.Label()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.gboImagen = New System.Windows.Forms.GroupBox()
		Me.btncargarimagen = New System.Windows.Forms.Button()
		Me.PBfoto = New System.Windows.Forms.PictureBox()
		Me.gboProducto = New System.Windows.Forms.GroupBox()
		Me.lblprod = New System.Windows.Forms.Label()
		Me.rdpropios = New System.Windows.Forms.RadioButton()
		Me.rdterceros = New System.Windows.Forms.RadioButton()
		Me.Label29 = New System.Windows.Forms.Label()
		Me.tbCodBarra = New System.Windows.Forms.TextBox()
		Me.tbCodigo = New System.Windows.Forms.TextBox()
		Me.Label27 = New System.Windows.Forms.Label()
		Me.TbNombreProducto = New System.Windows.Forms.TextBox()
		Me.Label32 = New System.Windows.Forms.Label()
		Me.gboStock = New System.Windows.Forms.GroupBox()
		Me.Label22 = New System.Windows.Forms.Label()
		Me.TbStockmin = New System.Windows.Forms.TextBox()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.TbStockMax = New System.Windows.Forms.TextBox()
		Me.gboCaracteristicas = New System.Windows.Forms.GroupBox()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.cmbUnidad = New System.Windows.Forms.ComboBox()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.TbPeso = New System.Windows.Forms.TextBox()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.TbColor = New System.Windows.Forms.TextBox()
		Me.gboCategorias = New System.Windows.Forms.GroupBox()
		Me.Label28 = New System.Windows.Forms.Label()
		Me.Label33 = New System.Windows.Forms.Label()
		Me.btnProveedor = New System.Windows.Forms.Button()
		Me.CmbTipoprodcuto = New System.Windows.Forms.ComboBox()
		Me.btnNuevaCategoria = New System.Windows.Forms.Button()
		Me.Label30 = New System.Windows.Forms.Label()
		Me.btnNuevoTipo = New System.Windows.Forms.Button()
		Me.CmbMaterial = New System.Windows.Forms.ComboBox()
		Me.btnNuevoMaterial = New System.Windows.Forms.Button()
		Me.CmbCategoria = New System.Windows.Forms.ComboBox()
		Me.Label26 = New System.Windows.Forms.Label()
		Me.cmbProveedor = New System.Windows.Forms.ComboBox()
		Me.gboPrecio = New System.Windows.Forms.GroupBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.btnModificarPrecios = New System.Windows.Forms.Button()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.TbPrecio = New System.Windows.Forms.TextBox()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.TbUtilidad = New System.Windows.Forms.TextBox()
		Me.btnguardarmodificacion = New System.Windows.Forms.Button()
		Me.btncancelar = New System.Windows.Forms.Button()
		Me.btnNuevo = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.btnmodificar = New System.Windows.Forms.Button()
		Me.btnSiguiente = New System.Windows.Forms.Button()
		Me.btnAnterior = New System.Windows.Forms.Button()
		Me.lblPagina = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.gbbusqueda.SuspendLayout()
		Me.GroupBox7.SuspendLayout()
		Me.GroupBox8.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		Me.gboImagen.SuspendLayout()
		CType(Me.PBfoto, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gboProducto.SuspendLayout()
		Me.gboStock.SuspendLayout()
		Me.gboCaracteristicas.SuspendLayout()
		Me.gboCategorias.SuspendLayout()
		Me.gboPrecio.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'gbbusqueda
		'
		Me.gbbusqueda.Controls.Add(Me.GroupBox7)
		Me.gbbusqueda.Controls.Add(Me.txtBusNombreProd)
		Me.gbbusqueda.Controls.Add(Me.lblBusApellido)
		Me.gbbusqueda.Controls.Add(Me.GroupBox8)
		Me.gbbusqueda.Controls.Add(Me.txtBusCodigo)
		Me.gbbusqueda.Controls.Add(Me.lblBusNombre)
		Me.gbbusqueda.Controls.Add(Me.btnBuscar)
		Me.gbbusqueda.Controls.Add(Me.Button4)
		Me.gbbusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gbbusqueda.Location = New System.Drawing.Point(4, 6)
		Me.gbbusqueda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.gbbusqueda.Name = "gbbusqueda"
		Me.gbbusqueda.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.gbbusqueda.Size = New System.Drawing.Size(717, 174)
		Me.gbbusqueda.TabIndex = 8
		Me.gbbusqueda.TabStop = False
		Me.gbbusqueda.Text = "Búsqueda"
		'
		'GroupBox7
		'
		Me.GroupBox7.Controls.Add(Me.Label3)
		Me.GroupBox7.Controls.Add(Me.cboOrden)
		Me.GroupBox7.Controls.Add(Me.chbListaParaOrdenar)
		Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
		Me.GroupBox7.Location = New System.Drawing.Point(327, 12)
		Me.GroupBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox7.Name = "GroupBox7"
		Me.GroupBox7.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox7.Size = New System.Drawing.Size(248, 159)
		Me.GroupBox7.TabIndex = 46
		Me.GroupBox7.TabStop = False
		Me.GroupBox7.Text = "Ordenar por"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(111, 121)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(53, 17)
		Me.Label3.TabIndex = 85
		Me.Label3.Text = "Orden"
		'
		'cboOrden
		'
		Me.cboOrden.AccessibleDescription = ""
		Me.cboOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboOrden.FormattingEnabled = True
		Me.cboOrden.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboOrden.Location = New System.Drawing.Point(172, 118)
		Me.cboOrden.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.cboOrden.Name = "cboOrden"
		Me.cboOrden.Size = New System.Drawing.Size(65, 25)
		Me.cboOrden.TabIndex = 86
		'
		'chbListaParaOrdenar
		'
		Me.chbListaParaOrdenar.FormattingEnabled = True
		Me.chbListaParaOrdenar.Location = New System.Drawing.Point(5, 21)
		Me.chbListaParaOrdenar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.chbListaParaOrdenar.Name = "chbListaParaOrdenar"
		Me.chbListaParaOrdenar.Size = New System.Drawing.Size(232, 80)
		Me.chbListaParaOrdenar.TabIndex = 0
		'
		'txtBusNombreProd
		'
		Me.txtBusNombreProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBusNombreProd.Location = New System.Drawing.Point(89, 54)
		Me.txtBusNombreProd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtBusNombreProd.Name = "txtBusNombreProd"
		Me.txtBusNombreProd.Size = New System.Drawing.Size(229, 23)
		Me.txtBusNombreProd.TabIndex = 2
		'
		'lblBusApellido
		'
		Me.lblBusApellido.AutoSize = True
		Me.lblBusApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBusApellido.Location = New System.Drawing.Point(8, 58)
		Me.lblBusApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblBusApellido.Name = "lblBusApellido"
		Me.lblBusApellido.Size = New System.Drawing.Size(73, 17)
		Me.lblBusApellido.TabIndex = 27
		Me.lblBusApellido.Text = "Producto"
		'
		'GroupBox8
		'
		Me.GroupBox8.Controls.Add(Me.Label18)
		Me.GroupBox8.Controls.Add(Me.Label1)
		Me.GroupBox8.Controls.Add(Me.Label2)
		Me.GroupBox8.Controls.Add(Me.lblPrioridad3)
		Me.GroupBox8.Controls.Add(Me.lblPrioridad1)
		Me.GroupBox8.Controls.Add(Me.lblPrioridad2)
		Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
		Me.GroupBox8.Location = New System.Drawing.Point(580, 12)
		Me.GroupBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox8.Name = "GroupBox8"
		Me.GroupBox8.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox8.Size = New System.Drawing.Size(127, 159)
		Me.GroupBox8.TabIndex = 46
		Me.GroupBox8.TabStop = False
		Me.GroupBox8.Text = "Prioridad"
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.Location = New System.Drawing.Point(7, 102)
		Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(88, 17)
		Me.Label18.TabIndex = 25
		Me.Label18.Text = "Prioridad 3"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(7, 22)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(88, 17)
		Me.Label1.TabIndex = 23
		Me.Label1.Text = "Prioridad 1"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(7, 62)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(88, 17)
		Me.Label2.TabIndex = 24
		Me.Label2.Text = "Prioridad 2"
		'
		'lblPrioridad3
		'
		Me.lblPrioridad3.AutoSize = True
		Me.lblPrioridad3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrioridad3.Location = New System.Drawing.Point(21, 118)
		Me.lblPrioridad3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblPrioridad3.Name = "lblPrioridad3"
		Me.lblPrioridad3.Size = New System.Drawing.Size(77, 17)
		Me.lblPrioridad3.TabIndex = 22
		Me.lblPrioridad3.Text = "Prioridad 3"
		'
		'lblPrioridad1
		'
		Me.lblPrioridad1.AutoSize = True
		Me.lblPrioridad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrioridad1.Location = New System.Drawing.Point(21, 42)
		Me.lblPrioridad1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblPrioridad1.Name = "lblPrioridad1"
		Me.lblPrioridad1.Size = New System.Drawing.Size(77, 17)
		Me.lblPrioridad1.TabIndex = 20
		Me.lblPrioridad1.Text = "Prioridad 1"
		'
		'lblPrioridad2
		'
		Me.lblPrioridad2.AutoSize = True
		Me.lblPrioridad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPrioridad2.Location = New System.Drawing.Point(21, 81)
		Me.lblPrioridad2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblPrioridad2.Name = "lblPrioridad2"
		Me.lblPrioridad2.Size = New System.Drawing.Size(77, 17)
		Me.lblPrioridad2.TabIndex = 21
		Me.lblPrioridad2.Text = "Prioridad 2"
		'
		'txtBusCodigo
		'
		Me.txtBusCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBusCodigo.Location = New System.Drawing.Point(89, 22)
		Me.txtBusCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.txtBusCodigo.Name = "txtBusCodigo"
		Me.txtBusCodigo.Size = New System.Drawing.Size(229, 23)
		Me.txtBusCodigo.TabIndex = 1
		'
		'lblBusNombre
		'
		Me.lblBusNombre.AutoSize = True
		Me.lblBusNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBusNombre.Location = New System.Drawing.Point(8, 26)
		Me.lblBusNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblBusNombre.Name = "lblBusNombre"
		Me.lblBusNombre.Size = New System.Drawing.Size(58, 17)
		Me.lblBusNombre.TabIndex = 25
		Me.lblBusNombre.Text = "Codigo"
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
		Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnBuscar.FlatAppearance.BorderSize = 0
		Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
		Me.btnBuscar.Location = New System.Drawing.Point(140, 94)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(72, 66)
		Me.btnBuscar.TabIndex = 6
		Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.SystemColors.Control
		Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button4.FlatAppearance.BorderSize = 0
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Image = Global.ClaseUi.My.Resources.Resources.icons8_delete_62
		Me.Button4.Location = New System.Drawing.Point(220, 94)
		Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(72, 66)
		Me.Button4.TabIndex = 40
		Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button4.UseVisualStyleBackColor = False
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
		Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
		Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.DataGridView1.ColumnHeadersHeight = 45
		Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.DataGridView1.EnableHeadersVisualStyles = False
		Me.DataGridView1.Location = New System.Drawing.Point(0, 216)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.DataGridView1.MultiSelect = False
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.DataGridView1.RowHeadersVisible = False
		Me.DataGridView1.RowHeadersWidth = 56
		Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(725, 342)
		Me.DataGridView1.TabIndex = 37
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.gboImagen)
		Me.GroupBox2.Controls.Add(Me.gboProducto)
		Me.GroupBox2.Controls.Add(Me.gboStock)
		Me.GroupBox2.Controls.Add(Me.gboCaracteristicas)
		Me.GroupBox2.Controls.Add(Me.gboCategorias)
		Me.GroupBox2.Controls.Add(Me.gboPrecio)
		Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox2.Location = New System.Drawing.Point(4, 5)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox2.Size = New System.Drawing.Size(1029, 422)
		Me.GroupBox2.TabIndex = 35
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Gestion de producto"
		'
		'gboImagen
		'
		Me.gboImagen.Controls.Add(Me.btncargarimagen)
		Me.gboImagen.Controls.Add(Me.PBfoto)
		Me.gboImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gboImagen.Location = New System.Drawing.Point(803, 26)
		Me.gboImagen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.gboImagen.Name = "gboImagen"
		Me.gboImagen.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.gboImagen.Size = New System.Drawing.Size(221, 298)
		Me.gboImagen.TabIndex = 59
		Me.gboImagen.TabStop = False
		Me.gboImagen.Text = "Imagen del Producto"
		'
		'btncargarimagen
		'
		Me.btncargarimagen.BackColor = System.Drawing.SystemColors.Control
		Me.btncargarimagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btncargarimagen.FlatAppearance.BorderSize = 0
		Me.btncargarimagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btncargarimagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btncargarimagen.Image = CType(resources.GetObject("btncargarimagen.Image"), System.Drawing.Image)
		Me.btncargarimagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btncargarimagen.Location = New System.Drawing.Point(8, 222)
		Me.btncargarimagen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btncargarimagen.Name = "btncargarimagen"
		Me.btncargarimagen.Size = New System.Drawing.Size(204, 64)
		Me.btncargarimagen.TabIndex = 40
		Me.btncargarimagen.Text = "Cargar Imagen"
		Me.btncargarimagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btncargarimagen.UseVisualStyleBackColor = False
		'
		'PBfoto
		'
		Me.PBfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.PBfoto.ImageLocation = ""
		Me.PBfoto.Location = New System.Drawing.Point(8, 22)
		Me.PBfoto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.PBfoto.Name = "PBfoto"
		Me.PBfoto.Size = New System.Drawing.Size(203, 191)
		Me.PBfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PBfoto.TabIndex = 0
		Me.PBfoto.TabStop = False
		'
		'gboProducto
		'
		Me.gboProducto.Controls.Add(Me.lblprod)
		Me.gboProducto.Controls.Add(Me.rdpropios)
		Me.gboProducto.Controls.Add(Me.rdterceros)
		Me.gboProducto.Controls.Add(Me.Label29)
		Me.gboProducto.Controls.Add(Me.tbCodBarra)
		Me.gboProducto.Controls.Add(Me.tbCodigo)
		Me.gboProducto.Controls.Add(Me.Label27)
		Me.gboProducto.Controls.Add(Me.TbNombreProducto)
		Me.gboProducto.Controls.Add(Me.Label32)
		Me.gboProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gboProducto.Location = New System.Drawing.Point(12, 26)
		Me.gboProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.gboProducto.Name = "gboProducto"
		Me.gboProducto.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.gboProducto.Size = New System.Drawing.Size(783, 110)
		Me.gboProducto.TabIndex = 58
		Me.gboProducto.TabStop = False
		Me.gboProducto.Text = "Producto"
		'
		'lblprod
		'
		Me.lblprod.AutoSize = True
		Me.lblprod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblprod.Location = New System.Drawing.Point(8, 20)
		Me.lblprod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblprod.Name = "lblprod"
		Me.lblprod.Size = New System.Drawing.Size(98, 17)
		Me.lblprod.TabIndex = 45
		Me.lblprod.Text = "Procedencia"
		'
		'rdpropios
		'
		Me.rdpropios.AutoSize = True
		Me.rdpropios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rdpropios.Location = New System.Drawing.Point(12, 43)
		Me.rdpropios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.rdpropios.Name = "rdpropios"
		Me.rdpropios.Size = New System.Drawing.Size(84, 21)
		Me.rdpropios.TabIndex = 46
		Me.rdpropios.TabStop = True
		Me.rdpropios.Text = "Propios"
		Me.rdpropios.UseVisualStyleBackColor = True
		'
		'rdterceros
		'
		Me.rdterceros.AutoSize = True
		Me.rdterceros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rdterceros.Location = New System.Drawing.Point(12, 76)
		Me.rdterceros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.rdterceros.Name = "rdterceros"
		Me.rdterceros.Size = New System.Drawing.Size(94, 21)
		Me.rdterceros.TabIndex = 47
		Me.rdterceros.TabStop = True
		Me.rdterceros.Text = "Terceros"
		Me.rdterceros.UseVisualStyleBackColor = True
		'
		'Label29
		'
		Me.Label29.AutoSize = True
		Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label29.Location = New System.Drawing.Point(129, 46)
		Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label29.Name = "Label29"
		Me.Label29.Size = New System.Drawing.Size(58, 17)
		Me.Label29.TabIndex = 42
		Me.Label29.Text = "Código"
		'
		'tbCodBarra
		'
		Me.tbCodBarra.Location = New System.Drawing.Point(567, 42)
		Me.tbCodBarra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.tbCodBarra.Name = "tbCodBarra"
		Me.tbCodBarra.Size = New System.Drawing.Size(193, 23)
		Me.tbCodBarra.TabIndex = 1
		'
		'tbCodigo
		'
		Me.tbCodigo.Location = New System.Drawing.Point(212, 42)
		Me.tbCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.tbCodigo.Name = "tbCodigo"
		Me.tbCodigo.Size = New System.Drawing.Size(185, 23)
		Me.tbCodigo.TabIndex = 43
		'
		'Label27
		'
		Me.Label27.AutoSize = True
		Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label27.Location = New System.Drawing.Point(407, 46)
		Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label27.Name = "Label27"
		Me.Label27.Size = New System.Drawing.Size(134, 17)
		Me.Label27.TabIndex = 7
		Me.Label27.Text = "Codigo de Barras"
		'
		'TbNombreProducto
		'
		Me.TbNombreProducto.Location = New System.Drawing.Point(305, 75)
		Me.TbNombreProducto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TbNombreProducto.Name = "TbNombreProducto"
		Me.TbNombreProducto.Size = New System.Drawing.Size(455, 23)
		Me.TbNombreProducto.TabIndex = 5
		'
		'Label32
		'
		Me.Label32.AutoSize = True
		Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label32.Location = New System.Drawing.Point(129, 79)
		Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label32.Name = "Label32"
		Me.Label32.Size = New System.Drawing.Size(161, 17)
		Me.Label32.TabIndex = 10
		Me.Label32.Text = "Nombre del Producto"
		'
		'gboStock
		'
		Me.gboStock.Controls.Add(Me.Label22)
		Me.gboStock.Controls.Add(Me.TbStockmin)
		Me.gboStock.Controls.Add(Me.Label21)
		Me.gboStock.Controls.Add(Me.TbStockMax)
		Me.gboStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gboStock.Location = New System.Drawing.Point(604, 272)
		Me.gboStock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.gboStock.Name = "gboStock"
		Me.gboStock.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.gboStock.Size = New System.Drawing.Size(191, 90)
		Me.gboStock.TabIndex = 57
		Me.gboStock.TabStop = False
		Me.gboStock.Text = "Stock"
		'
		'Label22
		'
		Me.Label22.AutoSize = True
		Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label22.Location = New System.Drawing.Point(8, 60)
		Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(58, 17)
		Me.Label22.TabIndex = 32
		Me.Label22.Text = "Minimo"
		'
		'TbStockmin
		'
		Me.TbStockmin.Location = New System.Drawing.Point(81, 57)
		Me.TbStockmin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TbStockmin.Name = "TbStockmin"
		Me.TbStockmin.Size = New System.Drawing.Size(93, 23)
		Me.TbStockmin.TabIndex = 33
		'
		'Label21
		'
		Me.Label21.AutoSize = True
		Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label21.Location = New System.Drawing.Point(8, 28)
		Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(61, 17)
		Me.Label21.TabIndex = 34
		Me.Label21.Text = "Maximo"
		'
		'TbStockMax
		'
		Me.TbStockMax.Location = New System.Drawing.Point(81, 25)
		Me.TbStockMax.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TbStockMax.Name = "TbStockMax"
		Me.TbStockMax.Size = New System.Drawing.Size(93, 23)
		Me.TbStockMax.TabIndex = 35
		'
		'gboCaracteristicas
		'
		Me.gboCaracteristicas.Controls.Add(Me.Label23)
		Me.gboCaracteristicas.Controls.Add(Me.cmbUnidad)
		Me.gboCaracteristicas.Controls.Add(Me.Label24)
		Me.gboCaracteristicas.Controls.Add(Me.TbPeso)
		Me.gboCaracteristicas.Controls.Add(Me.Label25)
		Me.gboCaracteristicas.Controls.Add(Me.TbColor)
		Me.gboCaracteristicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gboCaracteristicas.Location = New System.Drawing.Point(276, 272)
		Me.gboCaracteristicas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.gboCaracteristicas.Name = "gboCaracteristicas"
		Me.gboCaracteristicas.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.gboCaracteristicas.Size = New System.Drawing.Size(320, 128)
		Me.gboCaracteristicas.TabIndex = 56
		Me.gboCaracteristicas.TabStop = False
		Me.gboCaracteristicas.Text = "Caracteristicas"
		'
		'Label23
		'
		Me.Label23.AutoSize = True
		Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label23.Location = New System.Drawing.Point(13, 25)
		Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(130, 17)
		Me.Label23.TabIndex = 29
		Me.Label23.Text = "Unidad/Magnitud"
		'
		'cmbUnidad
		'
		Me.cmbUnidad.FormattingEnabled = True
		Me.cmbUnidad.Location = New System.Drawing.Point(161, 21)
		Me.cmbUnidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.cmbUnidad.Name = "cmbUnidad"
		Me.cmbUnidad.Size = New System.Drawing.Size(143, 25)
		Me.cmbUnidad.TabIndex = 30
		'
		'Label24
		'
		Me.Label24.AutoSize = True
		Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label24.Location = New System.Drawing.Point(13, 57)
		Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(72, 17)
		Me.Label24.TabIndex = 28
		Me.Label24.Text = "Cantidad"
		'
		'TbPeso
		'
		Me.TbPeso.Location = New System.Drawing.Point(161, 54)
		Me.TbPeso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TbPeso.Name = "TbPeso"
		Me.TbPeso.Size = New System.Drawing.Size(143, 23)
		Me.TbPeso.TabIndex = 31
		'
		'Label25
		'
		Me.Label25.AutoSize = True
		Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label25.Location = New System.Drawing.Point(13, 90)
		Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(46, 17)
		Me.Label25.TabIndex = 24
		Me.Label25.Text = "Color"
		'
		'TbColor
		'
		Me.TbColor.Location = New System.Drawing.Point(161, 86)
		Me.TbColor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TbColor.Name = "TbColor"
		Me.TbColor.Size = New System.Drawing.Size(143, 23)
		Me.TbColor.TabIndex = 23
		'
		'gboCategorias
		'
		Me.gboCategorias.Controls.Add(Me.Label28)
		Me.gboCategorias.Controls.Add(Me.Label33)
		Me.gboCategorias.Controls.Add(Me.btnProveedor)
		Me.gboCategorias.Controls.Add(Me.CmbTipoprodcuto)
		Me.gboCategorias.Controls.Add(Me.btnNuevaCategoria)
		Me.gboCategorias.Controls.Add(Me.Label30)
		Me.gboCategorias.Controls.Add(Me.btnNuevoTipo)
		Me.gboCategorias.Controls.Add(Me.CmbMaterial)
		Me.gboCategorias.Controls.Add(Me.btnNuevoMaterial)
		Me.gboCategorias.Controls.Add(Me.CmbCategoria)
		Me.gboCategorias.Controls.Add(Me.Label26)
		Me.gboCategorias.Controls.Add(Me.cmbProveedor)
		Me.gboCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gboCategorias.Location = New System.Drawing.Point(12, 143)
		Me.gboCategorias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.gboCategorias.Name = "gboCategorias"
		Me.gboCategorias.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.gboCategorias.Size = New System.Drawing.Size(783, 122)
		Me.gboCategorias.TabIndex = 55
		Me.gboCategorias.TabStop = False
		Me.gboCategorias.Text = "Categorización"
		'
		'Label28
		'
		Me.Label28.AutoSize = True
		Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label28.Location = New System.Drawing.Point(11, 36)
		Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(78, 17)
		Me.Label28.TabIndex = 17
		Me.Label28.Text = "Categoria"
		'
		'Label33
		'
		Me.Label33.AutoSize = True
		Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label33.Location = New System.Drawing.Point(361, 76)
		Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label33.Name = "Label33"
		Me.Label33.Size = New System.Drawing.Size(133, 17)
		Me.Label33.TabIndex = 9
		Me.Label33.Text = "Tipo de Producto"
		'
		'btnProveedor
		'
		Me.btnProveedor.BackColor = System.Drawing.SystemColors.Control
		Me.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnProveedor.FlatAppearance.BorderSize = 0
		Me.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnProveedor.Image = CType(resources.GetObject("btnProveedor.Image"), System.Drawing.Image)
		Me.btnProveedor.Location = New System.Drawing.Point(728, 23)
		Me.btnProveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnProveedor.Name = "btnProveedor"
		Me.btnProveedor.Size = New System.Drawing.Size(40, 37)
		Me.btnProveedor.TabIndex = 53
		Me.btnProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnProveedor.UseVisualStyleBackColor = False
		'
		'CmbTipoprodcuto
		'
		Me.CmbTipoprodcuto.FormattingEnabled = True
		Me.CmbTipoprodcuto.Location = New System.Drawing.Point(509, 73)
		Me.CmbTipoprodcuto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.CmbTipoprodcuto.Name = "CmbTipoprodcuto"
		Me.CmbTipoprodcuto.Size = New System.Drawing.Size(209, 25)
		Me.CmbTipoprodcuto.TabIndex = 12
		'
		'btnNuevaCategoria
		'
		Me.btnNuevaCategoria.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevaCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevaCategoria.FlatAppearance.BorderSize = 0
		Me.btnNuevaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevaCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnNuevaCategoria.Image = CType(resources.GetObject("btnNuevaCategoria.Image"), System.Drawing.Image)
		Me.btnNuevaCategoria.Location = New System.Drawing.Point(313, 23)
		Me.btnNuevaCategoria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnNuevaCategoria.Name = "btnNuevaCategoria"
		Me.btnNuevaCategoria.Size = New System.Drawing.Size(40, 37)
		Me.btnNuevaCategoria.TabIndex = 51
		Me.btnNuevaCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevaCategoria.UseVisualStyleBackColor = False
		'
		'Label30
		'
		Me.Label30.AutoSize = True
		Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label30.Location = New System.Drawing.Point(8, 76)
		Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label30.Name = "Label30"
		Me.Label30.Size = New System.Drawing.Size(66, 17)
		Me.Label30.TabIndex = 13
		Me.Label30.Text = "Material"
		'
		'btnNuevoTipo
		'
		Me.btnNuevoTipo.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevoTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevoTipo.FlatAppearance.BorderSize = 0
		Me.btnNuevoTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevoTipo.Image = CType(resources.GetObject("btnNuevoTipo.Image"), System.Drawing.Image)
		Me.btnNuevoTipo.Location = New System.Drawing.Point(728, 65)
		Me.btnNuevoTipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnNuevoTipo.Name = "btnNuevoTipo"
		Me.btnNuevoTipo.Size = New System.Drawing.Size(40, 37)
		Me.btnNuevoTipo.TabIndex = 50
		Me.btnNuevoTipo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevoTipo.UseVisualStyleBackColor = False
		'
		'CmbMaterial
		'
		Me.CmbMaterial.FormattingEnabled = True
		Me.CmbMaterial.Location = New System.Drawing.Point(95, 73)
		Me.CmbMaterial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.CmbMaterial.Name = "CmbMaterial"
		Me.CmbMaterial.Size = New System.Drawing.Size(209, 25)
		Me.CmbMaterial.TabIndex = 14
		'
		'btnNuevoMaterial
		'
		Me.btnNuevoMaterial.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevoMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevoMaterial.FlatAppearance.BorderSize = 0
		Me.btnNuevoMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevoMaterial.Image = CType(resources.GetObject("btnNuevoMaterial.Image"), System.Drawing.Image)
		Me.btnNuevoMaterial.Location = New System.Drawing.Point(313, 65)
		Me.btnNuevoMaterial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnNuevoMaterial.Name = "btnNuevoMaterial"
		Me.btnNuevoMaterial.Size = New System.Drawing.Size(40, 37)
		Me.btnNuevoMaterial.TabIndex = 49
		Me.btnNuevoMaterial.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevoMaterial.UseVisualStyleBackColor = False
		'
		'CmbCategoria
		'
		Me.CmbCategoria.FormattingEnabled = True
		Me.CmbCategoria.Location = New System.Drawing.Point(95, 32)
		Me.CmbCategoria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.CmbCategoria.Name = "CmbCategoria"
		Me.CmbCategoria.Size = New System.Drawing.Size(209, 25)
		Me.CmbCategoria.TabIndex = 18
		'
		'Label26
		'
		Me.Label26.AutoSize = True
		Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label26.Location = New System.Drawing.Point(361, 38)
		Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(83, 17)
		Me.Label26.TabIndex = 15
		Me.Label26.Text = "Proveedor"
		'
		'cmbProveedor
		'
		Me.cmbProveedor.FormattingEnabled = True
		Me.cmbProveedor.Location = New System.Drawing.Point(509, 32)
		Me.cmbProveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.cmbProveedor.Name = "cmbProveedor"
		Me.cmbProveedor.Size = New System.Drawing.Size(209, 25)
		Me.cmbProveedor.TabIndex = 16
		'
		'gboPrecio
		'
		Me.gboPrecio.Controls.Add(Me.Button1)
		Me.gboPrecio.Controls.Add(Me.btnModificarPrecios)
		Me.gboPrecio.Controls.Add(Me.Label20)
		Me.gboPrecio.Controls.Add(Me.TbPrecio)
		Me.gboPrecio.Controls.Add(Me.Label19)
		Me.gboPrecio.Controls.Add(Me.TbUtilidad)
		Me.gboPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gboPrecio.Location = New System.Drawing.Point(12, 272)
		Me.gboPrecio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.gboPrecio.Name = "gboPrecio"
		Me.gboPrecio.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.gboPrecio.Size = New System.Drawing.Size(256, 143)
		Me.gboPrecio.TabIndex = 54
		Me.gboPrecio.TabStop = False
		Me.gboPrecio.Text = "Precio"
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.Control
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
		Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
		Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button1.Location = New System.Drawing.Point(8, 84)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button1.Name = "Button1"
		Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Button1.Size = New System.Drawing.Size(112, 49)
		Me.Button1.TabIndex = 40
		Me.Button1.Text = "Utilidad"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button1.UseVisualStyleBackColor = False
		'
		'btnModificarPrecios
		'
		Me.btnModificarPrecios.BackColor = System.Drawing.SystemColors.Control
		Me.btnModificarPrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnModificarPrecios.FlatAppearance.BorderSize = 0
		Me.btnModificarPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnModificarPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnModificarPrecios.Image = CType(resources.GetObject("btnModificarPrecios.Image"), System.Drawing.Image)
		Me.btnModificarPrecios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnModificarPrecios.Location = New System.Drawing.Point(128, 86)
		Me.btnModificarPrecios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnModificarPrecios.Name = "btnModificarPrecios"
		Me.btnModificarPrecios.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btnModificarPrecios.Size = New System.Drawing.Size(123, 46)
		Me.btnModificarPrecios.TabIndex = 38
		Me.btnModificarPrecios.Text = "Modificar precios"
		Me.btnModificarPrecios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnModificarPrecios.UseVisualStyleBackColor = False
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label20.Location = New System.Drawing.Point(8, 25)
		Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(73, 17)
		Me.Label20.TabIndex = 36
		Me.Label20.Text = "Precio  $"
		'
		'TbPrecio
		'
		Me.TbPrecio.Location = New System.Drawing.Point(101, 21)
		Me.TbPrecio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TbPrecio.Name = "TbPrecio"
		Me.TbPrecio.Size = New System.Drawing.Size(145, 23)
		Me.TbPrecio.TabIndex = 37
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.Location = New System.Drawing.Point(8, 58)
		Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(81, 17)
		Me.Label19.TabIndex = 38
		Me.Label19.Text = "Utilidad %"
		'
		'TbUtilidad
		'
		Me.TbUtilidad.Location = New System.Drawing.Point(101, 54)
		Me.TbUtilidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.TbUtilidad.Name = "TbUtilidad"
		Me.TbUtilidad.Size = New System.Drawing.Size(145, 23)
		Me.TbUtilidad.TabIndex = 39
		'
		'btnguardarmodificacion
		'
		Me.btnguardarmodificacion.BackColor = System.Drawing.SystemColors.Control
		Me.btnguardarmodificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnguardarmodificacion.FlatAppearance.BorderSize = 0
		Me.btnguardarmodificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnguardarmodificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnguardarmodificacion.Image = Global.ClaseUi.My.Resources.Resources.icons8_save_62
		Me.btnguardarmodificacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnguardarmodificacion.Location = New System.Drawing.Point(841, 438)
		Me.btnguardarmodificacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnguardarmodificacion.Name = "btnguardarmodificacion"
		Me.btnguardarmodificacion.Size = New System.Drawing.Size(92, 105)
		Me.btnguardarmodificacion.TabIndex = 5
		Me.btnguardarmodificacion.Text = "Guardar"
		Me.btnguardarmodificacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnguardarmodificacion.UseVisualStyleBackColor = False
		'
		'btncancelar
		'
		Me.btncancelar.BackColor = System.Drawing.SystemColors.Control
		Me.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btncancelar.FlatAppearance.BorderSize = 0
		Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btncancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btncancelar.Image = Global.ClaseUi.My.Resources.Resources.icons8_delete_62
		Me.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btncancelar.Location = New System.Drawing.Point(741, 438)
		Me.btncancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btncancelar.Name = "btncancelar"
		Me.btncancelar.Size = New System.Drawing.Size(92, 105)
		Me.btncancelar.TabIndex = 4
		Me.btncancelar.Text = "Cancelar"
		Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btncancelar.UseVisualStyleBackColor = False
		'
		'btnNuevo
		'
		Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevo.FlatAppearance.BorderSize = 0
		Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnNuevo.Image = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
		Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnNuevo.Location = New System.Drawing.Point(641, 438)
		Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnNuevo.Name = "btnNuevo"
		Me.btnNuevo.Size = New System.Drawing.Size(92, 105)
		Me.btnNuevo.TabIndex = 2
		Me.btnNuevo.Text = "Nuevo"
		Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevo.UseVisualStyleBackColor = False
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
		Me.Button2.Location = New System.Drawing.Point(941, 438)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(92, 105)
		Me.Button2.TabIndex = 31
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
		Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGuardar.Image = Global.ClaseUi.My.Resources.Resources.icons8_save_62
		Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnGuardar.Location = New System.Drawing.Point(841, 438)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(92, 105)
		Me.btnGuardar.TabIndex = 32
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'btnmodificar
		'
		Me.btnmodificar.BackColor = System.Drawing.SystemColors.Control
		Me.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnmodificar.FlatAppearance.BorderSize = 0
		Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnmodificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnmodificar.Image = Global.ClaseUi.My.Resources.Resources.icons8_downloading_updates_64
		Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnmodificar.Location = New System.Drawing.Point(541, 438)
		Me.btnmodificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnmodificar.Name = "btnmodificar"
		Me.btnmodificar.Size = New System.Drawing.Size(92, 105)
		Me.btnmodificar.TabIndex = 3
		Me.btnmodificar.Text = "Modificar"
		Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnmodificar.UseVisualStyleBackColor = False
		'
		'btnSiguiente
		'
		Me.btnSiguiente.BackColor = System.Drawing.SystemColors.Control
		Me.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSiguiente.FlatAppearance.BorderSize = 0
		Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnSiguiente.Location = New System.Drawing.Point(564, 183)
		Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnSiguiente.Name = "btnSiguiente"
		Me.btnSiguiente.Size = New System.Drawing.Size(147, 28)
		Me.btnSiguiente.TabIndex = 38
		Me.btnSiguiente.Text = "Sig. 20 registros"
		Me.btnSiguiente.UseVisualStyleBackColor = False
		'
		'btnAnterior
		'
		Me.btnAnterior.BackColor = System.Drawing.SystemColors.Control
		Me.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnAnterior.FlatAppearance.BorderSize = 0
		Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnAnterior.Location = New System.Drawing.Point(4, 183)
		Me.btnAnterior.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnAnterior.Name = "btnAnterior"
		Me.btnAnterior.Size = New System.Drawing.Size(147, 28)
		Me.btnAnterior.TabIndex = 39
		Me.btnAnterior.Text = "Ant. 20 registros"
		Me.btnAnterior.UseVisualStyleBackColor = False
		'
		'lblPagina
		'
		Me.lblPagina.AutoSize = True
		Me.lblPagina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPagina.Location = New System.Drawing.Point(231, 190)
		Me.lblPagina.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblPagina.Name = "lblPagina"
		Me.lblPagina.Size = New System.Drawing.Size(69, 17)
		Me.lblPagina.TabIndex = 36
		Me.lblPagina.Text = "*pagina*"
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.lblPagina)
		Me.Panel1.Controls.Add(Me.btnSiguiente)
		Me.Panel1.Controls.Add(Me.btnAnterior)
		Me.Panel1.Controls.Add(Me.DataGridView1)
		Me.Panel1.Controls.Add(Me.gbbusqueda)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
		Me.Panel1.Location = New System.Drawing.Point(1042, 0)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(725, 558)
		Me.Panel1.TabIndex = 40
		'
		'FrmGestionProducto
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1767, 558)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.btnguardarmodificacion)
		Me.Controls.Add(Me.btncancelar)
		Me.Controls.Add(Me.btnmodificar)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.btnNuevo)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.btnGuardar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FrmGestionProducto"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Gestion de Producto"
		Me.gbbusqueda.ResumeLayout(False)
		Me.gbbusqueda.PerformLayout()
		Me.GroupBox7.ResumeLayout(False)
		Me.GroupBox7.PerformLayout()
		Me.GroupBox8.ResumeLayout(False)
		Me.GroupBox8.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.gboImagen.ResumeLayout(False)
		CType(Me.PBfoto, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gboProducto.ResumeLayout(False)
		Me.gboProducto.PerformLayout()
		Me.gboStock.ResumeLayout(False)
		Me.gboStock.PerformLayout()
		Me.gboCaracteristicas.ResumeLayout(False)
		Me.gboCaracteristicas.PerformLayout()
		Me.gboCategorias.ResumeLayout(False)
		Me.gboCategorias.PerformLayout()
		Me.gboPrecio.ResumeLayout(False)
		Me.gboPrecio.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
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
    Friend WithEvents btncancelar As Windows.Forms.Button
    Friend WithEvents Button4 As Windows.Forms.Button
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents rdterceros As Windows.Forms.RadioButton
	Friend WithEvents rdpropios As Windows.Forms.RadioButton
	Friend WithEvents lblprod As Windows.Forms.Label
	Friend WithEvents tbCodigo As Windows.Forms.TextBox
	Friend WithEvents Label29 As Windows.Forms.Label
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
	Friend WithEvents Label32 As Windows.Forms.Label
	Friend WithEvents Label33 As Windows.Forms.Label
	Friend WithEvents Label27 As Windows.Forms.Label
	Friend WithEvents tbCodBarra As Windows.Forms.TextBox
	Friend WithEvents TbNombreProducto As Windows.Forms.TextBox
	Friend WithEvents PBfoto As Windows.Forms.PictureBox
	Friend WithEvents btnguardarmodificacion As Windows.Forms.Button
	Friend WithEvents btnNuevaCategoria As Windows.Forms.Button
	Friend WithEvents btnNuevoTipo As Windows.Forms.Button
	Friend WithEvents btnNuevoMaterial As Windows.Forms.Button
	Friend WithEvents btnProveedor As Windows.Forms.Button
	Friend WithEvents btnModificarPrecios As Windows.Forms.Button
    Friend WithEvents gboPrecio As Windows.Forms.GroupBox
    Friend WithEvents gboProducto As Windows.Forms.GroupBox
    Friend WithEvents gboStock As Windows.Forms.GroupBox
    Friend WithEvents gboCaracteristicas As Windows.Forms.GroupBox
    Friend WithEvents gboCategorias As Windows.Forms.GroupBox
    Friend WithEvents gboImagen As Windows.Forms.GroupBox
    Friend WithEvents btnmodificar As Windows.Forms.Button
	Friend WithEvents btnSiguiente As Windows.Forms.Button
	Friend WithEvents btnAnterior As Windows.Forms.Button
	Friend WithEvents lblPagina As Windows.Forms.Label
	Friend WithEvents Button1 As Windows.Forms.Button
	Friend WithEvents GroupBox7 As Windows.Forms.GroupBox
	Friend WithEvents chbListaParaOrdenar As Windows.Forms.CheckedListBox
	Friend WithEvents GroupBox8 As Windows.Forms.GroupBox
	Friend WithEvents Label18 As Windows.Forms.Label
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents lblPrioridad3 As Windows.Forms.Label
	Friend WithEvents lblPrioridad1 As Windows.Forms.Label
	Friend WithEvents lblPrioridad2 As Windows.Forms.Label
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents cboOrden As Windows.Forms.ComboBox
    Friend WithEvents Panel1 As Windows.Forms.Panel
End Class
