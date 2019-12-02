<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestionServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestionServicio))
        Me.TbPrecio = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TbNombreServicio = New System.Windows.Forms.TextBox()
        Me.gboServicio = New System.Windows.Forms.GroupBox()
        Me.btnProveedor = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnguardarmodificacion = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbldesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.rbtFechaExacta = New System.Windows.Forms.CheckBox()
        Me.rbtEntreFechas = New System.Windows.Forms.CheckBox()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblFechaExacta = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gboServicio.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TbPrecio
        '
        Me.TbPrecio.Location = New System.Drawing.Point(139, 73)
        Me.TbPrecio.Name = "TbPrecio"
        Me.TbPrecio.Size = New System.Drawing.Size(79, 20)
        Me.TbPrecio.TabIndex = 59
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 76)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 13)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Precio  $"
        '
        'cmbProveedor
        '
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(139, 44)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(211, 21)
        Me.cmbProveedor.TabIndex = 57
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(7, 46)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 13)
        Me.Label26.TabIndex = 56
        Me.Label26.Text = "Proveedor"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(8, 17)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(121, 13)
        Me.Label32.TabIndex = 55
        Me.Label32.Text = "Nombre del Servicio"
        '
        'TbNombreServicio
        '
        Me.TbNombreServicio.Location = New System.Drawing.Point(139, 14)
        Me.TbNombreServicio.Name = "TbNombreServicio"
        Me.TbNombreServicio.Size = New System.Drawing.Size(245, 20)
        Me.TbNombreServicio.TabIndex = 54
        '
        'gboServicio
        '
        Me.gboServicio.Controls.Add(Me.cmbProveedor)
        Me.gboServicio.Controls.Add(Me.btnProveedor)
        Me.gboServicio.Controls.Add(Me.TbNombreServicio)
        Me.gboServicio.Controls.Add(Me.TbPrecio)
        Me.gboServicio.Controls.Add(Me.Label32)
        Me.gboServicio.Controls.Add(Me.Label20)
        Me.gboServicio.Controls.Add(Me.Label26)
        Me.gboServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboServicio.Location = New System.Drawing.Point(10, 32)
        Me.gboServicio.Name = "gboServicio"
        Me.gboServicio.Size = New System.Drawing.Size(586, 109)
        Me.gboServicio.TabIndex = 61
        Me.gboServicio.TabStop = False
        '
        'btnProveedor
        '
        Me.btnProveedor.BackColor = System.Drawing.SystemColors.Control
        Me.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnProveedor.FlatAppearance.BorderSize = 0
        Me.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedor.Image = CType(resources.GetObject("btnProveedor.Image"), System.Drawing.Image)
        Me.btnProveedor.Location = New System.Drawing.Point(356, 40)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(28, 28)
        Me.btnProveedor.TabIndex = 60
        Me.btnProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProveedor.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 56
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(511, 316)
        Me.DataGridView1.TabIndex = 62
        '
        'btnguardarmodificacion
        '
        Me.btnguardarmodificacion.BackColor = System.Drawing.SystemColors.Control
        Me.btnguardarmodificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnguardarmodificacion.FlatAppearance.BorderSize = 0
        Me.btnguardarmodificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardarmodificacion.Image = CType(resources.GetObject("btnguardarmodificacion.Image"), System.Drawing.Image)
        Me.btnguardarmodificacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnguardarmodificacion.Location = New System.Drawing.Point(517, 90)
        Me.btnguardarmodificacion.Name = "btnguardarmodificacion"
        Me.btnguardarmodificacion.Size = New System.Drawing.Size(69, 81)
        Me.btnguardarmodificacion.TabIndex = 64
        Me.btnguardarmodificacion.Text = "Guardar"
        Me.btnguardarmodificacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnguardarmodificacion.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(517, 3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(69, 81)
        Me.btnNuevo.TabIndex = 63
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(517, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 81)
        Me.Button2.TabIndex = 67
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.lbldesde)
        Me.GroupBox5.Controls.Add(Me.lblHasta)
        Me.GroupBox5.Controls.Add(Me.rbtFechaExacta)
        Me.GroupBox5.Controls.Add(Me.rbtEntreFechas)
        Me.GroupBox5.Controls.Add(Me.dtpFechaHasta)
        Me.GroupBox5.Controls.Add(Me.dtpFechaDesde)
        Me.GroupBox5.Controls.Add(Me.btnBuscar)
        Me.GroupBox5.Controls.Add(Me.cboProveedor)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.lblFechaExacta)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(10, 144)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(592, 135)
        Me.GroupBox5.TabIndex = 68
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Búsqueda"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(108, 106)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 20)
        Me.TextBox1.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Nombre Servicio"
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesde.Location = New System.Drawing.Point(8, 64)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(43, 13)
        Me.lbldesde.TabIndex = 41
        Me.lbldesde.Text = "Desde"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(171, 64)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(40, 13)
        Me.lblHasta.TabIndex = 40
        Me.lblHasta.Text = "Hasta"
        '
        'rbtFechaExacta
        '
        Me.rbtFechaExacta.AutoSize = True
        Me.rbtFechaExacta.Location = New System.Drawing.Point(10, 45)
        Me.rbtFechaExacta.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtFechaExacta.Name = "rbtFechaExacta"
        Me.rbtFechaExacta.Size = New System.Drawing.Size(103, 17)
        Me.rbtFechaExacta.TabIndex = 39
        Me.rbtFechaExacta.Text = "Fecha exacta"
        Me.rbtFechaExacta.UseVisualStyleBackColor = True
        '
        'rbtEntreFechas
        '
        Me.rbtEntreFechas.AutoSize = True
        Me.rbtEntreFechas.Location = New System.Drawing.Point(174, 45)
        Me.rbtEntreFechas.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtEntreFechas.Name = "rbtEntreFechas"
        Me.rbtEntreFechas.Size = New System.Drawing.Size(98, 17)
        Me.rbtEntreFechas.TabIndex = 38
        Me.rbtEntreFechas.Text = "Entre fechas"
        Me.rbtEntreFechas.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaHasta.Location = New System.Drawing.Point(174, 80)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(114, 20)
        Me.dtpFechaHasta.TabIndex = 37
        Me.dtpFechaHasta.Value = New Date(2019, 7, 23, 0, 0, 1, 0)
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaDesde.Location = New System.Drawing.Point(10, 80)
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
        Me.btnBuscar.Location = New System.Drawing.Point(517, 23)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(69, 81)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'cboProveedor
        '
        Me.cboProveedor.AccessibleDescription = ""
        Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.FormattingEnabled = True
        Me.cboProveedor.Items.AddRange(New Object() {"Física", "Jurídica"})
        Me.cboProveedor.Location = New System.Drawing.Point(108, 19)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(276, 21)
        Me.cboProveedor.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "Proveedor"
        '
        'lblFechaExacta
        '
        Me.lblFechaExacta.AutoSize = True
        Me.lblFechaExacta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaExacta.Location = New System.Drawing.Point(8, 64)
        Me.lblFechaExacta.Name = "lblFechaExacta"
        Me.lblFechaExacta.Size = New System.Drawing.Size(138, 13)
        Me.lblFechaExacta.TabIndex = 21
        Me.lblFechaExacta.Text = "Fecha de Comprobante"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnguardarmodificacion)
        Me.Panel1.Location = New System.Drawing.Point(10, 285)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 316)
        Me.Panel1.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 20)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Gestion de Servicios"
        '
        'FrmGestionServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 613)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.gboServicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGestionServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestion de servicios"
        Me.gboServicio.ResumeLayout(False)
        Me.gboServicio.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProveedor As Windows.Forms.Button
	Friend WithEvents TbPrecio As Windows.Forms.TextBox
	Friend WithEvents Label20 As Windows.Forms.Label
	Friend WithEvents cmbProveedor As Windows.Forms.ComboBox
	Friend WithEvents Label26 As Windows.Forms.Label
	Friend WithEvents Label32 As Windows.Forms.Label
	Friend WithEvents TbNombreServicio As Windows.Forms.TextBox
	Friend WithEvents gboServicio As Windows.Forms.GroupBox
	Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
	Friend WithEvents btnguardarmodificacion As Windows.Forms.Button
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents Button2 As Windows.Forms.Button
	Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
	Friend WithEvents TextBox1 As Windows.Forms.TextBox
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents lbldesde As Windows.Forms.Label
	Friend WithEvents lblHasta As Windows.Forms.Label
	Friend WithEvents rbtFechaExacta As Windows.Forms.CheckBox
	Friend WithEvents rbtEntreFechas As Windows.Forms.CheckBox
	Friend WithEvents dtpFechaHasta As Windows.Forms.DateTimePicker
	Friend WithEvents dtpFechaDesde As Windows.Forms.DateTimePicker
	Friend WithEvents btnBuscar As Windows.Forms.Button
	Friend WithEvents cboProveedor As Windows.Forms.ComboBox
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents lblFechaExacta As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents Label4 As Windows.Forms.Label
End Class
