<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestionPedidoDeReposicion
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
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestionPedidoDeReposicion))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.dgvProveedores = New System.Windows.Forms.DataGridView()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.btnNuevo = New System.Windows.Forms.Button()
		Me.lbldesde = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lblHasta = New System.Windows.Forms.Label()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.rbtFechaExacta = New System.Windows.Forms.CheckBox()
		Me.rbtEntreFechas = New System.Windows.Forms.CheckBox()
		Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
		Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
		Me.lblFechaExacta = New System.Windows.Forms.Label()
		Me.Panel1.SuspendLayout()
		CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox5.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.dgvProveedores)
		Me.Panel1.Controls.Add(Me.btnEliminar)
		Me.Panel1.Controls.Add(Me.btnSalir)
		Me.Panel1.Controls.Add(Me.btnNuevo)
		Me.Panel1.Location = New System.Drawing.Point(7, 191)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(789, 544)
		Me.Panel1.TabIndex = 57
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
		Me.dgvProveedores.Size = New System.Drawing.Size(681, 544)
		Me.dgvProveedores.TabIndex = 50
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
		Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnEliminar.FlatAppearance.BorderSize = 0
		Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEliminar.Image = Global.ClaseUi.My.Resources.Resources.icons8_cancel_621
		Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnEliminar.Location = New System.Drawing.Point(689, 112)
		Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(92, 100)
		Me.btnEliminar.TabIndex = 53
		Me.btnEliminar.Text = "Anular"
		Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnEliminar.UseVisualStyleBackColor = False
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
		Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnSalir.Location = New System.Drawing.Point(689, 441)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(92, 100)
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
		Me.btnNuevo.Size = New System.Drawing.Size(92, 100)
		Me.btnNuevo.TabIndex = 48
		Me.btnNuevo.Text = "Nuevo"
		Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevo.UseVisualStyleBackColor = False
		'
		'lbldesde
		'
		Me.lbldesde.AutoSize = True
		Me.lbldesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbldesde.Location = New System.Drawing.Point(4, 62)
		Me.lbldesde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lbldesde.Name = "lbldesde"
		Me.lbldesde.Size = New System.Drawing.Size(54, 17)
		Me.lbldesde.TabIndex = 41
		Me.lbldesde.Text = "Desde"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(4, 4)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(332, 25)
		Me.Label1.TabIndex = 55
		Me.Label1.Text = "Gestión pedidos de reposición"
		'
		'lblHasta
		'
		Me.lblHasta.AutoSize = True
		Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHasta.Location = New System.Drawing.Point(188, 62)
		Me.lblHasta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblHasta.Name = "lblHasta"
		Me.lblHasta.Size = New System.Drawing.Size(50, 17)
		Me.lblHasta.TabIndex = 40
		Me.lblHasta.Text = "Hasta"
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.btnLimpiarFiltros)
		Me.GroupBox5.Controls.Add(Me.Button1)
		Me.GroupBox5.Controls.Add(Me.lbldesde)
		Me.GroupBox5.Controls.Add(Me.lblHasta)
		Me.GroupBox5.Controls.Add(Me.rbtFechaExacta)
		Me.GroupBox5.Controls.Add(Me.rbtEntreFechas)
		Me.GroupBox5.Controls.Add(Me.dtpFechaHasta)
		Me.GroupBox5.Controls.Add(Me.dtpFechaDesde)
		Me.GroupBox5.Controls.Add(Me.lblFechaExacta)
		Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox5.Location = New System.Drawing.Point(7, 32)
		Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox5.Size = New System.Drawing.Size(789, 151)
		Me.GroupBox5.TabIndex = 56
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Búsqueda"
		'
		'btnLimpiarFiltros
		'
		Me.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Control
		Me.btnLimpiarFiltros.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_clear_filters_40
		Me.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnLimpiarFiltros.FlatAppearance.BorderSize = 0
		Me.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnLimpiarFiltros.Location = New System.Drawing.Point(709, 81)
		Me.btnLimpiarFiltros.Margin = New System.Windows.Forms.Padding(4)
		Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
		Me.btnLimpiarFiltros.Size = New System.Drawing.Size(72, 69)
		Me.btnLimpiarFiltros.TabIndex = 83
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
		Me.Button1.Location = New System.Drawing.Point(709, 10)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(72, 69)
		Me.Button1.TabIndex = 82
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button1.UseVisualStyleBackColor = False
		'
		'rbtFechaExacta
		'
		Me.rbtFechaExacta.AutoSize = True
		Me.rbtFechaExacta.Location = New System.Drawing.Point(9, 22)
		Me.rbtFechaExacta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.rbtFechaExacta.Name = "rbtFechaExacta"
		Me.rbtFechaExacta.Size = New System.Drawing.Size(180, 21)
		Me.rbtFechaExacta.TabIndex = 39
		Me.rbtFechaExacta.Text = "Fecha exacta pedido"
		Me.rbtFechaExacta.UseVisualStyleBackColor = True
		'
		'rbtEntreFechas
		'
		Me.rbtEntreFechas.AutoSize = True
		Me.rbtEntreFechas.Location = New System.Drawing.Point(207, 22)
		Me.rbtEntreFechas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.rbtEntreFechas.Name = "rbtEntreFechas"
		Me.rbtEntreFechas.Size = New System.Drawing.Size(122, 21)
		Me.rbtEntreFechas.TabIndex = 38
		Me.rbtEntreFechas.Text = "Entre fechas"
		Me.rbtEntreFechas.UseVisualStyleBackColor = True
		'
		'dtpFechaHasta
		'
		Me.dtpFechaHasta.CustomFormat = "dd/MM/yyyy"
		Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpFechaHasta.Location = New System.Drawing.Point(192, 81)
		Me.dtpFechaHasta.Margin = New System.Windows.Forms.Padding(4)
		Me.dtpFechaHasta.Name = "dtpFechaHasta"
		Me.dtpFechaHasta.Size = New System.Drawing.Size(128, 23)
		Me.dtpFechaHasta.TabIndex = 37
		Me.dtpFechaHasta.Value = New Date(2019, 7, 23, 0, 0, 1, 0)
		'
		'dtpFechaDesde
		'
		Me.dtpFechaDesde.CustomFormat = "dd/MM/yyyy"
		Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpFechaDesde.Location = New System.Drawing.Point(8, 81)
		Me.dtpFechaDesde.Margin = New System.Windows.Forms.Padding(4)
		Me.dtpFechaDesde.Name = "dtpFechaDesde"
		Me.dtpFechaDesde.Size = New System.Drawing.Size(127, 23)
		Me.dtpFechaDesde.TabIndex = 22
		Me.dtpFechaDesde.Value = New Date(2019, 7, 23, 0, 0, 0, 0)
		Me.dtpFechaDesde.Visible = False
		'
		'lblFechaExacta
		'
		Me.lblFechaExacta.AutoSize = True
		Me.lblFechaExacta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFechaExacta.Location = New System.Drawing.Point(5, 62)
		Me.lblFechaExacta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblFechaExacta.Name = "lblFechaExacta"
		Me.lblFechaExacta.Size = New System.Drawing.Size(176, 17)
		Me.lblFechaExacta.TabIndex = 21
		Me.lblFechaExacta.Text = "Fecha de Comprobante"
		'
		'FrmGestionPedidoDeReposicion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(799, 754)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBox5)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FrmGestionPedidoDeReposicion"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Gestion de pedidos de reposición"
		Me.Panel1.ResumeLayout(False)
		CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Windows.Forms.Panel
	Friend WithEvents dgvProveedores As Windows.Forms.DataGridView
	Friend WithEvents btnEliminar As Windows.Forms.Button
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents lbldesde As Windows.Forms.Label
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents lblHasta As Windows.Forms.Label
	Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
	Friend WithEvents rbtFechaExacta As Windows.Forms.CheckBox
	Friend WithEvents rbtEntreFechas As Windows.Forms.CheckBox
	Friend WithEvents dtpFechaHasta As Windows.Forms.DateTimePicker
	Friend WithEvents dtpFechaDesde As Windows.Forms.DateTimePicker
	Friend WithEvents lblFechaExacta As Windows.Forms.Label
	Friend WithEvents btnLimpiarFiltros As Windows.Forms.Button
	Friend WithEvents Button1 As Windows.Forms.Button
End Class
