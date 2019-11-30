<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetallePedidoDeReposicion
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
		Me.dgvProductos = New System.Windows.Forms.DataGridView()
		Me.Label32 = New System.Windows.Forms.Label()
		Me.lblBase = New System.Windows.Forms.Label()
		Me.lblStockMinimo = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lblMaximo = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblProveedor = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblAComprar = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtForzado = New System.Windows.Forms.TextBox()
		Me.lblProducto = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.btnguardarmodificacion = New System.Windows.Forms.Button()
		Me.btncancelar = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnGuardarProveedor = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'dgvProductos
		'
		Me.dgvProductos.AllowDrop = True
		Me.dgvProductos.AllowUserToAddRows = False
		Me.dgvProductos.AllowUserToDeleteRows = False
		Me.dgvProductos.AllowUserToResizeColumns = False
		Me.dgvProductos.AllowUserToResizeRows = False
		Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.dgvProductos.ColumnHeadersHeight = 45
		Me.dgvProductos.EnableHeadersVisualStyles = False
		Me.dgvProductos.Location = New System.Drawing.Point(13, 247)
		Me.dgvProductos.Margin = New System.Windows.Forms.Padding(4)
		Me.dgvProductos.MultiSelect = False
		Me.dgvProductos.Name = "dgvProductos"
		Me.dgvProductos.ReadOnly = True
		Me.dgvProductos.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.dgvProductos.RowHeadersVisible = False
		Me.dgvProductos.RowHeadersWidth = 56
		Me.dgvProductos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvProductos.Size = New System.Drawing.Size(774, 245)
		Me.dgvProductos.TabIndex = 38
		'
		'Label32
		'
		Me.Label32.AutoSize = True
		Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label32.Location = New System.Drawing.Point(14, 15)
		Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label32.Name = "Label32"
		Me.Label32.Size = New System.Drawing.Size(49, 17)
		Me.Label32.TabIndex = 61
		Me.Label32.Text = "Base:"
		'
		'lblBase
		'
		Me.lblBase.AutoSize = True
		Me.lblBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBase.Location = New System.Drawing.Point(148, 15)
		Me.lblBase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblBase.Name = "lblBase"
		Me.lblBase.Size = New System.Drawing.Size(56, 17)
		Me.lblBase.TabIndex = 62
		Me.lblBase.Text = "*Base*"
		'
		'lblStockMinimo
		'
		Me.lblStockMinimo.AutoSize = True
		Me.lblStockMinimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblStockMinimo.Location = New System.Drawing.Point(122, 35)
		Me.lblStockMinimo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblStockMinimo.Name = "lblStockMinimo"
		Me.lblStockMinimo.Size = New System.Drawing.Size(70, 17)
		Me.lblStockMinimo.TabIndex = 64
		Me.lblStockMinimo.Text = "*Minimo*"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(2, 35)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(103, 17)
		Me.Label2.TabIndex = 63
		Me.Label2.Text = "Stock Minimo"
		'
		'lblMaximo
		'
		Me.lblMaximo.AutoSize = True
		Me.lblMaximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMaximo.Location = New System.Drawing.Point(119, 84)
		Me.lblMaximo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblMaximo.Name = "lblMaximo"
		Me.lblMaximo.Size = New System.Drawing.Size(73, 17)
		Me.lblMaximo.TabIndex = 66
		Me.lblMaximo.Text = "*Maximo*"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(2, 84)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(106, 17)
		Me.Label3.TabIndex = 65
		Me.Label3.Text = "Stock Máximo"
		'
		'lblProveedor
		'
		Me.lblProveedor.AutoSize = True
		Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProveedor.Location = New System.Drawing.Point(114, 136)
		Me.lblProveedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblProveedor.Name = "lblProveedor"
		Me.lblProveedor.Size = New System.Drawing.Size(95, 17)
		Me.lblProveedor.TabIndex = 68
		Me.lblProveedor.Text = "*Proveedor*"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(2, 136)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(83, 17)
		Me.Label4.TabIndex = 67
		Me.Label4.Text = "Proveedor"
		'
		'lblAComprar
		'
		Me.lblAComprar.AutoSize = True
		Me.lblAComprar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAComprar.Location = New System.Drawing.Point(578, 19)
		Me.lblAComprar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblAComprar.Name = "lblAComprar"
		Me.lblAComprar.Size = New System.Drawing.Size(91, 17)
		Me.lblAComprar.TabIndex = 70
		Me.lblAComprar.Text = "*AComprar*"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(236, 18)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(325, 17)
		Me.Label5.TabIndex = 69
		Me.Label5.Text = "Cantidad a comprar sugerida según la base"
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(269, 53)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(325, 43)
		Me.Label1.TabIndex = 71
		Me.Label1.Text = "Modifique el campo en caso de querer cambiar la cantidad a comprar"
		'
		'txtForzado
		'
		Me.txtForzado.Location = New System.Drawing.Point(577, 63)
		Me.txtForzado.Name = "txtForzado"
		Me.txtForzado.Size = New System.Drawing.Size(69, 22)
		Me.txtForzado.TabIndex = 72
		'
		'lblProducto
		'
		Me.lblProducto.AutoSize = True
		Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProducto.Location = New System.Drawing.Point(367, 137)
		Me.lblProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblProducto.Name = "lblProducto"
		Me.lblProducto.Size = New System.Drawing.Size(85, 17)
		Me.lblProducto.TabIndex = 74
		Me.lblProducto.Text = "*Producto*"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(269, 137)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(73, 17)
		Me.Label7.TabIndex = 73
		Me.Label7.Text = "Producto"
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
		Me.btnguardarmodificacion.Location = New System.Drawing.Point(577, 95)
		Me.btnguardarmodificacion.Margin = New System.Windows.Forms.Padding(4)
		Me.btnguardarmodificacion.Name = "btnguardarmodificacion"
		Me.btnguardarmodificacion.Size = New System.Drawing.Size(92, 92)
		Me.btnguardarmodificacion.TabIndex = 76
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
		Me.btncancelar.Location = New System.Drawing.Point(477, 95)
		Me.btncancelar.Margin = New System.Windows.Forms.Padding(4)
		Me.btncancelar.Name = "btncancelar"
		Me.btncancelar.Size = New System.Drawing.Size(92, 92)
		Me.btncancelar.TabIndex = 75
		Me.btncancelar.Text = "Cancelar"
		Me.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btncancelar.UseVisualStyleBackColor = False
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btnguardarmodificacion)
		Me.GroupBox1.Controls.Add(Me.lblProducto)
		Me.GroupBox1.Controls.Add(Me.btncancelar)
		Me.GroupBox1.Controls.Add(Me.Label7)
		Me.GroupBox1.Controls.Add(Me.txtForzado)
		Me.GroupBox1.Controls.Add(Me.lblAComprar)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.lblStockMinimo)
		Me.GroupBox1.Controls.Add(Me.Label5)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.lblProveedor)
		Me.GroupBox1.Controls.Add(Me.lblMaximo)
		Me.GroupBox1.Controls.Add(Me.Label4)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(676, 194)
		Me.GroupBox1.TabIndex = 77
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Producto"
		'
		'btnGuardarProveedor
		'
		Me.btnGuardarProveedor.BackColor = System.Drawing.SystemColors.Control
		Me.btnGuardarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnGuardarProveedor.FlatAppearance.BorderSize = 0
		Me.btnGuardarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnGuardarProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGuardarProveedor.Image = Global.ClaseUi.My.Resources.Resources.icons8_save_62
		Me.btnGuardarProveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnGuardarProveedor.Location = New System.Drawing.Point(695, 29)
		Me.btnGuardarProveedor.Margin = New System.Windows.Forms.Padding(4)
		Me.btnGuardarProveedor.Name = "btnGuardarProveedor"
		Me.btnGuardarProveedor.Size = New System.Drawing.Size(92, 92)
		Me.btnGuardarProveedor.TabIndex = 77
		Me.btnGuardarProveedor.Text = "Guardar"
		Me.btnGuardarProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnGuardarProveedor.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.Control
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Image = Global.ClaseUi.My.Resources.Resources.icons8_delete_62
		Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Button1.Location = New System.Drawing.Point(695, 141)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(92, 99)
		Me.Button1.TabIndex = 77
		Me.Button1.Text = "Cancelar Cambios"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button1.UseVisualStyleBackColor = False
		'
		'FrmDetallePedidoDeReposicion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 505)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.btnGuardarProveedor)
		Me.Controls.Add(Me.lblBase)
		Me.Controls.Add(Me.Label32)
		Me.Controls.Add(Me.dgvProductos)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "FrmDetallePedidoDeReposicion"
		Me.Text = "FrmDetallePedidoDeReposicion"
		CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgvProductos As Windows.Forms.DataGridView
	Friend WithEvents Label32 As Windows.Forms.Label
	Friend WithEvents lblBase As Windows.Forms.Label
	Friend WithEvents lblStockMinimo As Windows.Forms.Label
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents lblMaximo As Windows.Forms.Label
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents lblProveedor As Windows.Forms.Label
	Friend WithEvents Label4 As Windows.Forms.Label
	Friend WithEvents lblAComprar As Windows.Forms.Label
	Friend WithEvents Label5 As Windows.Forms.Label
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents txtForzado As Windows.Forms.TextBox
	Friend WithEvents lblProducto As Windows.Forms.Label
	Friend WithEvents Label7 As Windows.Forms.Label
	Friend WithEvents btnguardarmodificacion As Windows.Forms.Button
	Friend WithEvents btncancelar As Windows.Forms.Button
	Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
	Friend WithEvents btnGuardarProveedor As Windows.Forms.Button
	Friend WithEvents Button1 As Windows.Forms.Button
End Class
