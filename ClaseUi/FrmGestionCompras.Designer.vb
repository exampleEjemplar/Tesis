<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestionCompras
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.dtpFechaComp2 = New System.Windows.Forms.DateTimePicker()
		Me.rbtEntreFechas = New System.Windows.Forms.RadioButton()
		Me.cboUsuario = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.dtpFechaComp = New System.Windows.Forms.DateTimePicker()
		Me.cboProveedor = New System.Windows.Forms.ComboBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.dgvProveedores = New System.Windows.Forms.DataGridView()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.btnNuevo = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.GroupBox5.SuspendLayout()
		CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(13, 9)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(189, 25)
		Me.Label1.TabIndex = 36
		Me.Label1.Text = "Gestión compras"
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.dtpFechaComp2)
		Me.GroupBox5.Controls.Add(Me.rbtEntreFechas)
		Me.GroupBox5.Controls.Add(Me.cboUsuario)
		Me.GroupBox5.Controls.Add(Me.Label2)
		Me.GroupBox5.Controls.Add(Me.dtpFechaComp)
		Me.GroupBox5.Controls.Add(Me.btnBuscar)
		Me.GroupBox5.Controls.Add(Me.cboProveedor)
		Me.GroupBox5.Controls.Add(Me.Label17)
		Me.GroupBox5.Controls.Add(Me.Label16)
		Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox5.Location = New System.Drawing.Point(13, 62)
		Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox5.Size = New System.Drawing.Size(1012, 133)
		Me.GroupBox5.TabIndex = 39
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Búsqueda"
		'
		'dtpFechaComp2
		'
		Me.dtpFechaComp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpFechaComp2.Location = New System.Drawing.Point(577, 52)
		Me.dtpFechaComp2.Margin = New System.Windows.Forms.Padding(4)
		Me.dtpFechaComp2.Name = "dtpFechaComp2"
		Me.dtpFechaComp2.Size = New System.Drawing.Size(151, 23)
		Me.dtpFechaComp2.TabIndex = 37
		Me.dtpFechaComp2.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
		'
		'rbtEntreFechas
		'
		Me.rbtEntreFechas.AutoSize = True
		Me.rbtEntreFechas.Location = New System.Drawing.Point(354, 52)
		Me.rbtEntreFechas.Name = "rbtEntreFechas"
		Me.rbtEntreFechas.Size = New System.Drawing.Size(197, 21)
		Me.rbtEntreFechas.TabIndex = 36
		Me.rbtEntreFechas.TabStop = True
		Me.rbtEntreFechas.Text = "Busqueda entre fechas"
		Me.rbtEntreFechas.UseVisualStyleBackColor = True
		'
		'cboUsuario
		'
		Me.cboUsuario.AccessibleDescription = ""
		Me.cboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboUsuario.FormattingEnabled = True
		Me.cboUsuario.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboUsuario.Location = New System.Drawing.Point(187, 83)
		Me.cboUsuario.Margin = New System.Windows.Forms.Padding(4)
		Me.cboUsuario.Name = "cboUsuario"
		Me.cboUsuario.Size = New System.Drawing.Size(367, 25)
		Me.cboUsuario.TabIndex = 24
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(11, 86)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(64, 17)
		Me.Label2.TabIndex = 23
		Me.Label2.Text = "Usuario"
		'
		'dtpFechaComp
		'
		Me.dtpFechaComp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpFechaComp.Location = New System.Drawing.Point(187, 52)
		Me.dtpFechaComp.Margin = New System.Windows.Forms.Padding(4)
		Me.dtpFechaComp.Name = "dtpFechaComp"
		Me.dtpFechaComp.Size = New System.Drawing.Size(151, 23)
		Me.dtpFechaComp.TabIndex = 22
		Me.dtpFechaComp.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
		'
		'cboProveedor
		'
		Me.cboProveedor.AccessibleDescription = ""
		Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboProveedor.FormattingEnabled = True
		Me.cboProveedor.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboProveedor.Location = New System.Drawing.Point(187, 19)
		Me.cboProveedor.Margin = New System.Windows.Forms.Padding(4)
		Me.cboProveedor.Name = "cboProveedor"
		Me.cboProveedor.Size = New System.Drawing.Size(367, 25)
		Me.cboProveedor.TabIndex = 0
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(11, 30)
		Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(83, 17)
		Me.Label17.TabIndex = 21
		Me.Label17.Text = "Proveedor"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Location = New System.Drawing.Point(11, 57)
		Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(151, 17)
		Me.Label16.TabIndex = 21
		Me.Label16.Text = "Fecha comprobante"
		'
		'dgvProveedores
		'
		Me.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvProveedores.Location = New System.Drawing.Point(13, 203)
		Me.dgvProveedores.Margin = New System.Windows.Forms.Padding(4)
		Me.dgvProveedores.Name = "dgvProveedores"
		Me.dgvProveedores.Size = New System.Drawing.Size(1272, 214)
		Me.dgvProveedores.TabIndex = 40
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
		Me.btnBuscar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.loupe_78956__1_
		Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnBuscar.FlatAppearance.BorderSize = 0
		Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscar.Location = New System.Drawing.Point(867, 19)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(137, 110)
		Me.btnBuscar.TabIndex = 5
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
		Me.btnNuevo.Location = New System.Drawing.Point(1033, 83)
		Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevo.Name = "btnNuevo"
		Me.btnNuevo.Size = New System.Drawing.Size(137, 112)
		Me.btnNuevo.TabIndex = 38
		Me.btnNuevo.Text = "Nueva"
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
		Me.btnSalir.Location = New System.Drawing.Point(1178, 76)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(107, 110)
		Me.btnSalir.TabIndex = 37
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'FrmGestionCompras
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1302, 450)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBox5)
		Me.Controls.Add(Me.dgvProveedores)
		Me.Controls.Add(Me.btnNuevo)
		Me.Controls.Add(Me.btnSalir)
		Me.Name = "FrmGestionCompras"
		Me.Text = "FrmGestionCompras"
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
	Friend WithEvents dtpFechaComp2 As Windows.Forms.DateTimePicker
	Friend WithEvents rbtEntreFechas As Windows.Forms.RadioButton
	Friend WithEvents cboUsuario As Windows.Forms.ComboBox
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents dtpFechaComp As Windows.Forms.DateTimePicker
	Friend WithEvents btnBuscar As Windows.Forms.Button
	Friend WithEvents cboProveedor As Windows.Forms.ComboBox
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents Label16 As Windows.Forms.Label
	Friend WithEvents dgvProveedores As Windows.Forms.DataGridView
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents btnSalir As Windows.Forms.Button
End Class
