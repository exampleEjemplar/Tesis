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
		Me.TbPrecio = New System.Windows.Forms.TextBox()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.cmbProveedor = New System.Windows.Forms.ComboBox()
		Me.Label26 = New System.Windows.Forms.Label()
		Me.Label32 = New System.Windows.Forms.Label()
		Me.TbNombreServicio = New System.Windows.Forms.TextBox()
		Me.gboServicio = New System.Windows.Forms.GroupBox()
		Me.btnProveedor = New System.Windows.Forms.Button()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.gbousqueda = New System.Windows.Forms.GroupBox()
		Me.Button7 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.txtBusNombreProd = New System.Windows.Forms.TextBox()
		Me.lblBusApellido = New System.Windows.Forms.Label()
		Me.btnguardarmodificacion = New System.Windows.Forms.Button()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.btnNuevo = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.gboServicio.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbousqueda.SuspendLayout()
		Me.SuspendLayout()
		'
		'TbPrecio
		'
		Me.TbPrecio.Location = New System.Drawing.Point(185, 104)
		Me.TbPrecio.Margin = New System.Windows.Forms.Padding(4)
		Me.TbPrecio.Name = "TbPrecio"
		Me.TbPrecio.Size = New System.Drawing.Size(104, 23)
		Me.TbPrecio.TabIndex = 59
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label20.Location = New System.Drawing.Point(9, 107)
		Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(73, 17)
		Me.Label20.TabIndex = 58
		Me.Label20.Text = "Precio  $"
		'
		'cmbProveedor
		'
		Me.cmbProveedor.FormattingEnabled = True
		Me.cmbProveedor.Location = New System.Drawing.Point(185, 64)
		Me.cmbProveedor.Margin = New System.Windows.Forms.Padding(4)
		Me.cmbProveedor.Name = "cmbProveedor"
		Me.cmbProveedor.Size = New System.Drawing.Size(280, 25)
		Me.cmbProveedor.TabIndex = 57
		'
		'Label26
		'
		Me.Label26.AutoSize = True
		Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label26.Location = New System.Drawing.Point(9, 64)
		Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(83, 17)
		Me.Label26.TabIndex = 56
		Me.Label26.Text = "Proveedor"
		'
		'Label32
		'
		Me.Label32.AutoSize = True
		Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label32.Location = New System.Drawing.Point(9, 26)
		Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label32.Name = "Label32"
		Me.Label32.Size = New System.Drawing.Size(154, 17)
		Me.Label32.TabIndex = 55
		Me.Label32.Text = "Nombre del Servicio"
		'
		'TbNombreServicio
		'
		Me.TbNombreServicio.Location = New System.Drawing.Point(185, 24)
		Me.TbNombreServicio.Margin = New System.Windows.Forms.Padding(4)
		Me.TbNombreServicio.Name = "TbNombreServicio"
		Me.TbNombreServicio.Size = New System.Drawing.Size(443, 23)
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
		Me.gboServicio.Location = New System.Drawing.Point(13, 13)
		Me.gboServicio.Margin = New System.Windows.Forms.Padding(4)
		Me.gboServicio.Name = "gboServicio"
		Me.gboServicio.Padding = New System.Windows.Forms.Padding(4)
		Me.gboServicio.Size = New System.Drawing.Size(643, 156)
		Me.gboServicio.TabIndex = 61
		Me.gboServicio.TabStop = False
		Me.gboServicio.Text = "Gestion de servicio"
		'
		'btnProveedor
		'
		Me.btnProveedor.BackColor = System.Drawing.SystemColors.Control
		Me.btnProveedor.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_add_354
		Me.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnProveedor.FlatAppearance.BorderSize = 0
		Me.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnProveedor.Location = New System.Drawing.Point(473, 55)
		Me.btnProveedor.Margin = New System.Windows.Forms.Padding(4)
		Me.btnProveedor.Name = "btnProveedor"
		Me.btnProveedor.Size = New System.Drawing.Size(47, 43)
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
		Me.DataGridView1.EnableHeadersVisualStyles = False
		Me.DataGridView1.Location = New System.Drawing.Point(2, 479)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
		Me.DataGridView1.MultiSelect = False
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.DataGridView1.RowHeadersVisible = False
		Me.DataGridView1.RowHeadersWidth = 56
		Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(654, 208)
		Me.DataGridView1.TabIndex = 62
		'
		'gbousqueda
		'
		Me.gbousqueda.Controls.Add(Me.Button7)
		Me.gbousqueda.Controls.Add(Me.Button4)
		Me.gbousqueda.Controls.Add(Me.txtBusNombreProd)
		Me.gbousqueda.Controls.Add(Me.lblBusApellido)
		Me.gbousqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gbousqueda.Location = New System.Drawing.Point(13, 301)
		Me.gbousqueda.Margin = New System.Windows.Forms.Padding(4)
		Me.gbousqueda.Name = "gbousqueda"
		Me.gbousqueda.Padding = New System.Windows.Forms.Padding(4)
		Me.gbousqueda.Size = New System.Drawing.Size(643, 170)
		Me.gbousqueda.TabIndex = 66
		Me.gbousqueda.TabStop = False
		Me.gbousqueda.Text = "Búsqueda"
		'
		'Button7
		'
		Me.Button7.BackColor = System.Drawing.SystemColors.Control
		Me.Button7.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_checkmark_62
		Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button7.FlatAppearance.BorderSize = 0
		Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button7.Location = New System.Drawing.Point(8, 50)
		Me.Button7.Margin = New System.Windows.Forms.Padding(4)
		Me.Button7.Name = "Button7"
		Me.Button7.Size = New System.Drawing.Size(111, 112)
		Me.Button7.TabIndex = 0
		Me.Button7.Text = "Aceptar"
		Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button7.UseVisualStyleBackColor = False
		'
		'Button4
		'
		Me.Button4.BackColor = System.Drawing.SystemColors.Control
		Me.Button4.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_delete_62
		Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button4.FlatAppearance.BorderSize = 0
		Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button4.Location = New System.Drawing.Point(127, 55)
		Me.Button4.Margin = New System.Windows.Forms.Padding(4)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(107, 107)
		Me.Button4.TabIndex = 40
		Me.Button4.Text = "Cancelar"
		Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button4.UseVisualStyleBackColor = False
		'
		'txtBusNombreProd
		'
		Me.txtBusNombreProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBusNombreProd.Location = New System.Drawing.Point(94, 24)
		Me.txtBusNombreProd.Margin = New System.Windows.Forms.Padding(4)
		Me.txtBusNombreProd.Name = "txtBusNombreProd"
		Me.txtBusNombreProd.Size = New System.Drawing.Size(164, 23)
		Me.txtBusNombreProd.TabIndex = 2
		'
		'lblBusApellido
		'
		Me.lblBusApellido.AutoSize = True
		Me.lblBusApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBusApellido.Location = New System.Drawing.Point(9, 24)
		Me.lblBusApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblBusApellido.Name = "lblBusApellido"
		Me.lblBusApellido.Size = New System.Drawing.Size(64, 17)
		Me.lblBusApellido.TabIndex = 27
		Me.lblBusApellido.Text = "Nombre"
		'
		'btnguardarmodificacion
		'
		Me.btnguardarmodificacion.BackColor = System.Drawing.SystemColors.Control
		Me.btnguardarmodificacion.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_save_62
		Me.btnguardarmodificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnguardarmodificacion.FlatAppearance.BorderSize = 0
		Me.btnguardarmodificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnguardarmodificacion.Location = New System.Drawing.Point(419, 183)
		Me.btnguardarmodificacion.Margin = New System.Windows.Forms.Padding(4)
		Me.btnguardarmodificacion.Name = "btnguardarmodificacion"
		Me.btnguardarmodificacion.Size = New System.Drawing.Size(115, 116)
		Me.btnguardarmodificacion.TabIndex = 64
		Me.btnguardarmodificacion.Text = "Guardar"
		Me.btnguardarmodificacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnguardarmodificacion.UseVisualStyleBackColor = False
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
		Me.btnBuscar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.loupe_78956__1_
		Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnBuscar.FlatAppearance.BorderSize = 0
		Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscar.Location = New System.Drawing.Point(13, 177)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(108, 116)
		Me.btnBuscar.TabIndex = 65
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'btnNuevo
		'
		Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevo.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_create_document_62
		Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevo.FlatAppearance.BorderSize = 0
		Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevo.Location = New System.Drawing.Point(295, 183)
		Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevo.Name = "btnNuevo"
		Me.btnNuevo.Size = New System.Drawing.Size(116, 116)
		Me.btnNuevo.TabIndex = 63
		Me.btnNuevo.Text = "Nuevo"
		Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevo.UseVisualStyleBackColor = False
		'
		'Button2
		'
		Me.Button2.BackColor = System.Drawing.SystemColors.Control
		Me.Button2.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Location = New System.Drawing.Point(542, 183)
		Me.Button2.Margin = New System.Windows.Forms.Padding(4)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(114, 110)
		Me.Button2.TabIndex = 67
		Me.Button2.Text = "Salir"
		Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button2.UseVisualStyleBackColor = False
		'
		'FrmGestionServicio
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(679, 700)
		Me.Controls.Add(Me.btnguardarmodificacion)
		Me.Controls.Add(Me.gbousqueda)
		Me.Controls.Add(Me.btnBuscar)
		Me.Controls.Add(Me.btnNuevo)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.gboServicio)
		Me.Name = "FrmGestionServicio"
		Me.Text = "FrmGestionServicio"
		Me.gboServicio.ResumeLayout(False)
		Me.gboServicio.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbousqueda.ResumeLayout(False)
		Me.gbousqueda.PerformLayout()
		Me.ResumeLayout(False)

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
	Friend WithEvents gbousqueda As Windows.Forms.GroupBox
	Friend WithEvents Button7 As Windows.Forms.Button
	Friend WithEvents Button4 As Windows.Forms.Button
	Friend WithEvents txtBusNombreProd As Windows.Forms.TextBox
	Friend WithEvents lblBusApellido As Windows.Forms.Label
	Friend WithEvents btnBuscar As Windows.Forms.Button
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents Button2 As Windows.Forms.Button
End Class
