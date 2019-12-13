<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConfirmacionPedidoDeReposicion
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
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfirmacionPedidoDeReposicion))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.dgvProveedores = New System.Windows.Forms.DataGridView()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.btnNuevo = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblIdRepo = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.cboProveedor = New System.Windows.Forms.ComboBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtBusNombreProducto = New System.Windows.Forms.TextBox()
		Me.gboTotales = New System.Windows.Forms.GroupBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		Me.gboTotales.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.dgvProveedores)
		Me.Panel1.Controls.Add(Me.btnSalir)
		Me.Panel1.Controls.Add(Me.btnNuevo)
		Me.Panel1.Location = New System.Drawing.Point(6, 199)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(789, 481)
		Me.Panel1.TabIndex = 60
		'
		'dgvProveedores
		'
		Me.dgvProveedores.AllowDrop = True
		Me.dgvProveedores.AllowUserToAddRows = False
		Me.dgvProveedores.AllowUserToDeleteRows = False
		Me.dgvProveedores.AllowUserToResizeColumns = False
		Me.dgvProveedores.AllowUserToResizeRows = False
		Me.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
		DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
		Me.dgvProveedores.DefaultCellStyle = DataGridViewCellStyle2
		Me.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Left
		Me.dgvProveedores.EnableHeadersVisualStyles = False
		Me.dgvProveedores.Location = New System.Drawing.Point(0, 0)
		Me.dgvProveedores.Margin = New System.Windows.Forms.Padding(4)
		Me.dgvProveedores.MultiSelect = False
		Me.dgvProveedores.Name = "dgvProveedores"
		Me.dgvProveedores.ReadOnly = True
		Me.dgvProveedores.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.dgvProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.dgvProveedores.RowHeadersVisible = False
		Me.dgvProveedores.RowHeadersWidth = 56
		Me.dgvProveedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvProveedores.Size = New System.Drawing.Size(681, 481)
		Me.dgvProveedores.TabIndex = 50
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
		Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnSalir.Location = New System.Drawing.Point(689, 362)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(92, 115)
		Me.btnSalir.TabIndex = 47
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'btnNuevo
		'
		Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevo.FlatAppearance.BorderSize = 0
		Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
		Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnNuevo.Location = New System.Drawing.Point(689, 4)
		Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevo.Name = "btnNuevo"
		Me.btnNuevo.Size = New System.Drawing.Size(92, 115)
		Me.btnNuevo.TabIndex = 48
		Me.btnNuevo.Text = "Confirmar pedido"
		Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevo.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(3, 12)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(263, 25)
		Me.Label1.TabIndex = 58
		Me.Label1.Text = "Pedido de reposición n°"
		'
		'lblIdRepo
		'
		Me.lblIdRepo.AutoSize = True
		Me.lblIdRepo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.lblIdRepo.Location = New System.Drawing.Point(284, 12)
		Me.lblIdRepo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblIdRepo.Name = "lblIdRepo"
		Me.lblIdRepo.Size = New System.Drawing.Size(0, 25)
		Me.lblIdRepo.TabIndex = 61
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.cboProveedor)
		Me.GroupBox2.Controls.Add(Me.Label17)
		Me.GroupBox2.Controls.Add(Me.btnLimpiarFiltros)
		Me.GroupBox2.Controls.Add(Me.Button1)
		Me.GroupBox2.Controls.Add(Me.Label8)
		Me.GroupBox2.Controls.Add(Me.txtBusNombreProducto)
		Me.GroupBox2.Location = New System.Drawing.Point(6, 40)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(775, 152)
		Me.GroupBox2.TabIndex = 79
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Producto"
		'
		'cboProveedor
		'
		Me.cboProveedor.AccessibleDescription = ""
		Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboProveedor.FormattingEnabled = True
		Me.cboProveedor.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboProveedor.Location = New System.Drawing.Point(106, 91)
		Me.cboProveedor.Margin = New System.Windows.Forms.Padding(4)
		Me.cboProveedor.Name = "cboProveedor"
		Me.cboProveedor.Size = New System.Drawing.Size(237, 25)
		Me.cboProveedor.TabIndex = 82
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(6, 94)
		Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(83, 17)
		Me.Label17.TabIndex = 83
		Me.Label17.Text = "Proveedor"
		'
		'btnLimpiarFiltros
		'
		Me.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Control
		Me.btnLimpiarFiltros.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_clear_filters_40
		Me.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnLimpiarFiltros.FlatAppearance.BorderSize = 0
		Me.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLimpiarFiltros.Location = New System.Drawing.Point(696, 76)
		Me.btnLimpiarFiltros.Margin = New System.Windows.Forms.Padding(4)
		Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
		Me.btnLimpiarFiltros.Size = New System.Drawing.Size(72, 69)
		Me.btnLimpiarFiltros.TabIndex = 81
		Me.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnLimpiarFiltros.UseVisualStyleBackColor = False
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.Control
		Me.Button1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_search_48
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(696, 12)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(72, 69)
		Me.Button1.TabIndex = 80
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Label8
		'
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(6, 28)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(79, 36)
		Me.Label8.TabIndex = 78
		Me.Label8.Text = "Nombre producto"
		'
		'txtBusNombreProducto
		'
		Me.txtBusNombreProducto.Location = New System.Drawing.Point(106, 36)
		Me.txtBusNombreProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.txtBusNombreProducto.Name = "txtBusNombreProducto"
		Me.txtBusNombreProducto.Size = New System.Drawing.Size(237, 22)
		Me.txtBusNombreProducto.TabIndex = 79
		'
		'gboTotales
		'
		Me.gboTotales.Controls.Add(Me.Label11)
		Me.gboTotales.Controls.Add(Me.lblTotal)
		Me.gboTotales.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.gboTotales.Location = New System.Drawing.Point(0, 686)
		Me.gboTotales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboTotales.Name = "gboTotales"
		Me.gboTotales.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.gboTotales.Size = New System.Drawing.Size(799, 68)
		Me.gboTotales.TabIndex = 80
		Me.gboTotales.TabStop = False
		Me.gboTotales.Text = "Totales"
		'
		'Label11
		'
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold)
		Me.Label11.Location = New System.Drawing.Point(375, 16)
		Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(183, 22)
		Me.Label11.TabIndex = 30
		Me.Label11.Text = "Total del pedido"
		'
		'lblTotal
		'
		Me.lblTotal.AutoSize = True
		Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.lblTotal.Location = New System.Drawing.Point(638, 16)
		Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(49, 24)
		Me.lblTotal.TabIndex = 26
		Me.lblTotal.Text = "0.00"
		'
		'FrmConfirmacionPedidoDeReposicion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(799, 754)
		Me.Controls.Add(Me.gboTotales)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.lblIdRepo)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FrmConfirmacionPedidoDeReposicion"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Confirmación pedido de reposición"
		Me.Panel1.ResumeLayout(False)
		CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.gboTotales.ResumeLayout(False)
		Me.gboTotales.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Windows.Forms.Panel
	Friend WithEvents dgvProveedores As Windows.Forms.DataGridView
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents lblIdRepo As Windows.Forms.Label
	Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
	Friend WithEvents btnLimpiarFiltros As Windows.Forms.Button
	Friend WithEvents Button1 As Windows.Forms.Button
	Friend WithEvents Label8 As Windows.Forms.Label
	Friend WithEvents txtBusNombreProducto As Windows.Forms.TextBox
	Friend WithEvents cboProveedor As Windows.Forms.ComboBox
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents gboTotales As Windows.Forms.GroupBox
	Friend WithEvents Label11 As Windows.Forms.Label
	Friend WithEvents lblTotal As Windows.Forms.Label
End Class
