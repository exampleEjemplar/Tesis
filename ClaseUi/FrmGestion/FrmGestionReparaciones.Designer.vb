<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestionReparaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestionReparaciones))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbldesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.rbtFechaExacta = New System.Windows.Forms.CheckBox()
        Me.rbtEntreFechas = New System.Windows.Forms.CheckBox()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblFechaExacta = New System.Windows.Forms.Label()
        Me.dgvProveedores = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.ClaseUi.My.Resources.Resources.icons8_checklist_62
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(434, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 82)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Listar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(434, 179)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 82)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "Estadíticas"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lbldesde)
        Me.GroupBox5.Controls.Add(Me.lblHasta)
        Me.GroupBox5.Controls.Add(Me.rbtFechaExacta)
        Me.GroupBox5.Controls.Add(Me.rbtEntreFechas)
        Me.GroupBox5.Controls.Add(Me.dtpFechaHasta)
        Me.GroupBox5.Controls.Add(Me.dtpFechaDesde)
        Me.GroupBox5.Controls.Add(Me.btnBuscar)
        Me.GroupBox5.Controls.Add(Me.cboCliente)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.lblFechaExacta)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(509, 123)
        Me.GroupBox5.TabIndex = 56
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Búsqueda"
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesde.Location = New System.Drawing.Point(9, 74)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(43, 13)
        Me.lbldesde.TabIndex = 41
        Me.lbldesde.Text = "Desde"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(170, 74)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(40, 13)
        Me.lblHasta.TabIndex = 40
        Me.lblHasta.Text = "Hasta"
        '
        'rbtFechaExacta
        '
        Me.rbtFechaExacta.AutoSize = True
        Me.rbtFechaExacta.Location = New System.Drawing.Point(9, 44)
        Me.rbtFechaExacta.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtFechaExacta.Name = "rbtFechaExacta"
        Me.rbtFechaExacta.Size = New System.Drawing.Size(160, 17)
        Me.rbtFechaExacta.TabIndex = 39
        Me.rbtFechaExacta.Text = "Busqueda fecha exacta"
        Me.rbtFechaExacta.UseVisualStyleBackColor = True
        '
        'rbtEntreFechas
        '
        Me.rbtEntreFechas.AutoSize = True
        Me.rbtEntreFechas.Location = New System.Drawing.Point(173, 44)
        Me.rbtEntreFechas.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtEntreFechas.Name = "rbtEntreFechas"
        Me.rbtEntreFechas.Size = New System.Drawing.Size(157, 17)
        Me.rbtEntreFechas.TabIndex = 38
        Me.rbtEntreFechas.Text = "Busqueda entre fechas"
        Me.rbtEntreFechas.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaHasta.Location = New System.Drawing.Point(173, 90)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(114, 20)
        Me.dtpFechaHasta.TabIndex = 37
        Me.dtpFechaHasta.Value = New Date(2019, 7, 23, 0, 0, 1, 0)
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaDesde.Location = New System.Drawing.Point(12, 90)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(114, 20)
        Me.dtpFechaDesde.TabIndex = 22
        Me.dtpFechaDesde.Value = New Date(2019, 7, 23, 0, 0, 0, 0)
        Me.dtpFechaDesde.Visible = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(434, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(69, 82)
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
        Me.cboCliente.Location = New System.Drawing.Point(58, 18)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(276, 21)
        Me.cboCliente.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Cliente"
        '
        'lblFechaExacta
        '
        Me.lblFechaExacta.AutoSize = True
        Me.lblFechaExacta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaExacta.Location = New System.Drawing.Point(6, 74)
        Me.lblFechaExacta.Name = "lblFechaExacta"
        Me.lblFechaExacta.Size = New System.Drawing.Size(138, 13)
        Me.lblFechaExacta.TabIndex = 21
        Me.lblFechaExacta.Text = "Fecha de Comprobante"
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProveedores.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvProveedores.EnableHeadersVisualStyles = False
        Me.dgvProveedores.Location = New System.Drawing.Point(0, 0)
        Me.dgvProveedores.MultiSelect = False
        Me.dgvProveedores.Name = "dgvProveedores"
        Me.dgvProveedores.ReadOnly = True
        Me.dgvProveedores.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProveedores.RowHeadersVisible = False
        Me.dgvProveedores.RowHeadersWidth = 56
        Me.dgvProveedores.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedores.Size = New System.Drawing.Size(428, 440)
        Me.dgvProveedores.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 20)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Gestión reparaciones"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Image = Global.ClaseUi.My.Resources.Resources.icons8_create_document_621
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(434, 3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(69, 82)
        Me.btnNuevo.TabIndex = 55
        Me.btnNuevo.Text = "Nueva"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Image = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(434, 355)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(69, 82)
        Me.btnSalir.TabIndex = 54
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvProveedores)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Location = New System.Drawing.Point(12, 161)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 440)
        Me.Panel1.TabIndex = 60
        '
        'FrmGestionReparaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 613)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGestionReparaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion de reparaciones"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Windows.Forms.Button
	Friend WithEvents Button2 As Windows.Forms.Button
	Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
	Friend WithEvents lbldesde As Windows.Forms.Label
	Friend WithEvents lblHasta As Windows.Forms.Label
	Friend WithEvents rbtFechaExacta As Windows.Forms.CheckBox
	Friend WithEvents rbtEntreFechas As Windows.Forms.CheckBox
	Friend WithEvents dtpFechaHasta As Windows.Forms.DateTimePicker
	Friend WithEvents dtpFechaDesde As Windows.Forms.DateTimePicker
	Friend WithEvents btnBuscar As Windows.Forms.Button
	Friend WithEvents cboCliente As Windows.Forms.ComboBox
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents lblFechaExacta As Windows.Forms.Label
	Friend WithEvents dgvProveedores As Windows.Forms.DataGridView
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
End Class
