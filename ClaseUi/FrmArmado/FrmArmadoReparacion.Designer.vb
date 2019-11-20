<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArmadoReparacion
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
		Me.btnAgregarProducto = New System.Windows.Forms.Button()
		Me.btnQuitarItem = New System.Windows.Forms.Button()
		Me.btnLimpiar = New System.Windows.Forms.Button()
		Me.gboTotales = New System.Windows.Forms.GroupBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.ListView1 = New System.Windows.Forms.ListView()
		Me.lblInstrucciones = New System.Windows.Forms.Label()
		Me.btnAgregarCliente = New System.Windows.Forms.Button()
		Me.btnNuevo = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.cboCliente = New System.Windows.Forms.ComboBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.lstProdDispo = New System.Windows.Forms.ListView()
		Me.lblClienteDireccion = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.lblClienteDNI = New System.Windows.Forms.Label()
		Me.lblClienteTelefono = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblNombre = New System.Windows.Forms.Label()
		Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.gboFiltros = New System.Windows.Forms.GroupBox()
		Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.txtBusNombreProducto = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtDevolucion = New System.Windows.Forms.TextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.gboTotales.SuspendLayout()
		Me.GroupBox5.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.gboFiltros.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnAgregarProducto
		'
		Me.btnAgregarProducto.BackColor = System.Drawing.SystemColors.Control
		Me.btnAgregarProducto.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_add_354
		Me.btnAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnAgregarProducto.FlatAppearance.BorderSize = 0
		Me.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAgregarProducto.Location = New System.Drawing.Point(750, 308)
		Me.btnAgregarProducto.Margin = New System.Windows.Forms.Padding(4)
		Me.btnAgregarProducto.Name = "btnAgregarProducto"
		Me.btnAgregarProducto.Size = New System.Drawing.Size(80, 137)
		Me.btnAgregarProducto.TabIndex = 52
		Me.btnAgregarProducto.Text = "Agregar producto a reparar"
		Me.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnAgregarProducto.UseVisualStyleBackColor = False
		'
		'btnQuitarItem
		'
		Me.btnQuitarItem.BackColor = System.Drawing.SystemColors.Control
		Me.btnQuitarItem.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_cancel_62
		Me.btnQuitarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnQuitarItem.FlatAppearance.BorderSize = 0
		Me.btnQuitarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnQuitarItem.Location = New System.Drawing.Point(6, 13)
		Me.btnQuitarItem.Margin = New System.Windows.Forms.Padding(4)
		Me.btnQuitarItem.Name = "btnQuitarItem"
		Me.btnQuitarItem.Size = New System.Drawing.Size(134, 103)
		Me.btnQuitarItem.TabIndex = 37
		Me.btnQuitarItem.Text = "Quitar item"
		Me.btnQuitarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnQuitarItem.UseVisualStyleBackColor = False
		'
		'btnLimpiar
		'
		Me.btnLimpiar.BackColor = System.Drawing.SystemColors.Control
		Me.btnLimpiar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_clear_filters_40
		Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnLimpiar.FlatAppearance.BorderSize = 0
		Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLimpiar.Location = New System.Drawing.Point(259, 22)
		Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnLimpiar.Name = "btnLimpiar"
		Me.btnLimpiar.Size = New System.Drawing.Size(126, 103)
		Me.btnLimpiar.TabIndex = 36
		Me.btnLimpiar.Text = "Limpiar todo"
		Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnLimpiar.UseVisualStyleBackColor = False
		'
		'gboTotales
		'
		Me.gboTotales.Controls.Add(Me.Label11)
		Me.gboTotales.Controls.Add(Me.lblTotal)
		Me.gboTotales.Location = New System.Drawing.Point(1007, 116)
		Me.gboTotales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboTotales.Name = "gboTotales"
		Me.gboTotales.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboTotales.Size = New System.Drawing.Size(230, 175)
		Me.gboTotales.TabIndex = 48
		Me.gboTotales.TabStop = False
		Me.gboTotales.Text = "Totales"
		'
		'Label11
		'
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label11.Location = New System.Drawing.Point(67, 21)
		Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(115, 56)
		Me.Label11.TabIndex = 30
		Me.Label11.Text = "Costo de la reparación"
		'
		'lblTotal
		'
		Me.lblTotal.AutoSize = True
		Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lblTotal.Location = New System.Drawing.Point(93, 100)
		Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(49, 24)
		Me.lblTotal.TabIndex = 26
		Me.lblTotal.Text = "0.00"
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.btnQuitarItem)
		Me.GroupBox5.Controls.Add(Me.GroupBox4)
		Me.GroupBox5.Controls.Add(Me.btnLimpiar)
		Me.GroupBox5.Location = New System.Drawing.Point(835, 308)
		Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox5.Size = New System.Drawing.Size(402, 665)
		Me.GroupBox5.TabIndex = 45
		Me.GroupBox5.TabStop = False
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.ListView1)
		Me.GroupBox4.Location = New System.Drawing.Point(6, 141)
		Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox4.Size = New System.Drawing.Size(390, 596)
		Me.GroupBox4.TabIndex = 32
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Productos en la venta"
		'
		'ListView1
		'
		Me.ListView1.AllowDrop = True
		Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!)
		Me.ListView1.HideSelection = False
		Me.ListView1.Location = New System.Drawing.Point(6, 26)
		Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.ListView1.Name = "ListView1"
		Me.ListView1.Size = New System.Drawing.Size(373, 451)
		Me.ListView1.TabIndex = 1
		Me.ListView1.TileSize = New System.Drawing.Size(120, 25)
		Me.ListView1.UseCompatibleStateImageBehavior = False
		Me.ListView1.View = System.Windows.Forms.View.List
		'
		'lblInstrucciones
		'
		Me.lblInstrucciones.AutoSize = True
		Me.lblInstrucciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
		Me.lblInstrucciones.Location = New System.Drawing.Point(418, 34)
		Me.lblInstrucciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblInstrucciones.Name = "lblInstrucciones"
		Me.lblInstrucciones.Size = New System.Drawing.Size(401, 22)
		Me.lblInstrucciones.TabIndex = 51
		Me.lblInstrucciones.Text = "*Debe seleccionar un cliente para continuar"
		'
		'btnAgregarCliente
		'
		Me.btnAgregarCliente.BackColor = System.Drawing.SystemColors.Control
		Me.btnAgregarCliente.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_add_354
		Me.btnAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnAgregarCliente.FlatAppearance.BorderSize = 0
		Me.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAgregarCliente.Location = New System.Drawing.Point(476, 64)
		Me.btnAgregarCliente.Margin = New System.Windows.Forms.Padding(4)
		Me.btnAgregarCliente.Name = "btnAgregarCliente"
		Me.btnAgregarCliente.Size = New System.Drawing.Size(54, 46)
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
		Me.btnNuevo.Location = New System.Drawing.Point(999, 12)
		Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevo.Name = "btnNuevo"
		Me.btnNuevo.Size = New System.Drawing.Size(123, 98)
		Me.btnNuevo.TabIndex = 50
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
		Me.btnSalir.Location = New System.Drawing.Point(1130, 20)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(107, 100)
		Me.btnSalir.TabIndex = 49
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'cboCliente
		'
		Me.cboCliente.AccessibleDescription = ""
		Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCliente.FormattingEnabled = True
		Me.cboCliente.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboCliente.Location = New System.Drawing.Point(101, 74)
		Me.cboCliente.Margin = New System.Windows.Forms.Padding(4)
		Me.cboCliente.Name = "cboCliente"
		Me.cboCliente.Size = New System.Drawing.Size(367, 25)
		Me.cboCliente.TabIndex = 40
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(20, 78)
		Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(58, 17)
		Me.Label17.TabIndex = 41
		Me.Label17.Text = "Cliente"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label10.Location = New System.Drawing.Point(7, 139)
		Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(79, 20)
		Me.Label10.TabIndex = 32
		Me.Label10.Text = "Teléfono"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.lstProdDispo)
		Me.GroupBox3.Location = New System.Drawing.Point(12, 449)
		Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox3.Size = New System.Drawing.Size(786, 374)
		Me.GroupBox3.TabIndex = 46
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Productos"
		'
		'lstProdDispo
		'
		Me.lstProdDispo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstProdDispo.GridLines = True
		Me.lstProdDispo.HideSelection = False
		Me.lstProdDispo.Location = New System.Drawing.Point(10, 26)
		Me.lstProdDispo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.lstProdDispo.Name = "lstProdDispo"
		Me.lstProdDispo.Size = New System.Drawing.Size(770, 451)
		Me.lstProdDispo.Sorting = System.Windows.Forms.SortOrder.Ascending
		Me.lstProdDispo.TabIndex = 0
		Me.lstProdDispo.TileSize = New System.Drawing.Size(120, 25)
		Me.lstProdDispo.UseCompatibleStateImageBehavior = False
		'
		'lblClienteDireccion
		'
		Me.lblClienteDireccion.AutoSize = True
		Me.lblClienteDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.lblClienteDireccion.Location = New System.Drawing.Point(139, 57)
		Me.lblClienteDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblClienteDireccion.Name = "lblClienteDireccion"
		Me.lblClienteDireccion.Size = New System.Drawing.Size(98, 20)
		Me.lblClienteDireccion.TabIndex = 30
		Me.lblClienteDireccion.Text = "*Direccion*"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label9.Location = New System.Drawing.Point(7, 57)
		Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(81, 20)
		Me.Label9.TabIndex = 31
		Me.Label9.Text = "Domicilio"
		'
		'lblClienteDNI
		'
		Me.lblClienteDNI.AutoSize = True
		Me.lblClienteDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.lblClienteDNI.Location = New System.Drawing.Point(139, 102)
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
		Me.lblClienteTelefono.Location = New System.Drawing.Point(139, 139)
		Me.lblClienteTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblClienteTelefono.Name = "lblClienteTelefono"
		Me.lblClienteTelefono.Size = New System.Drawing.Size(93, 20)
		Me.lblClienteTelefono.TabIndex = 27
		Me.lblClienteTelefono.Text = "*Telefono*"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label4.Location = New System.Drawing.Point(7, 100)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(104, 20)
		Me.Label4.TabIndex = 28
		Me.Label4.Text = "Identifación"
		'
		'lblNombre
		'
		Me.lblNombre.AutoSize = True
		Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lblNombre.Location = New System.Drawing.Point(252, 15)
		Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblNombre.Name = "lblNombre"
		Me.lblNombre.Size = New System.Drawing.Size(115, 24)
		Me.lblNombre.TabIndex = 26
		Me.lblNombre.Text = "*NOMBRE*"
		'
		'PrintDialog1
		'
		Me.PrintDialog1.UseEXDialog = True
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
		Me.GroupBox2.Location = New System.Drawing.Point(583, 116)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox2.Size = New System.Drawing.Size(418, 175)
		Me.GroupBox2.TabIndex = 47
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Local"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label12.Location = New System.Drawing.Point(7, 139)
		Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(79, 20)
		Me.Label12.TabIndex = 35
		Me.Label12.Text = "Teléfono"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label2.Location = New System.Drawing.Point(187, 57)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(155, 20)
		Me.Label2.TabIndex = 30
		Me.Label2.Text = "Velez Sarsfield 68"
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label13.Location = New System.Drawing.Point(7, 57)
		Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(84, 20)
		Me.Label13.TabIndex = 34
		Me.Label13.Text = "Dirección"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label3.Location = New System.Drawing.Point(187, 100)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(119, 20)
		Me.Label3.TabIndex = 29
		Me.Label3.Text = "23349892014"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label14.Location = New System.Drawing.Point(7, 100)
		Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(104, 20)
		Me.Label14.TabIndex = 33
		Me.Label14.Text = "Identifación"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label5.Location = New System.Drawing.Point(187, 139)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(114, 20)
		Me.Label5.TabIndex = 27
		Me.Label5.Text = "351 4255463"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.Label6.Location = New System.Drawing.Point(154, 17)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(175, 24)
		Me.Label6.TabIndex = 26
		Me.Label6.Text = "JOYERIA CRIZOL"
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
		Me.GroupBox1.Location = New System.Drawing.Point(12, 116)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox1.Size = New System.Drawing.Size(555, 175)
		Me.GroupBox1.TabIndex = 43
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Cliente"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(13, 30)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(355, 25)
		Me.Label1.TabIndex = 42
		Me.Label1.Text = "Armado de pedido de reparación"
		'
		'gboFiltros
		'
		Me.gboFiltros.Controls.Add(Me.btnLimpiarFiltros)
		Me.gboFiltros.Controls.Add(Me.btnBuscar)
		Me.gboFiltros.Controls.Add(Me.txtBusNombreProducto)
		Me.gboFiltros.Controls.Add(Me.Label8)
		Me.gboFiltros.Location = New System.Drawing.Point(12, 308)
		Me.gboFiltros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboFiltros.Name = "gboFiltros"
		Me.gboFiltros.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboFiltros.Size = New System.Drawing.Size(731, 137)
		Me.gboFiltros.TabIndex = 54
		Me.gboFiltros.TabStop = False
		Me.gboFiltros.Text = "Filtros"
		'
		'btnLimpiarFiltros
		'
		Me.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Control
		Me.btnLimpiarFiltros.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_clear_filters_40
		Me.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnLimpiarFiltros.FlatAppearance.BorderSize = 0
		Me.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLimpiarFiltros.Location = New System.Drawing.Point(568, 19)
		Me.btnLimpiarFiltros.Margin = New System.Windows.Forms.Padding(4)
		Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
		Me.btnLimpiarFiltros.Size = New System.Drawing.Size(74, 76)
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
		Me.btnBuscar.Location = New System.Drawing.Point(650, 22)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(74, 73)
		Me.btnBuscar.TabIndex = 38
		Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'txtBusNombreProducto
		'
		Me.txtBusNombreProducto.Location = New System.Drawing.Point(143, 19)
		Me.txtBusNombreProducto.Name = "txtBusNombreProducto"
		Me.txtBusNombreProducto.Size = New System.Drawing.Size(201, 22)
		Me.txtBusNombreProducto.TabIndex = 41
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
		Me.Label8.Location = New System.Drawing.Point(8, 22)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(128, 16)
		Me.Label8.TabIndex = 40
		Me.Label8.Text = "Nombre producto"
		'
		'txtDevolucion
		'
		Me.txtDevolucion.Location = New System.Drawing.Point(890, 78)
		Me.txtDevolucion.Name = "txtDevolucion"
		Me.txtDevolucion.Size = New System.Drawing.Size(111, 22)
		Me.txtDevolucion.TabIndex = 54
		Me.txtDevolucion.Text = "7"
		Me.txtDevolucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
		Me.Label15.Location = New System.Drawing.Point(580, 81)
		Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(264, 16)
		Me.Label15.TabIndex = 53
		Me.Label15.Text = "Días para la devolución del producto"
		'
		'FrmArmadoReparacion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1252, 823)
		Me.Controls.Add(Me.txtDevolucion)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.gboFiltros)
		Me.Controls.Add(Me.gboTotales)
		Me.Controls.Add(Me.GroupBox5)
		Me.Controls.Add(Me.lblInstrucciones)
		Me.Controls.Add(Me.btnAgregarCliente)
		Me.Controls.Add(Me.btnNuevo)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.cboCliente)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnAgregarProducto)
		Me.Name = "FrmArmadoReparacion"
		Me.Text = "FrmArmadoReparacion"
		Me.gboTotales.ResumeLayout(False)
		Me.gboTotales.PerformLayout()
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.gboFiltros.ResumeLayout(False)
		Me.gboFiltros.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnAgregarProducto As Windows.Forms.Button
	Friend WithEvents btnQuitarItem As Windows.Forms.Button
	Friend WithEvents btnLimpiar As Windows.Forms.Button
	Friend WithEvents gboTotales As Windows.Forms.GroupBox
	Friend WithEvents Label11 As Windows.Forms.Label
	Friend WithEvents lblTotal As Windows.Forms.Label
	Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
	Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
	Friend WithEvents ListView1 As Windows.Forms.ListView
	Friend WithEvents lblInstrucciones As Windows.Forms.Label
	Friend WithEvents btnAgregarCliente As Windows.Forms.Button
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents cboCliente As Windows.Forms.ComboBox
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents Label10 As Windows.Forms.Label
	Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
	Friend WithEvents lstProdDispo As Windows.Forms.ListView
	Friend WithEvents lblClienteDireccion As Windows.Forms.Label
	Friend WithEvents Label9 As Windows.Forms.Label
	Friend WithEvents lblClienteDNI As Windows.Forms.Label
	Friend WithEvents lblClienteTelefono As Windows.Forms.Label
	Friend WithEvents Label4 As Windows.Forms.Label
	Friend WithEvents lblNombre As Windows.Forms.Label
	Friend WithEvents PrintDialog1 As Windows.Forms.PrintDialog
	Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
	Friend WithEvents Label12 As Windows.Forms.Label
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents Label13 As Windows.Forms.Label
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents Label14 As Windows.Forms.Label
	Friend WithEvents Label5 As Windows.Forms.Label
	Friend WithEvents Label6 As Windows.Forms.Label
	Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents gboFiltros As Windows.Forms.GroupBox
	Friend WithEvents btnLimpiarFiltros As Windows.Forms.Button
	Friend WithEvents btnBuscar As Windows.Forms.Button
	Friend WithEvents txtBusNombreProducto As Windows.Forms.TextBox
	Friend WithEvents Label8 As Windows.Forms.Label
	Friend WithEvents txtDevolucion As Windows.Forms.TextBox
	Friend WithEvents Label15 As Windows.Forms.Label
End Class
