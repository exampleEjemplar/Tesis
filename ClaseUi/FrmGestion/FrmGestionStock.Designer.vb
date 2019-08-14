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
		Me.dgvGrilla = New System.Windows.Forms.DataGridView()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.btnSalirr = New System.Windows.Forms.Button()
		Me.cboProveedor = New System.Windows.Forms.ComboBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.txtBusNombreProducto = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.btnLimpiarFiltros = New System.Windows.Forms.Button()
		Me.btnBuscar = New System.Windows.Forms.Button()
		CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
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
		Me.dgvGrilla.Location = New System.Drawing.Point(12, 157)
		Me.dgvGrilla.Margin = New System.Windows.Forms.Padding(4)
		Me.dgvGrilla.MultiSelect = False
		Me.dgvGrilla.Name = "dgvGrilla"
		Me.dgvGrilla.ReadOnly = True
		Me.dgvGrilla.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.dgvGrilla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.dgvGrilla.RowHeadersVisible = False
		Me.dgvGrilla.RowHeadersWidth = 56
		Me.dgvGrilla.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvGrilla.Size = New System.Drawing.Size(707, 188)
		Me.dgvGrilla.TabIndex = 56
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.Button1)
		Me.GroupBox2.Controls.Add(Me.TextBox3)
		Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
		Me.GroupBox2.Location = New System.Drawing.Point(12, 11)
		Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
		Me.GroupBox2.Size = New System.Drawing.Size(707, 28)
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
		Me.TextBox3.Location = New System.Drawing.Point(253, -386)
		Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
		Me.TextBox3.MaxLength = 30
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(321, 23)
		Me.TextBox3.TabIndex = 40
		'
		'btnSalirr
		'
		Me.btnSalirr.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalirr.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalirr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalirr.FlatAppearance.BorderSize = 0
		Me.btnSalirr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalirr.Location = New System.Drawing.Point(728, 235)
		Me.btnSalirr.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalirr.Name = "btnSalirr"
		Me.btnSalirr.Size = New System.Drawing.Size(115, 110)
		Me.btnSalirr.TabIndex = 54
		Me.btnSalirr.Text = "Salir"
		Me.btnSalirr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalirr.UseVisualStyleBackColor = False
		'
		'cboProveedor
		'
		Me.cboProveedor.AccessibleDescription = ""
		Me.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboProveedor.FormattingEnabled = True
		Me.cboProveedor.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboProveedor.Location = New System.Drawing.Point(157, 63)
		Me.cboProveedor.Margin = New System.Windows.Forms.Padding(4)
		Me.cboProveedor.Name = "cboProveedor"
		Me.cboProveedor.Size = New System.Drawing.Size(367, 25)
		Me.cboProveedor.TabIndex = 57
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(13, 66)
		Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(83, 17)
		Me.Label17.TabIndex = 59
		Me.Label17.Text = "Proveedor"
		'
		'txtBusNombreProducto
		'
		Me.txtBusNombreProducto.Location = New System.Drawing.Point(157, 107)
		Me.txtBusNombreProducto.Name = "txtBusNombreProducto"
		Me.txtBusNombreProducto.Size = New System.Drawing.Size(201, 22)
		Me.txtBusNombreProducto.TabIndex = 61
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Bold)
		Me.Label8.Location = New System.Drawing.Point(13, 113)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(128, 16)
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
		Me.btnLimpiarFiltros.Location = New System.Drawing.Point(563, 63)
		Me.btnLimpiarFiltros.Margin = New System.Windows.Forms.Padding(4)
		Me.btnLimpiarFiltros.Name = "btnLimpiarFiltros"
		Me.btnLimpiarFiltros.Size = New System.Drawing.Size(74, 76)
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
		Me.btnBuscar.Location = New System.Drawing.Point(645, 66)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(74, 73)
		Me.btnBuscar.TabIndex = 63
		Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'FrmGestionStock
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(861, 359)
		Me.Controls.Add(Me.btnLimpiarFiltros)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.txtBusNombreProducto)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.cboProveedor)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.dgvGrilla)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.btnSalirr)
		Me.Name = "FrmGestionStock"
		Me.Text = "FrmGestionStock"
		CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgvGrilla As Windows.Forms.DataGridView
	Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
	Friend WithEvents Button1 As Windows.Forms.Button
	Friend WithEvents TextBox3 As Windows.Forms.TextBox
	Friend WithEvents btnSalirr As Windows.Forms.Button
	Friend WithEvents cboProveedor As Windows.Forms.ComboBox
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents txtBusNombreProducto As Windows.Forms.TextBox
	Friend WithEvents Label8 As Windows.Forms.Label
	Friend WithEvents btnLimpiarFiltros As Windows.Forms.Button
	Friend WithEvents btnBuscar As Windows.Forms.Button
End Class
