﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCatalogo
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCatalogo))
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.CH3 = New System.Windows.Forms.CheckBox()
		Me.CH2 = New System.Windows.Forms.CheckBox()
		Me.CH1 = New System.Windows.Forms.CheckBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.CmbCategoria = New System.Windows.Forms.ComboBox()
		Me.tbBusnombre = New System.Windows.Forms.TextBox()
		Me.lblBusApellido = New System.Windows.Forms.Label()
		Me.tbBuscod = New System.Windows.Forms.TextBox()
		Me.btnBuscar = New System.Windows.Forms.Button()
		Me.lblBusNombre = New System.Windows.Forms.Label()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.GroupBox5.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.CH3)
		Me.GroupBox5.Controls.Add(Me.CH2)
		Me.GroupBox5.Controls.Add(Me.CH1)
		Me.GroupBox5.Controls.Add(Me.Button1)
		Me.GroupBox5.Controls.Add(Me.Label8)
		Me.GroupBox5.Controls.Add(Me.CmbCategoria)
		Me.GroupBox5.Controls.Add(Me.tbBusnombre)
		Me.GroupBox5.Controls.Add(Me.lblBusApellido)
		Me.GroupBox5.Controls.Add(Me.tbBuscod)
		Me.GroupBox5.Controls.Add(Me.btnBuscar)
		Me.GroupBox5.Controls.Add(Me.lblBusNombre)
		Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox5.Location = New System.Drawing.Point(28, 52)
		Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.GroupBox5.Size = New System.Drawing.Size(872, 171)
		Me.GroupBox5.TabIndex = 37
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Búsqueda"
		'
		'CH3
		'
		Me.CH3.AutoSize = True
		Me.CH3.Location = New System.Drawing.Point(481, 126)
		Me.CH3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.CH3.Name = "CH3"
		Me.CH3.Size = New System.Drawing.Size(18, 17)
		Me.CH3.TabIndex = 48
		Me.CH3.UseVisualStyleBackColor = True
		'
		'CH2
		'
		Me.CH2.AutoSize = True
		Me.CH2.Location = New System.Drawing.Point(481, 92)
		Me.CH2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.CH2.Name = "CH2"
		Me.CH2.Size = New System.Drawing.Size(18, 17)
		Me.CH2.TabIndex = 47
		Me.CH2.UseVisualStyleBackColor = True
		'
		'CH1
		'
		Me.CH1.AutoSize = True
		Me.CH1.Location = New System.Drawing.Point(481, 59)
		Me.CH1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.CH1.Name = "CH1"
		Me.CH1.Size = New System.Drawing.Size(18, 17)
		Me.CH1.TabIndex = 46
		Me.CH1.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.SystemColors.Control
		Me.Button1.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_clear_filters_60
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Location = New System.Drawing.Point(735, 38)
		Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(119, 110)
		Me.Button1.TabIndex = 44
		Me.Button1.Text = "Borrar filtro"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(75, 59)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(78, 17)
		Me.Label8.TabIndex = 37
		Me.Label8.Text = "Categoria"
		'
		'CmbCategoria
		'
		Me.CmbCategoria.FormattingEnabled = True
		Me.CmbCategoria.Location = New System.Drawing.Point(164, 55)
		Me.CmbCategoria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.CmbCategoria.Name = "CmbCategoria"
		Me.CmbCategoria.Size = New System.Drawing.Size(308, 25)
		Me.CmbCategoria.TabIndex = 36
		'
		'tbBusnombre
		'
		Me.tbBusnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbBusnombre.Location = New System.Drawing.Point(164, 121)
		Me.tbBusnombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.tbBusnombre.Name = "tbBusnombre"
		Me.tbBusnombre.Size = New System.Drawing.Size(308, 23)
		Me.tbBusnombre.TabIndex = 28
		'
		'lblBusApellido
		'
		Me.lblBusApellido.AutoSize = True
		Me.lblBusApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBusApellido.Location = New System.Drawing.Point(79, 124)
		Me.lblBusApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblBusApellido.Name = "lblBusApellido"
		Me.lblBusApellido.Size = New System.Drawing.Size(73, 17)
		Me.lblBusApellido.TabIndex = 27
		Me.lblBusApellido.Text = "Producto"
		'
		'tbBuscod
		'
		Me.tbBuscod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.tbBuscod.Location = New System.Drawing.Point(164, 89)
		Me.tbBuscod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.tbBuscod.Name = "tbBuscod"
		Me.tbBuscod.Size = New System.Drawing.Size(308, 23)
		Me.tbBuscod.TabIndex = 26
		'
		'btnBuscar
		'
		Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
		Me.btnBuscar.BackgroundImage = Global.ClaseUi.My.Resources.Resources.loupe_78956__1_
		Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnBuscar.FlatAppearance.BorderSize = 0
		Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBuscar.Location = New System.Drawing.Point(585, 38)
		Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnBuscar.Name = "btnBuscar"
		Me.btnBuscar.Size = New System.Drawing.Size(119, 110)
		Me.btnBuscar.TabIndex = 34
		Me.btnBuscar.Text = "Buscar"
		Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnBuscar.UseVisualStyleBackColor = False
		'
		'lblBusNombre
		'
		Me.lblBusNombre.AutoSize = True
		Me.lblBusNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBusNombre.Location = New System.Drawing.Point(95, 92)
		Me.lblBusNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblBusNombre.Name = "lblBusNombre"
		Me.lblBusNombre.Size = New System.Drawing.Size(58, 17)
		Me.lblBusNombre.TabIndex = 25
		Me.lblBusNombre.Text = "Codigo"
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Location = New System.Drawing.Point(1048, 69)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(119, 130)
		Me.btnSalir.TabIndex = 43
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(529, 12)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(162, 35)
		Me.Label1.TabIndex = 38
		Me.Label1.Text = "Catálogo"
		'
		'DataGridView1
		'
		Me.DataGridView1.AllowUserToAddRows = False
		Me.DataGridView1.AllowUserToDeleteRows = False
		Me.DataGridView1.AllowUserToResizeColumns = False
		Me.DataGridView1.AllowUserToResizeRows = False
		Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.DataGridView1.ColumnHeadersHeight = 45
		DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
		DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
		DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
		Me.DataGridView1.EnableHeadersVisualStyles = False
		Me.DataGridView1.Location = New System.Drawing.Point(28, 230)
		Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.DataGridView1.MultiSelect = False
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.ReadOnly = True
		Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
		Me.DataGridView1.RowHeadersVisible = False
		Me.DataGridView1.RowHeadersWidth = 68
		DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
		Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
		Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.DataGridView1.Size = New System.Drawing.Size(1204, 590)
		Me.DataGridView1.TabIndex = 39
		'
		'FrmCatalogo
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1256, 834)
		Me.ControlBox = False
		Me.Controls.Add(Me.DataGridView1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.GroupBox5)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FrmCatalogo"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Catálogo"
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
    Friend WithEvents tbBusnombre As Windows.Forms.TextBox
    Friend WithEvents lblBusApellido As Windows.Forms.Label
    Friend WithEvents tbBuscod As Windows.Forms.TextBox
    Friend WithEvents btnBuscar As Windows.Forms.Button
    Friend WithEvents lblBusNombre As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents CmbCategoria As Windows.Forms.ComboBox
    Friend WithEvents btnSalir As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents CH3 As Windows.Forms.CheckBox
    Friend WithEvents CH2 As Windows.Forms.CheckBox
    Friend WithEvents CH1 As Windows.Forms.CheckBox
End Class
