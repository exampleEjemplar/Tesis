<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArmadoCompra
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
		Me.btnNuevo = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.btnQuitar = New System.Windows.Forms.Button()
		Me.dgvProdSelec = New System.Windows.Forms.DataGridView()
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.lstProdDispo = New System.Windows.Forms.ListView()
		Me.btnAgregar = New System.Windows.Forms.Button()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.cboCliente = New System.Windows.Forms.ComboBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		CType(Me.dgvProdSelec, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.SuspendLayout()
		'
		'btnNuevo
		'
		Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevo.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
		Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevo.FlatAppearance.BorderSize = 0
		Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevo.Location = New System.Drawing.Point(953, 3)
		Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevo.Name = "btnNuevo"
		Me.btnNuevo.Size = New System.Drawing.Size(122, 98)
		Me.btnNuevo.TabIndex = 44
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
		Me.btnSalir.Location = New System.Drawing.Point(1083, 3)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(106, 100)
		Me.btnSalir.TabIndex = 43
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'btnQuitar
		'
		Me.btnQuitar.BackColor = System.Drawing.SystemColors.Control
		Me.btnQuitar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.minus
		Me.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnQuitar.FlatAppearance.BorderSize = 0
		Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnQuitar.Location = New System.Drawing.Point(568, 297)
		Me.btnQuitar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnQuitar.Name = "btnQuitar"
		Me.btnQuitar.Size = New System.Drawing.Size(119, 113)
		Me.btnQuitar.TabIndex = 40
		Me.btnQuitar.Text = "Quitar"
		Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnQuitar.UseVisualStyleBackColor = False
		'
		'dgvProdSelec
		'
		Me.dgvProdSelec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvProdSelec.Location = New System.Drawing.Point(7, 22)
		Me.dgvProdSelec.Name = "dgvProdSelec"
		Me.dgvProdSelec.RowTemplate.Height = 24
		Me.dgvProdSelec.Size = New System.Drawing.Size(499, 551)
		Me.dgvProdSelec.TabIndex = 0
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.dgvProdSelec)
		Me.GroupBox4.Location = New System.Drawing.Point(687, 166)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(512, 579)
		Me.GroupBox4.TabIndex = 41
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Productos en la venta"
		'
		'lstProdDispo
		'
		Me.lstProdDispo.Location = New System.Drawing.Point(12, 21)
		Me.lstProdDispo.Name = "lstProdDispo"
		Me.lstProdDispo.Size = New System.Drawing.Size(537, 552)
		Me.lstProdDispo.TabIndex = 0
		Me.lstProdDispo.UseCompatibleStateImageBehavior = False
		'
		'btnAgregar
		'
		Me.btnAgregar.BackColor = System.Drawing.SystemColors.Control
		Me.btnAgregar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.plus1
		Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnAgregar.FlatAppearance.BorderSize = 0
		Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnAgregar.Location = New System.Drawing.Point(571, 176)
		Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnAgregar.Name = "btnAgregar"
		Me.btnAgregar.Size = New System.Drawing.Size(113, 113)
		Me.btnAgregar.TabIndex = 42
		Me.btnAgregar.Text = "Agregar"
		Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnAgregar.UseVisualStyleBackColor = False
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.lstProdDispo)
		Me.GroupBox3.Location = New System.Drawing.Point(12, 166)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(555, 579)
		Me.GroupBox3.TabIndex = 38
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Productos disponibles"
		'
		'cboCliente
		'
		Me.cboCliente.AccessibleDescription = ""
		Me.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCliente.FormattingEnabled = True
		Me.cboCliente.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboCliente.Location = New System.Drawing.Point(184, 107)
		Me.cboCliente.Margin = New System.Windows.Forms.Padding(4)
		Me.cboCliente.Name = "cboCliente"
		Me.cboCliente.Size = New System.Drawing.Size(367, 25)
		Me.cboCliente.TabIndex = 24
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(13, 107)
		Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(83, 17)
		Me.Label17.TabIndex = 25
		Me.Label17.Text = "Proveedor"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(3, 5)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(385, 25)
		Me.Label1.TabIndex = 36
		Me.Label1.Text = "Armado de comprobante de compra"
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.Control
		Me.Button1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.plus1
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(778, 8)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(180, 98)
		Me.Button1.TabIndex = 45
		Me.Button1.Text = "Agregar nuevo producto"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button1.UseVisualStyleBackColor = False
		'
		'ComboBox1
		'
		Me.ComboBox1.AccessibleDescription = ""
		Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.ComboBox1.Location = New System.Drawing.Point(184, 51)
		Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(367, 25)
		Me.ComboBox1.TabIndex = 26
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(11, 54)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(121, 17)
		Me.Label2.TabIndex = 27
		Me.Label2.Text = "Tipo de compra"
		'
		'FrmArmadoCompra
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1203, 798)
		Me.Controls.Add(Me.cboCliente)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.btnNuevo)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.btnQuitar)
		Me.Controls.Add(Me.GroupBox4)
		Me.Controls.Add(Me.btnAgregar)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.Label1)
		Me.Name = "FrmArmadoCompra"
		Me.Text = "FrmArmadoCompra"
		CType(Me.dgvProdSelec, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox3.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents btnQuitar As Windows.Forms.Button
	Friend WithEvents dgvProdSelec As Windows.Forms.DataGridView
	Friend WithEvents GroupBox4 As Windows.Forms.GroupBox
	Friend WithEvents lstProdDispo As Windows.Forms.ListView
	Friend WithEvents btnAgregar As Windows.Forms.Button
	Friend WithEvents GroupBox3 As Windows.Forms.GroupBox
	Friend WithEvents cboCliente As Windows.Forms.ComboBox
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents Button1 As Windows.Forms.Button
	Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
	Friend WithEvents Label2 As Windows.Forms.Label
End Class
