<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditarReparaciones
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnSalir = New System.Windows.Forms.Button()
		Me.btnguardarmodificacion = New System.Windows.Forms.Button()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.lblCliente = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.cboEstado = New System.Windows.Forms.ComboBox()
		Me.lblHasta = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.lblCosto = New System.Windows.Forms.Label()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.lblFechaPactada = New System.Windows.Forms.Label()
		Me.lblFechaPedido = New System.Windows.Forms.Label()
		Me.GroupBox5.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(13, 8)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(218, 25)
		Me.Label1.TabIndex = 58
		Me.Label1.Text = "Editar reparaciones"
		'
		'btnSalir
		'
		Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
		Me.btnSalir.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_shutdown_62
		Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnSalir.FlatAppearance.BorderSize = 0
		Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnSalir.Location = New System.Drawing.Point(18, 334)
		Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(104, 111)
		Me.btnSalir.TabIndex = 59
		Me.btnSalir.Text = "Salir"
		Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnSalir.UseVisualStyleBackColor = False
		'
		'btnguardarmodificacion
		'
		Me.btnguardarmodificacion.BackColor = System.Drawing.SystemColors.Control
		Me.btnguardarmodificacion.BackgroundImage = Global.ClaseUi.My.Resources.Resources.icons8_save_62
		Me.btnguardarmodificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btnguardarmodificacion.FlatAppearance.BorderSize = 0
		Me.btnguardarmodificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnguardarmodificacion.Location = New System.Drawing.Point(130, 334)
		Me.btnguardarmodificacion.Margin = New System.Windows.Forms.Padding(4)
		Me.btnguardarmodificacion.Name = "btnguardarmodificacion"
		Me.btnguardarmodificacion.Size = New System.Drawing.Size(101, 111)
		Me.btnguardarmodificacion.TabIndex = 62
		Me.btnguardarmodificacion.Text = "Guardar"
		Me.btnguardarmodificacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.btnguardarmodificacion.UseVisualStyleBackColor = False
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(11, 30)
		Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(58, 17)
		Me.Label17.TabIndex = 21
		Me.Label17.Text = "Cliente"
		'
		'lblCliente
		'
		Me.lblCliente.AutoSize = True
		Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCliente.Location = New System.Drawing.Point(254, 30)
		Me.lblCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCliente.Name = "lblCliente"
		Me.lblCliente.Size = New System.Drawing.Size(82, 17)
		Me.lblCliente.TabIndex = 42
		Me.lblCliente.Text = "**Cliente**"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(8, 75)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(182, 17)
		Me.Label2.TabIndex = 43
		Me.Label2.Text = "Estado de la reparación"
		'
		'cboEstado
		'
		Me.cboEstado.AccessibleDescription = ""
		Me.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboEstado.FormattingEnabled = True
		Me.cboEstado.Items.AddRange(New Object() {"Física", "Jurídica"})
		Me.cboEstado.Location = New System.Drawing.Point(257, 72)
		Me.cboEstado.Margin = New System.Windows.Forms.Padding(4)
		Me.cboEstado.Name = "cboEstado"
		Me.cboEstado.Size = New System.Drawing.Size(247, 25)
		Me.cboEstado.TabIndex = 44
		'
		'lblHasta
		'
		Me.lblHasta.AutoSize = True
		Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHasta.Location = New System.Drawing.Point(8, 118)
		Me.lblHasta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblHasta.Name = "lblHasta"
		Me.lblHasta.Size = New System.Drawing.Size(133, 17)
		Me.lblHasta.TabIndex = 46
		Me.lblHasta.Text = "Fecha del pedido"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(8, 161)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(199, 17)
		Me.Label3.TabIndex = 48
		Me.Label3.Text = "Fecha pactada de entrega"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(8, 211)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(162, 17)
		Me.Label7.TabIndex = 52
		Me.Label7.Text = "Costo presupuestado"
		'
		'lblCosto
		'
		Me.lblCosto.AutoSize = True
		Me.lblCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCosto.Location = New System.Drawing.Point(254, 211)
		Me.lblCosto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblCosto.Name = "lblCosto"
		Me.lblCosto.Size = New System.Drawing.Size(182, 17)
		Me.lblCosto.TabIndex = 53
		Me.lblCosto.Text = "**CostoPresupuestado**"
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.lblFechaPedido)
		Me.GroupBox5.Controls.Add(Me.lblFechaPactada)
		Me.GroupBox5.Controls.Add(Me.lblCosto)
		Me.GroupBox5.Controls.Add(Me.Label7)
		Me.GroupBox5.Controls.Add(Me.Label3)
		Me.GroupBox5.Controls.Add(Me.lblHasta)
		Me.GroupBox5.Controls.Add(Me.cboEstado)
		Me.GroupBox5.Controls.Add(Me.Label2)
		Me.GroupBox5.Controls.Add(Me.lblCliente)
		Me.GroupBox5.Controls.Add(Me.Label17)
		Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox5.Location = New System.Drawing.Point(13, 61)
		Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
		Me.GroupBox5.Size = New System.Drawing.Size(519, 265)
		Me.GroupBox5.TabIndex = 61
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "Búsqueda"
		'
		'lblFechaPactada
		'
		Me.lblFechaPactada.AutoSize = True
		Me.lblFechaPactada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFechaPactada.Location = New System.Drawing.Point(254, 161)
		Me.lblFechaPactada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblFechaPactada.Name = "lblFechaPactada"
		Me.lblFechaPactada.Size = New System.Drawing.Size(135, 17)
		Me.lblFechaPactada.TabIndex = 54
		Me.lblFechaPactada.Text = "**FechaPactada**"
		'
		'lblFechaPedido
		'
		Me.lblFechaPedido.AutoSize = True
		Me.lblFechaPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFechaPedido.Location = New System.Drawing.Point(254, 118)
		Me.lblFechaPedido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.lblFechaPedido.Name = "lblFechaPedido"
		Me.lblFechaPedido.Size = New System.Drawing.Size(126, 17)
		Me.lblFechaPedido.TabIndex = 55
		Me.lblFechaPedido.Text = "**FechaPedido**"
		'
		'FrmEditarReparaciones
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(556, 563)
		Me.Controls.Add(Me.btnguardarmodificacion)
		Me.Controls.Add(Me.GroupBox5)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnSalir)
		Me.Name = "FrmEditarReparaciones"
		Me.Text = "FrmEditarReparaciones"
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox5.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents btnSalir As Windows.Forms.Button
	Friend WithEvents btnguardarmodificacion As Windows.Forms.Button
	Friend WithEvents Label17 As Windows.Forms.Label
	Friend WithEvents lblCliente As Windows.Forms.Label
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents cboEstado As Windows.Forms.ComboBox
	Friend WithEvents lblHasta As Windows.Forms.Label
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents Label7 As Windows.Forms.Label
	Friend WithEvents lblCosto As Windows.Forms.Label
	Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
	Friend WithEvents lblFechaPedido As Windows.Forms.Label
	Friend WithEvents lblFechaPactada As Windows.Forms.Label
End Class
