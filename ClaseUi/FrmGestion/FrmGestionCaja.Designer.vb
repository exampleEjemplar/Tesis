﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestionCaja))
        Me.btnSalirr = New System.Windows.Forms.Button()
        Me.lbldesde = New System.Windows.Forms.Label()
        Me.rbtEntreFechas = New System.Windows.Forms.CheckBox()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.rbtFechaExacta = New System.Windows.Forms.CheckBox()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaExacta = New System.Windows.Forms.Label()
        Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cboUsuarios = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIngresos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMontoFinal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidadMov = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEgresos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalirr
        '
        Me.btnSalirr.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalirr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalirr.FlatAppearance.BorderSize = 0
        Me.btnSalirr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalirr.Image = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.btnSalirr.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalirr.Location = New System.Drawing.Point(512, 263)
        Me.btnSalirr.Name = "btnSalirr"
        Me.btnSalirr.Size = New System.Drawing.Size(69, 81)
        Me.btnSalirr.TabIndex = 64
        Me.btnSalirr.Text = "Salir"
        Me.btnSalirr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalirr.UseVisualStyleBackColor = False
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldesde.Location = New System.Drawing.Point(5, 66)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(43, 13)
        Me.lbldesde.TabIndex = 83
        Me.lbldesde.Text = "Desde"
        '
        'rbtEntreFechas
        '
        Me.rbtEntreFechas.AutoSize = True
        Me.rbtEntreFechas.Location = New System.Drawing.Point(157, 45)
        Me.rbtEntreFechas.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtEntreFechas.Name = "rbtEntreFechas"
        Me.rbtEntreFechas.Size = New System.Drawing.Size(157, 17)
        Me.rbtEntreFechas.TabIndex = 80
        Me.rbtEntreFechas.Text = "Busqueda entre fechas"
        Me.rbtEntreFechas.UseVisualStyleBackColor = True
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
        Me.lblHasta.Location = New System.Drawing.Point(154, 66)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(39, 13)
        Me.lblHasta.TabIndex = 82
        Me.lblHasta.Text = "Hasta"
        '
        'rbtFechaExacta
        '
        Me.rbtFechaExacta.AutoSize = True
        Me.rbtFechaExacta.Location = New System.Drawing.Point(8, 45)
        Me.rbtFechaExacta.Margin = New System.Windows.Forms.Padding(2)
        Me.rbtFechaExacta.Name = "rbtFechaExacta"
        Me.rbtFechaExacta.Size = New System.Drawing.Size(145, 17)
        Me.rbtFechaExacta.TabIndex = 81
        Me.rbtFechaExacta.Text = "Busqueda dia exacto"
        Me.rbtFechaExacta.UseVisualStyleBackColor = True
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaHasta.Location = New System.Drawing.Point(157, 82)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(116, 20)
        Me.dtpFechaHasta.TabIndex = 79
        Me.dtpFechaHasta.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.CustomFormat = "dd/MM/yyyy"
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaDesde.Location = New System.Drawing.Point(8, 83)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(114, 20)
        Me.dtpFechaDesde.TabIndex = 78
        Me.dtpFechaDesde.Value = New Date(2019, 4, 23, 23, 0, 18, 0)
        '
        'lblFechaExacta
        '
        Me.lblFechaExacta.AutoSize = True
        Me.lblFechaExacta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaExacta.Location = New System.Drawing.Point(5, 66)
        Me.lblFechaExacta.Name = "lblFechaExacta"
        Me.lblFechaExacta.Size = New System.Drawing.Size(68, 13)
        Me.lblFechaExacta.TabIndex = 77
        Me.lblFechaExacta.Text = "Dia exacto"
        '
        'btnLimpiarFiltros
        '
        Me.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Control
        Me.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnLimpiarFiltros.FlatAppearance.BorderSize = 0
        Me.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarFiltros.Image = CType(resources.GetObject("btnLimpiarFiltros.Image"), System.Drawing.Image)
        Me.btnLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpiarFiltros.Location = New System.Drawing.Point(437, 26)
        Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
        Me.btnLimpiarFiltros.Size = New System.Drawing.Size(69, 81)
        Me.btnLimpiarFiltros.TabIndex = 75
        Me.btnLimpiarFiltros.Text = "Limpiar"
        Me.btnLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpiarFiltros.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(512, 26)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(69, 81)
        Me.btnBuscar.TabIndex = 76
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'cboUsuarios
        '
        Me.cboUsuarios.AccessibleDescription = ""
        Me.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUsuarios.FormattingEnabled = True
        Me.cboUsuarios.Items.AddRange(New Object() {"Física", "Jurídica"})
        Me.cboUsuarios.Location = New System.Drawing.Point(60, 19)
        Me.cboUsuarios.Name = "cboUsuarios"
        Me.cboUsuarios.Size = New System.Drawing.Size(276, 21)
        Me.cboUsuarios.TabIndex = 71
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(5, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 13)
        Me.Label17.TabIndex = 72
        Me.Label17.Text = "Usuario"
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
        Me.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvGrilla.Location = New System.Drawing.Point(0, 0)
        Me.dgvGrilla.MultiSelect = False
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.ReadOnly = True
        Me.dgvGrilla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvGrilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvGrilla.RowHeadersVisible = False
        Me.dgvGrilla.RowHeadersWidth = 56
        Me.dgvGrilla.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrilla.Size = New System.Drawing.Size(506, 347)
        Me.dgvGrilla.TabIndex = 66
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.lbldesde)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.rbtEntreFechas)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.cboUsuarios)
        Me.GroupBox1.Controls.Add(Me.rbtFechaExacta)
        Me.GroupBox1.Controls.Add(Me.dtpFechaHasta)
        Me.GroupBox1.Controls.Add(Me.dtpFechaDesde)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.lblFechaExacta)
        Me.GroupBox1.Controls.Add(Me.btnLimpiarFiltros)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 31)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(586, 121)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(552, 223)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 89)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(190, -314)
        Me.TextBox1.MaxLength = 30
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(242, 20)
        Me.TextBox1.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(13, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 15)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Ingresos"
        '
        'txtIngresos
        '
        Me.txtIngresos.Location = New System.Drawing.Point(82, 222)
        Me.txtIngresos.MaxLength = 30
        Me.txtIngresos.Name = "txtIngresos"
        Me.txtIngresos.ReadOnly = True
        Me.txtIngresos.Size = New System.Drawing.Size(107, 20)
        Me.txtIngresos.TabIndex = 91
        Me.txtIngresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(373, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Monto final"
        '
        'txtMontoFinal
        '
        Me.txtMontoFinal.Location = New System.Drawing.Point(458, 222)
        Me.txtMontoFinal.MaxLength = 30
        Me.txtMontoFinal.Name = "txtMontoFinal"
        Me.txtMontoFinal.ReadOnly = True
        Me.txtMontoFinal.Size = New System.Drawing.Size(107, 20)
        Me.txtMontoFinal.TabIndex = 89
        Me.txtMontoFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(13, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(326, 15)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Cantidad de movimientos en el período de tiempo"
        '
        'txtCantidadMov
        '
        Me.txtCantidadMov.Location = New System.Drawing.Point(346, 190)
        Me.txtCantidadMov.MaxLength = 30
        Me.txtCantidadMov.Name = "txtCantidadMov"
        Me.txtCantidadMov.ReadOnly = True
        Me.txtCantidadMov.Size = New System.Drawing.Size(219, 20)
        Me.txtCantidadMov.TabIndex = 87
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(13, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 15)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Usuarios"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(84, 157)
        Me.txtUsuario.MaxLength = 30
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(481, 20)
        Me.txtUsuario.TabIndex = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(195, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Egresos"
        '
        'txtEgresos
        '
        Me.txtEgresos.Location = New System.Drawing.Point(260, 222)
        Me.txtEgresos.MaxLength = 30
        Me.txtEgresos.Name = "txtEgresos"
        Me.txtEgresos.ReadOnly = True
        Me.txtEgresos.Size = New System.Drawing.Size(107, 20)
        Me.txtEgresos.TabIndex = 93
        Me.txtEgresos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Gestión Caja"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvGrilla)
        Me.Panel1.Controls.Add(Me.btnSalirr)
        Me.Panel1.Location = New System.Drawing.Point(16, 254)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 347)
        Me.Panel1.TabIndex = 96
        '
        'FrmGestionCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 613)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEgresos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIngresos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMontoFinal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCantidadMov)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGestionCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de caja"
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalirr As Windows.Forms.Button
    Friend WithEvents lbldesde As Windows.Forms.Label
    Friend WithEvents rbtEntreFechas As Windows.Forms.CheckBox
    Friend WithEvents lblHasta As Windows.Forms.Label
    Friend WithEvents rbtFechaExacta As Windows.Forms.CheckBox
    Friend WithEvents dtpFechaHasta As Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaDesde As Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaExacta As Windows.Forms.Label
    Friend WithEvents btnLimpiarFiltros As Windows.Forms.Button
    Friend WithEvents btnBuscar As Windows.Forms.Button
    Friend WithEvents cboUsuarios As Windows.Forms.ComboBox
    Friend WithEvents Label17 As Windows.Forms.Label
    Friend WithEvents dgvGrilla As Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents txtIngresos As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents txtMontoFinal As Windows.Forms.TextBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents txtCantidadMov As Windows.Forms.TextBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents txtUsuario As Windows.Forms.TextBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents txtEgresos As Windows.Forms.TextBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
End Class
