﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPedidoDeReposicion
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
		Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPedidoDeReposicion))
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.dgvProveedores = New System.Windows.Forms.DataGridView()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.btnEliminar = New System.Windows.Forms.Button()
		Me.btnNuevo = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label32 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.cboBaseCalculo = New System.Windows.Forms.ComboBox()
		Me.btnRegenerar = New System.Windows.Forms.Button()
		Me.Panel1.SuspendLayout()
		CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Panel1
		'
		Me.Panel1.Controls.Add(Me.dgvProveedores)
		Me.Panel1.Controls.Add(Me.btnSalir)
		Me.Panel1.Controls.Add(Me.btnEliminar)
		Me.Panel1.Controls.Add(Me.btnNuevo)
		Me.Panel1.Location = New System.Drawing.Point(8, 185)
		Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(789, 556)
		Me.Panel1.TabIndex = 58
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
		Me.dgvProveedores.Size = New System.Drawing.Size(685, 556)
		Me.dgvProveedores.TabIndex = 45
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Image = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnSalir.Location = New System.Drawing.Point(693, 591)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(92, 100)
		Me.btnSalir.TabIndex = 32
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'btnEliminar
		'
		Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
		Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnEliminar.FlatAppearance.BorderSize = 0
		Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEliminar.Image = Global.ClaseUi.My.Resources.Resources.icons8_cancel_621
		Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnEliminar.Location = New System.Drawing.Point(693, 110)
		Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnEliminar.Name = "btnEliminar"
		Me.btnEliminar.Size = New System.Drawing.Size(92, 101)
		Me.btnEliminar.TabIndex = 54
		Me.btnEliminar.Text = "Anular"
		Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnEliminar.UseVisualStyleBackColor = False
		'
		'btnNuevo
		'
		Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
		Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnNuevo.FlatAppearance.BorderSize = 0
		Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
		Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnNuevo.Location = New System.Drawing.Point(693, 3)
		Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4)
		Me.btnNuevo.Name = "btnNuevo"
		Me.btnNuevo.Size = New System.Drawing.Size(92, 100)
		Me.btnNuevo.TabIndex = 33
		Me.btnNuevo.Text = "Confirmar"
		Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnNuevo.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(3, 8)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(234, 25)
		Me.Label1.TabIndex = 56
		Me.Label1.Text = "Pedido de reposición"
		'
		'Label32
		'
		Me.Label32.AutoSize = True
		Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label32.Location = New System.Drawing.Point(27, 64)
		Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label32.Name = "Label32"
		Me.Label32.Size = New System.Drawing.Size(149, 17)
		Me.Label32.TabIndex = 60
		Me.Label32.Text = "Calcular en base a:"
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.cboBaseCalculo)
		Me.GroupBox1.Controls.Add(Me.btnRegenerar)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(685, 138)
		Me.GroupBox1.TabIndex = 61
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Configuración"
		'
		'cboBaseCalculo
		'
		Me.cboBaseCalculo.AccessibleDescription = ""
		Me.cboBaseCalculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboBaseCalculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboBaseCalculo.FormattingEnabled = True
		Me.cboBaseCalculo.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboBaseCalculo.Location = New System.Drawing.Point(176, 21)
		Me.cboBaseCalculo.Margin = New System.Windows.Forms.Padding(4)
		Me.cboBaseCalculo.Name = "cboBaseCalculo"
		Me.cboBaseCalculo.Size = New System.Drawing.Size(131, 25)
		Me.cboBaseCalculo.TabIndex = 62
		'
		'btnRegenerar
		'
		Me.btnRegenerar.BackColor = System.Drawing.SystemColors.Control
		Me.btnRegenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnRegenerar.FlatAppearance.BorderSize = 0
		Me.btnRegenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnRegenerar.Image = Global.ClaseUi.My.Resources.Resources.icons8_available_updates_48
		Me.btnRegenerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnRegenerar.Location = New System.Drawing.Point(576, 59)
		Me.btnRegenerar.Margin = New System.Windows.Forms.Padding(4)
		Me.btnRegenerar.Name = "btnRegenerar"
		Me.btnRegenerar.Size = New System.Drawing.Size(92, 72)
		Me.btnRegenerar.TabIndex = 55
		Me.btnRegenerar.Text = "Regenerar"
		Me.btnRegenerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnRegenerar.UseVisualStyleBackColor = False
		'
		'FrmPedidoDeReposicion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(799, 754)
		Me.Controls.Add(Me.Label32)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FrmPedidoDeReposicion"
		Me.Text = "Pedido de Reposición"
		Me.Panel1.ResumeLayout(False)
		CType(Me.dgvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Panel1 As Windows.Forms.Panel
	Friend WithEvents dgvProveedores As Windows.Forms.DataGridView
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents btnEliminar As Windows.Forms.Button
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents btnNuevo As Windows.Forms.Button
	Friend WithEvents Label32 As Windows.Forms.Label
	Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
	Friend WithEvents btnRegenerar As Windows.Forms.Button
	Friend WithEvents cboBaseCalculo As Windows.Forms.ComboBox
End Class
