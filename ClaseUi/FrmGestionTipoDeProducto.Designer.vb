<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestionTipoDeProducto
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.txtNombre = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtDescripcion = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.dgvCategorias = New System.Windows.Forms.DataGridView()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.btnNuevo = New System.Windows.Forms.Button()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Button1)
		Me.GroupBox2.Controls.Add(Me.TextBox3)
		Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(707, 28)
		Me.GroupBox2.TabIndex = 49
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Gestión Tipo de producto"
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.Control
		Me.Button1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(736, 274)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(107, 110)
		Me.Button1.TabIndex = 42
		Me.Button1.Text = "Salir"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button1.UseVisualStyleBackColor = False
		'
		'TextBox3
		'
		Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox3.Location = New System.Drawing.Point(254, -387)
		Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
		Me.TextBox3.MaxLength = 30
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(321, 23)
		Me.TextBox3.TabIndex = 40
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btnSalir)
		Me.GroupBox1.Controls.Add(Me.TextBox2)
		Me.GroupBox1.Controls.Add(Me.txtNombre)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.txtDescripcion)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(707, 162)
		Me.GroupBox1.TabIndex = 45
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Gestión Categorías"
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Location = New System.Drawing.Point(736, 274)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(107, 110)
		Me.btnSalir.TabIndex = 42
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'TextBox2
		'
		Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox2.Location = New System.Drawing.Point(254, -387)
		Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
		Me.TextBox2.MaxLength = 30
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(321, 23)
		Me.TextBox2.TabIndex = 40
		'
		'txtNombre
		'
		Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNombre.Location = New System.Drawing.Point(7, 66)
		Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
		Me.txtNombre.MaxLength = 30
		Me.txtNombre.Name = "txtNombre"
		Me.txtNombre.Size = New System.Drawing.Size(236, 23)
		Me.txtNombre.TabIndex = 37
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(7, 37)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(75, 17)
		Me.Label2.TabIndex = 36
		Me.Label2.Text = "Nombre *"
		'
		'txtDescripcion
		'
		Me.txtDescripcion.Location = New System.Drawing.Point(284, 66)
		Me.txtDescripcion.MaxLength = 300
		Me.txtDescripcion.Multiline = True
		Me.txtDescripcion.Name = "txtDescripcion"
		Me.txtDescripcion.Size = New System.Drawing.Size(417, 84)
		Me.txtDescripcion.TabIndex = 34
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(281, 37)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(93, 17)
		Me.Label1.TabIndex = 35
		Me.Label1.Text = "Descripción"
		'
		'dgvCategorias
		'
		Me.dgvCategorias.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
		Me.dgvCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
		Me.dgvCategorias.EnableHeadersVisualStyles = False
		Me.dgvCategorias.Location = New System.Drawing.Point(22, 181)
		Me.dgvCategorias.Margin = New System.Windows.Forms.Padding(4)
		Me.dgvCategorias.MultiSelect = False
		Me.dgvCategorias.Name = "dgvCategorias"
		Me.dgvCategorias.ReadOnly = True
		Me.dgvCategorias.RowHeadersVisible = False
		Me.dgvCategorias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		Me.dgvCategorias.RowsDefaultCellStyle = DataGridViewCellStyle1
		Me.dgvCategorias.Size = New System.Drawing.Size(701, 200)
		Me.dgvCategorias.TabIndex = 44
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.SystemColors.Control
		Me.Button2.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Location = New System.Drawing.Point(731, 256)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(115, 110)
		Me.Button2.TabIndex = 48
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
		Me.btnGuardar.Location = New System.Drawing.Point(731, 138)
		Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(115, 110)
		Me.btnGuardar.TabIndex = 47
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnGuardar.UseVisualStyleBackColor = False
		'
		'btnNuevo
		'
		Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevo.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
		Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevo.FlatAppearance.BorderSize = 0
		Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevo.Location = New System.Drawing.Point(731, 24)
		Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevo.Name = "btnNuevo"
		Me.btnNuevo.Size = New System.Drawing.Size(115, 106)
		Me.btnNuevo.TabIndex = 46
		Me.btnNuevo.Text = "Nuevo"
		Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevo.UseVisualStyleBackColor = False
		'
		'FrmGestionTipoDeProducto
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(851, 401)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.btnGuardar)
		Me.Controls.Add(Me.btnNuevo)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.dgvCategorias)
		Me.Name = "FrmGestionTipoDeProducto"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FrmGestionTipoDeProducto"
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.dgvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
	Friend WithEvents Button1 As Windows.Forms.Button
	Friend WithEvents TextBox3 As Windows.Forms.TextBox
	Friend WithEvents Button2 As Windows.Forms.Button
	Friend WithEvents btnGuardar As Windows.Forms.Button
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents TextBox2 As Windows.Forms.TextBox
	Friend WithEvents txtNombre As Windows.Forms.TextBox
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents txtDescripcion As Windows.Forms.TextBox
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents dgvCategorias As Windows.Forms.DataGridView
End Class
