<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestionVentas
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
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.dtpfechanac = New System.Windows.Forms.DateTimePicker()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.cboCliente = New System.Windows.Forms.ComboBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.dgvProveedores = New System.Windows.Forms.DataGridView()
		Me.btnNuevo = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox5.SuspendLayout()
		CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.dtpfechanac)
		Me.GroupBox5.Controls.Add(Me.btnBuscar)
		Me.GroupBox5.Controls.Add(Me.cboCliente)
		Me.GroupBox5.Controls.Add(Me.Label17)
		Me.GroupBox5.Controls.Add(Me.Label16)
		Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox5.Location = New System.Drawing.Point(13, 62)
		Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox5.Size = New System.Drawing.Size(608, 133)
		Me.GroupBox5.TabIndex = 34
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Búsqueda"
		'
		'dtpfechanac
		'
		Me.dtpfechanac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpfechanac.Location = New System.Drawing.Point(228, 54)
		Me.dtpfechanac.Margin = New System.Windows.Forms.Padding(4)
		Me.dtpfechanac.Name = "dtpfechanac"
		Me.dtpfechanac.Size = New System.Drawing.Size(215, 23)
		Me.dtpfechanac.TabIndex = 22
		Me.dtpfechanac.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
		Me.btnBuscar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.loupe_78956__1_
		Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnBuscar.FlatAppearance.BorderSize = 0
		Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscar.Location = New System.Drawing.Point(466, 9)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(137, 110)
		Me.btnBuscar.TabIndex = 5
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'cboCliente
		'
		Me.cboCliente.AccessibleDescription = ""
		Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCliente.FormattingEnabled = True
		Me.cboCliente.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboCliente.Location = New System.Drawing.Point(228, 21)
		Me.cboCliente.Margin = New System.Windows.Forms.Padding(4)
		Me.cboCliente.Name = "cboCliente"
		Me.cboCliente.Size = New System.Drawing.Size(215, 25)
		Me.cboCliente.TabIndex = 0
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(11, 30)
		Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(58, 17)
		Me.Label17.TabIndex = 21
		Me.Label17.Text = "Cliente"
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
		Me.dgvProveedores.TabIndex = 35
		'
		'btnNuevo
		'
		Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevo.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
		Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevo.FlatAppearance.BorderSize = 0
		Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevo.Location = New System.Drawing.Point(627, 74)
		Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevo.Name = "btnNuevo"
		Me.btnNuevo.Size = New System.Drawing.Size(137, 112)
		Me.btnNuevo.TabIndex = 33
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
		Me.btnSalir.TabIndex = 32
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(13, 9)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(170, 25)
		Me.Label1.TabIndex = 23
		Me.Label1.Text = "Gestión ventas"
		'
		'FrmGestionVentas
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1316, 424)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBox5)
		Me.Controls.Add(Me.dgvProveedores)
		Me.Controls.Add(Me.btnNuevo)
		Me.Controls.Add(Me.btnSalir)
		Me.Name = "FrmGestionVentas"
		Me.Text = "FrmGestionVentas"
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
	Friend WithEvents btnBuscar As Windows.Forms.Button
	Friend WithEvents cboCliente As Windows.Forms.ComboBox
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents Label16 As Windows.Forms.Label
	Friend WithEvents dgvProveedores As Windows.Forms.DataGridView
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents dtpfechanac As Windows.Forms.DateTimePicker
	Friend WithEvents Label1 As Windows.Forms.Label
End Class
