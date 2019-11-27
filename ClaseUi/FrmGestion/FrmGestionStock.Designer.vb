<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionStock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestionStock))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBusNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lbldesde = New System.Windows.Forms.Label()
        Me.rbtEntreFechas = New System.Windows.Forms.CheckBox()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.rbtFechaExacta = New System.Windows.Forms.CheckBox()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaExacta = New System.Windows.Forms.Label()
        Me.btnSalirr = New System.Windows.Forms.Button()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(530, 23)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gestión Stock"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(552, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 89)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(190, -314)
        Me.TextBox3.MaxLength = 30
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(242, 20)
        Me.TextBox3.TabIndex = 40
        '
        'cboProveedor
        '
        Me.cboProveedor.AccessibleDescription = ""
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Items.AddRange(New Object() {"Física", "Jurídica"})
        Me.cboProveedor.Location = New System.Drawing.Point(118, 51)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(276, 21)
        Me.cboProveedor.TabIndex = 57
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Proveedor"
        '
        'txtBusNombreProducto
        '
        Me.txtBusNombreProducto.Location = New System.Drawing.Point(118, 87)
        Me.txtBusNombreProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBusNombreProducto.Name = "txtBusNombreProducto"
        Me.txtBusNombreProducto.Size = New System.Drawing.Size(152, 20)
        Me.txtBusNombreProducto.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(10, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Nombre producto"
        '
        'btnLimpiarFiltros
        '
        Me.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Control
        Me.btnLimpiarFiltros.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_clear_filters_40
        Me.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiarFiltros.FlatAppearance.BorderSize = 0
        Me.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarFiltros.Location = New System.Drawing.Point(422, 106)
        Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
        Me.btnLimpiarFiltros.Size = New System.Drawing.Size(56, 62)
        Me.btnLimpiarFiltros.TabIndex = 62
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
        Me.btnBuscar.Location = New System.Drawing.Point(484, 109)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(56, 59)
        Me.btnBuscar.TabIndex = 63
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.lbldesde.Location = New System.Drawing.Point(82, 150)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(43, 13)
        Me.lbldesde.TabIndex = 70
        Me.lbldesde.Text = "Desde"
        '
        'rbtEntreFechas
        '
        Me.rbtEntreFechas.AutoSize = True
        Me.rbtEntreFechas.Location = New System.Drawing.Point(255, 119)
        Me.rbtEntreFechas.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtEntreFechas.Name = "rbtEntreFechas"
        Me.rbtEntreFechas.Size = New System.Drawing.Size(136, 17)
        Me.rbtEntreFechas.TabIndex = 67
        Me.rbtEntreFechas.Text = "Busqueda entre fechas"
        Me.rbtEntreFechas.UseVisualStyleBackColor = True
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.lblHasta.Location = New System.Drawing.Point(248, 150)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(39, 13)
        Me.lblHasta.TabIndex = 69
        Me.lblHasta.Text = "Hasta"
        '
        'rbtFechaExacta
        '
        Me.rbtFechaExacta.AutoSize = True
        Me.rbtFechaExacta.Location = New System.Drawing.Point(12, 119)
        Me.rbtFechaExacta.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtFechaExacta.Name = "rbtFechaExacta"
        Me.rbtFechaExacta.Size = New System.Drawing.Size(244, 17)
        Me.rbtFechaExacta.TabIndex = 68
        Me.rbtFechaExacta.Text = "Busqueda fecha exacta de carga de producto"
        Me.rbtFechaExacta.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(292, 147)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(114, 20)
        Me.dtpFechaHasta.TabIndex = 66
        Me.dtpFechaHasta.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(129, 147)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(114, 20)
        Me.dtpFechaDesde.TabIndex = 65
        Me.dtpFechaDesde.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
        '
        'lblFechaExacta
        '
        Me.lblFechaExacta.AutoSize = True
        Me.lblFechaExacta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.lblFechaExacta.Location = New System.Drawing.Point(10, 150)
        Me.lblFechaExacta.Name = "lblFechaExacta"
        Me.lblFechaExacta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaExacta.TabIndex = 64
        Me.lblFechaExacta.Text = "Fecha carga"
        '
        'btnSalirr
        '
        Me.btnSalirr.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalirr.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.btnSalirr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalirr.FlatAppearance.BorderSize = 0
        Me.btnSalirr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalirr.Location = New System.Drawing.Point(558, 342)
        Me.btnSalirr.Name = "btnSalirr"
        Me.btnSalirr.Size = New System.Drawing.Size(80, 89)
        Me.btnSalirr.TabIndex = 54
        Me.btnSalirr.Text = "Salir"
        Me.btnSalirr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalirr.UseVisualStyleBackColor = False
        '
        'dgvGrilla
        '
        Me.dgvGrilla.AllowDrop = True
        Me.dgvGrilla.AllowUserToAddRows = False
        Me.dgvGrilla.AllowUserToDeleteRows = False
        Me.dgvGrilla.AllowUserToResizeColumns = False
        Me.dgvGrilla.AllowUserToResizeRows = False
        Me.dgvGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGrilla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvGrilla.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvGrilla.Location = New System.Drawing.Point(28, 174)
        Me.dgvGrilla.MultiSelect = False
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.ReadOnly = True
        Me.dgvGrilla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvGrilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvGrilla.RowHeadersVisible = False
        Me.dgvGrilla.RowHeadersWidth = 56
        Me.dgvGrilla.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrilla.Size = New System.Drawing.Size(524, 253)
        Me.dgvGrilla.TabIndex = 56
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(552, 256)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 80)
        Me.Button3.TabIndex = 71
        Me.Button3.Text = "Estadísticas"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.Button2.Location = New System.Drawing.Point(561, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 80)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "Listar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FrmGestionStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 439)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lbldesde)
        Me.Controls.Add(Me.rbtEntreFechas)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.rbtFechaExacta)
        Me.Controls.Add(Me.dtpFechaHasta)
        Me.Controls.Add(Me.dtpFechaDesde)
        Me.Controls.Add(Me.lblFechaExacta)
        Me.Controls.Add(Me.btnLimpiarFiltros)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBusNombreProducto)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboProveedor)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dgvGrilla)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSalirr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGestionStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion Stock"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents TextBox3 As Windows.Forms.TextBox
    Friend WithEvents cboProveedor As Windows.Forms.ComboBox
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents txtBusNombreProducto As Windows.Forms.TextBox
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents btnLimpiarFiltros As Windows.Forms.Button
    Friend WithEvents btnBuscar As Windows.Forms.Button
    Friend WithEvents lbldesde As Windows.Forms.Label
    Friend WithEvents rbtEntreFechas As Windows.Forms.CheckBox
    Friend WithEvents lblHasta As Windows.Forms.Label
    Friend WithEvents rbtFechaExacta As Windows.Forms.CheckBox
    Friend WithEvents dtpFechaHasta As Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaDesde As Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaExacta As Windows.Forms.Label
    Friend WithEvents btnSalirr As Windows.Forms.Button
    Friend WithEvents dgvGrilla As Windows.Forms.DataGridView
    Friend WithEvents Button3 As Windows.Forms.Button
    Friend WithEvents Button2 As Windows.Forms.Button
End Class
