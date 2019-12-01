<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditarReparacion
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEditarReparacion))
		Me.cboEstado = New System.Windows.Forms.ComboBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.lblFechaExacta = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnguardarmodificacion = New System.Windows.Forms.Button()
		Me.lblCliente = New System.Windows.Forms.Label()
		Me.lblFechaPedido = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblFechaPactada = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lblCosto = New System.Windows.Forms.Label()
		Me.Costo = New System.Windows.Forms.Label()
		Me.lblProducto = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.btnEstadistica = New System.Windows.Forms.Button()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'cboEstado
		'
		Me.cboEstado.AccessibleDescription = ""
		Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboEstado.FormattingEnabled = True
		Me.cboEstado.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboEstado.Location = New System.Drawing.Point(173, 99)
		Me.cboEstado.Margin = New System.Windows.Forms.Padding(4)
		Me.cboEstado.Name = "cboEstado"
		Me.cboEstado.Size = New System.Drawing.Size(367, 25)
		Me.cboEstado.TabIndex = 0
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(11, 102)
		Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(58, 17)
		Me.Label17.TabIndex = 21
		Me.Label17.Text = "Estado"
		'
		'lblFechaExacta
		'
		Me.lblFechaExacta.AutoSize = True
		Me.lblFechaExacta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFechaExacta.Location = New System.Drawing.Point(10, 55)
		Me.lblFechaExacta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblFechaExacta.Name = "lblFechaExacta"
		Me.lblFechaExacta.Size = New System.Drawing.Size(58, 17)
		Me.lblFechaExacta.TabIndex = 21
		Me.lblFechaExacta.Text = "Cliente"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(8, 9)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(218, 25)
		Me.Label1.TabIndex = 59
		Me.Label1.Text = "Editar reparaciones"
		'
		'btnguardarmodificacion
		'
		Me.btnguardarmodificacion.BackColor = System.Drawing.SystemColors.Control
		Me.btnguardarmodificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnguardarmodificacion.FlatAppearance.BorderSize = 0
		Me.btnguardarmodificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnguardarmodificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnguardarmodificacion.Image = Global.ClaseUi.My.Resources.Resources.icons8_save_62
		Me.btnguardarmodificacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnguardarmodificacion.Location = New System.Drawing.Point(330, 381)
		Me.btnguardarmodificacion.Margin = New System.Windows.Forms.Padding(4)
		Me.btnguardarmodificacion.Name = "btnguardarmodificacion"
		Me.btnguardarmodificacion.Size = New System.Drawing.Size(104, 93)
		Me.btnguardarmodificacion.TabIndex = 60
		Me.btnguardarmodificacion.Text = "Guardar"
		Me.btnguardarmodificacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnguardarmodificacion.UseVisualStyleBackColor = False
		'
		'lblCliente
		'
		Me.lblCliente.AutoSize = True
		Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCliente.Location = New System.Drawing.Point(170, 55)
		Me.lblCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCliente.Name = "lblCliente"
		Me.lblCliente.Size = New System.Drawing.Size(82, 17)
		Me.lblCliente.TabIndex = 61
		Me.lblCliente.Text = "**Cliente**"
		'
		'lblFechaPedido
		'
		Me.lblFechaPedido.AutoSize = True
		Me.lblFechaPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFechaPedido.Location = New System.Drawing.Point(170, 155)
		Me.lblFechaPedido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblFechaPedido.Name = "lblFechaPedido"
		Me.lblFechaPedido.Size = New System.Drawing.Size(126, 17)
		Me.lblFechaPedido.TabIndex = 63
		Me.lblFechaPedido.Text = "**FechaPedido**"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(11, 155)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(107, 17)
		Me.Label3.TabIndex = 62
		Me.Label3.Text = "Fecha Pedido"
		'
		'lblFechaPactada
		'
		Me.lblFechaPactada.AutoSize = True
		Me.lblFechaPactada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFechaPactada.Location = New System.Drawing.Point(170, 209)
		Me.lblFechaPactada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblFechaPactada.Name = "lblFechaPactada"
		Me.lblFechaPactada.Size = New System.Drawing.Size(135, 17)
		Me.lblFechaPactada.TabIndex = 65
		Me.lblFechaPactada.Text = "**FechaPactada**"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(11, 209)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(116, 17)
		Me.Label5.TabIndex = 64
		Me.Label5.Text = "Fecha Pactada"
		'
		'lblCosto
		'
		Me.lblCosto.AutoSize = True
		Me.lblCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCosto.Location = New System.Drawing.Point(170, 262)
		Me.lblCosto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCosto.Name = "lblCosto"
		Me.lblCosto.Size = New System.Drawing.Size(73, 17)
		Me.lblCosto.TabIndex = 67
		Me.lblCosto.Text = "**Costo**"
		'
		'Costo
		'
		Me.Costo.AutoSize = True
		Me.Costo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Costo.Location = New System.Drawing.Point(11, 262)
		Me.Costo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Costo.Name = "Costo"
		Me.Costo.Size = New System.Drawing.Size(49, 17)
		Me.Costo.TabIndex = 66
		Me.Costo.Text = "Costo"
		'
		'lblProducto
		'
		Me.lblProducto.AutoSize = True
		Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProducto.Location = New System.Drawing.Point(169, 314)
		Me.lblProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblProducto.Name = "lblProducto"
		Me.lblProducto.Size = New System.Drawing.Size(97, 17)
		Me.lblProducto.TabIndex = 69
		Me.lblProducto.Text = "**Producto**"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(10, 314)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(73, 17)
		Me.Label4.TabIndex = 68
		Me.Label4.Text = "Producto"
		'
		'btnEstadistica
		'
		Me.btnEstadistica.BackColor = System.Drawing.SystemColors.Control
		Me.btnEstadistica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnEstadistica.FlatAppearance.BorderSize = 0
		Me.btnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnEstadistica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEstadistica.Image = CType(resources.GetObject("btnEstadistica.Image"), System.Drawing.Image)
		Me.btnEstadistica.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnEstadistica.Location = New System.Drawing.Point(161, 380)
		Me.btnEstadistica.Margin = New System.Windows.Forms.Padding(4)
		Me.btnEstadistica.Name = "btnEstadistica"
		Me.btnEstadistica.Size = New System.Drawing.Size(144, 94)
		Me.btnEstadistica.TabIndex = 86
		Me.btnEstadistica.Text = "Estadística"
		Me.btnEstadistica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnEstadistica.UseVisualStyleBackColor = False
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSalir.Image = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnSalir.Location = New System.Drawing.Point(459, 381)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(105, 93)
		Me.btnSalir.TabIndex = 87
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'FrmEditarReparacion
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(577, 487)
		Me.Controls.Add(Me.btnSalir)
		Me.Controls.Add(Me.btnEstadistica)
		Me.Controls.Add(Me.lblProducto)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.lblCosto)
		Me.Controls.Add(Me.Costo)
		Me.Controls.Add(Me.lblFechaPactada)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.lblFechaPedido)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.lblCliente)
		Me.Controls.Add(Me.cboEstado)
		Me.Controls.Add(Me.Label17)
		Me.Controls.Add(Me.btnguardarmodificacion)
		Me.Controls.Add(Me.lblFechaExacta)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FrmEditarReparacion"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Editar Reparacion"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents cboEstado As Windows.Forms.ComboBox
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents lblFechaExacta As Windows.Forms.Label
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents btnguardarmodificacion As Windows.Forms.Button
	Friend WithEvents lblCliente As Windows.Forms.Label
	Friend WithEvents lblFechaPedido As Windows.Forms.Label
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents lblFechaPactada As Windows.Forms.Label
	Friend WithEvents Label5 As Windows.Forms.Label
	Friend WithEvents lblCosto As Windows.Forms.Label
	Friend WithEvents Costo As Windows.Forms.Label
	Friend WithEvents lblProducto As Windows.Forms.Label
	Friend WithEvents Label4 As Windows.Forms.Label
	Friend WithEvents btnEstadistica As Windows.Forms.Button
	Friend WithEvents btnSalir As Windows.Forms.Button
End Class
